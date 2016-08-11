using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Holds information relating to selected pick up location for a consignment
    /// <remarks>
    /// This property will only be applicable when a PickUpLocation has been selected
    /// </remarks>
    /// </summary>
    [DataContract]
    [XmlRoot("LocationInformation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class LocationInformation
    {
        /// <summary>
        /// The identifier or reference of the selected shop
        /// </summary>
        [DataMember]
        public string ShopReference { get; set; }

        /// <summary>
        /// The reference of the reservation with the shop
        /// <remarks>
        /// This property is only applicable for certain carrier services
        /// </remarks>
        /// </summary>
        [DataMember]
        public string ReservationReference { get; set; }
    }
}