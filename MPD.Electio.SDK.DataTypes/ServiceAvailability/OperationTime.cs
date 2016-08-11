using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.ServiceAvailability
{
	public struct OperationTime
	{
		[DataMember]
		public int TimeOffsetInDays { get; set; }

		[DataMember]
		public TimeSpan Time { get; set; }
	}
}