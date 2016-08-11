using System;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Caching;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// Represents an Address
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.DataTypes.Caching.BaseCacheableEntity" />
    /// <seealso cref="MPD.Electio.SDK.DataTypes.ICacheable" />
    [DataContract]
    [Serializable]
    [XmlRoot("Address", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
	public class Address : BaseCacheableEntity, ICacheable
    {
        private static readonly Regex PostcodeMatcher = new Regex("^(?<Area>[A-Za-z]{1,2})?(?<District>[0-9][A-Za-z0-9]?)?(?: (?<Sector>[0-9])?(?<Unit>[A-Za-z]{2})?)?$", RegexOptions.Compiled);

        private string _postcode;

        /// <summary>
        /// Gets or sets the contact.
        /// </summary>
        /// <value>
        /// The contact.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets or sets the name of the company.
        /// </summary>
        /// <value>
        /// The name of the company.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }
        
        /// <summary>
        /// Gets the name of the contact.
        /// </summary>
        /// <value>
        /// The name of the contact.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ContactName
        {
            get
            {
                if (Contact != null)
                    return Contact.FullName;

                return !string.IsNullOrWhiteSpace(CompanyName) ? CompanyName : null;
            }
        }

        /// <summary>
        /// The shipping location reference
        /// </summary>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ShippingLocationReference { get; set; }

        /// <summary>
        /// Gets or sets the name of the customer.
        /// </summary>
        /// <value>
        /// The name of the customer.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the address line1.
        /// </summary>
        /// <value>
        /// The address line1.
        /// </value>
        [DataMember]
		public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line2.
        /// </summary>
        /// <value>
        /// The address line2.
        /// </value>
        [DataMember]
		public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the address line3.
        /// </summary>
        /// <value>
        /// The address line3.
        /// </value>
        [DataMember]
		[JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
		public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        /// <value>
        /// The town.
        /// </value>
        [DataMember]
		public string Town { get; set; }

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        /// <value>
        /// The region.
        /// </value>
        [DataMember]
		[JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
		public string Region { get; set; }

        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        /// <value>
        /// The postcode.
        /// </value>
        [DataMember]
        public string Postcode
        {
            get { return _postcode; }
            set
            {
                _postcode = value;

                if (string.IsNullOrWhiteSpace(value)) return;

                var match = PostcodeMatcher.Match(value);

                if (!match.Success) return;

                PostcodeArea = match.Groups["Area"].Value;
                PostcodeDistrict = match.Groups["District"].Value;
                PostcodeSector = match.Groups["Sector"].Value;
                PostcodeUnit = match.Groups["Unit"].Value;
            }
        }
        
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        [DataMember]
		public Country Country { get; set; }

        /// <summary>
        /// Gets or sets the region code.
        /// </summary>
        /// <value>
        /// The region code.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [XmlIgnore]
        public string RegionCode { get; set; }

        /// <summary>
        /// Gets or sets the special instructions - any specical instructions for the carrier when delivering to or collecing from the address.
        /// </summary>
        /// <value>
        /// The special instructions.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string SpecialInstructions { get; set; }

        /// <summary>
        /// The location represented in terms of latitude and longitude
        /// </summary>
        [DataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public LatLong LatLong { get; set; }

        /// <summary>
        /// The postcode area - eg 'M' within M1 5WG
        /// </summary>
        [XmlIgnore]
        public string PostcodeArea { get; private set; }

        /// <summary>
        /// The postcode district - eg '1' within M1 5WG
        /// </summary>
        [XmlIgnore]
        public string PostcodeDistrict { get; private set; }

        /// <summary>
        /// The postcode sector - eg '5' within M1 5WG
        /// </summary>
        [XmlIgnore]
        public string PostcodeSector { get; private set; }

        /// <summary>
        /// The postcode unit - eg 'WG' within M1 5WG
        /// </summary>
        [XmlIgnore]
        public string PostcodeUnit { get; private set; }

        /// <summary>
        /// Defaults the cache duration in minutes.
        /// </summary>
        /// <returns></returns>
        public virtual int DefaultCacheDurationInMinutes()
        {
            return 30;
        }
    }
}