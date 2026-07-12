using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded.Native;

public partial class WindowsFunctionResolver : FunctionResolverBase
{
    private const string Kernel32 = "kernel32";

    protected override string GetNativeLibraryName(string libraryName, int version, bool addVersionSuffixToLibraryPath) => addVersionSuffixToLibraryPath ? $"{libraryName}-{version}.dll" : $"{libraryName}.dll";

    protected override IntPtr LoadNativeLibrary(string libraryName)
    {
        IntPtr handle = LoadLibrary(libraryName);

        if (handle == IntPtr.Zero)
        {
            int errorCode = Marshal.GetLastWin32Error();
            string errorMessage = new System.ComponentModel.Win32Exception(errorCode).Message;
            throw new DllNotFoundException($"Failed to load native library '{libraryName}'. Error code: 0x{errorCode:X}, Message: {errorMessage}");
        }

        return handle;
    }

    protected override IntPtr GetFunctionPointer(IntPtr nativeLibraryHandle, string functionName) => GetProcAddress(nativeLibraryHandle, functionName);

    [LibraryImport(Kernel32, EntryPoint = "GetProcAddress", StringMarshalling = StringMarshalling.Utf8)]
    public static partial IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    [LibraryImport(Kernel32, EntryPoint = "LoadLibraryW", SetLastError = true, StringMarshalling = StringMarshalling.Utf16)]
    public static partial IntPtr LoadLibrary(string dllToLoad);
}
