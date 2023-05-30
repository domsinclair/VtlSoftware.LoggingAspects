// <copyright file="NoLogAttribute.cs" company="View To Learn / Vtl Software Ltd">
// Copyright (c) 2023 View To Learn / Vtl Software Ltd. All rights reserved.
// </copyright>
// <author> Dom Sinclair </author>
// <date> 30 May 2023 </date>
// <summary> Implements the no log attribute class </summary>

namespace VtlSoftware.Logging
{
    /// <summary>
    /// Attribute for no log. This class cannot be inherited.
    /// </summary>
    ///
    /// <remarks>
    /// When applied to a Class, Method or Property that entity will not be logged.
    /// </remarks>
    ///
    /// <seealso cref="T:Attribute"/>

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public sealed class NoLogAttribute : Attribute
    {
    }
}
