using System;
using System.Net;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.Consignments;
using MPD.Electio.SDK.DataTypes.Quotes;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
    /// <summary>
    /// Default implementation of IQuoteService
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Services.BaseService" />
    /// <seealso cref="MPD.Electio.SDK.Interfaces.Services.IQuoteService" />
    public class QuoteService : BaseService, IQuoteService
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteService"/> class.
        /// </summary>
        /// <param name="apiKey">The API key.</param>
        /// <param name="endpoints">The endpoints.</param>
        /// <param name="log">The log.</param>
        /// <exception cref="System.ArgumentNullException">endpoints</exception>
        /// <exception cref="System.ArgumentException">You must supply an api key;apiKey</exception>
        public QuoteService(string apiKey, IEndpoints endpoints, ILogger log) : base (apiKey, endpoints, endpoints.Quotes, log)
		{
		}

        /// <summary>
        /// Generates quotes for the given consignment.
        /// </summary>
        /// <param name="consignment">The consignment.</param>
        /// <returns>
        /// Quotes
        /// </returns>
        public QuoteResult CreateQuotes(Consignment consignment)
        {
            return CallAsyncMethod(() => CreateQuotesAsync(consignment).Result);
        }

        /// <summary>
        /// Generates quotes for the given consignment.
        /// </summary>
        /// <param name="consignment">The consignment.</param>
        /// <returns>
        /// Task to await
        /// </returns>
        public Task<QuoteResult> CreateQuotesAsync(Consignment consignment)
        {
            return Rest.PostAsync<Consignment, QuoteResult>(consignment, string.Empty);
        }

        /// <summary>
        /// Generates quotes for the given consignment reference.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// List of Quotes
        /// </returns>
        public QuoteResult CreateQuotes(string consignmentReference)
        {
            return CallAsyncMethod(() => CreateQuotesAsync(consignmentReference).Result);
        }

        /// <summary>
        /// Generates quotes for the given consignment reference.
        /// </summary>
        /// <param name="consignmentReference">The consignment reference.</param>
        /// <returns>
        /// Task to await.
        /// </returns>
        public Task<QuoteResult> CreateQuotesAsync(string consignmentReference)
        {
            return Rest.GetAsync<QuoteResult>(string.Format("consignment/{0}", WebUtility.UrlEncode(consignmentReference)));
        }

        /// <summary>
        /// Retrieves the specified quote if valid.
        /// </summary>
        /// <param name="quoteRequestReference">The quote request reference.</param>
        /// <returns>
        /// Quote
        /// </returns>
        public QuoteResult GetQuoteResult(Guid quoteRequestReference)
        {
            return CallAsyncMethod(() => GetQuoteResultAsync(quoteRequestReference).Result);
        }

        /// <summary>
        /// Retrieves the specified quote if valid.
        /// </summary>
        /// <param name="quoteRequestReference">The quote request reference.</param>
        /// <returns>
        /// Task to await.
        /// </returns>
        public Task<QuoteResult> GetQuoteResultAsync(Guid quoteRequestReference)
        {
            return Rest.GetAsync<QuoteResult>(quoteRequestReference.ToString());
        }

        /// <summary>
        /// Purges all quotes that have expired.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        public void PurgeQuotes(Guid secretKey)
        {
            PurgeQuotesAsync(secretKey).Wait();
        }

        /// <summary>
        /// Purges all quotes that have expired.
        /// </summary>
        /// <param name="secretKey">The secret key.</param>
        /// <returns>
        /// Task to await
        /// </returns>
        public Task PurgeQuotesAsync(Guid secretKey)
        {
            return Rest.GetAsync(string.Format("purge/{0}", secretKey));
        }

    }
}