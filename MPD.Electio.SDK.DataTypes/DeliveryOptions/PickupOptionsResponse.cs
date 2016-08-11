using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A collection of Pickup Locations
    /// </summary>
    [DataContract]
    [XmlRoot("PickupOptionsResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class PickupOptionsResponse
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

        /// <summary>
        /// Gets or sets the pickup locations.
        /// </summary>
        /// <value>
        /// The pickup locations.
        /// </value>
        [DataMember]
        public List<Location> Locations { get; set; }

        /// <summary>
        /// The earliest available non-guaranteed pickup location
        /// </summary>
        [DataMember]
        public Location NonGuaranteedLocation { get; set; }
    }
}
