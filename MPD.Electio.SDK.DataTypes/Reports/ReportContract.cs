using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using MPD.Electio.SDK.DataTypes.Reports.Enums;

namespace MPD.Electio.SDK.DataTypes.Reports
{
	public class ReportContract
	{
        [DataMember]
        public Guid AccountReference { get; set; }
        [DataMember]
        public string ContainerName { get; set; }
        [DataMember]
        public Guid CustomerReference { get; set; }
        [DataMember]
        public DateTime? DateCreated { get; set; }
        [DataMember]
        public DateTime? DateDownloaded { get; set; }
        [DataMember]
        public DateTime? DateRequested { get; set; }
        [DataMember]
        public string FileFormat { get; set; }
        [DataMember]
        public Guid Reference { get; set; }
        [DataMember]
        public ReportStatus Status { get; set; }
        [DataMember]
        public ReportType ReportType { get; set; }
        [DataMember]
        public ReportLevel ReportLevel { get; set; }
        [DataMember]
        public int TimeZoneOffsetInMinutes { get; set; }
    }
}
