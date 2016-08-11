using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    /// <summary>
    /// The VAT rate type - standard, reduced or zero (ie tax not applicable).
    /// </summary>
    [DataContract]
    [XmlRoot("VatRateType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum VatRateType : short
    {
        /// <summary>
        /// Standard rate tax
        /// </summary>
        [EnumMember]
        Standard,
        /// <summary>
        /// Reduced rate tax
        /// </summary>
        [EnumMember]
        Reduced,
        /// <summary>
        /// Tax not applicable
        /// </summary>
        [EnumMember]
        Zero
    }
}
