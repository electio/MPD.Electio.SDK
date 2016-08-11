using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// A stage in the transit journey with a specific Carrier service.
    /// </summary>
    [DataContract]
    [XmlRoot("ConsignmentLeg", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class ConsignmentLeg
	{
        /// <summary>
        /// Gets or sets the leg number within the Journey
        /// </summary>
        /// <value>
        /// The leg.
        /// </value>
        [DataMember]
		public int Leg { get; set; }
        /// <summary>
        /// Gets or sets the Carrier's tracking reference.
        /// </summary>
        /// <value>
        /// The tracking reference.
        /// </value>
        [DataMember]
		public string TrackingReference { get; set; }
        /// <summary>
        /// Gets or sets the carrier reference.
        /// </summary>
        /// <value>
        /// The carrier reference.
        /// </value>
        [DataMember]
        public string CarrierReference { get; set; }
        /// <summary>
        /// Gets or sets the name of the carrier.
        /// </summary>
        /// <value>
        /// The name of the carrier.
        /// </value>
        [DataMember]
        public string CarrierName { get; set; }
	}
}
