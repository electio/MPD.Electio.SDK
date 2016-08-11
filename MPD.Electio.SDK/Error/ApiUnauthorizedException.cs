using System;
using System.Net;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.Error
{
    [DataContract]
    public class ApiUnauthorizedException : ApiException
    {
        public ApiUnauthorizedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ApiUnauthorizedException(string message, ApiError withError) : base(HttpStatusCode.Unauthorized, message, withError)
        {
        }
    }
}
