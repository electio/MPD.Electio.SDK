using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A pick up location option. This is effectively a quote for a specific location
    /// </summary>
    [DataContract]
    [XmlRoot("Location", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class Location
    {
        private decimal _distance;

        [DataMember]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the optional shop reference.
        /// </summary>
        /// <value>
        /// The shop reference.
        /// </value>
        [DataMember]
        public string ShopReference { get; set; }
        /// <summary>
        /// The address of the pick up location
        /// </summary>
        [DataMember]
        public Address Address { get; set; }

        /// <summary>
        /// The distance from the destination address in kilometres
        /// </summary>
        [DataMember]
        public decimal Distance
        {
            get { return Math.Round(_distance, 2, MidpointRounding.AwayFromZero) ;}
            set { _distance = value; }
        }

        /// <summary>
        /// The opening times of the location
        /// </summary>
        [DataMember]
        public OpeningTimes OpeningTimes { get; set; }

        /// <summary>
        /// The delivery/service options for this location
        /// </summary>
        [JsonProperty("DeliveryOptions", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember]
        public List<DeliveryOption> DeliveryOptions { get; set; }

        /// <summary>
        /// Gets or sets the reservation.
        /// </summary>
        /// <value>
        /// The reservation.
        /// </value>
        [DataMember]
        public Reservation Reservation { get; set; }

        /// <summary>
        /// Additional information relating to the pickup location
        /// </summary>
        [DataMember]
        public List<AdditionalInformation> AdditionalInformation { get; set; } 
    }
}