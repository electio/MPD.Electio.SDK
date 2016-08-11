using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Hold additional information as a key value pair
    /// </summary>
    [DataContract]
    [XmlRoot("AdditionalInformation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class AdditionalInformation
    {
        /// <summary>
        /// The key of the additional information item
        /// </summary>
        [DataMember]
        public string Key { get; set; }

        /// <summary>
        /// The value of the additional information item
        /// </summary>
        [DataMember]
        public string Value { get; set; }
    }
}