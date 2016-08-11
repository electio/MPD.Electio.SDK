using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.LabelGeneration
{
	[DataContract]
	public class GetLabelsResponse
	{
		[DataMember]
		public byte[] File { get; set; }

		[DataMember]
		public string ContentType { get; set; }
	}
}
