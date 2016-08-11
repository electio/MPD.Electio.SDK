using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents a predefined package size.
    /// </summary>
    [DataContract]
    [XmlRoot("PackageSize", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class PackageSize
    {
        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        /// <value>
        /// The customer reference.
        /// </value>
        [DataMember]
        public Guid CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the length in cm.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public decimal Length { get; set; }

        /// <summary>
        /// Gets or sets the width in cm.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public decimal Width { get; set; }

        /// <summary>
        /// Gets or sets the height in cm.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public decimal Height { get; set; }

        /// <summary>
        /// Gets or sets the weight in Kg.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is the default package size for the Customer.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is default; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        [JsonProperty]
        public bool IsDefault { get; set; }
    }
}