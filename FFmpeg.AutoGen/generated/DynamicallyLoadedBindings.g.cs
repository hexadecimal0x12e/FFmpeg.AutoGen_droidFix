using System;
using System.Runtime.InteropServices;

namespace FFmpeg.AutoGen;

public static unsafe partial class DynamicallyLoadedBindings
{
    public static bool ThrowErrorIfFunctionNotFound;
    public static IFunctionResolver FunctionResolver;
    
    /// <summary>
    /// Generates the function bindings. 
    /// </summary>
    /// <remarks>
    /// <b>DO NOT CALL THIS except you have initialized the <see cref="FunctionResolver" />.</b>
    /// </remarks>
    public unsafe static void LoadBinding()
    {
        vectors.av_add_index_entry = (AVStream* @st, long @pos, long @timestamp, int @size, int @distance, int @flags) =>
        {
            var av_add_index_entry_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_add_index_entry", ThrowErrorIfFunctionNotFound);
            vectors.av_add_index_entry = av_add_index_entry_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_add_index_entry' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_add_index_entry_delegate>(av_add_index_entry_native_ptr);
            return vectors.av_add_index_entry(@st, @pos, @timestamp, @size, @distance, @flags);
        };
        
        vectors.av_add_q = (AVRational @b, AVRational @c) =>
        {
            var av_add_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_add_q", ThrowErrorIfFunctionNotFound);
            vectors.av_add_q = av_add_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_add_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_add_q_delegate>(av_add_q_native_ptr);
            return vectors.av_add_q(@b, @c);
        };
        
        vectors.av_add_stable = (AVRational @ts_tb, long @ts, AVRational @inc_tb, long @inc) =>
        {
            var av_add_stable_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_add_stable", ThrowErrorIfFunctionNotFound);
            vectors.av_add_stable = av_add_stable_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_add_stable' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_add_stable_delegate>(av_add_stable_native_ptr);
            return vectors.av_add_stable(@ts_tb, @ts, @inc_tb, @inc);
        };
        
        vectors.av_alpha_mode_from_name = (string @name) =>
        {
            var av_alpha_mode_from_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_alpha_mode_from_name", ThrowErrorIfFunctionNotFound);
            vectors.av_alpha_mode_from_name = av_alpha_mode_from_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_alpha_mode_from_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_alpha_mode_from_name_delegate>(av_alpha_mode_from_name_native_ptr);
            return vectors.av_alpha_mode_from_name(@name);
        };
        
        vectors.av_alpha_mode_name = (AVAlphaMode @mode) =>
        {
            var av_alpha_mode_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_alpha_mode_name", ThrowErrorIfFunctionNotFound);
            vectors.av_alpha_mode_name = av_alpha_mode_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_alpha_mode_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_alpha_mode_name_delegate>(av_alpha_mode_name_native_ptr);
            return vectors.av_alpha_mode_name(@mode);
        };
        
        vectors.av_append_packet = (AVIOContext* @s, AVPacket* @pkt, int @size) =>
        {
            var av_append_packet_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_append_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_append_packet = av_append_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_append_packet' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_append_packet_delegate>(av_append_packet_native_ptr);
            return vectors.av_append_packet(@s, @pkt, @size);
        };
        
        vectors.av_audio_fifo_alloc = (AVSampleFormat @sample_fmt, int @channels, int @nb_samples) =>
        {
            var av_audio_fifo_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_alloc = av_audio_fifo_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_alloc_delegate>(av_audio_fifo_alloc_native_ptr);
            return vectors.av_audio_fifo_alloc(@sample_fmt, @channels, @nb_samples);
        };
        
        vectors.av_audio_fifo_drain = (AVAudioFifo* @af, int @nb_samples) =>
        {
            var av_audio_fifo_drain_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_drain", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_drain = av_audio_fifo_drain_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_drain' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_drain_delegate>(av_audio_fifo_drain_native_ptr);
            return vectors.av_audio_fifo_drain(@af, @nb_samples);
        };
        
        vectors.av_audio_fifo_free = (AVAudioFifo* @af) =>
        {
            var av_audio_fifo_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_free", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_free = av_audio_fifo_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_free_delegate>(av_audio_fifo_free_native_ptr);
            vectors.av_audio_fifo_free(@af);
        };
        
        vectors.av_audio_fifo_peek = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
        {
            var av_audio_fifo_peek_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_peek", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_peek = av_audio_fifo_peek_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_peek' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_peek_delegate>(av_audio_fifo_peek_native_ptr);
            return vectors.av_audio_fifo_peek(@af, @data, @nb_samples);
        };
        
        vectors.av_audio_fifo_peek_at = (AVAudioFifo* @af, void** @data, int @nb_samples, int @offset) =>
        {
            var av_audio_fifo_peek_at_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_peek_at", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_peek_at = av_audio_fifo_peek_at_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_peek_at' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_peek_at_delegate>(av_audio_fifo_peek_at_native_ptr);
            return vectors.av_audio_fifo_peek_at(@af, @data, @nb_samples, @offset);
        };
        
        vectors.av_audio_fifo_read = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
        {
            var av_audio_fifo_read_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_read", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_read = av_audio_fifo_read_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_read' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_read_delegate>(av_audio_fifo_read_native_ptr);
            return vectors.av_audio_fifo_read(@af, @data, @nb_samples);
        };
        
        vectors.av_audio_fifo_realloc = (AVAudioFifo* @af, int @nb_samples) =>
        {
            var av_audio_fifo_realloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_realloc", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_realloc = av_audio_fifo_realloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_realloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_realloc_delegate>(av_audio_fifo_realloc_native_ptr);
            return vectors.av_audio_fifo_realloc(@af, @nb_samples);
        };
        
        vectors.av_audio_fifo_reset = (AVAudioFifo* @af) =>
        {
            var av_audio_fifo_reset_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_reset", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_reset = av_audio_fifo_reset_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_reset' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_reset_delegate>(av_audio_fifo_reset_native_ptr);
            vectors.av_audio_fifo_reset(@af);
        };
        
        vectors.av_audio_fifo_size = (AVAudioFifo* @af) =>
        {
            var av_audio_fifo_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_size", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_size = av_audio_fifo_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_size_delegate>(av_audio_fifo_size_native_ptr);
            return vectors.av_audio_fifo_size(@af);
        };
        
        vectors.av_audio_fifo_space = (AVAudioFifo* @af) =>
        {
            var av_audio_fifo_space_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_space", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_space = av_audio_fifo_space_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_space' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_space_delegate>(av_audio_fifo_space_native_ptr);
            return vectors.av_audio_fifo_space(@af);
        };
        
        vectors.av_audio_fifo_write = (AVAudioFifo* @af, void** @data, int @nb_samples) =>
        {
            var av_audio_fifo_write_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_audio_fifo_write", ThrowErrorIfFunctionNotFound);
            vectors.av_audio_fifo_write = av_audio_fifo_write_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_audio_fifo_write' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_audio_fifo_write_delegate>(av_audio_fifo_write_native_ptr);
            return vectors.av_audio_fifo_write(@af, @data, @nb_samples);
        };
        
        vectors.av_bessel_i0 = (double @x) =>
        {
            var av_bessel_i0_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_bessel_i0", ThrowErrorIfFunctionNotFound);
            vectors.av_bessel_i0 = av_bessel_i0_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bessel_i0' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bessel_i0_delegate>(av_bessel_i0_native_ptr);
            return vectors.av_bessel_i0(@x);
        };
        
        vectors.av_bsf_alloc = (AVBitStreamFilter* @filter, AVBSFContext** @ctx) =>
        {
            var av_bsf_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_alloc = av_bsf_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_alloc' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_alloc_delegate>(av_bsf_alloc_native_ptr);
            return vectors.av_bsf_alloc(@filter, @ctx);
        };
        
        vectors.av_bsf_flush = (AVBSFContext* @ctx) =>
        {
            var av_bsf_flush_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_flush", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_flush = av_bsf_flush_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_flush' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_flush_delegate>(av_bsf_flush_native_ptr);
            vectors.av_bsf_flush(@ctx);
        };
        
        vectors.av_bsf_free = (AVBSFContext** @ctx) =>
        {
            var av_bsf_free_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_free", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_free = av_bsf_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_free' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_free_delegate>(av_bsf_free_native_ptr);
            vectors.av_bsf_free(@ctx);
        };
        
        vectors.av_bsf_get_by_name = (string @name) =>
        {
            var av_bsf_get_by_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_get_by_name", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_get_by_name = av_bsf_get_by_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_get_by_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_get_by_name_delegate>(av_bsf_get_by_name_native_ptr);
            return vectors.av_bsf_get_by_name(@name);
        };
        
        vectors.av_bsf_get_class = () =>
        {
            var av_bsf_get_class_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_get_class", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_get_class = av_bsf_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_get_class' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_get_class_delegate>(av_bsf_get_class_native_ptr);
            return vectors.av_bsf_get_class();
        };
        
        vectors.av_bsf_get_null_filter = (AVBSFContext** @bsf) =>
        {
            var av_bsf_get_null_filter_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_get_null_filter", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_get_null_filter = av_bsf_get_null_filter_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_get_null_filter' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_get_null_filter_delegate>(av_bsf_get_null_filter_native_ptr);
            return vectors.av_bsf_get_null_filter(@bsf);
        };
        
        vectors.av_bsf_init = (AVBSFContext* @ctx) =>
        {
            var av_bsf_init_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_init", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_init = av_bsf_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_init' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_init_delegate>(av_bsf_init_native_ptr);
            return vectors.av_bsf_init(@ctx);
        };
        
        vectors.av_bsf_iterate = (void** @opaque) =>
        {
            var av_bsf_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_iterate = av_bsf_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_iterate' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_iterate_delegate>(av_bsf_iterate_native_ptr);
            return vectors.av_bsf_iterate(@opaque);
        };
        
        vectors.av_bsf_list_alloc = () =>
        {
            var av_bsf_list_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_list_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_list_alloc = av_bsf_list_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_list_alloc' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_list_alloc_delegate>(av_bsf_list_alloc_native_ptr);
            return vectors.av_bsf_list_alloc();
        };
        
        vectors.av_bsf_list_append = (AVBSFList* @lst, AVBSFContext* @bsf) =>
        {
            var av_bsf_list_append_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_list_append", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_list_append = av_bsf_list_append_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_list_append' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_list_append_delegate>(av_bsf_list_append_native_ptr);
            return vectors.av_bsf_list_append(@lst, @bsf);
        };
        
        vectors.av_bsf_list_append2 = (AVBSFList* @lst, string @bsf_name, AVDictionary** @options) =>
        {
            var av_bsf_list_append2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_list_append2", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_list_append2 = av_bsf_list_append2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_list_append2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_list_append2_delegate>(av_bsf_list_append2_native_ptr);
            return vectors.av_bsf_list_append2(@lst, @bsf_name, @options);
        };
        
        vectors.av_bsf_list_finalize = (AVBSFList** @lst, AVBSFContext** @bsf) =>
        {
            var av_bsf_list_finalize_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_list_finalize", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_list_finalize = av_bsf_list_finalize_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_list_finalize' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_list_finalize_delegate>(av_bsf_list_finalize_native_ptr);
            return vectors.av_bsf_list_finalize(@lst, @bsf);
        };
        
        vectors.av_bsf_list_free = (AVBSFList** @lst) =>
        {
            var av_bsf_list_free_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_list_free", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_list_free = av_bsf_list_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_list_free' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_list_free_delegate>(av_bsf_list_free_native_ptr);
            vectors.av_bsf_list_free(@lst);
        };
        
        vectors.av_bsf_list_parse_str = (string @str, AVBSFContext** @bsf) =>
        {
            var av_bsf_list_parse_str_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_list_parse_str", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_list_parse_str = av_bsf_list_parse_str_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_list_parse_str' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_list_parse_str_delegate>(av_bsf_list_parse_str_native_ptr);
            return vectors.av_bsf_list_parse_str(@str, @bsf);
        };
        
        vectors.av_bsf_receive_packet = (AVBSFContext* @ctx, AVPacket* @pkt) =>
        {
            var av_bsf_receive_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_receive_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_receive_packet = av_bsf_receive_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_receive_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_receive_packet_delegate>(av_bsf_receive_packet_native_ptr);
            return vectors.av_bsf_receive_packet(@ctx, @pkt);
        };
        
        vectors.av_bsf_send_packet = (AVBSFContext* @ctx, AVPacket* @pkt) =>
        {
            var av_bsf_send_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_bsf_send_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_bsf_send_packet = av_bsf_send_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_bsf_send_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_bsf_send_packet_delegate>(av_bsf_send_packet_native_ptr);
            return vectors.av_bsf_send_packet(@ctx, @pkt);
        };
        
        vectors.av_buffer_alloc = (ulong @size) =>
        {
            var av_buffer_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_alloc = av_buffer_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_alloc_delegate>(av_buffer_alloc_native_ptr);
            return vectors.av_buffer_alloc(@size);
        };
        
        vectors.av_buffer_allocz = (ulong @size) =>
        {
            var av_buffer_allocz_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_allocz", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_allocz = av_buffer_allocz_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_allocz' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_allocz_delegate>(av_buffer_allocz_native_ptr);
            return vectors.av_buffer_allocz(@size);
        };
        
        vectors.av_buffer_create = (byte* @data, ulong @size, av_buffer_create_free_func @free, void* @opaque, int @flags) =>
        {
            var av_buffer_create_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_create", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_create = av_buffer_create_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_create' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_create_delegate>(av_buffer_create_native_ptr);
            return vectors.av_buffer_create(@data, @size, @free, @opaque, @flags);
        };
        
        vectors.av_buffer_default_free = (void* @opaque, byte* @data) =>
        {
            var av_buffer_default_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_default_free", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_default_free = av_buffer_default_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_default_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_default_free_delegate>(av_buffer_default_free_native_ptr);
            vectors.av_buffer_default_free(@opaque, @data);
        };
        
        vectors.av_buffer_get_opaque = (AVBufferRef* @buf) =>
        {
            var av_buffer_get_opaque_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_get_opaque", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_get_opaque = av_buffer_get_opaque_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_get_opaque' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_get_opaque_delegate>(av_buffer_get_opaque_native_ptr);
            return vectors.av_buffer_get_opaque(@buf);
        };
        
        vectors.av_buffer_get_ref_count = (AVBufferRef* @buf) =>
        {
            var av_buffer_get_ref_count_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_get_ref_count", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_get_ref_count = av_buffer_get_ref_count_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_get_ref_count' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_get_ref_count_delegate>(av_buffer_get_ref_count_native_ptr);
            return vectors.av_buffer_get_ref_count(@buf);
        };
        
        vectors.av_buffer_is_writable = (AVBufferRef* @buf) =>
        {
            var av_buffer_is_writable_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_is_writable", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_is_writable = av_buffer_is_writable_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_is_writable' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_is_writable_delegate>(av_buffer_is_writable_native_ptr);
            return vectors.av_buffer_is_writable(@buf);
        };
        
        vectors.av_buffer_make_writable = (AVBufferRef** @buf) =>
        {
            var av_buffer_make_writable_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_make_writable", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_make_writable = av_buffer_make_writable_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_make_writable' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_make_writable_delegate>(av_buffer_make_writable_native_ptr);
            return vectors.av_buffer_make_writable(@buf);
        };
        
        vectors.av_buffer_pool_buffer_get_opaque = (AVBufferRef* @ref) =>
        {
            var av_buffer_pool_buffer_get_opaque_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_pool_buffer_get_opaque", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_pool_buffer_get_opaque = av_buffer_pool_buffer_get_opaque_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_pool_buffer_get_opaque' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_pool_buffer_get_opaque_delegate>(av_buffer_pool_buffer_get_opaque_native_ptr);
            return vectors.av_buffer_pool_buffer_get_opaque(@ref);
        };
        
        vectors.av_buffer_pool_get = (AVBufferPool* @pool) =>
        {
            var av_buffer_pool_get_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_pool_get", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_pool_get = av_buffer_pool_get_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_pool_get' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_pool_get_delegate>(av_buffer_pool_get_native_ptr);
            return vectors.av_buffer_pool_get(@pool);
        };
        
        vectors.av_buffer_pool_init = (ulong @size, av_buffer_pool_init_alloc_func @alloc) =>
        {
            var av_buffer_pool_init_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_pool_init", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_pool_init = av_buffer_pool_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_pool_init' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_pool_init_delegate>(av_buffer_pool_init_native_ptr);
            return vectors.av_buffer_pool_init(@size, @alloc);
        };
        
        vectors.av_buffer_pool_init2 = (ulong @size, void* @opaque, av_buffer_pool_init2_alloc_func @alloc, av_buffer_pool_init2_pool_free_func @pool_free) =>
        {
            var av_buffer_pool_init2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_pool_init2", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_pool_init2 = av_buffer_pool_init2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_pool_init2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_pool_init2_delegate>(av_buffer_pool_init2_native_ptr);
            return vectors.av_buffer_pool_init2(@size, @opaque, @alloc, @pool_free);
        };
        
        vectors.av_buffer_pool_uninit = (AVBufferPool** @pool) =>
        {
            var av_buffer_pool_uninit_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_pool_uninit", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_pool_uninit = av_buffer_pool_uninit_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_pool_uninit' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_pool_uninit_delegate>(av_buffer_pool_uninit_native_ptr);
            vectors.av_buffer_pool_uninit(@pool);
        };
        
        vectors.av_buffer_realloc = (AVBufferRef** @buf, ulong @size) =>
        {
            var av_buffer_realloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_realloc", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_realloc = av_buffer_realloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_realloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_realloc_delegate>(av_buffer_realloc_native_ptr);
            return vectors.av_buffer_realloc(@buf, @size);
        };
        
        vectors.av_buffer_ref = (AVBufferRef* @buf) =>
        {
            var av_buffer_ref_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_ref", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_ref = av_buffer_ref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_ref' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_ref_delegate>(av_buffer_ref_native_ptr);
            return vectors.av_buffer_ref(@buf);
        };
        
        vectors.av_buffer_replace = (AVBufferRef** @dst, AVBufferRef* @src) =>
        {
            var av_buffer_replace_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_replace", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_replace = av_buffer_replace_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_replace' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_replace_delegate>(av_buffer_replace_native_ptr);
            return vectors.av_buffer_replace(@dst, @src);
        };
        
        vectors.av_buffer_unref = (AVBufferRef** @buf) =>
        {
            var av_buffer_unref_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_buffer_unref", ThrowErrorIfFunctionNotFound);
            vectors.av_buffer_unref = av_buffer_unref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffer_unref' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffer_unref_delegate>(av_buffer_unref_native_ptr);
            vectors.av_buffer_unref(@buf);
        };
        
        vectors.av_buffersink_get_alpha_mode = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_alpha_mode_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_alpha_mode", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_alpha_mode = av_buffersink_get_alpha_mode_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_alpha_mode' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_alpha_mode_delegate>(av_buffersink_get_alpha_mode_native_ptr);
            return vectors.av_buffersink_get_alpha_mode(@ctx);
        };
        
        vectors.av_buffersink_get_ch_layout = (AVFilterContext* @ctx, AVChannelLayout* @ch_layout) =>
        {
            var av_buffersink_get_ch_layout_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_ch_layout", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_ch_layout = av_buffersink_get_ch_layout_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_ch_layout' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_ch_layout_delegate>(av_buffersink_get_ch_layout_native_ptr);
            return vectors.av_buffersink_get_ch_layout(@ctx, @ch_layout);
        };
        
