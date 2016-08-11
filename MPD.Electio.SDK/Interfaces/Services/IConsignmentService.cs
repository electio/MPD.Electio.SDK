using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Common.Enums;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using Address = MPD.Electio.SDK.DataTypes.Consignments.Address;

namespace MPD.Electio.SDK.Interfaces.Services
{

    /// <summary>
    /// Consignment Service
    /// </summary>
    public interface IConsignmentService
	{
        /// <summary>
        /// Gets the status of the given consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>Consignment status</returns>
        ConsignmentStatusResponse GetStatus(string consignmentReference);
        
        /// <summary>
        /// Gets the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>Consignment</returns>
        Consignment GetConsignment(string consignmentReference);
        
        /// <summary>
        /// Gets the consignment with all associated meta data.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>Consignment</returns>
        Consignment GetConsignmentWithMetaData(string consignmentReference);

        /// <summary>
        /// Gets the consignment without any associated metadata
        /// </summary>
        /// <param name="consignmentReference"></param>
        /// <returns></returns>
        Consignment GetConsignmentOnly(string consignmentReference);
        
        /// <summary>
        /// Gets the state of the count of consignments in the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <returns>Count of the number of consignments</returns>
        int GetCountOfConsignmentsInState(ConsignmentState? state);
        
        /// <summary>
        /// Deallocates the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        void DeallocateConsignment(string consignmentReference);
        
        /// <summary>
        /// Cancels the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        void CancelConsignment(string consignmentReference);
        
        /// <summary>
        /// Creates a new consignment within Electio.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>ApiLink to newly created consignment</returns>
        List<ApiLink> CreateConsignment(CreateConsignmentRequest request);

        /// <summary>
        /// Add a new package to the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to add the package to</param>
        /// <param name="request">An <see cref="UpdatePackageRequest"/></param>
        /// <returns>The details of the added package. <see cref="Package"/></returns>
        Package AddPackageToConsignment(string consignmentReference, UpdatePackageRequest request);

        /// <summary>
        /// Remove the specified package from the consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to remove the package from</param>
        /// <param name="packageReferenceForAllLegsAssignedByMpd">The reference of the package to remove</param>
        void RemovePackageFromConsignment(string consignmentReference, string packageReferenceForAllLegsAssignedByMpd);

        /// <summary>
        /// Add new empty package(s) to the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to add package(s) to</param>
        /// <param name="numberOfPackages">The number of packages to add</param>
        /// <returns>The number of packages added</returns>
        int AddEmptyPackagesToConsignment(string consignmentReference, int numberOfPackages);
        
        /// <summary>
        /// Gets the audit messages for the specified consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>List of audit messages</returns>
        List<ConsignmentAuditMessage> GetAuditMessages(string consignmentReference);

        /// <summary>
        /// Manifest a list of consignments
        /// <remarks>
        /// To manifest a single consignment provide a list of 1 consignment reference
        /// </remarks>
        /// </summary>
        /// <param name="request">A <see cref="ManifestConsignmentsRequest"/> containing the list of consignment references</param>
		void ManifestConsignments(ManifestConsignmentsRequest request);

        /// <summary>
        /// Update specified details of the consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to set details for</param>
        /// <param name="request">A <see cref="SetConsignmentDetailsRequest"/></param>
        void SetConsignmentDetails(string consignmentReference, SetConsignmentDetailsRequest request);
        
        /// <summary>
        /// Searches the consignments.
        /// </summary>
        /// <param name="searchTerms">The search terms.</param>
        /// <returns>Matching consignments</returns>
        MatchingConsignmentsResponse SearchConsignments(ConsignmentSearchTerms searchTerms);

        /// <summary>
        /// Get a summary of late consignments
        /// </summary>
        /// <param name="searchTerms">Search filters. <see cref="ConsignmentSearchTerms"/></param>
        /// <returns></returns>
        LateConsignmentsResponse GetLateConsignments(ConsignmentSearchTerms searchTerms);

