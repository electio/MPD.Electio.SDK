using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class EmailAddressInUseException : Exception
    {
        public EmailAddressInUseException(string emailAddress)
            : base("Email address already in use: " + emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public string EmailAddress { get; private set; }
    }
}
