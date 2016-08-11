using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ConsignmentStatusResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ConsignmentStatusResponse
	{
		[DataMember]
		public string ConsignmentReferenceForAllLegsAssignedByMpd { get; set; }

		[DataMember]
		public string Status { get; set; }

		[DataMember]
		public string ExpectedDeliveryDate { get; set; }

        [DataMember]
        public ApiLink ApiLink { get; set; }
	}
}
