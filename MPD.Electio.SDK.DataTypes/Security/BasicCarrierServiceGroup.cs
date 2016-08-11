using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security
{
    [Serializable]
    [DataContract]
    public class BasicCarrierServiceGroup
    {
        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public Guid CustomerReference { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}