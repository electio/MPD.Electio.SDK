using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.CarrierServiceDirectory
{
    /// <summary>
    /// Defines the source/owner of the MPD Carrier Service.
    /// </summary>
    [DataContract]
    [XmlRoot("MpdCarrierServiceSource", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.CarrierServiceDirectory")]
    public enum MpdCarrierServiceSource
	{
        [EnumMember]
        None = 0,

        /// <summary>
        /// Internal - Owned by Electio
        /// </summary>
        [EnumMember]
		Internal = 1,

        /// <summary>
        /// External - Owned by the Customer
        /// </summary>
        [EnumMember]
		External = 2
	}
}
