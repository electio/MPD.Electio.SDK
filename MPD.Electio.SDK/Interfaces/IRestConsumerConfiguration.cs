using System.Collections.Generic;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.Interfaces
{
	///<summary>Per-user configuration for a given Rest Consumer</summary>
	public interface IRestConsumerConfiguration
	{
        /// <summary>
        /// The base URL for the endpoint. This should be loaded from a config
        /// section under applicationSettings/MPD.Core.Infrastructure.RestConsumer.Properties.Settings
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        string BaseUrl { get; }

        /// <summary>
        /// Custom Serializer settings that should be used for this endpoint
        /// </summary>
        /// <value>
        /// The serializer settings.
        /// </value>
        JsonSerializerSettings SerializerSettings { get; }

        /// <summary>
        /// The authentication token for the current user
        /// </summary>
        /// <value>
        /// The authentication token.
        /// </value>
        string AuthenticationToken { get; }

        /// <summary>
        /// Any additional settings that should be used for a non-standard implementation of the RestConsumer
        /// </summary>
        /// <value>
        /// The additional options.
        /// </value>
        Dictionary<string, string> AdditionalOptions { get; }
	}
}
