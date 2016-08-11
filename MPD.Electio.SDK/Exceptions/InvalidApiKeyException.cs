using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class InvalidApiKeyException : Exception
    {
        public InvalidApiKeyException(string apiKey) : base(string.Format("API key '{0}' is not valid",apiKey))
        {
        }
    }
}