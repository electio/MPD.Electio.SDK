using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    [DataContract]
    [XmlRoot("TitleType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum TitleType
    {
        [EnumMember]
        Mrs = 0,
        [EnumMember]
        Mr = 1,
        [EnumMember]
        Ms = 2,
        [EnumMember]
        Miss = 3,
        [EnumMember]
        Dr = 4,
        [EnumMember]
        Sir = 5
    }
}