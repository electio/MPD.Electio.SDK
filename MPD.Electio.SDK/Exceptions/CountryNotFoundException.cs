namespace MPD.Electio.SDK.Exceptions
{
    public class CountryNotFoundException : ObjectNotFoundException
    {
        public CountryNotFoundException(string identifier) : base("Country", identifier)
        {
        }
    }
}