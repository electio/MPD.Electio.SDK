using System;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.Exceptions
{
	public class AccountDisabledException : SerializableException
	{

	    public AccountDisabledException()
	    {
	        
	    }
		public AccountDisabledException(string emailAddress, Exception ex)
			: base(ex)
		{
			EmailAddress = emailAddress;
		}

		public string EmailAddress { get; private set; }
	}
}