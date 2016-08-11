using System;

namespace MPD.Electio.SDK.Exceptions
{
	public class ServiceGroupNotFoundException : Exception
	{
		public ServiceGroupNotFoundException(string customerReference, string mpdCarrierServiceGroupReference)
			: base(string.Format("Service group ({0}) not found for customer ({1})", customerReference, mpdCarrierServiceGroupReference))
		{			
		}
	}
}
