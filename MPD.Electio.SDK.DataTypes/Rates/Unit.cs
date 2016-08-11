using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Rates
{
    [DataContract]
    public class Unit : ObjectBase
    {
        [DataMember]
        public int Id { get; set; }
    }
}
