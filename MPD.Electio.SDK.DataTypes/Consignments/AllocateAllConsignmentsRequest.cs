using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("AllocateAllConsignmentsRequest", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class AllocateAllConsignmentsRequest
    {

        /// <summary>
        /// Gets or sets the ship by date.
        /// </summary>
        /// <value>
        /// The ship by date.
        /// </value>
        [DataMember]
        public DateTime ShipByDate { get; set; }

        /// <summary>
        /// Gets or sets the shipping location reference.
        /// </summary>
        /// <value>
        /// The shipping location reference.
        /// </value>
        [DataMember]
        public string ShippingLocationReference { get; set; }
    }
}
