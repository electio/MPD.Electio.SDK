using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Caching;
using MPD.Electio.SDK.DataTypes.Profile;

namespace MPD.Electio.SDK.DataTypes.Accounts
{
    /// <summary>
    /// Represents an Electio user's Account.
    /// </summary>
    [DataContract]
    [Serializable]
    [XmlRoot("Account", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Accounts")]
    public class Account : BaseCacheableEntity, ICacheable
	{
        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
		public Guid Reference { get; set; }

        /// <summary>
        /// Gets or sets the roles assigned to the user account.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        [DataMember]
		public List<Security.Role> Roles { get; set; }

        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        /// <value>
        /// The customer reference.
        /// </value>
        [DataMember]
		public Guid CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DataMember]
		public string Title { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DataMember]
		public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
		public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email address.
        /// </value>
        [DataMember]
		public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        /// <value>
        /// The language code.
        /// </value>
        [DataMember]
		public string LanguageCode { get; set; }

        /// <summary>
        /// Gets or sets the Electio time zone identifier.
        /// </summary>
        /// <value>
        /// The time zone identifier.
        /// </value>
        [DataMember]
		public int TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets the system time zone identifier.
        /// </summary>
        /// <value>
        /// The system time zone identifier.
        /// </value>
        [DataMember]
        public string TimeZoneInfoId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
		public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets the land line number.
        /// </summary>
        /// <value>
        /// The land line number.
        /// </value>
        [DataMember]
		public string LandLineNumber { get; set; }

        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        [DataMember]
		public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the shipping location restrictions - a list of shipping
        /// location references that are available to this user account.
        /// </summary>
        /// <value>
        /// The shipping location restrictions.
        /// </value>
        [Obsolete("Gradually phase out and use ShippingLocationWhiteList", false)]
        [DataMember]
        public List<string> ShippingLocationRestrictions { get; set; }

        [DataMember]
        public List<ShippingLocation> ShippingLocationWhiteList { get; set; }

        public int DefaultCacheDurationInMinutes()
        {
            throw new NotImplementedException();
        }
	}
}
