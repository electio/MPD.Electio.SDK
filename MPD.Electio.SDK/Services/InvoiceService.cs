using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Payments;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    public class InvoiceService : BaseService, IInvoiceService
    {

        public InvoiceService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.Invoice, log)
        {
		}

        public IList<InvoiceSummary> GetInvoiceListForCustomer(Guid customerReference)
        {
            return CallAsyncMethod(() => GetInvoiceListForCustomerAsync(customerReference).Result);
        }

        public Task<IList<InvoiceSummary>> GetInvoiceListForCustomerAsync(Guid customerReference)
        {
            return Rest.GetAsync<IList<InvoiceSummary>>(customerReference.ToString());
        }
    }
}
