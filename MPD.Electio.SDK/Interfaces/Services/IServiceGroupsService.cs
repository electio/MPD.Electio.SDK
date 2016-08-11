using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Interface for interacting with MPD Carrier Service Groups.
    /// </summary>
    public interface IServiceGroupsService
	{
        /// <summary>
        /// Gets a list of all MPD Carrier Service groups.
        /// </summary>
        /// <returns>List of MPD Carrier Service Groups</returns>
        List<MpdCarrierServiceGroup> GetServiceGroups();
		List<MpdCarrierServiceGroup> GetServiceGroupSummaries();
        /// <summary>
        /// Gets the MPD Carrier Service group.
        /// </summary>
        /// <param name="serviceGroupReference">The service group reference.</param>
        /// <returns>MPDCarrierServiceGroup</returns>
        MpdCarrierServiceGroup GetServiceGroup(string serviceGroupReference);
		MpdCarrierServiceGroup GetServiceGroupSummary(string serviceGroupReference);
		bool IsServiceGroupReferenceAvailable(string serviceGroupReference);
        /// <summary>
        /// Creates a new MPD Carrier Service group containing all of the MPD
        /// Carrier Services defined in the request.
        /// </summary>
        /// <param name="serviceGroup">The service group.</param>
        /// <returns>The created MPD Carrier Service Group</returns>
        MpdCarrierServiceGroup CreateServiceGroup(MpdCarrierServiceGroup serviceGroup);
		void UpdateServiceGroup(string serviceGroupReference, MpdCarrierServiceGroup serviceGroup);
		void DeleteServiceGroup(string serviceGroupReference);
		Task<List<MpdCarrierServiceGroup>> GetServiceGroupsAsync();
		Task<List<MpdCarrierServiceGroup>> GetServiceGroupSummariesAsync();
		Task<MpdCarrierServiceGroup> GetServiceGroupAsync(string serviceGroupReference);
		Task<MpdCarrierServiceGroup> GetServiceGroupSummaryAsync(string serviceGroupReference);
		Task<bool> IsServiceGroupReferenceAvailableAsync(string serviceGroupReference);
		Task<MpdCarrierServiceGroup> CreateServiceGroupAsync(MpdCarrierServiceGroup serviceGroup);
		Task UpdateServiceGroupAsync(string serviceGroupReference, MpdCarrierServiceGroup serviceGroup);
		Task  DeleteServiceGroupAsync(string serviceGroupReference);
	}
}