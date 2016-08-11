using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ConsignmentAuditMessageCategory", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments.Enums")]
    public enum ConsignmentAuditMessageCategory
	{
		[EnumMember]
		None = 0,

		[EnumMember]
		Tracking = 1,

		[EnumMember]
		ConsignmentLifecycle = 2,

		[EnumMember]
		Labels = 3
	}
}
