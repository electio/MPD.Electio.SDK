using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Holds information as required for custom declaration documentation.
    /// </summary>
    [DataContract]
    [XmlRoot("CustomsDocumentation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class CustomsDocumentation
	{

		public CustomsDocumentation()
		{
			CategoryType = CategoryType.Other;
			ReferencesOfAttachedInvoices = new List<string>();
			ReferencesOfAttachedCertificates = new List<string>();
			ReferencesOfAttachedLicences = new List<string>();
			ShippingTerms = ShippingTerms.None;

		}

        [DataMember]
        public string DesignatedPersonResponsible { get; set; }

		/// <summary>
		/// Importer's Reference - Importer's Vat Number
		/// </summary>
		[DataMember]
		public string ImportersVatNumber { get; set; }

		/// <summary>
		/// Category Type of package
		/// </summary>
		[DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public CategoryType CategoryType { get; set; }

		/// <summary>
		/// Custom reference of shipper
		/// </summary>
		[DataMember]
		public string ShipperCustomsReference { get; set; }

		/// <summary>
		/// Importer's Reference - Importer's Code.
		/// </summary>
		[DataMember]
		[Obsolete("Please change to use ImportersTaxCode. This will be expunged in a future version.", true)]
		public string ImportersCode { get; set; }

		/// <summary>
		/// Importer's Reference - Importer's Tax Code
		/// </summary>
		[DataMember]
		public string ImportersTaxCode { get; set; }

		/// <summary>
		/// Importer's Telephone
		/// </summary>
		[DataMember]
		public string ImportersTelephone { get; set; }

		/// <summary>
		/// Importer's Fax
		/// </summary>
		[DataMember]
		public string ImportersFax { get; set; }

		/// <summary>
		/// Importer's Email
		/// </summary>
		[DataMember]
		public string ImportersEmail { get; set; }

		/// <summary>
		/// Details if the contents are subject to quarantine (plant, animal, food products, etc.) or other restrictions.
		/// (e.g.: goods subject to quarantine, sanitary/phytosanitary inspection or other restrictions)
		/// </summary>
		[DataMember]
		// ReSharper disable once InconsistentNaming
		public string CN23Comments { get; set; }

		/// <summary>
		/// References of attached invoices
		/// </summary>
		[DataMember]
		public List<string> ReferencesOfAttachedInvoices { get; set; }

		/// <summary>
		/// References of attached certificates
		/// </summary>
		[DataMember]
		public List<string> ReferencesOfAttachedCertificates { get; set; }

		/// <summary>
		/// References of attached licences
		/// </summary>
		[DataMember]
		public List<string> ReferencesOfAttachedLicences { get; set; }

		/// <summary>
		/// More info linked to the category of the item.
		/// Marked as 'Explanation' in the 'Item Category' section on the CN23 document
		/// </summary>
		[DataMember]
		public string CategoryTypeExplanation { get; set; }

		/// <summary>
		/// Date of customs declaration
		/// </summary>
		[DataMember]
		public DateTimeOffset DeclarationDate { get; set; }

		/// <summary>
		/// Office of origin
		/// </summary>
		[DataMember]
		public string OfficeOfPosting { get; set; }

		/// <summary>
		/// Shippers reason for sending the package
		/// </summary>
		[DataMember]
		public string ReasonForExport { get; set; }

		/// <summary>
		/// International Commercial Terms, 3 Letter Trade Terms
		/// </summary>
		[DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ShippingTerms ShippingTerms { get; set; }

		/// <summary>
		/// VAT number of shipper
		/// </summary>
		[DataMember]
		public string ShippersVatNumber { get; set; }

		/// <summary>
		/// The Tax Code/Id of the receiver. The receiver is the *ultimate* recipient of the consignment.
		/// This is usually the same as the 'Importer'.
		/// </summary>
		[DataMember]
		public string ReceiversTaxCode { get; set; }

		/// <summary>
		/// The VAT number of the receeriver. The receiver is the *ultimate* recipient of the consignment.
		/// </summary>
		[DataMember]
		public string ReceiversVatNumber { get; set; }


        /// <summary>
        /// This should be the date the transaction took place in the seller's records. 
        /// Should correspond to the date on the commercial invoice.
        /// </summary>
        [DataMember]
        public DateTimeOffset InvoiceDate { get; set; }


    }
}
