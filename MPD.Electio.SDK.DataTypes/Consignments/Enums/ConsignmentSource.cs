using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    /// <summary>
    /// Source of the request - Api or Electio website.
    /// </summary>
    [DataContract]
    [XmlRoot("Source", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum Source
    {
        [EnumMember]
        Api = 0,
        [EnumMember]
        Web = 1
    }
}
