using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.DeliveryOptions;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Interface for Delivery Options Service
    /// </summary>
    public interface IDeliveryOptionsService
    {
        /// <summary>
        /// Gets the delivery options.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        DeliveryOptionsResponse GetDeliveryOptions(DeliveryOptionsRequest request);

        /// <summary>
        /// Gets the delivery options summary.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        DeliveryOptionSummary GetDeliveryOptionsSummary(DeliveryOptionsRequest request);


        /// <summary>
        /// Gets the pickup options.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        PickupOptionsResponse GetPickupOptions(PickupOptionsRequest request);

        /// <summary>
        /// Reserves the pickup option.
        /// </summary>
        /// <param name="pickupOptionReference">The pickup option reference.</param>
        /// <returns></returns>
        string ReservePickupOption(string pickupOptionReference);

        /// <summary>
        /// Selects the delivery or pickup option.
        /// </summary>
        /// <param name="optionReference">The option reference.</param>
        /// <returns>Links to the Electio consignment</returns>
        List<ApiLink> SelectOption(string optionReference);

        /// <summary>
        /// Gets the delivery options asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<DeliveryOptionsResponse> GetDeliveryOptionsAsync(DeliveryOptionsRequest request);

        /// <summary>
        /// Gets the delivery options summary asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<DeliveryOptionSummary> GetDeliveryOptionsSummaryAsync(DeliveryOptionsRequest request);

        /// <summary>
        /// Gets the pickup options asynchronous.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<PickupOptionsResponse> GetPickupOptionsAsync(PickupOptionsRequest request);

        /// <summary>
        /// Reserves the pickup option asynchronous.
        /// </summary>
        /// <param name="pickupOptionReference">The pickup option reference.</param>
        /// <returns></returns>
        Task<string> ReservePickupOptionAsync(string pickupOptionReference);

        /// <summary>
        /// Selects the option asynchronous.
        /// </summary>
        /// <param name="optionReference">The option reference.</param>
        /// <returns></returns>
        Task<List<ApiLink>> SelectOptionAsync(string optionReference);
    }
}
