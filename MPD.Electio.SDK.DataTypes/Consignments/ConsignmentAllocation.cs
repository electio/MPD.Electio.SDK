using System;
using System.Collections.Generic;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    /// <summary>
    /// Consignment Allocation - represents the allocation of a Consignment
    /// with one or more Carrier Services.
    /// </summary>
    public class ConsignmentAllocation
	{
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the carrier consignments.
        /// </summary>
        /// <value>
        /// The carrier consignments.
        /// </value>
        public HashSet<CarrierConsignment> CarrierConsignments { get; protected set; }
        /// <summary>
        /// Gets or sets the date of allocation.
        /// </summary>
        /// <value>
        /// The allocation date.
        /// </value>
        public DateTimeOffset AllocationDate { get; protected set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ConsignmentAllocation"/> is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.
        /// </value>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the consignment reference.
        /// </summary>
        /// <value>
        /// The consignment reference.
        /// </value>
        public Guid ConsignmentReference { get; set; }

        /// <summary>
        /// Gets or sets the MPD carrier service reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service reference.
        /// </value>
        public string MpdCarrierServiceReference { get; protected set; }
        /// <summary>
        /// Gets or sets the name of the MPD carrier service.
        /// </summary>
        /// <value>
        /// The name of the MPD carrier service.
        /// </value>
        public string MpdCarrierServiceName { get; protected set; }
        /// <summary>
        /// Gets or sets the MPD carrier service group reference.
        /// </summary>
        /// <value>
        /// The MPD carrier service group reference.
        /// </value>
        public string MpdCarrierServiceGroupReference { get; set; }
        /// <summary>
        /// Gets or sets the name of the MPD carrier service group.
        /// </summary>
        /// <value>
        /// The name of the MPD carrier service group.
        /// </value>
        public string MpdCarrierServiceGroupName { get; set; }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
		{
			return string.Format("{0} Active={1} | {2} / {3} / {4}  ", AllocationDate, Active, MpdCarrierServiceGroupName, MpdCarrierServiceName, MpdCarrierServiceReference);
		}
	}
}
