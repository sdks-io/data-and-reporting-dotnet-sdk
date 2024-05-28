// <copyright file="PricedRequestData.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellDataReportingAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using ShellDataReportingAPIs.Standard;
    using ShellDataReportingAPIs.Standard.Utilities;

    /// <summary>
    /// PricedRequestData.
    /// </summary>
    public class PricedRequestData
    {
        private int? accountId;
        private string accountNumber;
        private string driverName;
        private int? cardGroupId;
        private string cardPAN;
        private string productCode;
        private string productName;
        private string siteCode;
        private string incomingSiteNumber;
        private string invoiceDate;
        private string invoiceNumber;
        private string purchasedInCountryCode;
        private string purchasedInCountry;
        private int? siteGroupId;
        private string vehicleRegistrationNumber;
        private int? feeTypeId;
        private string lineItemDescription;
        private string fromDate;
        private string toDate;
        private string postingDateFrom;
        private string postingDateTo;
        private string transactionItemId;
        private bool? fuelOnly;
        private bool? includeFees;
        private string invoiceFromDate;
        private string invoiceToDate;
        private string hostingCollectingCompanyNumber;
        private string search;
        private string transactionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "DriverName", false },
            { "CardGroupId", false },
            { "CardPAN", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "SiteCode", false },
            { "IncomingSiteNumber", false },
            { "InvoiceDate", false },
            { "InvoiceNumber", false },
            { "PurchasedInCountryCode", false },
            { "PurchasedInCountry", false },
            { "SiteGroupId", false },
            { "VehicleRegistrationNumber", false },
            { "FeeTypeId", false },
            { "LineItemDescription", false },
            { "FromDate", false },
            { "ToDate", false },
            { "PostingDateFrom", false },
            { "PostingDateTo", false },
            { "TransactionItemId", false },
            { "FuelOnly", true },
            { "IncludeFees", false },
            { "InvoiceFromDate", false },
            { "InvoiceToDate", false },
            { "HostingCollectingCompanyNumber", false },
            { "Search", false },
            { "TransactionId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedRequestData"/> class.
        /// </summary>
        public PricedRequestData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedRequestData"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="siteCode">SiteCode.</param>
        /// <param name="incomingSiteNumber">IncomingSiteNumber.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="purchasedInCountryCode">PurchasedInCountryCode.</param>
        /// <param name="purchasedInCountry">PurchasedInCountry.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="vehicleRegistrationNumber">VehicleRegistrationNumber.</param>
        /// <param name="feeTypeId">FeeTypeId.</param>
        /// <param name="lineItemDescription">LineItemDescription.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="sortOrder">SortOrder.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="period">Period.</param>
        /// <param name="postingDateFrom">PostingDateFrom.</param>
        /// <param name="postingDateTo">PostingDateTo.</param>
        /// <param name="transactionItemId">TransactionItemId.</param>
        /// <param name="fuelOnly">FuelOnly.</param>
        /// <param name="includeFees">IncludeFees.</param>
        /// <param name="isMultipayer">IsMultipayer.</param>
        /// <param name="validInvoiceDateOnly">ValidInvoiceDateOnly.</param>
        /// <param name="invoiceFromDate">InvoiceFromDate.</param>
        /// <param name="invoiceToDate">InvoiceToDate.</param>
        /// <param name="hostingCollectingCompanyNumber">HostingCollectingCompanyNumber.</param>
        /// <param name="search">Search.</param>
        /// <param name="transactionId">TransactionId.</param>
        public PricedRequestData(
            string colCoCode = null,
            Models.PricedTransactionReqV2InvoiceStatusEnum? invoiceStatus = null,
            string payerNumber = null,
            int? accountId = null,
            string accountNumber = null,
            string driverName = null,
            int? cardGroupId = null,
            string cardPAN = null,
            string productCode = null,
            string productName = null,
            string siteCode = null,
            string incomingSiteNumber = null,
            string invoiceDate = null,
            string invoiceNumber = null,
            string purchasedInCountryCode = null,
            string purchasedInCountry = null,
            int? siteGroupId = null,
            string vehicleRegistrationNumber = null,
            int? feeTypeId = null,
            string lineItemDescription = null,
            List<int> cards = null,
            Models.PricedTransactionReqV2SortOrderEnum? sortOrder = null,
            string fromDate = null,
            string toDate = null,
            Models.PricedTransactionReqV2PeriodEnum? period = null,
            string postingDateFrom = null,
            string postingDateTo = null,
            string transactionItemId = null,
            bool? fuelOnly = false,
            bool? includeFees = null,
            bool? isMultipayer = null,
            bool? validInvoiceDateOnly = false,
            string invoiceFromDate = null,
            string invoiceToDate = null,
            string hostingCollectingCompanyNumber = null,
            string search = null,
            string transactionId = null)
        {
            this.ColCoCode = colCoCode;
            this.InvoiceStatus = invoiceStatus;
            this.PayerNumber = payerNumber;
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (productName != null)
            {
                this.ProductName = productName;
            }

            if (siteCode != null)
            {
                this.SiteCode = siteCode;
            }

            if (incomingSiteNumber != null)
            {
                this.IncomingSiteNumber = incomingSiteNumber;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (purchasedInCountryCode != null)
            {
                this.PurchasedInCountryCode = purchasedInCountryCode;
            }

            if (purchasedInCountry != null)
            {
                this.PurchasedInCountry = purchasedInCountry;
            }

            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (vehicleRegistrationNumber != null)
            {
                this.VehicleRegistrationNumber = vehicleRegistrationNumber;
            }

            if (feeTypeId != null)
            {
                this.FeeTypeId = feeTypeId;
            }

            if (lineItemDescription != null)
            {
                this.LineItemDescription = lineItemDescription;
            }

            this.Cards = cards;
            this.SortOrder = sortOrder;
            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            this.Period = period;
            if (postingDateFrom != null)
            {
                this.PostingDateFrom = postingDateFrom;
            }

            if (postingDateTo != null)
            {
                this.PostingDateTo = postingDateTo;
            }

            if (transactionItemId != null)
            {
                this.TransactionItemId = transactionItemId;
            }

            this.FuelOnly = fuelOnly;
            if (includeFees != null)
            {
                this.IncludeFees = includeFees;
            }

            this.IsMultipayer = isMultipayer;
            this.ValidInvoiceDateOnly = validInvoiceDateOnly;
            if (invoiceFromDate != null)
            {
                this.InvoiceFromDate = invoiceFromDate;
            }

            if (invoiceToDate != null)
            {
                this.InvoiceToDate = invoiceToDate;
            }

            if (hostingCollectingCompanyNumber != null)
            {
                this.HostingCollectingCompanyNumber = hostingCollectingCompanyNumber;
            }

            if (search != null)
            {
                this.Search = search;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

        }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Include)]
        public string ColCoCode { get; set; }

        /// <summary>
        /// Invoice status of the transactions. Mandatory Possible options:I - Invoiced, U – Un-Invoiced, A – All
        /// </summary>
        [JsonProperty("InvoiceStatus", NullValueHandling = NullValueHandling.Include)]
        public Models.PricedTransactionReqV2InvoiceStatusEnum? InvoiceStatus { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Include)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Account Id (GFN customer id)
        /// </summary>
        [JsonProperty("AccountId")]
        public int? AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.shouldSerialize["AccountId"] = true;
                this.accountId = value;
            }
        }

        /// <summary>
        /// Account Number of the selected account.
        /// </summary>
        [JsonProperty("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["AccountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Driver Name (of Card record)
        /// </summary>
        [JsonProperty("DriverName")]
        public string DriverName
        {
            get
            {
                return this.driverName;
            }

            set
            {
                this.shouldSerialize["DriverName"] = true;
                this.driverName = value;
            }
        }

        /// <summary>
        /// Card Group Id in GFN
        /// </summary>
        [JsonProperty("CardGroupId")]
        public int? CardGroupId
        {
            get
            {
                return this.cardGroupId;
            }

            set
            {
                this.shouldSerialize["CardGroupId"] = true;
                this.cardGroupId = value;
            }
        }

        /// <summary>
        /// Full Card PAN
        /// </summary>
        [JsonProperty("CardPAN")]
        public string CardPAN
        {
            get
            {
                return this.cardPAN;
            }

            set
            {
                this.shouldSerialize["CardPAN"] = true;
                this.cardPAN = value;
            }
        }

        /// <summary>
        /// Product Code – Global as per GFN configuration
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode
        {
            get
            {
                return this.productCode;
            }

            set
            {
                this.shouldSerialize["ProductCode"] = true;
                this.productCode = value;
            }
        }

        /// <summary>
        /// Product Name – Global as per GFN configuration
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                this.shouldSerialize["ProductName"] = true;
                this.productName = value;
            }
        }

        /// <summary>
        /// Site Code in GFN
        /// </summary>
        [JsonProperty("SiteCode")]
        public string SiteCode
        {
            get
            {
                return this.siteCode;
            }

            set
            {
                this.shouldSerialize["SiteCode"] = true;
                this.siteCode = value;
            }
        }

        /// <summary>
        /// Site Code as configured in GFN
        /// </summary>
        [JsonProperty("IncomingSiteNumber")]
        public string IncomingSiteNumber
        {
            get
            {
                return this.incomingSiteNumber;
            }

            set
            {
                this.shouldSerialize["IncomingSiteNumber"] = true;
                this.incomingSiteNumber = value;
            }
        }

        /// <summary>
        /// Returns the billed transaction for the given invoice date
        /// </summary>
        [JsonProperty("InvoiceDate")]
        public string InvoiceDate
        {
            get
            {
                return this.invoiceDate;
            }

            set
            {
                this.shouldSerialize["InvoiceDate"] = true;
                this.invoiceDate = value;
            }
        }

        /// <summary>
        /// Returns the billed transaction for the given invoice number
        /// </summary>
        [JsonProperty("InvoiceNumber")]
        public string InvoiceNumber
        {
            get
            {
                return this.invoiceNumber;
            }

            set
            {
                this.shouldSerialize["InvoiceNumber"] = true;
                this.invoiceNumber = value;
            }
        }

        /// <summary>
        /// Purchased InCountryCode
        /// </summary>
        [JsonProperty("PurchasedInCountryCode")]
        public string PurchasedInCountryCode
        {
            get
            {
                return this.purchasedInCountryCode;
            }

            set
            {
                this.shouldSerialize["PurchasedInCountryCode"] = true;
                this.purchasedInCountryCode = value;
            }
        }

        /// <summary>
        /// Network Delco PurchasedCountryName
        /// </summary>
        [JsonProperty("PurchasedInCountry")]
        public string PurchasedInCountry
        {
            get
            {
                return this.purchasedInCountry;
            }

            set
            {
                this.shouldSerialize["PurchasedInCountry"] = true;
                this.purchasedInCountry = value;
            }
        }

        /// <summary>
        /// Site Group Id in GFN
        /// </summary>
        [JsonProperty("SiteGroupId")]
        public int? SiteGroupId
        {
            get
            {
                return this.siteGroupId;
            }

            set
            {
                this.shouldSerialize["SiteGroupId"] = true;
                this.siteGroupId = value;
            }
        }

        /// <summary>
        /// Vehicle Registration (of Card record)
        /// </summary>
        [JsonProperty("VehicleRegistrationNumber")]
        public string VehicleRegistrationNumber
        {
            get
            {
                return this.vehicleRegistrationNumber;
            }

            set
            {
                this.shouldSerialize["VehicleRegistrationNumber"] = true;
                this.vehicleRegistrationNumber = value;
            }
        }

        /// <summary>
        /// Card Id (i.e. Unique Card Id in GFN)
        /// </summary>
        [JsonProperty("FeeTypeId")]
        public int? FeeTypeId
        {
            get
            {
                return this.feeTypeId;
            }

            set
            {
                this.shouldSerialize["FeeTypeId"] = true;
                this.feeTypeId = value;
            }
        }

        /// <summary>
        /// Item identifier in the transaction.
        /// </summary>
        [JsonProperty("LineItemDescription")]
        public string LineItemDescription
        {
            get
            {
                return this.lineItemDescription;
            }

            set
            {
                this.shouldSerialize["LineItemDescription"] = true;
                this.lineItemDescription = value;
            }
        }

        /// <summary>
        /// This entity accepts the list of CardId to filter in the response.
        /// Note: The number of cardId allowed to be passed in the request is configurable to a maximum of 500 cards.
        /// </summary>
        [JsonProperty("Cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Cards { get; set; }

        /// <summary>
        /// Allowed Sorting Options
        /// 1.    TransactionDateAscending
        /// 2.    TransactionDateDescending
        /// 3.    GrossAmountDescending
        /// 4.    GrossAmountAscending
        /// 5.    NetAmountAscending
        /// 6.    NetAmountDescensding
        /// </summary>
        [JsonProperty("SortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricedTransactionReqV2SortOrderEnum? SortOrder { get; set; }

        /// <summary>
        /// From transaction delivery date
        /// </summary>
        [JsonProperty("FromDate")]
        public string FromDate
        {
            get
            {
                return this.fromDate;
            }

            set
            {
                this.shouldSerialize["FromDate"] = true;
                this.fromDate = value;
            }
        }

        /// <summary>
        /// To transaction delivery date
        /// </summary>
        [JsonProperty("ToDate")]
        public string ToDate
        {
            get
            {
                return this.toDate;
            }

            set
            {
                this.shouldSerialize["ToDate"] = true;
                this.toDate = value;
            }
        }

        /// <summary>
        /// Pass below one of the value as per the required transaction period
        /// 1. Last 7 Days
        /// 2. Last 30 Days
        /// 3. Last 90 Days
        /// </summary>
        [JsonProperty("Period", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricedTransactionReqV2PeriodEnum? Period { get; set; }

        /// <summary>
        /// Transaction posting start date and time
        /// </summary>
        [JsonProperty("PostingDateFrom")]
        public string PostingDateFrom
        {
            get
            {
                return this.postingDateFrom;
            }

            set
            {
                this.shouldSerialize["PostingDateFrom"] = true;
                this.postingDateFrom = value;
            }
        }

        /// <summary>
        /// Transaction posting end date and time
        /// </summary>
        [JsonProperty("PostingDateTo")]
        public string PostingDateTo
        {
            get
            {
                return this.postingDateTo;
            }

            set
            {
                this.shouldSerialize["PostingDateTo"] = true;
                this.postingDateTo = value;
            }
        }

        /// <summary>
        /// Unique id of the transaction that may include one or more salesitems
        /// </summary>
        [JsonProperty("TransactionItemId")]
        public string TransactionItemId
        {
            get
            {
                return this.transactionItemId;
            }

            set
            {
                this.shouldSerialize["TransactionItemId"] = true;
                this.transactionItemId = value;
            }
        }

        /// <summary>
        /// Is FuelOnly indicator
        /// </summary>
        [JsonProperty("FuelOnly")]
        public bool? FuelOnly
        {
            get
            {
                return this.fuelOnly;
            }

            set
            {
                this.shouldSerialize["FuelOnly"] = true;
                this.fuelOnly = value;
            }
        }

        /// <summary>
        /// When passed as ‘true’ then all sales items along with fees will be included in the response and the follwoing filteres will be ignored
        /// * InvoiceNumber
        /// * InvoiceDate
        /// * PostingDateFrom
        /// * PostingDateTo
        /// </summary>
        [JsonProperty("IncludeFees")]
        public bool? IncludeFees
        {
            get
            {
                return this.includeFees;
            }

            set
            {
                this.shouldSerialize["IncludeFees"] = true;
                this.includeFees = value;
            }
        }

        /// <summary>
        /// If true then returns all the data linked tothe payer group of the provided PayerNumberin the request
        /// </summary>
        [JsonProperty("IsMultipayer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultipayer { get; set; }

        /// <summary>
        /// When passed as ‘True’ the transactions records with report date not equal to 9999-12-30 will be returned. When passed as ‘False’ the above condition will not be checked.
        /// </summary>
        [JsonProperty("ValidInvoiceDateOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidInvoiceDateOnly { get; set; }

        /// <summary>
        /// Invoice From Date, this is a search criterion to filter invoiced transactions with invoice date from this date.
        /// </summary>
        [JsonProperty("InvoiceFromDate")]
        public string InvoiceFromDate
        {
            get
            {
                return this.invoiceFromDate;
            }

            set
            {
                this.shouldSerialize["InvoiceFromDate"] = true;
                this.invoiceFromDate = value;
            }
        }

        /// <summary>
        /// Invoice To Date, this is a search criterion to filter invoiced transactions with invoice date until this date.
        /// </summary>
        [JsonProperty("InvoiceToDate")]
        public string InvoiceToDate
        {
            get
            {
                return this.invoiceToDate;
            }

            set
            {
                this.shouldSerialize["InvoiceToDate"] = true;
                this.invoiceToDate = value;
            }
        }

        /// <summary>
        /// Hosting Collecting Company Number of the selected payer.
        /// </summary>
        [JsonProperty("HostingCollectingCompanyNumber")]
        public string HostingCollectingCompanyNumber
        {
            get
            {
                return this.hostingCollectingCompanyNumber;
            }

            set
            {
                this.shouldSerialize["HostingCollectingCompanyNumber"] = true;
                this.hostingCollectingCompanyNumber = value;
            }
        }

        /// <summary>
        /// Search based on DriverName or VRN
        /// </summary>
        [JsonProperty("Search")]
        public string Search
        {
            get
            {
                return this.search;
            }

            set
            {
                this.shouldSerialize["Search"] = true;
                this.search = value;
            }
        }

        /// <summary>
        /// Unique id of the transaction that may include one or more salesitems
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId
        {
            get
            {
                return this.transactionId;
            }

            set
            {
                this.shouldSerialize["TransactionId"] = true;
                this.transactionId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricedRequestData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDriverName()
        {
            this.shouldSerialize["DriverName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupId()
        {
            this.shouldSerialize["CardGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardPAN()
        {
            this.shouldSerialize["CardPAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductCode()
        {
            this.shouldSerialize["ProductCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductName()
        {
            this.shouldSerialize["ProductName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteCode()
        {
            this.shouldSerialize["SiteCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncomingSiteNumber()
        {
            this.shouldSerialize["IncomingSiteNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceDate()
        {
            this.shouldSerialize["InvoiceDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceNumber()
        {
            this.shouldSerialize["InvoiceNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchasedInCountryCode()
        {
            this.shouldSerialize["PurchasedInCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchasedInCountry()
        {
            this.shouldSerialize["PurchasedInCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteGroupId()
        {
            this.shouldSerialize["SiteGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVehicleRegistrationNumber()
        {
            this.shouldSerialize["VehicleRegistrationNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeTypeId()
        {
            this.shouldSerialize["FeeTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLineItemDescription()
        {
            this.shouldSerialize["LineItemDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFromDate()
        {
            this.shouldSerialize["FromDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetToDate()
        {
            this.shouldSerialize["ToDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPostingDateFrom()
        {
            this.shouldSerialize["PostingDateFrom"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPostingDateTo()
        {
            this.shouldSerialize["PostingDateTo"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionItemId()
        {
            this.shouldSerialize["TransactionItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelOnly()
        {
            this.shouldSerialize["FuelOnly"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncludeFees()
        {
            this.shouldSerialize["IncludeFees"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceFromDate()
        {
            this.shouldSerialize["InvoiceFromDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceToDate()
        {
            this.shouldSerialize["InvoiceToDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHostingCollectingCompanyNumber()
        {
            this.shouldSerialize["HostingCollectingCompanyNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSearch()
        {
            this.shouldSerialize["Search"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionId()
        {
            this.shouldSerialize["TransactionId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["AccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDriverName()
        {
            return this.shouldSerialize["DriverName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupId()
        {
            return this.shouldSerialize["CardGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardPAN()
        {
            return this.shouldSerialize["CardPAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductCode()
        {
            return this.shouldSerialize["ProductCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductName()
        {
            return this.shouldSerialize["ProductName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteCode()
        {
            return this.shouldSerialize["SiteCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncomingSiteNumber()
        {
            return this.shouldSerialize["IncomingSiteNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceDate()
        {
            return this.shouldSerialize["InvoiceDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceNumber()
        {
            return this.shouldSerialize["InvoiceNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchasedInCountryCode()
        {
            return this.shouldSerialize["PurchasedInCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchasedInCountry()
        {
            return this.shouldSerialize["PurchasedInCountry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteGroupId()
        {
            return this.shouldSerialize["SiteGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVehicleRegistrationNumber()
        {
            return this.shouldSerialize["VehicleRegistrationNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeTypeId()
        {
            return this.shouldSerialize["FeeTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLineItemDescription()
        {
            return this.shouldSerialize["LineItemDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFromDate()
        {
            return this.shouldSerialize["FromDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeToDate()
        {
            return this.shouldSerialize["ToDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePostingDateFrom()
        {
            return this.shouldSerialize["PostingDateFrom"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePostingDateTo()
        {
            return this.shouldSerialize["PostingDateTo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionItemId()
        {
            return this.shouldSerialize["TransactionItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelOnly()
        {
            return this.shouldSerialize["FuelOnly"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludeFees()
        {
            return this.shouldSerialize["IncludeFees"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceFromDate()
        {
            return this.shouldSerialize["InvoiceFromDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceToDate()
        {
            return this.shouldSerialize["InvoiceToDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHostingCollectingCompanyNumber()
        {
            return this.shouldSerialize["HostingCollectingCompanyNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSearch()
        {
            return this.shouldSerialize["Search"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionId()
        {
            return this.shouldSerialize["TransactionId"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is PricedRequestData other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.SiteCode == null && other.SiteCode == null) || (this.SiteCode?.Equals(other.SiteCode) == true)) &&
                ((this.IncomingSiteNumber == null && other.IncomingSiteNumber == null) || (this.IncomingSiteNumber?.Equals(other.IncomingSiteNumber) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.PurchasedInCountryCode == null && other.PurchasedInCountryCode == null) || (this.PurchasedInCountryCode?.Equals(other.PurchasedInCountryCode) == true)) &&
                ((this.PurchasedInCountry == null && other.PurchasedInCountry == null) || (this.PurchasedInCountry?.Equals(other.PurchasedInCountry) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.VehicleRegistrationNumber == null && other.VehicleRegistrationNumber == null) || (this.VehicleRegistrationNumber?.Equals(other.VehicleRegistrationNumber) == true)) &&
                ((this.FeeTypeId == null && other.FeeTypeId == null) || (this.FeeTypeId?.Equals(other.FeeTypeId) == true)) &&
                ((this.LineItemDescription == null && other.LineItemDescription == null) || (this.LineItemDescription?.Equals(other.LineItemDescription) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                ((this.SortOrder == null && other.SortOrder == null) || (this.SortOrder?.Equals(other.SortOrder) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.PostingDateFrom == null && other.PostingDateFrom == null) || (this.PostingDateFrom?.Equals(other.PostingDateFrom) == true)) &&
                ((this.PostingDateTo == null && other.PostingDateTo == null) || (this.PostingDateTo?.Equals(other.PostingDateTo) == true)) &&
                ((this.TransactionItemId == null && other.TransactionItemId == null) || (this.TransactionItemId?.Equals(other.TransactionItemId) == true)) &&
                ((this.FuelOnly == null && other.FuelOnly == null) || (this.FuelOnly?.Equals(other.FuelOnly) == true)) &&
                ((this.IncludeFees == null && other.IncludeFees == null) || (this.IncludeFees?.Equals(other.IncludeFees) == true)) &&
                ((this.IsMultipayer == null && other.IsMultipayer == null) || (this.IsMultipayer?.Equals(other.IsMultipayer) == true)) &&
                ((this.ValidInvoiceDateOnly == null && other.ValidInvoiceDateOnly == null) || (this.ValidInvoiceDateOnly?.Equals(other.ValidInvoiceDateOnly) == true)) &&
                ((this.InvoiceFromDate == null && other.InvoiceFromDate == null) || (this.InvoiceFromDate?.Equals(other.InvoiceFromDate) == true)) &&
                ((this.InvoiceToDate == null && other.InvoiceToDate == null) || (this.InvoiceToDate?.Equals(other.InvoiceToDate) == true)) &&
                ((this.HostingCollectingCompanyNumber == null && other.HostingCollectingCompanyNumber == null) || (this.HostingCollectingCompanyNumber?.Equals(other.HostingCollectingCompanyNumber) == true)) &&
                ((this.Search == null && other.Search == null) || (this.Search?.Equals(other.Search) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode)}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.SiteCode = {(this.SiteCode == null ? "null" : this.SiteCode)}");
            toStringOutput.Add($"this.IncomingSiteNumber = {(this.IncomingSiteNumber == null ? "null" : this.IncomingSiteNumber)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.PurchasedInCountryCode = {(this.PurchasedInCountryCode == null ? "null" : this.PurchasedInCountryCode)}");
            toStringOutput.Add($"this.PurchasedInCountry = {(this.PurchasedInCountry == null ? "null" : this.PurchasedInCountry)}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.VehicleRegistrationNumber = {(this.VehicleRegistrationNumber == null ? "null" : this.VehicleRegistrationNumber)}");
            toStringOutput.Add($"this.FeeTypeId = {(this.FeeTypeId == null ? "null" : this.FeeTypeId.ToString())}");
            toStringOutput.Add($"this.LineItemDescription = {(this.LineItemDescription == null ? "null" : this.LineItemDescription)}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.SortOrder = {(this.SortOrder == null ? "null" : this.SortOrder.ToString())}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.PostingDateFrom = {(this.PostingDateFrom == null ? "null" : this.PostingDateFrom)}");
            toStringOutput.Add($"this.PostingDateTo = {(this.PostingDateTo == null ? "null" : this.PostingDateTo)}");
            toStringOutput.Add($"this.TransactionItemId = {(this.TransactionItemId == null ? "null" : this.TransactionItemId)}");
            toStringOutput.Add($"this.FuelOnly = {(this.FuelOnly == null ? "null" : this.FuelOnly.ToString())}");
            toStringOutput.Add($"this.IncludeFees = {(this.IncludeFees == null ? "null" : this.IncludeFees.ToString())}");
            toStringOutput.Add($"this.IsMultipayer = {(this.IsMultipayer == null ? "null" : this.IsMultipayer.ToString())}");
            toStringOutput.Add($"this.ValidInvoiceDateOnly = {(this.ValidInvoiceDateOnly == null ? "null" : this.ValidInvoiceDateOnly.ToString())}");
            toStringOutput.Add($"this.InvoiceFromDate = {(this.InvoiceFromDate == null ? "null" : this.InvoiceFromDate)}");
            toStringOutput.Add($"this.InvoiceToDate = {(this.InvoiceToDate == null ? "null" : this.InvoiceToDate)}");
            toStringOutput.Add($"this.HostingCollectingCompanyNumber = {(this.HostingCollectingCompanyNumber == null ? "null" : this.HostingCollectingCompanyNumber)}");
            toStringOutput.Add($"this.Search = {(this.Search == null ? "null" : this.Search)}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId)}");
        }
    }
}