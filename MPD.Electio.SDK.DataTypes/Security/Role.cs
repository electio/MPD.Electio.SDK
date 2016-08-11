using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security
{
	[DataContract]
    [Serializable]
	public class Role
	{
		public Role()
		{
			Permissions = new List<Permission>();
		}

		[DataMember]
		public Guid CustomerReference { get; set; }

		[DataMember]
		public Guid Reference { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public string Type { get; set; }

		[DataMember]
		public List<Permission> Permissions { get; set; }
	}
}
