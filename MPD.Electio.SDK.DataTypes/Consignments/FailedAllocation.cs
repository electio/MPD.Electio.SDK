using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents a failed attempt to allocate a consignment
    /// with a carrier service.
    /// </summary>
    [DataContract]
    [XmlRoot("FailedAllocation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class FailedAllocation
	{
        /// <summary>
        /// Gets or sets the carrier service group reference.
        /// </summary>
        /// <value>
        /// The carrier service group reference.
        /// </value>
        [DataMember]
		public string CarrierServiceGroupReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the MPD carrier service group.
        /// </summary>
        /// <value>
        /// The name of the MPD carrier service group.
        /// </value>
        [DataMember]
		public string MpdCarrierServiceGroupName { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        [DataMember]
		public string MpdCarrierServiceReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the MPD carrier service.
        /// </summary>
        /// <value>
        /// The name of the MPD carrier service.
        /// </value>
        [DataMember]
		public string MpdCarrierServiceName { get; set; }

        /// <summary>
        /// Gets or sets the attempted allocation date.
        /// </summary>
        /// <value>
        /// The attempted allocation date.
        /// </value>
        [DataMember]
		public DateTimeOffset AttemptedAllocationDate { get; set; }

        /// <summary>
        /// Gets or sets the message - reason for failure.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
		public string Message { get; set; }

	}
}
