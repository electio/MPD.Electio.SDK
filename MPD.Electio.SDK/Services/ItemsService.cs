using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Service for managing items.
    /// </summary>
    public class ItemsService : BaseService, IItemsService
    {

        /// <summary>
        /// Initialize the items service
        /// </summary>
        /// <param name="apiKey">The api key of the user making the request</param>
        /// <param name="endpoints">An implementation of <see cref="IEndpoints"/></param>
        /// <param name="log">A logger implementing <see cref="ILogger"/></param>
        public ItemsService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Items, log)
        {
		}

        /// <summary>
        /// Add a new item
        /// </summary>
        /// <param name="request">A <see cref="AddItemRequest"/></param>
        public void AddItem(AddItemRequest request)
        {
            CallAsyncMethod(() => AddItemAsync(request).Wait());
        }

        /// <summary>
        /// Asynchronously add a new item
        /// </summary>
        /// <param name="request">A <see cref="AddItemRequest"/></param>
        public Task AddItemAsync(AddItemRequest request)
        {
            return Rest.PutAsync(request, string.Format("{0}", WebUtility.UrlEncode(request.PackageReference)));
        }

        /// <summary>
        /// Remove the specified item
        /// </summary>
        /// <param name="packageReference">The reference of the package containing the item</param>
        /// <param name="itemReference">The reference of the item to remove</param>
        public void RemoveItem(string packageReference, string itemReference)
        {
            CallAsyncMethod(() => RemoveItemAsync(packageReference, itemReference).Wait());
        }

        /// <summary>
        /// Asynchronously removed the specified item
        /// </summary>
        /// <param name="packageReference">The reference of the package containing the item</param>
        /// <param name="itemReference">The reference of the item to remove</param>
        public Task RemoveItemAsync(string packageReference, string itemReference)
        {
            return Rest.DeleteAsync(string.Format("{0}/{1}", WebUtility.UrlEncode(packageReference),
                    WebUtility.UrlEncode(itemReference)));
        }

        /// <summary>
        /// Move an item to the specified package
        /// <remarks>
        /// This removes the item from its current containing package and transfers it to the specified target package
        /// </remarks>
        /// </summary>
        /// <param name="request">A <see cref="MoveItemRequest"/></param>
        public void MoveItem(MoveItemRequest request)
        {
            CallAsyncMethod(() => MoveItemAsync(request).Wait());
        }

        /// <summary>
        /// Asynchronously move an item to the specified package
        /// <remarks>
        /// This removes the item from its current containing package and transfers it to the specified target package
        /// </remarks>
        /// </summary>
        /// <param name="request">A <see cref="MoveItemRequest"/></param>
        public Task MoveItemAsync(MoveItemRequest request)
        {
            return Rest.PutAsync(request, "move");
        }

        /// <summary>
        /// Set the reference provided by customer on the FIRST item in the package with the supplied label bar code.
        /// </summary>
        /// <param name="labelBarCode">The bar code of the label.</param>
        /// <param name="request">The request.</param>
        public void SetCustomerProvidedReferenceViaLabelBarCode(string labelBarCode, ReferenceProvidedByCustomerRequest request)
        {
            CallAsyncMethod(() => SetCustomerProvidedReferenceViaLabelBarCodeAsync(labelBarCode, request).Wait());
        }

        /// <summary>
        /// Asynchronously set the reference provided by customer on the FIRST item in the package with the supplied label bar code.
        /// </summary>
        /// <param name="labelBarCode">The bar code of the label.</param>
        /// <param name="request">The request.</param>
        public Task SetCustomerProvidedReferenceViaLabelBarCodeAsync(string labelBarCode, ReferenceProvidedByCustomerRequest request)
        {
            return Rest.PutAsync(request, string.Format("{0}/setCustomerProvidedReference", WebUtility.UrlEncode(labelBarCode)));
        }
    }
}