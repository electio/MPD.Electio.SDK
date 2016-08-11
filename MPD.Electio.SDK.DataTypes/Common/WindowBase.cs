using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Base class for a start timespan and end timespan representing a window
    /// <remarks>
    /// This class includes serialization attributes to ensure correct serialization in XML and JSON
    /// </remarks>
    /// </summary>
    [DataContract]
    [XmlRoot("WindowBase", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public abstract class WindowBase
    {
        /// <summary>
        /// The start of the window
        /// </summary>
        /// <value>
        /// The start.
        /// </value>
        [XmlIgnore]
        [DataMember]
        [JsonProperty(Order = 1)]
        public TimeSpan Start { get; set; }

        /// <summary>
        /// The end of the window
        /// </summary>
        /// <value>
        /// The end.
        /// </value>
        [XmlIgnore]
        [DataMember]
        [JsonProperty(Order = 2)]
        public TimeSpan End { get; set; }

        /// <summary>
        /// The start of the window represented as an XML duration is ISO format
        /// <seealso cref="!:https://en.wikipedia.org/wiki/ISO_8601#Durations"/>
        /// <remarks>
        /// This property is ignored when serializing as JSON, and named "Start" when serializing as XML
        /// </remarks>
        /// </summary>
        [JsonIgnore]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement(DataType = "duration", ElementName = "Start")]
        public string StartString
        {
            get { return XmlConvert.ToString(Start); }
            set { Start = string.IsNullOrEmpty(value) ? TimeSpan.Zero : XmlConvert.ToTimeSpan(value); }
        }

        /// <summary>
        /// The end of the window represented as an XML duration is ISO format
        /// <seealso href="https://en.wikipedia.org/wiki/ISO_8601#Durations"/>
        /// <remarks>
        /// This property is ignored when serializing as JSON, and named "End" when serializing as XML
        /// </remarks>
        /// </summary>
        [JsonIgnore]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement(DataType = "duration", ElementName = "End")]
        public string EndString
        {
            get { return XmlConvert.ToString(End); }
            set { End = string.IsNullOrEmpty(value) ? TimeSpan.Zero : XmlConvert.ToTimeSpan(value); }
        }

        /// <summary>
        /// Gets or sets the UTC offset.
        /// </summary>
        /// <value>
        /// The UTC offset.
        /// </value>
        [DataMember]
        [JsonProperty(Order = 3)]
        public string UtcOffset { get; set; }
    }
}