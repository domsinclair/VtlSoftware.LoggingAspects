namespace VtlSoftware.Logging.ConsoleApp
{
    internal class Calculator
    {
        #region Private Methods
        [TimedLogMethod]
        private double Add(double a, double b) => a + b;

        #endregion
    }
}
