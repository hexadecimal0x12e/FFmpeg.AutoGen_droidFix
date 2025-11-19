using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Native;

// call this AppleOSFunctionResolver to reflect its compatibility with all Apple OS platforms
public class AppleOSFunctionResolver : FunctionResolverBase 
{
    private const string Libdl = "libdl";

    private const int RTLD_NOW = 0x002;

    protected override string GetNativeLibraryName(string libraryName, int version, bool _) => $"lib{libraryName}.{version}.dylib";
    protected override IntPtr LoadNativeLibrary(string libraryName) => dlopen(libraryName, RTLD_NOW);
    protected override IntPtr FindFunctionPointer(IntPtr nativeLibraryHandle, string functionName) => dlsym(nativeLibraryHandle, functionName);


    [DllImport(Libdl)]
    public static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport(Libdl)]
    public static extern IntPtr dlopen(string fileName, int flag);
}
