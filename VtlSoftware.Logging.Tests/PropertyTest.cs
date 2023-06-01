namespace VtlSoftware.Logging.Tests
{
    internal class PropertyTest
    {
        #region Fields
        private string firstName;

        #endregion

        #region Public Properties
        [LogProperty]
        public string FirstName { get => firstName; set => firstName = value; }

        #endregion
    }
}
