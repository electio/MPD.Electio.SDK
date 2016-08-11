using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    /// <summary>
    /// Barcode Type - http://www.makebarcode.com/specs/barcodechart.html
    /// </summary>
    [DataContract]
    [XmlRoot("BarcodeType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum BarcodeType
    {
        [EnumMember, Display(Name = "Australia Postal Code")]
        AustraliaPostalCode,

        [EnumMember, Display(Name = "Aztec Code")]
        AztecCode,

        [EnumMember, Display(Name = "Codabar")]
        Codabar,

        [EnumMember, Display(Name = "Code 11")]
        Code11,

        [EnumMember, Display(Name = "Code 128")]
        Code128,

        [EnumMember, Display(Name = "Code 39")]
        Code39,

        [EnumMember, Display(Name = "Extended Code 39")]
        ExtendedCode39,

        [EnumMember, Display(Name = "Code 93")]
        Code93,

        [EnumMember, Display(Name = "Composite Code")]
        CompositeCode,

        [EnumMember, Display(Name = "DataMatrix")]
        DataMatrix,

        [EnumMember, Display(Name = "EAN-13")]
        EAN13,

        [EnumMember, Display(Name = "EAN-8")]
        EAN8,

        [EnumMember, Display(Name = "EAN Bookland")]
        EANBookland,

        [EnumMember, Display(Name = "Industrial 2 of 5")]
        Industrial2Of5,

        [EnumMember, Display(Name = "Interleaved 2 of 5")]
        Interleaved2Of5,

        [EnumMember, Display(Name = "ITF-14")]
        ITF14,

        [EnumMember, Display(Name = "LOGMARS")]
        LOGMARS,

        [EnumMember, Display(Name = "Maxicode")]
        Maxicode,

        [EnumMember, Display(Name = "MSI")]
        MSI,

        [EnumMember, Display(Name = "OPC")]
        OPC,

        [EnumMember, Display(Name = "PDF417")]
        PDF417,

        [EnumMember, Display(Name = "Plessey")]
        Plessey,

        [EnumMember, Display(Name = "Postnet")]
        Postnet,

        [EnumMember, Display(Name = "QR Code")]
        QRCode,

        [EnumMember, Display(Name = "SCC-14")]
        SCC14,

        [EnumMember, Display(Name = "Standard 2 of 5")]
        Standard2Of5,

        [EnumMember, Display(Name = "UCC/EAN 218")]
        UCCEAN218,

        [EnumMember, Display(Name = "UCC/EAN Shipping Container Code")]
        UCCEANShippingContainerCode,

        [EnumMember, Display(Name = "UPC shipping container code")]
        UPCShippingContainerCode,

        [EnumMember, Display(Name = "UPC-A")]
        UPCA,

        [EnumMember, Display(Name = "UPC-E")]
        UPCE,

        [EnumMember, Display(Name = "Unknown")]
        Unknown = 99
    }
}
