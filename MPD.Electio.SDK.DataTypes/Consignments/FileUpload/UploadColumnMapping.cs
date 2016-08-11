using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class UploadColumnMapping
    {
        [DataMember]
        public int MPDFieldId { get; set; }

        [DataMember]
        public int UploadFileColumnNumber { get; set; }

        [DataMember]
        public string MPDFieldName { get; set; }

        [DataMember]
        public string UploadFileColumnName { get; set; }
    }
}