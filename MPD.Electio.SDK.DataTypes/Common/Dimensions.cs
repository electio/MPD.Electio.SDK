using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Common
{
    /// <summary>
    /// The dimensions of a Consignment, Package or Item
    /// </summary>
    [DataContract]
    [XmlRoot("Dimensions", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Dimensions
    {
		private const decimal InchesPerCm = 0.393701m;

        /// <summary>
        /// Width in centimetres
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        [DataMember(Order = 2, IsRequired = true)]
		public decimal Width { get; set; }

        /// <summary>
        /// Length in centimetres
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        [DataMember(Order = 3, IsRequired = true)]
		public decimal Length { get; set; }

        /// <summary>
        /// Height in centimetres
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        [DataMember(Order = 4, IsRequired = true)]
		public decimal Height { get; set; }

        /// <summary>
        /// Gets the size of the longest dimension in cms
        /// </summary>
        /// <value>
        /// The longest dimension.
        /// </value>
        [IgnoreDataMember]
        [JsonIgnore]
        public decimal LongestDimension => Math.Max(Width, Math.Max(Height, Length));

        /// <summary>
        /// Gets the size of the longest dimension in inches
        /// </summary>
        /// <value>
        /// The longest dimension inches.
        /// </value>
        [IgnoreDataMember]
        [JsonIgnore]
        public decimal LongestDimensionInches => LongestDimension * InchesPerCm;

        /// <summary>
        /// Width in inches
        /// </summary>
        /// <value>
        /// The width inches.
        /// </value>
        [IgnoreDataMember]
        [JsonIgnore]
        [XmlIgnore]
	    public decimal WidthInches
		{
			get { return Width * InchesPerCm; }
			set { Width = value / InchesPerCm; }
		}

        /// <summary>
        /// Height in inches
        /// </summary>
        /// <value>
        /// The height inches.
        /// </value>
        [IgnoreDataMember]
        [JsonIgnore]
        [XmlIgnore]
        public decimal HeightInches
		{
			get { return Height * InchesPerCm; }
			set { Height = value / InchesPerCm; }
		}

        /// <summary>
        /// Length in inches
        /// </summary>
        /// <value>
        /// The length inches.
        /// </value>
        [IgnoreDataMember]
        [JsonIgnore]
        [XmlIgnore]
        public decimal LengthInches
		{
            get { return Length * InchesPerCm; }
            set { Length = value / InchesPerCm; }
		}

        /// <summary>
        /// Creates a new Dimensions object with all dimensions set to Zero
        /// </summary>
        public Dimensions() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dimensions" /> class.
        /// </summary>
        /// <param name="width">The width in centimetres.</param>
        /// <param name="length">The length the length in centimetres.</param>
        /// <param name="height">The height in centimetres.</param>
        public Dimensions(decimal width, decimal length, decimal height)
	    {
		    Width = width;
            Length = length;
		    Height = height;
	    }

        /// <summary>
        /// Creates a new Dimensions class using Inches as the measurement.
        /// </summary>
        /// <param name="widthInInches">The width in inches.</param>
        /// <param name="lengthInInches">The length in inches.</param>
        /// <param name="heightInInches">The height in inches.</param>
        /// <returns>
        /// New Dimensions object instantiated with Inches.
        /// </returns>
        public static Dimensions FromInches(decimal widthInInches, decimal lengthInInches, decimal heightInInches)
	    {
		    return new Dimensions
		    {
			    HeightInches = heightInInches,
				WidthInches = widthInInches,
                LengthInches = lengthInInches
		    };
	    }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
		{
			return $"{Length:0} x {Width:0} x {Height:0} cm";
		}
    }
}
