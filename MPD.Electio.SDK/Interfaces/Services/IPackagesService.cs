using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Represents the actions provided by the Packages services
    /// </summary>
    public interface IPackagesService
    {
        void UpdatePackage(UpdatePackageRequest request);
        Task UpdatePackageAsync(UpdatePackageRequest request);

        void DeletePackage(string packageReference);
        Task DeletePackageAsync(string packageReference);

        void AutoSplitPackage(string packageReference);

        Task AutoSplitPackageAsync(string packageReference);


        /// <summary>
        /// Set the reference provided by customer on the specified package.
        /// </summary>
        /// <param name="packageReference">The package reference.</param>
        /// <param name="request">The request.</param>
        void SetCustomerProvidedReference(string packageReference, ReferenceProvidedByCustomerRequest request);

        /// <summary>
        /// Asynchronously set the reference provided by customer on the specified package.
        /// </summary>
        /// <param name="packageReference">The package reference.</param>
        /// <param name="request">The request.</param>
        Task SetCustomerProvidedReferenceAsync(string packageReference, ReferenceProvidedByCustomerRequest request);

    }
}
