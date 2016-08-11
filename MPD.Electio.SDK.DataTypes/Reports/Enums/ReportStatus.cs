using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Reports.Enums
{
    public enum ReportStatus
    {
        [EnumMember]
        None = 0,
        [EnumMember]
        Requested = 1,
        [EnumMember]
        Processing = 2,
        [EnumMember]
        Generated = 3
    }
}
