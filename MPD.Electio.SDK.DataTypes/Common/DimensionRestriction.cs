using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("DimensionRestriction", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class DimensionRestriction
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public DimensionType DimensionType { get; set; }

		[DataMember]
		public decimal RangeFrom { get; set; }

		[DataMember]
		public decimal RangeTo { get; set; }
	}
}
