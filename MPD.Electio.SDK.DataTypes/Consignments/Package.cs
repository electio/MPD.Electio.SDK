using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents a Package within a Consignment, typically a boxed item.
    /// </summary>
    [DataContract]
    [XmlRoot("Package", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class Package
	{
        /// <summary>
        /// Gets or sets the Electio reference (EP-xxx-xxx-xxx).
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
		public string Reference { get; set; }
        /// <summary>
        /// Gets or sets the package reference provided by customer.
        /// </summary>
        /// <value>
        /// The package reference provided by customer.
        /// </value>
        [DataMember]
		public string PackageReferenceProvidedByCustomer { get; set; }
        /// <summary>
        /// Gets or sets the consignment legs.
        /// </summary>
        /// <value>
        /// The consignment legs.
        /// </value>
        [DataMember]
        public List<ConsignmentLeg> ConsignmentLegs { get; set; }
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
        /// Gets or sets the monetary value of the Package.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [DataMember]
		public Money Value { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
		public string Description { get; set; }
        /// <summary>
        /// Gets or sets the optional package size reference.
        /// </summary>
        /// <value>
        /// The package size reference.
        /// </value>
        [DataMember]
		public string PackageSizeReference { get; set; }
        /// <summary>
        /// Gets or sets the barcode.
        /// </summary>
        /// <value>
        /// The barcode.
        /// </value>
        [DataMember]
		public Barcode Barcode { get; set; }
        /// <summary>
        /// Gets or sets the collection of items within the package.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        [DataMember]
		public List<Item> Items { get; set; }
        
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
        /// List of custom charges applied to the package.
        /// </summary>
        [DataMember]
        public List<Common.KeyValuePair<CustomChargeType, decimal>> Charges { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
		{
			var packageDetails = new List<string>(6);

			if (!string.IsNullOrWhiteSpace(PackageReferenceProvidedByCustomer))
			{
				packageDetails.Add("Your Reference: " + PackageReferenceProvidedByCustomer);
			}

			if (!string.IsNullOrWhiteSpace(Description))
			{
				packageDetails.Add("Description: " + Description);
			}

			if (Value != null)
			{
				packageDetails.Add($"Value: {Value.Amount} {Value.Currency.IsoCode}");
			}

			packageDetails.Add(
			    $"Weight: {Weight.Kg}kg | Height: {Dimensions.Height}cm | Length: {Dimensions.Length}cm | Width: {Dimensions.Width}cm");

            if (Charges != null && Charges.Any())
            {
                Charges.ForEach(x =>
                {
                    packageDetails.Add($"CustomChargeType: {x.Key.ToString()} Value: {x.Value}");
                });
            }

			return string.Join(" | ", packageDetails);
		}
	}
}