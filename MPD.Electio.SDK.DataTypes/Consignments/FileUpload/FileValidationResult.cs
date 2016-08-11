using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class FileValidationResult
    {
        [DataMember]
        public int TotalNumberOfLines { get; set; }

        [DataMember]
        public int InconsistentDataLines { get; set; }

        [DataMember]
        public int InvalidDataLines { get; set; }

        [DataMember]
        public int TotalConsignments { get; set; }

        [DataMember]
        public int TotalPackages { get; set; }

        [DataMember]
        public int TotalItems { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string ErrorFileName { get; set; }
    }

    [DataContract]
    public class FileServiceResponse
    {
        [DataMember]
        public bool Success { get; set; }
    }
}
