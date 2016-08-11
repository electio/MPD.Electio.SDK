using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Tracking
{
	[DataContract]
    public class ConsignmentViewModel
    {
        public ConsignmentViewModel()
        {
            TrackedPackages = new List<PackageViewModel>();
        }

		[DataMember]
        public string ConsignmentReferenceForAllLegsAssignedByMpd { get; set; }

		[DataMember]
        public List<PackageViewModel> TrackedPackages { get; set; }
    }
}