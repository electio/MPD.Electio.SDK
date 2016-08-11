using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A request to retrieve Pickup Options for shipment of a consignment.
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.DataTypes.DeliveryOptions.DeliveryOptionsRequest" />
    [DataContract]
    [XmlRoot("PickupOptionsRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class PickupOptionsRequest : DeliveryOptionsRequest
    {
        /// <summary>
        /// Gets or sets the distance in Kilometres from the recipient's location.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        [DataMember]
        public decimal? Distance { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of results to return.
        /// </summary>
        /// <value>
        /// The maximum results.
        /// </value>
        [DataMember]
        public int? MaxResults { get; set; }
    }
}
