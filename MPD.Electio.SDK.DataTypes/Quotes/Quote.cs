using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.CarrierServiceDirectory;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Rates;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Quotes
{
    /// <summary>
    /// Represents a quote for carriage of a consignment with a specific MPD Carrier Service
    /// </summary>
    [DataContract]
    public class Quote
    {
        /// <summary>
        /// Gets or sets the unique quote reference.
        /// </summary>
        /// <value>
        /// The quote reference.
        /// </value>
        [DataMember(Order=0)]
        public Guid QuoteReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the requestor.
        /// </summary>
        /// <value>
        /// The requestor.
        /// </value>
        [DataMember(Order = 3)]
        public string Requestor { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        [DataMember(Order = 1)]
        [XmlIgnore]
        public DateTimeOffset CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        [JsonIgnore]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement(ElementName = "CreationDate")]
        [DataMember(Order = 1)]
        public string CreationDateString
        {
            get
            {
                return CreationDate.ToString("o");
            }
            set
            {
                CreationDate = DateTimeOffset.Parse(value);
            }
        }


        /// <summary>
        /// Gets or sets the expiry date.
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        [DataMember(Order = 2)]
        [XmlIgnore]
        public DateTimeOffset ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets the expiry date.
        /// </summary>
        /// <value>
        /// The expiry date.
        /// </value>
        [JsonIgnore]
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        [XmlElement(ElementName = "ExpiryDate")]
        [DataMember(Order = 2)]
        public string ExpiryDateString
        {
            get { return ExpiryDate.ToString("o"); }
            set { ExpiryDate = DateTimeOffset.Parse(value);}
        }

        /// <summary>
        /// Gets or sets the consignment reference.
        /// </summary>
        /// <value>
        /// The consignment reference.
        /// </value>
        [DataMember(Order=4)]
        public string ConsignmentReference { get; set; }

        /// <summary>
        /// Gets or sets the consignment reference provided by customer.
        /// </summary>
        /// <value>
        /// The consignment reference provided by customer.
        /// </value>
        [DataMember(Order = 5)]
        public string ConsignmentReferenceProvidedByCustomer { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        [DataMember(Order = 6)]
        public string MpdCarrierServiceReference { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service source.
        /// </summary>
        /// <value>
        /// The MPD carrier service source.
        /// </value>
        [DataMember]
        public MpdCarrierServiceSource MpdCarrierServiceSource { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service.
        /// </summary>
        /// <value>
        /// The MPD carrier service.
        /// </value>
        [DataMember]
        public string MpdCarrierService { get; set; }

        /// <summary>
        /// Gets or sets the origin address - the address from which the carrier
        /// will collect the consignment.
        /// </summary>
        /// <value>
        /// The origin address.
        /// </value>
        [DataMember]
        public Address OriginAddress { get; set; }

        /// <summary>
        /// Gets or sets the destination address - the address to which the carrier
        /// will deliver the consignment.
        /// </summary>
        /// <value>
        /// The destination address.
        /// </value>
        [DataMember]
        public Address DestinationAddress { get; set; }

        /// <summary>
        /// Gets or sets the collection date - the date on which the carrier will
        /// collect the consignment.
        /// </summary>
        /// <value>
        /// The collection date.
        /// </value>
        [DataMember]
        public DateTimeOffset? CollectionDate { get; set; }

        /// <summary>
        /// Gets or sets the earliest delivery date - the earliest date on which the 
        /// carrier will deliver the consignment.
        /// </summary>
        /// <value>
        /// The earliest delivery date.
        /// </value>
        [DataMember]
        public DateTimeOffset? EarliestDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the latest delivery date - the latest date on which the carrier
        /// will deliver the consignment.
        /// </summary>
        /// <value>
        /// The latest delivery date.
        /// </value>
        [DataMember]
        public DateTimeOffset? LatestDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the base price - the base price exclusive of any additional
        /// surcharges that may be applicable.
        /// </summary>
        /// <value>
        /// The base price.
        /// </value>
        [DataMember]
        public Rate BasePrice { get; set; }

        /// <summary>
        /// Gets or sets the total price for the Quote.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [DataMember]
        public Rate Price { get; set; }

        /// <summary>
        /// Gets or sets the surcharges - any surcharges that may be
        /// applicable to the quote due to parcel dimensions or collection or delivery
        /// locations etc.
        /// </summary>
        /// <value>
        /// The surcharges.
        /// </value>
        [DataMember]
        public List<QuoteSurcharge> Surcharges { get; set; }

        /// <summary>
        /// Gets the legs.
        /// </summary>
        /// <value>
        /// The legs.
        /// </value>
        [DataMember]
        public List<Leg> Legs { get; private set; }

        /// <summary>
        /// Gets or sets the carrier account owner.
        /// </summary>
        /// <value>
        /// The carrier account owner.
        /// </value>
        [DataMember]
        public string CarrierAccountOwner { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is an Electio service.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is an Electio service; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsElectioService { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quote"/> class.
        /// </summary>
        public Quote()
        {
            Legs = new List<Leg>();
        }
    }
}
