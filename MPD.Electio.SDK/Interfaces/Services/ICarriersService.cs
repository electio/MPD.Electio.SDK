using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MPD.Electio.SDK.DataTypes.CarrierServiceDirectory;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Subscription;

namespace MPD.Electio.SDK.Interfaces.Services
{
	public interface ICarriersService
	{
	    List<Carrier> GetCarriers();
        Task<List<Carrier>> GetCarriersAsync();
		SubscriptionMpdCarrierServiceResponse GetServicesForSubscription();
		Task<SubscriptionMpdCarrierServiceResponse> GetServicesForSubscriptionAsync();

        PagedList<Carrier> GetCustomerCarriers(Guid customerReference,int pageNumber, int pageSize, string nameFilter);
        Task<PagedList<Carrier>> GetCustomerCarriersAsync(Guid customerReference, int pageNumber, int pageSize, string nameFilter);
    }
}
