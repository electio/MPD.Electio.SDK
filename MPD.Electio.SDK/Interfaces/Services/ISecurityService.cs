using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Security;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Electio Security Service.
    /// Provides operations for signing in and out of Electio.
    /// </summary>
    public interface ISecurityService
	{
        /// <summary>
        /// Validates the token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Success or Failure of the operation</returns>
        bool ValidateToken(ValidateTokenRequest request);
        /// <summary>
        /// Signs the user out of Electio.
        /// </summary>
        void SignOut();
        /// <summary>
        /// Validates the token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>Task to await.</returns>
        Task<bool> ValidateTokenAsync(ValidateTokenRequest request);
        /// <summary>
        /// Signs the user out of Electio.
        /// </summary>
        Task SignOutAsync();
	}
}