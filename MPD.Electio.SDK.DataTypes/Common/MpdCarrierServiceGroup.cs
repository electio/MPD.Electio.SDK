using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [Serializable]
    [XmlRoot("MpdCarrierServiceGroup", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class MpdCarrierServiceGroup
	{
		public MpdCarrierServiceGroup()
		{
			MpdCarrierServiceProfiles = new List<MpdCarrierServiceProfile>();
		}

		[DataMember]
		public string Reference { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public Guid CustomerReference { get; set; }

		[DataMember]
		public List<MpdCarrierServiceProfile> MpdCarrierServiceProfiles { get; set; }

		[DataMember]
		public bool IsEnabled { get; set; }
	}
}
