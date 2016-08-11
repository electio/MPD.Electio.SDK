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
    /// Represents a Consignment - a collection of one or more packages
    /// transiting together from the same origin to the same destination via the same carrier
    /// at the same time.
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.DataTypes.Consignments.ConsignmentBase" />
    [DataContract]
    [XmlRoot("Consignment", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class Consignment : ConsignmentBase
	{
        
        /// <summary>
        /// Gets or sets the consignment legs - the stages
        /// of the journey between origin and destination.
        /// 
        /// A journey can consist of multiple legs when more than
        /// one carrier is responsible for the delivery of the consignment from
        /// it's origin to destination.
        /// </summary>
        /// <value>
        /// The consignment legs.
        /// </value>
        [DataMember]
        public List<ConsignmentLeg> ConsignmentLegs { get; set; }
        
        /// <summary>
        /// Gets or sets the date on which the carrier will collect the consignment.
        /// </summary>
        /// <value>
        /// The collection date.
        /// </value>
        [DataMember]
        public DateTimeOffset? CollectionDate { get; set; }
        
        /// <summary>
        /// Gets or sets the date on which the consignment was delivered.
        /// </summary>
        /// <value>
        /// The date delivered.
        /// </value>
        [DataMember]
		public DateTimeOffset? DateDelivered { get; set; }
        /// <summary>
        /// Gets or sets the date on which the consignment was
        /// first attempted to be delivered by the carrier.
        /// </summary>
        /// <value>
        /// The first attempted delivery date.
        /// </value>
        [DataMember]
        public DateTimeOffset? FirstAttemptedDeliveryDate { get; set; }
        [DataMember]
		public DateTimeOffset? DateReturned { get; set; }
        [DataMember]
		public DateTimeOffset? DateShipped { get; set; }
        [DataMember]
		public DateTimeOffset? DateCollected { get; set; }
        [DataMember]
		public DateTimeOffset? AttemptedDeliveryDate { get; set; }
        /// <summary>
        /// Gets or sets the meta data.
        /// </summary>
        /// <value>
        /// The meta data.
        /// </value>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<MetaData> MetaData { get; set; }
        
        /// <summary>
        /// Gets or sets the collection of packages
        /// within the consignment.
        /// </summary>
        /// <value>
        /// The packages.
        /// </value>
        [DataMember(Order=10)]
		public List<Package> Packages { get; set; }
        
        /// <summary>
        /// Gets or sets the allocation.
        /// </summary>
        /// <value>
        /// The allocation.
        /// </value>
        [DataMember]
		public Allocation Allocation { get; set; }
        /// <summary>
        /// Gets or sets the failed allocation.
        /// </summary>
        /// <value>
        /// The failed allocation.
        /// </value>
        [DataMember]
		public FailedAllocation FailedAllocation { get; set; }
        /// <summary>
        /// Gets or sets the state of the consignment.
        /// </summary>
        /// <value>
        /// The state of the consignment.
        /// </value>
        [DataMember (Order = 2)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConsignmentState ConsignmentState { get; set; }
        /// <summary>
        /// Gets or sets the source of creation 
        /// of the consignment - either via the Electio website
        /// or via the Api.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [DataMember]
		public string Source { get; set; }
        /// <summary>
        /// Gets or sets the count of the number of shipping labels
        /// associated with the consignment.
        /// </summary>
        /// <value>
        /// The label count.
        /// </value>
        [DataMember]
		public int LabelCount { get; set; }

        /// <summary>
        /// Returns true if the consignment has not yet been allocated 
        /// successfully with a Carrier Service.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is un allocated; otherwise, <c>false</c>.
        /// </value>
        [Obsolete("This property can be derived")]
        [JsonIgnore]
        [XmlIgnore]
        [DataMember]
        public bool IsUnAllocated
		{
			get
			{
			    // ReSharper disable once SwitchStatementMissingSomeCases
				switch (ConsignmentState)
				{
					case ConsignmentState.Unallocated:
					case ConsignmentState.Allocating:
					case ConsignmentState.AllocationFailed:
						return true;
					default:
						return false;
				}
			}
		}
        /// <summary>
        /// Gets or sets a value indicating whether the labels have been printed for the Consignment.
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
        /// Gets or sets a value indicating whether this instance is late.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is late; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
		public bool IsLate { get; set; }

        /// <summary>
        /// Indicates whether the consignment is late from the perspective of the customer
        /// </summary>
        [DataMember]
        public bool LateForCustomer { get; set; }

        /// <summary>
        /// Gets or sets the Electio reference (EC-xxx-xxx-xxx).
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember(Order = 1)]
        public override string Reference { get; set; }

        /// <summary>
        /// Provides details of the selected pick up location
        /// <remarks>
        /// This property is only applicable when a pick up location has been selected
        /// </remarks>
        /// </summary>
        public LocationInformation LocationInformation { get; set; }
	}
}
