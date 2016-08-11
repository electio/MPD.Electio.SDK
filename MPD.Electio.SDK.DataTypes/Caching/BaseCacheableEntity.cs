using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Caching
{
    /// <summary>
    /// Base entity providing support for caching via one of the MPD.Core.Infrastructure.Caching.Managers 
    /// cache managers.
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("BaseCacheableEntity", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Caching")]
    public abstract class BaseCacheableEntity
    {
        /// <summary>
        /// Date that the item was added into the cache
        /// </summary>
        /// <value>
        /// The cache date.
        /// </value>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [XmlIgnore]
        public DateTimeOffset? CacheDate { get; set; }

        /// <summary>
        /// Source of the cache object, typically hostname or IP address of the 
        /// machine that was responsible for adding the item to the cache.
        /// </summary>
        /// <value>
        /// The cache source.
        /// </value>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [XmlIgnore]
        public string CacheSource { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance is cached.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is cached; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [XmlIgnore]
        public bool IsCached => CacheDate != null;
    }
}
