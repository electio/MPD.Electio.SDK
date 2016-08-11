using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.DataTypes.Reports.Enums;

namespace MPD.Electio.SDK.DataTypes.Reports
{
	[DataContract]
	public class ReportFilters
	{
		[DataMember]
		public List<string> Carriers { get; set; }

		[DataMember]
		public List<string> CarrierServices { get; set; }

		[DataMember]
		public bool? CarrierWasLate { get; set; }

		[DataMember]
		public DateTime? DateCreatedFrom { get; set; }

		[DataMember]
		public DateTime? DateCreatedTo { get; set; }

		[DataMember]
		public DateTime? DateDeliveredFrom { get; set; }

		[DataMember]
		public DateTime? DateDeliveredTo { get; set; }

        [DataMember]
        public DateTime? EstimatedDeliveryDateFrom { get; set; }

        [DataMember]
        public DateTime? EstimatedDeliveryDateTo { get; set; }

        [DataMember]
		public DateTime? DateShippedFrom { get; set; }

		[DataMember]
		public DateTime? DateShippedTo { get; set; }

		[DataMember]
		public decimal? DepthFrom { get; set; }

		[DataMember]
		public decimal? DepthTo { get; set; }

		[DataMember]
		public decimal? LengthFrom { get; set; }

		[DataMember]
		public decimal? LengthTo { get; set; }

		[DataMember]
		public List<string> ShippedFroms { get; set; }

		[DataMember]
		public List<string> Statuses { get; set; }

		[DataMember]
		public decimal? WeightFrom { get; set; }

		[DataMember]
		public decimal? WeightTo { get; set; }

		[DataMember]
		public bool? WeWereLate { get; set; }

		[DataMember]
		public decimal? ValueFrom { get; set; }

		[DataMember]
		public decimal? ValueTo { get; set; }

		[DataMember]
		public decimal? WidthFrom { get; set; }

		[DataMember]
		public decimal? WidthTo { get; set; }

		[DataMember]
		public List<MetaDataFilter> MetaDataFilters { get; set; }
        
    }
}
