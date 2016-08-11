using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ConsignmentStateByCarrierService", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ConsignmentStateByCarrierService
	{
        [DataMember]
        public string MpdCarrierName { get; set; }

        [DataMember]
        public string MpdCarrierServiceName { get; set; }

		/// <summary>MPD Reference for the Carrier (like MPD_DPD)</summary>
		[DataMember]
		public string MpdCarrierReference { get; set; }

		/// <summary>MPD Carrier Service Reference (like MPD_DPDEC)</summary>
		[DataMember]
		public string MpdCarrierServiceReference { get; set; }

		/// <summary>Number of consignments for this service and state</summary>
		[DataMember]
		public int NumberOfConsignments { get; set; }

		/// <summary>Consignment State that this response relates to</summary>
		[DataMember]
		public int ConsignmentState { get; set; }

        /// <summary>
        /// The date of creation of the consignments
        /// <remarks>Used for measuring volume of consignments created per week by carrier service allocation</remarks>
        /// </summary>
        [DataMember]
        public DateTimeOffset Created { get; set; }
	}
}
