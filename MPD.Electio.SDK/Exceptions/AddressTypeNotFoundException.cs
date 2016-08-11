namespace MPD.Electio.SDK.Exceptions
{
    public class AddressTypeNotFoundException : ObjectNotFoundException
    {
        public AddressTypeNotFoundException(string identifier) : base("AddressType", identifier)
        {
        }
    }
}