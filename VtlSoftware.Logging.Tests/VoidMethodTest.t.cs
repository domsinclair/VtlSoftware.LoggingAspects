namespace VtlSoftware.Logging.Tests
{
    internal class VoidMethodTest
    {
        [LogMethod]
        private void DoSomething()
        {
            string redacted = "Redacted";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information,ref  "Entering VoidMethodTest.DoSomething");
            }
            try
            {
                var message = "Hi There";
                object result = null;
                if (isTracingEnabled)
                {
                    global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information,ref  "Leaving VoidMethodTest.DoSomething.");
                }
                return;
            }
            catch (global::System.Exception e)
            {
                global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in VoidMethodTest.DoSomething. These are the details: {e}");
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public VoidMethodTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.VoidMethodTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.VoidMethodTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}
