using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ConsignmentStateSummaryResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ConsignmentStateSummaryResponse
	{
		[DataMember]
		public int NumberOfConsignments { get; set; }

		/// <summary>
		/// Key is the ConsignmentState as a string, value is the number of consignments 
		/// for that state in the time period
		/// </summary>
		[DataMember]
		public List<Common.KeyValuePair<string, int>> Summary { get; set; }

		[DataMember]
		public DateTimeOffset StartFrom { get; set; }

		[DataMember]
		public DateTimeOffset EndAt { get; set; }
	}
}
