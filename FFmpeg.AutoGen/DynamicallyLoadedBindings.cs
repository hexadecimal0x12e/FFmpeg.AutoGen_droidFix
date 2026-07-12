using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FFmpeg.AutoGen
{
    /// <summary>
    /// The class for configure the dynamically loaded FFmpeg bindings.
    /// </summary>
    public static partial class DynamicallyLoadedBindings
    {
        /// <summary>
        /// Automatic initialize of FFmpeg bindings. If set to true, the bindings will be initialized and validated automatically when any FFmpeg function is called for the first time.
        /// </summary>
        public static bool EnableAutoInitialization { get; set; } = true;

        /// <summary>
        /// Validate the release version (like n8.0.1) of the FFmpeg libraries against the target version defined inside the code. As the string has a no fixed format, so set this to false can disable this check.
        /// </summary>
        public static bool ValidateReleaseVersion { get; set; } = false;

        /// <summary>
        /// The target FFmpeg's major version.
        /// </summary>
        internal const int TargetFFmpegMajorVersion = 8;
        /// <summary>
        /// The target FFmpeg's minor version.
        /// </summary>
        internal const int TargetFFmpegMinorVersion = 1;

        /// <summary>
        /// Try to initialize the FFmpeg bindings and validate the library versions.
        /// </summary>
        /// <returns>
        /// true if the initialization and validation succeed, otherwise false.
        /// </returns>
        public static bool TryInitialize()
        {
            FunctionResolver = FunctionResolverFactory.Create();
            ffmpeg.BindingVerificationResult = FFmpegBindingTest.VerifyDynamicallyLoadedBindings();
            if (!ValidateLibraryVersion() || !ffmpeg.BindingVerificationResult?.IsSuccess == true)
                return false;
            LoadBinding();
            return ffmpeg.BindingVerificationResult.IsSuccess;
        }

        /// <summary>
        /// Initialize the FFmpeg bindings.
        /// </summary>
        /// <remarks>
        /// note that this method does not validate the library versions. 
        /// If you want to validate the library versions, use the Initialize(bool enableAutoValidation) method instead.
        /// </remarks>
        public static void Initialize()
        {
            FunctionResolver = FunctionResolverFactory.Create();
            LoadBinding();
        }

        /// <summary>
        /// Initialize the FFmpeg bindings and optionally validate the library versions.
        /// </summary>
        public static void Initialize(bool enableBindingValidation = true, bool enableVersionValidation = true)
        {
            FunctionResolver = FunctionResolverFactory.Create();
            LoadBinding();
            if (enableBindingValidation) ffmpeg.BindingVerificationResult = FFmpegBindingTest.VerifyDynamicallyLoadedBindings();
            if (enableVersionValidation) ValidateLibraryVersion();  
        }

        /// <summary>
        /// Validate the version of each FFmpeg library against the expected version defined in the code. If ValidateReleaseVersion is true, also validate the FFmpeg release version string.
        /// </summary>
        /// <returns>True for success, false otherwise.</returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static bool ValidateLibraryVersion()
        {
            if (FunctionResolver is null) return false;
            bool success = true;
            foreach (var expectedLibraryVersion in ffmpeg.LibraryVersionMap)
            {
                var libraryName = expectedLibraryVersion.Key;
                var expectedMajor = expectedLibraryVersion.Value;
                var actualVersionInt = GetLibraryVersionInt(libraryName);
                var actualMajor = (int)((actualVersionInt >> 16) & 0xFF);

                if (actualMajor != expectedMajor)
                {
                    ffmpeg.BindingVerificationResult?.AppendResult(new FFmpegBindingTestFailure(libraryName, $"{libraryName}_version", $"Version mismatch for {libraryName}. Expected major version {expectedMajor}, but found {actualMajor}."));
                    success = false;
                }
            }

            if (ValidateReleaseVersion)
            {
                var versionInfoDelegate = Marshal.GetDelegateForFunctionPointer<vectors.av_version_info_delegate>(FunctionResolver.GetFunctionPointer("avutil", "av_version_info"));
                var versionInfo = versionInfoDelegate();
                if (!TryParseVersion(versionInfo, out var actualMajorVersion, out var actualMinorVersion))
                {
                    return false;
                }

                if (actualMajorVersion != TargetFFmpegMajorVersion || actualMinorVersion != TargetFFmpegMinorVersion)
                {
                    ffmpeg.BindingVerificationResult.AppendResult(new FFmpegBindingTestFailure("FFmpeg", "Version", $"FFmpeg release version mismatch. Expected {TargetFFmpegMajorVersion}.{TargetFFmpegMinorVersion}.x, but found {versionInfo}."));
                    success = false;
                }
            }
            return success;
        }

        private static uint GetLibraryVersionInt(string libraryName)
        {
            return libraryName switch
            {
                "avcodec" => Marshal.GetDelegateForFunctionPointer<vectors.avcodec_version_delegate>(FunctionResolver.GetFunctionPointer("avcodec", "avcodec_version"))(),
                "avdevice" => Marshal.GetDelegateForFunctionPointer<vectors.avdevice_version_delegate>(FunctionResolver.GetFunctionPointer("avdevice", "avdevice_version"))(),
                "avfilter" => Marshal.GetDelegateForFunctionPointer<vectors.avfilter_version_delegate>(FunctionResolver.GetFunctionPointer("avfilter", "avfilter_version"))(),
                "avformat" => Marshal.GetDelegateForFunctionPointer<vectors.avformat_version_delegate>(FunctionResolver.GetFunctionPointer("avformat", "avformat_version"))(),
                "avutil" => Marshal.GetDelegateForFunctionPointer<vectors.avutil_version_delegate>(FunctionResolver.GetFunctionPointer("avutil", "avutil_version"))(),
                "swresample" => Marshal.GetDelegateForFunctionPointer<vectors.swresample_version_delegate>(FunctionResolver.GetFunctionPointer("swresample", "swresample_version"))(),
                "swscale" => Marshal.GetDelegateForFunctionPointer<vectors.swscale_version_delegate>(FunctionResolver.GetFunctionPointer("swscale", "swscale_version"))(),
                _ => throw new NotSupportedException($"No version function mapping defined for library '{libraryName}'.")
            };
        }

        internal static bool TryParseVersion(string version, out int major, out int minor)
        {
            major = 0;
            minor = 0;

            if (string.IsNullOrWhiteSpace(version)) return false;

            var parts = version.Split('.');
            if (parts.Length < 2) return false;

            return TryParseLeadingInt(parts[0], out major) && TryParseLeadingInt(parts[1], out minor);
        }

        private static bool TryParseLeadingInt(string text, out int value)
        {
            value = 0;
            if (string.IsNullOrWhiteSpace(text)) return false;

            var end = 0;
            while (end < text.Length && char.IsDigit(text[end])) end++;
            if (end == 0) return false;

            return int.TryParse(text.Substring(0, end), out value);
        }
    }
}
