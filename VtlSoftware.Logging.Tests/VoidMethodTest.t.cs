namespace VtlSoftware.Logging.Tests
{
    public class VoidMethodTest
    {
        public VoidMethodTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.VoidMethodTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.VoidMethodTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
        [LogMethod]
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
                        global::VtlSoftware.Logging.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering VoidMethodTest.DoSomethingh.");
                    }
                }
            }
            try
            {
                object result = null;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Logging.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving VoidMethodTest.DoSomethingh.");
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
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in VoidMethodTest.DoSomethingh. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
    }
}
