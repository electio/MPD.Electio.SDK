using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class MPDUploadField
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public bool IsItemLevel { get; set; }

        [DataMember]
        public bool IsRequired { get; set; }

        [DataMember]
        public string DataType { get; set; }
    }
}