using System;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Security;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Default concrete implementation of ISecurity service.
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Services.BaseService" />
    /// <seealso cref="MPD.Electio.SDK.Interfaces.Services.ISecurityService" />
    public class SecurityService : BaseService, ISecurityService
	{

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityService"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        public SecurityService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Security, log)
        {

		}
        
        /// <summary>
        /// Validates the token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>
        /// Success or Failure of the operation
        /// </returns>
        public bool ValidateToken(ValidateTokenRequest request)
		{
			return CallAsyncMethod(() => ValidateTokenAsync(request).Result);
		}

        /// <summary>
        /// Signs the user out of Electio.
        /// </summary>
        public void SignOut()
		{
			CallAsyncMethod(() => SignOutAsync().Wait());
		}
        
        /// <summary>
        /// Validates the token.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>
        /// Task to await.
        /// </returns>
        public Task<bool> ValidateTokenAsync(ValidateTokenRequest request)
		{
			return Rest.PostAsync<ValidateTokenRequest, bool>(request, "validatetoken");
		}

        /// <summary>
        /// Signs the user out of Electio.
        /// </summary>
        public Task SignOutAsync()
		{
			return Rest.PutAsync(string.Empty, "signout");
		}
	}
}