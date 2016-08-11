using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class FileImportResult
    {
        [DataMember]
        public string UploadBatchReference { get; set; }
        [DataMember]
        public int PackagesCreated { get; set; }
        [DataMember]
        public int PackageItemsCreated { get; set; }
        [DataMember]
        public int ConsignmentsCreated { get; set; }
    }
}