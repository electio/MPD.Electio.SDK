using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Extensions;
using MPD.Electio.SDK.Error;
using MPD.Electio.SDK.Interfaces;
using Newtonsoft.Json;

namespace MPD.Electio.SDK
{
    /// <summary>
    /// Concrete implementation of IRestConsumer.
    /// </summary>
    /// <seealso cref="IRestConsumer" />
    public class RestConsumer : IRestConsumer
    {
        /// <summary>
        /// The MediaType that we transmit our content as
        /// </summary>
        protected const string ApplicationJson = "application/json";

        /// <summary>
        /// Gets the default serialization settings.
        /// </summary>
        /// <value>
        /// The default serialization settings.
        /// </value>
        protected static JsonSerializerSettings DefaultSerializationSettings { get; set; }

        /// <summary>
        /// The root URL of the endpoint
        /// </summary>
        /// <value>
        /// The base URL.
        /// </value>
        protected string BaseUrl { get; set; }

        /// <summary>
        /// The authentication token for the current user
        /// </summary>
        /// <value>
        /// The token.
        /// </value>
        protected string Token { get; set; }

        /// <summary>
        /// Provides diagnostic output on the usage of the RestConsumer
        /// </summary>
        /// <value>
        /// The log.
        /// </value>
        protected ILogger Log { get; set; }

        /// <summary>
        /// Serializer settings used to override Serialize/Deserialize in JsonConvert
        /// </summary>
        private readonly JsonSerializerSettings _serializerSettings;

        /// <summary>
        /// Initializes the <see cref="RestConsumer"/> class.
        /// </summary>
        static RestConsumer()
        {
            DefaultSerializationSettings = new JsonSerializerSettings
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                Formatting = Formatting.None
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestConsumer" /> class.
        /// </summary>
        /// <param name="configuration">The configuration used to instantiate this consumer.</param>
        /// <param name="log">The log we will use for diagnostics. If null an SdkReferenceLogger will be created and used.</param>
        /// <exception cref="System.ArgumentException">Thrown if BaseURL is null, empty or whitespace or if BaseUrl does not end with a trailing slash (/)</exception>
        public RestConsumer(IRestConsumerConfiguration configuration, ILogger log)
        {
            BaseUrl = configuration.BaseUrl;
			if (string.IsNullOrEmpty(BaseUrl) || string.IsNullOrWhiteSpace(BaseUrl))
			{
				throw new ArgumentException("BaseURL may not be null, empty or whitespace", nameof(configuration));
			}

			if (!BaseUrl.EndsWith("/"))
			{
				throw new ArgumentException($"BaseURL MUST end with a trailing slash (/). You supplied: '{BaseUrl}'", nameof(configuration));
			}

	        Token = configuration.AuthenticationToken ?? string.Empty;
	        _serializerSettings = configuration.SerializerSettings ?? DefaultSerializationSettings;
	        Log = log ?? new SdkReferenceLogger();
        }

        /// <summary>
        /// Issues a GET to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">Type that we will deserialise the response into</typeparam>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public T Get<T>(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        return GetAsync<T>(requestUri, optionalHeaders).Result;
        }

