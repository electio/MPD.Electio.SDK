using System;

namespace MPD.Electio.SDK.Exceptions
{
	public class RoleNotFoundException : ObjectNotFoundException
	{
		public RoleNotFoundException(Guid roleReference)
			: base("Role", roleReference.ToString())
		{
			RoleReference = roleReference;
		}

		public Guid RoleReference { get; private set; }
	}
}