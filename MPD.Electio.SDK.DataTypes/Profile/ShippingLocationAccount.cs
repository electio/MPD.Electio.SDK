using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Profile
{
    [DataContract]
    [Serializable]
    [XmlRoot("ShippingLocationAccount", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Profile")]
    public class ShippingLocationAccount
    {
        /// <summary>
        /// Gets or sets the account reference.
        /// </summary>
        /// <value>
        /// The account reference.
        /// </value>
        [DataMember]
        public Guid AccountReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the account.
        /// </summary>
        /// <value>
        /// The name of the account.
        /// </value>
        [DataMember]
        public string AccountName { get; set; }
    }
}