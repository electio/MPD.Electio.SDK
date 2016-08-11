using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Interface for Package Size operations.
    ///
    /// Package Sizes are pre-configured package dimensions that can be used during
    /// creation of consignments instead of supplying the dimensions and weight with
    /// every request.
    /// </summary>
    public interface IPackageSizeService
	{
        /// <summary>
        /// Retrieves a list of all configured Package Sizes.
        /// </summary>
        /// <returns>List of Package Sizes</returns>
        List<PackageSize> GetPackageSizes();
        /// <summary>
        /// Creates a new Package Size
        /// </summary>
        /// <param name="packageSize">Size of the package.</param>
        void CreatePackageSize(PackageSize packageSize);
        /// <summary>
        /// Deletes a Package Size
        /// </summary>
        /// <param name="packageSizeReference">The package size reference.</param>
        void DeletePackageSize(string packageSizeReference);
        /// <summary>
        /// Updates an existing Package Size
        /// </summary>
        /// <param name="packageSizeReference">The package size reference.</param>
        /// <param name="packageSize">Size of the package.</param>
        void UpdatePackageSize(string packageSizeReference, PackageSize packageSize);
        /// <summary>
        /// Sets a specific package size as the default.
        /// </summary>
        /// <param name="packageSizeReference">The package size reference.</param>
        void SetDefaultPackageSize(string packageSizeReference);
        /// <summary>
        /// Gets the default Package Size.
        /// </summary>
        /// <returns></returns>
        PackageSize GetDefaultPackageSize();
		Task<List<PackageSize>> GetPackageSizesAsync();
		Task CreatePackageSizeAsync(PackageSize packageSize);
		Task DeletePackageSizeAsync(string packageSizeReference);
		Task UpdatePackageSizeAsync(string packageSizeReference, PackageSize packageSize);
		Task SetDefaultPackageSizeAsync(string packageSizeReference);
		Task<PackageSize> GetDefaultPackageSizeAsync();
	}
}