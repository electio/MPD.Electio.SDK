using System.Collections.Generic;
using System.Linq;
using MPD.Electio.SDK.DataTypes.Attributes;
using MPD.Electio.SDK.DataTypes.Consignments.Enums;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
	public static class ConsignmentStates
	{
        /// <summary>
        /// Returns all states for a Consignment that has been shipped by a Carrier.
        /// </summary>
        /// <value>
        /// List of Shipped states.
        /// </value>
        public static IEnumerable<ConsignmentState> Shipped
		{
			get
			{
				return typeof(ConsignmentState)
					.GetFields()
					.Where(f => f.GetCustomAttributes(typeof(ShippedAttribute), false).FirstOrDefault() != null)
					.Select(f => f.GetValue(null))
					.Cast<ConsignmentState>()
					.ToList();
			}
		}

        /// <summary>
        /// Returns all states for a Consignment that has not yet been shipped by
        /// a Carrier.
        /// </summary>
        /// <value>
        /// List of Unshipped states.
        /// </value>
        public static IEnumerable<ConsignmentState> UnShipped
		{
			get
			{
				return System.Enum.GetValues(typeof(ConsignmentState))
					.Cast<ConsignmentState>()
					.Where(consignmentState => !Shipped.Contains(consignmentState))
					.ToList();
			}
		}
	}
}
