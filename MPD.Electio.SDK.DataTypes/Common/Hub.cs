using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents a hub - a depot used by a carrier during transit of a consignment
    /// </summary>
    [DataContract]
    [XmlRoot("Hub", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Hub
	{
        /// <summary>
        /// Gets or sets the hub address.
        /// </summary>
        /// <value>
        /// The hub address.
        /// </value>
        [DataMember]
		public Address HubAddress { get; set; }

        /// <summary>
        /// Gets or sets the extra days to transit time.
        /// </summary>
        /// <value>
        /// The extra days to transit time.
        /// </value>
        [DataMember]
		public int ExtraDaysToTransitTime { get; set; }
	}
}
