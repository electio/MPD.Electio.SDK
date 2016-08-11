using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.CarrierServiceDirectory
{
    /// <summary>
    /// The Type of Mpd Carrier Service - Scheduled or Ad-Hoc
    /// </summary>
    [DataContract]
    [XmlRoot("MpdCarrierServiceType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.CarrierServiceDirectory")]
    public enum MpdCarrierServiceType
    {
        /// <summary>
        /// A scheduled collection, pre-arranged between the Customer and the Carrier
        /// </summary>
        [EnumMember]
		Scheduled = 1,

        /// <summary>
        /// An AdHoc collection
        /// </summary>
        [EnumMember]
		AdHoc = 2
	}
}
