namespace VtlSoftware.Logging.Tests
{
    internal class MethodWithParamsTest
    {
        #region Private Methods

        [LogMethod]
        private string ChangeString(string stringToChange) { return stringToChange.ToUpper(); }

        #endregion
    }
}
