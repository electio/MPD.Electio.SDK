using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Reports.Enums
{
    public enum ReportLevel
    {
        [EnumMember]
        Unknown = 0,

        [EnumMember]
        Consignment = 1,

        [EnumMember]
        Package = 2
    }
}