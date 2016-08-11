using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class TokenExpiredException : Exception
    {
        public TokenExpiredException(Guid tokenValue)
            : base(string.Format("Token (value: {0}) is expired.", tokenValue.ToString("N")))
        {
            
        }
    }
}