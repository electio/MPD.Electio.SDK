using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>Models a single summary line for late packages</summary>
    [DataContract]
    [XmlRoot("LateConsignmentSummary", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class LateConsignmentSummary
	{
        [DataMember]
        public string CarrierName { get; set; }

		/// <summary>Reference of the carrier (like 'UPS')</summary>
		[DataMember]
		public string CarrierReference { get; set; }

		///<summary>Number of days that these packages are late</summary>
		[DataMember]
		public int DaysLate { get; set; }

		///<summary>Number of packages that are late for this carrier for this number of days</summary>
		[DataMember]
		public int NumberOfConsignments { get; set; }

        [DataMember]
        public ApiLink ApiLink { get; set; }
    }
}
