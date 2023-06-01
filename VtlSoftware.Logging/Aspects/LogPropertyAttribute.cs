// <copyright file="LogPropertyAttribute.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 30 May 2023 </date>
// <summary> Implements the log property attribute class </summary>

using Metalama.Extensions.DependencyInjection;
using Metalama.Framework.Aspects;
using Metalama.Framework.Code;

namespace VtlSoftware.Logging
{
    /// <summary>
    /// An attribute that applies logging to a Property.
    /// </summary>
    ///
    /// <remarks></remarks>
    ///
    /// <seealso cref="T:OverrideFieldOrPropertyAspect"/>

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
        /// <summary>
        /// Builds an aspect.
        /// </summary>
        ///
        /// <remarks></remarks>
        ///
        /// <param name="builder">The builder.</param>
        ///
        /// <seealso cref="M:Metalama.Framework.Aspects.OverrideFieldOrPropertyAspect.BuildAspect(IAspectBuilder{IFieldOrProperty})"/>

        public override void BuildAspect(IAspectBuilder<IFieldOrProperty> builder)
        {
            if(!(builder.Target.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any() ||
                builder.Target.DeclaringType.Attributes.OfAttributeType(typeof(NoLogAttribute)).Any()))
            {
                builder.Advice.Override(builder.Target, nameof(this.OverrideProperty));
            }
        }

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the override property.
        /// </summary>
        ///
        /// <value>The override property.</value>
        ///
        /// <seealso cref="P:Metalama.Framework.Aspects.OverrideFieldOrPropertyAspect.OverrideProperty"/>

        public override dynamic? OverrideProperty
        {
            get => meta.Proceed();
            set
            {
                var propertyName = $"{meta.Target.Type.ToDisplayString(CodeDisplayFormat.MinimallyQualified)}.{meta.Target.Property.Name}";
                meta.Proceed();
                logger.Log(
                    LogLevel.Information,
                    $"The value of {propertyName} was set to: {meta.Target.Property.Value}");
            }
        }

        #endregion
    }
}
