using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A request to retrieve Delivery Options for shipment of a consignment.
    /// </summary>
    [DataContract]
    [XmlRoot("DeliveryOptionsRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class DeliveryOptionsRequest : BaseCreateConsignmentRequest
    {
        /// <summary>
        /// Gets or sets the delivery date.
        /// </summary>
        /// <value>
        /// The delivery date.
        /// </value>
        [DataMember]
        public DateTime? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to only include services that guarantee
        /// delivery on the requested date.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [guaranteed only]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool GuaranteedOnly { get; set; }

        
    }
}
