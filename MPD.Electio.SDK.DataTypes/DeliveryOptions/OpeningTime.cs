using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// A start and end time window for opening hours
    /// <remarks>
    /// Used by, for instance, opening hours for a drop off location such as a shop
    /// </remarks>
    /// </summary>
    [DataContract]
    [XmlRoot("OpeningTime", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class OpeningTime : WindowBase { }
}