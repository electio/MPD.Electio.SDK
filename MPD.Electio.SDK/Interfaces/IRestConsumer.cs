using System.Collections.Generic;
using System.Threading.Tasks;

namespace MPD.Electio.SDK.Interfaces
{
    ///<summary>Implementing class provides methods which will allow the caller to interact with RESTful API's</summary>
    public interface IRestConsumer
    {
        /// <summary>
        /// Issues a GET to the specified requestUri. The <see cref="requestUri"/> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString"/>
        /// </summary>
        /// <typeparam name="T">Type that we will deserialise the response into</typeparam>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString"/>.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>ApiResponse containing a deserialised instance of type T or an Error object on failure.</returns>
        T Get<T>(string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        Task<T> GetAsync<T>(string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues a GET to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        void Get(string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues an asynchronous GET to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// Task for awaiting.
        /// </returns>
        Task GetAsync(string requestUri, Dictionary<string, string> optionalHeaders = null);


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
        TOut Post<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        Task<TOut> PostAsync<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues a POST to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the POST request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the POST request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        void Post<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        Task PostAsync<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        TOut Put<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues an asynchronous PUT to the specified requestUri sending the serialised content of <see cref="model"/> as the body of the request.
        /// The <see cref="requestUri"/> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString"/>
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PUT request as its body</typeparam>
        /// <typeparam name="TOut">The type that we will return within the API Response.</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PUT request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString"/>.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>ApiResponse containing a deserialised instance of type T or an Error object on failure.</returns>
        Task<TOut> PutAsync<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues a PUT to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PUT request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PUT request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        void Put<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        Task PutAsync<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        TOut Patch<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        Task<TOut> PatchAsync<T, TOut>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues a PATCH to the specified requestUri sending the serialised content of <see cref="model" /> as the body of the request.
        /// The <see cref="requestUri" /> should contain the route part of the request (not the endpoint) and should include any QueryString
        /// parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <typeparam name="T">The type of the model that we are passing with the PATCH request as its body</typeparam>
        /// <param name="model">The model that we are serializing and passing with the PATCH request as its body.</param>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        void Patch<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        Task PatchAsync<T>(T model, string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues a PATCH to the specified requestUri
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        void Patch(string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues an asynchronous PATCH to the specified requestUri
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>Task for awaiting</returns>
        Task PatchAsync(string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        T Delete<T>(string requestUri, Dictionary<string, string> optionalHeaders = null);

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
        Task<T> DeleteAsync<T>(string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues a DELETE to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        void Delete(string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Issues an asynchronous DELETE to the specified requestUri. The <see cref="requestUri" /> should contain the route part
        /// of the request (not the endpoint) and should include any QueryString parameters created using <seealso cref="BuildQueryString" />
        /// </summary>
        /// <param name="requestUri">The route part of the request. This should not include the endpoint but should include a QueryString built using <seealso cref="BuildQueryString" />.</param>
        /// <param name="optionalHeaders">Any optional headers which should be added to the request.</param>
        /// <returns>
        /// ApiResponse containing true on success, false on failure.
        /// </returns>
        Task DeleteAsync(string requestUri, Dictionary<string, string> optionalHeaders = null);

        /// <summary>
        /// Builds a query string by concatenating name/value pairs. This method will
        /// URLEncode all entries so you do not need to handle encoding before calling.
        /// </summary>
        /// <param name="queryStringItems">The query string items to create a querystring for.</param>
        /// <returns>
        /// URL Encoded QueryString ready for use.
        /// </returns>
        string BuildQueryString(Dictionary<string, string> queryStringItems);
    }
}
