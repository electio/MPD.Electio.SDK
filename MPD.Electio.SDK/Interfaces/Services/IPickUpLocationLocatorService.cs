using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.DeliveryOptions;

namespace MPD.Electio.SDK.Interfaces.Services
{
    public interface IPickUpLocationLocatorService
    {
        FindNearestPickUpLocationResponse FindNearestPickUpLocations(FindNearestPickUpLocationRequest request);
        Task<FindNearestPickUpLocationResponse> FindNearestPickUpLocationsAsync(FindNearestPickUpLocationRequest request);
    }
}
