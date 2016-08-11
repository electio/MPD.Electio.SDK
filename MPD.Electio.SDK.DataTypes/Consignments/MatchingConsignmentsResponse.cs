using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("MatchingConsignmentsResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class MatchingConsignmentsResponse
	{
        /// <summary>
        /// Gets or sets the count of the number of matching results.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        [DataMember]
		public int Count { get; set; }

        /// <summary>
        /// Gets or sets the consignment summaries.
        /// </summary>
        /// <value>
        /// The consignment summaries.
        /// </value>
        [DataMember]
		public List<ConsignmentSummary> ConsignmentSummaries { get; set; }
	}
}
