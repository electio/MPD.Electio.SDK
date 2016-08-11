using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.ServiceAvailability;
using MPD.Electio.SDK.Interfaces;
using MPD.Electio.SDK.Interfaces.Services;

namespace MPD.Electio.SDK.Services
{
	public class CollectionCalendarService : BaseService, ICollectionCalendarService
	{

		public CollectionCalendarService(string apiKey, IEndpoints endpoints, ILogger log) : base(apiKey, endpoints, endpoints.CollectionCalendar, log)
		{
		}
                
        public CollectionCalendar GetCollectionCalendar(string shippingLocationReference, string mpdCarrierReference)
		{
			return CallAsyncMethod(() => GetCollectionCalendarAsync(shippingLocationReference, mpdCarrierReference).Result);
		}		
                
        public void DeleteCollectionCalendar(string shippingLocationReference, string mpdCarrierReference)
        {
            CallAsyncMethod(() => DeleteCollectionCalendarAsync(shippingLocationReference, mpdCarrierReference).Wait());
        }        
                
        public void AddCollectionCalendarRule(string shippingLocationReference, string mpdCarrierReference, CalendarRule rule)
        {
            CallAsyncMethod(() => AddCollectionCalendarRuleAsync(shippingLocationReference, mpdCarrierReference, rule).Wait());
        }        
                
        public void AddCollectionCalendarException(string shippingLocationReference, string mpdCarrierReference, CalendarException exception)
        {
            CallAsyncMethod(() => AddCollectionCalendarExceptionAsync(shippingLocationReference, mpdCarrierReference, exception).Wait());
        }        
                
        public void RemoveCollectionCalendarRule(Guid ruleId)
        {
            CallAsyncMethod(() => RemoveCollectionCalendarRuleAsync(ruleId).Wait());
        }        
                
        public void RemoveCollectionCalendarException(Guid exceptionId)
        {
            CallAsyncMethod(() => RemoveCollectionCalendarExceptionAsync(exceptionId).Wait());
        }



        public Task RemoveCollectionCalendarExceptionAsync(Guid exceptionId)
        {
            return
                Rest.PutAsync(exceptionId, string.Format("removeException/{0}", WebUtility.UrlEncode(exceptionId.ToString())));
        }
        public Task<CollectionCalendar> GetCollectionCalendarAsync(string shippingLocationReference, string mpdCarrierReference)
        {
            return
                Rest.GetAsync<CollectionCalendar>(string.Format("{0}/{1}",
                    WebUtility.UrlEncode(shippingLocationReference), WebUtility.UrlEncode(mpdCarrierReference)));
        }

        public Task DeleteCollectionCalendarAsync(string shippingLocationReference, string mpdCarrierReference)
        {
            return
                Rest.PutAsync(mpdCarrierReference, string.Format("{0}/{1}",
                    WebUtility.UrlEncode(shippingLocationReference), WebUtility.UrlEncode(mpdCarrierReference)));
        }

        public Task AddCollectionCalendarRuleAsync(string shippingLocationReference, string mpdCarrierReference, CalendarRule rule)
        {
            return
                Rest.PostAsync(rule, string.Format("addRule/{0}/{1}", WebUtility.UrlEncode(shippingLocationReference), WebUtility.UrlEncode(mpdCarrierReference)));
        }

        public Task AddCollectionCalendarExceptionAsync(string shippingLocationReference, string mpdCarrierReference, CalendarException exception)
        {
            return
                Rest.PostAsync(exception, string.Format("addException/{0}/{1}", WebUtility.UrlEncode(shippingLocationReference), WebUtility.UrlEncode(mpdCarrierReference)));
        }

        public Task RemoveCollectionCalendarRuleAsync(Guid ruleId)
        {
            return
                Rest.PutAsync(ruleId, string.Format("removeRule/{0}", WebUtility.UrlEncode(ruleId.ToString())));
        }
    }
}
