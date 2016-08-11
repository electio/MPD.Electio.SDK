using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.LabelGeneration
{
	[DataContract]
	public enum PageSize
	{
		[EnumMember]
		A6 = 0,

		[EnumMember]
		A4 = 1,
	}
}
