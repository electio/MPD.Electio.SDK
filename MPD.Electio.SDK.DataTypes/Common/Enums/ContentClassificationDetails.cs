using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
	///<summary>Additional details for the contents that require a classification</summary>
	[Flags]
    [DataContract]
    [XmlRoot("ContentClassificationDetails", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum ContentClassificationDetails : ulong
	{
		/*	This enum is hard limited to a max of 65 flags so (1UL << 65) is the same as (1UL << 1). 
		 * If we need more than that we need a different solution. */
		NotSpecified			= (1UL << 00),

		Explosive				= (1UL << 01),
		Flammable				= (1UL << 02),
		Toxic					= (1UL << 03),

		Aerosols				= (1UL << 04),
		Alcohol					= (1UL << 05),
		Batteries				= (1UL << 06),
		Electronics				= (1UL << 07),
		Guns					= (1UL << 08),
		Lighters				= (1UL << 09),
		NailVarnish				= (1UL << 10),
		PerfumeOrAftershave		= (1UL << 11),
		Medicine				= (1UL << 12),
		LiveAnimals				= (1UL << 13),
	}
}
