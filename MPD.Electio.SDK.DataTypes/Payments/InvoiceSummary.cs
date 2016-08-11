using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Payments
{
    [DataContract]
    public class InvoiceSummary
    {
        [DataMember]
        public string Reference { get; set; }

        [DataMember]
        public DateTime InvoiceDate { get; set; }

        [DataMember]
        public DateTime DueDate { get; set; }

        [DataMember]
        public DateTime? PaidDate { get; set; }

        [DataMember]
        public decimal NetAmount { get; set; }

        [DataMember]
        public decimal GrossAmount { get; set; }

        [DataMember]
        public decimal VatAmount { get; set; }

        [DataMember]
        public InvoiceStatus Status { get; set; }

        [DataMember]
        public InvoiceType InvoiceType { get; set; }
    }
}
