using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    public abstract class BaseCreateConsignmentRequest
    {
        /// <summary>
        /// Gets or sets the consignment reference provided by customer.
        /// </summary>
        /// <value>
        /// The consignment reference provided by customer.
        /// </value>
        [DataMember]
        public string ConsignmentReferenceProvidedByCustomer { get; set; }

        /// <summary>
        /// Gets or sets the shipping date.
        /// </summary>
        /// <value>
        /// The shipping date.
        /// </value>
        [DataMember]
        public DateTime? ShippingDate { get; set; }

        /// <summary>
        /// Gets or sets the packages.
        /// </summary>
        /// <value>
        /// The packages.
        /// </value>
        [DataMember]
        public List<Package> Packages { get; set; }

        /// <summary>
        /// Information to be used in the generation of custom declaration documents (e.g. CN22, CN23)
        /// </summary>
        [DataMember]
        public CustomsDocumentation CustomsDocumentation { get; set; }


        /// <summary>
        /// Consingment addresses attached to this consignment
        /// </summary>
        [DataMember]
        public List<Address> Addresses { get; set; }
    }
}
