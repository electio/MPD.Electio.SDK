using System;
using System.Collections.Generic;
using MPD.Electio.SDK.Internal.DataTypes.Internal;

namespace MPD.Electio.SDK.Internal.Interfaces
{
    /// <summary>
    /// Used for managing internal service tokens
    /// <seealso cref="InternalServiceToken"/>
    /// </summary>
    public interface IInternalServiceTokenService
    {
        /// <summary>
        /// Gets or sets the service identifier. 
        /// <remarks>
        /// This just be injected by each hosting service. This value uniquely identifies each service making an internal service request.
        /// </remarks>
        /// </summary>
        /// <value>
        /// The service identifier.
        /// </value>
        string ServiceIdentifier { get; }

        /// <summary>
        /// Gets the <see cref="InternalServiceToken"/> represented by the service identifier and service auth token.
        /// <remarks>
        /// If the token exists it should be removed to ensure it is a single use only
        /// </remarks>
        /// </summary>
        /// <param name="serviceIdentifier">The service identifier of the calling service</param>
        /// <param name="serviceAuthToken">The service authentication token.</param>
        /// <returns><see cref="InternalServiceToken"/> or null if the token does not exist</returns>
        InternalServiceToken GetSingleUseToken(string serviceIdentifier, Guid serviceAuthToken);

        /// <summary>
        /// Add a new <see cref="InternalServiceToken"/>
        /// </summary>
        /// <returns>The generated <see cref="InternalServiceToken"/></returns>
        InternalServiceToken AddNewToken();

        /// <summary>
        /// Generates a new security token and returns a dictionary of strings to apply as headers
        /// </summary>
        /// <returns>A dictionary of strings to use as headers</returns>
        Dictionary<string, string> ProcessInternalSecurityToken();
    }
}