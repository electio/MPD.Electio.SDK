using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Profile;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Manage Shipping Locations
    /// </summary>
	public interface IShippingLocationsService
	{
        /// <summary>
        /// Get the full list of shipping locations for the current company, including those to which the current user has not been linked
        /// </summary>
        /// <returns>A list of <see cref="ShippingLocation"/></returns>
        List<ShippingLocation> GetShippingLocations();

	    /// <summary>
	    /// Gets the list of shipping locations for your company to which your account has been linked
	    /// </summary>
	    /// <returns>A list of <see cref="ShippingLocation"/></returns>
	    List<ShippingLocation> GetAssignedShippingLocations();

        /// <summary>
        /// Get a specific <see cref="ShippingLocation"/> by its reference
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to retrieve</param>
        /// <returns>The matching <see cref="ShippingLocation"/></returns>
        ShippingLocation GetShippingLocation(string shippingLocationReference);

        /// <summary>
        /// Check whether the specified shipping location reference is available.
        /// <remarks>
        /// A reference will be deemed unavailable when it has previously been used for an existing shipping location 
        /// </remarks>
        /// </summary>
        /// <param name="shippingLocationReference">The shipping location reference to check</param>
        /// <returns><c>True</c> if the reference is available, otherwise <c>False</c></returns>
        bool ShippingLocationReferenceAvailable(string shippingLocationReference);

        /// <summary>
        /// Creates a new Shipping Location with the given properties
        /// </summary>
        /// <param name="shippingLocation">The <see cref="ShippingLocation"/> object to created</param>
        void CreateShippingLocation(ShippingLocation shippingLocation);

        /// <summary>
        /// Update an existing shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the location to update</param>
        /// <param name="shippingLocation">The full <see cref="ShippingLocation"/> including modified and unmodified properties</param>
        void UpdateShippingLocation(string shippingLocationReference, ShippingLocation shippingLocation);

        /// <summary>
        /// Delete the specified shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to remove</param>
        void DeleteShippingLocation(string shippingLocationReference);

        /// <summary>
        /// Get the full list of shipping locations for the current company, including those to which the current user has not been linked
        /// </summary>
        /// <returns>A list of <see cref="ShippingLocation"/></returns>
        Task<List<ShippingLocation>> GetShippingLocationsAsync();

        /// <summary>
        /// Gets the list of shipping locations for your company to which your account has been linked
        /// </summary>
        /// <returns>A list of <see cref="ShippingLocation"/></returns>
        Task<List<ShippingLocation>> GetAssignedShippingLocationsAsync();

        /// <summary>
        /// Get a specific <see cref="ShippingLocation"/> by its reference
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to retrieve</param>
        /// <returns>The matching <see cref="ShippingLocation"/></returns>
        Task<ShippingLocation> GetShippingLocationAsync(string shippingLocationReference);

        /// <summary>
        /// Check whether the specified shipping location reference is available.
        /// <remarks>
        /// A reference will be deemed unavailable when it has previously been used for an existing shipping location 
        /// </remarks>
        /// </summary>
        /// <param name="shippingLocationReference">The shipping location reference to check</param>
        /// <returns><c>True</c> if the reference is available, otherwise <c>False</c></returns>
        Task<bool> ShippingLocationReferenceAvailableAsync(string shippingLocationReference);

        /// <summary>
        /// Creates a new Shipping Location with the given properties
        /// </summary>
        /// <param name="shippingLocation">The <see cref="ShippingLocation"/> object to created</param>
        Task CreateShippingLocationAsync(ShippingLocation shippingLocation);

        /// <summary>
        /// Update an existing shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the location to update</param>
        /// <param name="shippingLocation">The full <see cref="ShippingLocation"/> including modified and unmodified properties</param>
        Task UpdateShippingLocationAsync(string shippingLocationReference, ShippingLocation shippingLocation);

        /// <summary>
        /// Delete the specified shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to remove</param>
        Task DeleteShippingLocationAsync(string shippingLocationReference);
	}
}