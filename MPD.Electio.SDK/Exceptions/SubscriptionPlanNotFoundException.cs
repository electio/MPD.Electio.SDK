using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class SubscriptionPlanNotFoundException : Exception
    {
        public SubscriptionPlanNotFoundException(string message) : base(message)
        {
        }
    }
}