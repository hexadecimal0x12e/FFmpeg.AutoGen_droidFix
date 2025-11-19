using Microsoft.Extensions.Logging;
using System.Diagnostics;

#if ANDROID
using Java.Lang;
#endif

namespace FFmpeg.AutoGen.Example.MAUIAppExample
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

#if ANDROID
            var nativeLibDir = Android.App.Application.Context.ApplicationInfo.NativeLibraryDir;
            Debug.WriteLine($"Native library dir: {nativeLibDir}");
            ffmpeg.RootPath = nativeLibDir;
            JavaSystem.LoadLibrary("c");
            FFmpeg.AutoGen.DynamicallyLoadedBindings.ThrowErrorIfFunctionNotFound = true;
            FFmpeg.AutoGen.DynamicallyLoadedBindings.Initialize();
#elif WINDOWS
            var current = Environment.CurrentDirectory;
            var probe = Path.Combine("FFmpeg", "bin", Environment.Is64BitProcess ? "x64" : "x86");

            while (current != null)
            {
                var ffmpegBinaryPath = Path.Combine(current, probe);

                if (Directory.Exists(ffmpegBinaryPath))
                {
                    Debug.WriteLine($"FFmpeg binaries found in: {ffmpegBinaryPath}");
                    ffmpeg.RootPath = ffmpegBinaryPath;
                }

                current = Directory.GetParent(current)?.FullName;
            }
#endif


            return builder.Build();
        }
    }
}
