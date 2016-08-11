using System.Runtime.Serialization;
using System.ServiceModel;
namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [MessageContract, DataContract]
    public class FileUploadResponse
    {
        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public bool Success { get; set; }

        [MessageHeader]
        [DataMember]
        public string FileReference { get; set; }

        [MessageHeader]
        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
