using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Attributes;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    /// <summary>
    /// The current state of the <see cref="Consignment">Consignment</see>.
    /// </summary>
    [DataContract]
    [XmlRoot("ConsignmentState", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum ConsignmentState
	{
        /// <summary>
        /// Unallocated - Not allocated to any MPD Carrier Service
        /// </summary>
        [UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
		Unallocated = 0,

        /// <summary>
        /// In the process of being allocated with an MPD Carrier Service in response
        /// to a request to Allocate.
        /// </summary>
        [UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
        Allocating = 1,

        /// <summary>
        /// Previously attempted to allocate with an MPD Carrier Service but the allocation
        /// failed. The FailedAllocation will contain details of why the allocate attempt failed.
        /// </summary>
        [UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Error)]
        [EnumMember]
        AllocationFailed = 2,

        /// <summary>
        /// Successfully Allocated with an MPD Carrier Service. Labels are available but the
        /// consignment has not yet been manifested with the Carrier.
        /// </summary>
        [EnumMember]
        Allocated = 3,

        /// <summary>
        /// In the process of being manifested with an MPD Carrier Service in response
        /// to a request to Manifest.
        /// </summary>
        [UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
        Manifesting = 4,

        /// <summary>
        /// Successfully manifested with all Carriers within the Consignment's journey.
        /// </summary>
        [EnumMember]
        Manifested = 5,

        /// <summary>
        /// Previously attempted to manifest with the allocated Carrier but
        /// Manifest did not complete successfully.
        /// </summary>
        [UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Error)]
        [EnumMember]
        ManifestFailed = 6,

		[Shipped]
        [EnumMember]
        AtDropOffPoint = 9,

		[Shipped]
        [EnumMember]
        Collected = 10,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
        CollectionFailed = 11,

		[Shipped]
        [EnumMember]
        InTransit = 12,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
        Delayed = 13,

		[Shipped]
        [EnumMember]
        OutForDelivery = 14,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
        DeliveryFailed = 15,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
        DeliveryFailedCardLeft = 16,

		[Shipped]
        [EnumMember]
        Delivered = 17,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Warning)]
        [EnumMember]
        PartiallyDelivered = 18,

		[Shipped]
        [EnumMember]
        AtCollectionPoint = 19,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Error)]
        [EnumMember]
        ReturnToSender = 20,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Error)]
        [EnumMember]
        ActionRequired = 21,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Error)]
        [EnumMember]
        Missing = 22,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Error)]
        [EnumMember]
        Lost = 23,

		[Shipped]
		[UiDisplaySeverity(UiDisplaySeverityAttribute.UiDisplaySeverity.Error)]
        [EnumMember]
        Damaged = 24,

        /// <summary>
        /// In the process of being cancelled in response to a request to Cancel.
        /// </summary>
        [EnumMember]
        Cancelling = 25,

        /// <summary>
        /// Cancelled and de-allocated with the Carrier if previously Allocated or Manifested.
        /// No further action can be performed on a Consignment in this state.
        /// </summary>
        [EnumMember]
        Cancelled = 26,

        [Shipped]
        [EnumMember]
        InTransitWaiting = 27,

        [Shipped]
        [EnumMember]
        HeldByCarrier = 28,

        [Shipped]
        [EnumMember]
        ExchangeFailed = 29,

        [Shipped]
        [EnumMember]
        AtCustoms = 30,

        [Shipped]
        [EnumMember]
        CarrierUnableToCollect = 31,

        [Shipped]
        [EnumMember]
        DeliveredDamaged = 32
    }
}
