using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A 'Potential Consignment' represents all of the information required to form a <see cref="Consignment" />
    /// once a <see cref="DeliveryOption" /> has been selected.
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.DataTypes.Consignments.ConsignmentBase" />
    [DataContract]
    [XmlRoot("PotentialConsignment", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public sealed class PotentialConsignment : ConsignmentBase
    {
        /// <summary>
        /// Gets or sets the Electio reference (EPC-xxx-xxx-xxx).
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        public override string Reference { get; set; }
    }
}
