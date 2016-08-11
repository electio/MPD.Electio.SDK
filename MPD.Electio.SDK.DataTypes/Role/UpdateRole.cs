using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Security;

namespace MPD.Electio.SDK.DataTypes.Role
{
	[DataContract]
	public class UpdateRole
	{
		public UpdateRole()
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
		public List<Permission> Permissions { get; set; }
	}
}
