using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Quotes
{
    /// <summary>
    /// Represents an MPD Carrier Service for which a quote could not be obtained.
    /// </summary>
    [DataContract]
    public class UnqualifiedService
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="UnqualifiedService"/> is available for the requested consignment
        /// dimensions and journey.
        /// </summary>
        /// <value>
        ///   <c>true</c> if available; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool Available { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="UnqualifiedService"/> has rates configured within Electio.
        /// </summary>
        /// <value>
        ///   <c>true</c> if rates; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool Rates { get; set; }
        /// <summary>
        /// Gets or sets the MPD carrier service.
        /// </summary>
        /// <value>
        /// The MPD carrier service.
        /// </value>
        [DataMember]
        public string MpdCarrierService { get; set; }
        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceReference { get; set; }
        /// <summary>
        /// Gets or sets the exclusion reason.
        /// </summary>
        /// <value>
        /// The exclusion reason.
        /// </value>
        [DataMember]
        public string ExclusionReason { get; set; }
    }
}
