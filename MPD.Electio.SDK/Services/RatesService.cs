using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    public class RatesService : BaseService, IResetCache
    {
        public RatesService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Quotes, log)
        {
        }

        /// <summary>
		/// Resets the cache, purging all Rates data from memory and reloading from the
		/// backing data store.
		/// </summary>
		/// <param name="secretKey">The secret key.</param>
		/// <param name="customerReference">The customer Reference.</param>
		public void ResetCache(Guid secretKey, string customerReference)
        {
            ResetCacheAsync(secretKey, customerReference).Wait();
        }

        /// <summary>
        /// Resets the cache, purging all Rates data from memory and reloading from the
        /// backing data store.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="customerReference">The customer Reference.</param>
        /// <returns>
        /// Task to await.
        /// </returns>
        public Task ResetCacheAsync(Guid secretKey, string customerReference)
        {
            return Rest.GetAsync(string.IsNullOrEmpty(customerReference) ? $"refresh/{secretKey}" : $"refresh/{secretKey}/{customerReference}");
        }
    }
}
