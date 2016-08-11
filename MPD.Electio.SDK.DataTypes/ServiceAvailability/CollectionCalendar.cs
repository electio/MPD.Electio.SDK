using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MPD.Electio.SDK.DataTypes.ServiceAvailability
{
	[DataContract]
	public class CollectionCalendar
	{
        public CollectionCalendar()
        {
            ApplicableMpdCarrierServices = new List<string>();
        }

        [DataMember]
        public string MpdCarrierReference { get; set; }

        [DataMember]
        public string ShippingLocationReference { get; set; }

        [DataMember]
		public List<CalendarRule> CalendarRules { get; set; }

		[DataMember]
		public List<CalendarException> CalendarExceptions { get; set; }

        public List<string> ApplicableMpdCarrierServices { get; set; }
    }
}
