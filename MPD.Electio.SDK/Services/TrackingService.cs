using System;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.DataTypes.Tracking;
using MPD.Electio.SDK.Error;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Service for retrieving tracking events for consignments / packages
    /// </summary>
	public class TrackingService : BaseService, ITrackingService
	{

        /// <summary>
        /// Get tracking events
        /// </summary>
        /// <param name="apiKey">The api key of the user making the request</param>
        /// <param name="endpoints">An instance of <see cref="IEndpoints"/></param>
        /// <param name="log">A logger implenting <see cref="ILogger"/></param>
        public TrackingService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Tracking, log)
        {
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consignmentReference"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public FlattenedConsignmentViewModel GetFlattenedTrackingEventsForEachPackageByConsignment(string consignmentReference)
        {
            return CallAsyncMethod(() => GetFlattenedTrackingEventsForEachPackageByConsignmentAsync(consignmentReference).Result);
        }

        public Task<FlattenedConsignmentViewModel> GetFlattenedTrackingEventsForEachPackageByConsignmentAsync(string consignmentReference)
        {
            try
            {
                return Rest.GetAsync<FlattenedConsignmentViewModel>("flattened/" + WebUtility.UrlEncode(consignmentReference));
            }
            catch (ApiException ex)
            {
                Log.Trace("GetFlattenedTrackingEventsForEachPackageByConsignmentAsync encountered an Exception - {0}", ex);
                if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
                {
                    Log.Trace("GetFlattenedTrackingEventsForEachPackageByConsignmentAsync received a 404 - Not Found. Returning null");
                    return Task.FromResult<FlattenedConsignmentViewModel>(null);
                }

                throw;
            }
        }

        /// <summary>
        /// Get tracking events for all packages for the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the <see cref="Consignment"/> to retrieve packages for</param>
        /// <returns>A <see cref="ConsignmentViewModel"/> contains details of tracking events for each package</returns>
        public ConsignmentViewModel GetTrackingEventsForEachPackageByConsignment(string consignmentReference)
        {
            return CallAsyncMethod(() => GetTrackingEventsForEachPackageByConsignmentAsync(consignmentReference).Result);
        }

        /// <summary>
        /// Get tracking events for all packages for the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the <see cref="Consignment"/> to retrieve packages for</param>
        /// <returns>A <see cref="ConsignmentViewModel"/> contains details of tracking events for each package</returns>
        public Task<ConsignmentViewModel> GetTrackingEventsForEachPackageByConsignmentAsync(string consignmentReference)
        {
            try
            {
				return Rest.GetAsync<ConsignmentViewModel>(WebUtility.UrlEncode(consignmentReference));
            }
            catch (ApiException ex)
            {
                Log.Trace("GetTrackingEventsForEachPackageByConsignmentAsync encountered an Exception - {0}", ex);
                if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
                {
                    Log.Trace("GetTrackingEventsForEachPackageByConsignmentAsync received a 404 - Not Found. Returning null");
                    return Task.FromResult<ConsignmentViewModel>(null);
                }

                throw;
            }
        }
	}
}