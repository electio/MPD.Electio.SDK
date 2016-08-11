using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security.Enums
{
    /// <summary>
    /// Defines states for an MPD Carrier Service within the Customer's subscription.
    /// </summary>
    public enum CustomerSubscriptionStatus
    {
        /// <summary>
        /// Available to the Customer within their current subscription but not presently enabled.
        /// </summary>
        [EnumMember]
        Available = 0,
        /// <summary>
        /// Requested by the Customer for inclusion within their subscription but not presently available.
        /// </summary>
        [EnumMember]
        Requested = 1,
        /// <summary>
        /// Disabled
        /// </summary>
        [EnumMember]
        Disabled = 2,
        /// <summary>
        /// Enabled an in use within the Customer's current subscription.
        /// </summary>
        [EnumMember]
        Enabled = 3,
    }
}
