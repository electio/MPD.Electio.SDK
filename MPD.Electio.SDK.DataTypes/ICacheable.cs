using System;
using System.Collections.Generic;

namespace MPD.Electio.SDK.DataTypes
{
    /// <summary>
    /// Defines an entity that can be cached using the MPD.Core.Infrastructure.Caching.Managers.
    /// </summary>
    public interface ICacheable<T> where T : class
    {
        /// <summary>
        /// The default cache duration in minutes for this entity.
        /// </summary>
        /// <returns>int representing minutes to cache for</returns>
        int DefaultCacheDurationInMinutes();

        /// <summary>
        /// Gets or sets the date the item was added to the cache
        /// </summary>
        /// <value>
        /// The cache date.
        /// </value>
        DateTimeOffset? CacheDate { get; set; }

        /// <summary>
        /// Gets or sets the cache source.
        /// </summary>
        /// <value>
        /// The cache source.
        /// </value>
        string CacheSource { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is cached.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is cached; otherwise, <c>false</c>.
        /// </value>
        bool IsCached { get; }
    }

    /// <summary>
    /// Defines an entity that can be cached using the MPD.Core.Infrastructure.Caching.Managers.
    /// </summary>
    public interface ICacheable : ICacheable<object>
    {
    }

    /// <summary>
    /// Defines an enumerable entity that can be cached using the MPD.Core.Infrastructure.Caching.Managers.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="MPD.Electio.SDK.DataTypes.ICacheable" />
    /// <seealso cref="System.Collections.Generic.IEnumerable{T}" />
    public interface ICacheableEnumerable<T> : ICacheable, IEnumerable<T>
    {
    }

}
