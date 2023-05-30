// <copyright file="Handlers.v.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 30 May 2023 </date>
// <summary> Implements the handlers.v class </summary>

using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging;

/// <summary>
/// A vtl logging trace interpolated string handler.
/// </summary>
///
/// <remarks></remarks>

[InterpolatedStringHandler]
public readonly ref struct  VtlLoggingTraceInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>

    public VtlLoggingTraceInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Trace,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    /// <summary>
    /// Appends a formatted.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="name">(Optional) The name.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>

    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

/// <summary>
/// A vtl logging debug interpolated string handler.
/// </summary>
///
/// <remarks></remarks>

[InterpolatedStringHandler]
public readonly ref struct  VtlLoggingDebugInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>

    public VtlLoggingDebugInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Debug,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    /// <summary>
    /// Appends a formatted.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="name">(Optional) The name.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>

    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

/// <summary>
/// A vtl logging information interpolated string handler.
/// </summary>
///
/// <remarks></remarks>

[InterpolatedStringHandler]
public readonly ref struct  VtlLoggingInformationInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>

    public VtlLoggingInformationInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Information,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    /// <summary>
    /// Appends a formatted.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="name">(Optional) The name.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>

    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

/// <summary>
/// A vtl logging warning interpolated string handler.
/// </summary>
///
/// <remarks></remarks>

[InterpolatedStringHandler]
public readonly ref struct  VtlLoggingWarningInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>

    public VtlLoggingWarningInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Warning,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    /// <summary>
    /// Appends a formatted.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="name">(Optional) The name.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>

    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

/// <summary>
/// A vtl logging error interpolated string handler.
/// </summary>
///
/// <remarks></remarks>

[InterpolatedStringHandler]
public readonly ref struct  VtlLoggingErrorInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>

    public VtlLoggingErrorInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Error,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    /// <summary>
    /// Appends a formatted.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="name">(Optional) The name.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>

    public bool IsEnabled => handler.IsEnabled;

    #endregion
}

/// <summary>
/// A vtl logging critical interpolated string handler.
/// </summary>
///
/// <remarks></remarks>

[InterpolatedStringHandler]
public readonly ref struct  VtlLoggingCriticalInterpolatedStringHandler
{
    /// <summary>
    /// (Immutable) The handler.
    /// </summary>
    private readonly VtlLoggingInterpolatedStringHandler handler;

    #region Constructors
    /// <summary>
    /// Constructor.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="literalLength">Length of the literal.</param>
    /// <param name="formattedCount">Number of formatted.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>

    public VtlLoggingCriticalInterpolatedStringHandler(
        int literalLength,
        int formattedCount,
        ILogger logger,
        out bool isEnabled)
    {
        handler = new VtlLoggingInterpolatedStringHandler(
            literalLength,
            formattedCount,
            logger,
            LogLevel.Critical,
            out isEnabled);
    }

    #endregion

    #region Public Methods
    /// <summary>
    /// Appends a formatted.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <typeparam name="T">Generic type parameter.</typeparam>
    /// <param name="value">The value.</param>
    /// <param name="name">(Optional) The name.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "") => handler.AppendFormatted(
        value,
        name);

    /// <summary>
    /// Appends a literal.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <param name="s">The string.</param>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public void AppendLiteral(string s) => handler.AppendLiteral(s);

    /// <summary>
    /// Gets template and arguments.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <returns>The template and arguments.</returns>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public (string, object?[]) GetTemplateAndArguments() => handler.GetTemplateAndArguments();

    #endregion

    #region Public Properties
    /// <summary>
    /// Gets a value indicating whether this object is enabled.
    /// </summary>
    ///
    /// <value>True if this object is enabled, false if not.</value>

    public bool IsEnabled => handler.IsEnabled;

    #endregion
}
