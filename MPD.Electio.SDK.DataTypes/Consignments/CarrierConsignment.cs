using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.CarrierBooking.Enums;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using MPD.Electio.SDK.DataTypes.Rates;
using MPD.Electio.SDK.DataTypes.ServiceAvailability;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents the association between a Consignment and a Carrier service.
    /// </summary>
    [DataContract]
    [XmlRoot("CarrierConsignment", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class CarrierConsignment
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierConsignment"/> class.
        /// </summary>
        public CarrierConsignment()
	    {
	        Addresses = new List<Address>();
	    }

        /// <summary>
        /// Gets or sets the consignment reference for leg assigned by MPD.
        /// </summary>
        /// <value>
        /// The consignment reference for leg assigned by MPD.
        /// </value>
        [DataMember]
		public string ConsignmentReferenceForLegAssignedByMpd { get; set; }

        /// <summary>
        /// Gets or sets the consignment reference for leg assigned by carrier.
        /// </summary>
        /// <value>
        /// The consignment reference for leg assigned by carrier.
        /// </value>
        [DataMember]
		public string ConsignmentReferenceForLegAssignedByCarrier { get; set; }

        /// <summary>
        /// Gets or sets the consignment reference for all legs assigned by MPD.
        /// </summary>
        /// <value>
        /// The consignment reference for all legs assigned by MPD.
        /// </value>
        [DataMember]
		public string ConsignmentReferenceForAllLegsAssignedByMpd { get; set; }

        /// <summary>
        /// Gets or sets the carrier reference.
        /// </summary>
        /// <value>
        /// The carrier reference.
        /// </value>
        [DataMember]
		public string CarrierReference { get; set; }

        /// <summary>
        /// Gets or sets the carrier service reference.
        /// </summary>
        /// <value>
        /// The carrier service reference.
        /// </value>
        [DataMember]
		public string CarrierServiceReference { get; set; }

        /// <summary>
        /// Gets or sets the carrier account reference.
        /// </summary>
        /// <value>
        /// The carrier account reference.
        /// </value>
        [DataMember]
		public string CarrierAccountReference { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        [DataMember]
		public string MpdCarrierServiceReference { get; set; }
        
        /// <summary>
        /// Gets or sets the collection window.
        /// </summary>
        /// <value>
        /// The collection window.
        /// </value>
        [DataMember]
		public CollectionWindow CollectionWindow { get; set; }

        /// <summary>
        /// Date carrier consignment is expected to be collected
        /// </summary>
        public DateTimeOffset? CollectionDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is drop off.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is drop off; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
		public bool IsDropOff { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is pick up.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is pick up; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
		public bool IsPickUp { get; set; }

        /// <summary>
        /// Gets or sets the shop reservation reference for a Pickup service if required.
        /// <remarks>Not all services require the shop to be reserved.</remarks>
        /// </summary>
        /// <value>
        /// The shop reservation reference.
        /// </value>
        [DataMember]
        public string ShopReservationReference { get; set; }

        /// <summary>
        /// Gets or sets the leg number within the journey.
        /// </summary>
        /// <value>
        /// The leg number.
        /// </value>
        [DataMember]
		public int LegNumber { get; protected set; }

        /// <summary>
        /// Gets or sets the carrier packages.
        /// </summary>
        /// <value>
        /// The carrier packages.
        /// </value>
        [DataMember]
		public List<CarrierPackage> CarrierPackages { get; set; }

        /// <summary>
        /// Gets or sets the consignment allocation.
        /// </summary>
        /// <value>
        /// The consignment allocation.
        /// </value>
        [DataMember]
		public ConsignmentAllocation ConsignmentAllocation { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [DataMember]
		public ConsignmentState State { get; set; }

        /// <summary>
        /// Gets or sets the estimated delivery date.
        /// </summary>
        /// <value>
        /// The estimated delivery date.
        /// </value>
        [DataMember]
		public DateTimeOffset EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the original estimated delivery date.
        /// </summary>
        /// <value>
        /// The original estimated delivery date.
        /// </value>
        [DataMember]
		public DateTimeOffset OriginalEstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the type of the collection.
        /// </summary>
        /// <value>
        /// The type of the collection.
        /// </value>
        [DataMember]
		public CollectionType CollectionType { get; set; }

        /// <summary>
        /// Gets or sets the cost items.
        /// </summary>
        /// <value>
        /// The cost items.
        /// </value>
        [DataMember]
		public HashSet<CostItem> CostItems { get; set; }

        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        /// <value>
        /// The customer reference.
        /// </value>
        [DataMember]
		public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the monetary value of the contents
        /// </summary>
        /// <value>
        /// The contents value.
        /// </value>
        [DataMember]
		public Money ContentsValue { get; set; }

        /// <summary>
        /// Gets or sets the description of the contents.
        /// </summary>
        /// <value>
        /// The contents.
        /// </value>
        [DataMember]
		public string Contents { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [signature required].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [signature required]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
		public bool SignatureRequired { get; set; }

        /// <summary>
        /// Gets or sets the booking request date.
        /// </summary>
        /// <value>
        /// The booking request date.
        /// </value>
        [DataMember]
		public DateTimeOffset? BookingRequestDate { get; set; }

        /// <summary>
        /// Gets or sets the delivery date.
        /// </summary>
        /// <value>
        /// The delivery date.
        /// </value>
        [DataMember]
		public DateTimeOffset? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the booking references.
        /// </summary>
        /// <value>
        /// The booking references.
        /// </value>
        [DataMember]
		public List<BookingReference> BookingReferences { get; set; }

        /// <summary>
        /// Gets or sets the consignment reference as supplied by the client.
        /// </summary>
        /// <value>
        /// The client's consignment reference.
        /// </value>
        [DataMember]
		public string ConsignmentReferenceProvidedByCustomer { get; set; }

        /// <summary>
        /// Gets or sets the booking status.
        /// </summary>
        /// <value>
        /// The booking status.
        /// </value>
        [DataMember]
		public ConsignmentBookingStatus BookingStatus { get; set; }

        /// <summary>
        /// Gets or sets the consignment tracking reference assigned by carrier.
        /// </summary>
        /// <value>
        /// The consignment tracking reference assigned by carrier.
        /// </value>
        [DataMember]
		public string ConsignmentTrackingReferenceAssignedByCarrier { get; set; }

        /// <summary>
        /// Contact addresses attached to this carrier consignment
        /// </summary>
        [DataMember]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
		{
			return ConsignmentReferenceForLegAssignedByCarrier;
		}
	}
}
