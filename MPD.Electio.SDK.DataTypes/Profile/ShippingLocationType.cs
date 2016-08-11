using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Profile
{
    [DataContract]
    [XmlRoot("Reservation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Profile")]
    public enum ShippingLocationType : short
    {
        [EnumMember]
        DistributionCentre = 1,

        [EnumMember]
        Office = 2,

        [EnumMember]
        Store = 3,

        [EnumMember]
        Warehouse = 4
    }
}