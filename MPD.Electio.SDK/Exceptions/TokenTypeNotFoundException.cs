namespace MPD.Electio.SDK.Exceptions
{
    public class TokenTypeNotFoundException : ObjectNotFoundException
    {
        public TokenTypeNotFoundException(string identifier) : base("TokenType", identifier)
        {
        }
    }
}