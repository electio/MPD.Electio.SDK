using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Subscription.Enums
{
    /// <summary>
    /// The status of a Customer's Electio subscription
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("SubscriptionStatus", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Subscription.Enums")]
    public enum SubscriptionStatus
	{
        /// <summary>
        /// None - Customer is not associated with an Electio subscription.
        /// </summary>
        [EnumMember]
        None = 0,
        /// <summary>
        /// Active - Customer has an active Electio subscription.
        /// </summary>
        [EnumMember]
        Active = 1,
        /// <summary>
        /// Suspended - Customer's subscription is currently suspended.
        /// </summary>
        [EnumMember]
        Suspended = 2
	}
}
