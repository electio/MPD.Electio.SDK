using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("PagedList", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class PagedList<T>
	{
		[DataMember]
		public int TotalRecords { get; set; }

		[DataMember]
		public int PageSize { get; set; }

		[DataMember]
		public int PageNumber { get; set; }

		[DataMember]
		public List<T> Records { get; set; }
	}
}
