using Metalama.Framework.Fabrics;
namespace VtlSoftware.Logging.Tests
{
    internal class LoggingPublicNonStaticMethodsOnlyTest
    {
        private void DoSomethingElse()
        {
        }
        public int Add(int a, int b)
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
                        parameters.Add("Type = int: Parameter Name = a", a);
                        parameters.Add("Type = int: Parameter Name = b", b);
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Entering LoggingPublicNonStaticMethodsOnlyTest.Add with these parameters: {parameters}");
                    }
                }
            }
            try
            {
                global::System.Int32 result;
                result = a + b;
                if (isTracingEnabled)
                {
                    using (var guard_1 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                    {
                        if (guard_1.CanLog)
                        {
                            global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"Leaving LoggingPublicNonStaticMethodsOnlyTest.Add with the following result: {result}");
                        }
                    }
                }
                return (global::System.Int32)result;
            }
            catch (global::System.Exception e) when (this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Warning))
            {
                using (var guard_2 = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                {
                    if (guard_2.CanLog)
                    {
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LoggingPublicNonStaticMethodsOnlyTest.Add. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        public void DoSomething()
        {
            const string redacted = "<Redacted>";
            var isTracingEnabled = this.logger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel.Trace);
            if (isTracingEnabled)
            {
                using (var guard = global::VtlSoftware.Logging.LogRecursionGuard.Begin())
                {
                    if (guard.CanLog)
                    {
                        global::VtlSoftware.Logging.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Entering LoggingPublicNonStaticMethodsOnlyTest.DoSomething.");
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
                            global::VtlSoftware.Logging.LoggerExtensions.LogString(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, "Leaving LoggingPublicNonStaticMethodsOnlyTest.DoSomething.");
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
                        global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Error, $"An error has occured in LoggingPublicNonStaticMethodsOnlyTest.DoSomething. These are the details: {e}");
                    }
                }
                throw;
            }
        }
        [NoLog]
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public LoggingPublicNonStaticMethodsOnlyTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.LoggingPublicNonStaticMethodsOnlyTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.LoggingPublicNonStaticMethodsOnlyTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public static class DoStuff
    {
        public static void DoMoreStuff()
        {
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class FirstFabric : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}
