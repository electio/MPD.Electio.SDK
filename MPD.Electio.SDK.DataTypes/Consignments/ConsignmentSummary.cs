using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ConsignmentSummary", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class ConsignmentSummary
	{
        /// <summary>
        /// Gets or sets the Electio Consignment reference (EC-xxx-xxx-xxx)
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember(Order =1)]
		public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the reference provided by customer.
        /// </summary>
        /// <value>
        /// The reference provided by customer.
        /// </value>
        [DataMember(Order=2)]
        public string ConsignmentReferenceProvidedByCustomer { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The date created.
        /// </value>
        [DataMember(Order=3)]
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the state of the Consignment.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        [DataMember(Order = 4)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConsignmentState State { get; set; }

        /// <summary>
        /// Gets or sets the requested shipping date.
        /// </summary>
        /// <value>
        /// The shipping date.
        /// </value>
        [DataMember(Order = 5)]
        public DateTimeOffset? ShippingDate { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier reference.
        /// </summary>
        /// <value>
        /// The MPD carrier reference.
        /// </value>
        [DataMember(Order = 6)]
        public string MpdCarrierReference { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        [DataMember(Order=7)]
        public string MpdCarrierServiceReference { get; set; }

        /// <summary>
        /// Gets or sets the  allocation date - the date on which the consignment was allocated.
        /// </summary>
        /// <value>
        /// The active allocation date.
        /// </value>
        [DataMember(Order = 8)]
        public DateTimeOffset? AllocationDate { get; set; }


        /// <summary>
        /// Gets or sets the date on which the consignment was shipped
        /// </summary>
        /// <value>
        /// The shipped date.
        /// </value>
        [DataMember(Order=9)]
        public DateTimeOffset? ShippedDate { get; set; }
        
        
        /// <summary>
        /// Gets or sets the source of the creation of the consignment - API or Electio website.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [DataMember]
        public string Source { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the MPD carrier service.
        /// </summary>
        /// <value>
        /// The name of the MPD carrier service.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceName { get; set; }

        /// <summary>
        /// Gets or sets the name of the MPD carrier service group.
        /// </summary>
        /// <value>
        /// The name of the MPD carrier service group.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service group reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service group reference.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceGroupReference { get; set; }
        

        /// <summary>
        /// Gets or sets the destination address line1.
        /// </summary>
        /// <value>
        /// The destination address line1.
        /// </value>
        [DataMember]
        public string DestinationAddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the destination address town.
        /// </summary>
        /// <value>
        /// The destination address town.
        /// </value>
        [DataMember]
        public string DestinationAddressTown { get; set; }

        /// <summary>
        /// Gets or sets the destination address postcode.
        /// </summary>
        /// <value>
        /// The destination address postcode.
        /// </value>
        [DataMember]
        public string DestinationAddressPostcode { get; set; }

        /// <summary>
        /// Gets or sets the destination address country.
        /// </summary>
        /// <value>
        /// The destination address country.
        /// </value>
        [DataMember]
        public string DestinationAddressCountry { get; set; }

        /// <summary>
        /// Gets or sets the destination shipping location reference.
        /// </summary>
        /// <value>
        /// The destination shipping location reference.
        /// </value>
        [DataMember]
        public string DestinationShippingLocationReference { get; set; }

        /// <summary>
        /// Gets or sets the requested delivery date.
        /// </summary>
        /// <value>
        /// The requested delivery date.
        /// </value>
        [DataMember]
        public DateTimeOffset? RequestedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the requested delivery date is to be exactly on the date specified.
        /// </summary>
        /// <value>
        /// The requested delivery date is to be exactly on the date specified.
        /// </value>
        [DataMember]
        public bool? RequestedDeliveryDateIsToBeExactlyOnTheDateSpecified { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether labels have been printed.
        /// </summary>
        /// <value>
        /// <c>true</c> if labels have been printed otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool LabelsPrinted { get; set; }

        /// <summary>
        /// Gets or sets the date labels were first printed.
        /// </summary>
        /// <value>
        /// The date labels were first printed.
        /// </value>
        [DataMember]
        public DateTimeOffset? DateLabelsWereFirstPrinted { get; set; }

        /// <summary>
        /// Gets or sets the estimated delivery date.
        /// </summary>
        /// <value>
        /// The estimated delivery date.
        /// </value>
        [DataMember]
        public DateTimeOffset? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the shipping terms.
        /// </summary>
        /// <value>
        /// The shipping terms.
        /// </value>
        [DataMember]
        public ShippingTerms? ShippingTerms { get; set; }


        //Failed Allocation Info

        /// <summary>
        /// Gets or sets the failed allocation attempted allocation date.
        /// </summary>
        /// <value>
        /// The failed allocation attempted allocation date.
        /// </value>
        [DataMember]
        public DateTimeOffset? FailedAllocationAttemptedAllocationDate { get; set; }

        /// <summary>
        /// Gets or sets the failed allocation message.
        /// </summary>
        /// <value>
        /// The failed allocation message.
        /// </value>
        [DataMember]
        public string FailedAllocationMessage { get; set; }

        /// <summary>
        /// Gets or sets the failed allocation MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The failed allocation MPD carrier service reference.
        /// </value>
        [DataMember]
        public string FailedAllocationMpdCarrierServiceReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the failed alloc MPD carrier service group.
        /// </summary>
        /// <value>
        /// The name of the failed alloc MPD carrier service group.
        /// </value>
        [DataMember]
        public string FailedAllocationMpdCarrierServiceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the failed allocation MPD carrier service group reference.
        /// </summary>
        /// <value>
        /// The failed allocation MPD carrier service group reference.
        /// </value>
        [DataMember]
        public string FailedAllocationMpdCarrierServiceGroupReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the failed allocation MPD carrier service.
        /// </summary>
        /// <value>
        /// The name of the failed allocation MPD carrier service.
        /// </value>
        [DataMember]
        public string FailedAllocationMpdCarrierServiceName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is late.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is late; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsLate { get; set; }

        /// <summary>
        /// Gets or sets the delivery date.
        /// </summary>
        /// <value>
        /// The delivery date.
        /// </value>
        [DataMember]
        public DateTimeOffset? DeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the collection date.
        /// </summary>
        /// <value>
        /// The collection date.
        /// </value>
        [DataMember]
        public DateTimeOffset? CollectionDate { get; set; }

        /// <summary>
        /// Gets or sets the attempted delivery date.
        /// </summary>
        /// <value>
        /// The attempted delivery date.
        /// </value>
        [DataMember]
        public DateTimeOffset? AttemptedDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the monetary value of the Consignment.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [DataMember]
        public Money Value { get; set; }

        /// <summary>
        /// Gets or sets the weight of the Consignment in Kgs.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        [DataMember]
        public decimal Weight { get; set; }

        /// <summary>
        /// Gets or sets the API link.
        /// </summary>
        /// <value>
        /// The API link.
        /// </value>
        [DataMember]
        public ApiLink ApiLink { get; set; }

        /// <summary>
        /// Gets or sets the reason for a failed manifest
        /// </summary>
        [DataMember]
        public string FailedManifestMessage { get; set; }

        /// <summary>
        /// Gets or sets the failed manifest date
        /// </summary>
        [DataMember]
        public DateTimeOffset? FailedManifestTimeStamp { get; set; }

    }
}