using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VtlSoftware.Logging.Tests
{
    public class TimedMethodWithParamsTest
    {
        [TimedLogMethod]
        private string ChangeString(string stringToChange)
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object> parameters = new();
                        parameters.Add("Type = string: Parameter Name = stringToChange", stringToChange);
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering TimedMethodWithParamsTest.ChangeString with these parameters: {parameters}");
                    }
                }
            }
            global::System.Diagnostics.Stopwatch watch = global::System.Diagnostics.Stopwatch.StartNew();
            try
            {
                global::System.String result;
                result = stringToChange.ToUpper();
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving TimedMethodWithParamsTest.ChangeString with the following result: {result}");
                        }
                    }
                }
                return (global::System.String)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in TimedMethodWithParamsTest.ChangeString. These are the details: {e}");
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
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"TimedMethodWithParamsTest.ChangeString took {watch.ElapsedMilliseconds} ms to complete.");
                    }
                }
            }
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public TimedMethodWithParamsTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.TimedMethodWithParamsTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.TimedMethodWithParamsTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}