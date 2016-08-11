using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents an item contained within a <see cref="Package">package</see>.
    /// </summary>
    [DataContract]
    [XmlRoot("Item", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class Item
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="Item"/> class.
        /// </summary>
        public Item()
		{
			HarmonisationKeyWords = new List<string>();
		}

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
		public string Reference { get; set; }
        /// <summary>
        /// Gets or sets the SKU (Stock Keeping Unit).
        /// </summary>
        /// <value>
        /// The sku.
        /// </value>
        [DataMember]
		public string Sku { get; set; }
        
        /// <summary>
        /// Model code or description for the item
        /// </summary>
        [DataMember]
        public string Model { get; set; }
        
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
		public string Description { get; set; }
        /// <summary>
        /// Gets or sets the country of origin.
        /// </summary>
        /// <value>
        /// The country of origin.
        /// </value>
        [DataMember]
		public Country CountryOfOrigin { get; set; }
        /// <summary>
        /// Gets or sets the harmonisation code.
        /// </summary>
        /// <value>
        /// The harmonisation code.
        /// </value>
        [DataMember]
		public string HarmonisationCode { get; set; }
        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        [DataMember]
		public Weight Weight { get; set; }
        /// <summary>
        /// Gets or sets the dimensions.
        /// </summary>
        /// <value>
        /// The dimensions.
        /// </value>
        [DataMember]
		public Dimensions Dimensions { get; set; }
        /// <summary>
        /// Gets or sets the monetary value of the item.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [DataMember]
		public Money Value { get; set; }
        /// <summary>
        /// Gets or sets the item reference provided by customer.
        /// </summary>
        /// <value>
        /// The item reference provided by customer.
        /// </value>
        [DataMember]
		public string ItemReferenceProvidedByCustomer { get; set; }
        /// <summary>
        /// Gets or sets the barcode.
        /// </summary>
        /// <value>
        /// The barcode.
        /// </value>
        [DataMember]
		public Barcode Barcode { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [DataMember]
		public string Status { get; set; }
        /// <summary>
        /// Gets or sets the meta data.
        /// </summary>
        /// <value>
        /// The meta data.
        /// </value>
        [DataMember]
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public List<MetaData> MetaData { get; set; }

		/// <summary>
		/// Number of content/units within the parcel/Item e.g. if 2 packets of bolts are sent within a physical parcel, this field would be populated with '2'
		/// </summary>
		[DataMember]
		public int UnitOfQuantity { get; set; }

        /// <summary>
        /// Describes *how* the item is packaged. Unit of Measure.
        /// Whether the items are listed as individual, bundle, roll, etc.
        /// For instance, A BOX of bolts, this should be set as 'box'. A PALLET of cereal boxes, this should be set as 'pallet'. etc.
        /// </summary>
        [DataMember]
        public string ItemUnit { get; set; }

        /// <summary>
        /// Gets or sets the harmonisation key words.
        /// </summary>
        /// <value>
        /// The harmonisation key words.
        /// </value>
        [DataMember]
		public List<string> HarmonisationKeyWords { get; set; }

        /// <summary>
        /// Optional classification of an Item
        /// </summary>
        /// <value>
        /// The content classification.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContentClassification? ContentClassification { get; set; }

        /// <summary>
        /// Optional details for the classification of an Itme
        /// </summary>
        /// <value>
        /// The content classification details.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ContentClassificationDetails? ContentClassificationDetails { get; set; }

	}
}
