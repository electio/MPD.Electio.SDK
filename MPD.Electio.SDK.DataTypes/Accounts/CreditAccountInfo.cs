using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Accounts
{
    /// <summary>
    /// Information relating to a Customer's Credit Account
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("CreditAccountInfo", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Accounts")]
    public class CreditAccountInfo
	{
        /// <summary>
        /// Gets or sets the credit limit in the default currency of the customer.
        /// </summary>
        /// <value>
        /// The credit limit.
        /// </value>
        [DataMember]
		public virtual decimal CreditLimit { get; set; }

        /// <summary>
        /// Gets or sets the payment terms - number of days between generation of 
        /// an invoice and payment falling due.
        /// </summary>
        /// <value>
        /// The payment terms.
        /// </value>
        [DataMember]
		public virtual int PaymentTerms { get; set; }
	}
}
