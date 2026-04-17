using FFmpeg.AutoGen;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.ColorSpaces;
using SixLabors.ImageSharp.PixelFormats;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace projectFrameCut.Render
{

    public sealed unsafe class VideoDecoder : IDisposable //from projectFrameCut
    {
        private readonly string _path;
        private AVFormatContext* _fmt = null;
        private AVCodecContext* _codec = null;
        private long _totalFrames;
        private SwsContext* _sws = null;
        private AVPacket* _pkt = null;
        private AVFrame* _frm = null;
        private AVFrame* _rgb = null;
        private byte* _rgbBuffer = null;
        private bool _eof = false;

        private int _videoStreamIndex = -1;
        private int _width = -1;
        private int _height = -1;
        private double _fps = 0.0;
        private int _currentFrameNumber = 0;
        private bool flushSent = false;


        public bool Disposed { get; private set; }
        public bool Initialized { get; private set; } = false;

        public long TotalFrames => _totalFrames;

        public double Fps => _fps;

        public int Width => _width;

        public int Height => _height;

        public uint Index { get; set; } = 0;

        public VideoDecoder(string path)
        {
            if (!File.Exists(path)) throw new FileNotFoundException($"video file {path} is not exist.");
            _path = path ?? throw new ArgumentNullException(nameof(path));
            Initialize();
        }

        public void Initialize()
        {
            if (Initialized) throw new InvalidOperationException("DecoderContext has already been initialized.");
            try
            {
                _fmt = ffmpeg.avformat_alloc_context();
                if (_fmt == null) throw new InvalidOperationException("Failed to alloc a context for the Renderer. Please try reboot your device, or reinstall projectFrameCut.");


                fixed (AVFormatContext** fmtPtr = &_fmt)
                {
                    int averr = 0;
                    if ((averr = ffmpeg.avformat_open_input(fmtPtr, _path, null, null)) != 0)
                    {
                        const int AV_ERROR_MAX_STRING_SIZE = 1024;
                        byte* buffer = stackalloc byte[AV_ERROR_MAX_STRING_SIZE];
                        ffmpeg.av_strerror(averr, buffer, (ulong)AV_ERROR_MAX_STRING_SIZE);
                        var errStr = Marshal.PtrToStringAnsi((IntPtr)buffer);
                        throw new InvalidOperationException($"Failed to open video file '{_path}': {errStr}");
                    }
                }

                if (ffmpeg.avformat_find_stream_info(_fmt, null) != 0)
                    throw new InvalidDataException($"File '{_path}' seems don't like a multimedia file.");

                for (int i = 0; i < _fmt->nb_streams; i++)
                {
                    if (_fmt->streams[i]->codecpar->codec_type == AVMediaType.AVMEDIA_TYPE_VIDEO)
                    {
                        _videoStreamIndex = i;
                        break;
                    }
                }

                if (_videoStreamIndex < 0)
                    throw new InvalidDataException($"File '{_path}' seems don't like a video file. ");

                AVCodecParameters* par = _fmt->streams[_videoStreamIndex]->codecpar;
                AVCodec* codec = ffmpeg.avcodec_find_decoder(par->codec_id);
                if (codec == null)
                    throw new NotSupportedException("No suitable decoder found. Try encode your video again to another format.");

                _codec = ffmpeg.avcodec_alloc_context3(codec);
                if (_codec == null) throw new InvalidOperationException("Failed to alloc a context.");

                ffmpeg.avcodec_parameters_to_context(_codec, par);
                if (ffmpeg.avcodec_open2(_codec, codec, null) < 0)
                    throw new NotSupportedException("Failed to open decoder. ");

                _pkt = ffmpeg.av_packet_alloc();
                _frm = ffmpeg.av_frame_alloc();
                _rgb = ffmpeg.av_frame_alloc();
                if (_pkt == null || _frm == null || _rgb == null)
                    throw new OutOfMemoryException($"Failed to allocate enough memory space to process the video '{_path}'. Try closing other programs, restarting your device, increasing page file size (on Windows platforms)/swapping files (on Linux platforms), or adding more RAM on your device if possible.");


                _width = _codec->width;
                _height = _codec->height;


                AVRational fr = _codec->framerate;
                if (fr.num == 0 || fr.den == 0)
                    fr = _fmt->streams[_videoStreamIndex]->avg_frame_rate;
                if (fr.num == 0 || fr.den == 0)
                    fr = _fmt->streams[_videoStreamIndex]->r_frame_rate;

                _fps = fr.den != 0 ? ffmpeg.av_q2d(fr) : 0.0;



                if (_width <= 0 || _height <= 0)
                    throw new InvalidDataException($"Video file is invalid.");

                if (_fps <= 0)
                    throw new InvalidDataException($"The file '{_path}' is more like a single frame media, like a photo, rather than a video. If you're sure this file is a video, try encoding it again to another format.");

                long nbFrames = (long)_fmt->streams[_videoStreamIndex]->nb_frames;
                if (nbFrames <= 0)
                {
                    long duration = _fmt->streams[_videoStreamIndex]->duration;
                    AVRational tb = _fmt->streams[_videoStreamIndex]->time_base;
                    if (duration > 0 && tb.num > 0 && tb.den > 0 && _fps > 0)
                    {
                        double seconds = duration * ffmpeg.av_q2d(tb);
                        nbFrames = (long)Math.Round(seconds * _fps);
                        if (nbFrames < 0) nbFrames = -1;
                    }
                    else
                    {
                        nbFrames = -1;
                    }
                }
                _totalFrames = nbFrames > 0 ? nbFrames : -1;


                _sws = ffmpeg.sws_getContext(
                    _width, _height, _codec->pix_fmt,
                    _width, _height, AVPixelFormat.AV_PIX_FMT_BGR24,
                    4, // SWS_BICUBIC
                    null, null, null);

                if (_sws == null)
                    throw new InvalidOperationException("Failed to alloc a context for the Renderer. Please try reboot your device.");

                int bufferSize = ffmpeg.av_image_get_buffer_size(AVPixelFormat.AV_PIX_FMT_BGR24, _width, _height, 1);
                if (bufferSize <= 0) throw new OutOfMemoryException($"Failed to allocate enough memory space to process the video '{_path}'. Try closing other programs, restarting your device, increasing page file size (on Windows platforms)/swapping files (on Linux platforms), or adding more RAM on your device if possible.");

                _rgbBuffer = (byte*)ffmpeg.av_malloc((ulong)bufferSize);
                if (_rgbBuffer == null) throw new OutOfMemoryException($"Failed to allocate enough memory space to process the video '{_path}'. Try closing other programs, restarting your device, increasing page file size (on Windows platforms)/swapping files (on Linux platforms), or adding more RAM on your device if possible.");

                byte_ptrArray4 tmpData = default;
                int_array4 tmpLinesize = default;

                int fillRet = ffmpeg.av_image_fill_arrays(
                    ref tmpData,
                    ref tmpLinesize,
                    _rgbBuffer,
                    AVPixelFormat.AV_PIX_FMT_BGR24,
                    _width,
                    _height,
                    1);
                if (fillRet < 0) throw new InvalidOperationException("av_image_fill_arrays failed.");

                for (uint i = 0; i < 4; i++)
                {
                    _rgb->data[i] = tmpData[i];
                    _rgb->linesize[i] = tmpLinesize[i];
                }

                _rgb->format = (int)AVPixelFormat.AV_PIX_FMT_BGR24;
                _rgb->width = _width;
                _rgb->height = _height;

                _currentFrameNumber = 0;
                _eof = false;

            }
            catch (Exception ex)
            {
                Dispose();
                throw;
            }
            finally
            {
                Initialized = true;
            }
        }

        [DebuggerNonUserCode()]
        public ImageSource GetFrame(uint targetFrame)
        {

            if (targetFrame < _currentFrameNumber)
            {
                ffmpeg.av_seek_frame(_fmt, _videoStreamIndex, 0, ffmpeg.AVSEEK_FLAG_BACKWARD);
                ffmpeg.avcodec_flush_buffers(_codec);
                _currentFrameNumber = 0;
                _eof = false;
            }


            while (true)
            {
                if (!_eof)
                {
                    if (ffmpeg.av_read_frame(_fmt, _pkt) < 0)
                    {
                        _eof = true;
                        ffmpeg.av_packet_unref(_pkt);
                    }
                    else
                    {
                        if (_pkt->stream_index == _videoStreamIndex)
                        {
                            ffmpeg.avcodec_send_packet(_codec, _pkt);
                        }
                        ffmpeg.av_packet_unref(_pkt);
                    }
                }
                else if (!flushSent)
                {
                    ffmpeg.avcodec_send_packet(_codec, null);
                    flushSent = true;
                }

                while (true)
                {
                    ffmpeg.av_frame_unref(_frm);
                    if (ffmpeg.avcodec_receive_frame(_codec, _frm) == 0)
                    {
                        if (_currentFrameNumber++ == targetFrame)
                        {
                            goto found;
                        }

                        continue;
                    }
                    else if (_totalFrames < _currentFrameNumber)
                    {
                        goto not_found;
                    }

                    break;
                }

                if (_eof && flushSent)
                    break;
            }

        not_found:
            double fps = _fps > 0 ? _fps : 1.0;
            double seconds = targetFrame / fps;
            throw new OverflowException($"Frame #{targetFrame} (timespan {TimeSpan.FromSeconds(seconds)}) not exist in video '{_path}'.");

        found:
            Index++;
            ffmpeg.sws_scale(
                                _sws,
                                _frm->data,
                                _frm->linesize,
                                0,
                                _height,
                                _rgb->data,
                                _rgb->linesize);
            return PixelsToPicture(_rgb->data[0], _rgb->linesize[0], _width, _height);


        }

        [DebuggerNonUserCode()]
        private static ImageSource PixelsToPicture(byte* data, int stride, int width, int height)
        {
            var size = width * height;
            Image<Rgb48> result = new Image<Rgb48>(width, height);
            int idx, baseIndex, offset, x, y;
            byte* srcRow;
            for (y = 0; y < height; y++)
            {
                srcRow = data + y * stride;
                baseIndex = y * width;
                for (x = 0; x < width; x++)
                {
                    idx = baseIndex + x;
                    offset = x * 3;
                    result[x, y] = new Rgb48((ushort)(srcRow[offset + 2] * 257), (ushort)(srcRow[offset + 1] * 257), (ushort)(srcRow[offset + 0] * 257));
                }
            }
            var path = Path.Combine(FileSystem.CacheDirectory, $"image-{Guid.NewGuid().ToString()}.png");
            result.SaveAsPng(path,default);
            return ImageSource.FromFile(path);
        }

        public void Dispose()
        {
            if (Disposed) return;
            Disposed = true;

            if (_rgbBuffer != null) { ffmpeg.av_free(_rgbBuffer); _rgbBuffer = null; }
            if (_rgb != null) { AVFrame* tmp = _rgb; _rgb = null; ffmpeg.av_frame_free(&tmp); }
            if (_frm != null) { AVFrame* tmp = _frm; _frm = null; ffmpeg.av_frame_free(&tmp); }
            if (_pkt != null) { AVPacket* tmp = _pkt; _pkt = null; ffmpeg.av_packet_free(&tmp); }
            if (_sws != null) { ffmpeg.sws_freeContext(_sws); _sws = null; }
            if (_codec != null) { AVCodecContext* tmp = _codec; _codec = null; ffmpeg.avcodec_free_context(&tmp); }
            if (_fmt != null) { AVFormatContext* tmp = _fmt; _fmt = null; ffmpeg.avformat_close_input(&tmp); }
        }

        ~VideoDecoder()
        {
            Dispose();
        }
    }
}







