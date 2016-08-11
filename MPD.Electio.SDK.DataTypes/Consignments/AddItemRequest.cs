using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("AddItemRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class AddItemRequest
    {
        [DataMember]
        public string PackageReference { get; set; }
        [DataMember]
        public string ItemReference { get; set; }
        [DataMember]
        public string Sku { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string CountryOfOriginTwoLetterIsoCode { get; set; }
        [DataMember]
        public string HarmonisationCode { get; set; }
        [DataMember]
        public Weight Weight { get; set; }
        [DataMember]
        public Dimensions Dimensions { get; set; }
        [DataMember]
        public Money Value { get; set; }
        [DataMember]
        public Barcode Barcode { get; set; }

		///<summary>Classification of the contents of a package</summary>
		[DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContentClassification? ContentClassification { get; set; }

		///<summary>Details for the classification of the package contents</summary>
		[DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContentClassificationDetails? ContentClassificationDetails { get; set; }
    }
}
