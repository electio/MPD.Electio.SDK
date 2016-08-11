using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace MPD.Electio.SDK.DataTypes.Consignments
{
    [DataContract]
    [XmlRoot("ConsignmentSearchTerms", Namespace = "http://electioapp.com/schemas/v1/MPD.Electio.SDK.DataTypes.Consignments")]
    public class ConsignmentSearchTerms
	{
		private const string QueryStringDateFormat = "yyyy-MM-dd";

		[DataMember]
		public DateTime? StartFrom { get; set; }

		[DataMember]
		public DateTime? EndAt { get; set; }

		[DataMember]
		public int? PageSize { get; set; }

		[DataMember]
		public int? StartPage { get; set; }

		[DataMember]
		public DateTime? CreatedDateFrom { get; set; }

		[DataMember]
		public DateTime? CreatedDateTo { get; set; }

		[DataMember]
		public DateTime? ScheduledDeliveryDateFrom { get; set; }

		[DataMember]
		public DateTime? ScheduledDeliveryDateTo { get; set; }

		[DataMember]
		public DateTime? ShippedDateFrom { get; set; }

		[DataMember]
		public DateTime? ShippedDateTo { get; set; }

		[DataMember]
		public DateTime? RequestedDeliveryDateFrom { get; set; }

		[DataMember]
		public DateTime? RequestedDeliveryDateTo { get; set; }

		[DataMember]
		public string Reference { get; set; }

        [DataMember]
        public string ReferenceProvidedByCustomer { get; set; }

        [DataMember]
        public string TrackingReference { get; set; }

        [DataMember]
		public string State { get; set; }

		[DataMember]
		public int? WeightInGramsFrom { get; set; }

		[DataMember]
		public int? WeightInGramsTo { get; set; }

		[DataMember]
		public string CarrierService { get; set; }

		[DataMember]
		public string Source { get; set; }

		[DataMember]
		public string PostCode { get; set; }

		[DataMember]
		public decimal? ValueFrom { get; set; }

		[DataMember]
		public decimal? ValueTo { get; set; }

		[DataMember]
		public string LabelsPrinted { get; set; }

		[DataMember]
		public string SearchTerm { get; set; }

		[DataMember]
		public string StateAttribute { get; set; }

		[DataMember]
		public string ShippingLocationReference { get; set; }

        [DataMember]
        public string DestinationCountryCode { get; set; }

        [DataMember]
        public string DestinationRegion { get; set; }

        [DataMember]
        public string ClientReference { get; set; }

        [DataMember]
        public string PackageNumber { get; set; }

        [DataMember]
        public string ConsignmentNumber { get; set; }

        [DataMember]
        public long? CReference { get;  set; }

        [DataMember]
        public long? PReference { get; set; }

		public Dictionary<string, string> ToDictionary()
		{
			var dic = new Dictionary<string, string>
			{
				{ START_FROM,  FormatDate(StartFrom) },
				{ END_AT,  FormatDate(EndAt) },
				{ CREATED_DATE_FROM,  FormatDate(CreatedDateFrom) },
				{ CREATED_DATE_TO,  FormatDate(CreatedDateTo) },
				{ SCHEDULED_DELIVERY_DATE_FROM,  FormatDate(ScheduledDeliveryDateFrom) },
				{ SCHEDULED_DELIVERY_DATE_TO,  FormatDate(ScheduledDeliveryDateTo) },
				{ SHIPPED_DATE_FROM,  FormatDate(ShippedDateFrom) },
				{ SHIPPED_DATE_TO,  FormatDate(ShippedDateTo) },
				{ REQUESTED_DELIVERY_DATE_FROM,  FormatDate(RequestedDeliveryDateFrom) },
				{ REQUESTED_DELIVERY_DATE_TO,  FormatDate(RequestedDeliveryDateTo) },
				{ REFERENCE,  Reference },
				{ STATE,  State },
				{ CARRIER_SERVICE,  CarrierService },
				{ SOURCE,  Source },
				{ POSTCODE,  PostCode },
				{ LABELS_PRINTED,  LabelsPrinted },
				{ SEARCH_TERM,  SearchTerm },
				{ STATE_ATTRIBUTE,  StateAttribute },
				{ SHIPPING_LOCATION_REFERENCE,  ShippingLocationReference },
				{ WEIGHT_IN_GRAMS_FROM,  FormatNumeric(WeightInGramsFrom) },
				{ WEIGHT_IN_GRAMS_TO,  FormatNumeric(WeightInGramsTo) },
				{ VALUE_FROM,  FormatNumeric(ValueFrom) },
				{ VALUE_TO,  FormatNumeric(ValueTo) },
                { DESTINATION_COUNTRY_CODE, DestinationCountryCode },
                { DESTINATION_REGION, DestinationRegion },
                { CLIENT_REFERENCE, ClientReference },
                { PACKAGE_NUMBER, PackageNumber },
                { CONSIGNMENT_NUMBER, ConsignmentNumber },
                { REFERENCE_PROVIDED_BY_CUSTOMER, ReferenceProvidedByCustomer },
                { TRACKING_REFERENCE, TrackingReference },
                { C_REFERENCE, FormatNumeric(CReference)},
                { P_REFERENCE, FormatNumeric(PReference) }
            };

			return dic.Where(d => !String.IsNullOrEmpty(d.Value)).ToDictionary(ks => ks.Key, vs => vs.Value);
		}

		public static ConsignmentSearchTerms FromQueryParameters(NameValueCollection collection)
		{
			return new ConsignmentSearchTerms
			{
				StartFrom = DateFromString(collection[START_FROM]),
				EndAt = DateFromString(collection[END_AT]),
				CreatedDateFrom = DateFromString(collection[CREATED_DATE_FROM]),
				CreatedDateTo = DateFromString(collection[CREATED_DATE_TO]),
				ScheduledDeliveryDateFrom = DateFromString(collection[SCHEDULED_DELIVERY_DATE_FROM]),
				ScheduledDeliveryDateTo = DateFromString(collection[SCHEDULED_DELIVERY_DATE_TO]),
				ShippedDateFrom = DateFromString(collection[SHIPPED_DATE_FROM]),
				ShippedDateTo = DateFromString(collection[SHIPPED_DATE_TO]),
				RequestedDeliveryDateFrom = DateFromString(collection[REQUESTED_DELIVERY_DATE_FROM]),
				RequestedDeliveryDateTo = DateFromString(collection[REQUESTED_DELIVERY_DATE_TO]),
				Reference = collection[REFERENCE],
				State = collection[STATE],
				CarrierService = collection[CARRIER_SERVICE],
				Source = collection[SOURCE],
				PostCode = collection[POSTCODE],
				SearchTerm = collection[SEARCH_TERM],
				StateAttribute = collection[STATE_ATTRIBUTE],
				ShippingLocationReference = collection[SHIPPING_LOCATION_REFERENCE],
				LabelsPrinted = collection[LABELS_PRINTED],
				WeightInGramsFrom = IntFromString(collection[WEIGHT_IN_GRAMS_FROM]),
				WeightInGramsTo = IntFromString(collection[WEIGHT_IN_GRAMS_TO]),
				ValueFrom = DecimalFromString(collection[VALUE_FROM]),
				ValueTo = DecimalFromString(collection[VALUE_TO]),
                DestinationCountryCode = collection[DESTINATION_COUNTRY_CODE],
                DestinationRegion = collection[DESTINATION_REGION],
                ClientReference = collection[CLIENT_REFERENCE],
                PackageNumber = collection[PACKAGE_NUMBER],
                ConsignmentNumber = collection[CONSIGNMENT_NUMBER],
                ReferenceProvidedByCustomer = collection[REFERENCE_PROVIDED_BY_CUSTOMER],
                TrackingReference = collection[TRACKING_REFERENCE],
                CReference = LongFromAlphanumericString(collection[C_REFERENCE]),
                PReference = LongFromAlphanumericString(collection[P_REFERENCE])
			};
		}

        private static DateTime? DateFromString(string value)
		{
			if (String.IsNullOrWhiteSpace(value))
			{
				return null;
			}

			DateTime result;
			if (DateTime.TryParse(value, out result))
			{
				return result;
			}
			
			if (DateTime.TryParseExact(value, QueryStringDateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None,  out result))
			{
				return result;
			}

			return null;
		}
		
		private static int? IntFromString(string value)
		{
			if (String.IsNullOrWhiteSpace(value))
			{
				return null;
			}

			int result;
			if (int.TryParse(value, out result))
			{
				return result;
			}

			return null;
		}

        private static long? LongFromAlphanumericString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return null;
            }

            var justNumbers = Regex.Replace(value, @"[^\d]", string.Empty);

            long result;
            if (long.TryParse(justNumbers, out result))
            {
                return result;
            }

            return null;
        }

        private static decimal? DecimalFromString(string value)
		{
			if (String.IsNullOrWhiteSpace(value))
			{
				return null;
			}

			decimal result;
			if (decimal.TryParse(value, out result))
			{
				return result;
			}

			return null;
		}

		private static string FormatDate(DateTime? date)
		{
			return date.HasValue ? date.Value.ToString(QueryStringDateFormat) : null;
		}

		private static string FormatNumeric(int? value)
		{
			return value.HasValue ? value.Value.ToString() : null;
		}

        private static string FormatNumeric(long? value)
        {
            return value?.ToString();
        }

        private static string FormatNumeric(decimal? value)
		{
			return value.HasValue ? value.Value.ToString(CultureInfo.CurrentUICulture) : null;
		}

	    private const string START_FROM = "startFrom";
	    private const string END_AT = "endAt";
	    private const string CREATED_DATE_FROM = "createdDateFrom";
	    private const string CREATED_DATE_TO = "createdDateTo";
	    private const string SCHEDULED_DELIVERY_DATE_FROM = "scheduledDeliveryDateFrom";
	    private const string SCHEDULED_DELIVERY_DATE_TO = "scheduledDeliveryDateTo";
	    private const string SHIPPED_DATE_FROM = "shippedDateFrom";
	    private const string SHIPPED_DATE_TO = "shippedDateTo";
	    private const string REQUESTED_DELIVERY_DATE_FROM = "requestedDeliveryDateFrom";
	    private const string REQUESTED_DELIVERY_DATE_TO = "requestedDeliveryDateTo";
	    private const string REFERENCE = "reference";
	    private const string REFERENCE_PROVIDED_BY_CUSTOMER = "referenceProvidedByCustomer";
	    private const string STATE = "state";
	    private const string CARRIER_SERVICE = "carrierService";
	    private const string SOURCE = "source";
	    private const string POSTCODE = "postcode";
	    private const string LABELS_PRINTED = "labelsPrinted";
	    private const string SEARCH_TERM = "searchTerm";
	    private const string STATE_ATTRIBUTE = "stateAttribute";
	    private const string SHIPPING_LOCATION_REFERENCE = "shippingLocationReference";
	    private const string WEIGHT_IN_GRAMS_FROM = "weightInGramsFrom";
	    private const string WEIGHT_IN_GRAMS_TO = "weightInGramsTo";
	    private const string VALUE_FROM = "valueFrom";
	    private const string VALUE_TO = "valueTo";
	    private const string DESTINATION_COUNTRY_CODE = "destinationCountryCode";
	    private const string DESTINATION_REGION = "destinationRegion";
	    private const string CLIENT_REFERENCE = "clientReference";
	    private const string PACKAGE_NUMBER = "packageNumber";
	    private const string CONSIGNMENT_NUMBER = "consignmentNumber";
        private const string TRACKING_REFERENCE = "trackingReference";
        private const string C_REFERENCE = "cReference";
        private const string P_REFERENCE = "pReference";

    }
}
