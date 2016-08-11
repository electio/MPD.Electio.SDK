using System.Collections.Generic;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Subscription
{
    [DataContract]
    public class SubscriptionMpdCarrierServiceResponse : SubscriptionResponse
    {
        [DataMember]
        public List<MpdCarrierService> MpdCarrierServices { get; set; }
    }
}
