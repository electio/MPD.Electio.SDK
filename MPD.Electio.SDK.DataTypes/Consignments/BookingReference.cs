using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("BookingReference", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class BookingReference
    {
        [DataMember]
        public string ReferenceName { get; set; }
        [DataMember]
        public string ReferenceValue { get; set; }
    }
}
