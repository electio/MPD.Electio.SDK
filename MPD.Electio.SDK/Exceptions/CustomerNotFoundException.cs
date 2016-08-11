using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.Exceptions
{
	[Serializable]
	public class CustomerNotFoundException : ObjectNotFoundException
	{
		public CustomerNotFoundException(string customerReference)
			: base("Customer", customerReference.ToString())
		{
		}

		protected CustomerNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}