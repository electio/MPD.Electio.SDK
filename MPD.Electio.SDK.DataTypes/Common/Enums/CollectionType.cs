using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    [DataContract]
    [XmlRoot("CollectionType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum CollectionType
    {
        [EnumMember]
        [Obsolete("No longer, wait for it, applicable. ;-)", true)]
        NotApplicable = 0,

        [EnumMember, Display(Name = "Scheduled")]
        Scheduled = 1,

        [EnumMember, Display(Name = "Ad hoc")]
        AdHoc = 2,
    }
}
