using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.Exceptions
{
	[Serializable]
	public class MpdCarrierServiceNotFoundException : ObjectNotFoundException
	{
		public MpdCarrierServiceNotFoundException(string reference)
			: base("MpdCarrierService", reference.ToString()) { }

		protected MpdCarrierServiceNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}