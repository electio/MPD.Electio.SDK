using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("CompensationAndValue", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class CompensationAndValue
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public decimal? MaxParcelValue { get; set; }

		[DataMember]
		public bool GetEnhancedCompensation { get; set; }

		[DataMember]
		public decimal? CompensationThreshold { get; set; }

	}
}
