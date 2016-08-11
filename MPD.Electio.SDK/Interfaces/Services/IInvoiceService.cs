using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Payments;

namespace MPD.Electio.SDK.Interfaces.Services
{
    public interface IInvoiceService
    {
        IList<InvoiceSummary> GetInvoiceListForCustomer(Guid customerReference);

        Task<IList<InvoiceSummary>> GetInvoiceListForCustomerAsync(Guid customerReference);

    }
}
