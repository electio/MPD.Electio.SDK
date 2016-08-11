using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.Error;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Default Electio implementation of IPackageSizeService
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Services.BaseService" />
    /// <seealso cref="MPD.Electio.SDK.Interfaces.Services.IPackageSizeService" />
    public class PackageSizeService : BaseService, IPackageSizeService
	{
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageSizeService" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        public PackageSizeService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.PackageSize, log)
        {
		}

        /// <summary>
        /// Retrieves a list of all configured Package Sizes.
        /// </summary>
        /// <returns>
        /// List of Package Sizes
        /// </returns>
        public List<PackageSize> GetPackageSizes()
		{
			return CallAsyncMethod(() => GetPackageSizesAsync().Result);
		}

        /// <summary>
        /// Creates a new Package Size
        /// </summary>
        /// <param name="packageSize">Size of the package.</param>
        public void CreatePackageSize(PackageSize packageSize)
		{
			CallAsyncMethod(() => CreatePackageSizeAsync(packageSize).Wait());
		}

        /// <summary>
        /// Deletes a Package Size
        /// </summary>
        /// <param name="packageSizeReference">The package size reference.</param>
        public void DeletePackageSize(string packageSizeReference)
		{
			CallAsyncMethod(() => DeletePackageSizeAsync(packageSizeReference).Wait());
		}

        /// <summary>
        /// Updates an existing Package Size
        /// </summary>
        /// <param name="packageSizeReference">The package size reference.</param>
        /// <param name="packageSize">Size of the package.</param>
        public void UpdatePackageSize(string packageSizeReference, PackageSize packageSize)
		{
			CallAsyncMethod(() => UpdatePackageSizeAsync(packageSizeReference, packageSize).Wait());
		}

        /// <summary>
        /// Sets a specific package size as the default.
        /// </summary>
        /// <param name="packageSizeReference">The package size reference.</param>
        public void SetDefaultPackageSize(string packageSizeReference)
		{
			CallAsyncMethod(() => SetDefaultPackageSizeAsync(packageSizeReference).Wait());
		}

        /// <summary>
        /// Gets the default Package Size.
        /// </summary>
        /// <returns>
        /// The default Package Size
        /// </returns>
        public PackageSize GetDefaultPackageSize()
		{
			return CallAsyncMethod(() => GetDefaultPackageSizeAsync().Result);
		}
		public Task<List<PackageSize>> GetPackageSizesAsync()
		{
			return Rest.GetAsync<List<PackageSize>>(String.Empty);
		}

		public Task CreatePackageSizeAsync(PackageSize packageSize)
		{
			return Rest.PostAsync(packageSize, String.Empty);
		}

		public Task DeletePackageSizeAsync(string packageSizeReference)
		{
			return Rest.DeleteAsync(packageSizeReference.ToString());
		}

		public Task UpdatePackageSizeAsync(string packageSizeReference, PackageSize packageSize)
		{
			return Rest.PutAsync(packageSize, packageSizeReference.ToString());
		}

		public Task SetDefaultPackageSizeAsync(string packageSizeReference)
		{
			return Rest.PutAsync<string>(null, String.Format("{0}/default", packageSizeReference));
		}

		public Task<PackageSize> GetDefaultPackageSizeAsync()
		{
			try
			{
				return Rest.GetAsync<PackageSize>("default");
			}
			catch (ApiException ex)
			{
				if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
				{
					return Task.FromResult<PackageSize>(null);
				}

				throw;
			}
		}
	}
}