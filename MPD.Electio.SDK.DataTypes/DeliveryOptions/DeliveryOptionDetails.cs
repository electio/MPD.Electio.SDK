using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A pre-existing delivery option or pickup option quote with associated consignment
    /// </summary>
    [DataContract]
    [XmlRoot("DeliveryOptionDetails", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class DeliveryOptionDetails
    {
        /// <summary>
        /// The reference for this delivery option
        /// </summary>
        [DataMember]
        public string Reference { get; set; }

        /// <summary>
        /// The consignment associated with this delivery option
        /// </summary>
        [DataMember]
        public PotentialConsignment ConsignmentDetail { get; set; }

        /// <summary>
        /// The selected delivery option
        /// </summary>
        [DataMember]
        public DeliveryOption DeliveryOption { get; set; }
    }
}