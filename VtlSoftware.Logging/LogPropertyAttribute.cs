// file:	VtlSoftware.Logging\LogPropertyAttribute.cs
//
// summary:	Implements the log property attribute class

using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace VtlSoftware.Logging
{
    ///---- LogPropertyAttribute   (Class) ----
    ///
    /// <summary>
    /// An attribute for logging properties.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:OverrideFieldOrPropertyAspect"/>
    ///-------------------------------------------------------------------------------------------------

#pragma warning disable CS8618
    public class LogPropertyAttribute : OverrideFieldOrPropertyAspect
    {
        #region Fields

        /// <summary>
        /// (Immutable) The logger.
        /// </summary>
        [IntroduceDependency]
        private readonly ILogger logger;

        #endregion

        #region Public Methods
        ///---- BuildAspect   (Method) ----
        ///
        /// <summary>
        /// Builds an aspect.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="builder">The builder.</param>
        ///
        /// <seealso cref="M:Metalama.Framework.Aspects.OverrideFieldOrPropertyAspect.BuildAspect(IAspectBuilder{IFieldOrProperty})"/>
        ///-------------------------------------------------------------------------------------------------

        public override void BuildAspect(IAspectBuilder<IFieldOrProperty> builder)
        {
            if(!(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any()))
            {
                builder.Advice.Override(builder.Target, nameof(this.OverrideProperty));
            }
        }

        #endregion

        #region Public Properties
        ///---- OverrideProperty   (Property) ----
        ///
        /// <summary>
        /// Gets or sets the override property.
        /// </summary>
        ///
        /// <value>The override property.</value>
        ///
        /// <seealso cref="P:Metalama.Framework.Aspects.OverrideFieldOrPropertyAspect.OverrideProperty"/>
        ///-------------------------------------------------------------------------------------------------

        public override dynamic? OverrideProperty
        {
            get => meta.Proceed();
            set
            {
                var propertyName = $"{meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Property.Name}";
                meta.Proceed();
                logger.LogInformation($"The value of {propertyName} was set to: {meta.Target.Property.Value}");
            }
        }

        #endregion
    }
}
