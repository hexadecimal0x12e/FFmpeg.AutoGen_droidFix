using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Native;

public class LinuxFunctionResolver : FunctionResolverBase
{
    /// <summary>
    /// Represents the dlsym() function from the libdl library
    /// </summary>
    /// <remarks>
    /// You'll need to reassign this delegate to point if your target platform doesn't have 'libdl.so.2' or if it's named differently.
    /// </remarks>
    public static Func<IntPtr,string,IntPtr> DlsymFunc = dlsym;

    /// <summary>
    /// Represents the dlopen() function from the libdl library
    /// </summary>
    /// <remarks>
    /// You'll need to reassign this delegate to point if your target platform doesn't have 'libdl.so.2' or if it's named differently.
    /// </remarks>
    public static Func<string,int,IntPtr> DlopenFunc = dlopen;

    private const int RTLD_NOW = 0x002;

    protected override string GetNativeLibraryName(string libraryName, int version, bool addVersionSuffixToLibraryPath) => addVersionSuffixToLibraryPath ? $"lib{libraryName}.so.{version}" : $"lib{libraryName}.so";

    protected override IntPtr LoadNativeLibrary(string libraryName) => DlopenFunc(libraryName, RTLD_NOW);

    protected override IntPtr FindFunctionPointer(IntPtr nativeLibraryHandle, string functionName) => DlsymFunc(nativeLibraryHandle, functionName);

    [DllImport("libdl.so.2")]
    private static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport("libdl.so.2")]
    private static extern IntPtr dlopen(string fileName, int flag);

}
