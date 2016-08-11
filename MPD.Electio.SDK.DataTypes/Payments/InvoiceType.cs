using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Payments
{
    [DataContract]
    public enum InvoiceType
    {
        [EnumMember]
        Label = 0,

        [EnumMember]
        CarrierServices = 1,

        [EnumMember]
        All = 2
    }
}
