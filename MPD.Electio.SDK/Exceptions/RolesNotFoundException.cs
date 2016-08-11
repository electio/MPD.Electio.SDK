using System;
using System.Collections.Generic;

namespace MPD.Electio.SDK.Exceptions
{
	public class RolesNotFoundException : ObjectNotFoundException
	{
		public RolesNotFoundException(IEnumerable<Guid> roleReferences)
			: base("Roles", string.Join(", ", roleReferences))
		{
		}
	}
}
