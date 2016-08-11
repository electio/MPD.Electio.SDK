using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Rates.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Rates
{
    [DataContract]
    public class CostItem
    {
        /// <summary>
        /// Gets or sets the reference/code of the cost item.
        /// </summary>
        [DataMember]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the calculated cost.
        /// </summary>
        /// <value>
        /// The calculated cost.
        /// </value>
        [DataMember]
        public decimal CalculatedCost { get; set; }

        /// <summary>
        /// Gets or sets the type of the cost item.
        /// Simply determines if the cost is delivery charge or surcharge.
        /// </summary>
        /// <value>
        /// The type of the cost item.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public CostItemType CostItemType { get; set; }
    }
}
