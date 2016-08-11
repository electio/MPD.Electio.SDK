using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Common;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("WithMessage", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class WithMessage<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="isSuccess"></param>
        /// <param name="apiLinks"></param>
        /// <param name="explanation"></param>
        public WithMessage(T data, bool isSuccess, List<ApiLink> apiLinks, string explanation)
        {
            Data = data;
            IsSuccess = isSuccess;
            Message = !string.IsNullOrWhiteSpace(explanation) ? explanation.Trim() : explanation;
            ApiLinks = apiLinks;
        }

        /// <summary>
        /// Gets a value indicating whether this instance is success.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is success; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool IsSuccess { get; private set; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        [DataMember]
        public T Data { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public List<ApiLink> ApiLinks { get; private set; }
    }

    public static class WithMessage
    {
        /// <summary>
        /// Successes the specified data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        /// <param name="apiLinks"></param>
        /// <param name="explanation">The explanation.</param>
        /// <returns></returns>
        public static WithMessage<T> Success<T>(T data, List<ApiLink> apiLinks, string explanation = null)
        {
            return new WithMessage<T>(data, true, apiLinks, explanation);
        }

        /// <summary>
        /// Failures the specified data.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        /// <param name="apiLinks"></param>
        /// <param name="explanation">The explanation.</param>
        /// <returns></returns>
        public static WithMessage<T> Failure<T>(T data, List<ApiLink> apiLinks, string explanation)
        {
            return new WithMessage<T>(data, false, apiLinks, explanation);
        }
    }
}
