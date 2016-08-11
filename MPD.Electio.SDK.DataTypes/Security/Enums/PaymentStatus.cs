using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security.Enums
{
    public enum PaymentStatus
    {
        [EnumMember]
        Success = 1,
        [EnumMember]
        Failure = 2,
        [EnumMember]
        Pending = 3
    }
}
