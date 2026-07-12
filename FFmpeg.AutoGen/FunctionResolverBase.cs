using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

[DebuggerNonUserCode]
public abstract class FunctionResolverBase : IFunctionResolver
{
    /// <summary>
    /// Gets or sets a value indicating whether a version suffix should be appended to the library path when resolving
    /// assemblies.
    /// </summary>
    /// <remarks>Set this property to <see langword="true"/> to include the version information in the library
    /// path, which can help differentiate between multiple versions of the same library. Set to <see langword="false"/>
    /// to omit the version suffix.</remarks>
    public static bool AddVersionSuffixToLibraryPath { get; set; } = true;

    /// <summary>
    /// Gets or sets a value indicating whether the library pointer should be cached after loading.
    /// </summary>
    /// <remarks>
    /// Set this property to <see langword="true"/> to cache the library pointer after loading, which can improve performance.
    /// </remarks>
    public static bool CacheLibraryPointer { get; set; } = true;

    internal static string LogHeader = "";

    static FunctionResolverBase()
    {
        var assembly = Assembly.GetExecutingAssembly().GetName();
        LogHeader = $"{assembly.Name} v{assembly.Version}";
    }

    public static readonly Dictionary<string, string[]> LibraryDependenciesMap =
        new()
        {
            { "avcodec", new[] { "avutil", "swresample" } },
            { "avdevice", new[] { "avcodec", "avfilter", "avformat", "avutil" } },
            { "avfilter", new[] { "avcodec", "avformat", "avutil", "swresample", "swscale" } },
            { "avformat", new[] { "avcodec", "avutil" } },
            { "avutil", Array.Empty<string>() },
            { "swresample", new[] { "avutil" } },
            { "swscale", new[] { "avutil" } }
        };

    private readonly Dictionary<string, IntPtr> _loadedLibraries = new();

    private readonly object _syncRoot = new();

    public IntPtr GetFunctionPointer(string libraryName, string functionName, bool throwOnError = true)
    {
        var nativeLibraryHandle = GetOrLoadLibrary(libraryName, throwOnError);
        var functionPointer = GetFunctionPointer(nativeLibraryHandle, functionName);

        if (functionPointer == IntPtr.Zero)
        {
            if (throwOnError) throw new EntryPointNotFoundException($"Could not find the entrypoint for {functionName}.");
            return default;
        }

        return functionPointer;
    }

    protected abstract string GetNativeLibraryName(string libraryName, int version, bool addVersionSuffixToLibraryPath);
    protected abstract IntPtr LoadNativeLibrary(string libraryName);
    protected abstract IntPtr GetFunctionPointer(IntPtr nativeLibraryHandle, string functionName);

    private IntPtr GetOrLoadLibrary(string libraryName, bool throwOnError)
    {
        Debug.WriteLine($"[{LogHeader}] Requesting library {libraryName}");
        if (_loadedLibraries.TryGetValue(libraryName, out var ptr)) return ptr;

        lock (_syncRoot)
        {
            if (CacheLibraryPointer && _loadedLibraries.TryGetValue(libraryName, out ptr)) return ptr;

            if (!LibraryDependenciesMap.TryGetValue(libraryName, out var dependencies))
                throw new DllNotFoundException($"Could not found library {libraryName}'s dependencies.");
            foreach (var item in dependencies.Where(n => !_loadedLibraries.ContainsKey(n) && !n.Equals(libraryName)))
            {
                Debug.WriteLine($"[{LogHeader}] Loading dependency {item} for {libraryName}");
                GetOrLoadLibrary(item, false);
            }

            var version = ffmpeg.LibraryVersionMap[libraryName];
            string nativeLibraryName = GetNativeLibraryName(libraryName, version, AddVersionSuffixToLibraryPath);
            var libraryPath = Path.Combine(ffmpeg.RootPath, nativeLibraryName);
            if (File.Exists(libraryPath))
            {
                try
                {
                    ptr = LoadNativeLibrary(libraryPath);
                }
                catch (Exception ex)
                {
                    throw new BadImageFormatException($"Could not load {libraryName} because '{ex.Message}'.", ex);
                }
            }
            else
            {
                throw new DllNotFoundException($"The {libraryName} is not found at {ffmpeg.RootPath}.");
            }

            if (ptr != IntPtr.Zero && CacheLibraryPointer) _loadedLibraries.Add(libraryName, ptr);
            else if (throwOnError)
                throw new EntryPointNotFoundException(
                    $"Unable to load DLL {libraryPath} under {ffmpeg.RootPath}: The specified module could not be found.");

            return ptr;
        }
    }
}
