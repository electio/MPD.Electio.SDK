using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Common
{
    [DataContract]
    [Serializable]
    [XmlRoot("Contact", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Contact
    {
        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [DataMember]
        public Guid? Reference { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the telephone.
        /// </summary>
        /// <value>
        /// The telephone.
        /// </value>
        [DataMember]
        public string Telephone {
	        get { return Mobile ?? LandLine; }
	        set { Mobile = value; } 
		}

        /// <summary>
        /// Gets or sets the mobile.
        /// </summary>
        /// <value>
        /// The mobile.
        /// </value>
        [DataMember]
		public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets the land line.
        /// </summary>
        /// <value>
        /// The land line.
        /// </value>
        [DataMember]
		public string LandLine { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        [DataMember]
        [JsonProperty(Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        [IgnoreDataMember]
		public string FullName
		{
			get
			{
				return string.Join(" ", new []
				{
					Title,
					FirstName,
					LastName
				}.Where(part => !string.IsNullOrWhiteSpace(part)));
			}
		}

        [JsonIgnore]
        [XmlIgnore]
        public string Name
        {
            get
            {
                return string.Join(" ", new[]
                {
                    FirstName,
                    LastName
                }.Where(part => !string.IsNullOrWhiteSpace(part)));
            }
        }
    }
}