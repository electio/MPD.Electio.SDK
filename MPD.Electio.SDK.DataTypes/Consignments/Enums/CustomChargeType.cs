using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    /// <summary>
    /// The type of charges applied to a package.
    /// </summary>
    [DataContract]
    [XmlRoot("CustomChargeType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum CustomChargeType
    {
        [EnumMember]
        Others = 0,
        [Display(Name = "Sales Tax")]
        [EnumMember]
        SalesTax = 1,
        [EnumMember]
        Duty = 2,
        [EnumMember]
        Excise = 3,
        [EnumMember]
        Insurance = 4,
        [Display(Name = "Discount/Rebate")]
        [EnumMember]
        DisountRebate = 5

    }
}