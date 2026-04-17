using System;

namespace FFmpeg.AutoGen;

/// <summary>
///     Supports loading functions from native libraries. Provides a more flexible alternative to P/Invoke.
/// </summary>
public interface IFunctionResolver
{
    /// <summary>
    ///     Get the delegate's native function pointer.
    ///     Which is a AOT-friendly alternative to <see cref="GetFunctionDelegate{T}"/>. It can be used in scenarios where AOT compilation is required, such as in Unity or Xamarin applications.
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

    /// <summary>
    ///     Creates a delegate which invokes a native function.
    /// </summary>
    /// <typeparam name="T">
    ///     The function delegate.
    /// </typeparam>
    /// <param name="libraryName">
    ///     The library name which contains the function.
    /// </param>
    /// <param name="functionName">
    ///     The name of the function for which to create the delegate.
    /// </param>
    /// <returns>
    ///     A new delegate which points to the native function.
    /// </returns>
    T GetFunctionDelegate<T>(string libraryName, string functionName, bool throwOnError = true);
}
