using System;
using System.Runtime.Serialization;

namespace MPD.Electio.SDK.Exceptions
{
	[Serializable]
	public abstract class ObjectNotFoundException : Exception
	{
		private string ObjectType { get; set; }
		private string Identifier { get; set; }

		protected ObjectNotFoundException(string objectType, string identifier)
			: base("Specified " + objectType + " not found in database: " + identifier)
		{
			ObjectType = objectType;
			Identifier = identifier;
		}

		protected ObjectNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}