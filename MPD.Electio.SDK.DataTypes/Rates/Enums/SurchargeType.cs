using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Rates.Enums
{
    public enum SurchargeType : short
    {
        [EnumMember]
        Additive,
        [EnumMember]
        Variable
    }
}
