using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Rates;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents the allocation of a consignment with an MPD Carrier Service
    /// </summary>
    [DataContract]
    [XmlRoot("Allocation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class Allocation
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
        /// Gets or sets the date on which the consignment was
        /// allocated with the carrier service.
        /// </summary>
        /// <value>
        /// The allocation date.
        /// </value>
        [DataMember]
		public DateTimeOffset AllocationDate { get; set; }

        /// <summary>
        /// Gets or sets the total price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [DataMember]
		public Rate Price { get; set; }
	}
}
