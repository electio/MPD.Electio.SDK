using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents a barcode as defined - http://www.makebarcode.com/specs/barcodechart.html
    /// </summary>
    [DataContract]
    [XmlRoot("Barcode", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Barcode
    {
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the type of the barcode.
        /// </summary>
        /// <value>
        /// The type of the barcode.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public BarcodeType BarcodeType { get; set; }
    }
}
