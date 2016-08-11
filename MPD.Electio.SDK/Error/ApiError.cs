using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using static System.String;

namespace MPD.Electio.SDK.Error
{
    /// <summary>
    /// ApiError class
    /// </summary>
    [DataContract]
    public class ApiError
	{
        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        [DataMember]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the correlation identifier.
        /// </summary>
        /// <value>
        /// The correlation identifier.
        /// </value>
        [DataMember]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>
        /// The details.
        /// </value>
        [DataMember]
        public List<ApiErrorMessage> Details { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError"/> class.
        /// </summary>
        public ApiError() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError"/> class.
        /// </summary>
        /// <param name="fromException">From exception.</param>
        public ApiError(Exception fromException) : this(fromException, null)
		{
		}

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiError"/> class.
        /// </summary>
        /// <param name="fromException">From exception.</param>
        /// <param name="withCorrelationId">The with correlation identifier.</param>
        public ApiError(Exception fromException, string withCorrelationId)
		{
			CorrelationId = withCorrelationId;
			Code = fromException.GetType().Name;
			Message = fromException.Message;
			Details = new List<ApiErrorMessage>
			{
				new ApiErrorMessage
				{
					Message = fromException.ToString()
				}
			};
		}

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendFormat("{0} ({1})", Message, Code);

			if (Details != null)
			{
				foreach (var detail in Details)
				{
					sb.AppendFormat("\t- {0}", detail);
				}
			}

			if (!IsNullOrEmpty(CorrelationId))
			{
				sb.AppendFormat("\t- Correlation ID: {0}", CorrelationId);
			}

			return sb.ToString();
		}
	}
}