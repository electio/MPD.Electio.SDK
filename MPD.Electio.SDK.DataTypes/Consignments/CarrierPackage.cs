using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("CarrierPackage", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class CarrierPackage
	{
		[DataMember]
		public Package Package { get; protected set; }

		[DataMember]
		public HashSet<Item> Items { get; set; }

		[DataMember]
		public string Description { get; set; }

		[DataMember]
		public string PackageReferenceForLegAssignedByCarrier { get; set; }

		[DataMember]
		public string PackageReferenceForLegAssignedByMpd { get; set; }

		[DataMember]
		public string PackageReferenceForAllLegsAssignedByMpd { get; set; }

		[DataMember]
		public DateTimeOffset? ActualDeliveryDate { get; set; }

		[DataMember]
		public DateTimeOffset? AttemptedDeliveryDate { get; set; }

		[DataMember]
		public DateTimeOffset? ActualCollectionDate { get; set; }

		[DataMember]
		public DateTimeOffset? LastEventDate { get; set; }

		[DataMember]
		public PackageState State { get; set; }

		[DataMember]
		public Dimensions Dimensions { get; set; }

		[DataMember]
		public Weight Weight { get; set; }

		[DataMember]
		public decimal Value { get; set; }

		[DataMember]
		public string PackageTrackingReferenceForLegAssignedByCarrier { get; set; }

        [DataMember]
        public string PackageReferenceProvidedByCustomer { get; set; }

		/// <summary>
		/// Sales tax of the package
		/// </summary>
		[DataMember]
		[Obsolete("Charges are now defined in the 'Charges' property with the appropriate 'CustomChargeType'. This allows extensibility.", true)]
		public decimal SalesTax { get; set; }

		/// <summary>
		/// Excise of the package
		/// </summary>
		[DataMember]
		[Obsolete("Charges are now defined in the 'Charges' property with the appropriate 'CustomChargeType'. This allows extensibility.", true)]
		public decimal Excise { get; set; }

		/// <summary>
		/// Duty of the package
		/// </summary>
		[DataMember]
		[Obsolete("Charges are now defined in the 'Charges' property with the appropriate 'CustomChargeType'. This allows extensibility.", true)]
		public decimal Duty { get; set; }

		/// <summary>
		/// List of custom charges applied to the package
		/// </summary>
		[DataMember]
		public List<Common.KeyValuePair<CustomChargeType, decimal>> Charges { get; set; }

        [DataMember]
        public CategoryType? CategoryType { get; set; }

        [DataMember]
        public string CategoryTypeExplanation { get; set; }
	}
}
