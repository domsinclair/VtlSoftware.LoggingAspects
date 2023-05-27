using Metalama.Framework.Aspects;
using Metalama.Framework.Code;
using Metalama.Framework.Eligibility;

namespace VtlSoftware.Logging
{
    public class LogMethodAttribute : OverrideMethodAspect
    {
        #region Public Methods

        public override void BuildAspect(IAspectBuilder<IMethod> builder) { base.BuildAspect(builder); }

        public override void BuildEligibility(IEligibilityBuilder<IMethod> builder) { base.BuildEligibility(builder); }
        public override dynamic? OverrideMethod() { throw new NotImplementedException(); }

        #endregion
    }
}
