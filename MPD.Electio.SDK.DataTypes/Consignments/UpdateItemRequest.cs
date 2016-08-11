using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Request used to update the details of an individual item
    /// </summary>
    [DataContract]
    [XmlRoot("UpdateItemRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class UpdateItemRequest
    {
        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public string Sku { get; set; }

        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public Country CountryOfOrigin { get; set; }

        [DataMember]
        public string HarmonisationCode { get; set; }

        [DataMember]
        public Weight Weight { get; set; }

        [DataMember]
        public Dimensions Dimensions { get; set; }

        [DataMember]
        public Money Value { get; set; }

        [DataMember]
        public string ItemReferenceProvidedByCustomer { get; set; }

        [DataMember]
        public Barcode Barcode { get; set; }

        [DataMember]
        public List<MetaData> MetaData { get; set; }

        [DataMember]
        public int UnitOfQuantity { get; set; }

        [DataMember]
        public string ItemUnit { get; set; }

        [DataMember]
        public List<string> HarmonisationKeyWords { get; set; }
    }
}