        /// <summary>
        /// Issues an asynchronous GET to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">Type that we will deserialise the response into</typeparam>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public async Task<T> GetAsync<T>(string requestUri, Dictionary<string, string> optionalHeaders = null)
		{
			var processedRequestUri = PreProcessDestination(requestUri);
            using (var client = CreateHttpClient(optionalHeaders))
            {
				var response = await client.GetAsync(processedRequestUri).ConfigureAwait(false);
				return await ProcessResponseAsync<T>(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a GET to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        public void Get(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        GetAsync(requestUri, optionalHeaders).Wait();
        }

        /// <summary>
        /// Issues an asynchronous GET to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// Task for awaiting.
        /// </returns>
        public async Task GetAsync(string requestUri, Dictionary<string, string> optionalHeaders = null)
		{
			var processedRequestUri = PreProcessDestination(requestUri);
            using (var client = CreateHttpClient(optionalHeaders))
            {
				var response = await client.GetAsync(processedRequestUri).ConfigureAwait(false);
				await ProcessResponseAsync(response, requestUri).ConfigureAwait(false);
            }
        }


        /// <summary>
        /// Issues a POST to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the POST request as its body</typeparam>
        /// <typeparam name="TOut">The type that we will return within the API Response.</typeparam>
        /// <param name="model">The model that we are serializing and passing with the POST request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public TOut Post<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        return PostAsync<T, TOut>(model, requestUri, optionalHeaders).Result;
        }

        /// <summary>
        /// Issues an asynchronous POST to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the POST request as its body</typeparam>
        /// <typeparam name="TOut">The type that we will return within the API Response.</typeparam>
        /// <param name="model">The model that we are serializing and passing with the POST request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public async Task<TOut> PostAsync<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            var content = SerializeObject(model);

            var processedRequestUri = PreProcessDestination(requestUri);
            
            using (var client = CreateHttpClient(optionalHeaders))
            {
	            var response = await client.PostAsync(processedRequestUri, new StringContent(content, Encoding.UTF8, ApplicationJson)).ConfigureAwait(false);
	            return await ProcessResponseAsync<TOut>(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a POST to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the POST request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the POST request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        public void Post<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        PostAsync(model, requestUri, optionalHeaders).Wait();
        }

        /// <summary>
        /// Issues an asynchronous POST to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the POST request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the POST request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// Task for awaiting.
        /// </returns>
        public async Task PostAsync<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            var content = SerializeObject(model);

            var processedRequestUri = PreProcessDestination(requestUri);
            
            using (var client = CreateHttpClient(optionalHeaders))
            {
	            var response = await client.PostAsync(processedRequestUri, new StringContent(content, Encoding.UTF8, ApplicationJson)).ConfigureAwait(false);
	            await ProcessResponseAsync(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a PUT to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PUT request as its body</typeparam>
        /// <typeparam name="TOut">The type that we will return within the API Response.</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PUT request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public TOut Put<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        return PutAsync<T, TOut>(model, requestUri, optionalHeaders).Result;
        }

        /// <summary>
        /// Issues an asynchronous PUT to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PUT request as its body</typeparam>
        /// <typeparam name="TOut">The type that we will return within the API Response.</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PUT request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public async Task<TOut> PutAsync<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            var content = SerializeObject(model);

            var processedRequestUri = PreProcessDestination(requestUri);
            
            using (var client = CreateHttpClient(optionalHeaders))
            {
                var response = await client.PutAsync(processedRequestUri, new StringContent(content, Encoding.UTF8, ApplicationJson)).ConfigureAwait(false);
				return await ProcessResponseAsync<TOut>(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a PUT to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PUT request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PUT request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        public void Put<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        PutAsync(model, requestUri, optionalHeaders).Wait();
        }

        /// <summary>
        /// Issues an asynchronous PUT to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PUT request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PUT request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// Task for awaiting.
        /// </returns>
        public async Task PutAsync<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            var content = SerializeObject(model);

            var processedRequestUri = PreProcessDestination(requestUri);
            
            using (var client = CreateHttpClient(optionalHeaders))
            {
                var response = await client.PutAsync(processedRequestUri, new StringContent(content, Encoding.UTF8, ApplicationJson)).ConfigureAwait(false);
				await ProcessResponseAsync(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a PATCH to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PATCH request as its body</typeparam>
        /// <typeparam name="TOut">The type that we will return within the API Response.</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PATCH request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public TOut Patch<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        return PatchAsync<T, TOut>(model, requestUri, optionalHeaders).Result;
        }

        /// <summary>
        /// Issues an asynchronous PATCH to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PATCH request as its body</typeparam>
        /// <typeparam name="TOut">The type that we will return within the API Response.</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PATCH request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing a deserialised instance of type T or an Error object on failure.
        /// </returns>
        public async Task<TOut> PatchAsync<T, TOut>(T model, string requestUri, Dictionary<string,string> optionalHeaders = null)
        {
            var content = SerializeObject(model);

            var processedRequestUri = PreProcessDestination(requestUri);
            
            using (var client = CreateHttpClient(optionalHeaders))
            {
                var response = await client.PatchAsync(processedRequestUri, new StringContent(content, Encoding.UTF8, ApplicationJson)).ConfigureAwait(false);
				return await ProcessResponseAsync<TOut>(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a PATCH to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PATCH request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PATCH request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        public void Patch<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        PatchAsync(model, requestUri, optionalHeaders).Wait();
        }

        /// <summary>
        /// Issues an asynchronous PATCH to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PATCH request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PATCH request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// Task for awaiting.
        /// </returns>
        public async Task PatchAsync<T>(T model, string requestUri, Dictionary<string,string> optionalHeaders = null)
        {
            var content = SerializeObject(model);

            var processedRequestUri = PreProcessDestination(requestUri);
            
            using (var client = CreateHttpClient(optionalHeaders))
            {
                var response = await client.PatchAsync(processedRequestUri, new StringContent(content, Encoding.UTF8, ApplicationJson)).ConfigureAwait(false);
				await ProcessResponseAsync(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a PATCH to the specified requestUri
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        public void Patch(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            PatchAsync(requestUri, optionalHeaders).Wait();
        }

        /// <summary>
        /// Issues an asynchronous PATCH to the specified requestUri
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// Task for awaiting
        /// </returns>
        public Task PatchAsync(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            return PatchAsync(string.Empty, requestUri, optionalHeaders);
        }

        /// <summary>
        /// Issues a DELETE to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing true on success, false on failure.
        /// </returns>
        public T Delete<T>(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        return DeleteAsync<T>(requestUri, optionalHeaders).Result;
        }

        /// <summary>
        /// Issues an asynchronous DELETE to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing true on success, false on failure.
        /// </returns>
        public async Task<T> DeleteAsync<T>(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            using (var client = CreateHttpClient(optionalHeaders))
            {
                var response = await client.DeleteAsync(requestUri).ConfigureAwait(false);
				return await ProcessResponseAsync<T>(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Issues a DELETE to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        public void Delete(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
	        DeleteAsync(requestUri, optionalHeaders).Wait();
        }

        /// <summary>
        /// Issues an asynchronous DELETE to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing true on success, false on failure.
        /// </returns>
        public async Task DeleteAsync(string requestUri, Dictionary<string, string> optionalHeaders = null)
        {
            using (var client = CreateHttpClient(optionalHeaders))
            {
                var response = await client.DeleteAsync(requestUri).ConfigureAwait(false);
				await ProcessResponseAsync(response, requestUri).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Builds a query string by concatenating name/value pairs. This method will
        /// URLEncode all entries so you do not need to handle encoding before calling.
        /// If queryStringItems is null or empty an empty string will be returned
        /// </summary>
        /// <param name="queryStringItems">The query string items to create a querystring for.</param>
        /// <returns>
        /// URL Encoded QueryString ready for use. This will be String.Empty if <see cref="queryStringItems" /> is null or empty
        /// </returns>
        public string BuildQueryString(Dictionary<string,string> queryStringItems)
		{
			if (queryStringItems == null || !queryStringItems.Any())
			{
				return string.Empty;
			}

			var qs = string.Join("&", queryStringItems.Select(i =>
			    $"{WebUtility.UrlEncode(i.Key)}={WebUtility.UrlEncode(i.Value)}"));
            return qs;
        }

        /// <summary>
        /// Creates an HTTP client including the SharedAccessSignature from the user token passed in configuration.
        /// This method will also append any request Headers included in the <see cref="optionalHeaders" /> parameter.
        /// All REST access methods (GET/POST/PUT/PATCH/DELETE) get their HTTP Client by calling this method.
        /// </summary>
        /// <param name="optionalHeaders">Optional headers which will be added to the client. If null or empty no headers will be added.</param>
        /// <returns>
        /// HttpClient configured with the users authentication token and and additional optional headers.
        /// </returns>
        protected virtual HttpClient CreateHttpClient(Dictionary<string, string> optionalHeaders = null)
        {
            var handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var httpClient = new HttpClient(handler) { BaseAddress = new Uri(BaseUrl) };
            var defaultHeaders = new Dictionary<string, string>
			{
				{"Accept", ApplicationJson},
				{"Ocp-apim-subscription-key", Token},
                {"Accept-Encoding", "gzip, deflate"}
			};

			httpClient = ApplyOptionalHeaders(httpClient, defaultHeaders);
            httpClient = ApplyOptionalHeaders(httpClient, optionalHeaders);

            return httpClient;
        }

        /// <summary>
        /// Provides a hook to pre-process the requestUri URL prior to making a GET/POST/PUT/PATCH/DELETE call. This method
        /// performs no action in the default implementation but is provided for overriding implementations.
        /// </summary>
        /// <param name="requestUri">The requestUri.</param>
        /// <returns>
        /// The request URI after applying any processing.
        /// </returns>
        private string PreProcessDestination(string requestUri)
	    {
		    return requestUri;
	    }

        /// <summary>
        /// Deserializes the specified content.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        private T Deserialize<T>(string content)
		{
			return DeserializeAsync<T>(content).Result;
		}

        /// <summary>
        /// Deserialises a content string into an instance of type T. If the deserialisation fails an
        /// <see cref="ApiException" /> will be thrown.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content">The content.</param>
        /// <returns>
        /// Task&lt;T&gt;.
        /// </returns>
        private async Task<T> DeserializeAsync<T>(string content)
        {
			//Log.Trace("Entered DeserializeAsync");
            return await Task.Factory.StartNew(() =>
            {
	            try
	            {
		            return JsonConvert.DeserializeObject<T>(content, _serializerSettings);
	            }
	            catch (Exception ex)
	            {
					Log.Error($"Failed to deserialise '{content}' into an object of type {typeof(T)}. Error - {ex}");
		            throw new ApiException($"Failed to deserialise '{content}' into an object of type {typeof (T)}", ex);
	            }

            }).ConfigureAwait(false);
        }

        /// <summary>
        /// Deserializes the error.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        private ApiError DeserializeError(string content)
		{
			return DeserializeErrorAsync(content).Result;
		}

        /// <summary>
        /// Deserializes the error.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <returns></returns>
        private async Task<ApiError> DeserializeErrorAsync(string content)
        {
            return await Task.Factory.StartNew(() =>
            {
                try
                {
                    return string.IsNullOrEmpty(content) ? new ApiError { Message = "An unsuccessful status code was received however the response body was empty" } : JsonConvert.DeserializeObject<ApiError>(content, _serializerSettings);
                }
                catch (Exception ex)
                {
#if DEBUG //Only show fully serialised content in Debug builds
					Log.Error($"Failed whilst attempting to deserialise '{content}' into ApiError ({ex})");
#else
					Log.Error($"Failed whilst attempting to deserialise response into ApiError ({ex})");
#endif
	                return new ApiError(ex);
                }
            }).ConfigureAwait(false);
        }

        /// <summary>
        /// Serializes the object.
        /// </summary>
        /// <param name="obj">The object.</param>
        /// <returns></returns>
        /// <exception cref="ApiException"></exception>
        private string SerializeObject(object obj)
        {
			try
			{
				var serialised = JsonConvert.SerializeObject(obj, _serializerSettings);
                return serialised;
			}
			catch (Exception ex)
			{
				Log.Error($"Failed to serialize an object of type {obj?.GetType().ToString() ?? "NULL"} ({ex})");
				throw new ApiException(
				    $"Failed to serialize an object of type {obj?.GetType().ToString() ?? "NULL"}", ex);
			}
		}

        /// <summary>
        /// Takes a Dictionary of headers and applies them to the passed client. Key is the name of the header, value is the header value.
        /// </summary>
        /// <param name="client">The client we will append headers to.</param>
        /// <param name="optionalHeaders">The headers to append to the client.</param>
        /// <returns>
        /// Reference to the passed HttpClient with the optional headers appended.
        /// </returns>
        protected HttpClient ApplyOptionalHeaders(HttpClient client, Dictionary<string, string> optionalHeaders)
        {
            if (client == null)
            {
                return null;
            }

            if (optionalHeaders == null)
            {
                return client;
            }

            foreach (var header in optionalHeaders)
            {
                client.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            return client;
        }

        /// <summary>
        /// Processes an HTTP response from a REST service call as an asynchronous operation. This method will
        /// check the status code of the response. If the response status code is success then the response
        /// content will be deserialised into an instance of type <see cref="T" />. If the status code is non-success and the
        /// response content is not empty then the response will be serialised into an <see cref="ApiError" /> which will be
        /// thrown as an <see cref="ApiException" />. If the response code is not success and the response body is empty then
        /// an <see cref="ApiException" /> will be thrown but the message will be the generic "Request failed".
        /// </summary>
        /// <typeparam name="T">Type that we will deserialise response content into on success</typeparam>
        /// <param name="response">The response.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <returns>
        /// Task containing the deserialised value on success. Throws ApiException on failure
        /// </returns>
        /// <exception cref="ApiUnauthorizedException">Thrown if response.StatusCode is 401.</exception>
        /// <exception cref="ApiException">Thrown if response.IsSuccessStatusCode is false and HttpStatusCode is not 401</exception>
        private async Task<T> ProcessResponseAsync<T>(HttpResponseMessage response, string requestUri)
		{
			var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            CheckForException(response, requestUri, result);

            var converted = Deserialize<T>(result);

            return converted;
		}

        /// <summary>
        /// Processes an HTTP response from a REST service call as an asynchronous operation with no return type.
        /// This method will  check the status code of the response. If the status code is non-success and the
        /// response content is not empty then the response will be serialised into an <see cref="ApiError" /> which will be
        /// thrown as an <see cref="ApiException" />. If the response code is not success and the response body is empty then
        /// an <see cref="ApiException" /> will be thrown but the message will be the generic "Request failed".
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="requestUri">The processed request URI.</param>
        /// <returns>
        /// Task for awaiting. Throws ApiException on failure
        /// </returns>
        /// <exception cref="ApiUnauthorizedException">Thrown if response.StatusCode is 401.</exception>
        /// <exception cref="ApiException">Thrown if response.IsSuccessStatusCode is false and HttpStatusCode is not 401</exception>
        private async Task ProcessResponseAsync(HttpResponseMessage response, string requestUri)
		{
			var result = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

			CheckForException(response, requestUri, result);
		}

        /// <summary>
        /// Checks the HttpResponse for any exceptions and throws accordingly.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="requestUri">The request URI.</param>
        /// <param name="result">The result.</param>
        /// <exception cref="ApiUnauthorizedException">Thrown if response.StatusCode is 401.</exception>
        /// <exception cref="ApiException">Thrown if response.IsSuccessStatusCode is false and HttpStatusCode is not 401</exception>
        private void CheckForException(HttpResponseMessage response, string requestUri, string result)
        {
            if (response.IsSuccessStatusCode) return;

            var error = DeserializeError(result);

            ErrorLogger(response, error, requestUri);

            if (response.StatusCode == HttpStatusCode.Unauthorized)
                throw new ApiUnauthorizedException(
                    $"Call to {BaseUrl}{requestUri} failed with status code {response.StatusCode} ({(int) response.StatusCode})",
                    error);

            throw new ApiException(response.StatusCode,
                $"Call to {BaseUrl}{requestUri} failed with status code {response.StatusCode} ({(int) response.StatusCode})",
                error);
        }

        /// <summary>
        /// Logs errors caused by unexpected http status codes
        /// </summary>
        /// <param name="response">The response.</param>
        /// <param name="error">The error.</param>
        /// <param name="requestUri">The request URI.</param>
        private void ErrorLogger(HttpResponseMessage response, ApiError error, string requestUri)
        {
            var errorCode = (int) response.StatusCode;
            var formattedUrl = $"{BaseUrl}/{requestUri}";

            if (errorCode >= 400 && errorCode <= 499)
            {
                Log.Warn($"Finished request against {formattedUrl}. Error code in 400-499 range received. Details: {error}");
            }

            if (errorCode >= 500 && errorCode <= 599)
            {
                Log.Fatal($"Finished request against {BaseUrl}/{requestUri}. Error code in 500-599 range received. Detail: {error}");
            }
        }
    }
}