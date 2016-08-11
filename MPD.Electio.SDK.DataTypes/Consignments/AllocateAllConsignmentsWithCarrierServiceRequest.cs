using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("AllocateAllConsignmentsWithCarrierServiceRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class AllocateAllConsignmentsWithCarrierServiceRequest : AllocateAllConsignmentsRequest
    {
        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceReference { get; set; }
    }
}
