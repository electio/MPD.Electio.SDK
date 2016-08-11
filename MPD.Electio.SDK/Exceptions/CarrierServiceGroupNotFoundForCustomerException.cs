using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.Exceptions
{
    [DataContract]
    public class CarrierServiceGroupNotFoundForCustomerException : Exception
    {
        public CarrierServiceGroupNotFoundForCustomerException(Guid carrierServiceGroupReference,
            Guid customerReference)
            : base(
                string.Format(
                    "Specified carrier service group ({0}) is not among Customer ({1}) Carrier Service Groups",
                    carrierServiceGroupReference, customerReference))
        {
            
        }
    }
}