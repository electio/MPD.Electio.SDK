using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// A rate of tax for a specific country.
    /// </summary>
    [DataContract]
    [XmlRoot("VatRate", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public sealed class VatRate
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        public string Reference { get; set; }
        /// <summary>
        /// Gets or sets the two letter country ISO code.
        /// </summary>
        /// <value>
        /// The country iso code.
        /// </value>
        [DataMember]
        public string CountryIsoCode { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public VatRateType Type { get; set; }

        /// <summary>
        /// Rate/percentage represented as a decimal (0 - 1)
        /// ie 20% = 0.2
        /// </summary>
        [DataMember]
        public decimal Rate { get; set; }
    }
}
