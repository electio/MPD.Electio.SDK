using System;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.LabelGeneration;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Service for retrieving labels
    /// </summary>
	public interface ILabelService
	{
        /// <summary>
        /// Get labels using a <see cref="GetLabelsRequest"/>
        /// </summary>
        /// <param name="request">The parameters for the request. <see cref="GetLabelsRequest"/></param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
        [Obsolete("Please use the GetLabels('consignmentReference') method")]
		GetLabelsResponse GetLabels(GetLabelsRequest request);

        /// <summary>
        /// Asynchronously get labels using a <see cref="GetLabelsRequest"/>
        /// </summary>
        /// <param name="request">The parameters for the request. <see cref="GetLabelsRequest"/></param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
        [Obsolete("Please use the GetLabelsAsync('consignmentReference') method.")]
		Task<GetLabelsResponse> GetLabelsAsync(GetLabelsRequest request);

        /// <summary>
        /// Get labels for the specified consignment reference
        /// </summary>
        /// <param name="consignmentReference">The consignment reference to retrieve labels for</param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
        GetLabelsResponse GetLabels(string consignmentReference);

        /// <summary>
        /// Get labels for the specified consignment reference
        /// </summary>
        /// <param name="consignmentReference">The consignment reference to retrieve labels for</param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
        Task<GetLabelsResponse> GetLabelsAsync(string consignmentReference);
	}
}