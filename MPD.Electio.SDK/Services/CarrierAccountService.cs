using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.CarrierServiceDirectory;
using MPD.Electio.SDK.Interfaces;

namespace MPD.Electio.SDK.Services
{
	public class CarrierAccountService : BaseService
	{

		public CarrierAccountService(string apiKey, IEndpoints endpoints, ILogger log) : base( apiKey, endpoints, endpoints.Carriers, log)
		{
		}

        public List<Carrier> GetCarrierAccountsByCarrier()
        {
            return CallAsyncMethod(() => GetCarrierAccountsByCarrierAsync().Result);
        }

        public Task<List<Carrier>> GetCarrierAccountsByCarrierAsync()
        {
            return Rest.GetAsync<List<Carrier>>("getcarriers");
        }

	}
}
