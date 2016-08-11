using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Update the properties of an existing consignment
    /// </summary>
    [DataContract]
    [XmlRoot("UpdateConsignmentRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class UpdateConsignmentRequest
    {
        /// <summary>
        /// The consignment reference in the format EC-XXX-XXX-XXX
        /// </summary>
        [DataMember]
        public string Reference { get; set; }

        /// <summary>
        /// The requested delivery date for this consignment
        /// <remarks>
        /// This can only be updated where the consignment has not already been allocated
        /// </remarks>
        /// </summary>
        [DataMember]
        public RequestedDeliveryDate RequestedDeliveryDate { get; set; }

        /// <summary>
        /// The shipping date for the consignment
        /// </summary>
        [DataMember]
        public DateTimeOffset? ShippingDate { get; set; }

        /// <summary>
        /// Your own reference for this consignment
        /// </summary>
        [DataMember]
        public string ConsignmentReferenceProvidedByCustomer { get; set; }

        /// <summary>
        /// The customs documentation for this consignment
        /// </summary>
        [DataMember]
        public CustomsDocumentation CustomsDocumentation { get; set; }

        /// <summary>
        /// The addresses for the consignment
        /// <remarks>
        /// Key address details cannot be updated if a consignment has already been allocated
        /// </remarks>
        /// </summary>
        [DataMember]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// The consignment metadata
        /// </summary>
        [DataMember]
        public List<MetaData> MetaData { get; set; }

        /// <summary>
        /// The packages for this consignment
        /// <remarks>
        /// Packages cannot be added or removed if a consignment has already been allocated
        /// </remarks>
        /// </summary>
        [DataMember]
        public List<UpdatePackageRequest> Packages { get; set; }
    }
}
