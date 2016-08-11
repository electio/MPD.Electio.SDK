using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    /// <summary>
    /// The customs document type
    /// </summary>
    [DataContract]
    [XmlRoot("CustomsDocType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum CustomsDocType : short
    {
        /// <summary>
        /// CN22 Customs document
        /// </summary>
        [EnumMember]
        CN22 = 1,
        /// <summary>
        /// CN23 Customs document
        /// </summary>
        [EnumMember]
        CN23 = 2,

        [EnumMember]
        CommercialInvoice = 3
    }
}