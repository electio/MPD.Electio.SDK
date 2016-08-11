using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Accounts;
using MPD.Electio.SDK.DataTypes.Role;
using MPD.Electio.SDK.DataTypes.Security;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
	public class RoleService : BaseService, IRoleService
	{

		public RoleService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Role, log)
        {
		}

		public Role CreateCustomRole(NewRole role)
		{
			return CallAsyncMethod(() => CreateCustomRoleAsync(role).Result);
		}

		public void DeleteRole(Guid roleReference)
		{
			CallAsyncMethod(() => DeleteRoleAsync(roleReference).Wait());
		}

		public void UpdateRole(UpdateRole role)
		{
			CallAsyncMethod(() => UpdateRoleAsync(role).Wait());
		}

		public List<Account> GetAccountsWithinRole(Guid roleReference)
		{
			return CallAsyncMethod(() => GetAccountsWithinRoleAsync(roleReference).Result);
		}

		public void AddAccountToRole(Guid roleReference, Guid accountReference)
		{
			CallAsyncMethod(() => AddAccountToRoleAsync(roleReference, accountReference).Wait());
		}

		public void RemoveAccountFromRole(Guid roleReference, Guid accountReference)
		{
			CallAsyncMethod(() => RemoveAccountFromRoleAsync(roleReference, accountReference).Wait());
		}



		public Task<Role> CreateCustomRoleAsync(NewRole role)
		{
			return Rest.PostAsync<NewRole, Role>(role, "custom");
		}

		public Task DeleteRoleAsync(Guid roleReference)
		{
			return Rest.DeleteAsync(roleReference.ToString());
		}

		public Task UpdateRoleAsync(UpdateRole role)
		{
			return Rest.PutAsync(role, String.Empty);
		}

		public Task<List<Account>> GetAccountsWithinRoleAsync(Guid roleReference)
		{
			return Rest.GetAsync<List<Account>>(String.Format("{0}/accounts", roleReference));
		}

		public Task AddAccountToRoleAsync(Guid roleReference, Guid accountReference)
		{
			return Rest.PostAsync<string>(null, String.Format("{0}/accounts/{1}", roleReference, accountReference));
		}

		public Task RemoveAccountFromRoleAsync(Guid roleReference, Guid accountReference)
		{
			return Rest.DeleteAsync(String.Format("{0}/accounts/{1}", roleReference, accountReference));
		}
	}
}
