using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("InternationalLocationRestriction", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class InternationalLocationRestriction
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string Postcode { get; set; }

		[DataMember]
		public string Town { get; set; }

		[DataMember]
		public string County { get; set; }

		[DataMember]
		public string CountryTwoLetterIsoCode { get; set; }
	}
}
