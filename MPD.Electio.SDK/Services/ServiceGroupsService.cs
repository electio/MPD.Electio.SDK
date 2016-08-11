using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
	public class ServiceGroupsService : BaseService, IServiceGroupsService
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceGroupsService"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        public ServiceGroupsService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.ServiceGroups, log)
        {
		}

        /// <summary>
        /// Gets a list of all MPD Carrier Service groups.
        /// </summary>
        /// <returns>
        /// List of MPD Carrier Service Groups
        /// </returns>
        public List<MpdCarrierServiceGroup> GetServiceGroups()
		{
			return CallAsyncMethod(() => GetServiceGroupsAsync().Result);
		}

		public List<MpdCarrierServiceGroup> GetServiceGroupSummaries()
		{
			return CallAsyncMethod(() => GetServiceGroupSummariesAsync().Result);
		}

        /// <summary>
        /// Gets the MPD Carrier Service group.
        /// </summary>
        /// <param name="serviceGroupReference">The service group reference.</param>
        /// <returns>
        /// MPDCarrierServiceGroup
        /// </returns>
        public MpdCarrierServiceGroup GetServiceGroup(string serviceGroupReference)
		{
			return CallAsyncMethod(() => GetServiceGroupAsync(serviceGroupReference).Result);
		}

		public MpdCarrierServiceGroup GetServiceGroupSummary(string serviceGroupReference)
		{
			return CallAsyncMethod(() => GetServiceGroupSummaryAsync(serviceGroupReference).Result);
		}

		public bool IsServiceGroupReferenceAvailable(string serviceGroupReference)
		{
			return CallAsyncMethod(() => IsServiceGroupReferenceAvailableAsync(serviceGroupReference).Result);
		}

        /// <summary>
        /// Creates a new MPD Carrier Service group containing all of the MPD
        /// Carrier Services defined in the request.
        /// </summary>
        /// <param name="serviceGroup">The service group.</param>
        /// <returns>
        /// The created MPD Carrier Service Group
        /// </returns>
        public MpdCarrierServiceGroup CreateServiceGroup(MpdCarrierServiceGroup serviceGroup)
		{
			return CallAsyncMethod(() => CreateServiceGroupAsync(serviceGroup).Result);
		}

		public void UpdateServiceGroup(string serviceGroupReference, MpdCarrierServiceGroup serviceGroup)
		{
			CallAsyncMethod(() => UpdateServiceGroupAsync(serviceGroupReference, serviceGroup).Wait());
		}

		public void DeleteServiceGroup(string serviceGroupReference)
		{
			CallAsyncMethod(() => DeleteServiceGroupAsync(serviceGroupReference).Wait());
		}

        public Task<List<MpdCarrierServiceGroup>> GetServiceGroupsAsync()
		{
			return Rest.GetAsync<List<MpdCarrierServiceGroup>>(String.Empty);
		}

		public Task<List<MpdCarrierServiceGroup>> GetServiceGroupSummariesAsync()
		{
			return Rest.GetAsync<List<MpdCarrierServiceGroup>>("summaries");
		}

		public Task<MpdCarrierServiceGroup> GetServiceGroupAsync(string serviceGroupReference)
		{
			return Rest.GetAsync<MpdCarrierServiceGroup>(WebUtility.UrlEncode(serviceGroupReference));
		}

		public Task<MpdCarrierServiceGroup> GetServiceGroupSummaryAsync(string serviceGroupReference)
		{
			return Rest.GetAsync<MpdCarrierServiceGroup>(String.Format("summary/{0}", WebUtility.UrlEncode(serviceGroupReference)));
		}

		public Task<bool> IsServiceGroupReferenceAvailableAsync(string serviceGroupReference)
		{
			return Rest.GetAsync<bool>(String.Format("{0}/available", WebUtility.UrlEncode(serviceGroupReference)));
		}

		public Task<MpdCarrierServiceGroup> CreateServiceGroupAsync(MpdCarrierServiceGroup serviceGroup)
		{
			return Rest.PostAsync<MpdCarrierServiceGroup, MpdCarrierServiceGroup>(serviceGroup, String.Empty);
		}

		public Task UpdateServiceGroupAsync(string serviceGroupReference, MpdCarrierServiceGroup serviceGroup)
		{
			return Rest.PutAsync<MpdCarrierServiceGroup, MpdCarrierServiceGroup>(serviceGroup, WebUtility.UrlEncode(serviceGroupReference));
		}

		public Task  DeleteServiceGroupAsync(string serviceGroupReference)
		{
			return Rest.DeleteAsync(WebUtility.UrlEncode(serviceGroupReference));
		}
	}
}