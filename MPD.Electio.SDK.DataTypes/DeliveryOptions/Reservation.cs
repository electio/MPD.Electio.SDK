using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// Pickup Option Reservation.
    /// </summary>
    [DataContract]
    [XmlRoot("Reservation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public sealed class Reservation
    {
        /// <summary>
        /// Gets or sets a value indicating whether this instance is reservation required.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is reservation required; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsReservationRequired { get; set; }
        /// <summary>
        /// Gets or sets time before which the reservation must be made.
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        [DataMember]
        public DateTimeOffset? ExpiryDate { get; set; }
    }
}
