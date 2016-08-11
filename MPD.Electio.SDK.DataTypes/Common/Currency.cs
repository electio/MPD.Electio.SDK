using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Currency
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("Currency", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Currency
	{
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
		public string Name { get; set; }

        /// <summary>
        /// Gets or sets the iso4217 alpha code - https://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        /// <value>
        /// The iso4217 alpha code.
        /// </value>
        [IgnoreDataMember]
		[JsonIgnore]
        [XmlIgnore]
		public string Iso4217AlphaCode { get; set; }

        /// <summary>
        /// Gets or sets the iso4217 numeric code - https://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        /// <value>
        /// The iso4217 numeric code.
        /// </value>
        [IgnoreDataMember]
		[JsonIgnore]
        [XmlIgnore]
        public int Iso4217NumericCode { get; set; }
        
        /// <summary>
        /// Gets or sets the 3 character ISO Code (eg GBP) 
        /// - https://en.wikipedia.org/wiki/ISO_4217
        /// </summary>
        /// <value>
        /// The iso code.
        /// </value>
       [DataMember]
		public string IsoCode { get; set; }
	}
}
