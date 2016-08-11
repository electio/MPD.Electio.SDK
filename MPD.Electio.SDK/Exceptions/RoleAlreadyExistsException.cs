using System;

namespace MPD.Electio.SDK.Exceptions
{
	public class RoleAlreadyExistsException : Exception
	{
		public RoleAlreadyExistsException(string roleName)
			: base (string.Format("Role {0} already exists.", roleName))
		{
			RoleName = roleName;
		}

		public string RoleName { get; private set; }
	}
}
