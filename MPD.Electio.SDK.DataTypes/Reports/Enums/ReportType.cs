using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Reports.Enums
{
    public enum ReportType
    {
        [EnumMember]
        Unknown = 0,

        [EnumMember]
        Custom = 1,

        [EnumMember]
        ConsignmentStates = 2
    }
}