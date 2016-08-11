namespace MPD.Electio.SDK.Exceptions
{
    public class PhoneNumberTypeNotFoundException : ObjectNotFoundException
    {
        public PhoneNumberTypeNotFoundException(string identifier) : base("PhoneNumberType", identifier)
        {
        }
    }
}