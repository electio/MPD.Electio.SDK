using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Tracking
{
    [DataContract]
    public class FlattenedEventViewModel
    {
        [DataMember]
        public DateTimeOffset TimeStamp { get; set; }

        [DataMember]
        public string Code { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string SignedBy { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public string CarrierServiceName { get; set; }
    }
}