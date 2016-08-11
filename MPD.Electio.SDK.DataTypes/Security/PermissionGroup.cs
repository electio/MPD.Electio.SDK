using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security
{
    [DataContract]
    public class PermissionGroup
    {
        [DataMember]
        public string Key { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Permission> Permissions { get; set; }

        [DataMember]
        public Access Access { get; set; }
    }
}