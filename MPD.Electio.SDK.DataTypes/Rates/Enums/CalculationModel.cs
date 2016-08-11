using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Rates.Enums
{
    [DataContract]
    public enum CalculationModel : short
    {
        [EnumMember]
        Fixed = 0,
        [EnumMember]
        Calculated = 1
    }
}
