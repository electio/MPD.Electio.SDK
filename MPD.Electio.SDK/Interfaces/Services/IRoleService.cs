using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Accounts;
using MPD.Electio.SDK.DataTypes.Role;
using MPD.Electio.SDK.DataTypes.Security;

namespace MPD.Electio.SDK.Interfaces.Services
{
	public interface IRoleService
	{
		Role CreateCustomRole(NewRole role);
		void DeleteRole(Guid roleReference);
		void UpdateRole(UpdateRole role);
		List<Account> GetAccountsWithinRole(Guid roleReference);
		void AddAccountToRole(Guid roleReference, Guid accountReference);
		void RemoveAccountFromRole(Guid roleReference, Guid accountReference);
		Task<Role> CreateCustomRoleAsync(NewRole role);
		Task DeleteRoleAsync(Guid roleReference);
		Task UpdateRoleAsync(UpdateRole role);
		Task<List<Account>> GetAccountsWithinRoleAsync(Guid roleReference);
		Task AddAccountToRoleAsync(Guid roleReference, Guid accountReference);
		Task RemoveAccountFromRoleAsync(Guid roleReference, Guid accountReference);
	}
}