using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// An estimated delivery date
    /// </summary>
    [DataContract]
    [XmlRoot("EstimatedDeliveryDate", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class EstimatedDeliveryDate
    {
        /// <summary>
        /// The date of the estimated delivery
        /// </summary>
        [DataMember]
        [XmlIgnore]
        public DateTimeOffset Date { get; set; }

        [JsonIgnore]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement(ElementName = "Date")]
        [DataMember]
        public string DateString
        {
            get { return Date.ToString("o"); }
            set { Date = DateTimeOffset.Parse(value); }
        }


        /// <summary>
        /// A flag that indicates whether the delivery date is guaranteed or note
        /// </summary>
        [DataMember]
        public bool Guaranteed { get; set; }

        /// <summary>
        /// The string representation of the day of the week, e.g. Monday
        /// </summary>
        [DataMember]
        public string DayOfWeek => Date.DayOfWeek.ToString();
    }
}