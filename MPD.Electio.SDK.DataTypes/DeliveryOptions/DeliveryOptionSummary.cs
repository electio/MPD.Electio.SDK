using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// Provides details of dates upon which services are available
    /// </summary>
    [DataContract]
    [XmlRoot("DeliveryOptionSummary", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class DeliveryOptionSummary
    {
        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        public string Reference { get; set; }
        /// <summary>
        /// Dates where a delivery option is available
        /// </summary>
        [DataMember]
        public List<DateTime> DeliveryOptions { get; set; }

        /// <summary>
        /// Dates where delivery options with timeslots are available
        /// </summary>
        [DataMember]
        public List<DateTime> TimeSlots { get; set; }

        /// <summary>
        /// Date where pickup services are available
        /// </summary>
        [DataMember]
        public List<DateTime> PickUp { get; set; }

        /// <summary>
        /// Dates where drop off services are available
        /// </summary>
        [DataMember]
        public List<DateTime> DropOff { get; set; }   
    }
}