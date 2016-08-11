using System.Runtime.Serialization;

namespace MPD.Electio.SDK.DataTypes.Reconciliation
{
	[DataContract]
	public class Tolerance
	{
		///<summary>
		/// The maximum allowed difference between the value from the carrier 
		/// invoice and the value in Electio expressed as a percentage.
		/// Setting this value to Decimal.Zero will disable this check - 
		/// any deviation from expected cost will always be a discrepancy.
		/// This value may not be less than zero.
		/// </summary>
		/// <example>
		/// We have a consignment in Electio with a cost of £10.00. 
		/// The matching line from the carrier invoice is £10.50 because they 
		/// added a handling charge. The difference between £10.00 and £10.50 
		/// is: 
		/// 
		/// ((Actual / Expected) * 100) - 100 :
		/// ((10.50 / 10.00) * 100) - 100 == 5%. 
		/// 
		/// If <see cref="MaxPercentageDifferenceAllowed"/> is set to 5% or more
		/// then we would mark the line as reconciled.
		/// 
		/// If <see cref="MaxPercentageDifferenceAllowed"/> is set to less than 
		/// 5% (i.e. 0%) then the line will be flagged as a discrepancy.
		/// </example>
		[DataMember]
		public decimal MaxPercentageDifferenceAllowed { get; set; }

		/// <summary>
		/// The maximum value of a difference that if exceeded will automatically cause 
		/// a line to be marked as a discrepancy regardless of <see cref="MaxPercentageDifferenceAllowed"/>.
		/// A <see cref="ValueOfDifferenceThreshold"/> of Decimal.Zero will disable this check meaning that 
		/// if a value is within the <see cref="MaxPercentageDifferenceAllowed"/> it will always be 
		/// allowed regardless of the value of the difference. This value may not be less than zero.
		/// </summary>
		/// <example>
		/// We have a consignment in Electio with a cost of £50.00. 
		/// The matching line from the carrier invoice is £54.50. 
		/// The difference between £50.00 and £54.50  is: 
		/// 
		/// ((Actual / Expected) * 100) - 100 :
		/// ((54.50 / 50.00) * 100) - 100 == 9%. 
		/// 
		/// The Value of the Difference is £4.50:
		/// 
		/// Actual - Expected : (54.50 - 50.00) == £4.50
		/// 
		/// Assume <see cref="MaxPercentageDifferenceAllowed"/> is set to 10%.
		/// 
		/// If <see cref="ValueOfDifferenceThreshold"/> is set to £4.51 or higher 
		/// then the line will be marked as a match - it is within tolerance.
		/// 
		/// If <see cref="ValueOfDifferenceThreshold"/> is set to £4.50 or lower
		/// then the line will be marked as a discrepancy - despite the fact that 
		/// it is within the percentage difference tolerance, the amount is large 
		/// enough to trigger an automatic discrepancy. 
		/// </example>
		[DataMember]
		public decimal ValueOfDifferenceThreshold { get; set; }

		///<summary>
		/// The maximum allowed difference between the value from the carrier 
		/// invoice and the value in Electio expressed as a percentage.
		/// Setting this value to Decimal.Zero will disable this check - 
		/// any deviation from expected cost will always be a discrepancy.
		/// This value may not be less than zero. This is used when the 
		/// actual cost is lower than expected.
		/// </summary>
		[DataMember]
		public decimal NegativeMaxPercentageDifferenceAllowed { get; set; }

		/// <summary>
		/// The maximum value of a difference that if exceeded will automatically cause 
		/// a line to be marked as a discrepancy regardless of <see cref="NegativeMaxPercentageDifferenceAllowed"/>.
		/// A <see cref="NegativeValueOfDifferenceThreshold"/> of Decimal.Zero will disable this check meaning that 
		/// if a value is within the <see cref="NegativeMaxPercentageDifferenceAllowed"/> it will always be 
		/// allowed regardless of the value of the difference. This value may not be less than zero.
		/// This value is used when the actual cost is lower than expected.
		/// </summary>
		[DataMember]
		public decimal NegativeValueOfDifferenceThreshold { get; set; }

		/// <summary>
		/// The timespan in days that we expect a consignment to be within in relation to the 
		/// invoice line that references it. Setting this to zero will cause the system to 
		/// match the consignment with a date closest to the invoice line date. Setting this 
		/// to -1 will cause the reconciler to only match consignments with a shipping date 
		/// which exactly matches the Invoice Line Date.
		/// </summary>
		/// <example>
		/// Assume <see cref="ExpectedDateRangeInDays"/> is set to 5.
		/// 
		/// We find consignments with a carrier reference of ABC123. This returns 2 consignments, 
		/// one with a date of 10/11/12 and one with a date of 10/05/12. The invoice line has a date 
		/// of 11/11/12. 
		/// 
		/// We will try to find the consignment with a date range of 06/11/12 - 16/11/12 (Invoice line 
		/// date +/- 5 days). The result will be the consignment with the date 10/11/12 as it is the only 
		/// one within this range.
		/// 
		/// If multiple consignments are within the range or if <see cref="ExpectedDateRangeInDays"/> is 0
		/// we will pick the consignment which is closest to the invoice line date.
		/// 
		/// If <see cref="ExpectedDateRangeInDays"/> is -1 we will only match consignments which have a 
		/// shipping date which exactly matches the invoice date.
		/// </example>
		[DataMember]
		public int ExpectedDateRangeInDays { get; set; }
	}
}
