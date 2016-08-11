using System.Runtime.Serialization;
using System.Xml.Serialization;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// A contact address in the context of a consignment. The actual purpose of the address is defined by the value of the 'ConsignmentAddressType' assigned.
    /// </summary>
    [DataContract]
    [XmlRoot("Address", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public sealed class Address : Common.Address
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
            
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address.</param>
        /// <param name="addressType">Type of the address.</param>
        /// <param name="shopLocationReference">The shop location reference.</param>
        public Address(Common.Address baseAddress, ConsignmentAddressType addressType, string shopLocationReference)
        {
            Construct(baseAddress, addressType, shopLocationReference);   
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="baseAddress">The base address.</param>
        /// <param name="addressType">Type of the address.</param>
        public Address(Common.Address baseAddress, ConsignmentAddressType addressType)
        {
            Construct(baseAddress, addressType);
        }

        private void Construct(Common.Address baseAddress, ConsignmentAddressType addressType,
            string shopLocationReference = null)
        {
            if (baseAddress == null) return;

            CustomerName = baseAddress.CustomerName;
            CompanyName = baseAddress.CompanyName;

            AddressLine1 = baseAddress.AddressLine1;
            AddressLine2 = baseAddress.AddressLine2;
            AddressLine3 = baseAddress.AddressLine3;
            Town = baseAddress.Town;
            Region = baseAddress.Region;
            RegionCode = baseAddress.RegionCode;
            Postcode = baseAddress.Postcode;
            Country = baseAddress.Country;

            Contact = baseAddress.Contact;

            LatLong = baseAddress.LatLong;

            ShippingLocationReference = baseAddress.ShippingLocationReference;
            ShopLocationReference = shopLocationReference;
            SpecialInstructions = baseAddress.SpecialInstructions;

            AddressType = addressType;
        }

        /// <summary>
        /// Defines the purpose of the contact address
        /// </summary>
        [DataMember]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConsignmentAddressType AddressType { get; set; }
        
        /// <summary>
        /// Gets or sets the shop location reference where this address
        /// forms part of a journey with a Pickup or DropOff service.
        /// </summary>
        /// <value>
        /// The shop location reference.
        /// </value>
        [DataMember]
        public string ShopLocationReference { get; set; }
    }
}