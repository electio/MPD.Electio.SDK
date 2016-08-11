using System.Collections.Generic;

namespace MPD.Electio.SDK.DataTypes
{
    /// <summary>
    /// A list that can be cached via MPD.Core.Infrastructure.Caching.Managers
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="System.Collections.Generic.IList{T}" />
    public interface ICacheableList<T> : IList<T>, ICacheable
    {
    }

    /// <summary>
    /// A list that can be cached via MPD.Core.Infrastructure.Caching.Managers
    /// </summary>
    /// <seealso cref="System.Collections.Generic.IList{T}" />
    public interface ICacheableList : ICacheableList<object>, ICacheableEnumerable<object>
    {
    }
}
