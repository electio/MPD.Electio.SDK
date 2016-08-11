using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.Exceptions
{
	[DataContract]
    public class RoleNotFoundForCustomerException : Exception
    {
        public RoleNotFoundForCustomerException(Guid identifier, Guid customerReference)
            : base(string.Format("Role ({0}) not found registed with customer ({1}) roles.", identifier.ToString(), customerReference.ToString()))
        {
        }
    }
}