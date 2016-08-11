using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security.Enums
{
    [DataContract]
    public enum TokenTypeEnum
    {
        [EnumMember]
        PasswordReset = 0,
        [EnumMember]
        InviteAccount = 1,
        [EnumMember]
        AccountActivation = 2
    }
}