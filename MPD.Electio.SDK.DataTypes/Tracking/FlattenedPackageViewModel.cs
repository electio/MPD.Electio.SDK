using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Tracking
{
    [DataContract]
    public class FlattenedPackageViewModel
    {
        [DataMember]
        public string PackageReferenceForAllLegsAssignedByMpd { get; set; }

        [DataMember]
        public List<FlattenedEventViewModel> Events { get; set; }

        public FlattenedPackageViewModel()
        {
            Events = new List<FlattenedEventViewModel>();
        }
    }
}