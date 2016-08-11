using System;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments;

namespace MPD.Electio.SDK.DataTypes.Quotes
{
    /// <summary>
    /// A request for a Quote for carriage of a consignment.
    /// </summary>
    [DataContract]
    public class QuoteRequest
    {
        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        /// <value>
        /// The customer reference.
        /// </value>
        [DataMember]
        public Guid CustomerReference { get; set; }
        /// <summary>
        /// Gets or sets the consignment.
        /// </summary>
        /// <value>
        /// The consignment.
        /// </value>
        [DataMember]
        public Consignment Consignment { get; set; }

        /// <summary>
        /// Gets or sets the optional MPD carrier service group reference to apply for 
        /// filtering quotes to a specific predefined grouping of MPD Carrier Services.
        /// </summary>
        /// <value>
        /// The MPD carrier service group reference.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceGroupReference { get; set; }
    }
}
