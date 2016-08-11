using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;


namespace MPD.Electio.SDK.Internal.DataTypes.Common
{
    [DataContract]
    [XmlRoot("CustomerCarrierConfiguration", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class CustomerCarrierConfiguration
    {
        [DataMember]
        public Guid CustomerReference { get; set; }

        [DataMember]
        public List<Configuration> Configurations { get; set; }
    }
}
