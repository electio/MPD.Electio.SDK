using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.LabelGeneration
{
	[DataContract]
	public abstract class LabelsRequest
	{
		[DataMember]
		public string MpdConsignmentReference { get; set; }

		[DataMember]
		public PageSize PageSize { get; set; }

		[DataMember]
		public string CustomerReference { get; set; }

		[DataMember]
		public string AccountReference { get; set; }
	}
}
