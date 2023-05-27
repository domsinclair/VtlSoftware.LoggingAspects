using System.Runtime.CompilerServices;
namespace VtlSoftware.Logging;


[InterpolatedStringHandler]
public ref struct VtlLoggingTraceInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    public VtlLoggingTraceInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Trace, out isEnabled);
    }

    public bool IsEnabled => handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct VtlLoggingDebugInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    public VtlLoggingDebugInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Debug, out isEnabled);
    }

    public bool IsEnabled => handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct VtlLoggingInformationInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    public VtlLoggingInformationInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Information, out isEnabled);
    }

    public bool IsEnabled => handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct VtlLoggingWarningInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    public VtlLoggingWarningInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Warning, out isEnabled);
    }

    public bool IsEnabled => handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct VtlLoggingErrorInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    public VtlLoggingErrorInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Error, out isEnabled);
    }

    public bool IsEnabled => handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}

[InterpolatedStringHandler]
public ref struct VtlLoggingCriticalInterpolatedStringHandler
{
    private readonly VtlLoggingInterpolatedStringHandler handler;

    public VtlLoggingCriticalInterpolatedStringHandler(int literalLength, int formattedCount, ILogger logger, out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(literalLength, formattedCount, logger, LogLevel.Critical, out isEnabled);
    }

    public bool IsEnabled => handler.IsEnabled;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(value, name);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();
}
