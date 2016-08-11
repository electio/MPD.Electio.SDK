using System;

namespace MPD.Electio.SDK.Exceptions
{
	public class PackageSizeNotFoundForCustomerException : Exception
	{
		public PackageSizeNotFoundForCustomerException(Guid customerReference, string packageSizeReference)
			: base(string.Format("Package size {0} not found or no longer exists for customer {1}", packageSizeReference, customerReference))
		{
		}

        public PackageSizeNotFoundForCustomerException(string message) : base(message) { }
	}
}
