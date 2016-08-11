using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Represents an Audit Message attributed to a Consignment.
    /// </summary>
    [DataContract]
    [XmlRoot("ConsignmentAuditMessage", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ConsignmentAuditMessage
	{
        /// <summary>
        /// The system user
        /// </summary>
        public const string SystemUser = "System";

        /// <summary>
        /// We only have a primary key to support NHibernate
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [DataMember]
		public Guid Id { get; set; }

        /// <summary>
        /// Date/Time of the audit message
        /// </summary>
        /// <value>
        /// The timestamp.
        /// </value>
        [DataMember]
		public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Reference of the consignment that the log line belongs to
        /// </summary>
        /// <value>
        /// The consignment reference.
        /// </value>
        [DataMember]
		public string ConsignmentReference { get; set; }

        /// <summary>
        /// Audit message
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
		public string Message { get; set; }

        /// <summary>
        /// Severity of the message (Default: None)
        /// </summary>
        /// <value>
        /// The severity.
        /// </value>
        [DataMember]
		public AuditMessageSeverity Severity { get; set; }

        /// <summary>
        /// Category of the message (Default: None)
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        [DataMember]
		public ConsignmentAuditMessageCategory Category { get; set; }

        /// <summary>
        /// String representation of the user which caused the audit message to be raised (i.e. System or 'Joe Bloggs')
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        [DataMember]
		public string Username { get; set; }

        /// <summary>
        /// Any additional data that the audit needs to store agains tthe row
        /// </summary>
        /// <value>
        /// The additional data.
        /// </value>
        [DataMember]
		public string AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        /// <value>
        /// The details.
        /// </value>
        [DataMember]
        public string Details { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsignmentAuditMessage"/> class.
        /// </summary>
        public ConsignmentAuditMessage() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsignmentAuditMessage"/> class.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <param name="message">The message.</param>
        /// <param name="username">The username.</param>
        /// <param name="severity">The severity.</param>
        /// <param name="category">The category.</param>
        /// <param name="additionalData">The additional data.</param>
        /// <param name="details">The details.</param>
        public ConsignmentAuditMessage(
			string consignmentReference,
			string message,
			string username,
			AuditMessageSeverity severity = AuditMessageSeverity.None,
			ConsignmentAuditMessageCategory category = ConsignmentAuditMessageCategory.None,
			string additionalData = null,
            string details = null)
		{
			ConsignmentReference = consignmentReference;
			Message = message;
			Username = username;
			Severity = severity;
			Category = category;
			AdditionalData = additionalData;
            Details = details;
		}
	}
}
