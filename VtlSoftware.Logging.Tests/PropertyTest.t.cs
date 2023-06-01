namespace VtlSoftware.Logging.Tests
{
    internal class PropertyTest
    {
        private string firstName;
        [LogProperty]
        public string FirstName
        {
            get
            {
                return this.FirstName_Source;
            }
            set
            {
                this.FirstName_Source = value;
                global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The value of PropertyTest.FirstName was set to: {this.FirstName_Source}");
            }
        }
        private string FirstName_Source { get => firstName; set => firstName = value; }
        private global::Microsoft.Extensions.Logging.ILogger logger;
        public PropertyTest(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.PropertyTest> logger = default(global::Microsoft.Extensions.Logging.ILogger<global::VtlSoftware.Logging.Tests.PropertyTest>))
        {
            this.logger = logger ?? throw new System.ArgumentNullException(nameof(logger));
        }
    }
}
