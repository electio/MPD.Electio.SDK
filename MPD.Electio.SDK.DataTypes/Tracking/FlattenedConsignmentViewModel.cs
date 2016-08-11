using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MPD.Electio.SDK.DataTypes.Tracking
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class FlattenedConsignmentViewModel
    {
        [DataMember]
        public string ConsignmentReferenceForAllLegsAssignedByMpd { get; set; }

        [DataMember]
        public List<FlattenedPackageViewModel> TrackedPackages { get; set; }

        public FlattenedConsignmentViewModel()
        {
            TrackedPackages = new List<FlattenedPackageViewModel>();
        }
    }
}
