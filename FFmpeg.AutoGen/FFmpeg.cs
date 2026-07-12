#nullable enable
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;
using System.Text.Json;

namespace FFmpeg.AutoGen;

/// <summary>
/// The main class for the FFmpeg bindings.
/// </summary>
public static partial class ffmpeg
{
    /// <summary>
    /// The EAGAIN error code constant. The actual value of this constant can vary across platforms, so it is determined at runtime based on the operating system. On most platforms, it is 11, but on Apple platforms, it is 35. This value is set during the static initialization of the <see cref="ffmpeg"/> class.
    /// </summary>
    public static readonly int EAGAIN;

    /// <summary>
    /// The ENOMEM error code constant.
    /// </summary>
    public const int ENOMEM = 12;

    /// <summary>
    /// The EINVAL error code constant.
    /// </summary>
    public const int EINVAL = 22;

    /// <summary>
    /// The EPIPE error code constant.
    /// </summary>
    public const int EPIPE = 32;

    /// <summary>
    /// Get the binding auto verification's result, which is set during the static initialization of the <see cref="ffmpeg"/> class.
    /// </summary>
    public static FFmpegBindingTestResult? BindingVerificationResult { get; internal set; }

    /// <summary>
    /// Get the release version (like n8.1) but parse to an <see cref="System.Version"/> object of the FFmpeg libraries.
    /// </summary>
    /// <remarks>
    /// As these value from <see cref="av_version_info"/> has no fixed format, it may fail to parse the version number. In that case, this method will return null. So the result of this method is not guaranteed to be non-null. Please check the result before using it.
    /// </remarks>
    /// <returns>The version, or null if the version string cannot be parsed.</returns>
    public static Version? ReleaseVersion => DynamicallyLoadedBindings.TryParseVersion(av_version_info(), out var major, out var minor) ? new Version(major, minor) : null;

    /// <summary>
    /// Return an informative version string. This usually is the actual release version number or a git commit description. This string has no fixed format and can change any time. It should never be parsed by code.
    /// </summary>
    /// <remarks>
    /// The result like this: "n8.1_some_custom_version_string"
    /// </remarks>
    public static string Version => av_version_info();
    /// <summary>
    /// Return the libavcodec build-time configuration.
    /// </summary>
    /// <remarks>
    /// The result like this: "--enable-gpl --enable-libx264 --enable-libx265 ...".
    /// </remarks>
    public static string Configuration => avcodec_configuration();

    /// <summary>
    /// Determine whether the FFmpeg libraries are licensed under GPL and not LGPL.
    /// </summary>
    public static bool IsGPLCompatible => avcodec_license().Contains("GPL") && !avcodec_license().Contains("LGPL");

    /// <summary>
    /// Indicates whether the FFmpeg bindings are ready to use. This property is set to true if the bindings have been successfully initialized.
    /// </summary>
    public static bool Ready { get; internal set; } = false;


    static ffmpeg()
    {
        var isiOSLike = OperatingSystem.IsIOS() || OperatingSystem.IsMacCatalyst() || OperatingSystem.IsWatchOS() || OperatingSystem.IsTvOS();
#if ANDROID
        Java.Lang.JavaSystem.LoadLibrary("c"); 
        var libPath = Android.App.Application.Context?.ApplicationInfo?.NativeLibraryDir;

#elif IOS || MACCATALYST || WATCHOS || TVOS
        var libPath = Foundation.NSBundle.MainBundle.BundlePath;
#else
        string libPath;
        if (OperatingSystem.IsLinux())
        {
            libPath = $"/usr/lib{(Environment.Is64BitProcess ? "64" : "")}";
        }
        else if (OperatingSystem.IsWindows())
        {
            libPath = AppDomain.CurrentDomain.BaseDirectory;
        }
        else
        {
            libPath = "";
        }
#endif

        if (!string.IsNullOrWhiteSpace(libPath) && System.IO.Directory.Exists(libPath))
        {
            RootPath = libPath;
            Debug.WriteLine($"[{FunctionResolverBase.LogHeader}] Using auto-detected library path: {libPath}");
        }
        EAGAIN = OperatingSystem.IsMacOS() || isiOSLike ? 35 : 11;

        if (DynamicallyLoadedBindings.EnableAutoInitialization)
        {
            if (!DynamicallyLoadedBindings.TryInitialize())
            {
                Ready = false;
                StringBuilder b = new();
                foreach (var item in ffmpeg.BindingVerificationResult?.Failures ?? [])
                {
                    b.AppendLine($"{item.FunctionName} in {item.LibraryName} failed: {item.Message}");
                }
                if (DynamicallyLoadedBindings.ValidateLibraryVersion())
                {
                    Debug.WriteLine($"[{FunctionResolverBase.LogHeader}] FFmpeg libraries version validation failed. ({b})");
                }
                else
                {
                    Debug.WriteLine($"[{FunctionResolverBase.LogHeader}] FFmpeg bindings validation failed. ({b})");
                }
            }
            else
            {
                Ready = true;
            }
        }

    }



    /// <summary>
    /// Gets or sets the root path for loading libraries. Default to <see cref="AppDomain.BaseDirectory"/>.
    /// You may need to set it manually to make it work with the native library importing mechanism.
    /// </summary>
    /// <remarks>
    /// <b>in .NET maui or Xamarin.Forms, if native aot is enabled or your application is trimmed, set this to 'Android.App.Application.Context.ApplicationInfo?.NativeLibraryDir' BEFORE you call any FFmpeg function;</b>
    /// <b>in any ios-Like platform (not included the 'osx' TargetPlatform, or aka MacOS), set this to 'NSBundle.MainBundle.BundlePath' BEFORE you call any FFmpeg function;</b>
    /// For other platforms, set this property to the appropriate path where your FFmpeg libraries are located.
    /// </remarks>
    /// <value>The root path.</value>
    public static string RootPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

    public static ulong UINT64_C<T>(T a)
        => Convert.ToUInt64(a);

    public static int AVERROR<T1>(T1 a)
        => -Convert.ToInt32(a);

    public static int MKTAG<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
        => (int)(Convert.ToUInt32(a) | (Convert.ToUInt32(b) << 8) | (Convert.ToUInt32(c) << 16) |
                 (Convert.ToUInt32(d) << 24));

    public static int FFERRTAG<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
        => -MKTAG(a, b, c, d);

    public static int AV_VERSION_INT<T1, T2, T3>(T1 a, T2 b, T3 c) =>
        (Convert.ToInt32(a) << 16) | (Convert.ToInt32(b) << 8) | Convert.ToInt32(c);

    public static string AV_VERSION_DOT<T1, T2, T3>(T1 a, T2 b, T3 c)
        => $"{a}.{b}.{c}";

    public static string AV_VERSION<T1, T2, T3>(T1 a, T2 b, T3 c)
        => AV_VERSION_DOT(a, b, c);
}
