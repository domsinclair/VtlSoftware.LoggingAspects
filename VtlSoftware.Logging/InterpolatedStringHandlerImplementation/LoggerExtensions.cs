// <copyright file="LoggerExtensions.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 30 May 2023 </date>
// <summary> Implements the logger extensions class </summary>

using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging
{
    /// <summary>
    /// A logger extensions.
    /// </summary>
    ///
    /// <remarks></remarks>

    public static partial class LoggerExtensions
    {
        #region Public Methods
        /// <summary>
        /// An ILogger extension method that logs.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="logger">The logger to act on.</param>
        /// <param name="logLevel">The log level.</param>
        /// <param name="handler">[in,out] The handler.</param>

        public static void Log(
            this ILogger logger,
            LogLevel logLevel,
            [InterpolatedStringHandlerArgument("logger", "logLevel")] ref VtlLoggingInterpolatedStringHandler handler)
        {
            if(handler.IsEnabled)
            {
                var (template, arguments) = handler.GetTemplateAndArguments();
                logger.Log(logLevel, template, arguments);
            }
        }

        #endregion
    }
}
