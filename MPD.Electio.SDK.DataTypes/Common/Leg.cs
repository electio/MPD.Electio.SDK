using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using MPD.Electio.SDK.DataTypes.Rates;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents a leg within the journey.
    /// </summary>
    [DataContract]
    [XmlRoot("Leg", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public sealed class Leg
	{
        /// <summary>
        /// Gets or sets the stage of this leg within a journey
        /// </summary>
        /// <value>
        /// The journey stage.
        /// </value>
        [DataMember]
		public int JourneyStage { get; set; }

        /// <summary>
        /// Gets or sets the carrier service fulfilling this leg of a journey.
        /// </summary>
        /// <value>
        /// The carrier service.
        /// </value>
        [DataMember]
		public CarrierService CarrierService { get; set; }

        /// <summary>
        /// Gets or sets the carrier account reference.
        /// </summary>
        /// <value>
        /// The carrier account reference.
        /// </value>
        [DataMember]
        public string CarrierAccountReference { get; set; }

        /// <summary>
        /// Gets or sets the delivery hub, the destination for this leg
        /// of the journey.
        ///<remarks>
        /// This value will be null for the final leg of the journey.
        /// </remarks>
        /// </summary>
        /// <value>
        /// The delivery hub.
        /// </value>
        [DataMember]
		public Hub DeliveryHub { get; set; }

        /// <summary>
        /// Gets or sets the cost items applicable to this leg.
        ///
        /// The cost items are the total costs for carriage by the carrier
        /// for this leg of the journey, including the base cost and any additional
        /// surcharges.
        /// </summary>
        /// <value>
        /// The cost items.
        /// </value>
        [DataMember]
		public List<CostItem> CostItems { get; set; }

        /// <summary>
        /// Gets or sets the volumetric parcel weights applicable to this carrier service and used when
        /// calculating costs/prices.
        /// </summary>
        /// <value>
        /// The volumetric parcel weight.
        /// </value>
        [DataMember]
		public List<VolumetricWeight> VolumetricParcelWeight { get; set; }

        /// <summary>
        /// Gets or sets the type of the collection.
        /// </summary>
        /// <value>
        /// The type of the collection.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public CollectionType CollectionType { get; set; }

	}
}
