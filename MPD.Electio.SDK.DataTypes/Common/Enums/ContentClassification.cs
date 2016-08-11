using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
	///<summary>Classification for the contents of a package or an individual item</summary>
	[Flags]
    [DataContract]
    [XmlRoot("ContentClassification", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum ContentClassification
	{
		NotSpecified	= (1 << 0),
		Unrestricted	= (1 << 1),
		Dangerous		= (1 << 2),
		Restricted		= (1 << 3),
		Liquid			= (1 << 4)
	}
}
