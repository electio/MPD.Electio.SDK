using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    /// <summary>
    /// Represents the possible type of the Phone Numbers
    /// </summary>
    [DataContract]
    [XmlRoot("PhoneNumberType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum PhoneNumberType
    {
        [EnumMember]
        Mobile = 0,
        [EnumMember]
        LandLine = 1
    }
}