using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Common.Enums
{
    /// <summary>
    /// Mpd Carrier Service Type
    /// </summary>
    [Flags]
    [DataContract]
    [XmlRoot("MpdCarrierServiceType", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common.Enums")]
    public enum MpdCarrierServiceType
    {
        /// <summary>
        /// A scheduled collection service
        /// </summary>
        Scheduled = 1,
        /// <summary>
        /// An adhoc collection service.
        /// </summary>
        AdHoc = 2,
        /// <summary>
        /// A pick up service - the customer picks up the 
        /// consignment from the collection location.
        /// </summary>
        PickUp = 4,
        /// <summary>
        /// A drop off service - the customer drops off 
        /// the consignment at the origin location.
        /// </summary>
        DropOff = 8,
        /// <summary>
        /// A timed service - delivery is guaranteed within
        /// a specific time window.
        /// </summary>
        Timed = 16,
        /// <summary>
        /// A consolidated service - there a multiple legs within
        /// the journey, possibly involving multiple carriers.
        /// </summary>
        Consolidated = 32
    }
}
