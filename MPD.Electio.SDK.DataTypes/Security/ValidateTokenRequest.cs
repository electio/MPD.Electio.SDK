using System;
using System.Runtime.Serialization;
using MPD.Electio.SDK.DataTypes.Security.Enums;

namespace MPD.Electio.SDK.DataTypes.Security
{
	[DataContract]
	public class ValidateTokenRequest
	{
		[DataMember]
		public Guid TokenValue { get; set; }

		[DataMember]
		public TokenTypeEnum TokenType { get; set; }
	}
}
