using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.LabelGeneration
{
	[DataContract]
	public class GetLabelsRequest : LabelsRequest
	{
		[DataMember]
		public bool AutoPrint { get; set; }
	}
}
