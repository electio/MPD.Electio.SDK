using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Rates.Enums;

namespace MPD.Electio.SDK.DataTypes.Rates
{
    [DataContract]
    public abstract class SurchargeBase : ObjectBase
    {
        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        [DataMember]
        public string MpdCarrierServiceReference { get; set; }

        /// <summary>
        /// This is a code we assign to the surcharge
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the currency iso code.
        /// </summary>
        /// <value>
        /// The currency iso code.
        /// </value>
        [DataMember]
        public string CurrencyIsoCode { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        [DataMember]
        public decimal Price { get; set; }
    
        [DataMember]
        public ApplicationType ApplicationType { get; set; }
    }

}

