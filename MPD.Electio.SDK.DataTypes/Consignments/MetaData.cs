using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Optional Customer defined metadata associated with a consignment, package or item.
    /// This data is stored within Electio but is not validated or used by Electio and is provided only 
    /// for information.
    /// </summary>
    [DataContract]
    [XmlRoot("MetaData", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class MetaData
    {
        /// <summary>
        /// Gets or sets the key value.
        /// </summary>
        /// <value>
        /// The key value.
        /// </value>
        [DataMember]
        public string KeyValue { get; set; }

        /// <summary>
        /// Gets or sets the string value.
        /// </summary>
        /// <value>
        /// The string value.
        /// </value>
        [DataMember]
        public string StringValue { get; set; }

        /// <summary>
        /// Gets or sets the int value.
        /// </summary>
        /// <value>
        /// The int value.
        /// </value>
        [DataMember]
        public int? IntValue { get; set; }

        /// <summary>
        /// Gets or sets the decimal value.
        /// </summary>
        /// <value>
        /// The decimal value.
        /// </value>
        [DataMember]
        public decimal? DecimalValue { get; set; }

        /// <summary>
        /// Gets or sets the date time value.
        /// </summary>
        /// <value>
        /// The date time value.
        /// </value>
        [DataMember]
        public DateTime? DateTimeValue { get; set; }

        /// <summary>
        /// Gets or sets the bool value.
        /// </summary>
        /// <value>
        /// The bool value.
        /// </value>
        [DataMember]
        public bool? BoolValue { get; set; }
    }
}