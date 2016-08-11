using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.DeliveryOptions
{
    /// <summary>
    /// Represents the delivery window in terms of a start and end time
    /// </summary>
    [DataContract]
    [XmlRoot("DeliveryWindow", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class DeliveryWindow : WindowBase { }
}