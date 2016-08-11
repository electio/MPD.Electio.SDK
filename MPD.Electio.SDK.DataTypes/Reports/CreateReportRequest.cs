using System;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Reports.Enums;

namespace MPD.Electio.SDK.DataTypes.Reports
{
	public class CreateReportRequest
	{
        [DataMember]
        public Guid Reference { get; set; }

		[DataMember]
        public Guid AccountReference { get; set; }

		[DataMember]
        public Guid CustomerReference { get; set; }

		///<summary>The set of filters that will be used to generate this report</summary>
		[DataMember]
		public ReportFilters Filters { get; set; }

        [DataMember]
        public ReportType ReportType { get; set; }

        [DataMember]
        public ReportLevel ReportLevel { get; set; }

        [DataMember]
        public string TimeZoneIdentifier { get; set; }
    }
}
