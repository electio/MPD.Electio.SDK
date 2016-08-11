using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.ServiceAvailability
{
    /// <summary>
    /// Represents a collection window for an MPD Carrier Service
    /// </summary>
    [DataContract]
    public class CollectionWindow
    {
        /// <summary>
        /// Gets or sets the earliest time in the day that the carrier will collect.
        /// </summary>
        /// <value>
        /// The earliest collection time.
        /// </value>
        [DataMember]
        public TimeSpan EarliestCollectionTime { get; set; }

        /// <summary>
        /// Gets or sets the latest time in the day that the carrier will collect.
        /// </summary>
        /// <value>
        /// The latest collection time.
        /// </value>
        [DataMember]
        public TimeSpan LatestCollectionTime { get; set; }

        /// <summary>
        /// Gets or sets the latest date/time by which the booking must be made with the 
        /// carrier in order to be eligable for this collection window.
        /// </summary>
        /// <value>
        /// The booking cut off time.
        /// </value>
        [DataMember]
        public DateTimeOffset? BookingCutOffTime { get; set; }

		[DataMember]
		public DateTimeOffset? ManifestDateTime { get; set; }

		[DataMember]
		public DateTimeOffset? PreAdviceDateTime { get; set; }

        [DataMember]
        public TimeSpan EarliestDeliveryTime { get; set; }

        [DataMember]
        public TimeSpan LatestDeliveryTime { get; set; }

        /// <summary>
        /// Gets or sets the operational cut off time at the shipping location.
        /// </summary>
        /// <value>
        /// The operational cut off time.
        /// </value>
        [DataMember]
        public DateTimeOffset? OperationalCutOffTime { get; set; }

    }
}