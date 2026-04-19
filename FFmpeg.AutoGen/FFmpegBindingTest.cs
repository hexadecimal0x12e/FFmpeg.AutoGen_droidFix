using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace FFmpeg.AutoGen;

public static class FFmpegBindingTest
{
    public static FFmpegBindingTestResult VerifyDynamicallyLoadedBindings()
    {
        var failures = new List<FFmpegBindingTestFailure>();
        Exception? exception = null;

        try
        {
            if (DynamicallyLoadedBindings.FunctionResolver is null)
                throw new InvalidOperationException("DynamicallyLoadedBindings.FunctionResolver was not initialized.");

            foreach (var functionBinding in DynamicallyLoadedBindingMap.Functions)
            {
                foreach (var functionName in functionBinding.Value)
                {
                    if (!IsSupportedBindingFunction(functionName))
                    {
                        continue;
                    }

                    try
                    {
                        if (DynamicallyLoadedBindings.FunctionResolver.GetFunctionPointer(functionBinding.Key, functionName, false) == IntPtr.Zero)
                        {
                            Debug.WriteLine($"Failed to resolve {functionName} from {functionBinding.Key}.");
                            failures.Add(new FFmpegBindingTestFailure(
                                functionBinding.Key,
                                functionName,
                                $"Could not resolve {functionName} from {functionBinding.Key}."));
                        }
                    }
                    catch (Exception functionException)
                    {
                        failures.Add(new FFmpegBindingTestFailure(
                            functionBinding.Key,
                            functionName,
                            functionException.Message));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        return new FFmpegBindingTestResult(failures, exception);
    }

    private static bool IsSupportedBindingFunction(string functionName)
    {

        return !(string.IsNullOrWhiteSpace(functionName) || functionName.StartsWith("avpriv_", StringComparison.Ordinal)) 
                && (functionName.StartsWith("av", StringComparison.Ordinal) || functionName.StartsWith("swr_", StringComparison.Ordinal) || functionName.StartsWith("sws_", StringComparison.Ordinal));
    }
}