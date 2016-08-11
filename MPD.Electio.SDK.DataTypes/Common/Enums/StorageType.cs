using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    [DataContract]
    [XmlRoot("StorageType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum StorageType
    {
        [EnumMember]
        Azure = 0,
        [EnumMember]
        Disk = 1
    }
}
