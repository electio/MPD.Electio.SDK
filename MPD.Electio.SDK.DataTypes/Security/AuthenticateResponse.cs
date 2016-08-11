using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Security
{
	[DataContract]
	public class AuthenticateResponse
	{
		[DataMember]
		public bool IsAuthenticated { get; set; }

		[DataMember]
		public string AuthenticationFailureMessage { get; set; }

		[DataMember]
		public Guid? ElectioAuthenticationToken { get; set; }

		[DataMember]
		public Guid? AccountReference { get; set; }

		[DataMember]
		public Guid? CustomerReference { get; set; }
	}
}
