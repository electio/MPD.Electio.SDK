using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Rates;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// Represents an option for delivery
    /// </summary>
    [DataContract]
    [XmlRoot("DeliveryOption", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public sealed class DeliveryOption
    {
        /// <summary>
        /// Gets or sets the unique reference for this delivery option.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        public string Reference { get; set; }

        /// <summary>
        /// The estimated date of delivery for this option
        /// </summary>
        [DataMember]
        public EstimatedDeliveryDate EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Represents a start and end time during which the delivery will be made
        /// </summary>
        [DataMember]
        public DeliveryWindow DeliveryWindow { get; set; }

        /// <summary>
        /// The name of the carrier
        /// </summary>
        [DataMember]
        public string Carrier { get; set; }

        /// <summary>
        /// The name of the carrier service
        /// </summary>
        [DataMember]
        public string CarrierService { get; set; }

        /// <summary>
        /// The reference of the carrier service
        /// </summary>
        [DataMember]
        public string CarrierServiceReference { get; set; }

        /// <summary>
        /// The price and currency for the delivery option
        /// </summary>
        [DataMember]
        public Rate Price { get; set; }

        /// <summary>
        /// The date and time by which allocation must be performed for this option to remain available
        /// </summary>
        [DataMember]
        [XmlIgnore]
        public DateTimeOffset AllocationCutOff { get; set; }

        /// <summary>
        /// The date and time by which allocation must be performed for this option to remain available
        /// </summary>
        [JsonIgnore]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement(ElementName = "AllocationCutOff")]
        [DataMember]
        public string AllocationCutOffString
        {
            get { return AllocationCutOff.ToString("o"); }
            set { AllocationCutOff = DateTimeOffset.Parse(value); }
        }

        /// <summary>
        /// Gets the operational cut off.
        /// </summary>
        /// <value>
        /// The operational cut off.
        /// </value>
        [DataMember]
        [XmlIgnore]
        public DateTimeOffset? OperationalCutOff { get; set; }

        /// <summary>
        /// Gets the operational cut off.
        /// </summary>
        /// <value>
        /// The operational cut off.
        /// </value>
        [JsonIgnore]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement(ElementName = "OperationalCutOff")]
        [DataMember]
        public string OperationalCutOffString
        {
            get { return OperationalCutOff?.ToString("o"); }
            set { OperationalCutOff = DateTimeOffset.Parse(value); }
        }

        /// <summary>
        /// Optional <see cref="Location"/> which indicates the location for this option where applicable
        /// </summary>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }
    }
}