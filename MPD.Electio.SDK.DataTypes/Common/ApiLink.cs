using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("ApiLink", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class ApiLink
    {
        /// <summary>
        /// Gets or sets the relative.
        /// </summary>
        /// <value>
        /// The relative.
        /// </value>
        [DataMember]
        public string Rel { get; set; }
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        [DataMember]
        public string Href { get; set; }
    }
}
