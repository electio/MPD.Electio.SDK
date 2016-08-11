using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    [DataContract]
    [XmlRoot("DimensionType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum DimensionType : short
	{
		[EnumMember]
		Length = 1,

		[EnumMember]
		Girth = 2,

		[EnumMember]
		AbsoluteWeight = 3,
        
		[EnumMember]
		CombinedDimensions = 4
	}
}
