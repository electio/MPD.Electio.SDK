using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class UpdateFileMappingsRequest
    {
        [DataMember]
        public string CustomerReference { get; set; }

        [DataMember]
        public string UploadFileReference { get; set; }

        [DataMember]
        public List<UploadColumnMapping> UploadColumnMappings { get; set; }
    }
}