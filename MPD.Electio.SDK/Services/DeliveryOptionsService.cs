using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.DeliveryOptions;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Default implementation of IDeliveryOptionsService
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Services.BaseService" />
    /// <seealso cref="MPD.Electio.SDK.Interfaces.Services.IDeliveryOptionsService" />
    public class DeliveryOptionsService : BaseService, IDeliveryOptionsService
    {

        protected IRestConsumer RestPickUpOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteService"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        /// <exception cref="System.ArgumentNullException">endpoints</exception>
        /// <exception cref="System.ArgumentException">You must supply an api key;apiKey</exception>
        public DeliveryOptionsService(string apiKey, IEndpoints endpoints, ILogger log) : base (apiKey, endpoints, endpoints.DeliveryOptions, log)
		{
            var pickupOptionsConfig = new RestConsumerConfiguration(endpoints.PickupOptions, apiKey);

            RestPickUpOptions = new RestConsumer(pickupOptionsConfig, log);
        }


        /// <summary>
        /// Gets the delivery options.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public DeliveryOptionsResponse GetDeliveryOptions(DeliveryOptionsRequest request)
        {
            return CallAsyncMethod(() => GetDeliveryOptionsAsync(request).Result);
        }

        /// <summary>
        /// Gets the delivery options summary.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public DeliveryOptionSummary GetDeliveryOptionsSummary(DeliveryOptionsRequest request)
        {
            return CallAsyncMethod(() => GetDeliveryOptionsSummaryAsync(request).Result);
        }

        /// <summary>
        /// Gets the pickup options.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public PickupOptionsResponse GetPickupOptions(PickupOptionsRequest request)
        {
            return CallAsyncMethod(() => GetPickupOptionsAsync(request).Result);
        }

        /// <summary>
        /// Reserves the pickup option.
        /// </summary>
        /// <param name="pickupOptionReference">The pickup option reference.</param>
        /// <returns></returns>
        public string ReservePickupOption(string pickupOptionReference)
        {
            return CallAsyncMethod(() => ReservePickupOptionAsync(pickupOptionReference).Result);
        }

        /// <summary>
        /// Selects the delivery or pickup option.
        /// </summary>
        /// <param name="optionReference">The option reference.</param>
        /// <returns>
        /// Links to the Electio consignment
        /// </returns>
        public List<ApiLink> SelectOption(string optionReference)
        {
            return CallAsyncMethod(() => SelectOptionAsync(optionReference).Result);
        }

        /// <summary>
        /// Gets the delivery options asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<DeliveryOptionsResponse> GetDeliveryOptionsAsync(DeliveryOptionsRequest request)
        {
            return Rest.PostAsync<DeliveryOptionsRequest, DeliveryOptionsResponse>(request, string.Empty);
        }

        /// <summary>
        /// Gets the delivery options summary asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<DeliveryOptionSummary> GetDeliveryOptionsSummaryAsync(DeliveryOptionsRequest request)
        {
            return Rest.PostAsync<DeliveryOptionsRequest, DeliveryOptionSummary>(request, "summary");
        }

        /// <summary>
        /// Gets the pickup options asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<PickupOptionsResponse> GetPickupOptionsAsync(PickupOptionsRequest request)
        {
            return RestPickUpOptions.PostAsync<PickupOptionsRequest, PickupOptionsResponse>(request, string.Empty);
        }

        /// <summary>
        /// Reserves the pickup option asynchronous.
        /// </summary>
        /// <param name="pickupOptionReference">The pickup option reference.</param>
        /// <returns></returns>
        public Task<string> ReservePickupOptionAsync(string pickupOptionReference)
        {
            return RestPickUpOptions.PostAsync<string, string>(pickupOptionReference, string.Format("reserve/{0}", pickupOptionReference));
        }

        /// <summary>
        /// Selects the option asynchronous.
        /// </summary>
        /// <param name="optionReference">The option reference.</param>
        /// <returns></returns>
        public Task<List<ApiLink>> SelectOptionAsync(string optionReference)
        {
            return Rest.PostAsync<string, List<ApiLink>>(optionReference, string.Format("select/{0}", optionReference));
        }
    }
}