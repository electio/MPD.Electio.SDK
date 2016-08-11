using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Interface for Resetting Caches.
    /// </summary>
    public interface IResetCache
    {
        /// <summary>
        /// Resets the cache.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="customerReference">The customer Reference.</param>
        void ResetCache(Guid secretKey, string customerReference);
        /// <summary>
        /// Resets the cache.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        /// <param name="customerReference">The customer Reference.</param>
        /// <returns>Task to await.</returns>
        Task ResetCacheAsync(Guid secretKey, string customerReference);
    }
}
