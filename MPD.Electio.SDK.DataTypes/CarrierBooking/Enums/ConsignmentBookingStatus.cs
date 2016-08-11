using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.CarrierBooking.Enums
{
    [DataContract]
    [XmlRoot("ConsignmentBookingStatus", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.CarrierBooking")]
    public enum ConsignmentBookingStatus
    {
        /// <summary>
        /// The allocated
        /// </summary>
        [EnumMember]
        Allocated = 0, //Awaiting for it to be processed (Book Collection)
        /// <summary>
        /// The manifested
        /// </summary>
        [EnumMember]
        Manifested = 1, //Uploaded to the carrier
        /// <summary>
        /// The failed to allocate
        /// </summary>
        [EnumMember]
        FailedToAllocate = 2, //Failed or any other errors
        /// <summary>
        /// The booked
        /// </summary>
        [EnumMember]
        Booked = 3, //After you have received a response
        /// <summary>
        /// The cancelled
        /// </summary>
        [EnumMember]
        Cancelled = 4,
        /// <summary>
        /// The awaiting manifest
        /// </summary>
        [EnumMember]
        AwaitingManifest = 5
    }
}