using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using MPD.Electio.SDK.DataTypes.Caching;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Security
{
	[DataContract]
    [JsonObject]
    public class SecurityToken : BaseCacheableEntity, ICacheable
    {
        /// <summary>
        /// Gets or sets the access actions.
        /// </summary>
        /// <value>
        /// The access actions.
        /// </value>
        [JsonProperty("accessactions")]
        // ReSharper disable MemberCanBePrivate.Global
        // ReSharper disable UnusedAutoPropertyAccessor.Global
        public AccessActions[] AccessActions { get; set; }

        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        /// <value>
        /// The customer reference.
        /// </value>
        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the account reference.
        /// </summary>
        /// <value>
        /// The account reference.
        /// </value>
        [JsonProperty("accountReference")]
        public string AccountReference { get; set; }

        /// <summary>
        /// Gets or sets the display name of the account.
        /// </summary>
        /// <value>
        /// The display name of the account.
        /// </value>
        [JsonProperty("accountDisplayName")]
        public string AccountDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the display name of the customer.
        /// </summary>
        /// <value>
        /// The display name of the customer.
        /// </value>
        [JsonProperty("customerDisplayName")]
        public string CustomerDisplayName { get; set; }

        /// <summary>
        /// Gets or sets the shipping location restrictions.
        /// </summary>
        /// <value>
        /// The shipping location restrictions.
        /// </value>
        [Obsolete("Gradually phase out and use ShippingLocationWhiteList", false)]
        [JsonProperty("shippingLocationRestrictions")]
        public string[] ShippingLocationRestrictions { get; set; }

        [JsonProperty("shippingLocationWhiteList")]
        public Dictionary<string, string> ShippingLocationWhiteList { get; set; }

        /// <summary>
        /// Indicates whether or not this key is a temporary/assigned token for web users, or is a permanent API key
        /// </summary>
        /// <value>
        ///   <c>true</c> if assigned as a temporary web token; otherwise, <c>false</c>.
        /// </value>
        public bool IsWebToken { get; set; }

        /// <summary>
        /// Defaults the cache duration in minutes.
        /// </summary>
        /// <returns></returns>
        public int DefaultCacheDurationInMinutes()
        {
            return 30;
        }

        /// <summary>
        /// Gets or sets the TimeZoneInfoId
        /// </summary>
        public string TimeZoneInfoId { get; set; }
    }
}
