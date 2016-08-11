using System.Globalization;

namespace MPD.Electio.SDK.Exceptions
{
	public class AccountNotFoundException : ObjectNotFoundException
    {
        public AccountNotFoundException(string emailAddress)
            : base("Account", emailAddress)
        {
        }

        public AccountNotFoundException(int accountId)
            : base("Account", accountId.ToString(CultureInfo.InvariantCulture))
        {
        }

    }
}