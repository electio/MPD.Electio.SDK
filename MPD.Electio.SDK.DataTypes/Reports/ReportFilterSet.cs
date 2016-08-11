using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Reports
{
	[DataContract]
	public class ReportFilterSet
	{
		public ReportFilterSet()
		{
			Filters = new ReportFilters();
		}

		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public string Title { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public Guid CustomerReference { get; set; }

		[DataMember]
		public ReportFilters Filters { get; set; }
	}
}