        /// <summary>
        /// Update the specified address of the consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to update the address of</param>
        /// <param name="address">The address.</param>
        void UpdateConsignmentAddress(string consignmentReference, Address address);

        /// <summary>
        /// Get a list of customer manifests
        /// </summary>
        /// <returns><see cref="List{ManifestFileInfo}"/></returns>
        List<ManifestFileInfo> GetCustomerManifests();

        /// <summary>
        /// Get the specified customer manifest
        /// </summary>
        /// <param name="manifestReference">The reference of the manifest to retrieve</param>
        /// <returns></returns>
        byte[] GetCustomerManifest(string manifestReference);

        /// <summary>
        /// Set the reference provided by customer on the specified consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="request">The request.</param>
        void SetCustomerProvidedReference(string consignmentReference, ReferenceProvidedByCustomerRequest request);

        /// <summary>
        /// Updates the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to update</param>
        /// <param name="request">A <see cref="UpdateConsignmentRequest"/></param>
        /// <returns>The details of the updated <see cref="Consignment"/></returns>
        List<ApiLink> UpdateConsignment(UpdateConsignmentRequest request);


        /// <summary>
        /// Get the document of requested <see cref="CustomsDocType"/> for supplied package within supplied consignment
        /// </summary>
        /// <param name="customsDocType">Defines the type of customs document</param>
        /// <param name="consignmentReference">The reference of the manifest to retrieve</param>
        /// <param name="packageReference">The reference of the manifest to retrieve</param>
        /// <returns>The custom document of requested <see cref="CustomsDocType"/></returns>
        byte[] GetCustomsDocument(CustomsDocType customsDocType, string consignmentReference, string packageReference);



        /// <summary>
        /// Gets the status of the specified consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>Consignment status</returns>
        Task<ConsignmentStatusResponse> GetStatusAsync(string consignmentReference);

        /// <summary>
        /// Gets the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns><see cref="Task{Consignment}"/></returns>
        Task<Consignment> GetConsignmentAsync(string consignmentReference);

        /// <summary>
        /// Get the consignment without including metadata
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to retrieve</param>
        /// <returns><see cref="Task{Consignment}"/></returns>
        Task<Consignment> GetConsignmentOnlyAsync(string consignmentReference);

        /// <summary>
        /// Get consignment with metadata asynchronously
        /// </summary>
        /// <param name="consignmentReference"></param>
        /// <returns><see cref="Task{Consignment}"/></returns>
        Task<Consignment> GetConsignmentWithMetaDataAsync(string consignmentReference);
        
        /// <summary>
        /// Gets the count of the number of consignments in the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        /// <returns>Number of consignments</returns>
        Task<int> GetCountOfConsignmentsInStateAsync(ConsignmentState? state);
        
        /// <summary>
        /// Deallocates the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>Task</returns>
        Task DeallocateConsignmentAsync(string consignmentReference);
        
        /// <summary>
        /// Cancels the consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>Task</returns>
        Task CancelConsignmentAsync(string consignmentReference);
        
        /// <summary>
        /// Creates the consignment.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task<List<ApiLink>> CreateConsignmentAsync(CreateConsignmentRequest request);

        /// <summary>
        /// Asynchronously add a package to the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to add the package to</param>
        /// <param name="request">A <see cref="UpdatePackageRequest"/></param>
        /// <returns><see cref="Task{Package}"/></returns>
        Task<Package> AddPackageToConsignmentAsync(string consignmentReference, UpdatePackageRequest request);

        /// <summary>
        /// Remove the specified package from the consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment</param>
        /// <param name="packageReferenceForAllLegsAssignedByMpd">The reference of the package to remove</param>
        Task RemovePackageFromConsignmentAsync(string consignmentReference, string packageReferenceForAllLegsAssignedByMpd);

