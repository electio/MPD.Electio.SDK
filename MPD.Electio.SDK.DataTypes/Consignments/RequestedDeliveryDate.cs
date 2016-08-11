using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.DeliveryOptions;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Date for delivery
    /// </summary>
    [DataContract]
    [XmlRoot("RequestedDeliveryDate", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class RequestedDeliveryDate
	{
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        [DataMember]
		public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the delivery window.
        /// </summary>
        /// <value>
        /// The delivery window.
        /// </value>
        [DataMember]
        public DeliveryWindow DeliveryWindow { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is to be exactly on the date specified.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is to be exactly on the date specified; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
		public bool IsToBeExactlyOnTheDateSpecified { get; set; }
	}
}
