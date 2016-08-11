using System;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Subscription;
using MPD.Electio.SDK.Error;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
	public class CarrierServiceService : BaseService, ICarrierServiceService
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierServiceService"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        public CarrierServiceService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.CarrierServices, log)
		{

		}

        /// <summary>
        /// Gets the available MPD carrier services for subscription.
        /// </summary>
        /// <returns>
        /// A collection of MPD Carrier Services
        /// </returns>
        public SubscriptionMpdCarrierServiceResponse GetAvailableMpdCarrierServicesForSubscription()
		{
			return CallAsyncMethod(() => GetAvailableMpdCarrierServicesForSubscriptionAsync().Result);
		}

        /// <summary>
        /// Gets the available underlying carrier services for subscription.
        /// </summary>
        /// <returns>
        /// A collection of Carrier Services
        /// </returns>
        public SubscriptionCarrierServiceResponse GetAvailableCarrierServicesForSubscription()
		{
			return CallAsyncMethod(() => GetAvailableCarrierServicesForSubscriptionAsync().Result);
		}


        /// <summary>
        /// Gets the available MPD carrier services for subscription.
        /// </summary>
        /// <returns>
        /// A collection of MPD Carrier Services
        /// </returns>
        public Task<SubscriptionMpdCarrierServiceResponse> GetAvailableMpdCarrierServicesForSubscriptionAsync()
		{
			try
			{
				return Rest.GetAsync<SubscriptionMpdCarrierServiceResponse>(String.Empty);
			}
			catch (ApiException ex)
			{
				if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
				{
					return Task.FromResult<SubscriptionMpdCarrierServiceResponse>(null);
				}
				throw;
			}
		}

        /// <summary>
        /// Gets the available underlying carrier services for subscription.
        /// </summary>
        /// <returns>
        /// A collection of Carrier Services
        /// </returns>
        public Task<SubscriptionCarrierServiceResponse> GetAvailableCarrierServicesForSubscriptionAsync()
		{
			try
			{
				return Rest.GetAsync<SubscriptionCarrierServiceResponse>("carrierServices");
			}
			catch (ApiException ex)
			{
				if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
				{
					return Task.FromResult<SubscriptionCarrierServiceResponse>(null);
				}
				throw;
			}
		}
	}
}
