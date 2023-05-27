
///--------
///
// file:	VtlSoftware.Logging\LoggerExtensions.cs
//
// summary:	Implements the logger extensions class
///-------------------------------------------------------------------------------------------------

using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging
{
    ///---- LoggerExtensions   (Class) ----
    ///
    /// <summary>
    /// Logger extensions.
    /// </summary>
    ///
    /// <remarks>
    /// A set of extension methods for the main log levels provided by the ILogger interface in
    /// Microsoft.Extensions.Logging
    /// </remarks>
    ///-------------------------------------------------------------------------------------------------

    public static partial class LoggerExtensions
    {
        #region Public Methods

        ///---- Log   (Method) ----
        ///
        /// <summary>
        /// An ILogger extension method that logs the plain Log method.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="logger">The logger to act on.</param>
        /// <param name="logLevel">The log level.</param>
        /// <param name="handler">[in,out] The handler.</param>
        ///-------------------------------------------------------------------------------------------------

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
