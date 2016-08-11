using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class OperationFailedException : Exception
    {
        public OperationFailedException(string message) : base(message)
        {
        }
    }
}