using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Represents available actions provided by the Items Service.
    /// </summary>
    public interface IItemsService
    {
        /// <summary>
        /// Add an item.
        /// </summary>
        /// <param name="request">The request.</param>
        void AddItem(AddItemRequest request);

        /// <summary>
        /// Asynchronously add an item.
        /// </summary>
        /// <param name="request"></param>
        Task AddItemAsync(AddItemRequest request);


        /// <summary>
        /// Remove the item with the supplied reference.
        /// </summary>
        /// <param name="packageReference">Reference the item belongs to.</param>
        /// <param name="itemReference">Reference of item to remove.</param>
        void RemoveItem(string packageReference, string itemReference);

        /// <summary>
        /// Asynchronously remove the item with the supplied reference.
        /// </summary>
        /// <param name="packageReference">Reference the item belongs to.</param>
        /// <param name="itemReference">Reference of item to remove.</param>
        Task RemoveItemAsync(string packageReference, string itemReference);

        /// <summary>
        /// Moves an item.
        /// </summary>
        /// <param name="request">The request.</param>
        void MoveItem(MoveItemRequest request);

        /// <summary>
        /// Asynchronously moves an item.
        /// </summary>
        /// <param name="request">The request.</param>
        Task MoveItemAsync(MoveItemRequest request);

        /// <summary>
        /// Set the reference provided by customer on the FIRST item in the package with the supplied label bar code.
        /// </summary>
        /// <param name="labelBarCode">The bar code of the label.</param>
        /// <param name="request">The request.</param>
        void SetCustomerProvidedReferenceViaLabelBarCode(string labelBarCode, ReferenceProvidedByCustomerRequest request);

        /// <summary>
        /// Asynchronously set the reference provided by customer on the FIRST item in the package with the supplied label bar code.
        /// </summary>
        /// <param name="labelBarCode">The bar code of the label.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task SetCustomerProvidedReferenceViaLabelBarCodeAsync(string labelBarCode, ReferenceProvidedByCustomerRequest request);
    }
}