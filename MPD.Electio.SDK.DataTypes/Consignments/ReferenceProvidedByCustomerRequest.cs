using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents a request to supply a reference sourced by the customer
    /// <para>
    /// In the context of a consignment, this would refer to the 'ConsignmentReferenceProvidedByCustomer'.
    /// In the context of a package, this would refer to the 'PackageReferenceProvidedByCustomer'.
    /// In the context of an item, this would refer to the 'ItemReferenceProvidedByCustomer'.
    /// </para>
    /// </summary>
    [DataContract]
    [XmlRoot("ReferenceProvidedByCustomerRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ReferenceProvidedByCustomerRequest
    {
        /// <summary>
        /// The reference provided by the customer
        /// </summary>
        [DataMember]
        public string Reference { get; set; }
    }
}