using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Consignment Allocation Service
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Services.BaseService" />
    /// <seealso cref="MPD.Electio.SDK.Interfaces.Services.IConsignmentAllocationService" />
    public class ConsignmentAllocationService : BaseService, IConsignmentAllocationService
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsignmentAllocationService"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        /// <exception cref="System.ArgumentNullException">endpoints</exception>
        /// <exception cref="System.ArgumentException">You must supply an api key;apiKey</exception>
        public ConsignmentAllocationService(string apiKey, IEndpoints endpoints, ILogger log) : base( apiKey, endpoints, endpoints.ConsignmentAllocation, log)
		{
		}

        /// <summary>
        /// Allocates the specified consignments using default allocation rules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public List<WithMessage<string>> AllocateConsignments(AllocateConsignmentsRequest request)
		{
			return CallAsyncMethod(() => AllocateConsignmentsAsync(request).Result);
		}
        /// <summary>
        /// Allocates the consignments using default allocation rules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateConsignmentsRequest request)
        {
            return Rest.PutAsync<AllocateConsignmentsRequest, List<WithMessage<string>>>(request, "allocate");
        }

        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public List<WithMessage<string>> AllocateConsignments(AllocateAllConsignmentsRequest request)
	    {
	        return CallAsyncMethod(() => AllocateConsignmentsAsync(request).Result);
	    }

        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateAllConsignmentsRequest request)
	    {
	        return Rest.PutAsync<string, List<WithMessage<string>>>(string.Empty, string.Format("allocate/{0}", request.ShipByDate));
	    }

        /// <summary>
        /// Allocates the specified consignments with the specific carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public List<WithMessage<string>> AllocateConsignments(AllocateConsignmentsWithCarrierServiceRequest request)
	    {
            return CallAsyncMethod(() => AllocateConsignmentsAsync(request).Result);
	    }

        /// <summary>
        /// Allocates the specified consignments with the specific carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateConsignmentsWithCarrierServiceRequest request)
	    {
            return Rest.PutAsync<AllocateConsignmentsRequest, List<WithMessage<string>>>(request, "allocateWithCarrierService");
	    }

        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time with the specified carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public List<WithMessage<string>> AllocateConsignments(AllocateAllConsignmentsWithCarrierServiceRequest request)
        {
            return CallAsyncMethod(() => AllocateConsignmentsAsync(request).Result);
        }

        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time with the specified carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateAllConsignmentsWithCarrierServiceRequest request)
        {
            return Rest.PutAsync<AllocateAllConsignmentsWithCarrierServiceRequest, List<WithMessage<string>>>(request, string.Format("allocateWithCarrierService/{0}", request.ShipByDate));
        }

        /// <summary>
        /// Allocates the consignments using the specific carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public List<WithMessage<string>> AllocateConsignments(AllocateConsignmentsWithServiceGroupRequest request)
	    {
            return CallAsyncMethod(() => AllocateConsignmentsAsync(request).Result);
	    }

        /// <summary>
        /// Allocates the consignments using the specific carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateConsignmentsWithServiceGroupRequest request)
	    {
            return Rest.PutAsync<AllocateConsignmentsRequest, List<WithMessage<string>>>(request, "allocateWithServiceGroup");
	    }

        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time within the specified carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public List<WithMessage<string>> AllocateConsignments(AllocateAllConsignmentsWithServiceGroupRequest request)
        {
            return CallAsyncMethod(() => AllocateConsignmentsAsync(request).Result);
        }

        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time within the specified carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        public Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateAllConsignmentsWithServiceGroupRequest request)
        {
            return Rest.PutAsync <AllocateAllConsignmentsWithServiceGroupRequest, List<WithMessage<string>>>(request, string.Format("allocateWithServiceGroup/{0}",request.ShipByDate));
        }

        /// <summary>
        /// Allocates the consignment using the default allocation rules.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        public void AllocateConsignment(string consignmentReference)
	    {
	       CallAsyncMethod(() =>  AllocateConsignmentAsync(consignmentReference).Wait());
	    }

        /// <summary>
        /// Allocates the consignment using the default allocation rules.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns></returns>
        public Task AllocateConsignmentAsync(string consignmentReference)
	    {
			return Rest.PutAsync("", string.Format("{0}/allocateWithCheapestQuote", consignmentReference));
	    }

        /// <summary>
        /// Allocates the consignment with the specfied quote.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="quoteReference">The quote reference.</param>
        public void AllocateConsignment(string consignmentReference, Guid quoteReference)
	    {
            CallAsyncMethod(() => AllocateConsignmentAsync(consignmentReference, quoteReference).Wait());
	    }

        /// <summary>
        /// Allocates the consignment with the specfied quote.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="quoteReference">The quote reference.</param>
        /// <returns></returns>
        public Task AllocateConsignmentAsync(string consignmentReference, Guid quoteReference)
	    {
            return Rest.PutAsync("", string.Format("{0}/allocateWithQuote/{1}", WebUtility.UrlEncode(consignmentReference), quoteReference));
	    }

        /// <summary>
        /// Allocates the consignment using a service in the specified MPD Carrier Service Group
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="mpdCarrierServiceGroupReference">The MPD Carrier Service Group Reference.</param>
        public void AllocateConsignment(string consignmentReference, string mpdCarrierServiceGroupReference)
        {
            CallAsyncMethod(() => AllocateConsignmentAsync(consignmentReference, mpdCarrierServiceGroupReference).Wait());
        }

        /// <summary>
        /// Allocates the consignment using a service in the specified MPD Carrier Service Group
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="mpdCarrierServiceGroupReference">The MPD Carrier Service Group Reference.</param>
        public Task AllocateConsignmentAsync(string consignmentReference, string mpdCarrierServiceGroupReference)
        {
            return Rest.PutAsync("", string.Format("{0}/allocateWithServiceGroup/{1}", consignmentReference, mpdCarrierServiceGroupReference));
        }
    }
}
