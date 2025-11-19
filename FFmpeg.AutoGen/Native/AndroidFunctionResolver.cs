using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Native;

public class AndroidFunctionResolver : FunctionResolverBase
{
    private const int RTLD_NOW = 0x002;

    protected override string GetNativeLibraryName(string libraryName, int version, bool _) => $"lib{libraryName}.so";

    protected override IntPtr LoadNativeLibrary(string libraryName)
    {
        var handle = dlopen(libraryName, RTLD_NOW);
        if (handle == IntPtr.Zero)
        {
            var error = Marshal.PtrToStringAnsi(dlerror());
            throw new DllNotFoundException($"Failed to load {libraryName}: {error}");
        }
        return handle;
    }

    protected override IntPtr FindFunctionPointer(IntPtr nativeLibraryHandle, string functionName)
    {
        if (NativeLibrary.TryGetExport(nativeLibraryHandle, functionName, out var address))
        {
            return address;
        }
        return dlsym(nativeLibraryHandle, functionName);
    }

    [DllImport("c")]
    private static extern IntPtr dlsym(IntPtr handle, string symbol);

    [DllImport("c")]
    private static extern IntPtr dlopen(string fileName, int flag);

    [DllImport("c")]
    private static extern IntPtr dlerror();
}
