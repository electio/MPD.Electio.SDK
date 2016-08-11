using System;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes;
using MPD.Electio.SDK.DataTypes.Caching;
using MPD.Electio.SDK.Internal.CoreLib;

namespace MPD.Electio.SDK.Internal.DataTypes.Internal
{
    /// <summary>
    /// Object used to verify the access rights in service to service calls
    /// </summary>
    [DataContract]
    public class InternalServiceToken : BaseCacheableEntity, ICacheable, ICacheKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalServiceToken"/> class.
        /// </summary>
        public InternalServiceToken()
        { }

        /// <summary>
        /// Generates a new <see cref="InternalServiceToken"/> with a pre-defined service identifier
        /// </summary>
        /// <param name="serviceIdentifier">The identity of the service generating the service identifier</param>
        /// <exception cref="ArgumentException">Thrown if an invalid service identifier is provided</exception>
        public InternalServiceToken(string serviceIdentifier)
        {
            SetProperties(serviceIdentifier, Guid.NewGuid());
        }

        /// <summary>
        /// Generates a new <see cref="InternalServiceToken"/> with both a pre-defined service identifier and a pre-defined auth token
        /// </summary>
        /// <param name="serviceIdentifier">The identity of the service generating the service identifier</param>
        /// <param name="authToken">The auth token</param>
        /// <exception cref="ArgumentException">Thrown if an invalid service identifier is provided</exception>
        public InternalServiceToken(string serviceIdentifier, Guid authToken)
        {
            SetProperties(serviceIdentifier, authToken);
        }

        /// <summary>
        /// The value of the token
        /// </summary>
        [DataMember]
        public Guid ServiceAuthToken { get; set; }
        
        /// <summary>
        /// The key or identifier of the service
        /// <remarks>
        /// This is used to generate the lookup key for the token
        /// </remarks>
        /// </summary>
        [DataMember]
        public string ServiceIdentifier { get; set; }

        /// <summary>
        /// Defaults the cache duration in minutes.
        /// <remarks>We are using a relatively short period here as this is a single use token</remarks>
        /// </summary>
        public int DefaultCacheDurationInMinutes()
        {
            return 10;
        }
        
        /// <summary>
        /// Gets the key used to uniquely identify this item.
        /// </summary>
        /// <returns>Unique key</returns>
        public string GetKey()
        {
            return $"{ServiceIdentifier}:{ServiceAuthToken}";
        }

        private void SetProperties(string serviceIdentifier, Guid authToken)
        {
            if (string.IsNullOrWhiteSpace(serviceIdentifier))
            {
                throw new ArgumentException("A valid (non-null) service identifier must be provided to generate a security token.");
            }

            ServiceIdentifier = serviceIdentifier;
            ServiceAuthToken = authToken;
        }
    }
}