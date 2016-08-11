using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents a request to create a new Consignment within Electio.
    /// </summary>
    [DataContract]
    [XmlRoot("CreateConsignmentRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class CreateConsignmentRequest : BaseCreateConsignmentRequest
	{
        /// <summary>
        /// Gets or sets the source of the consignment, either the Electio website or the Api.
        ///
        /// If no value is specified, it is assumed that the request has originated via an API call.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [DataMember]
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the required delivery date.
        /// </summary>
        /// <value>
        /// The required delivery date.
        /// </value>
        [DataMember]
        public RequestedDeliveryDate RequiredDeliveryDate { get; set; }

        /// <summary>
        /// Gets or sets the meta data.
        /// </summary>
        /// <value>
        /// The meta data.
        /// </value>
        [DataMember]
        public List<MetaData> MetaData { get; set; }
    }
}
