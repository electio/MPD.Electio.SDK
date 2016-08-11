using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class FileUploadInfo
    {
        [DataMember]
        public bool HasHeader { get; set; }

        [DataMember]
        public bool IsItemLevelData { get; set; }

        [DataMember]
        public bool GroupPackagesIntoConsignments { get; set; }

        [DataMember]
        public int LineCount { get; set; }

        [DataMember]
        public bool HasBeenProcessed { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string FileReference { get; set; }

        [DataMember]
        public DateTime UploadedOn { get; set; }

        [DataMember]
        public string ErrorFileName { get; set; }

        [DataMember]
        public List<UploadColumnMapping> Mappings { get; set; }

    }
}