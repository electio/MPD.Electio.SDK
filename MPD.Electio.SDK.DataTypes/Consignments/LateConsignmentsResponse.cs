using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("LateConsignmentsResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class LateConsignmentsResponse
	{
		[DataMember]
		public int TotalNumberOfLateConsignments { get; set; }

		[DataMember]
		public List<ConsignmentSummary> ConsignmentSummaries { get; set; }
	}
}