        /// <summary>
        /// Add empty package(s) to the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment to add package(s) to</param>
        /// <param name="numberOfPackages">The number of packages to add</param>
        /// <returns>The number of packages added</returns>
        Task<int> AddEmptyPackagesToConsignmentAsync(string consignmentReference, int numberOfPackages);
        
        /// <summary>
        /// Gets the audit messages for the given consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>List of audit messages</returns>
        Task<List<ConsignmentAuditMessage>> GetAuditMessagesAsync(string consignmentReference);

        /// <summary>
        /// Asynchronously manifest consignments
        /// </summary>
        /// <param name="request">A list of consignment references. <see cref="ManifestConsignmentsRequest"/></param>
        /// <returns><see cref="Task"/></returns>
        Task ManifestConsignmentsAsync(ManifestConsignmentsRequest request);

        /// <summary>
        /// Asynchronously set the details of the specified consignment
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment</param>
        /// <param name="request"><see cref="SetConsignmentDetailsRequest"/></param>
        /// <returns><see cref="Task"/></returns>
        Task SetConsignmentDetailsAsync(string consignmentReference, SetConsignmentDetailsRequest request);

        /// <summary>
        /// Asynchronously search for consignments
        /// </summary>
        /// <param name="searchTerms">Consignment search terms. <see cref="ConsignmentSearchTerms"/></param>
        /// <returns></returns>
        Task<MatchingConsignmentsResponse> SearchConsignmentsAsync(ConsignmentSearchTerms searchTerms);

        /// <summary>
        /// Asynchronously get late consignments
        /// </summary>
        /// <param name="searchTerms">Consignment search terms. <see cref="ConsignmentSearchTerms"/></param>
        /// <returns><see cref="Task{LateConsignmentsResponse}"/></returns>
        Task<LateConsignmentsResponse> GetLateConsignmentsAsync(ConsignmentSearchTerms searchTerms);

        /// <summary>
        /// Asynchronously update the consignment address
        /// </summary>
        /// <param name="consignmentReference">The reference of the consignment</param>
        /// <param name="address">The address.</param>
        /// <returns>
        ///   <see cref="Task" />
        /// </returns>
        Task UpdateConsignmentAddressAsync(string consignmentReference, Address address);

        /// <summary>
        /// Asynchronously get a list of customer manifests
        /// </summary>
        /// <returns><see cref="List{ManifestFileInfo}"/></returns>
        Task<List<ManifestFileInfo>> GetCustomerManifestsAsync();

        /// <summary>
        /// Asynchronously retrieve the specified manifest
        /// </summary>
        /// <param name="manifestReference">The reference of the manifest</param>
        /// <returns>A byte array</returns>
        Task<byte[]> GetCustomerManifestAsync(string manifestReference);

        /// <summary>
        /// Asynchronously set the reference provided by customer on the specified consignment.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="request">The request.</param>
        /// <returns></returns>
        Task SetCustomerProvidedReferenceAsync(string consignmentReference, ReferenceProvidedByCustomerRequest request);

        /// <summary>
        /// Asynchronously update the specified consignment
        /// </summary>
        /// <param name="request">A <see cref="UpdateConsignmentRequest"/></param>
        /// <returns>A <see cref="Task{Consignment}"/></returns>
        Task<List<ApiLink>> UpdateConsignmentAsync(UpdateConsignmentRequest request);

        /// <summary>
        /// Asynchronously get the document for supplied package within supplied consignment
        /// </summary>
        /// <param name="customsDocType">Customs document type</param>
        /// <param name="consignmentReference">The reference of the manifest to retrieve</param>
        /// <param name="packageReference">The reference of the manifest to retrieve</param>
        /// <returns></returns>
        Task<byte[]> GetCustomsDocumentAsync(CustomsDocType customsDocType, string consignmentReference, string packageReference);

        GetCustomsDocumentationResponse GetCustomsDocumentation(string consignmentReference);

        Task<GetCustomsDocumentationResponse> GetCustomsDocumentationAsync(string consignmentReference);
    }
}
