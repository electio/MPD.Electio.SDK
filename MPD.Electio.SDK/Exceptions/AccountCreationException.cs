using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.Exceptions
{
    [Serializable]
    [DataContract]
    [XmlRoot("AccountCreationException", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.DeliveryOptions")]
    public class AccountCreationException : SerializableException
    {
        public AccountCreationException()
        {
            
        }

        public AccountCreationException(Exception exception) : base(exception)
        {
            
        }
    }
}