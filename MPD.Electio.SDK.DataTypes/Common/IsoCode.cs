using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents an IsoCode
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("IsoCode", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class IsoCode
    {
        /// <summary>
        /// Gets or sets the two letter code.
        /// </summary>
        /// <value>
        /// The two letter code.
        /// </value>
        [DataMember]
        public string TwoLetterCode { get; set; }

        /// <summary>
        /// Gets or sets the three letter code.
        /// </summary>
        /// <value>
        /// The three letter code.
        /// </value>
        [DataMember]
        [XmlIgnore]
        public string ThreeLetterCode { get; set; }

        /// <summary>
        /// Gets or sets the numeric code.
        /// </summary>
        /// <value>
        /// The numeric code.
        /// </value>
        [DataMember]
        [XmlIgnore]
        public string NumericCode { get; set; }
    }
}
