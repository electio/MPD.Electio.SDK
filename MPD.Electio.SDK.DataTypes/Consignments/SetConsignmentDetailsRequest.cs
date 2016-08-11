using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents a request used in updating an existing consignment
    /// </summary>
    [DataContract]
    [XmlRoot("SetConsignmentDetailsRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class SetConsignmentDetailsRequest
	{
        /// <summary>
        /// Customer-provided reference associated with the consignment
        /// </summary>
		[DataMember]
		public string ConsignmentReferenceProvidedByCustomer { get; set; }

		/// <summary>
		/// Requested delivery date
		/// </summary>
		[DataMember]
		public DateTime? RequestedDeliveryDate { get; set; }

        /// <summary>
        /// Shipping date
        /// </summary>
        [DataMember]
        public DateTime? ShippingDateTime { get; set; }

        /// <summary>
        /// To be delivered exactly on the date <see cref="RequestedDeliveryDate"/> specified.
        /// </summary>
        [DataMember]
        public bool? IsExactRequestedDeliveryDate { get; set; }
	}
}
