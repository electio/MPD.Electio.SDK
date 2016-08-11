using System;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Security
{
	[DataContract]
    [Serializable]
	public class Permission
	{
		[DataMember]
		public string Key { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public AccessActions Action { get; set; }

		[DataMember]
		public Access Access { get; set; }

		[DataMember]
		public string Type { get; set; }
	}
}
