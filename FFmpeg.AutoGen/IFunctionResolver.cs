using System;

namespace FFmpeg.AutoGen;

/// <summary>
///     Supports loading functions from native libraries. Provides a more flexible alternative to P/Invoke.
/// </summary>
public interface IFunctionResolver
{
    /// <summary>
    ///     Get the delegate's native function pointer.
    ///     A AOT-friendly implementation.
    /// </summary>
    /// <param name="libraryName">
    ///     The library name which contains the function.
    /// </param>
    /// <param name="functionName">
    ///     The name of the function for which to create the delegate.
    /// </param>
    /// <returns>
    ///     A new delegate which points to the native function.
    /// </returns>
    IntPtr GetFunctionPointer(string libraryName, string functionName, bool throwOnError = true);

}
