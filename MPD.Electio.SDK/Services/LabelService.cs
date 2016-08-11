using System;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.LabelGeneration;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Service for retrieving labels
    /// </summary>
	public class LabelService : BaseService, ILabelService
	{
        /// <summary>
        /// Service for retrieving labels
        /// </summary>
        /// <param name="apiKey">The api key of the user making the request</param>
        /// <param name="endpoints">An instance of <see cref="IEndpoints"/></param>
        /// <param name="log">A logger implementing <see cref="ILogger"/></param>
		public LabelService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.LabelGeneration, log)
        {
		}

        /// <summary>
        /// Get labels using a <see cref="GetLabelsRequest"/>
        /// </summary>
        /// <param name="request">The parameters for the request. <see cref="GetLabelsRequest"/></param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
        [Obsolete("Please use the GetLabels('consignmentReference') method")]
		public GetLabelsResponse GetLabels(GetLabelsRequest request)
		{
			return CallAsyncMethod(() => GetLabelsAsync(request).Result);
		}

        /// <summary>
        /// Get labels using a <see cref="GetLabelsRequest"/>
        /// </summary>
        /// <param name="request">The parameters for the request. <see cref="GetLabelsRequest"/></param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
        [Obsolete("Please use the GetLabelsAsync('consignmentReference') method")]
		public Task<GetLabelsResponse> GetLabelsAsync(GetLabelsRequest request)
		{
			return Rest.PostAsync<GetLabelsRequest, GetLabelsResponse>(request, "GetLabels");
		}

        /// <summary>
        /// Get labels for the specified consignment reference
        /// </summary>
        /// <param name="consignmentReference">The consignment reference to retrieve labels for</param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
	    public GetLabelsResponse GetLabels(string consignmentReference)
	    {
	        return CallAsyncMethod(() => GetLabelsAsync(consignmentReference).Result);
	    }

        /// <summary>
        /// Get labels for the specified consignment reference
        /// </summary>
        /// <param name="consignmentReference">The consignment reference to retrieve labels for</param>
        /// <returns>A <see cref="GetLabelsResponse"/></returns>
	    public Task<GetLabelsResponse> GetLabelsAsync(string consignmentReference)
	    {
	        return Rest.GetAsync<GetLabelsResponse>(consignmentReference);
	    }
	}
}