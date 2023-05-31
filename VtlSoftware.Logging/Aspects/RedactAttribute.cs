// <copyright file="RedactAttribute.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 30 May 2023 </date>
// <summary> Implements the redact attribute class </summary>

namespace VtlSoftware.Logging
{
    /// <summary>
    /// An attribute for redacting parameter or return values. This class cannot be inherited.
    /// </summary>
    ///
    /// <remarks>
    /// If applied in front of Parameters or the retun value of a method the actual value will be logged as "Redacted".
    /// </remarks>
    ///
    /// <seealso cref="T:Attribute"/>

    [AttributeUsage(AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
    public sealed class RedactAttribute : Attribute
    {
    }
}
