using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class CustomersNotFoundException : Exception
    {
        public CustomersNotFoundException(string message) : base(message)
        {
        }
    }
}