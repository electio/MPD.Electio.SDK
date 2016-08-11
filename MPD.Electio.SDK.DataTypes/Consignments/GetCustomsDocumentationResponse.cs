using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Holds information as required for custom declaration documentation.
    /// </summary>
    [DataContract]
    [XmlRoot("GetCustomsDocumentationResponse", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class GetCustomsDocumentationResponse
	{
        [DataMember]
        public Dictionary<string, byte[]> CommercialInvoiceDocuments { get; set; }
        [DataMember]
        public Dictionary<string, byte[]> CN22Documents { get; set; }
        [DataMember]
        public Dictionary<string, byte[]> CN23Documents { get; set; }

        public GetCustomsDocumentationResponse()
        {
            CommercialInvoiceDocuments = new Dictionary<string, byte[]>();
            CN22Documents = new Dictionary<string, byte[]>();
            CN23Documents = new Dictionary<string, byte[]>();
        }
    }
}
