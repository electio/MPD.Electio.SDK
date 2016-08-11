using System;

namespace MPD.Electio.SDK.Exceptions
{
	public class ShippingLocationReferenceInUseException : Exception
	{
		public ShippingLocationReferenceInUseException(string shippingLocationReference)
			: base(string.Format("Shipping location reference ({0}) is already in use", shippingLocationReference))
		{
		}
	}
}
