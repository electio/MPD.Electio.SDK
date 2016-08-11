using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Reports
{
	public class DownloadReportResponse
	{
        [DataMember]
        public string FileFormat { get; set; }

        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public string Report { get; set; }
	}
}
