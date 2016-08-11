using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("DomesticLocationRestriction", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class DomesticLocationRestriction
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string PostcodeArea { get; set; }

		[DataMember]
		public string PostcodeDistrict { get; set; }

		[DataMember]
		public string PostcodeSector { get; set; }

		[DataMember]
		public string PostcodeUnit { get; set; }
	}
}
