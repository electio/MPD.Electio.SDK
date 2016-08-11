using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    [Obsolete("Switch to MPD.Electio.SDK.Internal.DataTypes.CarrierBooking.Enums.ConsignmentBookingStatus", true)]
    public enum CarrierConsignmentBookingStatus
    {
        [EnumMember]
        AwaitingManifest = 0,
        [EnumMember]
        Manifested = 1,
        [EnumMember]
        Pending = 2,
        [EnumMember]
        Booked = 3,
        [EnumMember]
        Cancelled = 4,
    }
}
