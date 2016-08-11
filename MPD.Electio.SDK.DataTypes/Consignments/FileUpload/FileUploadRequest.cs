using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [MessageContract, DataContract]
    public class FileUploadRequest : IDisposable
    {
        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public string FileName { get; set; }

        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public long Length { get; set; }

        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public string CustomerReference { get; set; }

        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public bool GroupPackagesIntoConsignments { get; set; }

        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public bool HasHeader { get; set; }

        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public bool HasFieldsEnclosedInQuotes { get; set; }

        [MessageHeader(MustUnderstand = true)]
        [DataMember]
        public bool IsItemLevelData { get; set; }

        [MessageBodyMember(Order = 1)]
        [DataMember]
        public System.IO.Stream FileByteStream { get; set; }

        public void Dispose()
        {
            if (FileByteStream != null)
            {
                FileByteStream.Close();
                FileByteStream = null;
            }
        }   
    }
}
