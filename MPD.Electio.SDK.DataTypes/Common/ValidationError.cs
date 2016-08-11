using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    public class ValidationError
    {

        public ValidationError()
        {
            
        }
       
        public ValidationError(string message)
        {
            Message = message;
        }

        [DataMember]
        public string Message { get; set; }
    }
}
