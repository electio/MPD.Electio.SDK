using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    /// <summary>
    /// Defines the commodity categories available for custom declaration documents
    /// </summary>
    [Flags]
    [DataContract]
    [XmlRoot("CategoryType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum CategoryType
    {
        [EnumMember]
        Gift = 1,
        [EnumMember]
        CommercialSample = 2,
        [EnumMember]
        Documents = 4,
        [EnumMember]
        Other = 8,
        /// <summary>
        /// Available ONLY on CN23 declaration forms
        /// </summary>
        [EnumMember]
        ReturnedGoods = 16
    }
}