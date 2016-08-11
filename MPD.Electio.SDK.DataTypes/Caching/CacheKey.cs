using System;

namespace MPD.Electio.SDK.DataTypes.Caching
{
    /// <summary>
    /// Denotes that this property forms the key for caching the entity.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public class CacheKey : Attribute
    {
    }
}
