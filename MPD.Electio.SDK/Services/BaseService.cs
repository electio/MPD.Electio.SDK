using System;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.Error;
using MPD.Electio.SDK.Interfaces;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Base class from which all services should inherit.
    /// </summary>
    public abstract class BaseService
	{

        /// <summary>
        /// Default IRestConsumer for the service.
        /// </summary>
        protected IRestConsumer Rest;

        /// <summary>
        /// The log
        /// </summary>
        protected ILogger Log;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseService" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="baseUri">The base URI.</param>
        /// <param name="log">The log.</param>
        /// <exception cref="System.ArgumentNullException">endpoints</exception>
        /// <exception cref="System.ArgumentException">You must supply an api key;apiKey</exception>
        protected BaseService(string apiKey, IEndpoints endpoints, string baseUri, ILogger log) : this(log)
        {
            var restConfig = GetRestConfig(apiKey, endpoints, baseUri);
            Rest = new RestConsumer(restConfig, log);
        }

        protected BaseService(ILogger log)
        {
            Log = log;
        }

        protected RestConsumerConfiguration GetRestConfig(string apiKey, IEndpoints endpoints, string baseUri)
        {
            if (endpoints == null)
            {
                throw new ArgumentNullException(nameof(endpoints));
            }

            if (apiKey == null)
            {
                throw new ArgumentException("You must supply an api key", nameof(apiKey));
            }

            return new RestConsumerConfiguration(baseUri, apiKey);
        }


        /// <summary>
        /// Calls the asynchronous method.
        /// </summary>
        /// <typeparam name="TReturn">The type of the return.</typeparam>
        /// <param name="asyncCall">The asynchronous call.</param>
        /// <returns>Type</returns>
        protected TReturn CallAsyncMethod<TReturn>(Func<TReturn> asyncCall)
        {

            var tr = typeof(TReturn);
            if (tr == typeof(Task)
                || (tr.IsGenericType && tr.GetGenericTypeDefinition() == typeof(Task<>)))
            {
                Log.Fatal("Attempted to invoke CallAsyncMethod<TReturn> with a return type of Task. Please ensure .Return is in the correct location.");
                throw new ApiException(HttpStatusCode.InternalServerError, "Invalid method call.", new ApiError());
            }

            try
            {
				return asyncCall();
			}
			catch (AggregateException ex)
			{
                if (ex.InnerExceptions.Count == 1)
				{
					throw ex.InnerExceptions[0];
				}

				throw;
			}
		}

        /// <summary>
        /// Calls the asynchronous method.
        /// </summary>
        /// <param name="asyncCall">The asynchronous call.</param>
        protected void CallAsyncMethod(Action asyncCall)
		{
			try
			{
				asyncCall();
			}
			catch (AggregateException ex)
			{
				if (ex.InnerExceptions.Count == 1)
				{
					throw ex.InnerExceptions[0];
				}

				throw;
			}
		}
	}
}
