using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.DeliveryOptions;
using MPD.Electio.SDK.DataTypes.Payments;
using MPD.Electio.SDK.DataTypes.ServiceAvailability;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    public class PickUpLocationLocatorService : BaseService, IPickUpLocationLocatorService
    {
        public PickUpLocationLocatorService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Invoice, log)
        {
        }

        public FindNearestPickUpLocationResponse FindNearestPickUpLocations(FindNearestPickUpLocationRequest request)
        {
            return CallAsyncMethod(() => FindNearestPickUpLocationsAsync(request).Result);
        }

        public Task<FindNearestPickUpLocationResponse> FindNearestPickUpLocationsAsync(FindNearestPickUpLocationRequest request)
        {
            return Rest.PostAsync<FindNearestPickUpLocationRequest, FindNearestPickUpLocationResponse>(request, string.Empty);
        }
    }
}
