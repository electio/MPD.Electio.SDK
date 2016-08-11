using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Quotes
{
    [DataContract]
    public class QuoteResult
    {
        /// <summary>
        /// Gets or sets the quote request reference - a unique reference assigned to the 
        /// request that generated the result.
        /// </summary>
        /// <value>
        /// The quote request reference.
        /// </value>
        [DataMember]
        public Guid QuoteRequestReference { get; set; }

        /// <summary>
        /// Gets or sets the quotes.
        /// </summary>
        /// <value>
        /// The quotes.
        /// </value>
        [DataMember]
        public List<Quote> Quotes { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the unqualified services - a list of 
        /// services for which quotes could not be obtained.
        /// </summary>
        /// <value>
        /// The unqualified services.
        /// </value>
        [DataMember]
        public List<UnqualifiedService> UnqualifiedServices { get; set; }
    }
}
