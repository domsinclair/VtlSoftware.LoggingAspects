namespace VtlSoftware.Logging.Tests
{
    internal class VoidMethodTest
    {
        #region Private Methods
        [LogMethod]
        private void DoSomething()
        {
            var message = "Hi There";
        }

        #endregion
    }
}
