using System;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    public class PackagesService : BaseService, IPackagesService
    {

        public PackagesService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Packages, log)
        {
		}

        public void UpdatePackage(UpdatePackageRequest request)
        {
            CallAsyncMethod(() => UpdatePackageAsync(request).Wait());
        }

        public Task UpdatePackageAsync(UpdatePackageRequest request)
        {
            return Rest.PutAsync(request, WebUtility.UrlEncode(request.Reference));
        }

        public void DeletePackage(string packageReference)
        {
            CallAsyncMethod(() => DeletePackageAsync(packageReference).Wait());
        }

        public Task DeletePackageAsync(string packageReference)
        {
            return Rest.DeleteAsync(WebUtility.UrlEncode(packageReference));
        }

        public void AutoSplitPackage(string packageReference)
        {
            CallAsyncMethod(() => AutoSplitPackageAsync(packageReference).Wait());
        }

        public Task AutoSplitPackageAsync(string packageReference)
        {
            return Rest.PutAsync(string.Empty, string.Format("{0}/split", WebUtility.UrlEncode(packageReference)));
        }

        /// <summary>
        /// Set the reference provided by customer on the specified package.
        /// </summary>
        /// <param name="packageReference">The package reference.</param>
        /// <param name="request">The request.</param>
        public void SetCustomerProvidedReference(string packageReference, ReferenceProvidedByCustomerRequest request)
        {
            CallAsyncMethod(() => SetCustomerProvidedReferenceAsync(packageReference, request).Wait());
        }

        /// <summary>
        /// Asynchronously set the reference provided by customer on the specified package.
        /// </summary>
        /// <param name="packageReference">The package reference.</param>
        /// <param name="request">The request.</param>
        public Task SetCustomerProvidedReferenceAsync(string packageReference, ReferenceProvidedByCustomerRequest request)
        {
            return Rest.PutAsync(request, $"{WebUtility.UrlEncode(packageReference)}/setCustomerProvidedReference");
        }
    }
}