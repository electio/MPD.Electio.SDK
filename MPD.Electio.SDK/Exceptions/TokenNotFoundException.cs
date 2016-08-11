using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class TokenNotFoundException : ObjectNotFoundException
    {
        public TokenNotFoundException(Guid tokenValue)
            : base("Token", tokenValue.ToString()) { }

	    public TokenNotFoundException(string emailAddress)
			: base("Token", emailAddress) { }
    }
}