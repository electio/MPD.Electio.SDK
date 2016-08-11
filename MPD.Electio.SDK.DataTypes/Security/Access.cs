using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security
{
	[DataContract]
    [Serializable]
	public enum Access
	{
		[EnumMember]
		None = 0,

		[EnumMember]
		AccountManagement = 1,

		[EnumMember]
		CustomerManagement = 2,

		[EnumMember]
		CarrierServiceManagement = 3,

		[EnumMember]
		RoleManagement = 4,

		[EnumMember]
		ShippingLocationManagement = 5,

		[EnumMember]
		ServiceGroupManagement = 6,

		[EnumMember]
		PackageSizeManagement = 7,

		[EnumMember]
		CollectionManagement = 8,

		[EnumMember]
		ServiceProfileManagement = 9,

		[EnumMember]
		CustomerServiceManagement = 10,

		[EnumMember]
		ConsignmentManagement = 11,

		[EnumMember]
		PackageManagement = 12,

		[EnumMember]
		QuoteManagement = 13,

		[EnumMember]
		TrackingManagement = 14,

		[EnumMember]
		RatesManagement = 15,

		[EnumMember] 
		SubscriptionPlanManagement = 16,

        [EnumMember]
        ReportManagement = 17,

        [EnumMember]
        ZonesManagement = 18,

        [EnumMember]
        ConfigurationManagement = 19
    }
}
