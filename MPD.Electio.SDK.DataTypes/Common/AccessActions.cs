using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("AccessActions", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    [Serializable]
    public enum AccessActions
	{
		[EnumMember]
		None = 0,

		[EnumMember]
		GetCustomer = 1,

		[EnumMember]
		GetAccount = 2,

		[EnumMember]
		UpdatePassword = 3,

		[EnumMember]
		UpdateAccount = 4,

		[EnumMember]
		UpdateCustomer = 11,

		[EnumMember]
		CreateAccount = 12,

		[EnumMember]
		UpdateCustomerSubscription = 13,

		[EnumMember]
		GetAllCarrierServices = 21,

		[EnumMember]
		AddCarrierService = 22,

		[EnumMember]
		UpdateCarrierService = 23,

		[EnumMember]
		GetCustomRoles = 31,

		[EnumMember]
		CreateCustomRole = 32,

		[EnumMember]
		DeleteCustomRole = 33,

		[EnumMember]
		UpdateCustomRole = 34,

		[EnumMember]
		GetRoleAccounts = 35,

		[EnumMember]
		AddAccountToRole = 36,

		[EnumMember]
		RemoveAccountFromRole = 37,

		[EnumMember]
		CreateShippingLocation = 41,

		[EnumMember]
		UpdateShippingLocation = 42,

		[EnumMember]
		DeleteShippingLocation = 43,

		[EnumMember]
		CreateServiceGroup = 51,

		[EnumMember]
		UpdateServiceGroup = 52,

		[EnumMember]
		DeleteServiceGroup = 53,

		[EnumMember]
		CreatePackageSize = 61,
		
		[EnumMember]
		PackageUpdateSizes = 63,
		
		[EnumMember]
		PackageDeleteSizes = 62,

		[EnumMember]
		SetDefaultPackageSize = 64,

		[EnumMember]
		GetCollectionCalendar = 71,

		[EnumMember]
		UpdateCollectionCalendar = 72,

		[EnumMember]
		GetServiceProfile = 81,

		[EnumMember]
		UpdateServiceProfile = 82,

		[EnumMember]
		CreateServiceProfile = 83,

		[EnumMember]
		CSGetCustomers = 91,

		[EnumMember]
		GetConsignments = 101,

		[EnumMember]
		UpdateConsignments = 102,

		[EnumMember]
		CreateConsignments = 103,

		[EnumMember]
		MovePackageItems = 111,

		[EnumMember]
		UpdatePackages = 112,

		[EnumMember]
		DeletePackages = 113,

		[EnumMember]
		GetQuotes = 121,

		[EnumMember]
		GetEventTracking = 131,

		[EnumMember]
		UploadNewRatesCost = 141,

		[EnumMember]
		SetVolumeDiscounts = 142,

		[EnumMember]
		GetRatesTemplate = 143,

		[EnumMember]
		GetRatesForConsignment = 144,

		[EnumMember]
		GetCustomerDocument = 145,

		[EnumMember]
		AddSubscriptionPlan = 146,

		[EnumMember]
		EditSubscriptionPlan = 147,

        [EnumMember]
        AddCustomer = 148,

		[EnumMember]
        EditCustomer = 149,

		///<summary>Allows a user to create or update tolerances used for invoice reconciliation</summary>
		[EnumMember]
		ToleranceAdministration = 151,

        [EnumMember]
        ManageAllShippingLocations = 152,

        [EnumMember]
        ManageZones = 153,

        [EnumMember]
        ManagePriceModels = 154,

        [EnumMember]
        ManageCostModels = 155,

        [EnumMember]
        GlobalSwitchCustomer = 156,

        [EnumMember]
        ManageCustomers = 157,

        [EnumMember]
        ManageCarriers = 158,

        [EnumMember]
        ManageCarrierServices = 159,

        [EnumMember]
        ManageMpdCarrierServices = 160
    }
}
