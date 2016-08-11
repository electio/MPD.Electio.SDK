using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Caching;

namespace MPD.Electio.SDK.DataTypes.CarrierServiceDirectory
{
    /// <summary>
    /// Represents an underlying carrier.
    /// </summary>
    [DataContract]
    [XmlRoot("Carrier", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.CarrierServiceDirectory")]
    public class Carrier : BaseCacheableEntity, ICacheable
	{
        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Defaults the cache duration in minutes.
        /// </summary>
        /// <returns></returns>
        public int DefaultCacheDurationInMinutes()
        {
            return 120;
        }
	}
}
