using System;
using System.Net;
using System.Runtime.Serialization;
using System.Text;

namespace MPD.Electio.SDK.Error
{
	[DataContract]
    public class ApiException : Exception
	{
        [DataMember]
        public ApiError Error { get; private set; }

		public HttpStatusCode? FailureCode { get; private set; }

		public ApiException(string message, Exception innerException) : base(message, innerException)
		{
			Error = new ApiError(innerException);
		}

		public ApiException(HttpStatusCode failureCode, string message, ApiError withError) : base(message)
		{
			FailureCode = failureCode;
			Error = withError;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendFormat("{0} ({1})", Message, FailureCode);
			if (Error != null)
			{
				sb.AppendFormat(Error.ToString());
			}
			sb.Append(base.ToString());
			return sb.ToString();
		}
	}
}