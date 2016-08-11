using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    [DataContract]
    [XmlRoot("PackageState", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum PackageState
	{
		[EnumMember]
		AwaitingCollection = 0,

		[EnumMember]
		Collected = 1,

		[EnumMember]
		InTransit = 2,

		[EnumMember]
		Delivered = 3,

		[EnumMember]
		Damaged = 4,

		[EnumMember]
		Missing = 5,

		[EnumMember]
		Lost = 6,

		[EnumMember]
		Delayed = 7,

		[EnumMember]
		AtCollectionPoint = 8,

		[EnumMember]
		AtDropOffPoint = 9,

		[EnumMember]
		CollectionFailed = 10,

		[EnumMember]
		DeliveryFailedCardLeft = 11,

		[EnumMember]
		DeliveryFailed = 12,

		[EnumMember]
		OutForDelivery = 13,

		[EnumMember]
		ReturnToSender = 14,

		[EnumMember]
		ActionRequired = 15,

        [EnumMember]
        InTransitWaiting = 16,

        [EnumMember]
        HeldByCarrier = 17,

        [EnumMember]
        ExchangeFailed = 18,

        [EnumMember]
        AtCustoms = 19,

        [EnumMember]
        CarrierUnableToCollect = 20,

        [EnumMember]
        DeliveredDamaged = 21
    }
}
