using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Caching;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [Serializable]
    [XmlRoot("MpdCarrierServiceProfile", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class MpdCarrierServiceProfile : BaseCacheableEntity, ICacheable
	{
		[DataMember]
		public bool IsEnabled { get; set; }

		[DataMember]
		public Guid CustomerReference { get; set; }

		[DataMember]
		public MpdCarrierService MpdCarrierService { get; set; }

		[DataMember]
		public List<DimensionRestriction> DimensionRestrictions { get; set; }

		[DataMember]
		public List<DomesticLocationRestriction> DomesticLocationRestrictions { get; set; }

		[DataMember]
		public List<InternationalLocationRestriction> InternationalLocationRestrictions { get; set; }

		[DataMember]
		public CompensationAndValue CompensationAndValue { get; set; }

	    public int DefaultCacheDurationInMinutes()
	    {
	        return 60;
	    }
	}
}
