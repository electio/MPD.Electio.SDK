using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Rates.Enums
{
    [DataContract]
    public enum CostItemType
    {
        Unknown = 0,

        [EnumMember, Display(Name = "Delivery charge")]
        DeliveryCharge = 1,

        [EnumMember, Display(Name = "Surcharge")]
        Surcharge = 2
    }
}
