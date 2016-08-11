using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// A wrapper class for serializing exceptions.
    /// </summary>
    [Serializable]
    [XmlRoot("PagedList", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class SerializableException
    {
        #region Members

        private KeyValuePair<object, object>[] _data;
        //This is the reason this class exists. Turning an IDictionary into a serializable object

        private string _helpLink = string.Empty;
        private SerializableException _innerException;
        private string _message = string.Empty;
        private string _source = string.Empty;
        private string _stackTrace = string.Empty;

        #endregion

        #region Constructors

        public SerializableException()
        {
        }

        public SerializableException(Exception exception) : this()
        {
            SetValues(exception);
        }

        #endregion

        #region Properties

        public string HelpLink
        {
            get { return _helpLink; }
            set { _helpLink = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string Source
        {
            get { return _source; }
            set { _source = value; }
        }

        public string StackTrace
        {
            get { return _stackTrace; }
            set { _stackTrace = value; }
        }

        public SerializableException InnerException
        {
            get { return _innerException; }
            set { _innerException = value; }
        } // Allow null to be returned, so serialization doesn't cascade until an out of memory exception occurs

        public KeyValuePair<object, object>[] Data
        {
            get { return _data ?? new KeyValuePair<object, object>[0]; }
            set { _data = value; }
        }

        #endregion

        #region Private Methods

        private void SetValues(Exception exception)
        {
            if (null == exception) return;

            _helpLink = exception.HelpLink ?? string.Empty;
            _message = exception.Message ?? string.Empty;
            _source = exception.Source ?? string.Empty;
            _stackTrace = exception.StackTrace ?? string.Empty;
            SetData(exception.Data);
            _innerException = new SerializableException(exception.InnerException);
        }

        private void SetData(ICollection collection)
        {
            _data = new KeyValuePair<object, object>[0];

            collection?.CopyTo(_data, 0);
        }

        #endregion
    }
}