using FFmpeg.AutoGen.Bindings.DynamicallyLoaded.Native;
using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen.Bindings.DynamicallyLoaded;

public static class FunctionResolverFactory
{
    public static IFunctionResolver Create()
    {
        if (OperatingSystem.IsWindows()) return new WindowsFunctionResolver();
        if (OperatingSystem.IsLinux()) return new LinuxFunctionResolver();
        if (OperatingSystem.IsMacOS() || OperatingSystem.IsIOS() || OperatingSystem.IsMacCatalyst() || OperatingSystem.IsTvOS() || OperatingSystem.IsWatchOS()) return new AppleOSFunctionResolver();
        if (OperatingSystem.IsAndroid()) return new AndroidFunctionResolver();
        throw new PlatformNotSupportedException($"Your platform is not supported yet. Implement a resolver for your platform by yourself.");
    }
}
