using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents latitude and longitude
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("LatLong", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class LatLong
    {
        private decimal _latitude;
        private decimal _longitude;

        /// <summary>
        /// The latitude
        /// </summary>
        [DataMember]
        public decimal Latitude
        {
            get { return Math.Round(_latitude, 6, MidpointRounding.AwayFromZero); }
            set { _latitude = value; }
        }

        /// <summary>
        /// The longitude
        /// </summary>
        [DataMember]
        public decimal Longitude
        {
            get { return Math.Round(_longitude, 6, MidpointRounding.AwayFromZero); }
            set { _longitude = value; }
        }
    }
}