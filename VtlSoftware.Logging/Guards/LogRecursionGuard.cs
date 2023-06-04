// <copyright file="LogRecursionGuard.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 04 Jun 2023 </date>
// <summary> Implements the log recursion guard class </summary>

namespace VtlSoftware.Logging
{
    /// <summary>
    /// A log recursion guard.
    /// </summary>
    ///
    /// <remarks></remarks>

    public static class LogRecursionGuard
    {
        #region Fields

        /// <summary>
        /// True if is logging, false if not.
        /// </summary>
        [ThreadStatic]
        public static bool isLogging;

        #endregion

        #region Public Methods
        /// <summary>
        /// Gets the begin.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <returns>A DisposeCookie.</returns>

        public static DisposeCookie Begin()
        {
            if(isLogging)
            {
                return new DisposeCookie(false);
            } else
            {
                isLogging = true;
                return new DisposeCookie(true);
            }
        }

        #endregion

        /// <summary>
        /// A dispose cookie.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <seealso cref="T:IDisposable"/>

        public class DisposeCookie : IDisposable
        {
            #region Constructors
            /// <summary>
            /// Constructor.
            /// </summary>
            ///
            /// <remarks></remarks>
            ///
            /// <param name="canLog">True if we can log, false if not.</param>

            public DisposeCookie(bool canLog) { this.CanLog = canLog; }

            #endregion

            #region Public Methods
            /// <summary>
            /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
            /// </summary>
            ///
            /// <remarks></remarks>
            ///
            /// <seealso cref="M:IDisposable.Dispose()"/>

            public void Dispose()
            {
                if(this.CanLog)
                {
                    isLogging = false;
                }
            }

            #endregion

            #region Public Properties
            /// <summary>
            /// Gets a value indicating whether we can log.
            /// </summary>
            ///
            /// <value>True if we can log, false if not.</value>

            public bool CanLog { get; }

            #endregion
        }
    }
}
