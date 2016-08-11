using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

// ReSharper disable InconsistentNaming


namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
	[Flags]
    [DataContract]
    [XmlRoot("ShippingTerms", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum ShippingTerms
	{
		/// <summary>
		/// None
		/// </summary>
		[EnumMember]
		None = 0,
		/// <summary>
		/// EXW - Ex Works (named place of delivery)
		/// </summary>
		[EnumMember]
		[Display(Name = @"EXW - Ex Works (named place of delivery)")]
		EXW = 1,
		/// <summary>
		/// FCA - Free Carrier (named place of delivery)
		/// </summary>
		[EnumMember]
		[Display(Name = @"FCA - Free Carrier (named place of delivery)")]
		FCA = 2,
		/// <summary>
		/// CPT - Carriage Paid To (named place of destination)
		/// </summary>
		[EnumMember]
		[Display(Name = @"CPT - Carriage Paid To (named place of destination)")]
		CPT = 4,
		/// <summary>
		/// CIP – Carriage and Insurance Paid to (named place of destination)
		/// </summary>
		[EnumMember]
		[Display(Name = @"CIP – Carriage and Insurance Paid to (named place of destination)")]
		CIP = 8,
		/// <summary>
		/// DAT – Delivered At Terminal (named terminal at port or place of destination)
		/// </summary>
		[EnumMember]
		[Display(Name = @"DAT – Delivered At Terminal (named terminal at port or place of destination)")]
		DAT = 16,
		/// <summary>
		/// DAP – Delivered At Place (named place of destination)
		/// </summary>
		[EnumMember]
		[Display(Name = @"DAP – Delivered At Place (named place of destination)")]
		DAP = 32,
		/// <summary>
		/// DDP – Delivered Duty Paid (named place of destination)
		/// </summary>
		[EnumMember]
		[Display(Name = @"DDP – Delivered Duty Paid (named place of destination)")]
		DDP = 64,
		/// <summary>
		/// FAS – Free Alongside Ship (named port of shipment)
		/// </summary>
		[EnumMember]
		[Display(Name = @"FAS – Free Alongside Ship (named port of shipment)")]
		FAS = 128,
		/// <summary>
		/// FOB – Free on Board (named port of shipment)
		/// </summary>
		[EnumMember]
		[Display(Name = @"FOB – Free on Board (named port of shipment)")]
		FOB = 256,
		/// <summary>
		/// CFR(CNF) – Cost and Freight (named port of destination)
		/// </summary>
		[EnumMember]
		[Display(Name = @"CFR(CNF) – Cost and Freight (named port of destination)")]
		CFR = 512,
		/// <summary>
		/// CIF – Cost, Insurance and Freight (named port of destination)
		/// </summary>
		[EnumMember]
		[Display(Name = @"CIF – Cost, Insurance & Freight (named port of destination)")]
		CIF = 1024
	}
}
