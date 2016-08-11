using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments.FileUpload
{
    [DataContract]
    public class UploadHeaderColumn
    {
        [DataMember]
        public int ColumnNumber { get; set; }

        [DataMember]
        public string ColumnName { get; set; }
    }
}