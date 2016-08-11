using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class CompanyCreationException : Exception
    {
        public CompanyCreationException()
            : base("Company was not successfully created.")
        {

        }
    }
}