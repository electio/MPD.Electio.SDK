using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Profile;
using MPD.Electio.SDK.Error;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Manage shipping locations
    /// </summary>
	public class ShippingLocationsServiceService : BaseService, IShippingLocationsService
	{

        /// <summary>
        /// Instantiates a new <see cref="ShippingLocationsServiceService"/>
        /// <remarks>
        /// This service is used to manage Shipping Locations
        /// </remarks>
        /// </summary>
        /// <param name="apiKey">The API Key of the current user</param>
        /// <param name="endpoints">The configured endpoints</param>
        /// <param name="log"><see cref="ILogger"/></param>
		public ShippingLocationsServiceService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.ShippingLocations, log)
        {
		}

        /// <summary>
        /// Get the full list of shipping locations for the current company, including those to which the current user has not been linked
        /// </summary>
        /// <returns>A list of <see cref="ShippingLocation"/></returns>
		public List<ShippingLocation> GetShippingLocations()
		{
			return CallAsyncMethod(() => GetShippingLocationsAsync().Result);
		}

        /// <summary>
        /// Gets the list of shipping locations for your company to which your account has been linked
        /// </summary>
        /// <returns>A list of <see cref="ShippingLocation"/></returns>
	    public List<ShippingLocation> GetAssignedShippingLocations()
	    {
	        return CallAsyncMethod(() => GetAssignedShippingLocationsAsync().Result);
	    } 

        /// <summary>
        /// Get a specific <see cref="ShippingLocation"/> by its reference
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to retrieve</param>
        /// <returns>The matching <see cref="ShippingLocation"/></returns>
		public ShippingLocation GetShippingLocation(string shippingLocationReference)
		{
			return CallAsyncMethod(() => GetShippingLocationAsync(shippingLocationReference).Result);
		}

        /// <summary>
        /// Check whether the specified shipping location reference is available.
        /// <remarks>
        /// A reference will be deemed unavailable when it has previously been used for an existing shipping location 
        /// </remarks>
        /// </summary>
        /// <param name="shippingLocationReference">The shipping location reference to check</param>
        /// <returns><c>True</c> if the reference is available, otherwise <c>False</c></returns>
		public bool ShippingLocationReferenceAvailable(string shippingLocationReference)
		{
			return CallAsyncMethod(() => ShippingLocationReferenceAvailableAsync(shippingLocationReference).Result);
		}

        /// <summary>
        /// Creates a new Shipping Location with the given properties
        /// </summary>
        /// <param name="shippingLocation">The <see cref="ShippingLocation"/> object to created</param>
		public void CreateShippingLocation(ShippingLocation shippingLocation)
		{
			CallAsyncMethod(() => CreateShippingLocationAsync(shippingLocation).Wait());
		}

        /// <summary>
        /// Update an existing shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the location to update</param>
        /// <param name="shippingLocation">The full <see cref="ShippingLocation"/> including modified and unmodified properties</param>
		public void UpdateShippingLocation(string shippingLocationReference, ShippingLocation shippingLocation)
		{
			CallAsyncMethod(() => UpdateShippingLocationAsync(shippingLocationReference, shippingLocation).Wait());
		}

        /// <summary>
        /// Delete the specified shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to remove</param>
		public void DeleteShippingLocation(string shippingLocationReference)
		{
			CallAsyncMethod(() => DeleteShippingLocationAsync(shippingLocationReference).Wait());
		}

        /// <summary>
        /// Gets the full list of shipping locations for the current company, including those to which the current user has not been linked
        /// </summary>
        /// <returns>A list of <see cref="ShippingLocation"/></returns>
		public Task<List<ShippingLocation>> GetShippingLocationsAsync()
		{
			try
			{
			    var locations = Rest.GetAsync<List<ShippingLocation>>(string.Empty).Result ?? new List<ShippingLocation>();
				return Task.FromResult(locations
						.OrderBy(sl => sl.Name)
						.ToList());
			}
			catch (ApiException ex)
			{
				if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
				{
                    return Task.FromResult<List<ShippingLocation>>(null);
				}

				throw;
			}
		}

        /// <summary>
        /// Gets the list of shipping locations for your company to which your account has been linked
        /// </summary>
        /// <returns>A list of <see cref="ShippingLocation"/></returns>
	    public Task<List<ShippingLocation>> GetAssignedShippingLocationsAsync()
	    {
            try
            {
                var locations = Rest.GetAsync<List<ShippingLocation>>("assigned").Result ?? new List<ShippingLocation>();
                return Task.FromResult(locations.OrderBy(sl => sl.Name).ToList());
            }
            catch (ApiException ex)
            {
                if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
                {
                    return Task.FromResult<List<ShippingLocation>>(null);
                }

                throw;
            }
	    }

        /// <summary>
        /// Get a specific <see cref="ShippingLocation"/> by its reference
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to retrieve</param>
        /// <returns>The matching <see cref="ShippingLocation"/></returns>
		public Task<ShippingLocation> GetShippingLocationAsync(string shippingLocationReference)
		{
			try
			{
			    return Rest.GetAsync<ShippingLocation>(WebUtility.UrlEncode(shippingLocationReference));
			}
			catch (ApiException ex)
			{
				if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
				{
					return Task.FromResult<ShippingLocation>(null);
				}

				throw;
			}
		}

        /// <summary>
        /// Check whether the specified shipping location reference is available.
        /// <remarks>
        /// A reference will be deemed unavailable when it has previously been used for an existing shipping location 
        /// </remarks>
        /// </summary>
        /// <param name="shippingLocationReference">The shipping location reference to check</param>
        /// <returns><c>True</c> if the reference is available, otherwise <c>False</c></returns>
        public Task<bool> ShippingLocationReferenceAvailableAsync(string shippingLocationReference)
		{
			return Rest.GetAsync<bool>($"{WebUtility.UrlEncode(shippingLocationReference)}/available");
		}

        /// <summary>
        /// Creates a new Shipping Location with the given properties
        /// </summary>
        /// <param name="shippingLocation">The <see cref="ShippingLocation"/> object to created</param>
        public Task CreateShippingLocationAsync(ShippingLocation shippingLocation)
		{
			return Rest.PostAsync(shippingLocation, string.Empty);
		}

        /// <summary>
        /// Update an existing shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the location to update</param>
        /// <param name="shippingLocation">The full <see cref="ShippingLocation"/> including modified and unmodified properties</param>
        public Task UpdateShippingLocationAsync(string shippingLocationReference, ShippingLocation shippingLocation)
		{
			return Rest.PutAsync(shippingLocation, WebUtility.UrlEncode(shippingLocationReference));
		}

        /// <summary>
        /// Delete the specified shipping location
        /// </summary>
        /// <param name="shippingLocationReference">The reference of the shipping location to remove</param>
        public Task DeleteShippingLocationAsync(string shippingLocationReference)
		{
			return Rest.DeleteAsync(WebUtility.UrlEncode(shippingLocationReference));
		}
	}
}