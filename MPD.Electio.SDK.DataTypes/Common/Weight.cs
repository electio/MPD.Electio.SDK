
using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace MPD.Electio.SDK.DataTypes.Common
{
    ///<summary>Represents a weight. The default unit is kilograms</summary>
    [DataContract]
    [XmlRoot("Weight", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Common")]
    public class Weight
	{
		private const decimal PoundsPerKg = 2.20462m;

        /// <summary>
        /// Weight in kilograms
        /// </summary>
        /// <value>
        /// The kg.
        /// </value>
        [DataMember]
		public decimal Kg { get; set; }

        /// <summary>
        /// Weight in pounds
        /// </summary>
        /// <value>
        /// The LBS.
        /// </value>
        [IgnoreDataMember]
        [JsonIgnore]
        [XmlIgnore]
		public decimal Lbs
		{
			get { return Kg * PoundsPerKg; }
			set { Kg = value / PoundsPerKg; }
		}

        /// <summary>
        /// Creates a new weight of Zero kg
        /// </summary>
        public Weight() {  }

        /// <summary>
        /// Initializes a new instance of the <see cref="Weight" /> class with the specified weight in KG.
        /// </summary>
        /// <param name="weightInKg">The weight in kg.</param>
        public Weight(decimal weightInKg)
		{
			Kg = weightInKg;
		}

        /// <summary>
        /// Creates a new Weight object with the value set in lbs
        /// </summary>
        /// <param name="weightInPounds">The weight in pounds.</param>
        /// <returns>
        /// Weight with the value set in lbs.
        /// </returns>
        public static Weight FromLbs(decimal weightInPounds)
		{
			return new Weight { Lbs = weightInPounds };
		}

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
		{
			return $"{Math.Round(Kg,3,MidpointRounding.AwayFromZero)} kg";
		}
	}
}
