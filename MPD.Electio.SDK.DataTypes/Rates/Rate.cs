using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Rates
{
    /// <summary>
    /// Represents a Price or Cost, including Net and Gross prices, VAT (tax) rates and amount
    /// and Currency.
    /// </summary>
    [DataContract]
    public class Rate
    {
        /// <summary>
        /// Gets or sets the net price - the price exclusive of any tax (UK VAT or similar)
        /// </summary>
        /// <value>
        /// The net price.
        /// </value>
        [DataMember]
        public decimal? Net { get; set; }

        /// <summary>
        /// Gets or sets the total gross price - Net Price + taxes.
        /// </summary>
        /// <value>
        /// The gross price.
        /// </value>
        [DataMember]
        public decimal? Gross { get; set; }

        /// <summary>
        /// Gets or sets the vat rate.
        /// </summary>
        /// <value>
        /// The vat rate.
        /// </value>
        [DataMember]
        public VatRate VatRate { get; set; }

        /// <summary>
        /// Gets or sets the tax amount.
        /// </summary>
        /// <value>
        /// The vat amount.
        /// </value>
        [DataMember]
        public decimal? VatAmount { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>
        /// The currency.
        /// </value>
        [DataMember]
        public Currency Currency { get; set; }
    }
}
