using System;
using System.Collections.Generic;
using System.Linq;

namespace FFmpeg.AutoGen;

public sealed class FFmpegBindingTestResult
{
    public FFmpegBindingTestResult(IReadOnlyList<FFmpegBindingTestFailure> failures, Exception? exception)
    {
        Failures = failures ?? throw new ArgumentNullException(nameof(failures));
        Exception = exception;
    }

    public IReadOnlyList<FFmpegBindingTestFailure> Failures { get; internal set; }

    public Exception? Exception { get; }

    public bool IsSuccess => Exception is null && Failures.Count == 0;

    public bool IsAPISuccess(string libraryName, string functionName)
    {
        if (libraryName is null) throw new ArgumentNullException(nameof(libraryName));
        if (functionName is null) throw new ArgumentNullException(nameof(functionName));
        return Exception is null && !Failures.Any(f => f.LibraryName == libraryName && f.FunctionName == functionName);
    }

    internal void AppendResult(FFmpegBindingTestFailure failure)
    {
        Failures = Failures.Append(failure).ToArray();
    }
}

public sealed class FFmpegBindingTestFailure
{
    public FFmpegBindingTestFailure(string libraryName, string functionName, string message)
    {
        LibraryName = libraryName ?? throw new ArgumentNullException(nameof(libraryName));
        FunctionName = functionName ?? throw new ArgumentNullException(nameof(functionName));
        Message = message ?? throw new ArgumentNullException(nameof(message));
    }

    public string LibraryName { get; }

    public string FunctionName { get; }

    public string Message { get; }
}
