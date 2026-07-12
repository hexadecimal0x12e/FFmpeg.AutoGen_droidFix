using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Native;

public class AndroidFunctionResolver : FunctionResolverBase
{
    protected override string GetNativeLibraryName(string libraryName, int version, bool _) => $"lib{libraryName}.so";

    protected override IntPtr LoadNativeLibrary(string libraryName) => NativeLibrary.Load(libraryName);

    protected override IntPtr GetFunctionPointer(IntPtr nativeLibraryHandle, string functionName)
        => NativeLibrary.TryGetExport(nativeLibraryHandle, functionName, out var address) ? address : IntPtr.Zero;
}
