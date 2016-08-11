using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Caching;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("Configuration", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Configuration : BaseCacheableEntity, ICacheable
    {
        /// <summary>
        /// Defaults the cache duration in minutes.
        /// </summary>
        /// <returns></returns>
        public int DefaultCacheDurationInMinutes()
        {
            return 120;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Value { get; set; }

    }
}
