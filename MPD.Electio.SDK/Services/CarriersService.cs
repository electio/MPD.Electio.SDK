using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using MPD.Electio.SDK.DataTypes.CarrierServiceDirectory;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Subscription;
using MPD.Electio.SDK.Error;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
	public class CarriersService : BaseService, ICarriersService
	{

		public CarriersService(string apiKey, IEndpoints endpoints, ILogger log) : base( apiKey, endpoints, endpoints.Carriers, log)
		{
		}

        public List<Carrier> GetCarriers()
        {
            return CallAsyncMethod(() => GetCarriersAsync().Result);
        }

        public Task<List<Carrier>> GetCarriersAsync()
        {
            return Rest.GetAsync<List<Carrier>>("getcarriers");
        }

		public SubscriptionMpdCarrierServiceResponse GetServicesForSubscription()
		{
			return CallAsyncMethod(() => GetServicesForSubscriptionAsync().Result);
		}

		public Task<SubscriptionMpdCarrierServiceResponse> GetServicesForSubscriptionAsync()
		{
			try
			{
				return Rest.GetAsync<SubscriptionMpdCarrierServiceResponse>(String.Empty);
			}
			catch (ApiException ex)
			{
				if (ex.FailureCode.HasValue && ex.FailureCode.Value == HttpStatusCode.NotFound)
				{
					return Task.FromResult<SubscriptionMpdCarrierServiceResponse>(null);
				}
				throw;
			}
		}

	    public PagedList<Carrier> GetCustomerCarriers(Guid customerReference, int pageNumber, int pageSize, string nameFilter)
	    {
	        return CallAsyncMethod(() => GetCustomerCarriersAsync(customerReference, pageNumber, pageSize, nameFilter).Result);
	    }

	    public Task<PagedList<Carrier>> GetCustomerCarriersAsync(Guid customerReference, int pageNumber, int pageSize, string nameFilter)
	    {
	        return Rest.GetAsync<PagedList<Carrier>>($"getcustomercarriers/{customerReference}/{pageNumber}/{pageSize}?namefilter={nameFilter}");
	    }
	}
}
