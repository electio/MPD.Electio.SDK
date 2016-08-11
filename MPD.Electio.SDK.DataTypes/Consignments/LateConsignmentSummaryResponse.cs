using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("LateConsignmentSummaryResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class LateConsignmentSummaryResponse
	{
		[DataMember]
		public List<LateConsignmentSummary> LateConsignments { get; set; }

		[DataMember]
		public List<OnTimeConsignmentSummary> OnTimeConsignments { get; set; }

        [DataMember]
        public List<LateConsignmentSummary> LateConsignmentsFromCustomerPerspective { get; set; }
    }
}
