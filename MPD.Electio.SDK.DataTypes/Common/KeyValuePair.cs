using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [Serializable]
    [DataContract]
    [XmlRoot("KeyValuePair", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public struct KeyValuePair<TK, TV>
    {
        [DataMember]
        public TK Key { get; set; }
        [DataMember]
        public TV Value { get; set; }
    }
}
