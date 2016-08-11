using System.Collections.Generic;
using MPD.Electio.SDK.Interfaces;
using Newtonsoft.Json;

namespace MPD.Electio.SDK
{
    /// <summary>
    /// Per-user configuration for a given Rest Consumer
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Interfaces.IRestConsumerConfiguration" />
    public class RestConsumerConfiguration : IRestConsumerConfiguration
	{
        /// <summary>
        /// The base URL for the endpoint. This should be loaded from a config
        /// section under applicationSettings/MPD.Core.Infrastructure.RestConsumer.Properties.Settings
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        public string BaseUrl { get; set; }
        /// <summary>
        /// Custom Serializer settings that should be used for this endpoint
        /// </summary>
        /// <value>
        /// The serializer settings.
        /// </value>
        public JsonSerializerSettings SerializerSettings { get; set; }
        /// <summary>
        /// The authentication token for the current user
        /// </summary>
        /// <value>
        /// The authentication token.
        /// </value>
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Any additional settings that should be used for a non-standard implementation of the RestConsumer
        /// </summary>
        /// <value>
        /// The additional options.
        /// </value>
        public Dictionary<string, string> AdditionalOptions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestConsumerConfiguration" /> class.
        /// </summary>
        public RestConsumerConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestConsumerConfiguration" /> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="authenticationToken">The authentication token.</param>
        public RestConsumerConfiguration(string baseUrl, string authenticationToken)
		{
			BaseUrl = baseUrl;
			AuthenticationToken = authenticationToken;
		}
	}
}
