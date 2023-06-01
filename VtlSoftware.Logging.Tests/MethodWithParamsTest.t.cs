namespace VtlSoftware.Logging.Tests
{
    internal class MethodWithParamsTest
    {
        [LogMethod]
        private string ChangeString(string stringToChange)
        {
            string redacted = "Redacted";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                parameters.Add("Type = string: Parameter Name = stringToChange", stringToChange);
                global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering MethodWithParamsTest.ChangeString with these parameters: {parameters}");
            }
            try
            {
                global::System.String result;
                result = stringToChange.ToUpper();
                if (isTracingEnabled)
                {
                    global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving MethodWithParamsTest.ChangeString with the following result: {result}");
                }
                return (global::System.String)result;
            }
            catch (global::System.Exception e)
            {
                global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in MethodWithParamsTest.ChangeString. These are the details: {e}");
                throw;
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public MethodWithParamsTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.MethodWithParamsTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.MethodWithParamsTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}