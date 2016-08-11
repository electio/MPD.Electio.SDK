using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    [DataContract]
    [XmlRoot("MetaDataType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum MetaDataType
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        String = 1,
        [EnumMember]
        Int = 2,
        [EnumMember]
        Decimal = 3,
        [EnumMember]
        DateTime = 4,
        [EnumMember]
        Bool = 5
    }
}
