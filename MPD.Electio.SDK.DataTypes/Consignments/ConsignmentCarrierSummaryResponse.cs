using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ConsignmentCarrierSummaryResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ConsignmentCarrierSummaryResponse
	{
		[DataMember]
		public List<ConsignmentStateByCarrierService> Summary { get; set; }
	}
}
