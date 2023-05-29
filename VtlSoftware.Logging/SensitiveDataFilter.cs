using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace VtlSoftware.Logging
{
    [CompileTime]
    internal static class SensitiveDataFilter
    {
        #region Public Methods

        public static bool IsSensitive(IParameter parameter)
        {
            bool result = false;
            if(parameter.Attributes.OfAttributeType(typeof(RedactAttribute)).Any())
            {
                result = true;
            }

            return result;

            //var options = parameter.Compilation.Project.LoggingOptions();

            //return options.SensitiveData.Contains(parameter.Name);
        }

        #endregion
    }
}
