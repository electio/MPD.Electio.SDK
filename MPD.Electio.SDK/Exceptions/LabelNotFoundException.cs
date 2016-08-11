using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class LabelNotFoundException : Exception
    {
        public LabelNotFoundException(string consignmentReference) : base(string.Format("Label not found for consignment reference '{0}'", consignmentReference))
        {
        }
    }
}