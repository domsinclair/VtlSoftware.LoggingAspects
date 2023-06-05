using Metalama.Framework.Fabrics;
namespace VtlSoftware.Logging.Tests
{
    [NoLog]
    internal class DoNotLogAllPublicMethodsInNoLogClassTest
    {
        private void DoSomethingElse()
        {
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public void DoSomething()
        {
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public DoNotLogAllPublicMethodsInNoLogClassTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.DoNotLogAllPublicMethodsInNoLogClassTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.DoNotLogAllPublicMethodsInNoLogClassTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
    public static class Static1
    {
        public static void DoMoreStuff()
        {
        }
    }
#pragma warning disable CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
    public class SecondFabric : ProjectFabric
    {
        public override void AmendProject(IProjectAmender amender) => throw new System.NotSupportedException("Compile-time-only code cannot be called at run-time.");
    }
#pragma warning restore CS0067, CS8618, CS0162, CS0169, CS0414, CA1822, CA1823, IDE0051, IDE0052
}
