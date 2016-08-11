using System;

namespace MPD.Electio.SDK.DataTypes.Attributes
{
	/// <summary>Marks a consignment state as being a "Shipped" state</summary>
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class ShippedAttribute : Attribute
	{
	}
}
