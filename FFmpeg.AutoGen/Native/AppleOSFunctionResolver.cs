using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Native;

// call this AppleOSFunctionResolver to reflect its compatibility with all Apple OS platforms
public class AppleOSFunctionResolver : FunctionResolverBase
{
    protected override string GetNativeLibraryName(string libraryName, int version, bool addVersionSuffixToLibraryPath) => addVersionSuffixToLibraryPath ? $"lib{libraryName}.{version}.dylib" : $"lib{libraryName}.dylib";

    protected override IntPtr LoadNativeLibrary(string libraryName) => NativeLibrary.Load(libraryName);

    protected override IntPtr GetFunctionPointer(IntPtr nativeLibraryHandle, string functionName)
        => NativeLibrary.TryGetExport(nativeLibraryHandle, functionName, out var address) ? address : IntPtr.Zero;

}
