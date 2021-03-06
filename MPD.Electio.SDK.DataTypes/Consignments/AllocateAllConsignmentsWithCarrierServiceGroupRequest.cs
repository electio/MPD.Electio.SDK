﻿using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("AllocateAllConsignmentsWithServiceGroupRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class AllocateAllConsignmentsWithServiceGroupRequest : AllocateAllConsignmentsRequest
    {
        /// <summary>
        /// Gets or sets the MPD carrier service group reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service group reference.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceGroupReference { get; set; }
    }
}
