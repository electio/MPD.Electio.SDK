using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents a request used in updating an existing package
    /// </summary>
    [DataContract]
    [XmlRoot("UpdatePackageRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class UpdatePackageRequest
	{
		/// <summary>
		/// Reference of the package to be updated
		/// </summary>
		[DataMember]
		public string Reference { get; set; }

        /// <summary>
        /// Customer-provided reference associated with the package
        /// </summary>
        [DataMember]
		public string PackageReferenceProvidedByCustomer { get; set; }

		/// <summary>
		/// Package weight
		/// </summary>
		[DataMember]
		public Weight Weight { get; set; }

		/// <summary>
		/// Package dimensions
		/// </summary>
		[DataMember]
		public Dimensions Dimensions { get; set; }

		/// <summary>
		/// Package description
		/// </summary>
		[DataMember]
		public string Description { get; set; }

		/// <summary>
		/// Package value
		/// </summary>
		[DataMember]
		public Money Value { get; set; }

		/// <summary>
		/// Optional reference of customer-defined package sizes
		/// </summary>
		[DataMember]
		public string PackageSizeReference { get; set; }

		/// <summary>
		/// Package barcocde
		/// </summary>
		[DataMember]
		public Barcode Barcode { get; set; }

		/// <summary>
        /// The metadata for this package
        /// </summary>
        [DataMember]
        public List<MetaData> MetaData { get; set; }

        /// <summary>
        /// The items in this package
        /// </summary>
        [DataMember]
        public List<UpdateItemRequest> Items { get; set; }
	}
}
