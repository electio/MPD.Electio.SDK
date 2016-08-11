using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.Error
{
	[DataContract]
    public class ApiErrorMessage
	{
        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Target { get; set; }

        [DataMember]
        public string Message { get; set; }

		public override string ToString()
		{
			return $"Code: {Code ?? "(null)"}, Target: {Target ?? "(null)"}, Message: {Message ?? "(null)"}";
		}
	}
}