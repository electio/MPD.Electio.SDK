using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Subscription;

namespace MPD.Electio.SDK.Interfaces.Services
{
	public interface ICarrierServiceService
	{
        /// <summary>
        /// Gets the available MPD carrier services for subscription.
        /// </summary>
        /// <returns>A collection of MPD Carrier Services</returns>
        SubscriptionMpdCarrierServiceResponse GetAvailableMpdCarrierServicesForSubscription();
        /// <summary>
        /// Gets the available underlying carrier services for subscription.
        /// </summary>
        /// <returns>A collection of Carrier Services</returns>
        SubscriptionCarrierServiceResponse GetAvailableCarrierServicesForSubscription();
        /// <summary>
        /// Gets the available MPD carrier services for subscription.
        /// </summary>
        /// <returns>A collection of MPD Carrier Services</returns>
        Task<SubscriptionMpdCarrierServiceResponse> GetAvailableMpdCarrierServicesForSubscriptionAsync();
        /// <summary>
        /// Gets the available underlying carrier services for subscription.
        /// </summary>
        /// <returns>A collection of Carrier Services</returns>
        Task<SubscriptionCarrierServiceResponse> GetAvailableCarrierServicesForSubscriptionAsync();
	}
}