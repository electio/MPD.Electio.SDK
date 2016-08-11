using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Rates.Enums
{
    [DataContract]
    public enum ApplicationType : short
    {
        Unknown = 0,
        [EnumMember]
        Standard = 1,
        [EnumMember]
        Retrospective = 2
    }
}
