using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Tracking
{
	[DataContract]
    public class PackageViewModel
    {
        public PackageViewModel()
        {
            Legs = new List<LegViewModel>();
        }

		[DataMember]
        public string PackageReferenceForAllLegsAssignedByMpd { get; set; }

		[DataMember]
        public List<LegViewModel> Legs { get; set; }
    }
}