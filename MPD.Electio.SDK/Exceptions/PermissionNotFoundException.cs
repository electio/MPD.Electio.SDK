using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class PermissionNotFoundException : Exception
    {
        public PermissionNotFoundException() : base("Permissions not found") { }

        public PermissionNotFoundException(string message) : base (message)
        {
        }
    }
}