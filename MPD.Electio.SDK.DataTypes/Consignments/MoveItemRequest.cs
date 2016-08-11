using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("MoveItemRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class MoveItemRequest
    {
        public MoveItemRequest() { }

        public MoveItemRequest(string itemReference, string targetpackageReference)
        {
            ItemReference = itemReference;
            TargetPackageReference = targetpackageReference;
        }

        [DataMember]
        public string ItemReference { get; set; }

        [DataMember]
        public string TargetPackageReference { get; set; }
    }
}
