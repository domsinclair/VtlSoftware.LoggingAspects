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
                var oldPropValue = this.FirstName_Source;
                this.FirstName_Source = value;
                var newPropValue = this.FirstName_Source;
                global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The old value of PropertyTest.FirstName was: string = {oldPropValue}");
                global::VtlSoftware.Logging.LoggerExtensions.Log(logger, global::Microsoft.Extensions.Logging.LogLevel.Information, $"The new value of PropertyTest.FirstName is: string = {newPropValue}");
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
