using System.Threading.Tasks;

using MPD.Electio.SDK.DataTypes.Tracking;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Retrieves TrackingEvents for a Consignment
    /// </summary>
    public interface ITrackingService
	{
        /// <summary>
        /// 
        /// </summary>
        /// <param name="consignmentReference"></param>
        /// <returns></returns>
        ConsignmentViewModel GetTrackingEventsForEachPackageByConsignment(string consignmentReference);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consignmentReference"></param>
        /// <returns></returns>
        Task<ConsignmentViewModel> GetTrackingEventsForEachPackageByConsignmentAsync(string consignmentReference);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consignmentReference"></param>
        /// <returns></returns>
        FlattenedConsignmentViewModel GetFlattenedTrackingEventsForEachPackageByConsignment(string consignmentReference);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="consignmentReference"></param>
        /// <returns></returns>
        Task<FlattenedConsignmentViewModel> GetFlattenedTrackingEventsForEachPackageByConsignmentAsync(string consignmentReference);
    }
}
