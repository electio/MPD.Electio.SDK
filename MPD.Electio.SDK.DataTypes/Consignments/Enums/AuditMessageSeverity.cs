using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.Enums
{
    [DataContract]
    [XmlRoot("AuditMessageSeverity", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum AuditMessageSeverity
	{
		[EnumMember]
		None = 0,

		[EnumMember]
		Low = 1,

		[EnumMember]
		Medium = 2,

		[EnumMember]
		High = 3,

		[EnumMember]
		Critical = 4
	}
}
