using System;
using System.Threading;
using MPD.Electio.SDK.Interfaces;

namespace MPD.Electio.SDK.Endpoints
{
    /// <summary>
    /// Electio Live REST Api endpoints.
    /// </summary>
    /// <seealso cref="MPD.Electio.SDK.Interfaces.IEndpoints" />
    public sealed class Production : IEndpoints
	{
		private Production() { }

		public string Subscription { get { return "https://api.electioapp.com/subscriptions/"; } }
		public string Account { get { return "https://api.electioapp.com/accounts/"; } }
		public string Security { get { return "https://api.electioapp.com/security/"; } }
		public string AllocationRules { get { return "https://api.electioapp.com/allocationRules/"; } }
        public string CarrierServices { get { return "https://api.electioapp.com/carrierServices/"; } }
        public string Carriers { get { return "https://api.electioapp.com/carriers/"; } }
        public string CarrierAccounts { get { return "https://api.electioapp.com/carrieraccounts/"; } }
        public string CustomerCarrierServices { get { return "https://api.electioapp.com/customerCarrierServices/"; } }
        public string LabelGeneration { get { return "https://api.electioapp.com/labels/"; } }
        public string CollectionCalendar { get { return "https://api.electioapp.com/collectionCalendar/"; } }
        public string CustomerAccounts { get { return "https://api.electioapp.com/customersaccounts/"; } }
        public string CustomerDocuments { get { return "https://api.electioapp.com/documents/"; } }
        public string Customers { get { return "https://api.electioapp.com/customers/"; } }
        public string PackageSize { get { return "https://api.electioapp.com/packageSizes/"; } }
        public string Role { get { return "https://api.electioapp.com/roles/"; } }
        public string ServiceGroups { get { return "https://api.electioapp.com/serviceGroups/"; } }
        public string ShippingLocations { get { return "https://api.electioapp.com/shippingLocations/"; } }
        public string SecurityStaticData { get { return "https://api.electioapp.com/staticdata/"; } }

        public string Rates { get { return "https://api.electioapp.com/rates/"; } }
        public string RatesStaticData { get { return "https://api.electioapp.com/rates/management/staticdata/"; } }
        public string RatesCustomers { get { return "https://api.electioapp.com/rates/customers/"; } }
        public string RatesManagement { get { return "https://api.electioapp.com/rates/management/"; } }

        public string Counter { get { return "https://api.electioapp.com/counters/"; } }

        public string Tracking { get { return "https://api.electioapp.com/tracking/"; } }

        public string ServiceAvailability { get { return string.Empty; } }

		public string Address { get { return "https://api.electioapp.com/address/"; } }

        public string Consignment { get { return "https://api.electioapp.com/consignments/"; } }

        public string ConsignmentCreation { get { return "https://api.electioapp.com/consignments/"; } }

        public string ConsignmentUpdation { get { return "https://api.electioapp.com/consignments/"; } }

        public string ConsignmentAllocation { get { return "https://api.electioapp.com/allocation/"; } }

        public string Quotes { get { return "https://api.electioapp.com/quotes/"; } }

        public string Packages { get { return "https://api.electioapp.com/packages/"; } }

        public string Items { get { return "https://api.electioapp.com/items/"; } }

        public string Payments { get { return "https://api.electioapp.com/paymentsService/"; } }
        public string PaymentCustomers { get { return "https://api.electioapp.com/customers/"; } }

        public string ConsignmentCustomers { get { return "https://api.electioapp.com/consignments/customer/"; } }

        public string Invoice { get { return "http://PAYMENTS-ELECTIO-APP-API/v1/invoiceService/"; } }

        public string Reports { get { return "https://api.electioapp.com/reports/"; } }

        public string Reconciliation { get { return "http://api.electioapp.com/reconciliation/"; } }

		public string Tolerance { get { return "http://api.electioapp.com/tolerance/"; } }

        public string PayPal { get { return "http://api.electioapp.com/paypal/";  } }

        public string BankCard { get { return "http://api.electioapp.com/bankcard/"; } }

        public string CarrierBooking { get { return "http://api.electioapp.com/carrierbooking/"; } }

        public string CarrierBookingDocumentation { get { return "http://api.electioapp.com/carrierbooking/documentation/"; } }

        public string CarrierBookingSchedule { get { return "http://api.electioapp.com/carrierbooking/schedule/"; } }

        public string PickUpLocation { get { return "https://api.electioapp.com/pickUpLocationLocator/"; } }
        public string ConsignmentDocuments { get { return "https://api.electioapp.com/consignments/docs/"; } }

		public string MetadataDictionary { get { return "https://api.electioapp.com/consignments/metadatadictionary/"; } }

        public string DeliveryOptions { get { return "https://api.electioapp.com/deliveryoptions/"; } }

        public string PickupOptions { get { return "https://api.electioapp.com/deliveryoptions/pickupoptions/"; } }

        private static readonly Lazy<Production> _instance = new Lazy<Production>(() => new Production(), LazyThreadSafetyMode.ExecutionAndPublication);

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Production Instance
		{
			get { return _instance.Value; }
		}
	}
}
