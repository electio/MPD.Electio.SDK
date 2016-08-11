using System;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.DataTypes.Quotes;

namespace MPD.Electio.SDK.Interfaces.Services
{
    /// <summary>
    /// Interface for Quote Service
    /// </summary>
    public interface IQuoteService
    {
        /// <summary>
        /// Generates quotes for the given consignment.
        /// </summary>
        /// <param name="consignment">The consignment.</param>
        /// <returns>Quotes</returns>
        QuoteResult CreateQuotes(Consignment consignment);
        /// <summary>
        /// Generates quotes for the given consignment.
        /// </summary>
        /// <param name="consignment">The consignment.</param>
        /// <returns>Task to await</returns>
        Task<QuoteResult> CreateQuotesAsync(Consignment consignment);
        /// <summary>
        /// Generates quotes for the given consignment reference.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>List of Quotes</returns>
        QuoteResult CreateQuotes(string consignmentReference);
        /// <summary>
        /// Generates quotes for the given consignment reference.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>Task to await.</returns>
        Task<QuoteResult> CreateQuotesAsync(string consignmentReference);
        /// <summary>
        /// Retrieves the specified quote if valid.
        /// </summary>
        /// <param name="quoteRequestReference">The quote request reference.</param>
        /// <returns>Quote</returns>
        QuoteResult GetQuoteResult(Guid quoteRequestReference);
        /// <summary>
        /// Retrieves the specified quote if valid.
        /// </summary>
        /// <param name="quoteRequestReference">The quote request reference.</param>
        /// <returns>Task to await.</returns>
        Task<QuoteResult> GetQuoteResultAsync(Guid quoteRequestReference);
        /// <summary>
        /// Purges all quotes that have expired.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        void PurgeQuotes(Guid secretKey);
        /// <summary>
        /// Purges all quotes that have expired.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        /// <returns>Task to await</returns>
        Task PurgeQuotesAsync(Guid secretKey);
    }
}
