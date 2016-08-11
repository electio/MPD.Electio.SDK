using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [XmlRoot("CarrierService", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class CarrierService
	{
		[DataMember]
		public string Reference { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string CarrierReference { get; set; }
        
        [DataMember]
        public string CarrierName { get; set; }

        [DataMember]
        public bool IsDropOff { get; set; }

        [DataMember]
        public bool IsPickUp { get; set; }
        [DataMember]
        public bool IsTimed { get; set; }
	}
}
