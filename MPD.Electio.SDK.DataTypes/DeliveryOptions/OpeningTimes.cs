using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A collection of opening times specified per day
    /// </summary>
    [DataContract]
    [XmlRoot("OpeningTimes", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class OpeningTimes
    {
        /// <summary>
        /// Opening times for Monday
        /// </summary>
        [DataMember]
        [JsonProperty(Order = 1)]
        public List<OpeningTime> Monday { get; set; }

        /// <summary>
        /// Opening times for Tuesday
        /// </summary>
        [DataMember]
        [JsonProperty(Order = 2)]
        public List<OpeningTime> Tuesday { get; set; }

        /// <summary>
        /// Opening times for Wednesday
        /// </summary>
        [DataMember]
        [JsonProperty(Order = 3)]
        public List<OpeningTime> Wednesday { get; set; }

        /// <summary>
        /// Opening times for Thursday
        /// </summary>
        [DataMember]
        [JsonProperty(Order = 4)]
        public List<OpeningTime> Thursday { get; set; }

        /// <summary>
        /// Opening times for Friday
        /// </summary>
        [DataMember]
        [JsonProperty(Order = 5)]
        public List<OpeningTime> Friday { get; set; }

        /// <summary>
        /// Opening times for Saturday
        /// </summary>
        [DataMember]
        [JsonProperty(Order = 6)]
        public List<OpeningTime> Saturday { get; set; }

        /// <summary>
        /// Opening times for Sunday
        /// </summary>
        [DataMember]
        [JsonProperty(Order = 7)]
        public List<OpeningTime> Sunday { get; set; }
    }
}