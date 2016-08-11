using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// A list of consignment references to manifest
    /// </summary>
	[DataContract]
    [XmlRoot("ManifestConsignmentsRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ManifestConsignmentsRequest
	{
        /// <summary>
        /// Initializes a <see cref="ManifestConsignmentsRequest"/> with an empty list of consignment references
        /// </summary>
		public ManifestConsignmentsRequest()
		{
			ConsignmentReferences = new List<string>();
		}

        /// <summary>
        /// A list of consignment references to be manifested
        /// </summary>
		[DataMember]
		public List<string> ConsignmentReferences { get; set; }
	}
}
