using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// A Country
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("Country", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Country
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
        /// Gets or sets the Country ISO code.
        /// </summary>
        /// <value>
        /// The iso code.
        /// </value>
        [DataMember]
		public IsoCode IsoCode { get; set; }
	}
}
