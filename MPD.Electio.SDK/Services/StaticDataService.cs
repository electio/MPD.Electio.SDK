using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Rates;
using MPD.Electio.SDK.DataTypes.Security;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
	public class StaticDataService : BaseService, IStaticDataService
	{
	    private readonly IRestConsumer _ratesRest;

		public StaticDataService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.SecurityStaticData, log)
        {
			if (endpoints == null)
			{
				throw new ArgumentNullException("endpoints");
			}

			if (apiKey == null)
			{
				throw new ArgumentException("You must supply an api key", "apiKey");
			}

			var securityConfig = new RestConsumerConfiguration(endpoints.SecurityStaticData, apiKey);
            var ratesConfig = new RestConsumerConfiguration(endpoints.RatesStaticData, apiKey);

            _ratesRest = new RestConsumer(ratesConfig,log);
		}

		public List<PermissionGroup> GetAllPermissions()
		{
			return CallAsyncMethod(() => GetAllPermissionsAsync().Result);
		}

		public List<Role> GetAllBuiltInRoles()
		{
			return CallAsyncMethod(() => GetAllBuiltInRolesAsync().Result);
		}

		public HashSet<DataTypes.Common.TimeZone> GetSupportedTimeZones()
		{
			return CallAsyncMethod(() => GetSupportedTimeZonesAsync().Result);
		}

		public List<string> GetSupportedTitles()
		{
			return CallAsyncMethod(() => GetSupportedTitlesAsync().Result);
		}

		public List<Currency> GetSupportedCurrencies()
		{
			return CallAsyncMethod(() => GetSupportedCurrenciesAsync().Result);
		}

		public List<Country> GetSupportedCountries()
		{
			return CallAsyncMethod(() => GetSupportedCountriesAsync().Result);
		}

	    public List<VatRate> GetVatRates(string countryIsoCode)
	    {
	        return CallAsyncMethod(() => GetVatRatesAsync(countryIsoCode).Result);
	    }

	    public List<Unit> GetDimensionUnits()
	    {
	        return CallAsyncMethod(() => GetDimensionUnitsAsync().Result);
	    }

		public Task<List<PermissionGroup>> GetAllPermissionsAsync()
		{
            return Rest.GetAsync<List<PermissionGroup>>("permissions");
		}

		public Task<List<Role>> GetAllBuiltInRolesAsync()
		{
            return Rest.GetAsync<List<Role>>("builtinroles");
		}

		public Task<HashSet<DataTypes.Common.TimeZone>> GetSupportedTimeZonesAsync()
		{
            return Rest.GetAsync<HashSet<DataTypes.Common.TimeZone>>("timezones");
		}

		public Task<List<string>> GetSupportedTitlesAsync()
		{
            return Rest.GetAsync<List<string>>("titles");
		}

		public Task<List<Currency>> GetSupportedCurrenciesAsync()
		{
            return Rest.GetAsync<List<Currency>>("currencies");
		}

		public Task<List<Country>> GetSupportedCountriesAsync()
		{
            return Rest.GetAsync<List<Country>>("countries");
		}

	    public Task<List<VatRate>> GetVatRatesAsync(string countryIsoCode)
	    {
	        return _ratesRest.GetAsync<List<VatRate>>(string.Format("vat/{0}", WebUtility.UrlEncode(countryIsoCode)));
	    }

	    public Task<List<Unit>> GetDimensionUnitsAsync()
	    {
	        return _ratesRest.GetAsync<List<Unit>>("dimensionUnits");
	    }
	}
}