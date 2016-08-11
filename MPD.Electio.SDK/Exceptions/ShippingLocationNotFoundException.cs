using System;

namespace MPD.Electio.SDK.Exceptions
{
	public class ShippingLocationNotFoundException : Exception
	{
		public ShippingLocationNotFoundException(string customerReference, string shippingLocationReference)
			: base(string.Format("Shipping location ({1}) not found or no longer exists for customer ({0}).", customerReference, shippingLocationReference))
		{
		}
	}
}
