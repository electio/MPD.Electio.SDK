using System;

namespace MPD.Electio.SDK.DataTypes.Attributes
{
	/// <summary>Marks consignment states with a severity which may alter how the UI displays chart elements for those states</summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class UiDisplaySeverityAttribute : Attribute
	{
	    public UiDisplaySeverityAttribute()
	    {
	        
	    }

		public UiDisplaySeverity Severity { get; private set; }

		public UiDisplaySeverityAttribute(UiDisplaySeverity severity)
		{
			Severity = severity;
		}

		public enum UiDisplaySeverity
		{
			None = 0,
			Warning = 1,
			Error = 2
		}
	}
}
