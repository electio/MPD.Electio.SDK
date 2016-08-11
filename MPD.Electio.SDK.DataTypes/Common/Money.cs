using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Rates;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents a monetary value in a given currency.
    /// See also <see cref="Rate"/>
    /// </summary>
    [DataContract]
    [XmlRoot("Money", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public sealed class Money
	{
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        [DataMember]
		public decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [DataMember]
		public Currency Currency { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class.
        /// </summary>
        public Money() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Money"/> class.
        /// </summary>
        /// <param name="currency">The currency.</param>
        /// <param name="amount">The amount.</param>
        public Money(Currency currency, decimal amount)
		{
			Amount = amount;
			Currency = currency;
		}

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
		{
			return Amount.ToString("0.00 ") + Currency.Iso4217AlphaCode;
		}
	}
}
