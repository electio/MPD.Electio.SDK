using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Profile
{
    /// <summary>
    /// A Shipping Location - factory, warehouse, store or similar.
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.DataTypes.Common.Address" />
    [DataContract]
    [Serializable]
    [XmlRoot("ShippingLocation", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Profile")]
    public class ShippingLocation : Address
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the unique reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public string Reference { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the type of the shipping location.
        /// </summary>
        /// <value>
        /// The type of the shipping location.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        [JsonConverter(typeof(StringEnumConverter))]
        public ShippingLocationType ShippingLocationType { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [default location for returns].
        /// </summary>
        /// <value>
        /// <c>true</c> if [default location for returns]; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public bool DefaultLocationForReturns { get; set; }
        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        /// <value>
        /// The customer reference.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always)]
        public Guid CustomerReference { get; set; }
        /// <summary>
        /// Gets or sets the linked accounts.
        /// </summary>
        /// <value>
        /// The linked accounts.
        /// </value>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<ShippingLocationAccount> LinkedAccounts { get; set; }

        /// <summary>
        /// Returns the default duration to use when caching a <see cref="ShippingLocation"/>
        /// </summary>
        /// <returns></returns>
        public override int DefaultCacheDurationInMinutes()
        {
            return 60;
        }
    }
}
