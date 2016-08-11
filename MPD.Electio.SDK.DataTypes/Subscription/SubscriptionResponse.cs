using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Subscription
{
	[DataContract]
	public class SubscriptionResponse
	{
		[DataMember]
		public string ErrorMessage { get; set; }

		[DataMember]
		public bool Success { get; set; }
	}
}