        vectors.av_buffersink_get_channels = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_channels_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_channels", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_channels = av_buffersink_get_channels_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_channels' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_channels_delegate>(av_buffersink_get_channels_native_ptr);
            return vectors.av_buffersink_get_channels(@ctx);
        };
        
        vectors.av_buffersink_get_color_range = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_color_range_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_color_range", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_color_range = av_buffersink_get_color_range_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_color_range' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_color_range_delegate>(av_buffersink_get_color_range_native_ptr);
            return vectors.av_buffersink_get_color_range(@ctx);
        };
        
        vectors.av_buffersink_get_colorspace = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_colorspace_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_colorspace", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_colorspace = av_buffersink_get_colorspace_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_colorspace' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_colorspace_delegate>(av_buffersink_get_colorspace_native_ptr);
            return vectors.av_buffersink_get_colorspace(@ctx);
        };
        
        vectors.av_buffersink_get_format = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_format_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_format", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_format = av_buffersink_get_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_format' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_format_delegate>(av_buffersink_get_format_native_ptr);
            return vectors.av_buffersink_get_format(@ctx);
        };
        
        vectors.av_buffersink_get_frame = (AVFilterContext* @ctx, AVFrame* @frame) =>
        {
            var av_buffersink_get_frame_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_frame = av_buffersink_get_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_frame' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_frame_delegate>(av_buffersink_get_frame_native_ptr);
            return vectors.av_buffersink_get_frame(@ctx, @frame);
        };
        
        vectors.av_buffersink_get_frame_flags = (AVFilterContext* @ctx, AVFrame* @frame, int @flags) =>
        {
            var av_buffersink_get_frame_flags_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_frame_flags", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_frame_flags = av_buffersink_get_frame_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_frame_flags' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_frame_flags_delegate>(av_buffersink_get_frame_flags_native_ptr);
            return vectors.av_buffersink_get_frame_flags(@ctx, @frame, @flags);
        };
        
        vectors.av_buffersink_get_frame_rate = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_frame_rate_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_frame_rate", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_frame_rate = av_buffersink_get_frame_rate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_frame_rate' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_frame_rate_delegate>(av_buffersink_get_frame_rate_native_ptr);
            return vectors.av_buffersink_get_frame_rate(@ctx);
        };
        
        vectors.av_buffersink_get_h = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_h_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_h", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_h = av_buffersink_get_h_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_h' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_h_delegate>(av_buffersink_get_h_native_ptr);
            return vectors.av_buffersink_get_h(@ctx);
        };
        
        vectors.av_buffersink_get_hw_frames_ctx = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_hw_frames_ctx_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_hw_frames_ctx", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_hw_frames_ctx = av_buffersink_get_hw_frames_ctx_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_hw_frames_ctx' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_hw_frames_ctx_delegate>(av_buffersink_get_hw_frames_ctx_native_ptr);
            return vectors.av_buffersink_get_hw_frames_ctx(@ctx);
        };
        
        vectors.av_buffersink_get_sample_aspect_ratio = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_sample_aspect_ratio_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_sample_aspect_ratio", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_sample_aspect_ratio = av_buffersink_get_sample_aspect_ratio_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_sample_aspect_ratio' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_sample_aspect_ratio_delegate>(av_buffersink_get_sample_aspect_ratio_native_ptr);
            return vectors.av_buffersink_get_sample_aspect_ratio(@ctx);
        };
        
        vectors.av_buffersink_get_sample_rate = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_sample_rate_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_sample_rate", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_sample_rate = av_buffersink_get_sample_rate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_sample_rate' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_sample_rate_delegate>(av_buffersink_get_sample_rate_native_ptr);
            return vectors.av_buffersink_get_sample_rate(@ctx);
        };
        
        vectors.av_buffersink_get_samples = (AVFilterContext* @ctx, AVFrame* @frame, int @nb_samples) =>
        {
            var av_buffersink_get_samples_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_samples", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_samples = av_buffersink_get_samples_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_samples' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_samples_delegate>(av_buffersink_get_samples_native_ptr);
            return vectors.av_buffersink_get_samples(@ctx, @frame, @nb_samples);
        };
        
        vectors.av_buffersink_get_side_data = (AVFilterContext* @ctx, int* @nb_side_data) =>
        {
            var av_buffersink_get_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_side_data = av_buffersink_get_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_side_data' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_side_data_delegate>(av_buffersink_get_side_data_native_ptr);
            return vectors.av_buffersink_get_side_data(@ctx, @nb_side_data);
        };
        
        vectors.av_buffersink_get_time_base = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_time_base_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_time_base", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_time_base = av_buffersink_get_time_base_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_time_base' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_time_base_delegate>(av_buffersink_get_time_base_native_ptr);
            return vectors.av_buffersink_get_time_base(@ctx);
        };
        
        vectors.av_buffersink_get_type = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_type_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_type", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_type = av_buffersink_get_type_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_type' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_type_delegate>(av_buffersink_get_type_native_ptr);
            return vectors.av_buffersink_get_type(@ctx);
        };
        
        vectors.av_buffersink_get_w = (AVFilterContext* @ctx) =>
        {
            var av_buffersink_get_w_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_get_w", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_get_w = av_buffersink_get_w_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_get_w' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_get_w_delegate>(av_buffersink_get_w_native_ptr);
            return vectors.av_buffersink_get_w(@ctx);
        };
        
        vectors.av_buffersink_set_frame_size = (AVFilterContext* @ctx, uint @frame_size) =>
        {
            var av_buffersink_set_frame_size_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersink_set_frame_size", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersink_set_frame_size = av_buffersink_set_frame_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersink_set_frame_size' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersink_set_frame_size_delegate>(av_buffersink_set_frame_size_native_ptr);
            vectors.av_buffersink_set_frame_size(@ctx, @frame_size);
        };
        
        vectors.av_buffersrc_add_frame = (AVFilterContext* @ctx, AVFrame* @frame) =>
        {
            var av_buffersrc_add_frame_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_add_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_add_frame = av_buffersrc_add_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_add_frame' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_add_frame_delegate>(av_buffersrc_add_frame_native_ptr);
            return vectors.av_buffersrc_add_frame(@ctx, @frame);
        };
        
        vectors.av_buffersrc_add_frame_flags = (AVFilterContext* @buffer_src, AVFrame* @frame, int @flags) =>
        {
            var av_buffersrc_add_frame_flags_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_add_frame_flags", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_add_frame_flags = av_buffersrc_add_frame_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_add_frame_flags' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_add_frame_flags_delegate>(av_buffersrc_add_frame_flags_native_ptr);
            return vectors.av_buffersrc_add_frame_flags(@buffer_src, @frame, @flags);
        };
        
        vectors.av_buffersrc_close = (AVFilterContext* @ctx, long @pts, uint @flags) =>
        {
            var av_buffersrc_close_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_close", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_close = av_buffersrc_close_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_close' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_close_delegate>(av_buffersrc_close_native_ptr);
            return vectors.av_buffersrc_close(@ctx, @pts, @flags);
        };
        
        vectors.av_buffersrc_get_nb_failed_requests = (AVFilterContext* @buffer_src) =>
        {
            var av_buffersrc_get_nb_failed_requests_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_get_nb_failed_requests", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_get_nb_failed_requests = av_buffersrc_get_nb_failed_requests_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_get_nb_failed_requests' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_get_nb_failed_requests_delegate>(av_buffersrc_get_nb_failed_requests_native_ptr);
            return vectors.av_buffersrc_get_nb_failed_requests(@buffer_src);
        };
        
        vectors.av_buffersrc_get_status = (AVFilterContext* @ctx) =>
        {
            var av_buffersrc_get_status_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_get_status", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_get_status = av_buffersrc_get_status_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_get_status' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_get_status_delegate>(av_buffersrc_get_status_native_ptr);
            return vectors.av_buffersrc_get_status(@ctx);
        };
        
        vectors.av_buffersrc_parameters_alloc = () =>
        {
            var av_buffersrc_parameters_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_parameters_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_parameters_alloc = av_buffersrc_parameters_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_parameters_alloc' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_parameters_alloc_delegate>(av_buffersrc_parameters_alloc_native_ptr);
            return vectors.av_buffersrc_parameters_alloc();
        };
        
        vectors.av_buffersrc_parameters_set = (AVFilterContext* @ctx, AVBufferSrcParameters* @param) =>
        {
            var av_buffersrc_parameters_set_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_parameters_set", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_parameters_set = av_buffersrc_parameters_set_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_parameters_set' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_parameters_set_delegate>(av_buffersrc_parameters_set_native_ptr);
            return vectors.av_buffersrc_parameters_set(@ctx, @param);
        };
        
        vectors.av_buffersrc_write_frame = (AVFilterContext* @ctx, AVFrame* @frame) =>
        {
            var av_buffersrc_write_frame_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_buffersrc_write_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_buffersrc_write_frame = av_buffersrc_write_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_buffersrc_write_frame' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_buffersrc_write_frame_delegate>(av_buffersrc_write_frame_native_ptr);
            return vectors.av_buffersrc_write_frame(@ctx, @frame);
        };
        
        vectors.av_calloc = (ulong @nmemb, ulong @size) =>
        {
            var av_calloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_calloc", ThrowErrorIfFunctionNotFound);
            vectors.av_calloc = av_calloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_calloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_calloc_delegate>(av_calloc_native_ptr);
            return vectors.av_calloc(@nmemb, @size);
        };
        
        vectors.av_channel_description = (byte* @buf, ulong @buf_size, AVChannel @channel) =>
        {
            var av_channel_description_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_description", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_description = av_channel_description_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_description' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_description_delegate>(av_channel_description_native_ptr);
            return vectors.av_channel_description(@buf, @buf_size, @channel);
        };
        
        vectors.av_channel_description_bprint = (AVBPrint* @bp, AVChannel @channel_id) =>
        {
            var av_channel_description_bprint_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_description_bprint", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_description_bprint = av_channel_description_bprint_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_description_bprint' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_description_bprint_delegate>(av_channel_description_bprint_native_ptr);
            vectors.av_channel_description_bprint(@bp, @channel_id);
        };
        
        vectors.av_channel_from_string = (string @name) =>
        {
            var av_channel_from_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_from_string", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_from_string = av_channel_from_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_from_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_from_string_delegate>(av_channel_from_string_native_ptr);
            return vectors.av_channel_from_string(@name);
        };
        
        vectors.av_channel_layout_ambisonic_order = (AVChannelLayout* @channel_layout) =>
        {
            var av_channel_layout_ambisonic_order_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_ambisonic_order", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_ambisonic_order = av_channel_layout_ambisonic_order_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_ambisonic_order' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_ambisonic_order_delegate>(av_channel_layout_ambisonic_order_native_ptr);
            return vectors.av_channel_layout_ambisonic_order(@channel_layout);
        };
        
        vectors.av_channel_layout_channel_from_index = (AVChannelLayout* @channel_layout, uint @idx) =>
        {
            var av_channel_layout_channel_from_index_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_channel_from_index", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_channel_from_index = av_channel_layout_channel_from_index_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_channel_from_index' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_channel_from_index_delegate>(av_channel_layout_channel_from_index_native_ptr);
            return vectors.av_channel_layout_channel_from_index(@channel_layout, @idx);
        };
        
        vectors.av_channel_layout_channel_from_string = (AVChannelLayout* @channel_layout, string @name) =>
        {
            var av_channel_layout_channel_from_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_channel_from_string", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_channel_from_string = av_channel_layout_channel_from_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_channel_from_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_channel_from_string_delegate>(av_channel_layout_channel_from_string_native_ptr);
            return vectors.av_channel_layout_channel_from_string(@channel_layout, @name);
        };
        
        vectors.av_channel_layout_check = (AVChannelLayout* @channel_layout) =>
        {
            var av_channel_layout_check_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_check", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_check = av_channel_layout_check_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_check' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_check_delegate>(av_channel_layout_check_native_ptr);
            return vectors.av_channel_layout_check(@channel_layout);
        };
        
        vectors.av_channel_layout_compare = (AVChannelLayout* @chl, AVChannelLayout* @chl1) =>
        {
            var av_channel_layout_compare_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_compare", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_compare = av_channel_layout_compare_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_compare' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_compare_delegate>(av_channel_layout_compare_native_ptr);
            return vectors.av_channel_layout_compare(@chl, @chl1);
        };
        
        vectors.av_channel_layout_copy = (AVChannelLayout* @dst, AVChannelLayout* @src) =>
        {
            var av_channel_layout_copy_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_copy", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_copy = av_channel_layout_copy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_copy' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_copy_delegate>(av_channel_layout_copy_native_ptr);
            return vectors.av_channel_layout_copy(@dst, @src);
        };
        
        vectors.av_channel_layout_custom_init = (AVChannelLayout* @channel_layout, int @nb_channels) =>
        {
            var av_channel_layout_custom_init_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_custom_init", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_custom_init = av_channel_layout_custom_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_custom_init' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_custom_init_delegate>(av_channel_layout_custom_init_native_ptr);
            return vectors.av_channel_layout_custom_init(@channel_layout, @nb_channels);
        };
        
        vectors.av_channel_layout_default = (AVChannelLayout* @ch_layout, int @nb_channels) =>
        {
            var av_channel_layout_default_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_default", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_default = av_channel_layout_default_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_default' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_default_delegate>(av_channel_layout_default_native_ptr);
            vectors.av_channel_layout_default(@ch_layout, @nb_channels);
        };
        
        vectors.av_channel_layout_describe = (AVChannelLayout* @channel_layout, byte* @buf, ulong @buf_size) =>
        {
            var av_channel_layout_describe_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_describe", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_describe = av_channel_layout_describe_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_describe' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_describe_delegate>(av_channel_layout_describe_native_ptr);
            return vectors.av_channel_layout_describe(@channel_layout, @buf, @buf_size);
        };
        
        vectors.av_channel_layout_describe_bprint = (AVChannelLayout* @channel_layout, AVBPrint* @bp) =>
        {
            var av_channel_layout_describe_bprint_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_describe_bprint", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_describe_bprint = av_channel_layout_describe_bprint_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_describe_bprint' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_describe_bprint_delegate>(av_channel_layout_describe_bprint_native_ptr);
            return vectors.av_channel_layout_describe_bprint(@channel_layout, @bp);
        };
        
        vectors.av_channel_layout_from_mask = (AVChannelLayout* @channel_layout, ulong @mask) =>
        {
            var av_channel_layout_from_mask_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_from_mask", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_from_mask = av_channel_layout_from_mask_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_from_mask' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_from_mask_delegate>(av_channel_layout_from_mask_native_ptr);
            return vectors.av_channel_layout_from_mask(@channel_layout, @mask);
        };
        
        vectors.av_channel_layout_from_string = (AVChannelLayout* @channel_layout, string @str) =>
        {
            var av_channel_layout_from_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_from_string", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_from_string = av_channel_layout_from_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_from_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_from_string_delegate>(av_channel_layout_from_string_native_ptr);
            return vectors.av_channel_layout_from_string(@channel_layout, @str);
        };
        
        vectors.av_channel_layout_index_from_channel = (AVChannelLayout* @channel_layout, AVChannel @channel) =>
        {
            var av_channel_layout_index_from_channel_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_index_from_channel", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_index_from_channel = av_channel_layout_index_from_channel_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_index_from_channel' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_index_from_channel_delegate>(av_channel_layout_index_from_channel_native_ptr);
            return vectors.av_channel_layout_index_from_channel(@channel_layout, @channel);
        };
        
        vectors.av_channel_layout_index_from_string = (AVChannelLayout* @channel_layout, string @name) =>
        {
            var av_channel_layout_index_from_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_index_from_string", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_index_from_string = av_channel_layout_index_from_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_index_from_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_index_from_string_delegate>(av_channel_layout_index_from_string_native_ptr);
            return vectors.av_channel_layout_index_from_string(@channel_layout, @name);
        };
        
        vectors.av_channel_layout_retype = (AVChannelLayout* @channel_layout, AVChannelOrder @order, int @flags) =>
        {
            var av_channel_layout_retype_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_retype", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_retype = av_channel_layout_retype_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_retype' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_retype_delegate>(av_channel_layout_retype_native_ptr);
            return vectors.av_channel_layout_retype(@channel_layout, @order, @flags);
        };
        
        vectors.av_channel_layout_standard = (void** @opaque) =>
        {
            var av_channel_layout_standard_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_standard", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_standard = av_channel_layout_standard_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_standard' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_standard_delegate>(av_channel_layout_standard_native_ptr);
            return vectors.av_channel_layout_standard(@opaque);
        };
        
        vectors.av_channel_layout_subset = (AVChannelLayout* @channel_layout, ulong @mask) =>
        {
            var av_channel_layout_subset_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_subset", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_subset = av_channel_layout_subset_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_subset' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_subset_delegate>(av_channel_layout_subset_native_ptr);
            return vectors.av_channel_layout_subset(@channel_layout, @mask);
        };
        
        vectors.av_channel_layout_uninit = (AVChannelLayout* @channel_layout) =>
        {
            var av_channel_layout_uninit_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_layout_uninit", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_layout_uninit = av_channel_layout_uninit_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_layout_uninit' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_layout_uninit_delegate>(av_channel_layout_uninit_native_ptr);
            vectors.av_channel_layout_uninit(@channel_layout);
        };
        
        vectors.av_channel_name = (byte* @buf, ulong @buf_size, AVChannel @channel) =>
        {
            var av_channel_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_name", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_name = av_channel_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_name_delegate>(av_channel_name_native_ptr);
            return vectors.av_channel_name(@buf, @buf_size, @channel);
        };
        
        vectors.av_channel_name_bprint = (AVBPrint* @bp, AVChannel @channel_id) =>
        {
            var av_channel_name_bprint_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_channel_name_bprint", ThrowErrorIfFunctionNotFound);
            vectors.av_channel_name_bprint = av_channel_name_bprint_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_channel_name_bprint' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_channel_name_bprint_delegate>(av_channel_name_bprint_native_ptr);
            vectors.av_channel_name_bprint(@bp, @channel_id);
        };
        
        vectors.av_chroma_location_enum_to_pos = (int* @xpos, int* @ypos, AVChromaLocation @pos) =>
        {
            var av_chroma_location_enum_to_pos_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_chroma_location_enum_to_pos", ThrowErrorIfFunctionNotFound);
            vectors.av_chroma_location_enum_to_pos = av_chroma_location_enum_to_pos_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_chroma_location_enum_to_pos' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_chroma_location_enum_to_pos_delegate>(av_chroma_location_enum_to_pos_native_ptr);
            return vectors.av_chroma_location_enum_to_pos(@xpos, @ypos, @pos);
        };
        
        vectors.av_chroma_location_from_name = (string @name) =>
        {
            var av_chroma_location_from_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_chroma_location_from_name", ThrowErrorIfFunctionNotFound);
            vectors.av_chroma_location_from_name = av_chroma_location_from_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_chroma_location_from_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_chroma_location_from_name_delegate>(av_chroma_location_from_name_native_ptr);
            return vectors.av_chroma_location_from_name(@name);
        };
        
        vectors.av_chroma_location_name = (AVChromaLocation @location) =>
        {
            var av_chroma_location_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_chroma_location_name", ThrowErrorIfFunctionNotFound);
            vectors.av_chroma_location_name = av_chroma_location_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_chroma_location_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_chroma_location_name_delegate>(av_chroma_location_name_native_ptr);
            return vectors.av_chroma_location_name(@location);
        };
        
        vectors.av_chroma_location_pos_to_enum = (int @xpos, int @ypos) =>
        {
            var av_chroma_location_pos_to_enum_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_chroma_location_pos_to_enum", ThrowErrorIfFunctionNotFound);
            vectors.av_chroma_location_pos_to_enum = av_chroma_location_pos_to_enum_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_chroma_location_pos_to_enum' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_chroma_location_pos_to_enum_delegate>(av_chroma_location_pos_to_enum_native_ptr);
            return vectors.av_chroma_location_pos_to_enum(@xpos, @ypos);
        };
        
        vectors.av_codec_get_id = (AVCodecTag** @tags, uint @tag) =>
        {
            var av_codec_get_id_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_codec_get_id", ThrowErrorIfFunctionNotFound);
            vectors.av_codec_get_id = av_codec_get_id_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_codec_get_id' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_codec_get_id_delegate>(av_codec_get_id_native_ptr);
            return vectors.av_codec_get_id(@tags, @tag);
        };
        
        vectors.av_codec_get_tag = (AVCodecTag** @tags, AVCodecID @id) =>
        {
            var av_codec_get_tag_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_codec_get_tag", ThrowErrorIfFunctionNotFound);
            vectors.av_codec_get_tag = av_codec_get_tag_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_codec_get_tag' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_codec_get_tag_delegate>(av_codec_get_tag_native_ptr);
            return vectors.av_codec_get_tag(@tags, @id);
        };
        
        vectors.av_codec_get_tag2 = (AVCodecTag** @tags, AVCodecID @id, uint* @tag) =>
        {
            var av_codec_get_tag2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_codec_get_tag2", ThrowErrorIfFunctionNotFound);
            vectors.av_codec_get_tag2 = av_codec_get_tag2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_codec_get_tag2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_codec_get_tag2_delegate>(av_codec_get_tag2_native_ptr);
            return vectors.av_codec_get_tag2(@tags, @id, @tag);
        };
        
        vectors.av_codec_is_decoder = (AVCodec* @codec) =>
        {
            var av_codec_is_decoder_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_codec_is_decoder", ThrowErrorIfFunctionNotFound);
            vectors.av_codec_is_decoder = av_codec_is_decoder_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_codec_is_decoder' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_codec_is_decoder_delegate>(av_codec_is_decoder_native_ptr);
            return vectors.av_codec_is_decoder(@codec);
        };
        
        vectors.av_codec_is_encoder = (AVCodec* @codec) =>
        {
            var av_codec_is_encoder_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_codec_is_encoder", ThrowErrorIfFunctionNotFound);
            vectors.av_codec_is_encoder = av_codec_is_encoder_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_codec_is_encoder' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_codec_is_encoder_delegate>(av_codec_is_encoder_native_ptr);
            return vectors.av_codec_is_encoder(@codec);
        };
        
        vectors.av_codec_iterate = (void** @opaque) =>
        {
            var av_codec_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_codec_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_codec_iterate = av_codec_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_codec_iterate' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_codec_iterate_delegate>(av_codec_iterate_native_ptr);
            return vectors.av_codec_iterate(@opaque);
        };
        
        vectors.av_color_primaries_from_name = (string @name) =>
        {
            var av_color_primaries_from_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_primaries_from_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_primaries_from_name = av_color_primaries_from_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_primaries_from_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_primaries_from_name_delegate>(av_color_primaries_from_name_native_ptr);
            return vectors.av_color_primaries_from_name(@name);
        };
        
        vectors.av_color_primaries_name = (AVColorPrimaries @primaries) =>
        {
            var av_color_primaries_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_primaries_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_primaries_name = av_color_primaries_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_primaries_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_primaries_name_delegate>(av_color_primaries_name_native_ptr);
            return vectors.av_color_primaries_name(@primaries);
        };
        
        vectors.av_color_range_from_name = (string @name) =>
        {
            var av_color_range_from_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_range_from_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_range_from_name = av_color_range_from_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_range_from_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_range_from_name_delegate>(av_color_range_from_name_native_ptr);
            return vectors.av_color_range_from_name(@name);
        };
        
        vectors.av_color_range_name = (AVColorRange @range) =>
        {
            var av_color_range_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_range_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_range_name = av_color_range_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_range_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_range_name_delegate>(av_color_range_name_native_ptr);
            return vectors.av_color_range_name(@range);
        };
        
        vectors.av_color_space_from_name = (string @name) =>
        {
            var av_color_space_from_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_space_from_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_space_from_name = av_color_space_from_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_space_from_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_space_from_name_delegate>(av_color_space_from_name_native_ptr);
            return vectors.av_color_space_from_name(@name);
        };
        
        vectors.av_color_space_name = (AVColorSpace @space) =>
        {
            var av_color_space_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_space_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_space_name = av_color_space_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_space_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_space_name_delegate>(av_color_space_name_native_ptr);
            return vectors.av_color_space_name(@space);
        };
        
        vectors.av_color_transfer_from_name = (string @name) =>
        {
            var av_color_transfer_from_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_transfer_from_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_transfer_from_name = av_color_transfer_from_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_transfer_from_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_transfer_from_name_delegate>(av_color_transfer_from_name_native_ptr);
            return vectors.av_color_transfer_from_name(@name);
        };
        
        vectors.av_color_transfer_name = (AVColorTransferCharacteristic @transfer) =>
        {
            var av_color_transfer_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_color_transfer_name", ThrowErrorIfFunctionNotFound);
            vectors.av_color_transfer_name = av_color_transfer_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_color_transfer_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_color_transfer_name_delegate>(av_color_transfer_name_native_ptr);
            return vectors.av_color_transfer_name(@transfer);
        };
        
        vectors.av_compare_mod = (ulong @a, ulong @b, ulong @mod) =>
        {
            var av_compare_mod_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_compare_mod", ThrowErrorIfFunctionNotFound);
            vectors.av_compare_mod = av_compare_mod_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_compare_mod' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_compare_mod_delegate>(av_compare_mod_native_ptr);
            return vectors.av_compare_mod(@a, @b, @mod);
        };
        
        vectors.av_compare_ts = (long @ts_a, AVRational @tb_a, long @ts_b, AVRational @tb_b) =>
        {
            var av_compare_ts_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_compare_ts", ThrowErrorIfFunctionNotFound);
            vectors.av_compare_ts = av_compare_ts_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_compare_ts' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_compare_ts_delegate>(av_compare_ts_native_ptr);
            return vectors.av_compare_ts(@ts_a, @tb_a, @ts_b, @tb_b);
        };
        
        vectors.av_container_fifo_alloc_avpacket = (uint @flags) =>
        {
            var av_container_fifo_alloc_avpacket_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_container_fifo_alloc_avpacket", ThrowErrorIfFunctionNotFound);
            vectors.av_container_fifo_alloc_avpacket = av_container_fifo_alloc_avpacket_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_container_fifo_alloc_avpacket' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_container_fifo_alloc_avpacket_delegate>(av_container_fifo_alloc_avpacket_native_ptr);
            return vectors.av_container_fifo_alloc_avpacket(@flags);
        };
        
        vectors.av_content_light_metadata_alloc = (ulong* @size) =>
        {
            var av_content_light_metadata_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_content_light_metadata_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_content_light_metadata_alloc = av_content_light_metadata_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_content_light_metadata_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_content_light_metadata_alloc_delegate>(av_content_light_metadata_alloc_native_ptr);
            return vectors.av_content_light_metadata_alloc(@size);
        };
        
        vectors.av_content_light_metadata_create_side_data = (AVFrame* @frame) =>
        {
            var av_content_light_metadata_create_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_content_light_metadata_create_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_content_light_metadata_create_side_data = av_content_light_metadata_create_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_content_light_metadata_create_side_data' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_content_light_metadata_create_side_data_delegate>(av_content_light_metadata_create_side_data_native_ptr);
            return vectors.av_content_light_metadata_create_side_data(@frame);
        };
        
        vectors.av_cpb_properties_alloc = (ulong* @size) =>
        {
            var av_cpb_properties_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_cpb_properties_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_cpb_properties_alloc = av_cpb_properties_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_cpb_properties_alloc' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_cpb_properties_alloc_delegate>(av_cpb_properties_alloc_native_ptr);
            return vectors.av_cpb_properties_alloc(@size);
        };
        
        vectors.av_cpu_count = () =>
        {
            var av_cpu_count_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_cpu_count", ThrowErrorIfFunctionNotFound);
            vectors.av_cpu_count = av_cpu_count_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_cpu_count' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_cpu_count_delegate>(av_cpu_count_native_ptr);
            return vectors.av_cpu_count();
        };
        
        vectors.av_cpu_force_count = (int @count) =>
        {
            var av_cpu_force_count_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_cpu_force_count", ThrowErrorIfFunctionNotFound);
            vectors.av_cpu_force_count = av_cpu_force_count_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_cpu_force_count' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_cpu_force_count_delegate>(av_cpu_force_count_native_ptr);
            vectors.av_cpu_force_count(@count);
        };
        
        vectors.av_cpu_max_align = () =>
        {
            var av_cpu_max_align_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_cpu_max_align", ThrowErrorIfFunctionNotFound);
            vectors.av_cpu_max_align = av_cpu_max_align_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_cpu_max_align' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_cpu_max_align_delegate>(av_cpu_max_align_native_ptr);
            return vectors.av_cpu_max_align();
        };
        
        vectors.av_d2q = (double @d, int @max) =>
        {
            var av_d2q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_d2q", ThrowErrorIfFunctionNotFound);
            vectors.av_d2q = av_d2q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_d2q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_d2q_delegate>(av_d2q_native_ptr);
            return vectors.av_d2q(@d, @max);
        };
        
        vectors.av_d3d11va_alloc_context = () =>
        {
            var av_d3d11va_alloc_context_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_d3d11va_alloc_context", ThrowErrorIfFunctionNotFound);
            vectors.av_d3d11va_alloc_context = av_d3d11va_alloc_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_d3d11va_alloc_context' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_d3d11va_alloc_context_delegate>(av_d3d11va_alloc_context_native_ptr);
            return vectors.av_d3d11va_alloc_context();
        };
        
        vectors.av_default_get_category = (void* @ptr) =>
        {
            var av_default_get_category_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_default_get_category", ThrowErrorIfFunctionNotFound);
            vectors.av_default_get_category = av_default_get_category_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_default_get_category' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_default_get_category_delegate>(av_default_get_category_native_ptr);
            return vectors.av_default_get_category(@ptr);
        };
        
        vectors.av_default_item_name = (void* @ctx) =>
        {
            var av_default_item_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_default_item_name", ThrowErrorIfFunctionNotFound);
            vectors.av_default_item_name = av_default_item_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_default_item_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_default_item_name_delegate>(av_default_item_name_native_ptr);
            return vectors.av_default_item_name(@ctx);
        };
        
        vectors.av_demuxer_iterate = (void** @opaque) =>
        {
            var av_demuxer_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_demuxer_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_demuxer_iterate = av_demuxer_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_demuxer_iterate' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_demuxer_iterate_delegate>(av_demuxer_iterate_native_ptr);
            return vectors.av_demuxer_iterate(@opaque);
        };
        
        vectors.av_dict_copy = (AVDictionary** @dst, AVDictionary* @src, int @flags) =>
        {
            var av_dict_copy_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_copy", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_copy = av_dict_copy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_copy' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_copy_delegate>(av_dict_copy_native_ptr);
            return vectors.av_dict_copy(@dst, @src, @flags);
        };
        
        vectors.av_dict_count = (AVDictionary* @m) =>
        {
            var av_dict_count_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_count", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_count = av_dict_count_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_count' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_count_delegate>(av_dict_count_native_ptr);
            return vectors.av_dict_count(@m);
        };
        
        vectors.av_dict_free = (AVDictionary** @m) =>
        {
            var av_dict_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_free", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_free = av_dict_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_free_delegate>(av_dict_free_native_ptr);
            vectors.av_dict_free(@m);
        };
        
        vectors.av_dict_get = (AVDictionary* @m, string @key, AVDictionaryEntry* @prev, int @flags) =>
        {
            var av_dict_get_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_get", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_get = av_dict_get_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_get' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_get_delegate>(av_dict_get_native_ptr);
            return vectors.av_dict_get(@m, @key, @prev, @flags);
        };
        
        vectors.av_dict_get_string = (AVDictionary* @m, byte** @buffer, byte @key_val_sep, byte @pairs_sep) =>
        {
            var av_dict_get_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_get_string", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_get_string = av_dict_get_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_get_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_get_string_delegate>(av_dict_get_string_native_ptr);
            return vectors.av_dict_get_string(@m, @buffer, @key_val_sep, @pairs_sep);
        };
        
        vectors.av_dict_iterate = (AVDictionary* @m, AVDictionaryEntry* @prev) =>
        {
            var av_dict_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_iterate = av_dict_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_iterate' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_iterate_delegate>(av_dict_iterate_native_ptr);
            return vectors.av_dict_iterate(@m, @prev);
        };
        
        vectors.av_dict_parse_string = (AVDictionary** @pm, string @str, string @key_val_sep, string @pairs_sep, int @flags) =>
        {
            var av_dict_parse_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_parse_string", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_parse_string = av_dict_parse_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_parse_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_parse_string_delegate>(av_dict_parse_string_native_ptr);
            return vectors.av_dict_parse_string(@pm, @str, @key_val_sep, @pairs_sep, @flags);
        };
        
        vectors.av_dict_set = (AVDictionary** @pm, string @key, string @value, int @flags) =>
        {
            var av_dict_set_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_set", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_set = av_dict_set_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_set' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_set_delegate>(av_dict_set_native_ptr);
            return vectors.av_dict_set(@pm, @key, @value, @flags);
        };
        
        vectors.av_dict_set_int = (AVDictionary** @pm, string @key, long @value, int @flags) =>
        {
            var av_dict_set_int_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dict_set_int", ThrowErrorIfFunctionNotFound);
            vectors.av_dict_set_int = av_dict_set_int_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dict_set_int' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dict_set_int_delegate>(av_dict_set_int_native_ptr);
            return vectors.av_dict_set_int(@pm, @key, @value, @flags);
        };
        
        vectors.av_display_matrix_flip = (ref int_array9 @matrix, int @hflip, int @vflip) =>
        {
            var av_display_matrix_flip_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_display_matrix_flip", ThrowErrorIfFunctionNotFound);
            vectors.av_display_matrix_flip = av_display_matrix_flip_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_display_matrix_flip' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_display_matrix_flip_delegate>(av_display_matrix_flip_native_ptr);
            vectors.av_display_matrix_flip(ref @matrix, @hflip, @vflip);
        };
        
        vectors.av_display_rotation_get = (in int_array9 @matrix) =>
        {
            var av_display_rotation_get_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_display_rotation_get", ThrowErrorIfFunctionNotFound);
            vectors.av_display_rotation_get = av_display_rotation_get_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_display_rotation_get' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_display_rotation_get_delegate>(av_display_rotation_get_native_ptr);
            return vectors.av_display_rotation_get(@matrix);
        };
        
        vectors.av_display_rotation_set = (ref int_array9 @matrix, double @angle) =>
        {
            var av_display_rotation_set_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_display_rotation_set", ThrowErrorIfFunctionNotFound);
            vectors.av_display_rotation_set = av_display_rotation_set_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_display_rotation_set' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_display_rotation_set_delegate>(av_display_rotation_set_native_ptr);
            vectors.av_display_rotation_set(ref @matrix, @angle);
        };
        
        vectors.av_disposition_from_string = (string @disp) =>
        {
            var av_disposition_from_string_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_disposition_from_string", ThrowErrorIfFunctionNotFound);
            vectors.av_disposition_from_string = av_disposition_from_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_disposition_from_string' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_disposition_from_string_delegate>(av_disposition_from_string_native_ptr);
            return vectors.av_disposition_from_string(@disp);
        };
        
        vectors.av_disposition_to_string = (int @disposition) =>
        {
            var av_disposition_to_string_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_disposition_to_string", ThrowErrorIfFunctionNotFound);
            vectors.av_disposition_to_string = av_disposition_to_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_disposition_to_string' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_disposition_to_string_delegate>(av_disposition_to_string_native_ptr);
            return vectors.av_disposition_to_string(@disposition);
        };
        
        vectors.av_div_q = (AVRational @b, AVRational @c) =>
        {
            var av_div_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_div_q", ThrowErrorIfFunctionNotFound);
            vectors.av_div_q = av_div_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_div_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_div_q_delegate>(av_div_q_native_ptr);
            return vectors.av_div_q(@b, @c);
        };
        
        vectors.av_dump_format = (AVFormatContext* @ic, int @index, string @url, int @is_output) =>
        {
            var av_dump_format_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_dump_format", ThrowErrorIfFunctionNotFound);
            vectors.av_dump_format = av_dump_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dump_format' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dump_format_delegate>(av_dump_format_native_ptr);
            vectors.av_dump_format(@ic, @index, @url, @is_output);
        };
        
        vectors.av_dynamic_hdr_plus_alloc = (ulong* @size) =>
        {
            var av_dynamic_hdr_plus_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dynamic_hdr_plus_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_dynamic_hdr_plus_alloc = av_dynamic_hdr_plus_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dynamic_hdr_plus_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dynamic_hdr_plus_alloc_delegate>(av_dynamic_hdr_plus_alloc_native_ptr);
            return vectors.av_dynamic_hdr_plus_alloc(@size);
        };
        
        vectors.av_dynamic_hdr_plus_create_side_data = (AVFrame* @frame) =>
        {
            var av_dynamic_hdr_plus_create_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dynamic_hdr_plus_create_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_dynamic_hdr_plus_create_side_data = av_dynamic_hdr_plus_create_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dynamic_hdr_plus_create_side_data' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dynamic_hdr_plus_create_side_data_delegate>(av_dynamic_hdr_plus_create_side_data_native_ptr);
            return vectors.av_dynamic_hdr_plus_create_side_data(@frame);
        };
        
        vectors.av_dynamic_hdr_plus_from_t35 = (AVDynamicHDRPlus* @s, byte* @data, ulong @size) =>
        {
            var av_dynamic_hdr_plus_from_t35_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dynamic_hdr_plus_from_t35", ThrowErrorIfFunctionNotFound);
            vectors.av_dynamic_hdr_plus_from_t35 = av_dynamic_hdr_plus_from_t35_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dynamic_hdr_plus_from_t35' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dynamic_hdr_plus_from_t35_delegate>(av_dynamic_hdr_plus_from_t35_native_ptr);
            return vectors.av_dynamic_hdr_plus_from_t35(@s, @data, @size);
        };
        
        vectors.av_dynamic_hdr_plus_to_t35 = (AVDynamicHDRPlus* @s, byte** @data, ulong* @size) =>
        {
            var av_dynamic_hdr_plus_to_t35_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dynamic_hdr_plus_to_t35", ThrowErrorIfFunctionNotFound);
            vectors.av_dynamic_hdr_plus_to_t35 = av_dynamic_hdr_plus_to_t35_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dynamic_hdr_plus_to_t35' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dynamic_hdr_plus_to_t35_delegate>(av_dynamic_hdr_plus_to_t35_native_ptr);
            return vectors.av_dynamic_hdr_plus_to_t35(@s, @data, @size);
        };
        
        vectors.av_dynarray_add = (void* @tab_ptr, int* @nb_ptr, void* @elem) =>
        {
            var av_dynarray_add_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dynarray_add", ThrowErrorIfFunctionNotFound);
            vectors.av_dynarray_add = av_dynarray_add_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dynarray_add' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dynarray_add_delegate>(av_dynarray_add_native_ptr);
            vectors.av_dynarray_add(@tab_ptr, @nb_ptr, @elem);
        };
        
        vectors.av_dynarray_add_nofree = (void* @tab_ptr, int* @nb_ptr, void* @elem) =>
        {
            var av_dynarray_add_nofree_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dynarray_add_nofree", ThrowErrorIfFunctionNotFound);
            vectors.av_dynarray_add_nofree = av_dynarray_add_nofree_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dynarray_add_nofree' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dynarray_add_nofree_delegate>(av_dynarray_add_nofree_native_ptr);
            return vectors.av_dynarray_add_nofree(@tab_ptr, @nb_ptr, @elem);
        };
        
        vectors.av_dynarray2_add = (void** @tab_ptr, int* @nb_ptr, ulong @elem_size, byte* @elem_data) =>
        {
            var av_dynarray2_add_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_dynarray2_add", ThrowErrorIfFunctionNotFound);
            vectors.av_dynarray2_add = av_dynarray2_add_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_dynarray2_add' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_dynarray2_add_delegate>(av_dynarray2_add_native_ptr);
            return vectors.av_dynarray2_add(@tab_ptr, @nb_ptr, @elem_size, @elem_data);
        };
        
        vectors.av_fast_malloc = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            var av_fast_malloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_fast_malloc", ThrowErrorIfFunctionNotFound);
            vectors.av_fast_malloc = av_fast_malloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_fast_malloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_fast_malloc_delegate>(av_fast_malloc_native_ptr);
            vectors.av_fast_malloc(@ptr, @size, @min_size);
        };
        
        vectors.av_fast_mallocz = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            var av_fast_mallocz_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_fast_mallocz", ThrowErrorIfFunctionNotFound);
            vectors.av_fast_mallocz = av_fast_mallocz_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_fast_mallocz' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_fast_mallocz_delegate>(av_fast_mallocz_native_ptr);
            vectors.av_fast_mallocz(@ptr, @size, @min_size);
        };
        
        vectors.av_fast_padded_malloc = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            var av_fast_padded_malloc_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_fast_padded_malloc", ThrowErrorIfFunctionNotFound);
            vectors.av_fast_padded_malloc = av_fast_padded_malloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_fast_padded_malloc' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_fast_padded_malloc_delegate>(av_fast_padded_malloc_native_ptr);
            vectors.av_fast_padded_malloc(@ptr, @size, @min_size);
        };
        
        vectors.av_fast_padded_mallocz = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            var av_fast_padded_mallocz_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_fast_padded_mallocz", ThrowErrorIfFunctionNotFound);
            vectors.av_fast_padded_mallocz = av_fast_padded_mallocz_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_fast_padded_mallocz' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_fast_padded_mallocz_delegate>(av_fast_padded_mallocz_native_ptr);
            vectors.av_fast_padded_mallocz(@ptr, @size, @min_size);
        };
        
        vectors.av_fast_realloc = (void* @ptr, uint* @size, ulong @min_size) =>
        {
            var av_fast_realloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_fast_realloc", ThrowErrorIfFunctionNotFound);
            vectors.av_fast_realloc = av_fast_realloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_fast_realloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_fast_realloc_delegate>(av_fast_realloc_native_ptr);
            return vectors.av_fast_realloc(@ptr, @size, @min_size);
        };
        
        vectors.av_file_map = (string @filename, byte** @bufptr, ulong* @size, int @log_offset, void* @log_ctx) =>
        {
            var av_file_map_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_file_map", ThrowErrorIfFunctionNotFound);
            vectors.av_file_map = av_file_map_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_file_map' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_file_map_delegate>(av_file_map_native_ptr);
            return vectors.av_file_map(@filename, @bufptr, @size, @log_offset, @log_ctx);
        };
        
        vectors.av_file_unmap = (byte* @bufptr, ulong @size) =>
        {
            var av_file_unmap_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_file_unmap", ThrowErrorIfFunctionNotFound);
            vectors.av_file_unmap = av_file_unmap_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_file_unmap' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_file_unmap_delegate>(av_file_unmap_native_ptr);
            vectors.av_file_unmap(@bufptr, @size);
        };
        
        vectors.av_filename_number_test = (string @filename) =>
        {
            var av_filename_number_test_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_filename_number_test", ThrowErrorIfFunctionNotFound);
            vectors.av_filename_number_test = av_filename_number_test_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_filename_number_test' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_filename_number_test_delegate>(av_filename_number_test_native_ptr);
            return vectors.av_filename_number_test(@filename);
        };
        
        vectors.av_filter_iterate = (void** @opaque) =>
        {
            var av_filter_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "av_filter_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_filter_iterate = av_filter_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_filter_iterate' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_filter_iterate_delegate>(av_filter_iterate_native_ptr);
            return vectors.av_filter_iterate(@opaque);
        };
        
        vectors.av_find_best_pix_fmt_of_2 = (AVPixelFormat @dst_pix_fmt1, AVPixelFormat @dst_pix_fmt2, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
        {
            var av_find_best_pix_fmt_of_2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_find_best_pix_fmt_of_2", ThrowErrorIfFunctionNotFound);
            vectors.av_find_best_pix_fmt_of_2 = av_find_best_pix_fmt_of_2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_find_best_pix_fmt_of_2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_find_best_pix_fmt_of_2_delegate>(av_find_best_pix_fmt_of_2_native_ptr);
            return vectors.av_find_best_pix_fmt_of_2(@dst_pix_fmt1, @dst_pix_fmt2, @src_pix_fmt, @has_alpha, @loss_ptr);
        };
        
        vectors.av_find_best_stream = (AVFormatContext* @ic, AVMediaType @type, int @wanted_stream_nb, int @related_stream, AVCodec** @decoder_ret, int @flags) =>
        {
            var av_find_best_stream_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_find_best_stream", ThrowErrorIfFunctionNotFound);
            vectors.av_find_best_stream = av_find_best_stream_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_find_best_stream' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_find_best_stream_delegate>(av_find_best_stream_native_ptr);
            return vectors.av_find_best_stream(@ic, @type, @wanted_stream_nb, @related_stream, @decoder_ret, @flags);
        };
        
        vectors.av_find_default_stream_index = (AVFormatContext* @s) =>
        {
            var av_find_default_stream_index_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_find_default_stream_index", ThrowErrorIfFunctionNotFound);
            vectors.av_find_default_stream_index = av_find_default_stream_index_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_find_default_stream_index' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_find_default_stream_index_delegate>(av_find_default_stream_index_native_ptr);
            return vectors.av_find_default_stream_index(@s);
        };
        
        vectors.av_find_input_format = (string @short_name) =>
        {
            var av_find_input_format_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_find_input_format", ThrowErrorIfFunctionNotFound);
            vectors.av_find_input_format = av_find_input_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_find_input_format' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_find_input_format_delegate>(av_find_input_format_native_ptr);
            return vectors.av_find_input_format(@short_name);
        };
        
        vectors.av_find_nearest_q_idx = (AVRational @q, AVRational* @q_list) =>
        {
            var av_find_nearest_q_idx_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_find_nearest_q_idx", ThrowErrorIfFunctionNotFound);
            vectors.av_find_nearest_q_idx = av_find_nearest_q_idx_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_find_nearest_q_idx' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_find_nearest_q_idx_delegate>(av_find_nearest_q_idx_native_ptr);
            return vectors.av_find_nearest_q_idx(@q, @q_list);
        };
        
        vectors.av_find_program_from_stream = (AVFormatContext* @ic, AVProgram* @last, int @s) =>
        {
            var av_find_program_from_stream_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_find_program_from_stream", ThrowErrorIfFunctionNotFound);
            vectors.av_find_program_from_stream = av_find_program_from_stream_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_find_program_from_stream' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_find_program_from_stream_delegate>(av_find_program_from_stream_native_ptr);
            return vectors.av_find_program_from_stream(@ic, @last, @s);
        };
        
        vectors.av_force_cpu_flags = (int @flags) =>
        {
            var av_force_cpu_flags_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_force_cpu_flags", ThrowErrorIfFunctionNotFound);
            vectors.av_force_cpu_flags = av_force_cpu_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_force_cpu_flags' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_force_cpu_flags_delegate>(av_force_cpu_flags_native_ptr);
            vectors.av_force_cpu_flags(@flags);
        };
        
        vectors.av_fourcc_make_string = (byte* @buf, uint @fourcc) =>
        {
            var av_fourcc_make_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_fourcc_make_string", ThrowErrorIfFunctionNotFound);
            vectors.av_fourcc_make_string = av_fourcc_make_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_fourcc_make_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_fourcc_make_string_delegate>(av_fourcc_make_string_native_ptr);
            return vectors.av_fourcc_make_string(@buf, @fourcc);
        };
        
        vectors.av_frame_alloc = () =>
        {
            var av_frame_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_alloc = av_frame_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_alloc_delegate>(av_frame_alloc_native_ptr);
            return vectors.av_frame_alloc();
        };
        
        vectors.av_frame_apply_cropping = (AVFrame* @frame, int @flags) =>
        {
            var av_frame_apply_cropping_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_apply_cropping", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_apply_cropping = av_frame_apply_cropping_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_apply_cropping' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_apply_cropping_delegate>(av_frame_apply_cropping_native_ptr);
            return vectors.av_frame_apply_cropping(@frame, @flags);
        };
        
        vectors.av_frame_clone = (AVFrame* @src) =>
        {
            var av_frame_clone_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_clone", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_clone = av_frame_clone_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_clone' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_clone_delegate>(av_frame_clone_native_ptr);
            return vectors.av_frame_clone(@src);
        };
        
        vectors.av_frame_copy = (AVFrame* @dst, AVFrame* @src) =>
        {
            var av_frame_copy_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_copy", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_copy = av_frame_copy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_copy' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_copy_delegate>(av_frame_copy_native_ptr);
            return vectors.av_frame_copy(@dst, @src);
        };
        
        vectors.av_frame_copy_props = (AVFrame* @dst, AVFrame* @src) =>
        {
            var av_frame_copy_props_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_copy_props", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_copy_props = av_frame_copy_props_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_copy_props' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_copy_props_delegate>(av_frame_copy_props_native_ptr);
            return vectors.av_frame_copy_props(@dst, @src);
        };
        
        vectors.av_frame_free = (AVFrame** @frame) =>
        {
            var av_frame_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_free", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_free = av_frame_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_free_delegate>(av_frame_free_native_ptr);
            vectors.av_frame_free(@frame);
        };
        
        vectors.av_frame_get_buffer = (AVFrame* @frame, int @align) =>
        {
            var av_frame_get_buffer_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_get_buffer", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_get_buffer = av_frame_get_buffer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_get_buffer' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_get_buffer_delegate>(av_frame_get_buffer_native_ptr);
            return vectors.av_frame_get_buffer(@frame, @align);
        };
        
        vectors.av_frame_get_plane_buffer = (AVFrame* @frame, int @plane) =>
        {
            var av_frame_get_plane_buffer_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_get_plane_buffer", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_get_plane_buffer = av_frame_get_plane_buffer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_get_plane_buffer' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_get_plane_buffer_delegate>(av_frame_get_plane_buffer_native_ptr);
            return vectors.av_frame_get_plane_buffer(@frame, @plane);
        };
        
        vectors.av_frame_get_side_data = (AVFrame* @frame, AVFrameSideDataType @type) =>
        {
            var av_frame_get_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_get_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_get_side_data = av_frame_get_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_get_side_data' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_get_side_data_delegate>(av_frame_get_side_data_native_ptr);
            return vectors.av_frame_get_side_data(@frame, @type);
        };
        
        vectors.av_frame_is_writable = (AVFrame* @frame) =>
        {
            var av_frame_is_writable_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_is_writable", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_is_writable = av_frame_is_writable_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_is_writable' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_is_writable_delegate>(av_frame_is_writable_native_ptr);
            return vectors.av_frame_is_writable(@frame);
        };
        
        vectors.av_frame_make_writable = (AVFrame* @frame) =>
        {
            var av_frame_make_writable_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_make_writable", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_make_writable = av_frame_make_writable_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_make_writable' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_make_writable_delegate>(av_frame_make_writable_native_ptr);
            return vectors.av_frame_make_writable(@frame);
        };
        
        vectors.av_frame_move_ref = (AVFrame* @dst, AVFrame* @src) =>
        {
            var av_frame_move_ref_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_move_ref", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_move_ref = av_frame_move_ref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_move_ref' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_move_ref_delegate>(av_frame_move_ref_native_ptr);
            vectors.av_frame_move_ref(@dst, @src);
        };
        
        vectors.av_frame_new_side_data = (AVFrame* @frame, AVFrameSideDataType @type, ulong @size) =>
        {
            var av_frame_new_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_new_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_new_side_data = av_frame_new_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_new_side_data' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_new_side_data_delegate>(av_frame_new_side_data_native_ptr);
            return vectors.av_frame_new_side_data(@frame, @type, @size);
        };
        
        vectors.av_frame_new_side_data_from_buf = (AVFrame* @frame, AVFrameSideDataType @type, AVBufferRef* @buf) =>
        {
            var av_frame_new_side_data_from_buf_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_new_side_data_from_buf", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_new_side_data_from_buf = av_frame_new_side_data_from_buf_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_new_side_data_from_buf' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_new_side_data_from_buf_delegate>(av_frame_new_side_data_from_buf_native_ptr);
            return vectors.av_frame_new_side_data_from_buf(@frame, @type, @buf);
        };
        
        vectors.av_frame_ref = (AVFrame* @dst, AVFrame* @src) =>
        {
            var av_frame_ref_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_ref", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_ref = av_frame_ref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_ref' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_ref_delegate>(av_frame_ref_native_ptr);
            return vectors.av_frame_ref(@dst, @src);
        };
        
        vectors.av_frame_remove_side_data = (AVFrame* @frame, AVFrameSideDataType @type) =>
        {
            var av_frame_remove_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_remove_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_remove_side_data = av_frame_remove_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_remove_side_data' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_remove_side_data_delegate>(av_frame_remove_side_data_native_ptr);
            vectors.av_frame_remove_side_data(@frame, @type);
        };
        
        vectors.av_frame_replace = (AVFrame* @dst, AVFrame* @src) =>
        {
            var av_frame_replace_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_replace", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_replace = av_frame_replace_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_replace' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_replace_delegate>(av_frame_replace_native_ptr);
            return vectors.av_frame_replace(@dst, @src);
        };
        
        vectors.av_frame_side_data_add = (AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, AVBufferRef** @buf, uint @flags) =>
        {
            var av_frame_side_data_add_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_add", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_add = av_frame_side_data_add_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_add' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_add_delegate>(av_frame_side_data_add_native_ptr);
            return vectors.av_frame_side_data_add(@sd, @nb_sd, @type, @buf, @flags);
        };
        
        vectors.av_frame_side_data_clone = (AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideData* @src, uint @flags) =>
        {
            var av_frame_side_data_clone_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_clone", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_clone = av_frame_side_data_clone_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_clone' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_clone_delegate>(av_frame_side_data_clone_native_ptr);
            return vectors.av_frame_side_data_clone(@sd, @nb_sd, @src, @flags);
        };
        
        vectors.av_frame_side_data_desc = (AVFrameSideDataType @type) =>
        {
            var av_frame_side_data_desc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_desc", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_desc = av_frame_side_data_desc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_desc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_desc_delegate>(av_frame_side_data_desc_native_ptr);
            return vectors.av_frame_side_data_desc(@type);
        };
        
        vectors.av_frame_side_data_free = (AVFrameSideData*** @sd, int* @nb_sd) =>
        {
            var av_frame_side_data_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_free", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_free = av_frame_side_data_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_free_delegate>(av_frame_side_data_free_native_ptr);
            vectors.av_frame_side_data_free(@sd, @nb_sd);
        };
        
        vectors.av_frame_side_data_get_c = (AVFrameSideData** @sd, int @nb_sd, AVFrameSideDataType @type) =>
        {
            var av_frame_side_data_get_c_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_get_c", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_get_c = av_frame_side_data_get_c_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_get_c' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_get_c_delegate>(av_frame_side_data_get_c_native_ptr);
            return vectors.av_frame_side_data_get_c(@sd, @nb_sd, @type);
        };
        
        vectors.av_frame_side_data_name = (AVFrameSideDataType @type) =>
        {
            var av_frame_side_data_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_name", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_name = av_frame_side_data_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_name_delegate>(av_frame_side_data_name_native_ptr);
            return vectors.av_frame_side_data_name(@type);
        };
        
        vectors.av_frame_side_data_new = (AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type, ulong @size, uint @flags) =>
        {
            var av_frame_side_data_new_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_new", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_new = av_frame_side_data_new_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_new' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_new_delegate>(av_frame_side_data_new_native_ptr);
            return vectors.av_frame_side_data_new(@sd, @nb_sd, @type, @size, @flags);
        };
        
        vectors.av_frame_side_data_remove = (AVFrameSideData*** @sd, int* @nb_sd, AVFrameSideDataType @type) =>
        {
            var av_frame_side_data_remove_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_remove", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_remove = av_frame_side_data_remove_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_remove' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_remove_delegate>(av_frame_side_data_remove_native_ptr);
            vectors.av_frame_side_data_remove(@sd, @nb_sd, @type);
        };
        
        vectors.av_frame_side_data_remove_by_props = (AVFrameSideData*** @sd, int* @nb_sd, int @props) =>
        {
            var av_frame_side_data_remove_by_props_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_side_data_remove_by_props", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_side_data_remove_by_props = av_frame_side_data_remove_by_props_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_side_data_remove_by_props' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_side_data_remove_by_props_delegate>(av_frame_side_data_remove_by_props_native_ptr);
            vectors.av_frame_side_data_remove_by_props(@sd, @nb_sd, @props);
        };
        
        vectors.av_frame_unref = (AVFrame* @frame) =>
        {
            var av_frame_unref_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_frame_unref", ThrowErrorIfFunctionNotFound);
            vectors.av_frame_unref = av_frame_unref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_frame_unref' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_frame_unref_delegate>(av_frame_unref_native_ptr);
            vectors.av_frame_unref(@frame);
        };
        
        vectors.av_free = (void* @ptr) =>
        {
            var av_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_free", ThrowErrorIfFunctionNotFound);
            vectors.av_free = av_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_free_delegate>(av_free_native_ptr);
            vectors.av_free(@ptr);
        };
        
        vectors.av_freep = (void* @ptr) =>
        {
            var av_freep_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_freep", ThrowErrorIfFunctionNotFound);
            vectors.av_freep = av_freep_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_freep' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_freep_delegate>(av_freep_native_ptr);
            vectors.av_freep(@ptr);
        };
        
        vectors.av_gcd = (long @a, long @b) =>
        {
            var av_gcd_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_gcd", ThrowErrorIfFunctionNotFound);
            vectors.av_gcd = av_gcd_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_gcd' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_gcd_delegate>(av_gcd_native_ptr);
            return vectors.av_gcd(@a, @b);
        };
        
        vectors.av_gcd_q = (AVRational @a, AVRational @b, int @max_den, AVRational @def) =>
        {
            var av_gcd_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_gcd_q", ThrowErrorIfFunctionNotFound);
            vectors.av_gcd_q = av_gcd_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_gcd_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_gcd_q_delegate>(av_gcd_q_native_ptr);
            return vectors.av_gcd_q(@a, @b, @max_den, @def);
        };
        
        vectors.av_get_alt_sample_fmt = (AVSampleFormat @sample_fmt, int @planar) =>
        {
            var av_get_alt_sample_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_alt_sample_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_get_alt_sample_fmt = av_get_alt_sample_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_alt_sample_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_alt_sample_fmt_delegate>(av_get_alt_sample_fmt_native_ptr);
            return vectors.av_get_alt_sample_fmt(@sample_fmt, @planar);
        };
        
        vectors.av_get_audio_frame_duration = (AVCodecContext* @avctx, int @frame_bytes) =>
        {
            var av_get_audio_frame_duration_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_get_audio_frame_duration", ThrowErrorIfFunctionNotFound);
            vectors.av_get_audio_frame_duration = av_get_audio_frame_duration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_audio_frame_duration' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_audio_frame_duration_delegate>(av_get_audio_frame_duration_native_ptr);
            return vectors.av_get_audio_frame_duration(@avctx, @frame_bytes);
        };
        
        vectors.av_get_audio_frame_duration2 = (AVCodecParameters* @par, int @frame_bytes) =>
        {
            var av_get_audio_frame_duration2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_get_audio_frame_duration2", ThrowErrorIfFunctionNotFound);
            vectors.av_get_audio_frame_duration2 = av_get_audio_frame_duration2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_audio_frame_duration2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_audio_frame_duration2_delegate>(av_get_audio_frame_duration2_native_ptr);
            return vectors.av_get_audio_frame_duration2(@par, @frame_bytes);
        };
        
        vectors.av_get_bits_per_pixel = (AVPixFmtDescriptor* @pixdesc) =>
        {
            var av_get_bits_per_pixel_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_bits_per_pixel", ThrowErrorIfFunctionNotFound);
            vectors.av_get_bits_per_pixel = av_get_bits_per_pixel_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_bits_per_pixel' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_bits_per_pixel_delegate>(av_get_bits_per_pixel_native_ptr);
            return vectors.av_get_bits_per_pixel(@pixdesc);
        };
        
        vectors.av_get_bits_per_sample = (AVCodecID @codec_id) =>
        {
            var av_get_bits_per_sample_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_get_bits_per_sample", ThrowErrorIfFunctionNotFound);
            vectors.av_get_bits_per_sample = av_get_bits_per_sample_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_bits_per_sample' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_bits_per_sample_delegate>(av_get_bits_per_sample_native_ptr);
            return vectors.av_get_bits_per_sample(@codec_id);
        };
        
        vectors.av_get_bytes_per_sample = (AVSampleFormat @sample_fmt) =>
        {
            var av_get_bytes_per_sample_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_bytes_per_sample", ThrowErrorIfFunctionNotFound);
            vectors.av_get_bytes_per_sample = av_get_bytes_per_sample_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_bytes_per_sample' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_bytes_per_sample_delegate>(av_get_bytes_per_sample_native_ptr);
            return vectors.av_get_bytes_per_sample(@sample_fmt);
        };
        
        vectors.av_get_cpu_flags = () =>
        {
            var av_get_cpu_flags_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_cpu_flags", ThrowErrorIfFunctionNotFound);
            vectors.av_get_cpu_flags = av_get_cpu_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_cpu_flags' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_cpu_flags_delegate>(av_get_cpu_flags_native_ptr);
            return vectors.av_get_cpu_flags();
        };
        
        vectors.av_get_exact_bits_per_sample = (AVCodecID @codec_id) =>
        {
            var av_get_exact_bits_per_sample_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_get_exact_bits_per_sample", ThrowErrorIfFunctionNotFound);
            vectors.av_get_exact_bits_per_sample = av_get_exact_bits_per_sample_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_exact_bits_per_sample' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_exact_bits_per_sample_delegate>(av_get_exact_bits_per_sample_native_ptr);
            return vectors.av_get_exact_bits_per_sample(@codec_id);
        };
        
        vectors.av_get_frame_filename = (byte* @buf, int @buf_size, string @path, int @number) =>
        {
            var av_get_frame_filename_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_get_frame_filename", ThrowErrorIfFunctionNotFound);
            vectors.av_get_frame_filename = av_get_frame_filename_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_frame_filename' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_frame_filename_delegate>(av_get_frame_filename_native_ptr);
            return vectors.av_get_frame_filename(@buf, @buf_size, @path, @number);
        };
        
        vectors.av_get_frame_filename2 = (byte* @buf, int @buf_size, string @path, int @number, int @flags) =>
        {
            var av_get_frame_filename2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_get_frame_filename2", ThrowErrorIfFunctionNotFound);
            vectors.av_get_frame_filename2 = av_get_frame_filename2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_frame_filename2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_frame_filename2_delegate>(av_get_frame_filename2_native_ptr);
            return vectors.av_get_frame_filename2(@buf, @buf_size, @path, @number, @flags);
        };
        
        vectors.av_get_media_type_string = (AVMediaType @media_type) =>
        {
            var av_get_media_type_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_media_type_string", ThrowErrorIfFunctionNotFound);
            vectors.av_get_media_type_string = av_get_media_type_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_media_type_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_media_type_string_delegate>(av_get_media_type_string_native_ptr);
            return vectors.av_get_media_type_string(@media_type);
        };
        
        vectors.av_get_output_timestamp = (AVFormatContext* @s, int @stream, long* @dts, long* @wall) =>
        {
            var av_get_output_timestamp_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_get_output_timestamp", ThrowErrorIfFunctionNotFound);
            vectors.av_get_output_timestamp = av_get_output_timestamp_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_output_timestamp' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_output_timestamp_delegate>(av_get_output_timestamp_native_ptr);
            return vectors.av_get_output_timestamp(@s, @stream, @dts, @wall);
        };
        
        vectors.av_get_packed_sample_fmt = (AVSampleFormat @sample_fmt) =>
        {
            var av_get_packed_sample_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_packed_sample_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_get_packed_sample_fmt = av_get_packed_sample_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_packed_sample_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_packed_sample_fmt_delegate>(av_get_packed_sample_fmt_native_ptr);
            return vectors.av_get_packed_sample_fmt(@sample_fmt);
        };
        
        vectors.av_get_packet = (AVIOContext* @s, AVPacket* @pkt, int @size) =>
        {
            var av_get_packet_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_get_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_get_packet = av_get_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_packet' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_packet_delegate>(av_get_packet_native_ptr);
            return vectors.av_get_packet(@s, @pkt, @size);
        };
        
        vectors.av_get_padded_bits_per_pixel = (AVPixFmtDescriptor* @pixdesc) =>
        {
            var av_get_padded_bits_per_pixel_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_padded_bits_per_pixel", ThrowErrorIfFunctionNotFound);
            vectors.av_get_padded_bits_per_pixel = av_get_padded_bits_per_pixel_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_padded_bits_per_pixel' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_padded_bits_per_pixel_delegate>(av_get_padded_bits_per_pixel_native_ptr);
            return vectors.av_get_padded_bits_per_pixel(@pixdesc);
        };
        
        vectors.av_get_pcm_codec = (AVSampleFormat @fmt, int @be) =>
        {
            var av_get_pcm_codec_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_get_pcm_codec", ThrowErrorIfFunctionNotFound);
            vectors.av_get_pcm_codec = av_get_pcm_codec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_pcm_codec' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_pcm_codec_delegate>(av_get_pcm_codec_native_ptr);
            return vectors.av_get_pcm_codec(@fmt, @be);
        };
        
        vectors.av_get_picture_type_char = (AVPictureType @pict_type) =>
        {
            var av_get_picture_type_char_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_picture_type_char", ThrowErrorIfFunctionNotFound);
            vectors.av_get_picture_type_char = av_get_picture_type_char_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_picture_type_char' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_picture_type_char_delegate>(av_get_picture_type_char_native_ptr);
            return vectors.av_get_picture_type_char(@pict_type);
        };
        
        vectors.av_get_pix_fmt = (string @name) =>
        {
            var av_get_pix_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_pix_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_get_pix_fmt = av_get_pix_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_pix_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_pix_fmt_delegate>(av_get_pix_fmt_native_ptr);
            return vectors.av_get_pix_fmt(@name);
        };
        
        vectors.av_get_pix_fmt_loss = (AVPixelFormat @dst_pix_fmt, AVPixelFormat @src_pix_fmt, int @has_alpha) =>
        {
            var av_get_pix_fmt_loss_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_pix_fmt_loss", ThrowErrorIfFunctionNotFound);
            vectors.av_get_pix_fmt_loss = av_get_pix_fmt_loss_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_pix_fmt_loss' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_pix_fmt_loss_delegate>(av_get_pix_fmt_loss_native_ptr);
            return vectors.av_get_pix_fmt_loss(@dst_pix_fmt, @src_pix_fmt, @has_alpha);
        };
        
        vectors.av_get_pix_fmt_name = (AVPixelFormat @pix_fmt) =>
        {
            var av_get_pix_fmt_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_pix_fmt_name", ThrowErrorIfFunctionNotFound);
            vectors.av_get_pix_fmt_name = av_get_pix_fmt_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_pix_fmt_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_pix_fmt_name_delegate>(av_get_pix_fmt_name_native_ptr);
            return vectors.av_get_pix_fmt_name(@pix_fmt);
        };
        
        vectors.av_get_pix_fmt_string = (byte* @buf, int @buf_size, AVPixelFormat @pix_fmt) =>
        {
            var av_get_pix_fmt_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_pix_fmt_string", ThrowErrorIfFunctionNotFound);
            vectors.av_get_pix_fmt_string = av_get_pix_fmt_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_pix_fmt_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_pix_fmt_string_delegate>(av_get_pix_fmt_string_native_ptr);
            return vectors.av_get_pix_fmt_string(@buf, @buf_size, @pix_fmt);
        };
        
        vectors.av_get_planar_sample_fmt = (AVSampleFormat @sample_fmt) =>
        {
            var av_get_planar_sample_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_planar_sample_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_get_planar_sample_fmt = av_get_planar_sample_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_planar_sample_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_planar_sample_fmt_delegate>(av_get_planar_sample_fmt_native_ptr);
            return vectors.av_get_planar_sample_fmt(@sample_fmt);
        };
        
        vectors.av_get_profile_name = (AVCodec* @codec, int @profile) =>
        {
            var av_get_profile_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_get_profile_name", ThrowErrorIfFunctionNotFound);
            vectors.av_get_profile_name = av_get_profile_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_profile_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_profile_name_delegate>(av_get_profile_name_native_ptr);
            return vectors.av_get_profile_name(@codec, @profile);
        };
        
        vectors.av_get_sample_fmt = (string @name) =>
        {
            var av_get_sample_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_sample_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_get_sample_fmt = av_get_sample_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_sample_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_sample_fmt_delegate>(av_get_sample_fmt_native_ptr);
            return vectors.av_get_sample_fmt(@name);
        };
        
        vectors.av_get_sample_fmt_name = (AVSampleFormat @sample_fmt) =>
        {
            var av_get_sample_fmt_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_sample_fmt_name", ThrowErrorIfFunctionNotFound);
            vectors.av_get_sample_fmt_name = av_get_sample_fmt_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_sample_fmt_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_sample_fmt_name_delegate>(av_get_sample_fmt_name_native_ptr);
            return vectors.av_get_sample_fmt_name(@sample_fmt);
        };
        
        vectors.av_get_sample_fmt_string = (byte* @buf, int @buf_size, AVSampleFormat @sample_fmt) =>
        {
            var av_get_sample_fmt_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_sample_fmt_string", ThrowErrorIfFunctionNotFound);
            vectors.av_get_sample_fmt_string = av_get_sample_fmt_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_sample_fmt_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_sample_fmt_string_delegate>(av_get_sample_fmt_string_native_ptr);
            return vectors.av_get_sample_fmt_string(@buf, @buf_size, @sample_fmt);
        };
        
        vectors.av_get_time_base_q = () =>
        {
            var av_get_time_base_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_get_time_base_q", ThrowErrorIfFunctionNotFound);
            vectors.av_get_time_base_q = av_get_time_base_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_get_time_base_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_get_time_base_q_delegate>(av_get_time_base_q_native_ptr);
            return vectors.av_get_time_base_q();
        };
        
        vectors.av_gettime = () =>
        {
            var av_gettime_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_gettime", ThrowErrorIfFunctionNotFound);
            vectors.av_gettime = av_gettime_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_gettime' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_gettime_delegate>(av_gettime_native_ptr);
            return vectors.av_gettime();
        };
        
        vectors.av_gettime_relative = () =>
        {
            var av_gettime_relative_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_gettime_relative", ThrowErrorIfFunctionNotFound);
            vectors.av_gettime_relative = av_gettime_relative_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_gettime_relative' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_gettime_relative_delegate>(av_gettime_relative_native_ptr);
            return vectors.av_gettime_relative();
        };
        
        vectors.av_gettime_relative_is_monotonic = () =>
        {
            var av_gettime_relative_is_monotonic_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_gettime_relative_is_monotonic", ThrowErrorIfFunctionNotFound);
            vectors.av_gettime_relative_is_monotonic = av_gettime_relative_is_monotonic_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_gettime_relative_is_monotonic' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_gettime_relative_is_monotonic_delegate>(av_gettime_relative_is_monotonic_native_ptr);
            return vectors.av_gettime_relative_is_monotonic();
        };
        
        vectors.av_grow_packet = (AVPacket* @pkt, int @grow_by) =>
        {
            var av_grow_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_grow_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_grow_packet = av_grow_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_grow_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_grow_packet_delegate>(av_grow_packet_native_ptr);
            return vectors.av_grow_packet(@pkt, @grow_by);
        };
        
        vectors.av_guess_codec = (AVOutputFormat* @fmt, string @short_name, string @filename, string @mime_type, AVMediaType @type) =>
        {
            var av_guess_codec_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_guess_codec", ThrowErrorIfFunctionNotFound);
            vectors.av_guess_codec = av_guess_codec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_guess_codec' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_guess_codec_delegate>(av_guess_codec_native_ptr);
            return vectors.av_guess_codec(@fmt, @short_name, @filename, @mime_type, @type);
        };
        
        vectors.av_guess_format = (string @short_name, string @filename, string @mime_type) =>
        {
            var av_guess_format_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_guess_format", ThrowErrorIfFunctionNotFound);
            vectors.av_guess_format = av_guess_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_guess_format' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_guess_format_delegate>(av_guess_format_native_ptr);
            return vectors.av_guess_format(@short_name, @filename, @mime_type);
        };
        
        vectors.av_guess_frame_rate = (AVFormatContext* @ctx, AVStream* @stream, AVFrame* @frame) =>
        {
            var av_guess_frame_rate_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_guess_frame_rate", ThrowErrorIfFunctionNotFound);
            vectors.av_guess_frame_rate = av_guess_frame_rate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_guess_frame_rate' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_guess_frame_rate_delegate>(av_guess_frame_rate_native_ptr);
            return vectors.av_guess_frame_rate(@ctx, @stream, @frame);
        };
        
        vectors.av_guess_sample_aspect_ratio = (AVFormatContext* @format, AVStream* @stream, AVFrame* @frame) =>
        {
            var av_guess_sample_aspect_ratio_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_guess_sample_aspect_ratio", ThrowErrorIfFunctionNotFound);
            vectors.av_guess_sample_aspect_ratio = av_guess_sample_aspect_ratio_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_guess_sample_aspect_ratio' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_guess_sample_aspect_ratio_delegate>(av_guess_sample_aspect_ratio_native_ptr);
            return vectors.av_guess_sample_aspect_ratio(@format, @stream, @frame);
        };
        
        vectors.av_hex_dump = (_iobuf* @f, byte* @buf, int @size) =>
        {
            var av_hex_dump_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_hex_dump", ThrowErrorIfFunctionNotFound);
            vectors.av_hex_dump = av_hex_dump_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hex_dump' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hex_dump_delegate>(av_hex_dump_native_ptr);
            vectors.av_hex_dump(@f, @buf, @size);
        };
        
        vectors.av_hex_dump_log = (void* @avcl, int @level, byte* @buf, int @size) =>
        {
            var av_hex_dump_log_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_hex_dump_log", ThrowErrorIfFunctionNotFound);
            vectors.av_hex_dump_log = av_hex_dump_log_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hex_dump_log' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hex_dump_log_delegate>(av_hex_dump_log_native_ptr);
            vectors.av_hex_dump_log(@avcl, @level, @buf, @size);
        };
        
        vectors.av_hwdevice_ctx_alloc = (AVHWDeviceType @type) =>
        {
            var av_hwdevice_ctx_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_ctx_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_ctx_alloc = av_hwdevice_ctx_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_ctx_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_ctx_alloc_delegate>(av_hwdevice_ctx_alloc_native_ptr);
            return vectors.av_hwdevice_ctx_alloc(@type);
        };
        
        vectors.av_hwdevice_ctx_create = (AVBufferRef** @device_ctx, AVHWDeviceType @type, string @device, AVDictionary* @opts, int @flags) =>
        {
            var av_hwdevice_ctx_create_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_ctx_create", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_ctx_create = av_hwdevice_ctx_create_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_ctx_create' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_ctx_create_delegate>(av_hwdevice_ctx_create_native_ptr);
            return vectors.av_hwdevice_ctx_create(@device_ctx, @type, @device, @opts, @flags);
        };
        
        vectors.av_hwdevice_ctx_create_derived = (AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, int @flags) =>
        {
            var av_hwdevice_ctx_create_derived_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_ctx_create_derived", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_ctx_create_derived = av_hwdevice_ctx_create_derived_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_ctx_create_derived' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_ctx_create_derived_delegate>(av_hwdevice_ctx_create_derived_native_ptr);
            return vectors.av_hwdevice_ctx_create_derived(@dst_ctx, @type, @src_ctx, @flags);
        };
        
        vectors.av_hwdevice_ctx_create_derived_opts = (AVBufferRef** @dst_ctx, AVHWDeviceType @type, AVBufferRef* @src_ctx, AVDictionary* @options, int @flags) =>
        {
            var av_hwdevice_ctx_create_derived_opts_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_ctx_create_derived_opts", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_ctx_create_derived_opts = av_hwdevice_ctx_create_derived_opts_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_ctx_create_derived_opts' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_ctx_create_derived_opts_delegate>(av_hwdevice_ctx_create_derived_opts_native_ptr);
            return vectors.av_hwdevice_ctx_create_derived_opts(@dst_ctx, @type, @src_ctx, @options, @flags);
        };
        
        vectors.av_hwdevice_ctx_init = (AVBufferRef* @ref) =>
        {
            var av_hwdevice_ctx_init_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_ctx_init", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_ctx_init = av_hwdevice_ctx_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_ctx_init' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_ctx_init_delegate>(av_hwdevice_ctx_init_native_ptr);
            return vectors.av_hwdevice_ctx_init(@ref);
        };
        
        vectors.av_hwdevice_find_type_by_name = (string @name) =>
        {
            var av_hwdevice_find_type_by_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_find_type_by_name", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_find_type_by_name = av_hwdevice_find_type_by_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_find_type_by_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_find_type_by_name_delegate>(av_hwdevice_find_type_by_name_native_ptr);
            return vectors.av_hwdevice_find_type_by_name(@name);
        };
        
        vectors.av_hwdevice_get_hwframe_constraints = (AVBufferRef* @ref, void* @hwconfig) =>
        {
            var av_hwdevice_get_hwframe_constraints_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_get_hwframe_constraints", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_get_hwframe_constraints = av_hwdevice_get_hwframe_constraints_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_get_hwframe_constraints' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_get_hwframe_constraints_delegate>(av_hwdevice_get_hwframe_constraints_native_ptr);
            return vectors.av_hwdevice_get_hwframe_constraints(@ref, @hwconfig);
        };
        
        vectors.av_hwdevice_get_type_name = (AVHWDeviceType @type) =>
        {
            var av_hwdevice_get_type_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_get_type_name", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_get_type_name = av_hwdevice_get_type_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_get_type_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_get_type_name_delegate>(av_hwdevice_get_type_name_native_ptr);
            return vectors.av_hwdevice_get_type_name(@type);
        };
        
        vectors.av_hwdevice_hwconfig_alloc = (AVBufferRef* @device_ctx) =>
        {
            var av_hwdevice_hwconfig_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_hwconfig_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_hwconfig_alloc = av_hwdevice_hwconfig_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_hwconfig_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_hwconfig_alloc_delegate>(av_hwdevice_hwconfig_alloc_native_ptr);
            return vectors.av_hwdevice_hwconfig_alloc(@device_ctx);
        };
        
        vectors.av_hwdevice_iterate_types = (AVHWDeviceType @prev) =>
        {
            var av_hwdevice_iterate_types_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwdevice_iterate_types", ThrowErrorIfFunctionNotFound);
            vectors.av_hwdevice_iterate_types = av_hwdevice_iterate_types_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwdevice_iterate_types' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwdevice_iterate_types_delegate>(av_hwdevice_iterate_types_native_ptr);
            return vectors.av_hwdevice_iterate_types(@prev);
        };
        
        vectors.av_hwframe_constraints_free = (AVHWFramesConstraints** @constraints) =>
        {
            var av_hwframe_constraints_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_constraints_free", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_constraints_free = av_hwframe_constraints_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_constraints_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_constraints_free_delegate>(av_hwframe_constraints_free_native_ptr);
            vectors.av_hwframe_constraints_free(@constraints);
        };
        
        vectors.av_hwframe_ctx_alloc = (AVBufferRef* @device_ctx) =>
        {
            var av_hwframe_ctx_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_ctx_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_ctx_alloc = av_hwframe_ctx_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_ctx_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_ctx_alloc_delegate>(av_hwframe_ctx_alloc_native_ptr);
            return vectors.av_hwframe_ctx_alloc(@device_ctx);
        };
        
        vectors.av_hwframe_ctx_create_derived = (AVBufferRef** @derived_frame_ctx, AVPixelFormat @format, AVBufferRef* @derived_device_ctx, AVBufferRef* @source_frame_ctx, int @flags) =>
        {
            var av_hwframe_ctx_create_derived_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_ctx_create_derived", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_ctx_create_derived = av_hwframe_ctx_create_derived_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_ctx_create_derived' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_ctx_create_derived_delegate>(av_hwframe_ctx_create_derived_native_ptr);
            return vectors.av_hwframe_ctx_create_derived(@derived_frame_ctx, @format, @derived_device_ctx, @source_frame_ctx, @flags);
        };
        
        vectors.av_hwframe_ctx_init = (AVBufferRef* @ref) =>
        {
            var av_hwframe_ctx_init_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_ctx_init", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_ctx_init = av_hwframe_ctx_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_ctx_init' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_ctx_init_delegate>(av_hwframe_ctx_init_native_ptr);
            return vectors.av_hwframe_ctx_init(@ref);
        };
        
        vectors.av_hwframe_get_buffer = (AVBufferRef* @hwframe_ctx, AVFrame* @frame, int @flags) =>
        {
            var av_hwframe_get_buffer_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_get_buffer", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_get_buffer = av_hwframe_get_buffer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_get_buffer' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_get_buffer_delegate>(av_hwframe_get_buffer_native_ptr);
            return vectors.av_hwframe_get_buffer(@hwframe_ctx, @frame, @flags);
        };
        
        vectors.av_hwframe_map = (AVFrame* @dst, AVFrame* @src, int @flags) =>
        {
            var av_hwframe_map_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_map", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_map = av_hwframe_map_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_map' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_map_delegate>(av_hwframe_map_native_ptr);
            return vectors.av_hwframe_map(@dst, @src, @flags);
        };
        
        vectors.av_hwframe_transfer_data = (AVFrame* @dst, AVFrame* @src, int @flags) =>
        {
            var av_hwframe_transfer_data_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_transfer_data", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_transfer_data = av_hwframe_transfer_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_transfer_data' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_transfer_data_delegate>(av_hwframe_transfer_data_native_ptr);
            return vectors.av_hwframe_transfer_data(@dst, @src, @flags);
        };
        
        vectors.av_hwframe_transfer_get_formats = (AVBufferRef* @hwframe_ctx, AVHWFrameTransferDirection @dir, AVPixelFormat** @formats, int @flags) =>
        {
            var av_hwframe_transfer_get_formats_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_hwframe_transfer_get_formats", ThrowErrorIfFunctionNotFound);
            vectors.av_hwframe_transfer_get_formats = av_hwframe_transfer_get_formats_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_hwframe_transfer_get_formats' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_hwframe_transfer_get_formats_delegate>(av_hwframe_transfer_get_formats_native_ptr);
            return vectors.av_hwframe_transfer_get_formats(@hwframe_ctx, @dir, @formats, @flags);
        };
        
        vectors.av_image_alloc = (ref byte_ptrArray4 @pointers, ref int_array4 @linesizes, int @w, int @h, AVPixelFormat @pix_fmt, int @align) =>
        {
            var av_image_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_image_alloc = av_image_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_alloc_delegate>(av_image_alloc_native_ptr);
            return vectors.av_image_alloc(ref @pointers, ref @linesizes, @w, @h, @pix_fmt, @align);
        };
        
        vectors.av_image_check_sar = (uint @w, uint @h, AVRational @sar) =>
        {
            var av_image_check_sar_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_check_sar", ThrowErrorIfFunctionNotFound);
            vectors.av_image_check_sar = av_image_check_sar_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_check_sar' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_check_sar_delegate>(av_image_check_sar_native_ptr);
            return vectors.av_image_check_sar(@w, @h, @sar);
        };
        
        vectors.av_image_check_size = (uint @w, uint @h, int @log_offset, void* @log_ctx) =>
        {
            var av_image_check_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_check_size", ThrowErrorIfFunctionNotFound);
            vectors.av_image_check_size = av_image_check_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_check_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_check_size_delegate>(av_image_check_size_native_ptr);
            return vectors.av_image_check_size(@w, @h, @log_offset, @log_ctx);
        };
        
        vectors.av_image_check_size2 = (uint @w, uint @h, long @max_pixels, AVPixelFormat @pix_fmt, int @log_offset, void* @log_ctx) =>
        {
            var av_image_check_size2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_check_size2", ThrowErrorIfFunctionNotFound);
            vectors.av_image_check_size2 = av_image_check_size2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_check_size2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_check_size2_delegate>(av_image_check_size2_native_ptr);
            return vectors.av_image_check_size2(@w, @h, @max_pixels, @pix_fmt, @log_offset, @log_ctx);
        };
        
        vectors.av_image_copy = (ref byte_ptrArray4 @dst_data, in int_array4 @dst_linesizes, in byte_ptrArray4 @src_data, in int_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            var av_image_copy_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_copy", ThrowErrorIfFunctionNotFound);
            vectors.av_image_copy = av_image_copy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_copy' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_copy_delegate>(av_image_copy_native_ptr);
            vectors.av_image_copy(ref @dst_data, @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
        };
        
        vectors.av_image_copy_plane = (byte* @dst, int @dst_linesize, byte* @src, int @src_linesize, int @bytewidth, int @height) =>
        {
            var av_image_copy_plane_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_copy_plane", ThrowErrorIfFunctionNotFound);
            vectors.av_image_copy_plane = av_image_copy_plane_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_copy_plane' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_copy_plane_delegate>(av_image_copy_plane_native_ptr);
            vectors.av_image_copy_plane(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        };
        
        vectors.av_image_copy_plane_uc_from = (byte* @dst, long @dst_linesize, byte* @src, long @src_linesize, long @bytewidth, int @height) =>
        {
            var av_image_copy_plane_uc_from_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_copy_plane_uc_from", ThrowErrorIfFunctionNotFound);
            vectors.av_image_copy_plane_uc_from = av_image_copy_plane_uc_from_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_copy_plane_uc_from' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_copy_plane_uc_from_delegate>(av_image_copy_plane_uc_from_native_ptr);
            vectors.av_image_copy_plane_uc_from(@dst, @dst_linesize, @src, @src_linesize, @bytewidth, @height);
        };
        
        vectors.av_image_copy_to_buffer = (byte* @dst, int @dst_size, in byte_ptrArray4 @src_data, in int_array4 @src_linesize, AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
        {
            var av_image_copy_to_buffer_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_copy_to_buffer", ThrowErrorIfFunctionNotFound);
            vectors.av_image_copy_to_buffer = av_image_copy_to_buffer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_copy_to_buffer' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_copy_to_buffer_delegate>(av_image_copy_to_buffer_native_ptr);
            return vectors.av_image_copy_to_buffer(@dst, @dst_size, @src_data, @src_linesize, @pix_fmt, @width, @height, @align);
        };
        
        vectors.av_image_copy_uc_from = (ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesizes, in byte_ptrArray4 @src_data, in long_array4 @src_linesizes, AVPixelFormat @pix_fmt, int @width, int @height) =>
        {
            var av_image_copy_uc_from_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_copy_uc_from", ThrowErrorIfFunctionNotFound);
            vectors.av_image_copy_uc_from = av_image_copy_uc_from_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_copy_uc_from' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_copy_uc_from_delegate>(av_image_copy_uc_from_native_ptr);
            vectors.av_image_copy_uc_from(ref @dst_data, @dst_linesizes, @src_data, @src_linesizes, @pix_fmt, @width, @height);
        };
        
        vectors.av_image_fill_arrays = (ref byte_ptrArray4 @dst_data, ref int_array4 @dst_linesize, byte* @src, AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
        {
            var av_image_fill_arrays_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_fill_arrays", ThrowErrorIfFunctionNotFound);
            vectors.av_image_fill_arrays = av_image_fill_arrays_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_fill_arrays' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_fill_arrays_delegate>(av_image_fill_arrays_native_ptr);
            return vectors.av_image_fill_arrays(ref @dst_data, ref @dst_linesize, @src, @pix_fmt, @width, @height, @align);
        };
        
        vectors.av_image_fill_black = (ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesize, AVPixelFormat @pix_fmt, AVColorRange @range, int @width, int @height) =>
        {
            var av_image_fill_black_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_fill_black", ThrowErrorIfFunctionNotFound);
            vectors.av_image_fill_black = av_image_fill_black_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_fill_black' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_fill_black_delegate>(av_image_fill_black_native_ptr);
            return vectors.av_image_fill_black(ref @dst_data, @dst_linesize, @pix_fmt, @range, @width, @height);
        };
        
        vectors.av_image_fill_color = (ref byte_ptrArray4 @dst_data, in long_array4 @dst_linesize, AVPixelFormat @pix_fmt, in uint_array4 @color, int @width, int @height, int @flags) =>
        {
            var av_image_fill_color_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_fill_color", ThrowErrorIfFunctionNotFound);
            vectors.av_image_fill_color = av_image_fill_color_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_fill_color' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_fill_color_delegate>(av_image_fill_color_native_ptr);
            return vectors.av_image_fill_color(ref @dst_data, @dst_linesize, @pix_fmt, @color, @width, @height, @flags);
        };
        
        vectors.av_image_fill_linesizes = (ref int_array4 @linesizes, AVPixelFormat @pix_fmt, int @width) =>
        {
            var av_image_fill_linesizes_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_fill_linesizes", ThrowErrorIfFunctionNotFound);
            vectors.av_image_fill_linesizes = av_image_fill_linesizes_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_fill_linesizes' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_fill_linesizes_delegate>(av_image_fill_linesizes_native_ptr);
            return vectors.av_image_fill_linesizes(ref @linesizes, @pix_fmt, @width);
        };
        
        vectors.av_image_fill_max_pixsteps = (ref int_array4 @max_pixsteps, ref int_array4 @max_pixstep_comps, AVPixFmtDescriptor* @pixdesc) =>
        {
            var av_image_fill_max_pixsteps_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_fill_max_pixsteps", ThrowErrorIfFunctionNotFound);
            vectors.av_image_fill_max_pixsteps = av_image_fill_max_pixsteps_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_fill_max_pixsteps' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_fill_max_pixsteps_delegate>(av_image_fill_max_pixsteps_native_ptr);
            vectors.av_image_fill_max_pixsteps(ref @max_pixsteps, ref @max_pixstep_comps, @pixdesc);
        };
        
        vectors.av_image_fill_plane_sizes = (ref ulong_array4 @size, AVPixelFormat @pix_fmt, int @height, in long_array4 @linesizes) =>
        {
            var av_image_fill_plane_sizes_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_fill_plane_sizes", ThrowErrorIfFunctionNotFound);
            vectors.av_image_fill_plane_sizes = av_image_fill_plane_sizes_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_fill_plane_sizes' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_fill_plane_sizes_delegate>(av_image_fill_plane_sizes_native_ptr);
            return vectors.av_image_fill_plane_sizes(ref @size, @pix_fmt, @height, @linesizes);
        };
        
        vectors.av_image_fill_pointers = (ref byte_ptrArray4 @data, AVPixelFormat @pix_fmt, int @height, byte* @ptr, in int_array4 @linesizes) =>
        {
            var av_image_fill_pointers_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_fill_pointers", ThrowErrorIfFunctionNotFound);
            vectors.av_image_fill_pointers = av_image_fill_pointers_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_fill_pointers' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_fill_pointers_delegate>(av_image_fill_pointers_native_ptr);
            return vectors.av_image_fill_pointers(ref @data, @pix_fmt, @height, @ptr, @linesizes);
        };
        
        vectors.av_image_get_buffer_size = (AVPixelFormat @pix_fmt, int @width, int @height, int @align) =>
        {
            var av_image_get_buffer_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_get_buffer_size", ThrowErrorIfFunctionNotFound);
            vectors.av_image_get_buffer_size = av_image_get_buffer_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_get_buffer_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_get_buffer_size_delegate>(av_image_get_buffer_size_native_ptr);
            return vectors.av_image_get_buffer_size(@pix_fmt, @width, @height, @align);
        };
        
        vectors.av_image_get_linesize = (AVPixelFormat @pix_fmt, int @width, int @plane) =>
        {
            var av_image_get_linesize_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_image_get_linesize", ThrowErrorIfFunctionNotFound);
            vectors.av_image_get_linesize = av_image_get_linesize_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_image_get_linesize' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_image_get_linesize_delegate>(av_image_get_linesize_native_ptr);
            return vectors.av_image_get_linesize(@pix_fmt, @width, @plane);
        };
        
        vectors.av_index_search_timestamp = (AVStream* @st, long @timestamp, int @flags) =>
        {
            var av_index_search_timestamp_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_index_search_timestamp", ThrowErrorIfFunctionNotFound);
            vectors.av_index_search_timestamp = av_index_search_timestamp_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_index_search_timestamp' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_index_search_timestamp_delegate>(av_index_search_timestamp_native_ptr);
            return vectors.av_index_search_timestamp(@st, @timestamp, @flags);
        };
        
        vectors.av_init_packet = (AVPacket* @pkt) =>
        {
            var av_init_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_init_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_init_packet = av_init_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_init_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_init_packet_delegate>(av_init_packet_native_ptr);
            vectors.av_init_packet(@pkt);
        };
        
        vectors.av_input_audio_device_next = (AVInputFormat* @d) =>
        {
            var av_input_audio_device_next_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "av_input_audio_device_next", ThrowErrorIfFunctionNotFound);
            vectors.av_input_audio_device_next = av_input_audio_device_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_input_audio_device_next' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_input_audio_device_next_delegate>(av_input_audio_device_next_native_ptr);
            return vectors.av_input_audio_device_next(@d);
        };
        
        vectors.av_input_video_device_next = (AVInputFormat* @d) =>
        {
            var av_input_video_device_next_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "av_input_video_device_next", ThrowErrorIfFunctionNotFound);
            vectors.av_input_video_device_next = av_input_video_device_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_input_video_device_next' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_input_video_device_next_delegate>(av_input_video_device_next_native_ptr);
            return vectors.av_input_video_device_next(@d);
        };
        
        vectors.av_int_list_length_for_size = (uint @elsize, void* @list, ulong @term) =>
        {
            var av_int_list_length_for_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_int_list_length_for_size", ThrowErrorIfFunctionNotFound);
            vectors.av_int_list_length_for_size = av_int_list_length_for_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_int_list_length_for_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_int_list_length_for_size_delegate>(av_int_list_length_for_size_native_ptr);
            return vectors.av_int_list_length_for_size(@elsize, @list, @term);
        };
        
        vectors.av_interleaved_write_frame = (AVFormatContext* @s, AVPacket* @pkt) =>
        {
            var av_interleaved_write_frame_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_interleaved_write_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_interleaved_write_frame = av_interleaved_write_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_interleaved_write_frame' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_interleaved_write_frame_delegate>(av_interleaved_write_frame_native_ptr);
            return vectors.av_interleaved_write_frame(@s, @pkt);
        };
        
        vectors.av_interleaved_write_uncoded_frame = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) =>
        {
            var av_interleaved_write_uncoded_frame_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_interleaved_write_uncoded_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_interleaved_write_uncoded_frame = av_interleaved_write_uncoded_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_interleaved_write_uncoded_frame' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_interleaved_write_uncoded_frame_delegate>(av_interleaved_write_uncoded_frame_native_ptr);
            return vectors.av_interleaved_write_uncoded_frame(@s, @stream_index, @frame);
        };
        
        vectors.av_log = (void* @avcl, int @level, string @fmt) =>
        {
            var av_log_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log", ThrowErrorIfFunctionNotFound);
            vectors.av_log = av_log_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_delegate>(av_log_native_ptr);
            vectors.av_log(@avcl, @level, @fmt);
        };
        
        vectors.av_log_default_callback = (void* @avcl, int @level, string @fmt, byte* @vl) =>
        {
            var av_log_default_callback_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_default_callback", ThrowErrorIfFunctionNotFound);
            vectors.av_log_default_callback = av_log_default_callback_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_default_callback' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_default_callback_delegate>(av_log_default_callback_native_ptr);
            vectors.av_log_default_callback(@avcl, @level, @fmt, @vl);
        };
        
        vectors.av_log_format_line = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) =>
        {
            var av_log_format_line_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_format_line", ThrowErrorIfFunctionNotFound);
            vectors.av_log_format_line = av_log_format_line_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_format_line' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_format_line_delegate>(av_log_format_line_native_ptr);
            vectors.av_log_format_line(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        };
        
        vectors.av_log_format_line2 = (void* @ptr, int @level, string @fmt, byte* @vl, byte* @line, int @line_size, int* @print_prefix) =>
        {
            var av_log_format_line2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_format_line2", ThrowErrorIfFunctionNotFound);
            vectors.av_log_format_line2 = av_log_format_line2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_format_line2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_format_line2_delegate>(av_log_format_line2_native_ptr);
            return vectors.av_log_format_line2(@ptr, @level, @fmt, @vl, @line, @line_size, @print_prefix);
        };
        
        vectors.av_log_get_flags = () =>
        {
            var av_log_get_flags_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_get_flags", ThrowErrorIfFunctionNotFound);
            vectors.av_log_get_flags = av_log_get_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_get_flags' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_get_flags_delegate>(av_log_get_flags_native_ptr);
            return vectors.av_log_get_flags();
        };
        
        vectors.av_log_get_level = () =>
        {
            var av_log_get_level_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_get_level", ThrowErrorIfFunctionNotFound);
            vectors.av_log_get_level = av_log_get_level_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_get_level' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_get_level_delegate>(av_log_get_level_native_ptr);
            return vectors.av_log_get_level();
        };
        
        vectors.av_log_once = (void* @avcl, int @initial_level, int @subsequent_level, int* @state, string @fmt) =>
        {
            var av_log_once_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_once", ThrowErrorIfFunctionNotFound);
            vectors.av_log_once = av_log_once_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_once' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_once_delegate>(av_log_once_native_ptr);
            vectors.av_log_once(@avcl, @initial_level, @subsequent_level, @state, @fmt);
        };
        
        vectors.av_log_set_callback = (av_log_set_callback_callback_func @callback) =>
        {
            var av_log_set_callback_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_set_callback", ThrowErrorIfFunctionNotFound);
            vectors.av_log_set_callback = av_log_set_callback_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_set_callback' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_set_callback_delegate>(av_log_set_callback_native_ptr);
            vectors.av_log_set_callback(@callback);
        };
        
        vectors.av_log_set_flags = (int @arg) =>
        {
            var av_log_set_flags_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_set_flags", ThrowErrorIfFunctionNotFound);
            vectors.av_log_set_flags = av_log_set_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_set_flags' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_set_flags_delegate>(av_log_set_flags_native_ptr);
            vectors.av_log_set_flags(@arg);
        };
        
        vectors.av_log_set_level = (int @level) =>
        {
            var av_log_set_level_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log_set_level", ThrowErrorIfFunctionNotFound);
            vectors.av_log_set_level = av_log_set_level_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log_set_level' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log_set_level_delegate>(av_log_set_level_native_ptr);
            vectors.av_log_set_level(@level);
        };
        
        vectors.av_log2 = (uint @v) =>
        {
            var av_log2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log2", ThrowErrorIfFunctionNotFound);
            vectors.av_log2 = av_log2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log2_delegate>(av_log2_native_ptr);
            return vectors.av_log2(@v);
        };
        
        vectors.av_log2_16bit = (uint @v) =>
        {
            var av_log2_16bit_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_log2_16bit", ThrowErrorIfFunctionNotFound);
            vectors.av_log2_16bit = av_log2_16bit_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_log2_16bit' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_log2_16bit_delegate>(av_log2_16bit_native_ptr);
            return vectors.av_log2_16bit(@v);
        };
        
        vectors.av_malloc = (ulong @size) =>
        {
            var av_malloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_malloc", ThrowErrorIfFunctionNotFound);
            vectors.av_malloc = av_malloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_malloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_malloc_delegate>(av_malloc_native_ptr);
            return vectors.av_malloc(@size);
        };
        
        vectors.av_malloc_array = (ulong @nmemb, ulong @size) =>
        {
            var av_malloc_array_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_malloc_array", ThrowErrorIfFunctionNotFound);
            vectors.av_malloc_array = av_malloc_array_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_malloc_array' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_malloc_array_delegate>(av_malloc_array_native_ptr);
            return vectors.av_malloc_array(@nmemb, @size);
        };
        
        vectors.av_mallocz = (ulong @size) =>
        {
            var av_mallocz_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_mallocz", ThrowErrorIfFunctionNotFound);
            vectors.av_mallocz = av_mallocz_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_mallocz' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_mallocz_delegate>(av_mallocz_native_ptr);
            return vectors.av_mallocz(@size);
        };
        
        vectors.av_mastering_display_metadata_alloc = () =>
        {
            var av_mastering_display_metadata_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_mastering_display_metadata_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_mastering_display_metadata_alloc = av_mastering_display_metadata_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_mastering_display_metadata_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_mastering_display_metadata_alloc_delegate>(av_mastering_display_metadata_alloc_native_ptr);
            return vectors.av_mastering_display_metadata_alloc();
        };
        
        vectors.av_mastering_display_metadata_alloc_size = (ulong* @size) =>
        {
            var av_mastering_display_metadata_alloc_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_mastering_display_metadata_alloc_size", ThrowErrorIfFunctionNotFound);
            vectors.av_mastering_display_metadata_alloc_size = av_mastering_display_metadata_alloc_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_mastering_display_metadata_alloc_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_mastering_display_metadata_alloc_size_delegate>(av_mastering_display_metadata_alloc_size_native_ptr);
            return vectors.av_mastering_display_metadata_alloc_size(@size);
        };
        
        vectors.av_mastering_display_metadata_create_side_data = (AVFrame* @frame) =>
        {
            var av_mastering_display_metadata_create_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_mastering_display_metadata_create_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_mastering_display_metadata_create_side_data = av_mastering_display_metadata_create_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_mastering_display_metadata_create_side_data' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_mastering_display_metadata_create_side_data_delegate>(av_mastering_display_metadata_create_side_data_native_ptr);
            return vectors.av_mastering_display_metadata_create_side_data(@frame);
        };
        
        vectors.av_match_ext = (string @filename, string @extensions) =>
        {
            var av_match_ext_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_match_ext", ThrowErrorIfFunctionNotFound);
            vectors.av_match_ext = av_match_ext_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_match_ext' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_match_ext_delegate>(av_match_ext_native_ptr);
            return vectors.av_match_ext(@filename, @extensions);
        };
        
        vectors.av_max_alloc = (ulong @max) =>
        {
            var av_max_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_max_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_max_alloc = av_max_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_max_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_max_alloc_delegate>(av_max_alloc_native_ptr);
            vectors.av_max_alloc(@max);
        };
        
        vectors.av_memcpy_backptr = (byte* @dst, int @back, int @cnt) =>
        {
            var av_memcpy_backptr_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_memcpy_backptr", ThrowErrorIfFunctionNotFound);
            vectors.av_memcpy_backptr = av_memcpy_backptr_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_memcpy_backptr' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_memcpy_backptr_delegate>(av_memcpy_backptr_native_ptr);
            vectors.av_memcpy_backptr(@dst, @back, @cnt);
        };
        
        vectors.av_memdup = (void* @p, ulong @size) =>
        {
            var av_memdup_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_memdup", ThrowErrorIfFunctionNotFound);
            vectors.av_memdup = av_memdup_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_memdup' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_memdup_delegate>(av_memdup_native_ptr);
            return vectors.av_memdup(@p, @size);
        };
        
        vectors.av_mime_codec_str = (AVCodecParameters* @par, AVRational @frame_rate, AVBPrint* @out) =>
        {
            var av_mime_codec_str_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_mime_codec_str", ThrowErrorIfFunctionNotFound);
            vectors.av_mime_codec_str = av_mime_codec_str_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_mime_codec_str' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_mime_codec_str_delegate>(av_mime_codec_str_native_ptr);
            return vectors.av_mime_codec_str(@par, @frame_rate, @out);
        };
        
        vectors.av_mul_q = (AVRational @b, AVRational @c) =>
        {
            var av_mul_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_mul_q", ThrowErrorIfFunctionNotFound);
            vectors.av_mul_q = av_mul_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_mul_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_mul_q_delegate>(av_mul_q_native_ptr);
            return vectors.av_mul_q(@b, @c);
        };
        
        vectors.av_muxer_iterate = (void** @opaque) =>
        {
            var av_muxer_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_muxer_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_muxer_iterate = av_muxer_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_muxer_iterate' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_muxer_iterate_delegate>(av_muxer_iterate_native_ptr);
            return vectors.av_muxer_iterate(@opaque);
        };
        
        vectors.av_nearer_q = (AVRational @q, AVRational @q1, AVRational @q2) =>
        {
            var av_nearer_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_nearer_q", ThrowErrorIfFunctionNotFound);
            vectors.av_nearer_q = av_nearer_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_nearer_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_nearer_q_delegate>(av_nearer_q_native_ptr);
            return vectors.av_nearer_q(@q, @q1, @q2);
        };
        
        vectors.av_new_packet = (AVPacket* @pkt, int @size) =>
        {
            var av_new_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_new_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_new_packet = av_new_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_new_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_new_packet_delegate>(av_new_packet_native_ptr);
            return vectors.av_new_packet(@pkt, @size);
        };
        
        vectors.av_new_program = (AVFormatContext* @s, int @id) =>
        {
            var av_new_program_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_new_program", ThrowErrorIfFunctionNotFound);
            vectors.av_new_program = av_new_program_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_new_program' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_new_program_delegate>(av_new_program_native_ptr);
            return vectors.av_new_program(@s, @id);
        };
        
        vectors.av_opt_child_class_iterate = (AVClass* @parent, void** @iter) =>
        {
            var av_opt_child_class_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_child_class_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_child_class_iterate = av_opt_child_class_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_child_class_iterate' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_child_class_iterate_delegate>(av_opt_child_class_iterate_native_ptr);
            return vectors.av_opt_child_class_iterate(@parent, @iter);
        };
        
        vectors.av_opt_child_next = (void* @obj, void* @prev) =>
        {
            var av_opt_child_next_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_child_next", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_child_next = av_opt_child_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_child_next' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_child_next_delegate>(av_opt_child_next_native_ptr);
            return vectors.av_opt_child_next(@obj, @prev);
        };
        
        vectors.av_opt_copy = (void* @dest, void* @src) =>
        {
            var av_opt_copy_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_copy", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_copy = av_opt_copy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_copy' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_copy_delegate>(av_opt_copy_native_ptr);
            return vectors.av_opt_copy(@dest, @src);
        };
        
        vectors.av_opt_eval_double = (void* @obj, AVOption* @o, string @val, double* @double_out) =>
        {
            var av_opt_eval_double_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_eval_double", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_eval_double = av_opt_eval_double_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_eval_double' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_eval_double_delegate>(av_opt_eval_double_native_ptr);
            return vectors.av_opt_eval_double(@obj, @o, @val, @double_out);
        };
        
        vectors.av_opt_eval_flags = (void* @obj, AVOption* @o, string @val, int* @flags_out) =>
        {
            var av_opt_eval_flags_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_eval_flags", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_eval_flags = av_opt_eval_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_eval_flags' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_eval_flags_delegate>(av_opt_eval_flags_native_ptr);
            return vectors.av_opt_eval_flags(@obj, @o, @val, @flags_out);
        };
        
        vectors.av_opt_eval_float = (void* @obj, AVOption* @o, string @val, float* @float_out) =>
        {
            var av_opt_eval_float_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_eval_float", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_eval_float = av_opt_eval_float_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_eval_float' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_eval_float_delegate>(av_opt_eval_float_native_ptr);
            return vectors.av_opt_eval_float(@obj, @o, @val, @float_out);
        };
        
        vectors.av_opt_eval_int = (void* @obj, AVOption* @o, string @val, int* @int_out) =>
        {
            var av_opt_eval_int_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_eval_int", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_eval_int = av_opt_eval_int_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_eval_int' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_eval_int_delegate>(av_opt_eval_int_native_ptr);
            return vectors.av_opt_eval_int(@obj, @o, @val, @int_out);
        };
        
        vectors.av_opt_eval_int64 = (void* @obj, AVOption* @o, string @val, long* @int64_out) =>
        {
            var av_opt_eval_int64_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_eval_int64", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_eval_int64 = av_opt_eval_int64_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_eval_int64' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_eval_int64_delegate>(av_opt_eval_int64_native_ptr);
            return vectors.av_opt_eval_int64(@obj, @o, @val, @int64_out);
        };
        
        vectors.av_opt_eval_q = (void* @obj, AVOption* @o, string @val, AVRational* @q_out) =>
        {
            var av_opt_eval_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_eval_q", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_eval_q = av_opt_eval_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_eval_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_eval_q_delegate>(av_opt_eval_q_native_ptr);
            return vectors.av_opt_eval_q(@obj, @o, @val, @q_out);
        };
        
        vectors.av_opt_eval_uint = (void* @obj, AVOption* @o, string @val, uint* @uint_out) =>
        {
            var av_opt_eval_uint_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_eval_uint", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_eval_uint = av_opt_eval_uint_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_eval_uint' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_eval_uint_delegate>(av_opt_eval_uint_native_ptr);
            return vectors.av_opt_eval_uint(@obj, @o, @val, @uint_out);
        };
        
        vectors.av_opt_find = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags) =>
        {
            var av_opt_find_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_find", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_find = av_opt_find_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_find' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_find_delegate>(av_opt_find_native_ptr);
            return vectors.av_opt_find(@obj, @name, @unit, @opt_flags, @search_flags);
        };
        
        vectors.av_opt_find2 = (void* @obj, string @name, string @unit, int @opt_flags, int @search_flags, void** @target_obj) =>
        {
            var av_opt_find2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_find2", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_find2 = av_opt_find2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_find2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_find2_delegate>(av_opt_find2_native_ptr);
            return vectors.av_opt_find2(@obj, @name, @unit, @opt_flags, @search_flags, @target_obj);
        };
        
        vectors.av_opt_flag_is_set = (void* @obj, string @field_name, string @flag_name) =>
        {
            var av_opt_flag_is_set_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_flag_is_set", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_flag_is_set = av_opt_flag_is_set_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_flag_is_set' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_flag_is_set_delegate>(av_opt_flag_is_set_native_ptr);
            return vectors.av_opt_flag_is_set(@obj, @field_name, @flag_name);
        };
        
        vectors.av_opt_free = (void* @obj) =>
        {
            var av_opt_free_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_free", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_free = av_opt_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_free' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_free_delegate>(av_opt_free_native_ptr);
            vectors.av_opt_free(@obj);
        };
        
        vectors.av_opt_freep_ranges = (AVOptionRanges** @ranges) =>
        {
            var av_opt_freep_ranges_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_freep_ranges", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_freep_ranges = av_opt_freep_ranges_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_freep_ranges' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_freep_ranges_delegate>(av_opt_freep_ranges_native_ptr);
            vectors.av_opt_freep_ranges(@ranges);
        };
        
        vectors.av_opt_get = (void* @obj, string @name, int @search_flags, byte** @out_val) =>
        {
            var av_opt_get_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get = av_opt_get_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_delegate>(av_opt_get_native_ptr);
            return vectors.av_opt_get(@obj, @name, @search_flags, @out_val);
        };
        
        vectors.av_opt_get_array = (void* @obj, string @name, int @search_flags, uint @start_elem, uint @nb_elems, AVOptionType @out_type, void* @out_val) =>
        {
            var av_opt_get_array_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_array", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_array = av_opt_get_array_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_array' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_array_delegate>(av_opt_get_array_native_ptr);
            return vectors.av_opt_get_array(@obj, @name, @search_flags, @start_elem, @nb_elems, @out_type, @out_val);
        };
        
        vectors.av_opt_get_array_size = (void* @obj, string @name, int @search_flags, uint* @out_val) =>
        {
            var av_opt_get_array_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_array_size", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_array_size = av_opt_get_array_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_array_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_array_size_delegate>(av_opt_get_array_size_native_ptr);
            return vectors.av_opt_get_array_size(@obj, @name, @search_flags, @out_val);
        };
        
        vectors.av_opt_get_chlayout = (void* @obj, string @name, int @search_flags, AVChannelLayout* @layout) =>
        {
            var av_opt_get_chlayout_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_chlayout", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_chlayout = av_opt_get_chlayout_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_chlayout' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_chlayout_delegate>(av_opt_get_chlayout_native_ptr);
            return vectors.av_opt_get_chlayout(@obj, @name, @search_flags, @layout);
        };
        
        vectors.av_opt_get_dict_val = (void* @obj, string @name, int @search_flags, AVDictionary** @out_val) =>
        {
            var av_opt_get_dict_val_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_dict_val", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_dict_val = av_opt_get_dict_val_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_dict_val' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_dict_val_delegate>(av_opt_get_dict_val_native_ptr);
            return vectors.av_opt_get_dict_val(@obj, @name, @search_flags, @out_val);
        };
        
        vectors.av_opt_get_double = (void* @obj, string @name, int @search_flags, double* @out_val) =>
        {
            var av_opt_get_double_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_double", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_double = av_opt_get_double_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_double' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_double_delegate>(av_opt_get_double_native_ptr);
            return vectors.av_opt_get_double(@obj, @name, @search_flags, @out_val);
        };
        
        vectors.av_opt_get_image_size = (void* @obj, string @name, int @search_flags, int* @w_out, int* @h_out) =>
        {
            var av_opt_get_image_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_image_size", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_image_size = av_opt_get_image_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_image_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_image_size_delegate>(av_opt_get_image_size_native_ptr);
            return vectors.av_opt_get_image_size(@obj, @name, @search_flags, @w_out, @h_out);
        };
        
        vectors.av_opt_get_int = (void* @obj, string @name, int @search_flags, long* @out_val) =>
        {
            var av_opt_get_int_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_int", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_int = av_opt_get_int_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_int' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_int_delegate>(av_opt_get_int_native_ptr);
            return vectors.av_opt_get_int(@obj, @name, @search_flags, @out_val);
        };
        
        vectors.av_opt_get_key_value = (byte** @ropts, string @key_val_sep, string @pairs_sep, uint @flags, byte** @rkey, byte** @rval) =>
        {
            var av_opt_get_key_value_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_key_value", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_key_value = av_opt_get_key_value_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_key_value' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_key_value_delegate>(av_opt_get_key_value_native_ptr);
            return vectors.av_opt_get_key_value(@ropts, @key_val_sep, @pairs_sep, @flags, @rkey, @rval);
        };
        
        vectors.av_opt_get_pixel_fmt = (void* @obj, string @name, int @search_flags, AVPixelFormat* @out_fmt) =>
        {
            var av_opt_get_pixel_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_pixel_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_pixel_fmt = av_opt_get_pixel_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_pixel_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_pixel_fmt_delegate>(av_opt_get_pixel_fmt_native_ptr);
            return vectors.av_opt_get_pixel_fmt(@obj, @name, @search_flags, @out_fmt);
        };
        
        vectors.av_opt_get_q = (void* @obj, string @name, int @search_flags, AVRational* @out_val) =>
        {
            var av_opt_get_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_q", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_q = av_opt_get_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_q_delegate>(av_opt_get_q_native_ptr);
            return vectors.av_opt_get_q(@obj, @name, @search_flags, @out_val);
        };
        
        vectors.av_opt_get_sample_fmt = (void* @obj, string @name, int @search_flags, AVSampleFormat* @out_fmt) =>
        {
            var av_opt_get_sample_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_sample_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_sample_fmt = av_opt_get_sample_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_sample_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_sample_fmt_delegate>(av_opt_get_sample_fmt_native_ptr);
            return vectors.av_opt_get_sample_fmt(@obj, @name, @search_flags, @out_fmt);
        };
        
        vectors.av_opt_get_video_rate = (void* @obj, string @name, int @search_flags, AVRational* @out_val) =>
        {
            var av_opt_get_video_rate_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_get_video_rate", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_get_video_rate = av_opt_get_video_rate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_get_video_rate' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_get_video_rate_delegate>(av_opt_get_video_rate_native_ptr);
            return vectors.av_opt_get_video_rate(@obj, @name, @search_flags, @out_val);
        };
        
        vectors.av_opt_is_set_to_default = (void* @obj, AVOption* @o) =>
        {
            var av_opt_is_set_to_default_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_is_set_to_default", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_is_set_to_default = av_opt_is_set_to_default_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_is_set_to_default' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_is_set_to_default_delegate>(av_opt_is_set_to_default_native_ptr);
            return vectors.av_opt_is_set_to_default(@obj, @o);
        };
        
        vectors.av_opt_is_set_to_default_by_name = (void* @obj, string @name, int @search_flags) =>
        {
            var av_opt_is_set_to_default_by_name_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_is_set_to_default_by_name", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_is_set_to_default_by_name = av_opt_is_set_to_default_by_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_is_set_to_default_by_name' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_is_set_to_default_by_name_delegate>(av_opt_is_set_to_default_by_name_native_ptr);
            return vectors.av_opt_is_set_to_default_by_name(@obj, @name, @search_flags);
        };
        
        vectors.av_opt_next = (void* @obj, AVOption* @prev) =>
        {
            var av_opt_next_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_next", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_next = av_opt_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_next' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_next_delegate>(av_opt_next_native_ptr);
            return vectors.av_opt_next(@obj, @prev);
        };
        
        vectors.av_opt_ptr = (AVClass* @avclass, void* @obj, string @name) =>
        {
            var av_opt_ptr_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_ptr", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_ptr = av_opt_ptr_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_ptr' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_ptr_delegate>(av_opt_ptr_native_ptr);
            return vectors.av_opt_ptr(@avclass, @obj, @name);
        };
        
        vectors.av_opt_query_ranges = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) =>
        {
            var av_opt_query_ranges_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_query_ranges", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_query_ranges = av_opt_query_ranges_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_query_ranges' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_query_ranges_delegate>(av_opt_query_ranges_native_ptr);
            return vectors.av_opt_query_ranges(@p0, @obj, @key, @flags);
        };
        
        vectors.av_opt_query_ranges_default = (AVOptionRanges** @p0, void* @obj, string @key, int @flags) =>
        {
            var av_opt_query_ranges_default_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_query_ranges_default", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_query_ranges_default = av_opt_query_ranges_default_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_query_ranges_default' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_query_ranges_default_delegate>(av_opt_query_ranges_default_native_ptr);
            return vectors.av_opt_query_ranges_default(@p0, @obj, @key, @flags);
        };
        
        vectors.av_opt_serialize = (void* @obj, int @opt_flags, int @flags, byte** @buffer, byte @key_val_sep, byte @pairs_sep) =>
        {
            var av_opt_serialize_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_serialize", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_serialize = av_opt_serialize_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_serialize' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_serialize_delegate>(av_opt_serialize_native_ptr);
            return vectors.av_opt_serialize(@obj, @opt_flags, @flags, @buffer, @key_val_sep, @pairs_sep);
        };
        
        vectors.av_opt_set = (void* @obj, string @name, string @val, int @search_flags) =>
        {
            var av_opt_set_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set = av_opt_set_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_delegate>(av_opt_set_native_ptr);
            return vectors.av_opt_set(@obj, @name, @val, @search_flags);
        };
        
        vectors.av_opt_set_array = (void* @obj, string @name, int @search_flags, uint @start_elem, uint @nb_elems, AVOptionType @val_type, void* @val) =>
        {
            var av_opt_set_array_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_array", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_array = av_opt_set_array_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_array' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_array_delegate>(av_opt_set_array_native_ptr);
            return vectors.av_opt_set_array(@obj, @name, @search_flags, @start_elem, @nb_elems, @val_type, @val);
        };
        
        vectors.av_opt_set_bin = (void* @obj, string @name, byte* @val, int @size, int @search_flags) =>
        {
            var av_opt_set_bin_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_bin", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_bin = av_opt_set_bin_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_bin' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_bin_delegate>(av_opt_set_bin_native_ptr);
            return vectors.av_opt_set_bin(@obj, @name, @val, @size, @search_flags);
        };
        
        vectors.av_opt_set_chlayout = (void* @obj, string @name, AVChannelLayout* @layout, int @search_flags) =>
        {
            var av_opt_set_chlayout_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_chlayout", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_chlayout = av_opt_set_chlayout_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_chlayout' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_chlayout_delegate>(av_opt_set_chlayout_native_ptr);
            return vectors.av_opt_set_chlayout(@obj, @name, @layout, @search_flags);
        };
        
        vectors.av_opt_set_defaults = (void* @s) =>
        {
            var av_opt_set_defaults_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_defaults", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_defaults = av_opt_set_defaults_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_defaults' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_defaults_delegate>(av_opt_set_defaults_native_ptr);
            vectors.av_opt_set_defaults(@s);
        };
        
        vectors.av_opt_set_defaults2 = (void* @s, int @mask, int @flags) =>
        {
            var av_opt_set_defaults2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_defaults2", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_defaults2 = av_opt_set_defaults2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_defaults2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_defaults2_delegate>(av_opt_set_defaults2_native_ptr);
            vectors.av_opt_set_defaults2(@s, @mask, @flags);
        };
        
        vectors.av_opt_set_dict = (void* @obj, AVDictionary** @options) =>
        {
            var av_opt_set_dict_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_dict", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_dict = av_opt_set_dict_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_dict' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_dict_delegate>(av_opt_set_dict_native_ptr);
            return vectors.av_opt_set_dict(@obj, @options);
        };
        
        vectors.av_opt_set_dict_val = (void* @obj, string @name, AVDictionary* @val, int @search_flags) =>
        {
            var av_opt_set_dict_val_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_dict_val", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_dict_val = av_opt_set_dict_val_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_dict_val' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_dict_val_delegate>(av_opt_set_dict_val_native_ptr);
            return vectors.av_opt_set_dict_val(@obj, @name, @val, @search_flags);
        };
        
        vectors.av_opt_set_dict2 = (void* @obj, AVDictionary** @options, int @search_flags) =>
        {
            var av_opt_set_dict2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_dict2", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_dict2 = av_opt_set_dict2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_dict2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_dict2_delegate>(av_opt_set_dict2_native_ptr);
            return vectors.av_opt_set_dict2(@obj, @options, @search_flags);
        };
        
        vectors.av_opt_set_double = (void* @obj, string @name, double @val, int @search_flags) =>
        {
            var av_opt_set_double_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_double", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_double = av_opt_set_double_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_double' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_double_delegate>(av_opt_set_double_native_ptr);
            return vectors.av_opt_set_double(@obj, @name, @val, @search_flags);
        };
        
        vectors.av_opt_set_from_string = (void* @ctx, string @opts, byte** @shorthand, string @key_val_sep, string @pairs_sep) =>
        {
            var av_opt_set_from_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_from_string", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_from_string = av_opt_set_from_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_from_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_from_string_delegate>(av_opt_set_from_string_native_ptr);
            return vectors.av_opt_set_from_string(@ctx, @opts, @shorthand, @key_val_sep, @pairs_sep);
        };
        
        vectors.av_opt_set_image_size = (void* @obj, string @name, int @w, int @h, int @search_flags) =>
        {
            var av_opt_set_image_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_image_size", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_image_size = av_opt_set_image_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_image_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_image_size_delegate>(av_opt_set_image_size_native_ptr);
            return vectors.av_opt_set_image_size(@obj, @name, @w, @h, @search_flags);
        };
        
        vectors.av_opt_set_int = (void* @obj, string @name, long @val, int @search_flags) =>
        {
            var av_opt_set_int_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_int", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_int = av_opt_set_int_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_int' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_int_delegate>(av_opt_set_int_native_ptr);
            return vectors.av_opt_set_int(@obj, @name, @val, @search_flags);
        };
        
        vectors.av_opt_set_pixel_fmt = (void* @obj, string @name, AVPixelFormat @fmt, int @search_flags) =>
        {
            var av_opt_set_pixel_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_pixel_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_pixel_fmt = av_opt_set_pixel_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_pixel_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_pixel_fmt_delegate>(av_opt_set_pixel_fmt_native_ptr);
            return vectors.av_opt_set_pixel_fmt(@obj, @name, @fmt, @search_flags);
        };
        
        vectors.av_opt_set_q = (void* @obj, string @name, AVRational @val, int @search_flags) =>
        {
            var av_opt_set_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_q", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_q = av_opt_set_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_q_delegate>(av_opt_set_q_native_ptr);
            return vectors.av_opt_set_q(@obj, @name, @val, @search_flags);
        };
        
        vectors.av_opt_set_sample_fmt = (void* @obj, string @name, AVSampleFormat @fmt, int @search_flags) =>
        {
            var av_opt_set_sample_fmt_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_sample_fmt", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_sample_fmt = av_opt_set_sample_fmt_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_sample_fmt' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_sample_fmt_delegate>(av_opt_set_sample_fmt_native_ptr);
            return vectors.av_opt_set_sample_fmt(@obj, @name, @fmt, @search_flags);
        };
        
        vectors.av_opt_set_video_rate = (void* @obj, string @name, AVRational @val, int @search_flags) =>
        {
            var av_opt_set_video_rate_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_set_video_rate", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_set_video_rate = av_opt_set_video_rate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_set_video_rate' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_set_video_rate_delegate>(av_opt_set_video_rate_native_ptr);
            return vectors.av_opt_set_video_rate(@obj, @name, @val, @search_flags);
        };
        
        vectors.av_opt_show2 = (void* @obj, void* @av_log_obj, int @req_flags, int @rej_flags) =>
        {
            var av_opt_show2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_opt_show2", ThrowErrorIfFunctionNotFound);
            vectors.av_opt_show2 = av_opt_show2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_opt_show2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_opt_show2_delegate>(av_opt_show2_native_ptr);
            return vectors.av_opt_show2(@obj, @av_log_obj, @req_flags, @rej_flags);
        };
        
        vectors.av_output_audio_device_next = (AVOutputFormat* @d) =>
        {
            var av_output_audio_device_next_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "av_output_audio_device_next", ThrowErrorIfFunctionNotFound);
            vectors.av_output_audio_device_next = av_output_audio_device_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_output_audio_device_next' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_output_audio_device_next_delegate>(av_output_audio_device_next_native_ptr);
            return vectors.av_output_audio_device_next(@d);
        };
        
        vectors.av_output_video_device_next = (AVOutputFormat* @d) =>
        {
            var av_output_video_device_next_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "av_output_video_device_next", ThrowErrorIfFunctionNotFound);
            vectors.av_output_video_device_next = av_output_video_device_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_output_video_device_next' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_output_video_device_next_delegate>(av_output_video_device_next_native_ptr);
            return vectors.av_output_video_device_next(@d);
        };
        
        vectors.av_packet_add_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, byte* @data, ulong @size) =>
        {
            var av_packet_add_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_add_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_add_side_data = av_packet_add_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_add_side_data' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_add_side_data_delegate>(av_packet_add_side_data_native_ptr);
            return vectors.av_packet_add_side_data(@pkt, @type, @data, @size);
        };
        
        vectors.av_packet_alloc = () =>
        {
            var av_packet_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_alloc = av_packet_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_alloc' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_alloc_delegate>(av_packet_alloc_native_ptr);
            return vectors.av_packet_alloc();
        };
        
        vectors.av_packet_clone = (AVPacket* @src) =>
        {
            var av_packet_clone_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_clone", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_clone = av_packet_clone_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_clone' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_clone_delegate>(av_packet_clone_native_ptr);
            return vectors.av_packet_clone(@src);
        };
        
        vectors.av_packet_copy_props = (AVPacket* @dst, AVPacket* @src) =>
        {
            var av_packet_copy_props_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_copy_props", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_copy_props = av_packet_copy_props_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_copy_props' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_copy_props_delegate>(av_packet_copy_props_native_ptr);
            return vectors.av_packet_copy_props(@dst, @src);
        };
        
        vectors.av_packet_free = (AVPacket** @pkt) =>
        {
            var av_packet_free_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_free", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_free = av_packet_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_free' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_free_delegate>(av_packet_free_native_ptr);
            vectors.av_packet_free(@pkt);
        };
        
        vectors.av_packet_free_side_data = (AVPacket* @pkt) =>
        {
            var av_packet_free_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_free_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_free_side_data = av_packet_free_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_free_side_data' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_free_side_data_delegate>(av_packet_free_side_data_native_ptr);
            vectors.av_packet_free_side_data(@pkt);
        };
        
        vectors.av_packet_from_data = (AVPacket* @pkt, byte* @data, int @size) =>
        {
            var av_packet_from_data_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_from_data", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_from_data = av_packet_from_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_from_data' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_from_data_delegate>(av_packet_from_data_native_ptr);
            return vectors.av_packet_from_data(@pkt, @data, @size);
        };
        
        vectors.av_packet_get_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong* @size) =>
        {
            var av_packet_get_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_get_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_get_side_data = av_packet_get_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_get_side_data' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_get_side_data_delegate>(av_packet_get_side_data_native_ptr);
            return vectors.av_packet_get_side_data(@pkt, @type, @size);
        };
        
        vectors.av_packet_make_refcounted = (AVPacket* @pkt) =>
        {
            var av_packet_make_refcounted_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_make_refcounted", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_make_refcounted = av_packet_make_refcounted_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_make_refcounted' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_make_refcounted_delegate>(av_packet_make_refcounted_native_ptr);
            return vectors.av_packet_make_refcounted(@pkt);
        };
        
        vectors.av_packet_make_writable = (AVPacket* @pkt) =>
        {
            var av_packet_make_writable_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_make_writable", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_make_writable = av_packet_make_writable_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_make_writable' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_make_writable_delegate>(av_packet_make_writable_native_ptr);
            return vectors.av_packet_make_writable(@pkt);
        };
        
        vectors.av_packet_move_ref = (AVPacket* @dst, AVPacket* @src) =>
        {
            var av_packet_move_ref_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_move_ref", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_move_ref = av_packet_move_ref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_move_ref' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_move_ref_delegate>(av_packet_move_ref_native_ptr);
            vectors.av_packet_move_ref(@dst, @src);
        };
        
        vectors.av_packet_new_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong @size) =>
        {
            var av_packet_new_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_new_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_new_side_data = av_packet_new_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_new_side_data' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_new_side_data_delegate>(av_packet_new_side_data_native_ptr);
            return vectors.av_packet_new_side_data(@pkt, @type, @size);
        };
        
        vectors.av_packet_pack_dictionary = (AVDictionary* @dict, ulong* @size) =>
        {
            var av_packet_pack_dictionary_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_pack_dictionary", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_pack_dictionary = av_packet_pack_dictionary_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_pack_dictionary' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_pack_dictionary_delegate>(av_packet_pack_dictionary_native_ptr);
            return vectors.av_packet_pack_dictionary(@dict, @size);
        };
        
        vectors.av_packet_ref = (AVPacket* @dst, AVPacket* @src) =>
        {
            var av_packet_ref_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_ref", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_ref = av_packet_ref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_ref' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_ref_delegate>(av_packet_ref_native_ptr);
            return vectors.av_packet_ref(@dst, @src);
        };
        
        vectors.av_packet_rescale_ts = (AVPacket* @pkt, AVRational @tb_src, AVRational @tb_dst) =>
        {
            var av_packet_rescale_ts_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_rescale_ts", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_rescale_ts = av_packet_rescale_ts_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_rescale_ts' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_rescale_ts_delegate>(av_packet_rescale_ts_native_ptr);
            vectors.av_packet_rescale_ts(@pkt, @tb_src, @tb_dst);
        };
        
        vectors.av_packet_shrink_side_data = (AVPacket* @pkt, AVPacketSideDataType @type, ulong @size) =>
        {
            var av_packet_shrink_side_data_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_shrink_side_data", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_shrink_side_data = av_packet_shrink_side_data_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_shrink_side_data' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_shrink_side_data_delegate>(av_packet_shrink_side_data_native_ptr);
            return vectors.av_packet_shrink_side_data(@pkt, @type, @size);
        };
        
        vectors.av_packet_side_data_add = (AVPacketSideData** @sd, int* @nb_sd, AVPacketSideDataType @type, void* @data, ulong @size, int @flags) =>
        {
            var av_packet_side_data_add_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_add", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_add = av_packet_side_data_add_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_add' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_add_delegate>(av_packet_side_data_add_native_ptr);
            return vectors.av_packet_side_data_add(@sd, @nb_sd, @type, @data, @size, @flags);
        };
        
        vectors.av_packet_side_data_free = (AVPacketSideData** @sd, int* @nb_sd) =>
        {
            var av_packet_side_data_free_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_free", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_free = av_packet_side_data_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_free' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_free_delegate>(av_packet_side_data_free_native_ptr);
            vectors.av_packet_side_data_free(@sd, @nb_sd);
        };
        
        vectors.av_packet_side_data_from_frame = (AVPacketSideData** @sd, int* @nb_sd, AVFrameSideData* @src, uint @flags) =>
        {
            var av_packet_side_data_from_frame_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_from_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_from_frame = av_packet_side_data_from_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_from_frame' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_from_frame_delegate>(av_packet_side_data_from_frame_native_ptr);
            return vectors.av_packet_side_data_from_frame(@sd, @nb_sd, @src, @flags);
        };
        
        vectors.av_packet_side_data_get = (AVPacketSideData* @sd, int @nb_sd, AVPacketSideDataType @type) =>
        {
            var av_packet_side_data_get_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_get", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_get = av_packet_side_data_get_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_get' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_get_delegate>(av_packet_side_data_get_native_ptr);
            return vectors.av_packet_side_data_get(@sd, @nb_sd, @type);
        };
        
        vectors.av_packet_side_data_name = (AVPacketSideDataType @type) =>
        {
            var av_packet_side_data_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_name", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_name = av_packet_side_data_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_name_delegate>(av_packet_side_data_name_native_ptr);
            return vectors.av_packet_side_data_name(@type);
        };
        
        vectors.av_packet_side_data_new = (AVPacketSideData** @psd, int* @pnb_sd, AVPacketSideDataType @type, ulong @size, int @flags) =>
        {
            var av_packet_side_data_new_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_new", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_new = av_packet_side_data_new_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_new' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_new_delegate>(av_packet_side_data_new_native_ptr);
            return vectors.av_packet_side_data_new(@psd, @pnb_sd, @type, @size, @flags);
        };
        
        vectors.av_packet_side_data_remove = (AVPacketSideData* @sd, int* @nb_sd, AVPacketSideDataType @type) =>
        {
            var av_packet_side_data_remove_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_remove", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_remove = av_packet_side_data_remove_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_remove' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_remove_delegate>(av_packet_side_data_remove_native_ptr);
            vectors.av_packet_side_data_remove(@sd, @nb_sd, @type);
        };
        
        vectors.av_packet_side_data_to_frame = (AVFrameSideData*** @sd, int* @nb_sd, AVPacketSideData* @src, uint @flags) =>
        {
            var av_packet_side_data_to_frame_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_side_data_to_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_side_data_to_frame = av_packet_side_data_to_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_side_data_to_frame' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_side_data_to_frame_delegate>(av_packet_side_data_to_frame_native_ptr);
            return vectors.av_packet_side_data_to_frame(@sd, @nb_sd, @src, @flags);
        };
        
        vectors.av_packet_unpack_dictionary = (byte* @data, ulong @size, AVDictionary** @dict) =>
        {
            var av_packet_unpack_dictionary_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_unpack_dictionary", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_unpack_dictionary = av_packet_unpack_dictionary_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_unpack_dictionary' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_unpack_dictionary_delegate>(av_packet_unpack_dictionary_native_ptr);
            return vectors.av_packet_unpack_dictionary(@data, @size, @dict);
        };
        
        vectors.av_packet_unref = (AVPacket* @pkt) =>
        {
            var av_packet_unref_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_packet_unref", ThrowErrorIfFunctionNotFound);
            vectors.av_packet_unref = av_packet_unref_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_packet_unref' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_packet_unref_delegate>(av_packet_unref_native_ptr);
            vectors.av_packet_unref(@pkt);
        };
        
        vectors.av_parse_cpu_caps = (uint* @flags, string @s) =>
        {
            var av_parse_cpu_caps_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_parse_cpu_caps", ThrowErrorIfFunctionNotFound);
            vectors.av_parse_cpu_caps = av_parse_cpu_caps_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_parse_cpu_caps' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_parse_cpu_caps_delegate>(av_parse_cpu_caps_native_ptr);
            return vectors.av_parse_cpu_caps(@flags, @s);
        };
        
        vectors.av_parser_close = (AVCodecParserContext* @s) =>
        {
            var av_parser_close_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_parser_close", ThrowErrorIfFunctionNotFound);
            vectors.av_parser_close = av_parser_close_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_parser_close' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_parser_close_delegate>(av_parser_close_native_ptr);
            vectors.av_parser_close(@s);
        };
        
        vectors.av_parser_init = (int @codec_id) =>
        {
            var av_parser_init_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_parser_init", ThrowErrorIfFunctionNotFound);
            vectors.av_parser_init = av_parser_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_parser_init' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_parser_init_delegate>(av_parser_init_native_ptr);
            return vectors.av_parser_init(@codec_id);
        };
        
        vectors.av_parser_iterate = (void** @opaque) =>
        {
            var av_parser_iterate_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_parser_iterate", ThrowErrorIfFunctionNotFound);
            vectors.av_parser_iterate = av_parser_iterate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_parser_iterate' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_parser_iterate_delegate>(av_parser_iterate_native_ptr);
            return vectors.av_parser_iterate(@opaque);
        };
        
        vectors.av_parser_parse2 = (AVCodecParserContext* @s, AVCodecContext* @avctx, byte** @poutbuf, int* @poutbuf_size, byte* @buf, int @buf_size, long @pts, long @dts, long @pos) =>
        {
            var av_parser_parse2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_parser_parse2", ThrowErrorIfFunctionNotFound);
            vectors.av_parser_parse2 = av_parser_parse2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_parser_parse2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_parser_parse2_delegate>(av_parser_parse2_native_ptr);
            return vectors.av_parser_parse2(@s, @avctx, @poutbuf, @poutbuf_size, @buf, @buf_size, @pts, @dts, @pos);
        };
        
        vectors.av_pix_fmt_count_planes = (AVPixelFormat @pix_fmt) =>
        {
            var av_pix_fmt_count_planes_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_pix_fmt_count_planes", ThrowErrorIfFunctionNotFound);
            vectors.av_pix_fmt_count_planes = av_pix_fmt_count_planes_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pix_fmt_count_planes' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pix_fmt_count_planes_delegate>(av_pix_fmt_count_planes_native_ptr);
            return vectors.av_pix_fmt_count_planes(@pix_fmt);
        };
        
        vectors.av_pix_fmt_desc_get = (AVPixelFormat @pix_fmt) =>
        {
            var av_pix_fmt_desc_get_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_pix_fmt_desc_get", ThrowErrorIfFunctionNotFound);
            vectors.av_pix_fmt_desc_get = av_pix_fmt_desc_get_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pix_fmt_desc_get' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pix_fmt_desc_get_delegate>(av_pix_fmt_desc_get_native_ptr);
            return vectors.av_pix_fmt_desc_get(@pix_fmt);
        };
        
        vectors.av_pix_fmt_desc_get_id = (AVPixFmtDescriptor* @desc) =>
        {
            var av_pix_fmt_desc_get_id_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_pix_fmt_desc_get_id", ThrowErrorIfFunctionNotFound);
            vectors.av_pix_fmt_desc_get_id = av_pix_fmt_desc_get_id_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pix_fmt_desc_get_id' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pix_fmt_desc_get_id_delegate>(av_pix_fmt_desc_get_id_native_ptr);
            return vectors.av_pix_fmt_desc_get_id(@desc);
        };
        
        vectors.av_pix_fmt_desc_next = (AVPixFmtDescriptor* @prev) =>
        {
            var av_pix_fmt_desc_next_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_pix_fmt_desc_next", ThrowErrorIfFunctionNotFound);
            vectors.av_pix_fmt_desc_next = av_pix_fmt_desc_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pix_fmt_desc_next' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pix_fmt_desc_next_delegate>(av_pix_fmt_desc_next_native_ptr);
            return vectors.av_pix_fmt_desc_next(@prev);
        };
        
        vectors.av_pix_fmt_get_chroma_sub_sample = (AVPixelFormat @pix_fmt, int* @h_shift, int* @v_shift) =>
        {
            var av_pix_fmt_get_chroma_sub_sample_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_pix_fmt_get_chroma_sub_sample", ThrowErrorIfFunctionNotFound);
            vectors.av_pix_fmt_get_chroma_sub_sample = av_pix_fmt_get_chroma_sub_sample_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pix_fmt_get_chroma_sub_sample' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pix_fmt_get_chroma_sub_sample_delegate>(av_pix_fmt_get_chroma_sub_sample_native_ptr);
            return vectors.av_pix_fmt_get_chroma_sub_sample(@pix_fmt, @h_shift, @v_shift);
        };
        
        vectors.av_pix_fmt_swap_endianness = (AVPixelFormat @pix_fmt) =>
        {
            var av_pix_fmt_swap_endianness_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_pix_fmt_swap_endianness", ThrowErrorIfFunctionNotFound);
            vectors.av_pix_fmt_swap_endianness = av_pix_fmt_swap_endianness_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pix_fmt_swap_endianness' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pix_fmt_swap_endianness_delegate>(av_pix_fmt_swap_endianness_native_ptr);
            return vectors.av_pix_fmt_swap_endianness(@pix_fmt);
        };
        
        vectors.av_pkt_dump_log2 = (void* @avcl, int @level, AVPacket* @pkt, int @dump_payload, AVStream* @st) =>
        {
            var av_pkt_dump_log2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_pkt_dump_log2", ThrowErrorIfFunctionNotFound);
            vectors.av_pkt_dump_log2 = av_pkt_dump_log2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pkt_dump_log2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pkt_dump_log2_delegate>(av_pkt_dump_log2_native_ptr);
            vectors.av_pkt_dump_log2(@avcl, @level, @pkt, @dump_payload, @st);
        };
        
        vectors.av_pkt_dump2 = (_iobuf* @f, AVPacket* @pkt, int @dump_payload, AVStream* @st) =>
        {
            var av_pkt_dump2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_pkt_dump2", ThrowErrorIfFunctionNotFound);
            vectors.av_pkt_dump2 = av_pkt_dump2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_pkt_dump2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_pkt_dump2_delegate>(av_pkt_dump2_native_ptr);
            vectors.av_pkt_dump2(@f, @pkt, @dump_payload, @st);
        };
        
        vectors.av_probe_input_buffer = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) =>
        {
            var av_probe_input_buffer_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_probe_input_buffer", ThrowErrorIfFunctionNotFound);
            vectors.av_probe_input_buffer = av_probe_input_buffer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_probe_input_buffer' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_probe_input_buffer_delegate>(av_probe_input_buffer_native_ptr);
            return vectors.av_probe_input_buffer(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        };
        
        vectors.av_probe_input_buffer2 = (AVIOContext* @pb, AVInputFormat** @fmt, string @url, void* @logctx, uint @offset, uint @max_probe_size) =>
        {
            var av_probe_input_buffer2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_probe_input_buffer2", ThrowErrorIfFunctionNotFound);
            vectors.av_probe_input_buffer2 = av_probe_input_buffer2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_probe_input_buffer2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_probe_input_buffer2_delegate>(av_probe_input_buffer2_native_ptr);
            return vectors.av_probe_input_buffer2(@pb, @fmt, @url, @logctx, @offset, @max_probe_size);
        };
        
        vectors.av_probe_input_format = (AVProbeData* @pd, int @is_opened) =>
        {
            var av_probe_input_format_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_probe_input_format", ThrowErrorIfFunctionNotFound);
            vectors.av_probe_input_format = av_probe_input_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_probe_input_format' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_probe_input_format_delegate>(av_probe_input_format_native_ptr);
            return vectors.av_probe_input_format(@pd, @is_opened);
        };
        
        vectors.av_probe_input_format2 = (AVProbeData* @pd, int @is_opened, int* @score_max) =>
        {
            var av_probe_input_format2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_probe_input_format2", ThrowErrorIfFunctionNotFound);
            vectors.av_probe_input_format2 = av_probe_input_format2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_probe_input_format2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_probe_input_format2_delegate>(av_probe_input_format2_native_ptr);
            return vectors.av_probe_input_format2(@pd, @is_opened, @score_max);
        };
        
        vectors.av_probe_input_format3 = (AVProbeData* @pd, int @is_opened, int* @score_ret) =>
        {
            var av_probe_input_format3_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_probe_input_format3", ThrowErrorIfFunctionNotFound);
            vectors.av_probe_input_format3 = av_probe_input_format3_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_probe_input_format3' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_probe_input_format3_delegate>(av_probe_input_format3_native_ptr);
            return vectors.av_probe_input_format3(@pd, @is_opened, @score_ret);
        };
        
        vectors.av_program_add_stream_index = (AVFormatContext* @ac, int @progid, uint @idx) =>
        {
            var av_program_add_stream_index_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_program_add_stream_index", ThrowErrorIfFunctionNotFound);
            vectors.av_program_add_stream_index = av_program_add_stream_index_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_program_add_stream_index' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_program_add_stream_index_delegate>(av_program_add_stream_index_native_ptr);
            vectors.av_program_add_stream_index(@ac, @progid, @idx);
        };
        
        vectors.av_q2intfloat = (AVRational @q) =>
        {
            var av_q2intfloat_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_q2intfloat", ThrowErrorIfFunctionNotFound);
            vectors.av_q2intfloat = av_q2intfloat_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_q2intfloat' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_q2intfloat_delegate>(av_q2intfloat_native_ptr);
            return vectors.av_q2intfloat(@q);
        };
        
        vectors.av_read_frame = (AVFormatContext* @s, AVPacket* @pkt) =>
        {
            var av_read_frame_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_read_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_read_frame = av_read_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_read_frame' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_read_frame_delegate>(av_read_frame_native_ptr);
            return vectors.av_read_frame(@s, @pkt);
        };
        
        vectors.av_read_image_line = (ushort* @dst, in byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component) =>
        {
            var av_read_image_line_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_read_image_line", ThrowErrorIfFunctionNotFound);
            vectors.av_read_image_line = av_read_image_line_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_read_image_line' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_read_image_line_delegate>(av_read_image_line_native_ptr);
            vectors.av_read_image_line(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component);
        };
        
        vectors.av_read_image_line2 = (void* @dst, in byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @read_pal_component, int @dst_element_size) =>
        {
            var av_read_image_line2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_read_image_line2", ThrowErrorIfFunctionNotFound);
            vectors.av_read_image_line2 = av_read_image_line2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_read_image_line2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_read_image_line2_delegate>(av_read_image_line2_native_ptr);
            vectors.av_read_image_line2(@dst, @data, @linesize, @desc, @x, @y, @c, @w, @read_pal_component, @dst_element_size);
        };
        
        vectors.av_read_pause = (AVFormatContext* @s) =>
        {
            var av_read_pause_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_read_pause", ThrowErrorIfFunctionNotFound);
            vectors.av_read_pause = av_read_pause_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_read_pause' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_read_pause_delegate>(av_read_pause_native_ptr);
            return vectors.av_read_pause(@s);
        };
        
        vectors.av_read_play = (AVFormatContext* @s) =>
        {
            var av_read_play_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_read_play", ThrowErrorIfFunctionNotFound);
            vectors.av_read_play = av_read_play_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_read_play' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_read_play_delegate>(av_read_play_native_ptr);
            return vectors.av_read_play(@s);
        };
        
        vectors.av_realloc = (void* @ptr, ulong @size) =>
        {
            var av_realloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_realloc", ThrowErrorIfFunctionNotFound);
            vectors.av_realloc = av_realloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_realloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_realloc_delegate>(av_realloc_native_ptr);
            return vectors.av_realloc(@ptr, @size);
        };
        
        vectors.av_realloc_array = (void* @ptr, ulong @nmemb, ulong @size) =>
        {
            var av_realloc_array_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_realloc_array", ThrowErrorIfFunctionNotFound);
            vectors.av_realloc_array = av_realloc_array_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_realloc_array' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_realloc_array_delegate>(av_realloc_array_native_ptr);
            return vectors.av_realloc_array(@ptr, @nmemb, @size);
        };
        
        vectors.av_realloc_f = (void* @ptr, ulong @nelem, ulong @elsize) =>
        {
            var av_realloc_f_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_realloc_f", ThrowErrorIfFunctionNotFound);
            vectors.av_realloc_f = av_realloc_f_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_realloc_f' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_realloc_f_delegate>(av_realloc_f_native_ptr);
            return vectors.av_realloc_f(@ptr, @nelem, @elsize);
        };
        
        vectors.av_reallocp = (void* @ptr, ulong @size) =>
        {
            var av_reallocp_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_reallocp", ThrowErrorIfFunctionNotFound);
            vectors.av_reallocp = av_reallocp_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_reallocp' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_reallocp_delegate>(av_reallocp_native_ptr);
            return vectors.av_reallocp(@ptr, @size);
        };
        
        vectors.av_reallocp_array = (void* @ptr, ulong @nmemb, ulong @size) =>
        {
            var av_reallocp_array_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_reallocp_array", ThrowErrorIfFunctionNotFound);
            vectors.av_reallocp_array = av_reallocp_array_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_reallocp_array' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_reallocp_array_delegate>(av_reallocp_array_native_ptr);
            return vectors.av_reallocp_array(@ptr, @nmemb, @size);
        };
        
        vectors.av_reduce = (int* @dst_num, int* @dst_den, long @num, long @den, long @max) =>
        {
            var av_reduce_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_reduce", ThrowErrorIfFunctionNotFound);
            vectors.av_reduce = av_reduce_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_reduce' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_reduce_delegate>(av_reduce_native_ptr);
            return vectors.av_reduce(@dst_num, @dst_den, @num, @den, @max);
        };
        
        vectors.av_rescale = (long @a, long @b, long @c) =>
        {
            var av_rescale_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_rescale", ThrowErrorIfFunctionNotFound);
            vectors.av_rescale = av_rescale_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_rescale' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_rescale_delegate>(av_rescale_native_ptr);
            return vectors.av_rescale(@a, @b, @c);
        };
        
        vectors.av_rescale_delta = (AVRational @in_tb, long @in_ts, AVRational @fs_tb, int @duration, long* @last, AVRational @out_tb) =>
        {
            var av_rescale_delta_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_rescale_delta", ThrowErrorIfFunctionNotFound);
            vectors.av_rescale_delta = av_rescale_delta_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_rescale_delta' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_rescale_delta_delegate>(av_rescale_delta_native_ptr);
            return vectors.av_rescale_delta(@in_tb, @in_ts, @fs_tb, @duration, @last, @out_tb);
        };
        
        vectors.av_rescale_q = (long @a, AVRational @bq, AVRational @cq) =>
        {
            var av_rescale_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_rescale_q", ThrowErrorIfFunctionNotFound);
            vectors.av_rescale_q = av_rescale_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_rescale_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_rescale_q_delegate>(av_rescale_q_native_ptr);
            return vectors.av_rescale_q(@a, @bq, @cq);
        };
        
        vectors.av_rescale_q_rnd = (long @a, AVRational @bq, AVRational @cq, AVRounding @rnd) =>
        {
            var av_rescale_q_rnd_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_rescale_q_rnd", ThrowErrorIfFunctionNotFound);
            vectors.av_rescale_q_rnd = av_rescale_q_rnd_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_rescale_q_rnd' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_rescale_q_rnd_delegate>(av_rescale_q_rnd_native_ptr);
            return vectors.av_rescale_q_rnd(@a, @bq, @cq, @rnd);
        };
        
        vectors.av_rescale_rnd = (long @a, long @b, long @c, AVRounding @rnd) =>
        {
            var av_rescale_rnd_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_rescale_rnd", ThrowErrorIfFunctionNotFound);
            vectors.av_rescale_rnd = av_rescale_rnd_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_rescale_rnd' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_rescale_rnd_delegate>(av_rescale_rnd_native_ptr);
            return vectors.av_rescale_rnd(@a, @b, @c, @rnd);
        };
        
        vectors.av_sample_fmt_is_planar = (AVSampleFormat @sample_fmt) =>
        {
            var av_sample_fmt_is_planar_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_sample_fmt_is_planar", ThrowErrorIfFunctionNotFound);
            vectors.av_sample_fmt_is_planar = av_sample_fmt_is_planar_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_sample_fmt_is_planar' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_sample_fmt_is_planar_delegate>(av_sample_fmt_is_planar_native_ptr);
            return vectors.av_sample_fmt_is_planar(@sample_fmt);
        };
        
        vectors.av_samples_alloc = (byte** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            var av_samples_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_samples_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_samples_alloc = av_samples_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_samples_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_samples_alloc_delegate>(av_samples_alloc_native_ptr);
            return vectors.av_samples_alloc(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        
        vectors.av_samples_alloc_array_and_samples = (byte*** @audio_data, int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            var av_samples_alloc_array_and_samples_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_samples_alloc_array_and_samples", ThrowErrorIfFunctionNotFound);
            vectors.av_samples_alloc_array_and_samples = av_samples_alloc_array_and_samples_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_samples_alloc_array_and_samples' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_samples_alloc_array_and_samples_delegate>(av_samples_alloc_array_and_samples_native_ptr);
            return vectors.av_samples_alloc_array_and_samples(@audio_data, @linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        
        vectors.av_samples_copy = (byte** @dst, byte** @src, int @dst_offset, int @src_offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) =>
        {
            var av_samples_copy_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_samples_copy", ThrowErrorIfFunctionNotFound);
            vectors.av_samples_copy = av_samples_copy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_samples_copy' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_samples_copy_delegate>(av_samples_copy_native_ptr);
            return vectors.av_samples_copy(@dst, @src, @dst_offset, @src_offset, @nb_samples, @nb_channels, @sample_fmt);
        };
        
        vectors.av_samples_fill_arrays = (byte** @audio_data, int* @linesize, byte* @buf, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            var av_samples_fill_arrays_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_samples_fill_arrays", ThrowErrorIfFunctionNotFound);
            vectors.av_samples_fill_arrays = av_samples_fill_arrays_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_samples_fill_arrays' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_samples_fill_arrays_delegate>(av_samples_fill_arrays_native_ptr);
            return vectors.av_samples_fill_arrays(@audio_data, @linesize, @buf, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        
        vectors.av_samples_get_buffer_size = (int* @linesize, int @nb_channels, int @nb_samples, AVSampleFormat @sample_fmt, int @align) =>
        {
            var av_samples_get_buffer_size_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_samples_get_buffer_size", ThrowErrorIfFunctionNotFound);
            vectors.av_samples_get_buffer_size = av_samples_get_buffer_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_samples_get_buffer_size' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_samples_get_buffer_size_delegate>(av_samples_get_buffer_size_native_ptr);
            return vectors.av_samples_get_buffer_size(@linesize, @nb_channels, @nb_samples, @sample_fmt, @align);
        };
        
        vectors.av_samples_set_silence = (byte** @audio_data, int @offset, int @nb_samples, int @nb_channels, AVSampleFormat @sample_fmt) =>
        {
            var av_samples_set_silence_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_samples_set_silence", ThrowErrorIfFunctionNotFound);
            vectors.av_samples_set_silence = av_samples_set_silence_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_samples_set_silence' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_samples_set_silence_delegate>(av_samples_set_silence_native_ptr);
            return vectors.av_samples_set_silence(@audio_data, @offset, @nb_samples, @nb_channels, @sample_fmt);
        };
        
        vectors.av_sdp_create = (AVFormatContext** @ac, int @n_files, byte* @buf, int @size) =>
        {
            var av_sdp_create_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_sdp_create", ThrowErrorIfFunctionNotFound);
            vectors.av_sdp_create = av_sdp_create_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_sdp_create' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_sdp_create_delegate>(av_sdp_create_native_ptr);
            return vectors.av_sdp_create(@ac, @n_files, @buf, @size);
        };
        
        vectors.av_seek_frame = (AVFormatContext* @s, int @stream_index, long @timestamp, int @flags) =>
        {
            var av_seek_frame_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_seek_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_seek_frame = av_seek_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_seek_frame' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_seek_frame_delegate>(av_seek_frame_native_ptr);
            return vectors.av_seek_frame(@s, @stream_index, @timestamp, @flags);
        };
        
        vectors.av_set_options_string = (void* @ctx, string @opts, string @key_val_sep, string @pairs_sep) =>
        {
            var av_set_options_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_set_options_string", ThrowErrorIfFunctionNotFound);
            vectors.av_set_options_string = av_set_options_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_set_options_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_set_options_string_delegate>(av_set_options_string_native_ptr);
            return vectors.av_set_options_string(@ctx, @opts, @key_val_sep, @pairs_sep);
        };
        
        vectors.av_shrink_packet = (AVPacket* @pkt, int @size) =>
        {
            var av_shrink_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_shrink_packet", ThrowErrorIfFunctionNotFound);
            vectors.av_shrink_packet = av_shrink_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_shrink_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_shrink_packet_delegate>(av_shrink_packet_native_ptr);
            vectors.av_shrink_packet(@pkt, @size);
        };
        
        vectors.av_size_mult = (ulong @a, ulong @b, ulong* @r) =>
        {
            var av_size_mult_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_size_mult", ThrowErrorIfFunctionNotFound);
            vectors.av_size_mult = av_size_mult_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_size_mult' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_size_mult_delegate>(av_size_mult_native_ptr);
            return vectors.av_size_mult(@a, @b, @r);
        };
        
        vectors.av_strdup = (string @s) =>
        {
            var av_strdup_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_strdup", ThrowErrorIfFunctionNotFound);
            vectors.av_strdup = av_strdup_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_strdup' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_strdup_delegate>(av_strdup_native_ptr);
            return vectors.av_strdup(@s);
        };
        
        vectors.av_stream_get_class = () =>
        {
            var av_stream_get_class_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_stream_get_class", ThrowErrorIfFunctionNotFound);
            vectors.av_stream_get_class = av_stream_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_stream_get_class' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_stream_get_class_delegate>(av_stream_get_class_native_ptr);
            return vectors.av_stream_get_class();
        };
        
        vectors.av_stream_get_codec_timebase = (AVStream* @st) =>
        {
            var av_stream_get_codec_timebase_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_stream_get_codec_timebase", ThrowErrorIfFunctionNotFound);
            vectors.av_stream_get_codec_timebase = av_stream_get_codec_timebase_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_stream_get_codec_timebase' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_stream_get_codec_timebase_delegate>(av_stream_get_codec_timebase_native_ptr);
            return vectors.av_stream_get_codec_timebase(@st);
        };
        
        vectors.av_stream_get_parser = (AVStream* @s) =>
        {
            var av_stream_get_parser_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_stream_get_parser", ThrowErrorIfFunctionNotFound);
            vectors.av_stream_get_parser = av_stream_get_parser_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_stream_get_parser' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_stream_get_parser_delegate>(av_stream_get_parser_native_ptr);
            return vectors.av_stream_get_parser(@s);
        };
        
        vectors.av_stream_group_get_class = () =>
        {
            var av_stream_group_get_class_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_stream_group_get_class", ThrowErrorIfFunctionNotFound);
            vectors.av_stream_group_get_class = av_stream_group_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_stream_group_get_class' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_stream_group_get_class_delegate>(av_stream_group_get_class_native_ptr);
            return vectors.av_stream_group_get_class();
        };
        
        vectors.av_strerror = (int @errnum, byte* @errbuf, ulong @errbuf_size) =>
        {
            var av_strerror_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_strerror", ThrowErrorIfFunctionNotFound);
            vectors.av_strerror = av_strerror_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_strerror' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_strerror_delegate>(av_strerror_native_ptr);
            return vectors.av_strerror(@errnum, @errbuf, @errbuf_size);
        };
        
        vectors.av_strndup = (string @s, ulong @len) =>
        {
            var av_strndup_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_strndup", ThrowErrorIfFunctionNotFound);
            vectors.av_strndup = av_strndup_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_strndup' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_strndup_delegate>(av_strndup_native_ptr);
            return vectors.av_strndup(@s, @len);
        };
        
        vectors.av_sub_q = (AVRational @b, AVRational @c) =>
        {
            var av_sub_q_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_sub_q", ThrowErrorIfFunctionNotFound);
            vectors.av_sub_q = av_sub_q_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_sub_q' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_sub_q_delegate>(av_sub_q_native_ptr);
            return vectors.av_sub_q(@b, @c);
        };
        
        vectors.av_timecode_adjust_ntsc_framenum2 = (int @framenum, int @fps) =>
        {
            var av_timecode_adjust_ntsc_framenum2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_adjust_ntsc_framenum2", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_adjust_ntsc_framenum2 = av_timecode_adjust_ntsc_framenum2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_adjust_ntsc_framenum2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_adjust_ntsc_framenum2_delegate>(av_timecode_adjust_ntsc_framenum2_native_ptr);
            return vectors.av_timecode_adjust_ntsc_framenum2(@framenum, @fps);
        };
        
        vectors.av_timecode_check_frame_rate = (AVRational @rate) =>
        {
            var av_timecode_check_frame_rate_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_check_frame_rate", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_check_frame_rate = av_timecode_check_frame_rate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_check_frame_rate' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_check_frame_rate_delegate>(av_timecode_check_frame_rate_native_ptr);
            return vectors.av_timecode_check_frame_rate(@rate);
        };
        
        vectors.av_timecode_get_smpte = (AVRational @rate, int @drop, int @hh, int @mm, int @ss, int @ff) =>
        {
            var av_timecode_get_smpte_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_get_smpte", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_get_smpte = av_timecode_get_smpte_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_get_smpte' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_get_smpte_delegate>(av_timecode_get_smpte_native_ptr);
            return vectors.av_timecode_get_smpte(@rate, @drop, @hh, @mm, @ss, @ff);
        };
        
        vectors.av_timecode_get_smpte_from_framenum = (AVTimecode* @tc, int @framenum) =>
        {
            var av_timecode_get_smpte_from_framenum_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_get_smpte_from_framenum", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_get_smpte_from_framenum = av_timecode_get_smpte_from_framenum_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_get_smpte_from_framenum' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_get_smpte_from_framenum_delegate>(av_timecode_get_smpte_from_framenum_native_ptr);
            return vectors.av_timecode_get_smpte_from_framenum(@tc, @framenum);
        };
        
        vectors.av_timecode_init = (AVTimecode* @tc, AVRational @rate, int @flags, int @frame_start, void* @log_ctx) =>
        {
            var av_timecode_init_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_init", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_init = av_timecode_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_init' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_init_delegate>(av_timecode_init_native_ptr);
            return vectors.av_timecode_init(@tc, @rate, @flags, @frame_start, @log_ctx);
        };
        
        vectors.av_timecode_init_from_components = (AVTimecode* @tc, AVRational @rate, int @flags, int @hh, int @mm, int @ss, int @ff, void* @log_ctx) =>
        {
            var av_timecode_init_from_components_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_init_from_components", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_init_from_components = av_timecode_init_from_components_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_init_from_components' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_init_from_components_delegate>(av_timecode_init_from_components_native_ptr);
            return vectors.av_timecode_init_from_components(@tc, @rate, @flags, @hh, @mm, @ss, @ff, @log_ctx);
        };
        
        vectors.av_timecode_init_from_string = (AVTimecode* @tc, AVRational @rate, string @str, void* @log_ctx) =>
        {
            var av_timecode_init_from_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_init_from_string", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_init_from_string = av_timecode_init_from_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_init_from_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_init_from_string_delegate>(av_timecode_init_from_string_native_ptr);
            return vectors.av_timecode_init_from_string(@tc, @rate, @str, @log_ctx);
        };
        
        vectors.av_timecode_make_mpeg_tc_string = (byte* @buf, uint @tc25bit) =>
        {
            var av_timecode_make_mpeg_tc_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_make_mpeg_tc_string", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_make_mpeg_tc_string = av_timecode_make_mpeg_tc_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_make_mpeg_tc_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_make_mpeg_tc_string_delegate>(av_timecode_make_mpeg_tc_string_native_ptr);
            return vectors.av_timecode_make_mpeg_tc_string(@buf, @tc25bit);
        };
        
        vectors.av_timecode_make_smpte_tc_string = (byte* @buf, uint @tcsmpte, int @prevent_df) =>
        {
            var av_timecode_make_smpte_tc_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_make_smpte_tc_string", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_make_smpte_tc_string = av_timecode_make_smpte_tc_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_make_smpte_tc_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_make_smpte_tc_string_delegate>(av_timecode_make_smpte_tc_string_native_ptr);
            return vectors.av_timecode_make_smpte_tc_string(@buf, @tcsmpte, @prevent_df);
        };
        
        vectors.av_timecode_make_smpte_tc_string2 = (byte* @buf, AVRational @rate, uint @tcsmpte, int @prevent_df, int @skip_field) =>
        {
            var av_timecode_make_smpte_tc_string2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_make_smpte_tc_string2", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_make_smpte_tc_string2 = av_timecode_make_smpte_tc_string2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_make_smpte_tc_string2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_make_smpte_tc_string2_delegate>(av_timecode_make_smpte_tc_string2_native_ptr);
            return vectors.av_timecode_make_smpte_tc_string2(@buf, @rate, @tcsmpte, @prevent_df, @skip_field);
        };
        
        vectors.av_timecode_make_string = (AVTimecode* @tc, byte* @buf, int @framenum) =>
        {
            var av_timecode_make_string_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_timecode_make_string", ThrowErrorIfFunctionNotFound);
            vectors.av_timecode_make_string = av_timecode_make_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_timecode_make_string' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_timecode_make_string_delegate>(av_timecode_make_string_native_ptr);
            return vectors.av_timecode_make_string(@tc, @buf, @framenum);
        };
        
        vectors.av_tree_destroy = (AVTreeNode* @t) =>
        {
            var av_tree_destroy_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_tree_destroy", ThrowErrorIfFunctionNotFound);
            vectors.av_tree_destroy = av_tree_destroy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_tree_destroy' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_tree_destroy_delegate>(av_tree_destroy_native_ptr);
            vectors.av_tree_destroy(@t);
        };
        
        vectors.av_tree_enumerate = (AVTreeNode* @t, void* @opaque, av_tree_enumerate_cmp_func @cmp, av_tree_enumerate_enu_func @enu) =>
        {
            var av_tree_enumerate_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_tree_enumerate", ThrowErrorIfFunctionNotFound);
            vectors.av_tree_enumerate = av_tree_enumerate_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_tree_enumerate' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_tree_enumerate_delegate>(av_tree_enumerate_native_ptr);
            vectors.av_tree_enumerate(@t, @opaque, @cmp, @enu);
        };
        
        vectors.av_tree_find = (AVTreeNode* @root, void* @key, av_tree_find_cmp_func @cmp, ref void_ptrArray2 @next) =>
        {
            var av_tree_find_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_tree_find", ThrowErrorIfFunctionNotFound);
            vectors.av_tree_find = av_tree_find_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_tree_find' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_tree_find_delegate>(av_tree_find_native_ptr);
            return vectors.av_tree_find(@root, @key, @cmp, ref @next);
        };
        
        vectors.av_tree_insert = (AVTreeNode** @rootp, void* @key, av_tree_insert_cmp_func @cmp, AVTreeNode** @next) =>
        {
            var av_tree_insert_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_tree_insert", ThrowErrorIfFunctionNotFound);
            vectors.av_tree_insert = av_tree_insert_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_tree_insert' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_tree_insert_delegate>(av_tree_insert_native_ptr);
            return vectors.av_tree_insert(@rootp, @key, @cmp, @next);
        };
        
        vectors.av_tree_node_alloc = () =>
        {
            var av_tree_node_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_tree_node_alloc", ThrowErrorIfFunctionNotFound);
            vectors.av_tree_node_alloc = av_tree_node_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_tree_node_alloc' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_tree_node_alloc_delegate>(av_tree_node_alloc_native_ptr);
            return vectors.av_tree_node_alloc();
        };
        
        vectors.av_url_split = (byte* @proto, int @proto_size, byte* @authorization, int @authorization_size, byte* @hostname, int @hostname_size, int* @port_ptr, byte* @path, int @path_size, string @url) =>
        {
            var av_url_split_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_url_split", ThrowErrorIfFunctionNotFound);
            vectors.av_url_split = av_url_split_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_url_split' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_url_split_delegate>(av_url_split_native_ptr);
            vectors.av_url_split(@proto, @proto_size, @authorization, @authorization_size, @hostname, @hostname_size, @port_ptr, @path, @path_size, @url);
        };
        
        vectors.av_usleep = (uint @usec) =>
        {
            var av_usleep_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_usleep", ThrowErrorIfFunctionNotFound);
            vectors.av_usleep = av_usleep_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_usleep' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_usleep_delegate>(av_usleep_native_ptr);
            return vectors.av_usleep(@usec);
        };
        
        vectors.av_version_info = () =>
        {
            var av_version_info_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_version_info", ThrowErrorIfFunctionNotFound);
            vectors.av_version_info = av_version_info_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_version_info' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_version_info_delegate>(av_version_info_native_ptr);
            return vectors.av_version_info();
        };
        
        vectors.av_vlog = (void* @avcl, int @level, string @fmt, byte* @vl) =>
        {
            var av_vlog_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_vlog", ThrowErrorIfFunctionNotFound);
            vectors.av_vlog = av_vlog_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_vlog' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_vlog_delegate>(av_vlog_native_ptr);
            vectors.av_vlog(@avcl, @level, @fmt, @vl);
        };
        
        vectors.av_write_frame = (AVFormatContext* @s, AVPacket* @pkt) =>
        {
            var av_write_frame_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_write_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_write_frame = av_write_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_write_frame' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_write_frame_delegate>(av_write_frame_native_ptr);
            return vectors.av_write_frame(@s, @pkt);
        };
        
        vectors.av_write_image_line = (ushort* @src, ref byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w) =>
        {
            var av_write_image_line_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_write_image_line", ThrowErrorIfFunctionNotFound);
            vectors.av_write_image_line = av_write_image_line_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_write_image_line' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_write_image_line_delegate>(av_write_image_line_native_ptr);
            vectors.av_write_image_line(@src, ref @data, @linesize, @desc, @x, @y, @c, @w);
        };
        
        vectors.av_write_image_line2 = (void* @src, ref byte_ptrArray4 @data, in int_array4 @linesize, AVPixFmtDescriptor* @desc, int @x, int @y, int @c, int @w, int @src_element_size) =>
        {
            var av_write_image_line2_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "av_write_image_line2", ThrowErrorIfFunctionNotFound);
            vectors.av_write_image_line2 = av_write_image_line2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_write_image_line2' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_write_image_line2_delegate>(av_write_image_line2_native_ptr);
            vectors.av_write_image_line2(@src, ref @data, @linesize, @desc, @x, @y, @c, @w, @src_element_size);
        };
        
        vectors.av_write_trailer = (AVFormatContext* @s) =>
        {
            var av_write_trailer_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_write_trailer", ThrowErrorIfFunctionNotFound);
            vectors.av_write_trailer = av_write_trailer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_write_trailer' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_write_trailer_delegate>(av_write_trailer_native_ptr);
            return vectors.av_write_trailer(@s);
        };
        
        vectors.av_write_uncoded_frame = (AVFormatContext* @s, int @stream_index, AVFrame* @frame) =>
        {
            var av_write_uncoded_frame_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_write_uncoded_frame", ThrowErrorIfFunctionNotFound);
            vectors.av_write_uncoded_frame = av_write_uncoded_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_write_uncoded_frame' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_write_uncoded_frame_delegate>(av_write_uncoded_frame_native_ptr);
            return vectors.av_write_uncoded_frame(@s, @stream_index, @frame);
        };
        
        vectors.av_write_uncoded_frame_query = (AVFormatContext* @s, int @stream_index) =>
        {
            var av_write_uncoded_frame_query_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "av_write_uncoded_frame_query", ThrowErrorIfFunctionNotFound);
            vectors.av_write_uncoded_frame_query = av_write_uncoded_frame_query_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_write_uncoded_frame_query' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_write_uncoded_frame_query_delegate>(av_write_uncoded_frame_query_native_ptr);
            return vectors.av_write_uncoded_frame_query(@s, @stream_index);
        };
        
        vectors.av_xiphlacing = (byte* @s, uint @v) =>
        {
            var av_xiphlacing_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "av_xiphlacing", ThrowErrorIfFunctionNotFound);
            vectors.av_xiphlacing = av_xiphlacing_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'av_xiphlacing' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.av_xiphlacing_delegate>(av_xiphlacing_native_ptr);
            return vectors.av_xiphlacing(@s, @v);
        };
        
        vectors.avcodec_align_dimensions = (AVCodecContext* @s, int* @width, int* @height) =>
        {
            var avcodec_align_dimensions_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_align_dimensions", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_align_dimensions = avcodec_align_dimensions_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_align_dimensions' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_align_dimensions_delegate>(avcodec_align_dimensions_native_ptr);
            vectors.avcodec_align_dimensions(@s, @width, @height);
        };
        
        vectors.avcodec_align_dimensions2 = (AVCodecContext* @s, int* @width, int* @height, ref int_array8 @linesize_align) =>
        {
            var avcodec_align_dimensions2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_align_dimensions2", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_align_dimensions2 = avcodec_align_dimensions2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_align_dimensions2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_align_dimensions2_delegate>(avcodec_align_dimensions2_native_ptr);
            vectors.avcodec_align_dimensions2(@s, @width, @height, ref @linesize_align);
        };
        
        vectors.avcodec_alloc_context3 = (AVCodec* @codec) =>
        {
            var avcodec_alloc_context3_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_alloc_context3", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_alloc_context3 = avcodec_alloc_context3_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_alloc_context3' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_alloc_context3_delegate>(avcodec_alloc_context3_native_ptr);
            return vectors.avcodec_alloc_context3(@codec);
        };
        
        vectors.avcodec_configuration = () =>
        {
            var avcodec_configuration_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_configuration", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_configuration = avcodec_configuration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_configuration' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_configuration_delegate>(avcodec_configuration_native_ptr);
            return vectors.avcodec_configuration();
        };
        
        vectors.avcodec_decode_subtitle2 = (AVCodecContext* @avctx, AVSubtitle* @sub, int* @got_sub_ptr, AVPacket* @avpkt) =>
        {
            var avcodec_decode_subtitle2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_decode_subtitle2", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_decode_subtitle2 = avcodec_decode_subtitle2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_decode_subtitle2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_decode_subtitle2_delegate>(avcodec_decode_subtitle2_native_ptr);
            return vectors.avcodec_decode_subtitle2(@avctx, @sub, @got_sub_ptr, @avpkt);
        };
        
        vectors.avcodec_default_execute = (AVCodecContext* @c, avcodec_default_execute_func_func @func, void* @arg, int* @ret, int @count, int @size) =>
        {
            var avcodec_default_execute_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_default_execute", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_default_execute = avcodec_default_execute_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_default_execute' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_default_execute_delegate>(avcodec_default_execute_native_ptr);
            return vectors.avcodec_default_execute(@c, @func, @arg, @ret, @count, @size);
        };
        
        vectors.avcodec_default_execute2 = (AVCodecContext* @c, avcodec_default_execute2_func_func @func, void* @arg, int* @ret, int @count) =>
        {
            var avcodec_default_execute2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_default_execute2", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_default_execute2 = avcodec_default_execute2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_default_execute2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_default_execute2_delegate>(avcodec_default_execute2_native_ptr);
            return vectors.avcodec_default_execute2(@c, @func, @arg, @ret, @count);
        };
        
        vectors.avcodec_default_get_buffer2 = (AVCodecContext* @s, AVFrame* @frame, int @flags) =>
        {
            var avcodec_default_get_buffer2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_default_get_buffer2", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_default_get_buffer2 = avcodec_default_get_buffer2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_default_get_buffer2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_default_get_buffer2_delegate>(avcodec_default_get_buffer2_native_ptr);
            return vectors.avcodec_default_get_buffer2(@s, @frame, @flags);
        };
        
        vectors.avcodec_default_get_encode_buffer = (AVCodecContext* @s, AVPacket* @pkt, int @flags) =>
        {
            var avcodec_default_get_encode_buffer_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_default_get_encode_buffer", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_default_get_encode_buffer = avcodec_default_get_encode_buffer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_default_get_encode_buffer' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_default_get_encode_buffer_delegate>(avcodec_default_get_encode_buffer_native_ptr);
            return vectors.avcodec_default_get_encode_buffer(@s, @pkt, @flags);
        };
        
        vectors.avcodec_default_get_format = (AVCodecContext* @s, AVPixelFormat* @fmt) =>
        {
            var avcodec_default_get_format_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_default_get_format", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_default_get_format = avcodec_default_get_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_default_get_format' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_default_get_format_delegate>(avcodec_default_get_format_native_ptr);
            return vectors.avcodec_default_get_format(@s, @fmt);
        };
        
        vectors.avcodec_descriptor_get = (AVCodecID @id) =>
        {
            var avcodec_descriptor_get_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_descriptor_get", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_descriptor_get = avcodec_descriptor_get_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_descriptor_get' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_descriptor_get_delegate>(avcodec_descriptor_get_native_ptr);
            return vectors.avcodec_descriptor_get(@id);
        };
        
        vectors.avcodec_descriptor_get_by_name = (string @name) =>
        {
            var avcodec_descriptor_get_by_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_descriptor_get_by_name", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_descriptor_get_by_name = avcodec_descriptor_get_by_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_descriptor_get_by_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_descriptor_get_by_name_delegate>(avcodec_descriptor_get_by_name_native_ptr);
            return vectors.avcodec_descriptor_get_by_name(@name);
        };
        
        vectors.avcodec_descriptor_next = (AVCodecDescriptor* @prev) =>
        {
            var avcodec_descriptor_next_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_descriptor_next", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_descriptor_next = avcodec_descriptor_next_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_descriptor_next' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_descriptor_next_delegate>(avcodec_descriptor_next_native_ptr);
            return vectors.avcodec_descriptor_next(@prev);
        };
        
        vectors.avcodec_encode_subtitle = (AVCodecContext* @avctx, byte* @buf, int @buf_size, AVSubtitle* @sub) =>
        {
            var avcodec_encode_subtitle_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_encode_subtitle", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_encode_subtitle = avcodec_encode_subtitle_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_encode_subtitle' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_encode_subtitle_delegate>(avcodec_encode_subtitle_native_ptr);
            return vectors.avcodec_encode_subtitle(@avctx, @buf, @buf_size, @sub);
        };
        
        vectors.avcodec_fill_audio_frame = (AVFrame* @frame, int @nb_channels, AVSampleFormat @sample_fmt, byte* @buf, int @buf_size, int @align) =>
        {
            var avcodec_fill_audio_frame_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_fill_audio_frame", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_fill_audio_frame = avcodec_fill_audio_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_fill_audio_frame' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_fill_audio_frame_delegate>(avcodec_fill_audio_frame_native_ptr);
            return vectors.avcodec_fill_audio_frame(@frame, @nb_channels, @sample_fmt, @buf, @buf_size, @align);
        };
        
        vectors.avcodec_find_best_pix_fmt_of_list = (AVPixelFormat* @pix_fmt_list, AVPixelFormat @src_pix_fmt, int @has_alpha, int* @loss_ptr) =>
        {
            var avcodec_find_best_pix_fmt_of_list_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_find_best_pix_fmt_of_list", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_find_best_pix_fmt_of_list = avcodec_find_best_pix_fmt_of_list_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_find_best_pix_fmt_of_list' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_find_best_pix_fmt_of_list_delegate>(avcodec_find_best_pix_fmt_of_list_native_ptr);
            return vectors.avcodec_find_best_pix_fmt_of_list(@pix_fmt_list, @src_pix_fmt, @has_alpha, @loss_ptr);
        };
        
        vectors.avcodec_find_decoder = (AVCodecID @id) =>
        {
            var avcodec_find_decoder_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_find_decoder", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_find_decoder = avcodec_find_decoder_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_find_decoder' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_find_decoder_delegate>(avcodec_find_decoder_native_ptr);
            return vectors.avcodec_find_decoder(@id);
        };
        
        vectors.avcodec_find_decoder_by_name = (string @name) =>
        {
            var avcodec_find_decoder_by_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_find_decoder_by_name", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_find_decoder_by_name = avcodec_find_decoder_by_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_find_decoder_by_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_find_decoder_by_name_delegate>(avcodec_find_decoder_by_name_native_ptr);
            return vectors.avcodec_find_decoder_by_name(@name);
        };
        
        vectors.avcodec_find_encoder = (AVCodecID @id) =>
        {
            var avcodec_find_encoder_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_find_encoder", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_find_encoder = avcodec_find_encoder_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_find_encoder' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_find_encoder_delegate>(avcodec_find_encoder_native_ptr);
            return vectors.avcodec_find_encoder(@id);
        };
        
        vectors.avcodec_find_encoder_by_name = (string @name) =>
        {
            var avcodec_find_encoder_by_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_find_encoder_by_name", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_find_encoder_by_name = avcodec_find_encoder_by_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_find_encoder_by_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_find_encoder_by_name_delegate>(avcodec_find_encoder_by_name_native_ptr);
            return vectors.avcodec_find_encoder_by_name(@name);
        };
        
        vectors.avcodec_flush_buffers = (AVCodecContext* @avctx) =>
        {
            var avcodec_flush_buffers_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_flush_buffers", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_flush_buffers = avcodec_flush_buffers_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_flush_buffers' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_flush_buffers_delegate>(avcodec_flush_buffers_native_ptr);
            vectors.avcodec_flush_buffers(@avctx);
        };
        
        vectors.avcodec_free_context = (AVCodecContext** @avctx) =>
        {
            var avcodec_free_context_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_free_context", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_free_context = avcodec_free_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_free_context' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_free_context_delegate>(avcodec_free_context_native_ptr);
            vectors.avcodec_free_context(@avctx);
        };
        
        vectors.avcodec_get_class = () =>
        {
            var avcodec_get_class_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_get_class", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_get_class = avcodec_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_get_class' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_get_class_delegate>(avcodec_get_class_native_ptr);
            return vectors.avcodec_get_class();
        };
        
        vectors.avcodec_get_hw_config = (AVCodec* @codec, int @index) =>
        {
            var avcodec_get_hw_config_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_get_hw_config", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_get_hw_config = avcodec_get_hw_config_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_get_hw_config' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_get_hw_config_delegate>(avcodec_get_hw_config_native_ptr);
            return vectors.avcodec_get_hw_config(@codec, @index);
        };
        
        vectors.avcodec_get_hw_frames_parameters = (AVCodecContext* @avctx, AVBufferRef* @device_ref, AVPixelFormat @hw_pix_fmt, AVBufferRef** @out_frames_ref) =>
        {
            var avcodec_get_hw_frames_parameters_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_get_hw_frames_parameters", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_get_hw_frames_parameters = avcodec_get_hw_frames_parameters_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_get_hw_frames_parameters' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_get_hw_frames_parameters_delegate>(avcodec_get_hw_frames_parameters_native_ptr);
            return vectors.avcodec_get_hw_frames_parameters(@avctx, @device_ref, @hw_pix_fmt, @out_frames_ref);
        };
        
        vectors.avcodec_get_name = (AVCodecID @id) =>
        {
            var avcodec_get_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_get_name", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_get_name = avcodec_get_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_get_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_get_name_delegate>(avcodec_get_name_native_ptr);
            return vectors.avcodec_get_name(@id);
        };
        
        vectors.avcodec_get_subtitle_rect_class = () =>
        {
            var avcodec_get_subtitle_rect_class_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_get_subtitle_rect_class", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_get_subtitle_rect_class = avcodec_get_subtitle_rect_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_get_subtitle_rect_class' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_get_subtitle_rect_class_delegate>(avcodec_get_subtitle_rect_class_native_ptr);
            return vectors.avcodec_get_subtitle_rect_class();
        };
        
        vectors.avcodec_get_supported_config = (AVCodecContext* @avctx, AVCodec* @codec, AVCodecConfig @config, uint @flags, void** @out_configs, int* @out_num_configs) =>
        {
            var avcodec_get_supported_config_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_get_supported_config", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_get_supported_config = avcodec_get_supported_config_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_get_supported_config' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_get_supported_config_delegate>(avcodec_get_supported_config_native_ptr);
            return vectors.avcodec_get_supported_config(@avctx, @codec, @config, @flags, @out_configs, @out_num_configs);
        };
        
        vectors.avcodec_get_type = (AVCodecID @codec_id) =>
        {
            var avcodec_get_type_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_get_type", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_get_type = avcodec_get_type_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_get_type' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_get_type_delegate>(avcodec_get_type_native_ptr);
            return vectors.avcodec_get_type(@codec_id);
        };
        
        vectors.avcodec_is_open = (AVCodecContext* @s) =>
        {
            var avcodec_is_open_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_is_open", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_is_open = avcodec_is_open_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_is_open' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_is_open_delegate>(avcodec_is_open_native_ptr);
            return vectors.avcodec_is_open(@s);
        };
        
        vectors.avcodec_license = () =>
        {
            var avcodec_license_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_license", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_license = avcodec_license_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_license' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_license_delegate>(avcodec_license_native_ptr);
            return vectors.avcodec_license();
        };
        
        vectors.avcodec_open2 = (AVCodecContext* @avctx, AVCodec* @codec, AVDictionary** @options) =>
        {
            var avcodec_open2_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_open2", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_open2 = avcodec_open2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_open2' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_open2_delegate>(avcodec_open2_native_ptr);
            return vectors.avcodec_open2(@avctx, @codec, @options);
        };
        
        vectors.avcodec_parameters_alloc = () =>
        {
            var avcodec_parameters_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_parameters_alloc", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_parameters_alloc = avcodec_parameters_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_parameters_alloc' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_parameters_alloc_delegate>(avcodec_parameters_alloc_native_ptr);
            return vectors.avcodec_parameters_alloc();
        };
        
        vectors.avcodec_parameters_copy = (AVCodecParameters* @dst, AVCodecParameters* @src) =>
        {
            var avcodec_parameters_copy_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_parameters_copy", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_parameters_copy = avcodec_parameters_copy_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_parameters_copy' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_parameters_copy_delegate>(avcodec_parameters_copy_native_ptr);
            return vectors.avcodec_parameters_copy(@dst, @src);
        };
        
        vectors.avcodec_parameters_free = (AVCodecParameters** @par) =>
        {
            var avcodec_parameters_free_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_parameters_free", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_parameters_free = avcodec_parameters_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_parameters_free' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_parameters_free_delegate>(avcodec_parameters_free_native_ptr);
            vectors.avcodec_parameters_free(@par);
        };
        
        vectors.avcodec_parameters_from_context = (AVCodecParameters* @par, AVCodecContext* @codec) =>
        {
            var avcodec_parameters_from_context_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_parameters_from_context", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_parameters_from_context = avcodec_parameters_from_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_parameters_from_context' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_parameters_from_context_delegate>(avcodec_parameters_from_context_native_ptr);
            return vectors.avcodec_parameters_from_context(@par, @codec);
        };
        
        vectors.avcodec_parameters_to_context = (AVCodecContext* @codec, AVCodecParameters* @par) =>
        {
            var avcodec_parameters_to_context_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_parameters_to_context", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_parameters_to_context = avcodec_parameters_to_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_parameters_to_context' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_parameters_to_context_delegate>(avcodec_parameters_to_context_native_ptr);
            return vectors.avcodec_parameters_to_context(@codec, @par);
        };
        
        vectors.avcodec_pix_fmt_to_codec_tag = (AVPixelFormat @pix_fmt) =>
        {
            var avcodec_pix_fmt_to_codec_tag_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_pix_fmt_to_codec_tag", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_pix_fmt_to_codec_tag = avcodec_pix_fmt_to_codec_tag_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_pix_fmt_to_codec_tag' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_pix_fmt_to_codec_tag_delegate>(avcodec_pix_fmt_to_codec_tag_native_ptr);
            return vectors.avcodec_pix_fmt_to_codec_tag(@pix_fmt);
        };
        
        vectors.avcodec_profile_name = (AVCodecID @codec_id, int @profile) =>
        {
            var avcodec_profile_name_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_profile_name", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_profile_name = avcodec_profile_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_profile_name' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_profile_name_delegate>(avcodec_profile_name_native_ptr);
            return vectors.avcodec_profile_name(@codec_id, @profile);
        };
        
        vectors.avcodec_receive_frame = (AVCodecContext* @avctx, AVFrame* @frame) =>
        {
            var avcodec_receive_frame_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_receive_frame", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_receive_frame = avcodec_receive_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_receive_frame' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_receive_frame_delegate>(avcodec_receive_frame_native_ptr);
            return vectors.avcodec_receive_frame(@avctx, @frame);
        };
        
        vectors.avcodec_receive_frame_flags = (AVCodecContext* @avctx, AVFrame* @frame, uint @flags) =>
        {
            var avcodec_receive_frame_flags_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_receive_frame_flags", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_receive_frame_flags = avcodec_receive_frame_flags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_receive_frame_flags' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_receive_frame_flags_delegate>(avcodec_receive_frame_flags_native_ptr);
            return vectors.avcodec_receive_frame_flags(@avctx, @frame, @flags);
        };
        
        vectors.avcodec_receive_packet = (AVCodecContext* @avctx, AVPacket* @avpkt) =>
        {
            var avcodec_receive_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_receive_packet", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_receive_packet = avcodec_receive_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_receive_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_receive_packet_delegate>(avcodec_receive_packet_native_ptr);
            return vectors.avcodec_receive_packet(@avctx, @avpkt);
        };
        
        vectors.avcodec_send_frame = (AVCodecContext* @avctx, AVFrame* @frame) =>
        {
            var avcodec_send_frame_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_send_frame", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_send_frame = avcodec_send_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_send_frame' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_send_frame_delegate>(avcodec_send_frame_native_ptr);
            return vectors.avcodec_send_frame(@avctx, @frame);
        };
        
        vectors.avcodec_send_packet = (AVCodecContext* @avctx, AVPacket* @avpkt) =>
        {
            var avcodec_send_packet_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_send_packet", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_send_packet = avcodec_send_packet_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_send_packet' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_send_packet_delegate>(avcodec_send_packet_native_ptr);
            return vectors.avcodec_send_packet(@avctx, @avpkt);
        };
        
        vectors.avcodec_string = (byte* @buf, int @buf_size, AVCodecContext* @enc, int @encode) =>
        {
            var avcodec_string_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_string", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_string = avcodec_string_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_string' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_string_delegate>(avcodec_string_native_ptr);
            vectors.avcodec_string(@buf, @buf_size, @enc, @encode);
        };
        
        vectors.avcodec_version = () =>
        {
            var avcodec_version_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avcodec_version", ThrowErrorIfFunctionNotFound);
            vectors.avcodec_version = avcodec_version_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avcodec_version' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avcodec_version_delegate>(avcodec_version_native_ptr);
            return vectors.avcodec_version();
        };
        
        vectors.avdevice_app_to_dev_control_message = (AVFormatContext* @s, AVAppToDevMessageType @type, void* @data, ulong @data_size) =>
        {
            var avdevice_app_to_dev_control_message_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_app_to_dev_control_message", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_app_to_dev_control_message = avdevice_app_to_dev_control_message_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_app_to_dev_control_message' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_app_to_dev_control_message_delegate>(avdevice_app_to_dev_control_message_native_ptr);
            return vectors.avdevice_app_to_dev_control_message(@s, @type, @data, @data_size);
        };
        
        vectors.avdevice_configuration = () =>
        {
            var avdevice_configuration_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_configuration", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_configuration = avdevice_configuration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_configuration' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_configuration_delegate>(avdevice_configuration_native_ptr);
            return vectors.avdevice_configuration();
        };
        
        vectors.avdevice_dev_to_app_control_message = (AVFormatContext* @s, AVDevToAppMessageType @type, void* @data, ulong @data_size) =>
        {
            var avdevice_dev_to_app_control_message_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_dev_to_app_control_message", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_dev_to_app_control_message = avdevice_dev_to_app_control_message_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_dev_to_app_control_message' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_dev_to_app_control_message_delegate>(avdevice_dev_to_app_control_message_native_ptr);
            return vectors.avdevice_dev_to_app_control_message(@s, @type, @data, @data_size);
        };
        
        vectors.avdevice_free_list_devices = (AVDeviceInfoList** @device_list) =>
        {
            var avdevice_free_list_devices_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_free_list_devices", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_free_list_devices = avdevice_free_list_devices_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_free_list_devices' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_free_list_devices_delegate>(avdevice_free_list_devices_native_ptr);
            vectors.avdevice_free_list_devices(@device_list);
        };
        
        vectors.avdevice_license = () =>
        {
            var avdevice_license_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_license", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_license = avdevice_license_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_license' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_license_delegate>(avdevice_license_native_ptr);
            return vectors.avdevice_license();
        };
        
        vectors.avdevice_list_devices = (AVFormatContext* @s, AVDeviceInfoList** @device_list) =>
        {
            var avdevice_list_devices_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_list_devices", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_list_devices = avdevice_list_devices_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_list_devices' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_list_devices_delegate>(avdevice_list_devices_native_ptr);
            return vectors.avdevice_list_devices(@s, @device_list);
        };
        
        vectors.avdevice_list_input_sources = (AVInputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) =>
        {
            var avdevice_list_input_sources_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_list_input_sources", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_list_input_sources = avdevice_list_input_sources_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_list_input_sources' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_list_input_sources_delegate>(avdevice_list_input_sources_native_ptr);
            return vectors.avdevice_list_input_sources(@device, @device_name, @device_options, @device_list);
        };
        
        vectors.avdevice_list_output_sinks = (AVOutputFormat* @device, string @device_name, AVDictionary* @device_options, AVDeviceInfoList** @device_list) =>
        {
            var avdevice_list_output_sinks_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_list_output_sinks", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_list_output_sinks = avdevice_list_output_sinks_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_list_output_sinks' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_list_output_sinks_delegate>(avdevice_list_output_sinks_native_ptr);
            return vectors.avdevice_list_output_sinks(@device, @device_name, @device_options, @device_list);
        };
        
        vectors.avdevice_register_all = () =>
        {
            var avdevice_register_all_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_register_all", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_register_all = avdevice_register_all_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_register_all' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_register_all_delegate>(avdevice_register_all_native_ptr);
            vectors.avdevice_register_all();
        };
        
        vectors.avdevice_version = () =>
        {
            var avdevice_version_native_ptr = FunctionResolver.GetFunctionPointer("avdevice", "avdevice_version", ThrowErrorIfFunctionNotFound);
            vectors.avdevice_version = avdevice_version_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avdevice_version' in the 'avdevice' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avdevice_version_delegate>(avdevice_version_native_ptr);
            return vectors.avdevice_version();
        };
        
        vectors.avfilter_configuration = () =>
        {
            var avfilter_configuration_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_configuration", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_configuration = avfilter_configuration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_configuration' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_configuration_delegate>(avfilter_configuration_native_ptr);
            return vectors.avfilter_configuration();
        };
        
        vectors.avfilter_filter_pad_count = (AVFilter* @filter, int @is_output) =>
        {
            var avfilter_filter_pad_count_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_filter_pad_count", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_filter_pad_count = avfilter_filter_pad_count_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_filter_pad_count' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_filter_pad_count_delegate>(avfilter_filter_pad_count_native_ptr);
            return vectors.avfilter_filter_pad_count(@filter, @is_output);
        };
        
        vectors.avfilter_free = (AVFilterContext* @filter) =>
        {
            var avfilter_free_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_free", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_free = avfilter_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_free' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_free_delegate>(avfilter_free_native_ptr);
            vectors.avfilter_free(@filter);
        };
        
        vectors.avfilter_get_by_name = (string @name) =>
        {
            var avfilter_get_by_name_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_get_by_name", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_get_by_name = avfilter_get_by_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_get_by_name' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_get_by_name_delegate>(avfilter_get_by_name_native_ptr);
            return vectors.avfilter_get_by_name(@name);
        };
        
        vectors.avfilter_get_class = () =>
        {
            var avfilter_get_class_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_get_class", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_get_class = avfilter_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_get_class' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_get_class_delegate>(avfilter_get_class_native_ptr);
            return vectors.avfilter_get_class();
        };
        
        vectors.avfilter_graph_alloc = () =>
        {
            var avfilter_graph_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_alloc", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_alloc = avfilter_graph_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_alloc' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_alloc_delegate>(avfilter_graph_alloc_native_ptr);
            return vectors.avfilter_graph_alloc();
        };
        
        vectors.avfilter_graph_alloc_filter = (AVFilterGraph* @graph, AVFilter* @filter, string @name) =>
        {
            var avfilter_graph_alloc_filter_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_alloc_filter", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_alloc_filter = avfilter_graph_alloc_filter_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_alloc_filter' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_alloc_filter_delegate>(avfilter_graph_alloc_filter_native_ptr);
            return vectors.avfilter_graph_alloc_filter(@graph, @filter, @name);
        };
        
        vectors.avfilter_graph_config = (AVFilterGraph* @graphctx, void* @log_ctx) =>
        {
            var avfilter_graph_config_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_config", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_config = avfilter_graph_config_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_config' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_config_delegate>(avfilter_graph_config_native_ptr);
            return vectors.avfilter_graph_config(@graphctx, @log_ctx);
        };
        
        vectors.avfilter_graph_create_filter = (AVFilterContext** @filt_ctx, AVFilter* @filt, string @name, string @args, void* @opaque, AVFilterGraph* @graph_ctx) =>
        {
            var avfilter_graph_create_filter_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_create_filter", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_create_filter = avfilter_graph_create_filter_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_create_filter' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_create_filter_delegate>(avfilter_graph_create_filter_native_ptr);
            return vectors.avfilter_graph_create_filter(@filt_ctx, @filt, @name, @args, @opaque, @graph_ctx);
        };
        
        vectors.avfilter_graph_dump = (AVFilterGraph* @graph, string @options) =>
        {
            var avfilter_graph_dump_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_dump", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_dump = avfilter_graph_dump_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_dump' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_dump_delegate>(avfilter_graph_dump_native_ptr);
            return vectors.avfilter_graph_dump(@graph, @options);
        };
        
        vectors.avfilter_graph_free = (AVFilterGraph** @graph) =>
        {
            var avfilter_graph_free_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_free", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_free = avfilter_graph_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_free' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_free_delegate>(avfilter_graph_free_native_ptr);
            vectors.avfilter_graph_free(@graph);
        };
        
        vectors.avfilter_graph_get_filter = (AVFilterGraph* @graph, string @name) =>
        {
            var avfilter_graph_get_filter_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_get_filter", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_get_filter = avfilter_graph_get_filter_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_get_filter' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_get_filter_delegate>(avfilter_graph_get_filter_native_ptr);
            return vectors.avfilter_graph_get_filter(@graph, @name);
        };
        
        vectors.avfilter_graph_parse = (AVFilterGraph* @graph, string @filters, AVFilterInOut* @inputs, AVFilterInOut* @outputs, void* @log_ctx) =>
        {
            var avfilter_graph_parse_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_parse", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_parse = avfilter_graph_parse_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_parse' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_parse_delegate>(avfilter_graph_parse_native_ptr);
            return vectors.avfilter_graph_parse(@graph, @filters, @inputs, @outputs, @log_ctx);
        };
        
        vectors.avfilter_graph_parse_ptr = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs, void* @log_ctx) =>
        {
            var avfilter_graph_parse_ptr_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_parse_ptr", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_parse_ptr = avfilter_graph_parse_ptr_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_parse_ptr' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_parse_ptr_delegate>(avfilter_graph_parse_ptr_native_ptr);
            return vectors.avfilter_graph_parse_ptr(@graph, @filters, @inputs, @outputs, @log_ctx);
        };
        
        vectors.avfilter_graph_parse2 = (AVFilterGraph* @graph, string @filters, AVFilterInOut** @inputs, AVFilterInOut** @outputs) =>
        {
            var avfilter_graph_parse2_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_parse2", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_parse2 = avfilter_graph_parse2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_parse2' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_parse2_delegate>(avfilter_graph_parse2_native_ptr);
            return vectors.avfilter_graph_parse2(@graph, @filters, @inputs, @outputs);
        };
        
        vectors.avfilter_graph_queue_command = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, int @flags, double @ts) =>
        {
            var avfilter_graph_queue_command_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_queue_command", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_queue_command = avfilter_graph_queue_command_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_queue_command' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_queue_command_delegate>(avfilter_graph_queue_command_native_ptr);
            return vectors.avfilter_graph_queue_command(@graph, @target, @cmd, @arg, @flags, @ts);
        };
        
        vectors.avfilter_graph_request_oldest = (AVFilterGraph* @graph) =>
        {
            var avfilter_graph_request_oldest_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_request_oldest", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_request_oldest = avfilter_graph_request_oldest_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_request_oldest' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_request_oldest_delegate>(avfilter_graph_request_oldest_native_ptr);
            return vectors.avfilter_graph_request_oldest(@graph);
        };
        
        vectors.avfilter_graph_segment_apply = (AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs) =>
        {
            var avfilter_graph_segment_apply_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_segment_apply", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_segment_apply = avfilter_graph_segment_apply_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_segment_apply' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_segment_apply_delegate>(avfilter_graph_segment_apply_native_ptr);
            return vectors.avfilter_graph_segment_apply(@seg, @flags, @inputs, @outputs);
        };
        
        vectors.avfilter_graph_segment_apply_opts = (AVFilterGraphSegment* @seg, int @flags) =>
        {
            var avfilter_graph_segment_apply_opts_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_segment_apply_opts", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_segment_apply_opts = avfilter_graph_segment_apply_opts_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_segment_apply_opts' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_segment_apply_opts_delegate>(avfilter_graph_segment_apply_opts_native_ptr);
            return vectors.avfilter_graph_segment_apply_opts(@seg, @flags);
        };
        
        vectors.avfilter_graph_segment_create_filters = (AVFilterGraphSegment* @seg, int @flags) =>
        {
            var avfilter_graph_segment_create_filters_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_segment_create_filters", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_segment_create_filters = avfilter_graph_segment_create_filters_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_segment_create_filters' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_segment_create_filters_delegate>(avfilter_graph_segment_create_filters_native_ptr);
            return vectors.avfilter_graph_segment_create_filters(@seg, @flags);
        };
        
        vectors.avfilter_graph_segment_free = (AVFilterGraphSegment** @seg) =>
        {
            var avfilter_graph_segment_free_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_segment_free", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_segment_free = avfilter_graph_segment_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_segment_free' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_segment_free_delegate>(avfilter_graph_segment_free_native_ptr);
            vectors.avfilter_graph_segment_free(@seg);
        };
        
        vectors.avfilter_graph_segment_init = (AVFilterGraphSegment* @seg, int @flags) =>
        {
            var avfilter_graph_segment_init_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_segment_init", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_segment_init = avfilter_graph_segment_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_segment_init' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_segment_init_delegate>(avfilter_graph_segment_init_native_ptr);
            return vectors.avfilter_graph_segment_init(@seg, @flags);
        };
        
        vectors.avfilter_graph_segment_link = (AVFilterGraphSegment* @seg, int @flags, AVFilterInOut** @inputs, AVFilterInOut** @outputs) =>
        {
            var avfilter_graph_segment_link_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_segment_link", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_segment_link = avfilter_graph_segment_link_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_segment_link' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_segment_link_delegate>(avfilter_graph_segment_link_native_ptr);
            return vectors.avfilter_graph_segment_link(@seg, @flags, @inputs, @outputs);
        };
        
        vectors.avfilter_graph_segment_parse = (AVFilterGraph* @graph, string @graph_str, int @flags, AVFilterGraphSegment** @seg) =>
        {
            var avfilter_graph_segment_parse_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_segment_parse", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_segment_parse = avfilter_graph_segment_parse_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_segment_parse' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_segment_parse_delegate>(avfilter_graph_segment_parse_native_ptr);
            return vectors.avfilter_graph_segment_parse(@graph, @graph_str, @flags, @seg);
        };
        
        vectors.avfilter_graph_send_command = (AVFilterGraph* @graph, string @target, string @cmd, string @arg, byte* @res, int @res_len, int @flags) =>
        {
            var avfilter_graph_send_command_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_send_command", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_send_command = avfilter_graph_send_command_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_send_command' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_send_command_delegate>(avfilter_graph_send_command_native_ptr);
            return vectors.avfilter_graph_send_command(@graph, @target, @cmd, @arg, @res, @res_len, @flags);
        };
        
        vectors.avfilter_graph_set_auto_convert = (AVFilterGraph* @graph, uint @flags) =>
        {
            var avfilter_graph_set_auto_convert_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_graph_set_auto_convert", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_graph_set_auto_convert = avfilter_graph_set_auto_convert_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_graph_set_auto_convert' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_graph_set_auto_convert_delegate>(avfilter_graph_set_auto_convert_native_ptr);
            vectors.avfilter_graph_set_auto_convert(@graph, @flags);
        };
        
        vectors.avfilter_init_dict = (AVFilterContext* @ctx, AVDictionary** @options) =>
        {
            var avfilter_init_dict_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_init_dict", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_init_dict = avfilter_init_dict_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_init_dict' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_init_dict_delegate>(avfilter_init_dict_native_ptr);
            return vectors.avfilter_init_dict(@ctx, @options);
        };
        
        vectors.avfilter_init_str = (AVFilterContext* @ctx, string @args) =>
        {
            var avfilter_init_str_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_init_str", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_init_str = avfilter_init_str_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_init_str' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_init_str_delegate>(avfilter_init_str_native_ptr);
            return vectors.avfilter_init_str(@ctx, @args);
        };
        
        vectors.avfilter_inout_alloc = () =>
        {
            var avfilter_inout_alloc_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_inout_alloc", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_inout_alloc = avfilter_inout_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_inout_alloc' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_inout_alloc_delegate>(avfilter_inout_alloc_native_ptr);
            return vectors.avfilter_inout_alloc();
        };
        
        vectors.avfilter_inout_free = (AVFilterInOut** @inout) =>
        {
            var avfilter_inout_free_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_inout_free", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_inout_free = avfilter_inout_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_inout_free' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_inout_free_delegate>(avfilter_inout_free_native_ptr);
            vectors.avfilter_inout_free(@inout);
        };
        
        vectors.avfilter_insert_filter = (AVFilterLink* @link, AVFilterContext* @filt, uint @filt_srcpad_idx, uint @filt_dstpad_idx) =>
        {
            var avfilter_insert_filter_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_insert_filter", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_insert_filter = avfilter_insert_filter_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_insert_filter' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_insert_filter_delegate>(avfilter_insert_filter_native_ptr);
            return vectors.avfilter_insert_filter(@link, @filt, @filt_srcpad_idx, @filt_dstpad_idx);
        };
        
        vectors.avfilter_license = () =>
        {
            var avfilter_license_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_license", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_license = avfilter_license_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_license' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_license_delegate>(avfilter_license_native_ptr);
            return vectors.avfilter_license();
        };
        
        vectors.avfilter_link = (AVFilterContext* @src, uint @srcpad, AVFilterContext* @dst, uint @dstpad) =>
        {
            var avfilter_link_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_link", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_link = avfilter_link_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_link' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_link_delegate>(avfilter_link_native_ptr);
            return vectors.avfilter_link(@src, @srcpad, @dst, @dstpad);
        };
        
        vectors.avfilter_link_get_hw_frames_ctx = (AVFilterLink* @link) =>
        {
            var avfilter_link_get_hw_frames_ctx_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_link_get_hw_frames_ctx", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_link_get_hw_frames_ctx = avfilter_link_get_hw_frames_ctx_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_link_get_hw_frames_ctx' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_link_get_hw_frames_ctx_delegate>(avfilter_link_get_hw_frames_ctx_native_ptr);
            return vectors.avfilter_link_get_hw_frames_ctx(@link);
        };
        
        vectors.avfilter_pad_get_name = (AVFilterPad* @pads, int @pad_idx) =>
        {
            var avfilter_pad_get_name_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_pad_get_name", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_pad_get_name = avfilter_pad_get_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_pad_get_name' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_pad_get_name_delegate>(avfilter_pad_get_name_native_ptr);
            return vectors.avfilter_pad_get_name(@pads, @pad_idx);
        };
        
        vectors.avfilter_pad_get_type = (AVFilterPad* @pads, int @pad_idx) =>
        {
            var avfilter_pad_get_type_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_pad_get_type", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_pad_get_type = avfilter_pad_get_type_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_pad_get_type' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_pad_get_type_delegate>(avfilter_pad_get_type_native_ptr);
            return vectors.avfilter_pad_get_type(@pads, @pad_idx);
        };
        
        vectors.avfilter_process_command = (AVFilterContext* @filter, string @cmd, string @arg, byte* @res, int @res_len, int @flags) =>
        {
            var avfilter_process_command_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_process_command", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_process_command = avfilter_process_command_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_process_command' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_process_command_delegate>(avfilter_process_command_native_ptr);
            return vectors.avfilter_process_command(@filter, @cmd, @arg, @res, @res_len, @flags);
        };
        
        vectors.avfilter_version = () =>
        {
            var avfilter_version_native_ptr = FunctionResolver.GetFunctionPointer("avfilter", "avfilter_version", ThrowErrorIfFunctionNotFound);
            vectors.avfilter_version = avfilter_version_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avfilter_version' in the 'avfilter' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avfilter_version_delegate>(avfilter_version_native_ptr);
            return vectors.avfilter_version();
        };
        
        vectors.avformat_alloc_context = () =>
        {
            var avformat_alloc_context_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_alloc_context", ThrowErrorIfFunctionNotFound);
            vectors.avformat_alloc_context = avformat_alloc_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_alloc_context' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_alloc_context_delegate>(avformat_alloc_context_native_ptr);
            return vectors.avformat_alloc_context();
        };
        
        vectors.avformat_alloc_output_context2 = (AVFormatContext** @ctx, AVOutputFormat* @oformat, string @format_name, string @filename) =>
        {
            var avformat_alloc_output_context2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_alloc_output_context2", ThrowErrorIfFunctionNotFound);
            vectors.avformat_alloc_output_context2 = avformat_alloc_output_context2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_alloc_output_context2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_alloc_output_context2_delegate>(avformat_alloc_output_context2_native_ptr);
            return vectors.avformat_alloc_output_context2(@ctx, @oformat, @format_name, @filename);
        };
        
        vectors.avformat_close_input = (AVFormatContext** @s) =>
        {
            var avformat_close_input_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_close_input", ThrowErrorIfFunctionNotFound);
            vectors.avformat_close_input = avformat_close_input_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_close_input' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_close_input_delegate>(avformat_close_input_native_ptr);
            vectors.avformat_close_input(@s);
        };
        
        vectors.avformat_configuration = () =>
        {
            var avformat_configuration_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_configuration", ThrowErrorIfFunctionNotFound);
            vectors.avformat_configuration = avformat_configuration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_configuration' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_configuration_delegate>(avformat_configuration_native_ptr);
            return vectors.avformat_configuration();
        };
        
        vectors.avformat_find_stream_info = (AVFormatContext* @ic, AVDictionary** @options) =>
        {
            var avformat_find_stream_info_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_find_stream_info", ThrowErrorIfFunctionNotFound);
            vectors.avformat_find_stream_info = avformat_find_stream_info_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_find_stream_info' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_find_stream_info_delegate>(avformat_find_stream_info_native_ptr);
            return vectors.avformat_find_stream_info(@ic, @options);
        };
        
        vectors.avformat_flush = (AVFormatContext* @s) =>
        {
            var avformat_flush_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_flush", ThrowErrorIfFunctionNotFound);
            vectors.avformat_flush = avformat_flush_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_flush' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_flush_delegate>(avformat_flush_native_ptr);
            return vectors.avformat_flush(@s);
        };
        
        vectors.avformat_free_context = (AVFormatContext* @s) =>
        {
            var avformat_free_context_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_free_context", ThrowErrorIfFunctionNotFound);
            vectors.avformat_free_context = avformat_free_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_free_context' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_free_context_delegate>(avformat_free_context_native_ptr);
            vectors.avformat_free_context(@s);
        };
        
        vectors.avformat_get_class = () =>
        {
            var avformat_get_class_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_get_class", ThrowErrorIfFunctionNotFound);
            vectors.avformat_get_class = avformat_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_get_class' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_get_class_delegate>(avformat_get_class_native_ptr);
            return vectors.avformat_get_class();
        };
        
        vectors.avformat_get_mov_audio_tags = () =>
        {
            var avformat_get_mov_audio_tags_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_get_mov_audio_tags", ThrowErrorIfFunctionNotFound);
            vectors.avformat_get_mov_audio_tags = avformat_get_mov_audio_tags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_get_mov_audio_tags' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_get_mov_audio_tags_delegate>(avformat_get_mov_audio_tags_native_ptr);
            return vectors.avformat_get_mov_audio_tags();
        };
        
        vectors.avformat_get_mov_video_tags = () =>
        {
            var avformat_get_mov_video_tags_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_get_mov_video_tags", ThrowErrorIfFunctionNotFound);
            vectors.avformat_get_mov_video_tags = avformat_get_mov_video_tags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_get_mov_video_tags' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_get_mov_video_tags_delegate>(avformat_get_mov_video_tags_native_ptr);
            return vectors.avformat_get_mov_video_tags();
        };
        
        vectors.avformat_get_riff_audio_tags = () =>
        {
            var avformat_get_riff_audio_tags_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_get_riff_audio_tags", ThrowErrorIfFunctionNotFound);
            vectors.avformat_get_riff_audio_tags = avformat_get_riff_audio_tags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_get_riff_audio_tags' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_get_riff_audio_tags_delegate>(avformat_get_riff_audio_tags_native_ptr);
            return vectors.avformat_get_riff_audio_tags();
        };
        
        vectors.avformat_get_riff_video_tags = () =>
        {
            var avformat_get_riff_video_tags_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_get_riff_video_tags", ThrowErrorIfFunctionNotFound);
            vectors.avformat_get_riff_video_tags = avformat_get_riff_video_tags_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_get_riff_video_tags' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_get_riff_video_tags_delegate>(avformat_get_riff_video_tags_native_ptr);
            return vectors.avformat_get_riff_video_tags();
        };
        
        vectors.avformat_index_get_entries_count = (AVStream* @st) =>
        {
            var avformat_index_get_entries_count_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_index_get_entries_count", ThrowErrorIfFunctionNotFound);
            vectors.avformat_index_get_entries_count = avformat_index_get_entries_count_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_index_get_entries_count' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_index_get_entries_count_delegate>(avformat_index_get_entries_count_native_ptr);
            return vectors.avformat_index_get_entries_count(@st);
        };
        
        vectors.avformat_index_get_entry = (AVStream* @st, int @idx) =>
        {
            var avformat_index_get_entry_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_index_get_entry", ThrowErrorIfFunctionNotFound);
            vectors.avformat_index_get_entry = avformat_index_get_entry_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_index_get_entry' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_index_get_entry_delegate>(avformat_index_get_entry_native_ptr);
            return vectors.avformat_index_get_entry(@st, @idx);
        };
        
        vectors.avformat_index_get_entry_from_timestamp = (AVStream* @st, long @wanted_timestamp, int @flags) =>
        {
            var avformat_index_get_entry_from_timestamp_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_index_get_entry_from_timestamp", ThrowErrorIfFunctionNotFound);
            vectors.avformat_index_get_entry_from_timestamp = avformat_index_get_entry_from_timestamp_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_index_get_entry_from_timestamp' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_index_get_entry_from_timestamp_delegate>(avformat_index_get_entry_from_timestamp_native_ptr);
            return vectors.avformat_index_get_entry_from_timestamp(@st, @wanted_timestamp, @flags);
        };
        
        vectors.avformat_init_output = (AVFormatContext* @s, AVDictionary** @options) =>
        {
            var avformat_init_output_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_init_output", ThrowErrorIfFunctionNotFound);
            vectors.avformat_init_output = avformat_init_output_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_init_output' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_init_output_delegate>(avformat_init_output_native_ptr);
            return vectors.avformat_init_output(@s, @options);
        };
        
        vectors.avformat_license = () =>
        {
            var avformat_license_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_license", ThrowErrorIfFunctionNotFound);
            vectors.avformat_license = avformat_license_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_license' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_license_delegate>(avformat_license_native_ptr);
            return vectors.avformat_license();
        };
        
        vectors.avformat_match_stream_specifier = (AVFormatContext* @s, AVStream* @st, string @spec) =>
        {
            var avformat_match_stream_specifier_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_match_stream_specifier", ThrowErrorIfFunctionNotFound);
            vectors.avformat_match_stream_specifier = avformat_match_stream_specifier_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_match_stream_specifier' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_match_stream_specifier_delegate>(avformat_match_stream_specifier_native_ptr);
            return vectors.avformat_match_stream_specifier(@s, @st, @spec);
        };
        
        vectors.avformat_network_deinit = () =>
        {
            var avformat_network_deinit_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_network_deinit", ThrowErrorIfFunctionNotFound);
            vectors.avformat_network_deinit = avformat_network_deinit_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_network_deinit' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_network_deinit_delegate>(avformat_network_deinit_native_ptr);
            return vectors.avformat_network_deinit();
        };
        
        vectors.avformat_network_init = () =>
        {
            var avformat_network_init_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_network_init", ThrowErrorIfFunctionNotFound);
            vectors.avformat_network_init = avformat_network_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_network_init' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_network_init_delegate>(avformat_network_init_native_ptr);
            return vectors.avformat_network_init();
        };
        
        vectors.avformat_new_stream = (AVFormatContext* @s, AVCodec* @c) =>
        {
            var avformat_new_stream_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_new_stream", ThrowErrorIfFunctionNotFound);
            vectors.avformat_new_stream = avformat_new_stream_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_new_stream' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_new_stream_delegate>(avformat_new_stream_native_ptr);
            return vectors.avformat_new_stream(@s, @c);
        };
        
        vectors.avformat_open_input = (AVFormatContext** @ps, string @url, AVInputFormat* @fmt, AVDictionary** @options) =>
        {
            var avformat_open_input_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_open_input", ThrowErrorIfFunctionNotFound);
            vectors.avformat_open_input = avformat_open_input_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_open_input' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_open_input_delegate>(avformat_open_input_native_ptr);
            return vectors.avformat_open_input(@ps, @url, @fmt, @options);
        };
        
        vectors.avformat_query_codec = (AVOutputFormat* @ofmt, AVCodecID @codec_id, int @std_compliance) =>
        {
            var avformat_query_codec_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_query_codec", ThrowErrorIfFunctionNotFound);
            vectors.avformat_query_codec = avformat_query_codec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_query_codec' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_query_codec_delegate>(avformat_query_codec_native_ptr);
            return vectors.avformat_query_codec(@ofmt, @codec_id, @std_compliance);
        };
        
        vectors.avformat_queue_attached_pictures = (AVFormatContext* @s) =>
        {
            var avformat_queue_attached_pictures_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_queue_attached_pictures", ThrowErrorIfFunctionNotFound);
            vectors.avformat_queue_attached_pictures = avformat_queue_attached_pictures_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_queue_attached_pictures' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_queue_attached_pictures_delegate>(avformat_queue_attached_pictures_native_ptr);
            return vectors.avformat_queue_attached_pictures(@s);
        };
        
        vectors.avformat_receive_command_reply = (AVFormatContext* @s, AVFormatCommandID @id, void** @data_out) =>
        {
            var avformat_receive_command_reply_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_receive_command_reply", ThrowErrorIfFunctionNotFound);
            vectors.avformat_receive_command_reply = avformat_receive_command_reply_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_receive_command_reply' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_receive_command_reply_delegate>(avformat_receive_command_reply_native_ptr);
            return vectors.avformat_receive_command_reply(@s, @id, @data_out);
        };
        
        vectors.avformat_seek_file = (AVFormatContext* @s, int @stream_index, long @min_ts, long @ts, long @max_ts, int @flags) =>
        {
            var avformat_seek_file_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_seek_file", ThrowErrorIfFunctionNotFound);
            vectors.avformat_seek_file = avformat_seek_file_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_seek_file' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_seek_file_delegate>(avformat_seek_file_native_ptr);
            return vectors.avformat_seek_file(@s, @stream_index, @min_ts, @ts, @max_ts, @flags);
        };
        
        vectors.avformat_send_command = (AVFormatContext* @s, AVFormatCommandID @id, void* @data) =>
        {
            var avformat_send_command_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_send_command", ThrowErrorIfFunctionNotFound);
            vectors.avformat_send_command = avformat_send_command_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_send_command' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_send_command_delegate>(avformat_send_command_native_ptr);
            return vectors.avformat_send_command(@s, @id, @data);
        };
        
        vectors.avformat_stream_group_add_stream = (AVStreamGroup* @stg, AVStream* @st) =>
        {
            var avformat_stream_group_add_stream_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_stream_group_add_stream", ThrowErrorIfFunctionNotFound);
            vectors.avformat_stream_group_add_stream = avformat_stream_group_add_stream_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_stream_group_add_stream' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_stream_group_add_stream_delegate>(avformat_stream_group_add_stream_native_ptr);
            return vectors.avformat_stream_group_add_stream(@stg, @st);
        };
        
        vectors.avformat_stream_group_create = (AVFormatContext* @s, AVStreamGroupParamsType @type, AVDictionary** @options) =>
        {
            var avformat_stream_group_create_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_stream_group_create", ThrowErrorIfFunctionNotFound);
            vectors.avformat_stream_group_create = avformat_stream_group_create_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_stream_group_create' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_stream_group_create_delegate>(avformat_stream_group_create_native_ptr);
            return vectors.avformat_stream_group_create(@s, @type, @options);
        };
        
        vectors.avformat_stream_group_name = (AVStreamGroupParamsType @type) =>
        {
            var avformat_stream_group_name_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_stream_group_name", ThrowErrorIfFunctionNotFound);
            vectors.avformat_stream_group_name = avformat_stream_group_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_stream_group_name' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_stream_group_name_delegate>(avformat_stream_group_name_native_ptr);
            return vectors.avformat_stream_group_name(@type);
        };
        
        vectors.avformat_transfer_internal_stream_timing_info = (AVOutputFormat* @ofmt, AVStream* @ost, AVStream* @ist, AVTimebaseSource @copy_tb) =>
        {
            var avformat_transfer_internal_stream_timing_info_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_transfer_internal_stream_timing_info", ThrowErrorIfFunctionNotFound);
            vectors.avformat_transfer_internal_stream_timing_info = avformat_transfer_internal_stream_timing_info_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_transfer_internal_stream_timing_info' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_transfer_internal_stream_timing_info_delegate>(avformat_transfer_internal_stream_timing_info_native_ptr);
            return vectors.avformat_transfer_internal_stream_timing_info(@ofmt, @ost, @ist, @copy_tb);
        };
        
        vectors.avformat_version = () =>
        {
            var avformat_version_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_version", ThrowErrorIfFunctionNotFound);
            vectors.avformat_version = avformat_version_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_version' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_version_delegate>(avformat_version_native_ptr);
            return vectors.avformat_version();
        };
        
        vectors.avformat_write_header = (AVFormatContext* @s, AVDictionary** @options) =>
        {
            var avformat_write_header_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avformat_write_header", ThrowErrorIfFunctionNotFound);
            vectors.avformat_write_header = avformat_write_header_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avformat_write_header' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avformat_write_header_delegate>(avformat_write_header_native_ptr);
            return vectors.avformat_write_header(@s, @options);
        };
        
        vectors.avio_accept = (AVIOContext* @s, AVIOContext** @c) =>
        {
            var avio_accept_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_accept", ThrowErrorIfFunctionNotFound);
            vectors.avio_accept = avio_accept_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_accept' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_accept_delegate>(avio_accept_native_ptr);
            return vectors.avio_accept(@s, @c);
        };
        
        vectors.avio_alloc_context = (byte* @buffer, int @buffer_size, int @write_flag, void* @opaque, avio_alloc_context_read_packet_func @read_packet, avio_alloc_context_write_packet_func @write_packet, avio_alloc_context_seek_func @seek) =>
        {
            var avio_alloc_context_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_alloc_context", ThrowErrorIfFunctionNotFound);
            vectors.avio_alloc_context = avio_alloc_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_alloc_context' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_alloc_context_delegate>(avio_alloc_context_native_ptr);
            return vectors.avio_alloc_context(@buffer, @buffer_size, @write_flag, @opaque, @read_packet, @write_packet, @seek);
        };
        
        vectors.avio_check = (string @url, int @flags) =>
        {
            var avio_check_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_check", ThrowErrorIfFunctionNotFound);
            vectors.avio_check = avio_check_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_check' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_check_delegate>(avio_check_native_ptr);
            return vectors.avio_check(@url, @flags);
        };
        
        vectors.avio_close = (AVIOContext* @s) =>
        {
            var avio_close_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_close", ThrowErrorIfFunctionNotFound);
            vectors.avio_close = avio_close_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_close' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_close_delegate>(avio_close_native_ptr);
            return vectors.avio_close(@s);
        };
        
        vectors.avio_close_dir = (AVIODirContext** @s) =>
        {
            var avio_close_dir_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_close_dir", ThrowErrorIfFunctionNotFound);
            vectors.avio_close_dir = avio_close_dir_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_close_dir' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_close_dir_delegate>(avio_close_dir_native_ptr);
            return vectors.avio_close_dir(@s);
        };
        
        vectors.avio_close_dyn_buf = (AVIOContext* @s, byte** @pbuffer) =>
        {
            var avio_close_dyn_buf_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_close_dyn_buf", ThrowErrorIfFunctionNotFound);
            vectors.avio_close_dyn_buf = avio_close_dyn_buf_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_close_dyn_buf' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_close_dyn_buf_delegate>(avio_close_dyn_buf_native_ptr);
            return vectors.avio_close_dyn_buf(@s, @pbuffer);
        };
        
        vectors.avio_closep = (AVIOContext** @s) =>
        {
            var avio_closep_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_closep", ThrowErrorIfFunctionNotFound);
            vectors.avio_closep = avio_closep_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_closep' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_closep_delegate>(avio_closep_native_ptr);
            return vectors.avio_closep(@s);
        };
        
        vectors.avio_context_free = (AVIOContext** @s) =>
        {
            var avio_context_free_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_context_free", ThrowErrorIfFunctionNotFound);
            vectors.avio_context_free = avio_context_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_context_free' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_context_free_delegate>(avio_context_free_native_ptr);
            vectors.avio_context_free(@s);
        };
        
        vectors.avio_enum_protocols = (void** @opaque, int @output) =>
        {
            var avio_enum_protocols_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_enum_protocols", ThrowErrorIfFunctionNotFound);
            vectors.avio_enum_protocols = avio_enum_protocols_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_enum_protocols' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_enum_protocols_delegate>(avio_enum_protocols_native_ptr);
            return vectors.avio_enum_protocols(@opaque, @output);
        };
        
        vectors.avio_feof = (AVIOContext* @s) =>
        {
            var avio_feof_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_feof", ThrowErrorIfFunctionNotFound);
            vectors.avio_feof = avio_feof_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_feof' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_feof_delegate>(avio_feof_native_ptr);
            return vectors.avio_feof(@s);
        };
        
        vectors.avio_find_protocol_name = (string @url) =>
        {
            var avio_find_protocol_name_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_find_protocol_name", ThrowErrorIfFunctionNotFound);
            vectors.avio_find_protocol_name = avio_find_protocol_name_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_find_protocol_name' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_find_protocol_name_delegate>(avio_find_protocol_name_native_ptr);
            return vectors.avio_find_protocol_name(@url);
        };
        
        vectors.avio_flush = (AVIOContext* @s) =>
        {
            var avio_flush_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_flush", ThrowErrorIfFunctionNotFound);
            vectors.avio_flush = avio_flush_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_flush' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_flush_delegate>(avio_flush_native_ptr);
            vectors.avio_flush(@s);
        };
        
        vectors.avio_free_directory_entry = (AVIODirEntry** @entry) =>
        {
            var avio_free_directory_entry_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_free_directory_entry", ThrowErrorIfFunctionNotFound);
            vectors.avio_free_directory_entry = avio_free_directory_entry_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_free_directory_entry' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_free_directory_entry_delegate>(avio_free_directory_entry_native_ptr);
            vectors.avio_free_directory_entry(@entry);
        };
        
        vectors.avio_get_dyn_buf = (AVIOContext* @s, byte** @pbuffer) =>
        {
            var avio_get_dyn_buf_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_get_dyn_buf", ThrowErrorIfFunctionNotFound);
            vectors.avio_get_dyn_buf = avio_get_dyn_buf_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_get_dyn_buf' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_get_dyn_buf_delegate>(avio_get_dyn_buf_native_ptr);
            return vectors.avio_get_dyn_buf(@s, @pbuffer);
        };
        
        vectors.avio_get_str = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
        {
            var avio_get_str_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_get_str", ThrowErrorIfFunctionNotFound);
            vectors.avio_get_str = avio_get_str_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_get_str' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_get_str_delegate>(avio_get_str_native_ptr);
            return vectors.avio_get_str(@pb, @maxlen, @buf, @buflen);
        };
        
        vectors.avio_get_str16be = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
        {
            var avio_get_str16be_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_get_str16be", ThrowErrorIfFunctionNotFound);
            vectors.avio_get_str16be = avio_get_str16be_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_get_str16be' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_get_str16be_delegate>(avio_get_str16be_native_ptr);
            return vectors.avio_get_str16be(@pb, @maxlen, @buf, @buflen);
        };
        
        vectors.avio_get_str16le = (AVIOContext* @pb, int @maxlen, byte* @buf, int @buflen) =>
        {
            var avio_get_str16le_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_get_str16le", ThrowErrorIfFunctionNotFound);
            vectors.avio_get_str16le = avio_get_str16le_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_get_str16le' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_get_str16le_delegate>(avio_get_str16le_native_ptr);
            return vectors.avio_get_str16le(@pb, @maxlen, @buf, @buflen);
        };
        
        vectors.avio_handshake = (AVIOContext* @c) =>
        {
            var avio_handshake_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_handshake", ThrowErrorIfFunctionNotFound);
            vectors.avio_handshake = avio_handshake_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_handshake' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_handshake_delegate>(avio_handshake_native_ptr);
            return vectors.avio_handshake(@c);
        };
        
        vectors.avio_open = (AVIOContext** @s, string @url, int @flags) =>
        {
            var avio_open_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_open", ThrowErrorIfFunctionNotFound);
            vectors.avio_open = avio_open_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_open' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_open_delegate>(avio_open_native_ptr);
            return vectors.avio_open(@s, @url, @flags);
        };
        
        vectors.avio_open_dir = (AVIODirContext** @s, string @url, AVDictionary** @options) =>
        {
            var avio_open_dir_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_open_dir", ThrowErrorIfFunctionNotFound);
            vectors.avio_open_dir = avio_open_dir_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_open_dir' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_open_dir_delegate>(avio_open_dir_native_ptr);
            return vectors.avio_open_dir(@s, @url, @options);
        };
        
        vectors.avio_open_dyn_buf = (AVIOContext** @s) =>
        {
            var avio_open_dyn_buf_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_open_dyn_buf", ThrowErrorIfFunctionNotFound);
            vectors.avio_open_dyn_buf = avio_open_dyn_buf_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_open_dyn_buf' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_open_dyn_buf_delegate>(avio_open_dyn_buf_native_ptr);
            return vectors.avio_open_dyn_buf(@s);
        };
        
        vectors.avio_open2 = (AVIOContext** @s, string @url, int @flags, AVIOInterruptCB* @int_cb, AVDictionary** @options) =>
        {
            var avio_open2_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_open2", ThrowErrorIfFunctionNotFound);
            vectors.avio_open2 = avio_open2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_open2' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_open2_delegate>(avio_open2_native_ptr);
            return vectors.avio_open2(@s, @url, @flags, @int_cb, @options);
        };
        
        vectors.avio_pause = (AVIOContext* @h, int @pause) =>
        {
            var avio_pause_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_pause", ThrowErrorIfFunctionNotFound);
            vectors.avio_pause = avio_pause_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_pause' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_pause_delegate>(avio_pause_native_ptr);
            return vectors.avio_pause(@h, @pause);
        };
        
        vectors.avio_print_string_array = (AVIOContext* @s, byte*[] @strings) =>
        {
            var avio_print_string_array_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_print_string_array", ThrowErrorIfFunctionNotFound);
            vectors.avio_print_string_array = avio_print_string_array_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_print_string_array' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_print_string_array_delegate>(avio_print_string_array_native_ptr);
            vectors.avio_print_string_array(@s, @strings);
        };
        
        vectors.avio_printf = (AVIOContext* @s, string @fmt) =>
        {
            var avio_printf_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_printf", ThrowErrorIfFunctionNotFound);
            vectors.avio_printf = avio_printf_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_printf' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_printf_delegate>(avio_printf_native_ptr);
            return vectors.avio_printf(@s, @fmt);
        };
        
        vectors.avio_protocol_get_class = (string @name) =>
        {
            var avio_protocol_get_class_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_protocol_get_class", ThrowErrorIfFunctionNotFound);
            vectors.avio_protocol_get_class = avio_protocol_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_protocol_get_class' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_protocol_get_class_delegate>(avio_protocol_get_class_native_ptr);
            return vectors.avio_protocol_get_class(@name);
        };
        
        vectors.avio_put_str = (AVIOContext* @s, string @str) =>
        {
            var avio_put_str_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_put_str", ThrowErrorIfFunctionNotFound);
            vectors.avio_put_str = avio_put_str_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_put_str' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_put_str_delegate>(avio_put_str_native_ptr);
            return vectors.avio_put_str(@s, @str);
        };
        
        vectors.avio_put_str16be = (AVIOContext* @s, string @str) =>
        {
            var avio_put_str16be_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_put_str16be", ThrowErrorIfFunctionNotFound);
            vectors.avio_put_str16be = avio_put_str16be_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_put_str16be' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_put_str16be_delegate>(avio_put_str16be_native_ptr);
            return vectors.avio_put_str16be(@s, @str);
        };
        
        vectors.avio_put_str16le = (AVIOContext* @s, string @str) =>
        {
            var avio_put_str16le_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_put_str16le", ThrowErrorIfFunctionNotFound);
            vectors.avio_put_str16le = avio_put_str16le_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_put_str16le' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_put_str16le_delegate>(avio_put_str16le_native_ptr);
            return vectors.avio_put_str16le(@s, @str);
        };
        
        vectors.avio_r8 = (AVIOContext* @s) =>
        {
            var avio_r8_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_r8", ThrowErrorIfFunctionNotFound);
            vectors.avio_r8 = avio_r8_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_r8' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_r8_delegate>(avio_r8_native_ptr);
            return vectors.avio_r8(@s);
        };
        
        vectors.avio_rb16 = (AVIOContext* @s) =>
        {
            var avio_rb16_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rb16", ThrowErrorIfFunctionNotFound);
            vectors.avio_rb16 = avio_rb16_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rb16' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rb16_delegate>(avio_rb16_native_ptr);
            return vectors.avio_rb16(@s);
        };
        
        vectors.avio_rb24 = (AVIOContext* @s) =>
        {
            var avio_rb24_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rb24", ThrowErrorIfFunctionNotFound);
            vectors.avio_rb24 = avio_rb24_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rb24' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rb24_delegate>(avio_rb24_native_ptr);
            return vectors.avio_rb24(@s);
        };
        
        vectors.avio_rb32 = (AVIOContext* @s) =>
        {
            var avio_rb32_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rb32", ThrowErrorIfFunctionNotFound);
            vectors.avio_rb32 = avio_rb32_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rb32' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rb32_delegate>(avio_rb32_native_ptr);
            return vectors.avio_rb32(@s);
        };
        
        vectors.avio_rb64 = (AVIOContext* @s) =>
        {
            var avio_rb64_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rb64", ThrowErrorIfFunctionNotFound);
            vectors.avio_rb64 = avio_rb64_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rb64' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rb64_delegate>(avio_rb64_native_ptr);
            return vectors.avio_rb64(@s);
        };
        
        vectors.avio_read = (AVIOContext* @s, byte* @buf, int @size) =>
        {
            var avio_read_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_read", ThrowErrorIfFunctionNotFound);
            vectors.avio_read = avio_read_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_read' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_read_delegate>(avio_read_native_ptr);
            return vectors.avio_read(@s, @buf, @size);
        };
        
        vectors.avio_read_dir = (AVIODirContext* @s, AVIODirEntry** @next) =>
        {
            var avio_read_dir_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_read_dir", ThrowErrorIfFunctionNotFound);
            vectors.avio_read_dir = avio_read_dir_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_read_dir' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_read_dir_delegate>(avio_read_dir_native_ptr);
            return vectors.avio_read_dir(@s, @next);
        };
        
        vectors.avio_read_partial = (AVIOContext* @s, byte* @buf, int @size) =>
        {
            var avio_read_partial_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_read_partial", ThrowErrorIfFunctionNotFound);
            vectors.avio_read_partial = avio_read_partial_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_read_partial' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_read_partial_delegate>(avio_read_partial_native_ptr);
            return vectors.avio_read_partial(@s, @buf, @size);
        };
        
        vectors.avio_read_to_bprint = (AVIOContext* @h, AVBPrint* @pb, ulong @max_size) =>
        {
            var avio_read_to_bprint_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_read_to_bprint", ThrowErrorIfFunctionNotFound);
            vectors.avio_read_to_bprint = avio_read_to_bprint_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_read_to_bprint' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_read_to_bprint_delegate>(avio_read_to_bprint_native_ptr);
            return vectors.avio_read_to_bprint(@h, @pb, @max_size);
        };
        
        vectors.avio_rl16 = (AVIOContext* @s) =>
        {
            var avio_rl16_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rl16", ThrowErrorIfFunctionNotFound);
            vectors.avio_rl16 = avio_rl16_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rl16' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rl16_delegate>(avio_rl16_native_ptr);
            return vectors.avio_rl16(@s);
        };
        
        vectors.avio_rl24 = (AVIOContext* @s) =>
        {
            var avio_rl24_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rl24", ThrowErrorIfFunctionNotFound);
            vectors.avio_rl24 = avio_rl24_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rl24' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rl24_delegate>(avio_rl24_native_ptr);
            return vectors.avio_rl24(@s);
        };
        
        vectors.avio_rl32 = (AVIOContext* @s) =>
        {
            var avio_rl32_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rl32", ThrowErrorIfFunctionNotFound);
            vectors.avio_rl32 = avio_rl32_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rl32' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rl32_delegate>(avio_rl32_native_ptr);
            return vectors.avio_rl32(@s);
        };
        
        vectors.avio_rl64 = (AVIOContext* @s) =>
        {
            var avio_rl64_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_rl64", ThrowErrorIfFunctionNotFound);
            vectors.avio_rl64 = avio_rl64_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_rl64' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_rl64_delegate>(avio_rl64_native_ptr);
            return vectors.avio_rl64(@s);
        };
        
        vectors.avio_seek = (AVIOContext* @s, long @offset, int @whence) =>
        {
            var avio_seek_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_seek", ThrowErrorIfFunctionNotFound);
            vectors.avio_seek = avio_seek_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_seek' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_seek_delegate>(avio_seek_native_ptr);
            return vectors.avio_seek(@s, @offset, @whence);
        };
        
        vectors.avio_seek_time = (AVIOContext* @h, int @stream_index, long @timestamp, int @flags) =>
        {
            var avio_seek_time_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_seek_time", ThrowErrorIfFunctionNotFound);
            vectors.avio_seek_time = avio_seek_time_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_seek_time' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_seek_time_delegate>(avio_seek_time_native_ptr);
            return vectors.avio_seek_time(@h, @stream_index, @timestamp, @flags);
        };
        
        vectors.avio_size = (AVIOContext* @s) =>
        {
            var avio_size_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_size", ThrowErrorIfFunctionNotFound);
            vectors.avio_size = avio_size_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_size' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_size_delegate>(avio_size_native_ptr);
            return vectors.avio_size(@s);
        };
        
        vectors.avio_skip = (AVIOContext* @s, long @offset) =>
        {
            var avio_skip_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_skip", ThrowErrorIfFunctionNotFound);
            vectors.avio_skip = avio_skip_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_skip' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_skip_delegate>(avio_skip_native_ptr);
            return vectors.avio_skip(@s, @offset);
        };
        
        vectors.avio_vprintf = (AVIOContext* @s, string @fmt, byte* @ap) =>
        {
            var avio_vprintf_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_vprintf", ThrowErrorIfFunctionNotFound);
            vectors.avio_vprintf = avio_vprintf_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_vprintf' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_vprintf_delegate>(avio_vprintf_native_ptr);
            return vectors.avio_vprintf(@s, @fmt, @ap);
        };
        
        vectors.avio_w8 = (AVIOContext* @s, int @b) =>
        {
            var avio_w8_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_w8", ThrowErrorIfFunctionNotFound);
            vectors.avio_w8 = avio_w8_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_w8' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_w8_delegate>(avio_w8_native_ptr);
            vectors.avio_w8(@s, @b);
        };
        
        vectors.avio_wb16 = (AVIOContext* @s, uint @val) =>
        {
            var avio_wb16_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wb16", ThrowErrorIfFunctionNotFound);
            vectors.avio_wb16 = avio_wb16_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wb16' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wb16_delegate>(avio_wb16_native_ptr);
            vectors.avio_wb16(@s, @val);
        };
        
        vectors.avio_wb24 = (AVIOContext* @s, uint @val) =>
        {
            var avio_wb24_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wb24", ThrowErrorIfFunctionNotFound);
            vectors.avio_wb24 = avio_wb24_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wb24' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wb24_delegate>(avio_wb24_native_ptr);
            vectors.avio_wb24(@s, @val);
        };
        
        vectors.avio_wb32 = (AVIOContext* @s, uint @val) =>
        {
            var avio_wb32_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wb32", ThrowErrorIfFunctionNotFound);
            vectors.avio_wb32 = avio_wb32_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wb32' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wb32_delegate>(avio_wb32_native_ptr);
            vectors.avio_wb32(@s, @val);
        };
        
        vectors.avio_wb64 = (AVIOContext* @s, ulong @val) =>
        {
            var avio_wb64_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wb64", ThrowErrorIfFunctionNotFound);
            vectors.avio_wb64 = avio_wb64_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wb64' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wb64_delegate>(avio_wb64_native_ptr);
            vectors.avio_wb64(@s, @val);
        };
        
        vectors.avio_wl16 = (AVIOContext* @s, uint @val) =>
        {
            var avio_wl16_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wl16", ThrowErrorIfFunctionNotFound);
            vectors.avio_wl16 = avio_wl16_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wl16' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wl16_delegate>(avio_wl16_native_ptr);
            vectors.avio_wl16(@s, @val);
        };
        
        vectors.avio_wl24 = (AVIOContext* @s, uint @val) =>
        {
            var avio_wl24_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wl24", ThrowErrorIfFunctionNotFound);
            vectors.avio_wl24 = avio_wl24_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wl24' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wl24_delegate>(avio_wl24_native_ptr);
            vectors.avio_wl24(@s, @val);
        };
        
        vectors.avio_wl32 = (AVIOContext* @s, uint @val) =>
        {
            var avio_wl32_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wl32", ThrowErrorIfFunctionNotFound);
            vectors.avio_wl32 = avio_wl32_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wl32' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wl32_delegate>(avio_wl32_native_ptr);
            vectors.avio_wl32(@s, @val);
        };
        
        vectors.avio_wl64 = (AVIOContext* @s, ulong @val) =>
        {
            var avio_wl64_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_wl64", ThrowErrorIfFunctionNotFound);
            vectors.avio_wl64 = avio_wl64_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_wl64' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_wl64_delegate>(avio_wl64_native_ptr);
            vectors.avio_wl64(@s, @val);
        };
        
        vectors.avio_write = (AVIOContext* @s, byte* @buf, int @size) =>
        {
            var avio_write_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_write", ThrowErrorIfFunctionNotFound);
            vectors.avio_write = avio_write_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_write' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_write_delegate>(avio_write_native_ptr);
            vectors.avio_write(@s, @buf, @size);
        };
        
        vectors.avio_write_marker = (AVIOContext* @s, long @time, AVIODataMarkerType @type) =>
        {
            var avio_write_marker_native_ptr = FunctionResolver.GetFunctionPointer("avformat", "avio_write_marker", ThrowErrorIfFunctionNotFound);
            vectors.avio_write_marker = avio_write_marker_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avio_write_marker' in the 'avformat' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avio_write_marker_delegate>(avio_write_marker_native_ptr);
            vectors.avio_write_marker(@s, @time, @type);
        };
        
        vectors.avsubtitle_free = (AVSubtitle* @sub) =>
        {
            var avsubtitle_free_native_ptr = FunctionResolver.GetFunctionPointer("avcodec", "avsubtitle_free", ThrowErrorIfFunctionNotFound);
            vectors.avsubtitle_free = avsubtitle_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avsubtitle_free' in the 'avcodec' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avsubtitle_free_delegate>(avsubtitle_free_native_ptr);
            vectors.avsubtitle_free(@sub);
        };
        
        vectors.avutil_configuration = () =>
        {
            var avutil_configuration_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "avutil_configuration", ThrowErrorIfFunctionNotFound);
            vectors.avutil_configuration = avutil_configuration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avutil_configuration' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avutil_configuration_delegate>(avutil_configuration_native_ptr);
            return vectors.avutil_configuration();
        };
        
        vectors.avutil_license = () =>
        {
            var avutil_license_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "avutil_license", ThrowErrorIfFunctionNotFound);
            vectors.avutil_license = avutil_license_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avutil_license' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avutil_license_delegate>(avutil_license_native_ptr);
            return vectors.avutil_license();
        };
        
        vectors.avutil_version = () =>
        {
            var avutil_version_native_ptr = FunctionResolver.GetFunctionPointer("avutil", "avutil_version", ThrowErrorIfFunctionNotFound);
            vectors.avutil_version = avutil_version_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'avutil_version' in the 'avutil' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.avutil_version_delegate>(avutil_version_native_ptr);
            return vectors.avutil_version();
        };
        
        vectors.swr_alloc = () =>
        {
            var swr_alloc_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_alloc", ThrowErrorIfFunctionNotFound);
            vectors.swr_alloc = swr_alloc_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_alloc' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_alloc_delegate>(swr_alloc_native_ptr);
            return vectors.swr_alloc();
        };
        
        vectors.swr_alloc_set_opts2 = (SwrContext** @ps, AVChannelLayout* @out_ch_layout, AVSampleFormat @out_sample_fmt, int @out_sample_rate, AVChannelLayout* @in_ch_layout, AVSampleFormat @in_sample_fmt, int @in_sample_rate, int @log_offset, void* @log_ctx) =>
        {
            var swr_alloc_set_opts2_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_alloc_set_opts2", ThrowErrorIfFunctionNotFound);
            vectors.swr_alloc_set_opts2 = swr_alloc_set_opts2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_alloc_set_opts2' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_alloc_set_opts2_delegate>(swr_alloc_set_opts2_native_ptr);
            return vectors.swr_alloc_set_opts2(@ps, @out_ch_layout, @out_sample_fmt, @out_sample_rate, @in_ch_layout, @in_sample_fmt, @in_sample_rate, @log_offset, @log_ctx);
        };
        
        vectors.swr_build_matrix2 = (AVChannelLayout* @in_layout, AVChannelLayout* @out_layout, double @center_mix_level, double @surround_mix_level, double @lfe_mix_level, double @maxval, double @rematrix_volume, double* @matrix, long @stride, AVMatrixEncoding @matrix_encoding, void* @log_context) =>
        {
            var swr_build_matrix2_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_build_matrix2", ThrowErrorIfFunctionNotFound);
            vectors.swr_build_matrix2 = swr_build_matrix2_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_build_matrix2' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_build_matrix2_delegate>(swr_build_matrix2_native_ptr);
            return vectors.swr_build_matrix2(@in_layout, @out_layout, @center_mix_level, @surround_mix_level, @lfe_mix_level, @maxval, @rematrix_volume, @matrix, @stride, @matrix_encoding, @log_context);
        };
        
        vectors.swr_close = (SwrContext* @s) =>
        {
            var swr_close_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_close", ThrowErrorIfFunctionNotFound);
            vectors.swr_close = swr_close_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_close' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_close_delegate>(swr_close_native_ptr);
            vectors.swr_close(@s);
        };
        
        vectors.swr_config_frame = (SwrContext* @swr, AVFrame* @out, AVFrame* @in) =>
        {
            var swr_config_frame_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_config_frame", ThrowErrorIfFunctionNotFound);
            vectors.swr_config_frame = swr_config_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_config_frame' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_config_frame_delegate>(swr_config_frame_native_ptr);
            return vectors.swr_config_frame(@swr, @out, @in);
        };
        
        vectors.swr_convert = (SwrContext* @s, byte** @out, int @out_count, byte** @in, int @in_count) =>
        {
            var swr_convert_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_convert", ThrowErrorIfFunctionNotFound);
            vectors.swr_convert = swr_convert_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_convert' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_convert_delegate>(swr_convert_native_ptr);
            return vectors.swr_convert(@s, @out, @out_count, @in, @in_count);
        };
        
        vectors.swr_convert_frame = (SwrContext* @swr, AVFrame* @output, AVFrame* @input) =>
        {
            var swr_convert_frame_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_convert_frame", ThrowErrorIfFunctionNotFound);
            vectors.swr_convert_frame = swr_convert_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_convert_frame' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_convert_frame_delegate>(swr_convert_frame_native_ptr);
            return vectors.swr_convert_frame(@swr, @output, @input);
        };
        
        vectors.swr_drop_output = (SwrContext* @s, int @count) =>
        {
            var swr_drop_output_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_drop_output", ThrowErrorIfFunctionNotFound);
            vectors.swr_drop_output = swr_drop_output_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_drop_output' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_drop_output_delegate>(swr_drop_output_native_ptr);
            return vectors.swr_drop_output(@s, @count);
        };
        
        vectors.swr_free = (SwrContext** @s) =>
        {
            var swr_free_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_free", ThrowErrorIfFunctionNotFound);
            vectors.swr_free = swr_free_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_free' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_free_delegate>(swr_free_native_ptr);
            vectors.swr_free(@s);
        };
        
        vectors.swr_get_class = () =>
        {
            var swr_get_class_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_get_class", ThrowErrorIfFunctionNotFound);
            vectors.swr_get_class = swr_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_get_class' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_get_class_delegate>(swr_get_class_native_ptr);
            return vectors.swr_get_class();
        };
        
        vectors.swr_get_delay = (SwrContext* @s, long @base) =>
        {
            var swr_get_delay_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_get_delay", ThrowErrorIfFunctionNotFound);
            vectors.swr_get_delay = swr_get_delay_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_get_delay' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_get_delay_delegate>(swr_get_delay_native_ptr);
            return vectors.swr_get_delay(@s, @base);
        };
        
        vectors.swr_get_out_samples = (SwrContext* @s, int @in_samples) =>
        {
            var swr_get_out_samples_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_get_out_samples", ThrowErrorIfFunctionNotFound);
            vectors.swr_get_out_samples = swr_get_out_samples_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_get_out_samples' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_get_out_samples_delegate>(swr_get_out_samples_native_ptr);
            return vectors.swr_get_out_samples(@s, @in_samples);
        };
        
        vectors.swr_init = (SwrContext* @s) =>
        {
            var swr_init_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_init", ThrowErrorIfFunctionNotFound);
            vectors.swr_init = swr_init_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_init' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_init_delegate>(swr_init_native_ptr);
            return vectors.swr_init(@s);
        };
        
        vectors.swr_inject_silence = (SwrContext* @s, int @count) =>
        {
            var swr_inject_silence_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_inject_silence", ThrowErrorIfFunctionNotFound);
            vectors.swr_inject_silence = swr_inject_silence_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_inject_silence' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_inject_silence_delegate>(swr_inject_silence_native_ptr);
            return vectors.swr_inject_silence(@s, @count);
        };
        
        vectors.swr_is_initialized = (SwrContext* @s) =>
        {
            var swr_is_initialized_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_is_initialized", ThrowErrorIfFunctionNotFound);
            vectors.swr_is_initialized = swr_is_initialized_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_is_initialized' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_is_initialized_delegate>(swr_is_initialized_native_ptr);
            return vectors.swr_is_initialized(@s);
        };
        
        vectors.swr_next_pts = (SwrContext* @s, long @pts) =>
        {
            var swr_next_pts_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_next_pts", ThrowErrorIfFunctionNotFound);
            vectors.swr_next_pts = swr_next_pts_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_next_pts' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_next_pts_delegate>(swr_next_pts_native_ptr);
            return vectors.swr_next_pts(@s, @pts);
        };
        
        vectors.swr_set_channel_mapping = (SwrContext* @s, int* @channel_map) =>
        {
            var swr_set_channel_mapping_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_set_channel_mapping", ThrowErrorIfFunctionNotFound);
            vectors.swr_set_channel_mapping = swr_set_channel_mapping_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_set_channel_mapping' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_set_channel_mapping_delegate>(swr_set_channel_mapping_native_ptr);
            return vectors.swr_set_channel_mapping(@s, @channel_map);
        };
        
        vectors.swr_set_compensation = (SwrContext* @s, int @sample_delta, int @compensation_distance) =>
        {
            var swr_set_compensation_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_set_compensation", ThrowErrorIfFunctionNotFound);
            vectors.swr_set_compensation = swr_set_compensation_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_set_compensation' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_set_compensation_delegate>(swr_set_compensation_native_ptr);
            return vectors.swr_set_compensation(@s, @sample_delta, @compensation_distance);
        };
        
        vectors.swr_set_matrix = (SwrContext* @s, double* @matrix, int @stride) =>
        {
            var swr_set_matrix_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swr_set_matrix", ThrowErrorIfFunctionNotFound);
            vectors.swr_set_matrix = swr_set_matrix_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swr_set_matrix' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swr_set_matrix_delegate>(swr_set_matrix_native_ptr);
            return vectors.swr_set_matrix(@s, @matrix, @stride);
        };
        
        vectors.swresample_configuration = () =>
        {
            var swresample_configuration_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swresample_configuration", ThrowErrorIfFunctionNotFound);
            vectors.swresample_configuration = swresample_configuration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swresample_configuration' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swresample_configuration_delegate>(swresample_configuration_native_ptr);
            return vectors.swresample_configuration();
        };
        
        vectors.swresample_license = () =>
        {
            var swresample_license_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swresample_license", ThrowErrorIfFunctionNotFound);
            vectors.swresample_license = swresample_license_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swresample_license' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swresample_license_delegate>(swresample_license_native_ptr);
            return vectors.swresample_license();
        };
        
        vectors.swresample_version = () =>
        {
            var swresample_version_native_ptr = FunctionResolver.GetFunctionPointer("swresample", "swresample_version", ThrowErrorIfFunctionNotFound);
            vectors.swresample_version = swresample_version_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swresample_version' in the 'swresample' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swresample_version_delegate>(swresample_version_native_ptr);
            return vectors.swresample_version();
        };
        
        vectors.sws_alloc_context = () =>
        {
            var sws_alloc_context_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_alloc_context", ThrowErrorIfFunctionNotFound);
            vectors.sws_alloc_context = sws_alloc_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_alloc_context' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_alloc_context_delegate>(sws_alloc_context_native_ptr);
            return vectors.sws_alloc_context();
        };
        
        vectors.sws_allocVec = (int @length) =>
        {
            var sws_allocVec_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_allocVec", ThrowErrorIfFunctionNotFound);
            vectors.sws_allocVec = sws_allocVec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_allocVec' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_allocVec_delegate>(sws_allocVec_native_ptr);
            return vectors.sws_allocVec(@length);
        };
        
        vectors.sws_convertPalette8ToPacked24 = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) =>
        {
            var sws_convertPalette8ToPacked24_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_convertPalette8ToPacked24", ThrowErrorIfFunctionNotFound);
            vectors.sws_convertPalette8ToPacked24 = sws_convertPalette8ToPacked24_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_convertPalette8ToPacked24' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_convertPalette8ToPacked24_delegate>(sws_convertPalette8ToPacked24_native_ptr);
            vectors.sws_convertPalette8ToPacked24(@src, @dst, @num_pixels, @palette);
        };
        
        vectors.sws_convertPalette8ToPacked32 = (byte* @src, byte* @dst, int @num_pixels, byte* @palette) =>
        {
            var sws_convertPalette8ToPacked32_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_convertPalette8ToPacked32", ThrowErrorIfFunctionNotFound);
            vectors.sws_convertPalette8ToPacked32 = sws_convertPalette8ToPacked32_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_convertPalette8ToPacked32' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_convertPalette8ToPacked32_delegate>(sws_convertPalette8ToPacked32_native_ptr);
            vectors.sws_convertPalette8ToPacked32(@src, @dst, @num_pixels, @palette);
        };
        
        vectors.sws_frame_end = (SwsContext* @c) =>
        {
            var sws_frame_end_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_frame_end", ThrowErrorIfFunctionNotFound);
            vectors.sws_frame_end = sws_frame_end_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_frame_end' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_frame_end_delegate>(sws_frame_end_native_ptr);
            vectors.sws_frame_end(@c);
        };
        
        vectors.sws_frame_setup = (SwsContext* @ctx, AVFrame* @dst, AVFrame* @src) =>
        {
            var sws_frame_setup_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_frame_setup", ThrowErrorIfFunctionNotFound);
            vectors.sws_frame_setup = sws_frame_setup_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_frame_setup' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_frame_setup_delegate>(sws_frame_setup_native_ptr);
            return vectors.sws_frame_setup(@ctx, @dst, @src);
        };
        
        vectors.sws_frame_start = (SwsContext* @c, AVFrame* @dst, AVFrame* @src) =>
        {
            var sws_frame_start_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_frame_start", ThrowErrorIfFunctionNotFound);
            vectors.sws_frame_start = sws_frame_start_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_frame_start' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_frame_start_delegate>(sws_frame_start_native_ptr);
            return vectors.sws_frame_start(@c, @dst, @src);
        };
        
        vectors.sws_free_context = (SwsContext** @ctx) =>
        {
            var sws_free_context_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_free_context", ThrowErrorIfFunctionNotFound);
            vectors.sws_free_context = sws_free_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_free_context' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_free_context_delegate>(sws_free_context_native_ptr);
            vectors.sws_free_context(@ctx);
        };
        
        vectors.sws_freeContext = (SwsContext* @swsContext) =>
        {
            var sws_freeContext_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_freeContext", ThrowErrorIfFunctionNotFound);
            vectors.sws_freeContext = sws_freeContext_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_freeContext' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_freeContext_delegate>(sws_freeContext_native_ptr);
            vectors.sws_freeContext(@swsContext);
        };
        
        vectors.sws_freeFilter = (SwsFilter* @filter) =>
        {
            var sws_freeFilter_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_freeFilter", ThrowErrorIfFunctionNotFound);
            vectors.sws_freeFilter = sws_freeFilter_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_freeFilter' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_freeFilter_delegate>(sws_freeFilter_native_ptr);
            vectors.sws_freeFilter(@filter);
        };
        
        vectors.sws_freeVec = (SwsVector* @a) =>
        {
            var sws_freeVec_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_freeVec", ThrowErrorIfFunctionNotFound);
            vectors.sws_freeVec = sws_freeVec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_freeVec' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_freeVec_delegate>(sws_freeVec_native_ptr);
            vectors.sws_freeVec(@a);
        };
        
        vectors.sws_get_class = () =>
        {
            var sws_get_class_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_get_class", ThrowErrorIfFunctionNotFound);
            vectors.sws_get_class = sws_get_class_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_get_class' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_get_class_delegate>(sws_get_class_native_ptr);
            return vectors.sws_get_class();
        };
        
        vectors.sws_getCachedContext = (SwsContext* @context, int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) =>
        {
            var sws_getCachedContext_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_getCachedContext", ThrowErrorIfFunctionNotFound);
            vectors.sws_getCachedContext = sws_getCachedContext_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_getCachedContext' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_getCachedContext_delegate>(sws_getCachedContext_native_ptr);
            return vectors.sws_getCachedContext(@context, @srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        };
        
        vectors.sws_getCoefficients = (int @colorspace) =>
        {
            var sws_getCoefficients_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_getCoefficients", ThrowErrorIfFunctionNotFound);
            vectors.sws_getCoefficients = sws_getCoefficients_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_getCoefficients' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_getCoefficients_delegate>(sws_getCoefficients_native_ptr);
            return vectors.sws_getCoefficients(@colorspace);
        };
        
        vectors.sws_getColorspaceDetails = (SwsContext* @c, int** @inv_table, int* @srcRange, int** @table, int* @dstRange, int* @brightness, int* @contrast, int* @saturation) =>
        {
            var sws_getColorspaceDetails_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_getColorspaceDetails", ThrowErrorIfFunctionNotFound);
            vectors.sws_getColorspaceDetails = sws_getColorspaceDetails_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_getColorspaceDetails' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_getColorspaceDetails_delegate>(sws_getColorspaceDetails_native_ptr);
            return vectors.sws_getColorspaceDetails(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        };
        
        vectors.sws_getContext = (int @srcW, int @srcH, AVPixelFormat @srcFormat, int @dstW, int @dstH, AVPixelFormat @dstFormat, int @flags, SwsFilter* @srcFilter, SwsFilter* @dstFilter, double* @param) =>
        {
            var sws_getContext_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_getContext", ThrowErrorIfFunctionNotFound);
            vectors.sws_getContext = sws_getContext_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_getContext' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_getContext_delegate>(sws_getContext_native_ptr);
            return vectors.sws_getContext(@srcW, @srcH, @srcFormat, @dstW, @dstH, @dstFormat, @flags, @srcFilter, @dstFilter, @param);
        };
        
        vectors.sws_getDefaultFilter = (float @lumaGBlur, float @chromaGBlur, float @lumaSharpen, float @chromaSharpen, float @chromaHShift, float @chromaVShift, int @verbose) =>
        {
            var sws_getDefaultFilter_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_getDefaultFilter", ThrowErrorIfFunctionNotFound);
            vectors.sws_getDefaultFilter = sws_getDefaultFilter_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_getDefaultFilter' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_getDefaultFilter_delegate>(sws_getDefaultFilter_native_ptr);
            return vectors.sws_getDefaultFilter(@lumaGBlur, @chromaGBlur, @lumaSharpen, @chromaSharpen, @chromaHShift, @chromaVShift, @verbose);
        };
        
        vectors.sws_getGaussianVec = (double @variance, double @quality) =>
        {
            var sws_getGaussianVec_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_getGaussianVec", ThrowErrorIfFunctionNotFound);
            vectors.sws_getGaussianVec = sws_getGaussianVec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_getGaussianVec' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_getGaussianVec_delegate>(sws_getGaussianVec_native_ptr);
            return vectors.sws_getGaussianVec(@variance, @quality);
        };
        
        vectors.sws_init_context = (SwsContext* @sws_context, SwsFilter* @srcFilter, SwsFilter* @dstFilter) =>
        {
            var sws_init_context_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_init_context", ThrowErrorIfFunctionNotFound);
            vectors.sws_init_context = sws_init_context_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_init_context' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_init_context_delegate>(sws_init_context_native_ptr);
            return vectors.sws_init_context(@sws_context, @srcFilter, @dstFilter);
        };
        
        vectors.sws_is_noop = (AVFrame* @dst, AVFrame* @src) =>
        {
            var sws_is_noop_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_is_noop", ThrowErrorIfFunctionNotFound);
            vectors.sws_is_noop = sws_is_noop_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_is_noop' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_is_noop_delegate>(sws_is_noop_native_ptr);
            return vectors.sws_is_noop(@dst, @src);
        };
        
        vectors.sws_isSupportedEndiannessConversion = (AVPixelFormat @pix_fmt) =>
        {
            var sws_isSupportedEndiannessConversion_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_isSupportedEndiannessConversion", ThrowErrorIfFunctionNotFound);
            vectors.sws_isSupportedEndiannessConversion = sws_isSupportedEndiannessConversion_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_isSupportedEndiannessConversion' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_isSupportedEndiannessConversion_delegate>(sws_isSupportedEndiannessConversion_native_ptr);
            return vectors.sws_isSupportedEndiannessConversion(@pix_fmt);
        };
        
        vectors.sws_isSupportedInput = (AVPixelFormat @pix_fmt) =>
        {
            var sws_isSupportedInput_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_isSupportedInput", ThrowErrorIfFunctionNotFound);
            vectors.sws_isSupportedInput = sws_isSupportedInput_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_isSupportedInput' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_isSupportedInput_delegate>(sws_isSupportedInput_native_ptr);
            return vectors.sws_isSupportedInput(@pix_fmt);
        };
        
        vectors.sws_isSupportedOutput = (AVPixelFormat @pix_fmt) =>
        {
            var sws_isSupportedOutput_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_isSupportedOutput", ThrowErrorIfFunctionNotFound);
            vectors.sws_isSupportedOutput = sws_isSupportedOutput_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_isSupportedOutput' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_isSupportedOutput_delegate>(sws_isSupportedOutput_native_ptr);
            return vectors.sws_isSupportedOutput(@pix_fmt);
        };
        
        vectors.sws_normalizeVec = (SwsVector* @a, double @height) =>
        {
            var sws_normalizeVec_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_normalizeVec", ThrowErrorIfFunctionNotFound);
            vectors.sws_normalizeVec = sws_normalizeVec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_normalizeVec' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_normalizeVec_delegate>(sws_normalizeVec_native_ptr);
            vectors.sws_normalizeVec(@a, @height);
        };
        
        vectors.sws_receive_slice = (SwsContext* @c, uint @slice_start, uint @slice_height) =>
        {
            var sws_receive_slice_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_receive_slice", ThrowErrorIfFunctionNotFound);
            vectors.sws_receive_slice = sws_receive_slice_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_receive_slice' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_receive_slice_delegate>(sws_receive_slice_native_ptr);
            return vectors.sws_receive_slice(@c, @slice_start, @slice_height);
        };
        
        vectors.sws_receive_slice_alignment = (SwsContext* @c) =>
        {
            var sws_receive_slice_alignment_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_receive_slice_alignment", ThrowErrorIfFunctionNotFound);
            vectors.sws_receive_slice_alignment = sws_receive_slice_alignment_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_receive_slice_alignment' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_receive_slice_alignment_delegate>(sws_receive_slice_alignment_native_ptr);
            return vectors.sws_receive_slice_alignment(@c);
        };
        
        vectors.sws_scale = (SwsContext* @c, byte*[] @srcSlice, int[] @srcStride, int @srcSliceY, int @srcSliceH, byte*[] @dst, int[] @dstStride) =>
        {
            var sws_scale_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_scale", ThrowErrorIfFunctionNotFound);
            vectors.sws_scale = sws_scale_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_scale' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_scale_delegate>(sws_scale_native_ptr);
            return vectors.sws_scale(@c, @srcSlice, @srcStride, @srcSliceY, @srcSliceH, @dst, @dstStride);
        };
        
        vectors.sws_scale_frame = (SwsContext* @c, AVFrame* @dst, AVFrame* @src) =>
        {
            var sws_scale_frame_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_scale_frame", ThrowErrorIfFunctionNotFound);
            vectors.sws_scale_frame = sws_scale_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_scale_frame' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_scale_frame_delegate>(sws_scale_frame_native_ptr);
            return vectors.sws_scale_frame(@c, @dst, @src);
        };
        
        vectors.sws_scaleVec = (SwsVector* @a, double @scalar) =>
        {
            var sws_scaleVec_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_scaleVec", ThrowErrorIfFunctionNotFound);
            vectors.sws_scaleVec = sws_scaleVec_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_scaleVec' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_scaleVec_delegate>(sws_scaleVec_native_ptr);
            vectors.sws_scaleVec(@a, @scalar);
        };
        
        vectors.sws_send_slice = (SwsContext* @c, uint @slice_start, uint @slice_height) =>
        {
            var sws_send_slice_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_send_slice", ThrowErrorIfFunctionNotFound);
            vectors.sws_send_slice = sws_send_slice_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_send_slice' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_send_slice_delegate>(sws_send_slice_native_ptr);
            return vectors.sws_send_slice(@c, @slice_start, @slice_height);
        };
        
        vectors.sws_setColorspaceDetails = (SwsContext* @c, in int_array4 @inv_table, int @srcRange, in int_array4 @table, int @dstRange, int @brightness, int @contrast, int @saturation) =>
        {
            var sws_setColorspaceDetails_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_setColorspaceDetails", ThrowErrorIfFunctionNotFound);
            vectors.sws_setColorspaceDetails = sws_setColorspaceDetails_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_setColorspaceDetails' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_setColorspaceDetails_delegate>(sws_setColorspaceDetails_native_ptr);
            return vectors.sws_setColorspaceDetails(@c, @inv_table, @srcRange, @table, @dstRange, @brightness, @contrast, @saturation);
        };
        
        vectors.sws_test_colorspace = (AVColorSpace @colorspace, int @output) =>
        {
            var sws_test_colorspace_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_test_colorspace", ThrowErrorIfFunctionNotFound);
            vectors.sws_test_colorspace = sws_test_colorspace_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_test_colorspace' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_test_colorspace_delegate>(sws_test_colorspace_native_ptr);
            return vectors.sws_test_colorspace(@colorspace, @output);
        };
        
        vectors.sws_test_format = (AVPixelFormat @format, int @output) =>
        {
            var sws_test_format_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_test_format", ThrowErrorIfFunctionNotFound);
            vectors.sws_test_format = sws_test_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_test_format' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_test_format_delegate>(sws_test_format_native_ptr);
            return vectors.sws_test_format(@format, @output);
        };
        
        vectors.sws_test_frame = (AVFrame* @frame, int @output) =>
        {
            var sws_test_frame_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_test_frame", ThrowErrorIfFunctionNotFound);
            vectors.sws_test_frame = sws_test_frame_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_test_frame' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_test_frame_delegate>(sws_test_frame_native_ptr);
            return vectors.sws_test_frame(@frame, @output);
        };
        
        vectors.sws_test_hw_format = (AVPixelFormat @format) =>
        {
            var sws_test_hw_format_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_test_hw_format", ThrowErrorIfFunctionNotFound);
            vectors.sws_test_hw_format = sws_test_hw_format_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_test_hw_format' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_test_hw_format_delegate>(sws_test_hw_format_native_ptr);
            return vectors.sws_test_hw_format(@format);
        };
        
        vectors.sws_test_primaries = (AVColorPrimaries @primaries, int @output) =>
        {
            var sws_test_primaries_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_test_primaries", ThrowErrorIfFunctionNotFound);
            vectors.sws_test_primaries = sws_test_primaries_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_test_primaries' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_test_primaries_delegate>(sws_test_primaries_native_ptr);
            return vectors.sws_test_primaries(@primaries, @output);
        };
        
        vectors.sws_test_transfer = (AVColorTransferCharacteristic @trc, int @output) =>
        {
            var sws_test_transfer_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "sws_test_transfer", ThrowErrorIfFunctionNotFound);
            vectors.sws_test_transfer = sws_test_transfer_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'sws_test_transfer' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.sws_test_transfer_delegate>(sws_test_transfer_native_ptr);
            return vectors.sws_test_transfer(@trc, @output);
        };
        
        vectors.swscale_configuration = () =>
        {
            var swscale_configuration_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "swscale_configuration", ThrowErrorIfFunctionNotFound);
            vectors.swscale_configuration = swscale_configuration_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swscale_configuration' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swscale_configuration_delegate>(swscale_configuration_native_ptr);
            return vectors.swscale_configuration();
        };
        
        vectors.swscale_license = () =>
        {
            var swscale_license_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "swscale_license", ThrowErrorIfFunctionNotFound);
            vectors.swscale_license = swscale_license_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swscale_license' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swscale_license_delegate>(swscale_license_native_ptr);
            return vectors.swscale_license();
        };
        
        vectors.swscale_version = () =>
        {
            var swscale_version_native_ptr = FunctionResolver.GetFunctionPointer("swscale", "swscale_version", ThrowErrorIfFunctionNotFound);
            vectors.swscale_version = swscale_version_native_ptr == IntPtr.Zero 
                ? throw new EntryPointNotFoundException("Could not find the function 'swscale_version' in the 'swscale' using. Is you using the full edition of FFmpeg?")
                : Marshal.GetDelegateForFunctionPointer<vectors.swscale_version_delegate>(swscale_version_native_ptr);
            return vectors.swscale_version();
        };
        
        ffmpeg.Ready = true;
    }
}
