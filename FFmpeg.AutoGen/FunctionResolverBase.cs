using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;


public abstract class FunctionResolverBase : IFunctionResolver
{
    /// <summary>
    /// This is also a change by me that make it compatible with .NET MAUI's Android native library importing mechanism.
    /// Gets or sets a value indicating whether a version suffix should be appended to the library path when resolving
    /// assemblies. 
    /// </summary>
    /// <remarks>Set this property to <see langword="true"/> to include the version information in the library
    /// path, which can help differentiate between multiple versions of the same library. Set to <see langword="false"/>
    /// to omit the version suffix.</remarks>
    public static bool AddVersionSuffixToLibraryPath { get; set; } = true;

    public static readonly Dictionary<string, string[]> LibraryDependenciesMap =
        new()
        {
            { "avcodec", new[] { "avutil", "swresample" } },
            { "avdevice", new[] { "avcodec", "avfilter", "avformat", "avutil" } },
            { "avfilter", new[] { "avcodec", "avformat", "avutil", "postproc", "swresample", "swscale" } },
            { "avformat", new[] { "avcodec", "avutil" } },
            { "avutil", new string[] { } },
            { "postproc", new[] { "avutil" } },
            { "swresample", new[] { "avutil" } },
            { "swscale", new[] { "avutil" } }
        };

    private readonly Dictionary<string, IntPtr> _loadedLibraries = new();

    private readonly object _syncRoot = new();

    public T GetFunctionDelegate<T>(string libraryName, string functionName, bool throwOnError = true)
    {
        var nativeLibraryHandle = GetOrLoadLibrary(libraryName, throwOnError);
        return GetFunctionDelegate<T>(nativeLibraryHandle, functionName, throwOnError);
    }

    public T GetFunctionDelegate<T>(IntPtr nativeLibraryHandle, string functionName, bool throwOnError)
    {
        var functionPointer = FindFunctionPointer(nativeLibraryHandle, functionName);

        if (functionPointer == IntPtr.Zero)
        {
            if (throwOnError) throw new EntryPointNotFoundException($"Could not find the entrypoint for {functionName}.");
            return default;
        }

#if NETSTANDARD2_0_OR_GREATER
        try
        {
            return Marshal.GetDelegateForFunctionPointer<T>(functionPointer);
        }
        catch (MarshalDirectiveException)
        {
            if (throwOnError)
                throw;
            return default;
        }
#else
        return (T)(object)Marshal.GetDelegateForFunctionPointer(functionPointer, typeof(T));
#endif
    }

    public IntPtr GetOrLoadLibrary(string libraryName, bool throwOnError)
    {
        Debug.WriteLine($"Requesting library {libraryName}");
        if (_loadedLibraries.TryGetValue(libraryName, out var ptr)) return ptr;

        lock (_syncRoot)
        {
            if (_loadedLibraries.TryGetValue(libraryName, out ptr)) return ptr;

            var dependencies = LibraryDependenciesMap[libraryName];
            foreach (var item in dependencies.Where(n => !_loadedLibraries.ContainsKey(n) && !n.Equals(libraryName)))
            {
                Debug.WriteLine($"Loading dependency {item} for {libraryName}");
                GetOrLoadLibrary(item, false);
            }
                //.ToList()
                //.ForEach(n => GetOrLoadLibrary(n, false));

            var version = ffmpeg.LibraryVersionMap[libraryName];
            string nativeLibraryName = GetNativeLibraryName(libraryName, version, AddVersionSuffixToLibraryPath);

            var libraryPath = Path.Combine(ffmpeg.RootPath, nativeLibraryName);
            if (!File.Exists(libraryPath))
            {
                try
                {
                    ptr = LoadNativeLibrary(libraryName);
                }
                catch(Exception ex)
                {
                    throw new DllNotFoundException($"The {libraryName} located at {libraryPath} does not actually exist, and it is also not in the default location or the library failed to load from the default location."); //no one wants to see a DllNotFoundException with a very confused message 'libdl.so.2'
                }
            }
            else
            {
                try
                {
                    ptr = LoadNativeLibrary(libraryPath);
                }
                catch (Exception ex)
                {
                    try
                    {
                        ptr = LoadNativeLibrary(libraryName);

                    }
                    catch (Exception ex1)
                    {
                        throw new DllNotFoundException($"The {libraryName} located at {libraryPath} and this library in the default location is all failed to load.", new AggregateException([ex,ex1]));
                    }
                    
                }
            }


            if (ptr != IntPtr.Zero) _loadedLibraries.Add(libraryName, ptr);
            else if (throwOnError)
            {
                throw new EntryPointNotFoundException(
                    $"Unable to load DLL {libraryPath} under {ffmpeg.RootPath}: The specified module could not be found.");
            }

            return ptr;
        }
    }

    protected abstract string GetNativeLibraryName(string libraryName, int version, bool addVersionSuffixToLibraryPath);
    protected abstract IntPtr LoadNativeLibrary(string libraryName);
    protected abstract IntPtr FindFunctionPointer(IntPtr nativeLibraryHandle, string functionName);
}
