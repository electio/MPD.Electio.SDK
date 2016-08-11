using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security.Enums
{
    public enum PaymentCycle
    {
        [EnumMember]
        Day,
        [EnumMember]
        Week,
        [EnumMember]
        Month,
        [EnumMember]
        Year
    }
}
