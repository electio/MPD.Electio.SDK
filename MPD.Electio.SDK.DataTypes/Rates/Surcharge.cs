using System;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Rates.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Rates
{
    [DataContract]
    public class Surcharge : SurchargeBase
    {

        /// <summary>
        /// Additive/Variable
        /// Additive is a fixed or calculated amount that is added on to the price.
        /// Variable represents a percentage surcharge that is calculated and then added to the final price.
        /// 
        /// eg Variable surcharge with an amount of 0.4 means add 40%
        /// Additive surcharge with an amount of 0.4 means add 40p
        /// </summary>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public SurchargeType Type { get; set; }

        /// <summary>
        /// e.g. kg if the class is 'out of gauge' and subclass is 'too heavy'; can be null, if the class is 'Special Day Delivery'
        /// </summary>
        [DataMember]
        public int DimensionUnitId { get; set; }

        [DataMember]
        public string Dimension { get; set; }

        /// <summary>
        /// This field is only used for variable surcharges
        /// </summary>
        [DataMember]
        public bool AppliesToBase { get; set; }

        /// <summary>
        /// This field is only used for variable surcharges
        /// </summary>
        [DataMember]
        public bool AppliesToBaseOnly { get; set; }

        /// <summary>
        /// In units
        /// </summary>
        [DataMember]
        public decimal DimensionIntervalStart { get; set; }

        /// <summary>
        /// In units
        /// </summary>
        [DataMember]
        public decimal? DimensionIntervalEnd { get; set; }

        [DataMember]
        public decimal? IncrementalUnitFactor { get; set; }

        [DataMember]
        public decimal? IncrementalUnitPrice { get; set; }

        /// <summary>
        /// Applies to variable only
        /// </summary>
        [DataMember]
        public decimal? MinimumPrice { get; set; }

        /// <summary>
        /// Applies to variable only
        /// </summary>
        [DataMember]
        public decimal? MaximumPrice { get; set; }

        /// <summary>
        /// Date and time this surcharge is valid from
        /// </summary>
        [DataMember]
        public DateTime ValidFrom { get; set; }

        /// <summary>
        /// Date and time this surcharge is valid to
        /// </summary>
        [DataMember]
        public DateTime? ValidTo { get; set; }

        /// <summary>
        /// Gets or sets the type of the application - Standard or Retrospective
        /// </summary>
        /// <value>
        /// The type of the application.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ApplicationType ApplicationType { get; set; }

        /// <summary>
        /// Gets or sets the calcuation model.
        /// </summary>
        /// <value>
        /// The calcuation model.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public CalculationModel CalculationModel { get; set; }

        /// <summary>
        /// Gets or sets the vat rate identifier.
        /// </summary>
        /// <value>
        /// The vat rate identifier.
        /// </value>
        [DataMember]
        public int VatRateId { get; set; }

    }
}
