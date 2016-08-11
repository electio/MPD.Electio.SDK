using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;
using Address = MPD.Electio.SDK.DataTypes.Consignments.Address;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Consignment Service
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Services.BaseService" />
    /// <seealso cref="MPD.Electio.SDK.Interfaces.Services.IConsignmentService" />
    public class ConsignmentService : BaseService, IConsignmentService
	{
        /// <summary>
        /// RestConsumer for Create Consignment
        /// </summary>
        private readonly IRestConsumer _restCreate;
        private readonly IRestConsumer _restUpdate;
		private readonly IRestConsumer _consignmentsCustomerRest;
        private IRestConsumer _documentsCustomerRest;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsignmentService" /> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        /// <exception cref="System.ArgumentNullException">endpoints</exception>
        /// <exception cref="System.ArgumentException">You must supply an api key;apiKey</exception>
        public ConsignmentService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Consignment, log)
		{
            var createConfig = new RestConsumerConfiguration(endpoints.ConsignmentCreation, apiKey);
            _restCreate = new RestConsumer(createConfig, log);

            var updateConfig = new RestConsumerConfiguration(endpoints.ConsignmentUpdation, apiKey);
            _restUpdate = new RestConsumer(updateConfig, log);

            var customerConfig = new RestConsumerConfiguration(endpoints.ConsignmentCustomers, apiKey);
            _consignmentsCustomerRest = new RestConsumer(customerConfig, log);

            ConfigureConsignmentsDocumentsModule(apiKey, endpoints, log);
		}

        private void ConfigureConsignmentsDocumentsModule(string apiKey, IEndpoints endpoints, ILogger log)
        {
            var documentConfig = new RestConsumerConfiguration(endpoints.ConsignmentDocuments, apiKey);
            _documentsCustomerRest = new RestConsumer(documentConfig, log);
        }

        /// <summary>
        /// Gets the status of the given consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Consignment status
        /// </returns>
        public ConsignmentStatusResponse GetStatus(string consignmentReference)
		{
			return CallAsyncMethod(() => GetStatusAsync(consignmentReference).Result);
		}

        /// <summary>
        /// Gets the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Consignment
        /// </returns>
        public Consignment GetConsignment(string consignmentReference)
		{
			return CallAsyncMethod(() => GetConsignmentAsync(consignmentReference).Result);
		}

		public Consignment GetConsignmentOnly(string consignmentReference)
		{
			return CallAsyncMethod(() => GetConsignmentOnlyAsync(consignmentReference).Result);
		}

        /// <summary>
        /// Gets the consignment with all associated meta data.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Consignment
        /// </returns>
        public Consignment GetConsignmentWithMetaData(string consignmentReference)
		{
			return CallAsyncMethod(() => GetConsignmentWithMetaDataAsync(consignmentReference).Result);
		}

        /// <summary>
        /// Gets the state of the count of consignments in the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <returns>
        /// Count of the number of consignments
        /// </returns>
        public int GetCountOfConsignmentsInState(ConsignmentState? state)
		{
			return CallAsyncMethod(() => GetCountOfConsignmentsInStateAsync(state).Result);
		}

        /// <summary>
        /// Deallocates the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        public void DeallocateConsignment(string consignmentReference)
		{
			 CallAsyncMethod(() =>DeallocateConsignmentAsync(consignmentReference).Wait());
		}

        /// <summary>
        /// Cancels the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        public void CancelConsignment(string consignmentReference)
		{
			 CallAsyncMethod(() =>CancelConsignmentAsync(consignmentReference).Wait());
		}

        /// <summary>
        /// Creates the consignment.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>
        /// ApiLink to newly created consignment
        /// </returns>
        public List<ApiLink> CreateConsignment(CreateConsignmentRequest request)
		{
			return CallAsyncMethod(() => CreateConsignmentAsync(request).Result);
		}

		public Package AddPackageToConsignment(string consignmentReference, UpdatePackageRequest request)
		{
			return CallAsyncMethod(() => AddPackageToConsignmentAsync(consignmentReference, request).Result);
		}

		public void RemovePackageFromConsignment(string consignmentReference, string packageReferenceForAllLegsAssignedByMpd)
		{
			CallAsyncMethod(() => RemovePackageFromConsignmentAsync(consignmentReference, packageReferenceForAllLegsAssignedByMpd).Wait());
		}

		public int AddEmptyPackagesToConsignment(string consignmentReference, int numberOfPackages)
		{
			return CallAsyncMethod(() => AddEmptyPackagesToConsignmentAsync(consignmentReference, numberOfPackages).Result);
		}

        /// <summary>
        /// Gets the audit messages for the specified consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// List of audit messages
        /// </returns>
        public List<ConsignmentAuditMessage> GetAuditMessages(string consignmentReference)
		{
			return CallAsyncMethod(() => GetAuditMessagesAsync(consignmentReference).Result);
		}

		public void ManifestConsignments(ManifestConsignmentsRequest request)
		{
			CallAsyncMethod(() =>ManifestConsignmentsAsync(request).Wait());
		}

		public void SetConsignmentDetails(string consignmentReference, SetConsignmentDetailsRequest request)
		{
			CallAsyncMethod(() =>SetConsignmentDetailsAsync(consignmentReference, request).Wait());
		}

        /// <summary>
        /// Searches the consignments.
        /// </summary>
        /// <param name="searchTerms">The search terms.</param>
        /// <returns>
        /// Matching consignments
        /// </returns>
        public MatchingConsignmentsResponse SearchConsignments(ConsignmentSearchTerms searchTerms)
		{
			return CallAsyncMethod(() => SearchConsignmentsAsync(searchTerms).Result);
		}

		public LateConsignmentsResponse GetLateConsignments(ConsignmentSearchTerms searchTerms)
		{
			return CallAsyncMethod(() => GetLateConsignmentsAsync(searchTerms).Result);
		}

		public void UpdateConsignmentAddress(string consignmentReference, Address address)
		{
			CallAsyncMethod(() => UpdateConsignmentAddressAsync(consignmentReference, address).Wait());
		}

		public List<ManifestFileInfo> GetCustomerManifests()
		{
			return CallAsyncMethod(() => GetCustomerManifestsAsync().Result);
		}

        public byte[] GetCustomerManifest(string manifestReference)
        {
            return CallAsyncMethod(() => GetCustomerManifestAsync(manifestReference).Result);
        }

        public void SetCustomerProvidedReference(string consignmentReference, ReferenceProvidedByCustomerRequest request)
        {
            CallAsyncMethod(() => SetCustomerProvidedReferenceAsync(consignmentReference, request).Wait());
        }

        /// <summary>
        /// Updates the specified consignment
        /// </summary>
        /// <param name="request">A <see cref="UpdateConsignmentRequest"/></param>
        /// <returns>The details of the updated <see cref="Consignment"/></returns>
        public List<ApiLink> UpdateConsignment(UpdateConsignmentRequest request)
        {
            return CallAsyncMethod(() => UpdateConsignmentAsync(request).Result);
        }

        /// <summary>
        /// Get the document of requested <see cref="CustomsDocType"/> for given package of consignment
        /// </summary>
        /// <param name="customsDocType"></param>
        /// <param name="consignmentReference"></param>
        /// <param name="packageReference"></param>
        /// <returns>The document of requested <see cref="CustomsDocType"/></returns>
        public byte[] GetCustomsDocument(CustomsDocType customsDocType, string consignmentReference, string packageReference)
        {
            return CallAsyncMethod(() => GetCustomsDocumentAsync(customsDocType, consignmentReference, packageReference).Result);
        }

        public GetCustomsDocumentationResponse GetCustomsDocumentation(string consignmentReference)
        {
            return CallAsyncMethod(() => GetCustomsDocumentationAsync(consignmentReference).Result);
        }

        /// <summary>
        /// Gets the status of the specified consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Consignment status
        /// </returns>
        public Task<ConsignmentStatusResponse> GetStatusAsync(string consignmentReference)
		{
			return Rest.GetAsync<ConsignmentStatusResponse>(string.Format("{0}/status", WebUtility.UrlEncode(consignmentReference)));
		}

        /// <summary>
        /// Gets the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Consignment
        /// </returns>
        public Task<Consignment> GetConsignmentAsync(string consignmentReference)
		{
			return Rest.GetAsync<Consignment>(WebUtility.UrlEncode(consignmentReference));
		}

		public Task<Consignment> GetConsignmentOnlyAsync(string consignmentReference)
		{
			return Rest.GetAsync<Consignment>(string.Format("getconsignmentonly/{0}", WebUtility.UrlEncode(consignmentReference)));
		}

		public Task<Consignment> GetConsignmentWithMetaDataAsync(string consignmentReference)
		{
			return Rest.GetAsync<Consignment>(string.Format("getconsignmentwithmetadata/{0}", WebUtility.UrlEncode(consignmentReference)));
		}

        /// <summary>
        /// Gets the count of the number of consignments in the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <returns>
        /// Number of consignments
        /// </returns>
        public Task<int> GetCountOfConsignmentsInStateAsync(ConsignmentState? state)
		{
			var qs = Rest.BuildQueryString(new Dictionary<string,string>
			{
				{ "state", state.HasValue ? state.ToString() : string.Empty }
			});

			return Rest.GetAsync<int>(string.Format("count?{0}", qs));
		}

        /// <summary>
        /// Deallocates the consignment from the currently allocated MPD Carrier Service.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Task
        /// </returns>
        public Task DeallocateConsignmentAsync(string consignmentReference)
		{
			return Rest.PutAsync("", string.Format("{0}/deallocate", WebUtility.UrlEncode(consignmentReference)));
		}

        /// <summary>
        /// Cancels the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Task
        /// </returns>
        public Task CancelConsignmentAsync(string consignmentReference)
		{
			return Rest.PutAsync("", string.Format("{0}/cancel", WebUtility.UrlEncode(consignmentReference)));
		}

        /// <summary>
        /// Creates a new consignment.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<List<ApiLink>> CreateConsignmentAsync(CreateConsignmentRequest request)
		{
			return _restCreate.PostAsync<CreateConsignmentRequest, List<ApiLink>>(request, "");
		}

		public Task<Package> AddPackageToConsignmentAsync(string consignmentReference, UpdatePackageRequest request)
		{
			return Rest.PostAsync<UpdatePackageRequest, Package>(request, string.Format("{0}/addpackage", WebUtility.UrlEncode(consignmentReference)));
		}

		public Task RemovePackageFromConsignmentAsync(string consignmentReference, string packageReferenceForAllLegsAssignedByMpd)
		{
			return Rest.PostAsync("", string.Format("{0}/removepackage/{1}", consignmentReference, packageReferenceForAllLegsAssignedByMpd));
		}

		public Task<int> AddEmptyPackagesToConsignmentAsync(string consignmentReference, int numberOfPackages)
		{
			return Rest.PutAsync<string, int>("", string.Format("{0}/addpackages/{1}", WebUtility.UrlEncode(consignmentReference), numberOfPackages));
		}

        /// <summary>
        /// Gets the audit messages for the given consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// List of audit messages
        /// </returns>
        public Task<List<ConsignmentAuditMessage>> GetAuditMessagesAsync(string consignmentReference)
		{
			return Rest.GetAsync<List<ConsignmentAuditMessage>>(string.Format("{0}/audit", WebUtility.UrlEncode(consignmentReference)));
		}

		public Task ManifestConsignmentsAsync(ManifestConsignmentsRequest request)
		{
			return Rest.PutAsync(request, "manifest");
		}

		public Task SetConsignmentDetailsAsync(string consignmentReference, SetConsignmentDetailsRequest request)
		{
			return Rest.PutAsync(request, string.Format("{0}/details", WebUtility.UrlEncode(consignmentReference)));
		}

		public Task<MatchingConsignmentsResponse> SearchConsignmentsAsync(ConsignmentSearchTerms searchTerms)
		{

			return Rest.GetAsync<MatchingConsignmentsResponse>(string.Format("{0}?{1}",
                                                                BuildTakeSkipQuerySegment(searchTerms),
																Rest.BuildQueryString(searchTerms.ToDictionary())));

        }

        internal static string BuildTakeSkipQuerySegment(ConsignmentSearchTerms searchTerms)
        {
            var pageSize = searchTerms.PageSize.GetValueOrDefault(10);
            if (pageSize < 1)
                pageSize = 10;


            var pageNumber = searchTerms.StartPage.GetValueOrDefault(0);
            if (pageNumber < 0)
                pageNumber = 0;

            return $"{pageSize}/{pageSize * pageNumber}";
        }

        public Task<LateConsignmentsResponse> GetLateConsignmentsAsync(ConsignmentSearchTerms searchTerms)
		{
			return Rest.GetAsync<LateConsignmentsResponse>(string.Format("late?{0}", Rest.BuildQueryString(searchTerms.ToDictionary())));
		}

		public Task UpdateConsignmentAddressAsync(string consignmentReference, Address address)
		{
			return Rest.PostAsync(address, string.Format("{0}/updateconsignmentaddress", consignmentReference));
		}

		public Task<List<ManifestFileInfo>> GetCustomerManifestsAsync()
		{
			return _consignmentsCustomerRest.GetAsync<List<ManifestFileInfo>>("manifests");
		}

        public Task<byte[]> GetCustomerManifestAsync(string manifestReference)
        {
            return _consignmentsCustomerRest.GetAsync<byte[]>(string.Format("manifest/{0}", manifestReference));
        }

        /// <summary>
        /// Asynchronously set the reference provided by customer on the specified consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task SetCustomerProvidedReferenceAsync(string consignmentReference, ReferenceProvidedByCustomerRequest request)
        {
            return Rest.PutAsync(request, $"{WebUtility.UrlEncode(consignmentReference)}/setCustomerProvidedReference");
        }

        /// <summary>
        /// Asynchronously update the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to be updated</param>
        /// <param name="request">A <see cref="UpdateConsignmentRequest"/></param>
        /// <returns>Details of the updated consignment as a <see cref="Task{Consignment}"/></returns>
        public Task<List<ApiLink>> UpdateConsignmentAsync(UpdateConsignmentRequest request)
        {
            return _restUpdate.PutAsync<UpdateConsignmentRequest, List<ApiLink>>(request, "");
        }

        public Task<byte[]> GetCustomsDocumentAsync(CustomsDocType customsDocType, string consignmentReference, string packageReference)
        {
            if (customsDocType == CustomsDocType.CommercialInvoice)
                return _documentsCustomerRest.GetAsync<byte[]>(string.Format("{0}/{1}", customsDocType, consignmentReference));
            else
                return _documentsCustomerRest.GetAsync<byte[]>(string.Format("{0}/{1}/{2}", customsDocType, consignmentReference, packageReference));
        }

        public Task<GetCustomsDocumentationResponse> GetCustomsDocumentationAsync(string consignmentReference)
        {
            return _documentsCustomerRest.GetAsync<GetCustomsDocumentationResponse>(string.Format("{0}", consignmentReference));
        }
    }
}
