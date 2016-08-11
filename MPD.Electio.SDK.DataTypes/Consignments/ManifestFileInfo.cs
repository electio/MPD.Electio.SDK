using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ManifestFileInfo", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ManifestFileInfo
    {
        [DataMember]
        public string ManifestReference { get; set; }
        [DataMember]
        public string ManifestFileStorageContainer { get; set; }
        [DataMember]
        public string ManifestFileName { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public string CarrierName { get; set; }
        [DataMember]
        public int BookingsCount { get; set; }
    }
}