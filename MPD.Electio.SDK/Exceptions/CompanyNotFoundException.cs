using System;

namespace MPD.Electio.SDK.Exceptions
{
    public class CompanyNotFoundException : ObjectNotFoundException
    {
        public CompanyNotFoundException(Guid companyReference)
            : base("Company", companyReference.ToString("N")) { }
    }
}