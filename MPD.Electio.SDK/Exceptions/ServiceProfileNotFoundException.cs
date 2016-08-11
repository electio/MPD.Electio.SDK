using System;

namespace MPD.Electio.SDK.Exceptions
{
	public class ServiceProfileNotFoundException : Exception
	{
		public ServiceProfileNotFoundException(string mpdCarrierServiceReference, string customerReference)
			: base (string.Format("MPD Carrier Service ({0}) not found for customer ({1}).", mpdCarrierServiceReference, customerReference))
		{
		}
	}
}
