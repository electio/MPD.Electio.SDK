using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.ServiceAvailability
{
	public class CalendarException
	{
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
		public DateTimeOffset Date { get; set; }

		[DataMember]
		public CalendarOperationTimes CalendarOperationTimes { get; set; }

		[DataMember]
		public CalendarExceptionType CalendarExceptionType { get; set; }

		/// <summary>
		/// Optional. Use only if given rule is only applicable to given MPD services. Empty list means it's applicable to all services.
		/// </summary>
		[DataMember]
		public List<string> MpdCarrierServiceReferences { get; set; } 
	}
}