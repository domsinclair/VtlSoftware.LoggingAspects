
// file:	VtlSoftware.Logging\VtlLoggingInterpolatedStringHandler.cs
//
// summary:	Implements the vtl logging interpolated string handler class

using System.Runtime.CompilerServices;

namespace VtlSoftware.Logging
{
    ///---- VtlLoggingInterpolatedStringHandler   (Struct) ----
    ///
    /// <summary>
    /// A logging interpolated string handler.
    /// </summary>
    ///
    /// <remarks>
    /// Handles an interpolated string such that it can produce  both a string for diaplay in coventional text format or
    /// structured data output for frameworks like Serilog.
    /// </remarks>
    ///-------------------------------------------------------------------------------------------------

    [InterpolatedStringHandler]
    public ref struct VtlLoggingInterpolatedStringHandler
    {
        /// <summary>
        /// (Immutable) The template.
        /// </summary>
        private readonly StringBuilder template = null!;

        /// <summary>
        /// (Immutable) The arguments.
        /// </summary>
        private readonly ArgumentList arguments = null!;

        #region Constructors
        ///---- VtlLoggingInterpolatedStringHandler   (Constructor) ----
        ///
        /// <summary>
        /// Constructor.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="literalLength">Length of the literal.</param>
        /// <param name="formattedCount">Number of formatted.</param>
        /// <param name="logger">The logger.</param>
        /// <param name="logLevel">The log level.</param>
        /// <param name="isEnabled">[out] True if this object is enabled, false if not.</param>
        ///-------------------------------------------------------------------------------------------------

        public VtlLoggingInterpolatedStringHandler(
            int literalLength,
            int formattedCount,
            ILogger logger,
            LogLevel logLevel,
            out bool isEnabled)
        {
            IsEnabled = isEnabled = logger.IsEnabled(logLevel);
            if(isEnabled)
            {
                template = new(literalLength + 20 * formattedCount);
                arguments = new(formattedCount);
            }
        }

        #endregion

        #region Public Methods
        ///---- AppendFormatted (of T)   (Method) ----
        ///
        /// <summary>
        /// Appends a value to the final formatted string output.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="value">The value.</param>
        /// <param name="name">(Optional) The name.</param>
        ///-------------------------------------------------------------------------------------------------

        public void AppendFormatted<T>(T value, [CallerArgumentExpression("value")] string name = "")
        {
            if(!IsEnabled)
                return;

            arguments.Add(value);
            template.Append($"{{@{name}}}");
        }

        ///---- AppendLiteral   (Method) ----
        ///
        /// <summary>
        /// Appends a literal string to the formatted string output.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="s">The string.</param>
        ///-------------------------------------------------------------------------------------------------

        public void AppendLiteral(string s)
        {
            if(!IsEnabled)
                return;

            template.Append(s.Replace("{", "{{", StringComparison.Ordinal).Replace("}", "}}", StringComparison.Ordinal));
        }

        ///---- GetTemplateAndArguments   (Method) ----
        ///
        /// <summary>
        /// Gets template and arguments.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <returns>The template and arguments.</returns>
        ///-------------------------------------------------------------------------------------------------

        public (string, object?[]) GetTemplateAndArguments() => (template.ToString(), arguments.Arguments);

        #endregion

        #region Public Properties
        ///---- IsEnabled   (Property) ----
        ///
        /// <summary>
        /// Gets a value indicating whether this object is enabled.
        /// </summary>
        ///
        /// <value>True if this object is enabled, false if not.</value>
        ///-------------------------------------------------------------------------------------------------

        public bool IsEnabled { get; }

        #endregion

        ///---- ArgumentList   (Class) ----
        ///
        /// <summary>
        /// List of arguments.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///-------------------------------------------------------------------------------------------------

        private class ArgumentList
        {
            #region Fields

            /// <summary>
            /// Zero-based index of the.
            /// </summary>
            private int _index;

            #endregion

            #region Constructors
            ///---- ArgumentList   (Constructor) ----
            ///
            /// <summary>
            /// Constructor.
            /// </summary>
            ///
            /// <remarks></remarks>
            ///
            /// <param name="formattedCount">Number of formatted.</param>
            ///
            /// ### <remarks>.</remarks>
            ///-------------------------------------------------------------------------------------------------

            public ArgumentList(int formattedCount) => Arguments = new object?[formattedCount];

            #endregion

            #region Public Methods
            ///---- Add   (Method) ----
            ///
            /// <summary>
            /// Adds value.
            /// </summary>
            ///
            /// <remarks></remarks>
            ///
            /// <param name="value">The value to add.</param>
            ///
            /// ### <remarks>.</remarks>
            ///-------------------------------------------------------------------------------------------------

            public void Add(object? value) => Arguments[_index++] = value;

            #endregion

            #region Public Properties
            ///---- Arguments   (Property) ----
            ///
            /// <summary>
            /// Gets the arguments.
            /// </summary>
            ///
            /// <value>The arguments.</value>
            ///-------------------------------------------------------------------------------------------------

            public object?[] Arguments { get; }

            #endregion
        }
    }
}
