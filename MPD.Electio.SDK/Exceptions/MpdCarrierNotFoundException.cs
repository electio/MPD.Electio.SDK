namespace MPD.Electio.SDK.Exceptions
{
	public class MpdCarrierNotFoundException : ObjectNotFoundException
	{
		public MpdCarrierNotFoundException(string carrierReference)
			: base("MpdCarrier", carrierReference.ToString())
		{
		}
	}
}
