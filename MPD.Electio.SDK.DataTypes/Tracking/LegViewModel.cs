using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Tracking
{
	[DataContract]
    public class LegViewModel
    {
        public LegViewModel()
        {
            Events = new List<EventViewModel>();
        }

		[DataMember]
        public string CarrierServiceName { get; set; }

		[DataMember]
        public List<EventViewModel> Events { get; set; }
    }
}