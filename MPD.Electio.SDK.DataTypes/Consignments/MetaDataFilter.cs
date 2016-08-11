using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("MetaDataFilter", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class MetaDataFilter
    {
        [DataMember]
        public string KeyValue { get; set; }

        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public MetaDataType MetaDataType { get; set; }

        [DataMember]
        public List<string> StringValues { get; set; }

        [DataMember]
        public List<string> StringValuesSelected { get; set; }

        [DataMember]
        public int? IntValueFrom { get; set; }

        [DataMember]
        public int? IntValueTo { get; set; }

        [DataMember]
        public decimal? DecimalValueFrom { get; set; }

        [DataMember]
        public decimal? DecimalValueTo { get; set; }

        [DataMember]
        public DateTime? DateTimeValueFrom { get; set; }

        [DataMember]
        public DateTime? DateTimeValueTo { get; set; }

        [DataMember]
        public bool? BoolValue { get; set; }
    }
}
