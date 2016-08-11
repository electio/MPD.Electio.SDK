using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("VolumetricWeight", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class VolumetricWeight
    {
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        [DataMember]
        public decimal? Weight { get; set; }
    }
}
