using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.ServiceAvailability
{
	public class CalendarOperationTimes
	{
        /// <summary>
        /// Gets or sets the manifest time.
        /// </summary>
        /// <value>
        /// The manifest time.
        /// </value>
        [DataMember]
		public TimeSpan ManifestTime { get; set; }

        /// <summary>
        /// Gets or sets the cut off time.
        /// </summary>
        /// <value>
        /// The cut off time.
        /// </value>
        [DataMember]
		public OperationTime CutOffTime { get; set; }

        /// <summary>
        /// Gets or sets the pre advice time.
        /// </summary>
        /// <value>
        /// The pre advice time.
        /// </value>
        [DataMember]
		public OperationTime? PreAdviceTime { get; set; }

        /// <summary>
        /// Gets or sets the operational cut off time.
        /// <remarks>
        /// This property is optional
        /// </remarks>
        /// </summary>
        /// <value>
        /// The operational cut off time.
        /// </value>
        [DataMember]
        public OperationTime? OperationalCutOffTime { get; set; }
    }
}