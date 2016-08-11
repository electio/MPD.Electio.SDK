using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class UploadFileHistory
    {
        [DataMember]
        public string UploadedFileReference { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string ErrorFileName { get; set; }

        [DataMember]
        public DateTime DateUploaded { get; set; }
    }
}