using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security
{
	[DataContract]
    [Serializable]
	public class BasicRole
	{
		[DataMember]
		public Guid CustomerReference { get; set; }

		[DataMember]
		public Guid Reference { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string Type { get; set; }

		[DataMember]
		public string Description { get; set; }
	}
}
