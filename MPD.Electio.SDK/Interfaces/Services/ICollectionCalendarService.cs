using System.Collections.Generic;
using System.Threading.Tasks;
using MPD.Electio.SDK.DataTypes.ServiceAvailability;
using System;

namespace MPD.Electio.SDK.Interfaces.Services
{
	public interface ICollectionCalendarService
	{
		CollectionCalendar GetCollectionCalendar(string shippingLocationReference, string mpdCarrierReference);
		Task<CollectionCalendar> GetCollectionCalendarAsync(string shippingLocationReference, string mpdCarrierReference);
        void DeleteCollectionCalendar(string shippingLocationReference, string mpdCarrierReference);
        Task DeleteCollectionCalendarAsync(string shippingLocationReference, string mpdCarrierReference);
        void RemoveCollectionCalendarRule(Guid ruleId);
        Task RemoveCollectionCalendarRuleAsync(Guid ruleId);
        void RemoveCollectionCalendarException(Guid exceptionId);
        Task RemoveCollectionCalendarExceptionAsync(Guid exceptionId);
        void AddCollectionCalendarRule(string shippingLocationReference, string mpdCarrierReference, CalendarRule rule);
        Task AddCollectionCalendarRuleAsync(string shippingLocationReference, string mpdCarrierReference, CalendarRule rule);
        void AddCollectionCalendarException(string shippingLocationReference, string mpdCarrierReference, CalendarException exception);
        Task AddCollectionCalendarExceptionAsync(string shippingLocationReference, string mpdCarrierReference, CalendarException exception);
    }
}