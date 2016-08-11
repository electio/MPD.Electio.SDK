using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Consignment allocation service.
    /// </summary>
    public interface IConsignmentAllocationService
    {
        /// <summary>
        /// Allocates the consignments using default allocation rules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        List<WithMessage<string>> AllocateConsignments(AllocateConsignmentsRequest request);
        /// <summary>
        /// Allocates the consignments using default allocation rules.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateConsignmentsRequest request);
        /// <summary>
        /// Allocates the consignments with the specific carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        List<WithMessage<string>> AllocateConsignments(AllocateConsignmentsWithCarrierServiceRequest request);
        /// <summary>
        /// Allocates the consignments with the specific carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateConsignmentsWithCarrierServiceRequest request);
        /// <summary>
        /// Allocates the consignments using the specific carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        List<WithMessage<string>> AllocateConsignments(AllocateConsignmentsWithServiceGroupRequest request);
        /// <summary>
        /// Allocates the consignments using the specific carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateConsignmentsWithServiceGroupRequest request);
        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        List<WithMessage<string>> AllocateConsignments(AllocateAllConsignmentsRequest request);
        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateAllConsignmentsRequest request);
        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time with the specified carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        List<WithMessage<string>> AllocateConsignments(AllocateAllConsignmentsWithCarrierServiceRequest request);
        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time with the specified carrier service.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateAllConsignmentsWithCarrierServiceRequest request);
        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time within the specified carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        List<WithMessage<string>> AllocateConsignments(AllocateAllConsignmentsWithServiceGroupRequest request);
        /// <summary>
        /// Allocates all unallocated consignments due to be shipped before the specified date/time within the specified carrier service group.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<List<WithMessage<string>>> AllocateConsignmentsAsync(AllocateAllConsignmentsWithServiceGroupRequest request);

        /// <summary>
        /// Allocates the consignment using the default allocation rules.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        void AllocateConsignment(string consignmentReference);
        /// <summary>
        /// Allocates the consignment using the default allocation rules.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns></returns>
        Task AllocateConsignmentAsync(string consignmentReference);
        /// <summary>
        /// Allocates the consignment with the specfied quote.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="quoteReference">The quote reference.</param>
        void AllocateConsignment(string consignmentReference, Guid quoteReference);
        /// <summary>
        /// Allocates the consignment with the specfied quote.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="quoteReference">The quote reference.</param>
        /// <returns></returns>
        Task AllocateConsignmentAsync(string consignmentReference, Guid quoteReference);
        /// <summary>
        /// Allocates the consignment using a service in the specified MPD Carrier Service Group
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="mpdCarrierServiceGroupReference">The MPD Carrier Service Group Reference.</param>
        void AllocateConsignment(string consignmentReference, string mpdCarrierServiceGroupReference);
        /// <summary>
        /// Allocates the consignment using a service in the specified MPD Carrier Service Group
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="mpdCarrierServiceGroupReference">The MPD Carrier Service Group Reference.</param>
        /// <returns></returns>
        Task AllocateConsignmentAsync(string consignmentReference, string mpdCarrierServiceGroupReference);
    }
}
