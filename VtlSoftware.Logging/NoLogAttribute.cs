
///--------
///
// file:	VtlSoftware.Logging\NoLogAttribute.cs
//
// summary:	Implements the no log attribute class
namespace VtlSoftware.Logging
{
    ///---- NoLogAttribute   (Class) ----
    ///
    /// <summary>
    /// An attribute to prevent logging. This class cannot be inherited.
    /// </summary>
    ///
    /// <remarks>
    /// When applied to a Class, Method or Property that entity will not be logged.
    /// </remarks>
    ///
    /// <seealso cref="T:Attribute"/>
    ///-------------------------------------------------------------------------------------------------

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public sealed class NoLogAttribute : Attribute
    {
    }
}
