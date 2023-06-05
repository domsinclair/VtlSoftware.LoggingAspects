using Metalama.Framework.Fabrics;

namespace VtlSoftware.Logging.Tests
{
    internal class LoggingPublicNonStaticMethodsOnlyTest
    {
        #region Private Methods
        private void DoSomethingElse()
        {
        }

        #endregion

        #region Public Methods
        public int Add(int a, int b) { return a + b; }

        public void DoSomething()
        {
        }

        [NoLog]
        public int Subtract(int a, int b) { return a - b; }

        #endregion
    }

    public static class DoStuff
    {
        #region Public Methods
        public static void DoMoreStuff()
        {
        }

        #endregion
    }

    public class FirstFabric : ProjectFabric
    {
        #region Public Methods
        public override void AmendProject(IProjectAmender amender) { amender.LogAllPublicMethods(); }

        #endregion
    }
}
