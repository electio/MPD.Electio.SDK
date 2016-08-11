
namespace MPD.Electio.SDK.Interfaces
{
	public interface IEndpoints
	{
		string Subscription { get; }
		string Account { get; }
		string Security { get; }
		string AllocationRules { get; }
		string CarrierServices { get; }
		string Carriers { get; }
        string CarrierAccounts { get; }
        string CollectionCalendar { get; }
		string CustomerCarrierServices { get; }
		string LabelGeneration { get; }
        string Counter { get; }
		string CustomerAccounts { get; }
		string CustomerDocuments { get; }
		string Customers { get; }
		string PackageSize { get; }
		string Role { get; }
		string ServiceGroups { get; }
		string ShippingLocations { get; }
		string SecurityStaticData { get; }
        string Tracking { get; }
        string Rates { get; }
        string Quotes { get; }
        string RatesCustomers { get; }
        string RatesStaticData { get; }
        string RatesManagement { get; }
		string Address { get; }
        string ServiceAvailability { get; }
		string Consignment { get; }
        string ConsignmentAllocation { get; }
        string ConsignmentCreation { get; }
        string ConsignmentUpdation { get; }
        string Packages { get; }
        string Items { get; }
        string Payments { get; }
        string Invoice { get; }
        string PaymentCustomers { get; }
        string ConsignmentCustomers { get; }
        string Reports { get; }
        string Reconciliation { get; }
        string Tolerance { get; }
        string PayPal { get; }
        string BankCard { get; }
        string CarrierBooking { get; }
        string CarrierBookingDocumentation { get; }
        string CarrierBookingSchedule { get; }
        string PickUpLocation { get; }
        string ConsignmentDocuments { get; }
        string MetadataDictionary { get; }
        string DeliveryOptions { get; }
        string PickupOptions { get; }
	}
}
