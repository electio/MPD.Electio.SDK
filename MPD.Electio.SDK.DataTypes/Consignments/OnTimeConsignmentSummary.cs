using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>Models a single summary line for on-time packages</summary>
    [DataContract]
    [XmlRoot("OnTimeConsignmentSummary", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class OnTimeConsignmentSummary
	{
        [DataMember]
        public string CarrierName { get; set; }

		/// <summary>Reference of the carrier (like 'UPS')</summary>
		[DataMember]
		public string CarrierReference { get; set; }

		///<summary>Number of packages that are on time for this carrier</summary>
		[DataMember]
		public int NumberOfConsignments { get; set; }
	}
}
