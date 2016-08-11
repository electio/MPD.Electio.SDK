using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Caching;
using MPD.Electio.SDK.DataTypes.CarrierServiceDirectory;
using MPD.Electio.SDK.DataTypes.Extensions;
using MPD.Electio.SDK.DataTypes.Security.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents an MPD Carrier Service
    /// </summary>
    [DataContract]
    [XmlRoot("MpdCarrierService", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class MpdCarrierService : BaseCacheableEntity, ICacheable
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="MpdCarrierService"/> class.
        /// </summary>
        public MpdCarrierService()
		{
			Journey = new List<Leg>();
		}

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
		public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [DataMember]
		public string Description { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
		public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier reference.
        /// </summary>
        /// <value>
        /// The MPD carrier reference.
        /// </value>
        [DataMember]
		public string MpdCarrierReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the carrier.
        /// </summary>
        /// <value>
        /// The name of the carrier.
        /// </value>
        [DataMember]
		public string CarrierName { get; set; }

        /// <summary>
        /// Gets or sets the carrier account owner.
        /// </summary>
        /// <value>
        /// The carrier account owner.
        /// </value>
        [DataMember]
		public string CarrierAccountOwner { get; set; }

        /// <summary>
        /// Gets or sets the status of this MpdCarrierService
        /// within the Customer's subscription.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        [DataMember]
		public CustomerSubscriptionStatus Status { get; set; }
        
        /// <summary>
        /// Gets or sets the journey (a list of <see cref="Leg">Legs</see> required
        /// to transit the consignment from it's Origin to Destination).
        ///
        /// An international service may be fulfilled by multiple carriers, with the first carrier
        /// transporting the consignment to the point of exit of the origin country and additional carriers
        /// responsible for the onwards journey to the ultimate destination.
        /// </summary>
        /// <value>
        /// The journey.
        /// </value>
        [DataMember]
		public List<Leg> Journey { get; set; }
        
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        [DataMember]
        public MpdCarrierServiceSource Source { get; set; }

        /// <summary>
        /// Gets or sets the type of the MPD Carrier Service.
        /// eg Timed, Scheduled, Pickup, Consolidated etc.
        /// 
        /// This property is a collection of Flags.
        /// Usage:
        /// 
        /// if (service.Type &amp; MpdCarrierServiceType.AhHoc) == MpdCarrierServiceType.AhHoc
        /// ....
        /// ....
        /// 
        /// 
        /// See also <see cref="MpdCarrierServiceExtensions">MpdCarrierServiceExtensions</see> for helper functions.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public Enums.MpdCarrierServiceType Type { get; set; }

        /// <summary>
        /// The default cache duration in minutes for this entity.
        /// </summary>
        /// <returns>int representing minutes to cache for</returns>
        public int DefaultCacheDurationInMinutes()
        {
            return 60;
        }

        [DataMember]
        public bool IsConfigured { get; set; }

    }
}
