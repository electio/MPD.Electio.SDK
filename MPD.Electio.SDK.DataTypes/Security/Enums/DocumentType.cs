using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security.Enums
{
    public enum DocumentType
    {
        [EnumMember]
        Invoice = 1,
        [EnumMember]
        CreditNote = 2
    }
}
