using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Base for Consignments
    /// </summary>
    [DataContract]
    [XmlRoot("ConsignmentBase", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public abstract class ConsignmentBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsignmentBase"/> class.
        /// </summary>
        protected ConsignmentBase()
        {
            Addresses = new List<Address>();
        }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The date created.
        /// </value>
        [DataMember (Order=3)]
        public DateTimeOffset DateCreated { get; set; }
        /// <summary>
        /// Gets or sets the requested delivery date.
        /// </summary>
        /// <value>
        /// The requested delivery date.
        /// </value>
        [DataMember(Order =5)]
        public RequestedDeliveryDate RequestedDeliveryDate { get; set; }
        /// <summary>
        /// Gets or sets the shipping date.
        /// </summary>
        /// <value>
        /// The shipping date.
        /// </value>
        [DataMember(Order=4)]
        public DateTimeOffset? ShippingDate { get; set; }
        /// <summary>
        /// Gets or sets the earliest delivery date on which the carrier will deliver the 
        /// consignment.
        /// </summary>
        /// <value>
        /// The earliest delivery date.
        /// </value>
        [DataMember(Order =6)]
        public DateTimeOffset? EarliestDeliveryDate { get; set; }
        /// <summary>
        /// Gets or sets the latest delivery date on which the carrier
        /// will deliver the consignment.
        /// </summary>
        /// <value>
        /// The latest delivery date.
        /// </value>
        [DataMember(Order =7)]
        public DateTimeOffset? LatestDeliveryDate { get; set; }
        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        /// <value>
        /// The customer reference.
        /// </value>
        [DataMember]
        public Guid CustomerReference { get; set; }
        /// <summary>
        /// Gets or sets the consignment reference provided by customer.
        /// </summary>
        /// <value>
        /// The consignment reference provided by customer.
        /// </value>
        [DataMember(Order = 8)]
        public string ConsignmentReferenceProvidedByCustomer { get; set; }
        /// <summary>
        /// Gets or sets the Electio reference (EC-xxx-xxx-xxx).
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [XmlIgnore]
        public abstract string Reference { get; set; }
        /// <summary>
        /// Gets or sets the weight of the consignment -
        /// the total weight of all of the packages within the
        /// consignment.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        [DataMember]
        public Weight Weight { get; set; }
        /// <summary>
        /// Gets or sets the monetary value of the consignment.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        [DataMember]
        public Money Value { get; set; }

        /// <summary>
        /// Holds extra information as required for custom declaration documentation
        /// </summary>
        [DataMember]
        public CustomsDocumentation CustomsDocumentation { get; set; }


        /// <summary>
        /// Consignment addresses attached to this consignment
        /// </summary>
        [DataMember(Order=9)]
        public List<Address> Addresses { get; set; }
    }
}
