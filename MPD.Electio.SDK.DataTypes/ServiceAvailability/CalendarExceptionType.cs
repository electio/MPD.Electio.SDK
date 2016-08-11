using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.ServiceAvailability
{
    [DataContract]
    public enum CalendarExceptionType
    {
        [EnumMember]
        ReScheduled = 0,

        [EnumMember]
        Cancelled = 1
    }
}