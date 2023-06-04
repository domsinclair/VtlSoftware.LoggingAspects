namespace VtlSoftware.Logging.Tests
{
    public class TimedVoidMethodTest
    {
        [TimedLogMethod]
        public void DoSomethingh()
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Logging.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering TimedVoidMethodTest.DoSomethingh.");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                object result = null;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Logging.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving TimedVoidMethodTest.DoSomethingh.");
                        }
                    }
                }
                return;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in TimedVoidMethodTest.DoSomethingh. These are the details: {e}");
                    }
                }
                throw;
            }
            finally
            {
                watch.Stop();
                using (var guard_3 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                {
                    if (guard_3.CanLog)
                    {
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"TimedVoidMethodTest.DoSomethingh took {watch.ElapsedMilliseconds} ms to complete.");
                    }
                }
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public TimedVoidMethodTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.TimedVoidMethodTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.TimedVoidMethodTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}
