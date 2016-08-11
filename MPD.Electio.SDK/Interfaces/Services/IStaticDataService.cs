using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Accounts;
using MPD.Electio.SDK.DataTypes.Common;
using MPD.Electio.SDK.DataTypes.Rates;
using MPD.Electio.SDK.DataTypes.Security;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Static Data service
    /// </summary>
    public interface IStaticDataService
	{
        /// <summary>
        /// Gets all permissions.
        /// </summary>
        /// <returns>List of Permissions</returns>
        List<PermissionGroup> GetAllPermissions();
        /// <summary>
        /// Gets all built in roles.
        /// </summary>
        /// <returns>List of 'BuiltIn' roles</returns>
        List<Role> GetAllBuiltInRoles();
        /// <summary>
        /// Gets the supported time zones.
        /// </summary>
        /// <returns>Set of supported timezones.</returns>
        HashSet<TimeZone> GetSupportedTimeZones();
		List<string> GetSupportedTitles();
		List<Currency> GetSupportedCurrencies();
		List<Country> GetSupportedCountries();
		Task<List<PermissionGroup>> GetAllPermissionsAsync();
		Task<List<Role>> GetAllBuiltInRolesAsync();
		Task<HashSet<TimeZone>> GetSupportedTimeZonesAsync();
		Task<List<string>> GetSupportedTitlesAsync();
		Task<List<Currency>> GetSupportedCurrenciesAsync();
		Task<List<Country>> GetSupportedCountriesAsync();
        /// <summary>
        /// Gets the VAT rates configured for the specified country.
        /// </summary>
        /// <param name="countryIsoCode">The country ISO code.</param>
        /// <returns>List of supported VAT rates</returns>
        List<VatRate> GetVatRates(string countryIsoCode);
        /// <summary>
        /// Gets the VAT rates configured for the specified country.
        /// </summary>
        /// <param name="countryIsoCode">The country ISO code.</param>
        /// <returns>Task to await.</returns>
        Task<List<VatRate>> GetVatRatesAsync(string countryIsoCode);
		List<Unit> GetDimensionUnits();
		Task<List<Unit>> GetDimensionUnitsAsync();
	}
}