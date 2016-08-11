using System.Collections.Generic;
using System.Threading.Tasks;

using MPD.Electio.SDK.DataTypes.Reports;

namespace MPD.Electio.SDK.Interfaces.Services
{
	public interface IReportService
	{
        DownloadReportResponse Download(string reportReference);
        Task<DownloadReportResponse> DownloadAsync(string reportReference);
        List<ReportContract> GetReports();
        Task<List<ReportContract>> GetReportsAsync();
		void RequestReport(CreateReportRequest request);
        Task RequestReportAsync(CreateReportRequest request);

		/// <summary>
		/// Gets a saved filterset with the given ID.
		/// </summary>
		/// <param name="id">The ID of the filter set to retrieve.</param>
		/// <returns>Filterset with the given ID.</returns>
		ReportFilterSet GetFilterSet(int id);

		/// <summary>
		/// Creates a new filter set returning the created filterset poipulated with its ID.
		/// </summary>
		/// <param name="filterSet">The filter set to create.</param>
		/// <returns>The created FilterSet which will include its ID</returns>
		ReportFilterSet CreateFilterSet(ReportFilterSet filterSet);

		/// <summary>
		/// Updates an existing filter set.
		/// </summary>
		/// <param name="filterSet">The filter set which will be updated.</param>
		void UpdateFilterSet(ReportFilterSet filterSet);

		/// <summary>
		/// Asynchronously gets a saved filterset with the given ID.
		/// </summary>
		/// <param name="id">The ID of the filter set to retrieve.</param>
		/// <returns>Filterset with the given ID.</returns>
		Task<ReportFilterSet> GetFilterSetAsync(int id);

		/// <summary>
		/// Asynchronously creates a new filter set returning the created filterset poipulated with its ID.
		/// </summary>
		/// <param name="filterSet">The filter set to create.</param>
		/// <returns>The created FilterSet which will include its ID</returns>
		Task<ReportFilterSet> CreateFilterSetAsync(ReportFilterSet filterSet);

		/// <summary>
		/// Asynchronously updates an existing filter set.
		/// </summary>
		/// <param name="filterSet">The filter set which will be updated.</param>
		Task UpdateFilterSetAsync(ReportFilterSet filterSet);

		/// <summary>
		/// Gets the filter sets for the current customer.
		/// </summary>
		/// <returns>Enumeration of filter sets for the customer</returns>
		IEnumerable<ReportFilterSet> GetFilterSetsForCustomer();

		/// <summary>
		/// Gets the filter sets for the current customer asynchronously.
		/// </summary>
		/// <returns>Array of filter sets for the customer</returns>
		Task<ReportFilterSet[]> GetFilterSetsForCustomerAsync();

		/// <summary>
		/// Deletes the filter set with the given ID.
		/// </summary>
		/// <param name="id">The ID of the filter set.</param>
		void DeleteFilterSet(int id);

		/// <summary>
		/// Deletes the filter set with the given ID.
		/// </summary>
		/// <param name="id">The ID of the filter set to delete.</param>
		/// <returns>Task to await.</returns>
		Task DeleteFilterSetAsync(int id);
	}
}
