using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    /// <summary>
    /// Defines the purpose of the Consignment Contact Address
    /// </summary>
    [DataContract]
    [XmlRoot("ConsignmentAddressType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    [Flags]
    public enum ConsignmentAddressType
    {
        /// <summary>
        /// Origin contact address.
        /// This is the ORIGIN of the consignment as far as the carrier is concerned
        /// </summary>
        [EnumMember]
        Origin = 1,
        /// <summary>
        /// Destination contact address.
        /// This is the final desintation of the consignment as far as the carrier is concerned.
        /// </summary>
        [EnumMember]
        Destination = 2,
        /// <summary>
        /// The return address of the contact address.
        /// This is where the consignment will/could be sent if say the consignment could not be delivered.
        /// </summary>
        [EnumMember]
        Return = 4,
        /// <summary>
        /// The contact address of the sender.
        /// E.g. For a drop off, this could be the contact address of the party dropping off the consignment at the 'Origin' address
        /// </summary>
        [EnumMember]
        Sender = 8,
        /// <summary>
        /// The receiver of the consignment
        /// E.g. For a pick up, this could be the party who picks up the consingment from it's 'Destination' address
        /// </summary>
        [EnumMember]
        Recipient = 16,
        /// <summary>
        /// This is the party liable for the payment of duties on the consignment.
        /// In the case of a multi-leg shipment, this could be the carrier.
        /// </summary>
        [EnumMember]
        Importer = 32
    }
}