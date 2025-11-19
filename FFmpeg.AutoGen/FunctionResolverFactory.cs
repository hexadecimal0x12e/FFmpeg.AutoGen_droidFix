using FFmpeg.AutoGen.Native;
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

public static class FunctionResolverFactory
{
    public static PlatformID GetPlatformId()
    {
#if NETSTANDARD2_1_OR_GREATER
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) return PlatformID.Win32NT;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) return PlatformID.Unix;
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) return PlatformID.MacOSX;
#else
        return Environment.OSVersion.Platform;

#endif
        throw new PlatformNotSupportedException();

    }

    public static IFunctionResolver Create()
    {
#if NETCOREAPP2_0_OR_GREATER
        if (OperatingSystem.IsWindows()) return new WindowsFunctionResolver();
        if (OperatingSystem.IsLinux()) return new LinuxFunctionResolver();
        if (OperatingSystem.IsMacOS() || OperatingSystem.IsIOS() || OperatingSystem.IsMacCatalyst() || OperatingSystem.IsTvOS() || OperatingSystem.IsWatchOS()) return new AppleOSFunctionResolver();
        if (OperatingSystem.IsAndroid()) return new AndroidFunctionResolver();
        throw new PlatformNotSupportedException($"Your platform is not supported yet.");
#else
        switch (GetPlatformId())
        {
            case PlatformID.MacOSX:
                return new MacFunctionResolver();
            case PlatformID.Unix:
                return new LinuxFunctionResolver();
            case PlatformID.Win32NT:
                return new WindowsFunctionResolver();
            default:
                throw new PlatformNotSupportedException($"Your platform is not supported yet.");
        }

#endif
    }
}
