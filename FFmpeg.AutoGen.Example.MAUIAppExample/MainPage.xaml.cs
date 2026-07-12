using projectFrameCut.Render;
using System.Diagnostics;

namespace FFmpeg.AutoGen.Example.MAUIAppExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Task.Run(() =>
            {
                string verStr = string.Empty;
                try
                {
                    DynamicallyLoadedBindings.Initialize(OperatingSystem.IsWindows());
                    verStr = $"FFmpeg library: version {ffmpeg.av_version_info()}, {ffmpeg.avcodec_license()}\r\nconfiguration:{ffmpeg.avcodec_configuration()}\r\nThis will become the video's info you selected later on.";
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                    verStr = $"Error getting FFmpeg version info: {ex.Message}";
                }
                Dispatcher.Dispatch(() => FFmpegInfoEntry.Text = verStr);
                DynamicallyLoadedBindings.Initialize();
                if (ffmpeg.BindingVerificationResult?.IsSuccess != true)
                {
                    string errorStr = "Failed to initialize FFmpeg dynamically loaded bindings.\r\n";
                    if (ffmpeg.BindingVerificationResult != null)
                    {
                        foreach (var item in ffmpeg.BindingVerificationResult.Failures)
                        {
                            errorStr += $"{item.FunctionName} in {item.LibraryName} failed: {item.Message}\r\n";
                        }
                    }
                    else
                    {
                        errorStr += "No binding verification result available.";
                    }
                    Dispatcher.Dispatch(() => DisplayAlertAsync("Error", errorStr, "OK"));
                }

            }).ContinueWith((_) => Dispatcher.Dispatch(() => LoadingIndicator.IsRunning = false));
        }

        string inPath = string.Empty;

        private VideoDecoder? VideoDecoder = null;

        private async void OpenVideoBtn_Clicked(object sender, EventArgs e)
        {
            var result = await FilePicker.Default.PickAsync();
            if (result != null)
            {
                inPath = result.FullPath;
                VideoPathEntry.Text = inPath;
                try
                {
                    VideoDecoder = new VideoDecoder(inPath);
                    var info = $"Video info:\r\n" +
                        $"Width: {VideoDecoder.Width}\r\n" +
                        $"Height: {VideoDecoder.Height}\r\n" +
                        $"Frame rate: {VideoDecoder.Fps}\r\n" +
                        $"Total frames: {VideoDecoder.TotalFrames}\r\n";
                    Dispatcher.Dispatch(() =>
                    {
                        FFmpegInfoEntry.Text = info;
                    });

                }
                catch (Exception ex)
                {
                    await DisplayAlertAsync("Error", $"Failed to open video file: {ex.Message}", "OK");
                }
            }
        }

        private void ExtractButton_Clicked(object sender, EventArgs e)
        {
            if (uint.TryParse(FrameIndexEntry.Text, out var frame))
            {
                if (VideoDecoder == null)
                {
                    DisplayAlertAsync("Error", "No video loaded. Please open a video file first.", "OK");
                    return;
                }
                try
                {
                    var image = VideoDecoder.GetFrame(frame);
                    ExtractedFrameImage.Source = image;
                }
                catch (Exception ex)
                {
                    DisplayAlertAsync("Error", $"Failed to extract frame: {ex.Message}", "OK");
                }

            }
            else
            {
                DisplayAlertAsync("Error", "Invalid frame index. Please enter a valid number.", "OK");
            }
        }
    }

}
