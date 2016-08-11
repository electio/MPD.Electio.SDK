using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A collection of delivery options
    /// </summary>
    [DataContract]
    [XmlRoot("DeliveryOptionsResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class DeliveryOptionsResponse
    {
        /// <summary>
        /// A list of <see cref="DeliveryOption"/> that are available
        /// </summary>
        [DataMember]
        public List<DeliveryOption> DeliveryOptions { get; set; }

        /// <summary>
        /// The earliest available non-guaranteed delivery option based on shipment ASAP
        /// </summary>
        [DataMember]
        public DeliveryOption NonGuaranteedDeliveryOption { get; set; }
    }
}