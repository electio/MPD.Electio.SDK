using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("AllocateConsignmentsRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class AllocateConsignmentsRequest
    {
        /// <summary>
        /// Gets or sets the consignment references.
        /// </summary>
        /// <value>
        /// The consignment references.
        /// </value>
        [DataMember]
        public List<string> ConsignmentReferences { get; set; }
    }
}
