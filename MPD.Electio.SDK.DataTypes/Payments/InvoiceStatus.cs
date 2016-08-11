using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Payments
{
    /// <summary>
    /// Current Status of the Invoice
    /// </summary>
    [DataContract]
    public enum InvoiceStatus
    {
        /// <summary>
        /// Pending (either unpaid and still within the invoice terms or overdue)
        /// </summary>
        [EnumMember]
        Pending = 0,
        /// <summary>
        /// Paid
        /// </summary>
        [EnumMember]
        Paid = 1,
        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember]
        Cancelled = 2,
        /// <summary>
        /// All statuses
        /// </summary>
        [EnumMember]
        All = 3

    }
}
