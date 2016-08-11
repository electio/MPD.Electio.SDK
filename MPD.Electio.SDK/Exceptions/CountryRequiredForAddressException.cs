using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class CountryRequiredForAddressException : Exception
    {
        public CountryRequiredForAddressException()
            : base("Address must have a country supplied.")
        {
        }
    }
}