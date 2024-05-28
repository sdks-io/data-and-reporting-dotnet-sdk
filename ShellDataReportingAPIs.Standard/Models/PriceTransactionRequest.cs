// <copyright file="PriceTransactionRequest.cs" company="APIMatic">
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
    /// PriceTransactionRequest.
    /// </summary>
    public class PriceTransactionRequest
    {
        private int? colCoId;
        private int? colCoCode;
        private int? payerId;
        private string payerNumber;
        private int? cardId;
        private string cardPAN;
        private string driverName;
        private string vehicleRegistrationNumber;
        private string invoiceStatus;
        private int? productId;
        private string productCode;
        private string purchasedInCountry;
        private int? cardGroupId;
        private string sortOrder;
        private string fromDate;
        private string toDate;
        private int? period;
        private string siteCode;
        private int? siteGroupId;
        private string postingDateFrom;
        private string postingDateTo;
        private string salesItemId;
        private string transactionId;
        private string invoiceDate;
        private string invoiceNumber;
        private bool? validInvoiceDateOnly;
        private string invoiceFromDate;
        private string invoiceToDate;
        private bool? fuelOnly;
        private bool? includeFees;
        private bool? useFieldId;
        private int? currentPage;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "ColCoCode", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "CardId", false },
            { "CardPAN", false },
            { "DriverName", false },
            { "VehicleRegistrationNumber", false },
            { "InvoiceStatus", false },
            { "ProductId", false },
            { "ProductCode", false },
            { "PurchasedInCountry", false },
            { "CardGroupId", false },
            { "SortOrder", false },
            { "FromDate", false },
            { "ToDate", false },
            { "Period", false },
            { "SiteCode", false },
            { "SiteGroupId", false },
            { "PostingDateFrom", false },
            { "PostingDateTo", false },
            { "SalesItemId", false },
            { "TransactionId", false },
            { "InvoiceDate", false },
            { "InvoiceNumber", false },
            { "ValidInvoiceDateOnly", false },
            { "InvoiceFromDate", false },
            { "InvoiceToDate", false },
            { "FuelOnly", false },
            { "IncludeFees", false },
            { "UseFieldId", false },
            { "CurrentPage", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTransactionRequest"/> class.
        /// </summary>
        public PriceTransactionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTransactionRequest"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="vehicleRegistrationNumber">VehicleRegistrationNumber.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="productId">ProductId.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="purchasedInCountry">PurchasedInCountry.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="sortOrder">SortOrder.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="period">Period.</param>
        /// <param name="siteCode">SiteCode.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="postingDateFrom">PostingDateFrom.</param>
        /// <param name="postingDateTo">PostingDateTo.</param>
        /// <param name="salesItemId">SalesItemId.</param>
        /// <param name="transactionId">TransactionId.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="validInvoiceDateOnly">ValidInvoiceDateOnly.</param>
        /// <param name="invoiceFromDate">InvoiceFromDate.</param>
        /// <param name="invoiceToDate">InvoiceToDate.</param>
        /// <param name="fuelOnly">FuelOnly.</param>
        /// <param name="includeFees">IncludeFees.</param>
        /// <param name="useFieldId">UseFieldId.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="pageSize">PageSize.</param>
        public PriceTransactionRequest(
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            Models.Accounts accounts = null,
            int? cardId = null,
            string cardPAN = null,
            string driverName = null,
            string vehicleRegistrationNumber = null,
            string invoiceStatus = null,
            int? productId = null,
            string productCode = null,
            string purchasedInCountry = null,
            int? cardGroupId = null,
            string sortOrder = null,
            string fromDate = null,
            string toDate = null,
            int? period = null,
            string siteCode = null,
            int? siteGroupId = null,
            string postingDateFrom = null,
            string postingDateTo = null,
            string salesItemId = null,
            string transactionId = null,
            string invoiceDate = null,
            string invoiceNumber = null,
            bool? validInvoiceDateOnly = null,
            string invoiceFromDate = null,
            string invoiceToDate = null,
            bool? fuelOnly = null,
            bool? includeFees = null,
            bool? useFieldId = null,
            int? currentPage = null,
            int? pageSize = null)
        {
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            this.Accounts = accounts;
            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (vehicleRegistrationNumber != null)
            {
                this.VehicleRegistrationNumber = vehicleRegistrationNumber;
            }

            if (invoiceStatus != null)
            {
                this.InvoiceStatus = invoiceStatus;
            }

            if (productId != null)
            {
                this.ProductId = productId;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (purchasedInCountry != null)
            {
                this.PurchasedInCountry = purchasedInCountry;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (sortOrder != null)
            {
                this.SortOrder = sortOrder;
            }

            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            if (period != null)
            {
                this.Period = period;
            }

            if (siteCode != null)
            {
                this.SiteCode = siteCode;
            }

            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (postingDateFrom != null)
            {
                this.PostingDateFrom = postingDateFrom;
            }

            if (postingDateTo != null)
            {
                this.PostingDateTo = postingDateTo;
            }

            if (salesItemId != null)
            {
                this.SalesItemId = salesItemId;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (validInvoiceDateOnly != null)
            {
                this.ValidInvoiceDateOnly = validInvoiceDateOnly;
            }

            if (invoiceFromDate != null)
            {
                this.InvoiceFromDate = invoiceFromDate;
            }

            if (invoiceToDate != null)
            {
                this.InvoiceToDate = invoiceToDate;
            }

            if (fuelOnly != null)
            {
                this.FuelOnly = fuelOnly;
            }

            if (includeFees != null)
            {
                this.IncludeFees = includeFees;
            }

            if (useFieldId != null)
            {
                this.UseFieldId = useFieldId;
            }

            if (currentPage != null)
            {
                this.CurrentPage = currentPage;
            }

            this.PageSize = pageSize;
        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoId")]
        public int? ColCoId
        {
            get
            {
                return this.colCoId;
            }

            set
            {
                this.shouldSerialize["ColCoId"] = true;
                this.colCoId = value;
            }
        }

        /// <summary>
        /// Collecting Company Code  of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// Payer Id  of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <summary>
        /// Payer Number (Ex: GB000000123) of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Accounts Accounts { get; set; }

        /// <summary>
        /// Card Id (i.e. Unique Card Id in GFN)
        /// Optional
        /// When both Card Id and Card PAN are not present on request, the response will have transactions of all cards under the selected payer or account
        /// </summary>
        [JsonProperty("CardId")]
        public int? CardId
        {
            get
            {
                return this.cardId;
            }

            set
            {
                this.shouldSerialize["CardId"] = true;
                this.cardId = value;
            }
        }

        /// <summary>
        /// Full Card PAN
        /// Optional
        /// When both Card Id and Card PAN are not present on request, the response will have transactions of all cards under the selected payer or account.
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
        /// Driver Name (of Card record)
        /// Optional
        /// Minimum of 4 characters should be provided else not considered
        /// Transactions of the card having the entered value at any part of the Driver Name will be returned
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
        /// Vehicle Registration (of Card record)
        /// Optional
        /// Minimum of 4 characters should be provided else not considered
        /// Transactions of the card having the entered value at any part of the VRN will be returned
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
        /// Invoice status of the transactions.
        /// Mandatory
        /// Possible options:
        /// I - Invoiced
        /// U – Un-Invoiced
        /// A – All
        /// </summary>
        [JsonProperty("InvoiceStatus")]
        public string InvoiceStatus
        {
            get
            {
                return this.invoiceStatus;
            }

            set
            {
                this.shouldSerialize["InvoiceStatus"] = true;
                this.invoiceStatus = value;
            }
        }

        /// <summary>
        /// Product Id
        /// Example:
        /// 21	Unleaded - High octane
        /// 22	Unleaded - Medium octane
        /// 23	Unleaded - Low octane
        /// 24	Unleaded Environmental
        /// </summary>
        [JsonProperty("ProductId")]
        public int? ProductId
        {
            get
            {
                return this.productId;
            }

            set
            {
                this.shouldSerialize["ProductId"] = true;
                this.productId = value;
            }
        }

        /// <summary>
        /// Product Code – Global as per GFN configuration
        /// Optional
        /// Max Length: 8
        /// Example:
        /// 10	TMF Charges
        /// 11	Tunnel/Bridges
        /// 12	Motorway toll
        /// 13	Ferries
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
        /// ISO Country Code (ex: UK, FR)
        /// Note: If IncludeFees is true then this filter will be ignored
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
        /// Allowed Sorting Options:
        /// 1.	TransactionDateAscending
        /// 2.	TransactionDateDescending
        /// 3.	GrossAmountDescending
        /// 4.	GrossAmountAscending
        /// 5.	DriverNameAscending (If Driver Name is null then VRN value will be considered)
        /// 6.	DriverNameDescending (If Driver Name is null then VRN value will be considered)
        /// 7.	VRNAscending (If VRN is null then Driver Name value will be considered)
        /// 8.	VRNDescending (If VRN is null then Driver Name value will be considered)
        /// 9.	NetAmountAscending
        /// 10.	NetAmountDescensding
        /// Example value to be passed: “1,3”
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder
        {
            get
            {
                return this.sortOrder;
            }

            set
            {
                this.shouldSerialize["SortOrder"] = true;
                this.sortOrder = value;
            }
        }

        /// <summary>
        /// Transactions from Date/Time.
        /// Optional – When provided, it should be with in last 24 months.
        /// Format: yyyyMMdd
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
        /// Transactions to Date/Time.
        /// Optional- Refer introduction section of this operation for the priority and sequence of different date and invoice number filters that are conditionally applied.
        /// Note:
        /// 1) When the value is blank and FromDate is provided on the input, all transactions took place 210(Configurable) days after the given FromDate is returned.
        /// 2) Difference between FromDate and ToDate cannot be more than 210 (Configurable) days.
        /// Format: yyyyMMdd
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
        /// Transactions Period.
        /// Possible values are:
        /// 1.	Last 7 Days
        /// 2.	Last 30 Days
        /// 3.	Last 90 Days
        /// Optional - Refer introduction section of this operation for the priority and sequence of different date and invoice number filters that are conditionally applied.
        /// </summary>
        [JsonProperty("Period")]
        public int? Period
        {
            get
            {
                return this.period;
            }

            set
            {
                this.shouldSerialize["Period"] = true;
                this.period = value;
            }
        }

        /// <summary>
        /// Site Code as configured in GFN
        /// Example:
        /// 050001 -	CHARNOCK RICHARD NTHBOUND MWSA 0755
        /// 050002 -	CHARNOCK RICHARD STHBOUND MWSA 0755
        /// 050005 -	HARTSHEAD MOOR EASTBOUND MWSA 0761.
        /// 050006 -	HARTSHEAD MOOR WESTBOUND MWSA.
        /// Note: If IncludeFees is true then this filter will be ignored
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
        /// Site Group Id in GFN
        /// Optional
        /// Example: 202
        /// Note: If IncludeFees is true then this filter will be ignored
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
        /// Transaction Posting Date/time in the Cards Platform - From Date/time.
        /// Note:
        /// 1) When the value of both PostingDateFrom and PostingDateTo are present in the request then the value of PostingDateFrom must be less than PostingDateTo.
        /// 2) If IncludeFees is true then this filter will be ignored
        /// Format: yyyyMMdd HH:mm:ss
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
        /// Transaction Posting Date/time in the Cards Platform – To Date/time.
        /// Note:
        /// 1) If IncludeFees is true then this filter will be ignored.
        /// 2) When the value of both PostingDateFrom and PostingDateTo are present in the request then the value of PostingDateFrom must be less than PostingDateTo.
        /// Format: yyyyMMdd HH:mm:ss
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
        /// Unique SalesItemId (Either Billed on Unbilled)
        /// Optional
        /// Note: If IncludeFees is true then this filter will be ignored
        /// </summary>
        [JsonProperty("SalesItemId")]
        public string SalesItemId
        {
            get
            {
                return this.salesItemId;
            }

            set
            {
                this.shouldSerialize["SalesItemId"] = true;
                this.salesItemId = value;
            }
        }

        /// <summary>
        /// Unique Transaction Id
        /// Optional
        /// Note: If IncludeFees is true then this filter will be ignored
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

        /// <summary>
        /// Invoice Date.
        /// Optional
        /// Note:
        /// 1) If value is not blank then the system will ignore the InvoiceStatus parameter and it will return all the billed transactions for the given invoice date.
        /// Format: yyyyMMdd
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
        /// Invoice Number.
        /// Optional
        /// Note:
        /// 1) If value is not blank then the system will ignore the InvoiceStatus parameter and it will return all the billed transactions for the given invoice date.
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
        /// True/False
        /// Optional
        /// Default value: True.
        /// When passed as ‘True’ the transactions records with report date not equal to 9999-12-30 will be returned.
        /// When passed as ‘False’ the above condition will not be checked.
        /// </summary>
        [JsonProperty("ValidInvoiceDateOnly")]
        public bool? ValidInvoiceDateOnly
        {
            get
            {
                return this.validInvoiceDateOnly;
            }

            set
            {
                this.shouldSerialize["ValidInvoiceDateOnly"] = true;
                this.validInvoiceDateOnly = value;
            }
        }

        /// <summary>
        /// Start date for transaction search by invoice date.
        /// Optional
        /// Note:
        /// 1) Value should be with in last 24 months (if provided).
        /// 2) Maximum of 90(Configurable) day’s duration allowed per search.
        /// 3) When provided, InvoiceFromDate has to be less than or equal to InvoiceToDate.
        /// Format: yyyyMMdd
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
        /// End date for transaction search by invoice date.
        /// Optional
        /// Note:
        /// 1) When InvoiceFromDate is provided and InvoiceToDate is null, then InvoiceToDate will be calculated as (InvoiceFromDate + 90 days) or (CurrentDate) whichever is lesser.
        /// Format: yyyyMMdd
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
        /// True/False
        /// Optional
        /// Default value: False.
        /// When passed as ‘True’ Only returned records with Fuel transactions.
        /// When passed as ‘False’ the above condition will not be checked.
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
        /// True/False
        /// Optional
        /// Default value: False
        /// When passed as ‘True’ then  ignore few filters, all sales items along with fees included on the same response
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
        /// True/False
        /// Optional
        /// Default value – False.
        /// When set to True, the property names in the output will be replaced by Field IDs.
        /// This will reduce the output payload size significantly for large data sets and help faster transmission of data over networks.
        /// </summary>
        [JsonProperty("UseFieldId")]
        public bool? UseFieldId
        {
            get
            {
                return this.useFieldId;
            }

            set
            {
                this.shouldSerialize["UseFieldId"] = true;
                this.useFieldId = value;
            }
        }

        /// <summary>
        /// Current Page Number
        /// </summary>
        [JsonProperty("CurrentPage")]
        public int? CurrentPage
        {
            get
            {
                return this.currentPage;
            }

            set
            {
                this.shouldSerialize["CurrentPage"] = true;
                this.currentPage = value;
            }
        }

        /// <summary>
        /// Page Size – Number of records to show on a page
        /// Optional
        /// Default value 50
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PriceTransactionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
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
        public void UnsetDriverName()
        {
            this.shouldSerialize["DriverName"] = false;
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
        public void UnsetInvoiceStatus()
        {
            this.shouldSerialize["InvoiceStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductId()
        {
            this.shouldSerialize["ProductId"] = false;
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
        public void UnsetPurchasedInCountry()
        {
            this.shouldSerialize["PurchasedInCountry"] = false;
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
        public void UnsetSortOrder()
        {
            this.shouldSerialize["SortOrder"] = false;
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
        public void UnsetPeriod()
        {
            this.shouldSerialize["Period"] = false;
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
        public void UnsetSiteGroupId()
        {
            this.shouldSerialize["SiteGroupId"] = false;
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
        public void UnsetSalesItemId()
        {
            this.shouldSerialize["SalesItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionId()
        {
            this.shouldSerialize["TransactionId"] = false;
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
        public void UnsetValidInvoiceDateOnly()
        {
            this.shouldSerialize["ValidInvoiceDateOnly"] = false;
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
        public void UnsetUseFieldId()
        {
            this.shouldSerialize["UseFieldId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrentPage()
        {
            this.shouldSerialize["CurrentPage"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
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
        public bool ShouldSerializeDriverName()
        {
            return this.shouldSerialize["DriverName"];
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
        public bool ShouldSerializeInvoiceStatus()
        {
            return this.shouldSerialize["InvoiceStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductId()
        {
            return this.shouldSerialize["ProductId"];
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
        public bool ShouldSerializePurchasedInCountry()
        {
            return this.shouldSerialize["PurchasedInCountry"];
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
        public bool ShouldSerializeSortOrder()
        {
            return this.shouldSerialize["SortOrder"];
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
        public bool ShouldSerializePeriod()
        {
            return this.shouldSerialize["Period"];
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
        public bool ShouldSerializeSiteGroupId()
        {
            return this.shouldSerialize["SiteGroupId"];
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
        public bool ShouldSerializeSalesItemId()
        {
            return this.shouldSerialize["SalesItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionId()
        {
            return this.shouldSerialize["TransactionId"];
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
        public bool ShouldSerializeValidInvoiceDateOnly()
        {
            return this.shouldSerialize["ValidInvoiceDateOnly"];
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
        public bool ShouldSerializeUseFieldId()
        {
            return this.shouldSerialize["UseFieldId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrentPage()
        {
            return this.shouldSerialize["CurrentPage"];
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
            return obj is PriceTransactionRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.VehicleRegistrationNumber == null && other.VehicleRegistrationNumber == null) || (this.VehicleRegistrationNumber?.Equals(other.VehicleRegistrationNumber) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.PurchasedInCountry == null && other.PurchasedInCountry == null) || (this.PurchasedInCountry?.Equals(other.PurchasedInCountry) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.SortOrder == null && other.SortOrder == null) || (this.SortOrder?.Equals(other.SortOrder) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.SiteCode == null && other.SiteCode == null) || (this.SiteCode?.Equals(other.SiteCode) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.PostingDateFrom == null && other.PostingDateFrom == null) || (this.PostingDateFrom?.Equals(other.PostingDateFrom) == true)) &&
                ((this.PostingDateTo == null && other.PostingDateTo == null) || (this.PostingDateTo?.Equals(other.PostingDateTo) == true)) &&
                ((this.SalesItemId == null && other.SalesItemId == null) || (this.SalesItemId?.Equals(other.SalesItemId) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.ValidInvoiceDateOnly == null && other.ValidInvoiceDateOnly == null) || (this.ValidInvoiceDateOnly?.Equals(other.ValidInvoiceDateOnly) == true)) &&
                ((this.InvoiceFromDate == null && other.InvoiceFromDate == null) || (this.InvoiceFromDate?.Equals(other.InvoiceFromDate) == true)) &&
                ((this.InvoiceToDate == null && other.InvoiceToDate == null) || (this.InvoiceToDate?.Equals(other.InvoiceToDate) == true)) &&
                ((this.FuelOnly == null && other.FuelOnly == null) || (this.FuelOnly?.Equals(other.FuelOnly) == true)) &&
                ((this.IncludeFees == null && other.IncludeFees == null) || (this.IncludeFees?.Equals(other.IncludeFees) == true)) &&
                ((this.UseFieldId == null && other.UseFieldId == null) || (this.UseFieldId?.Equals(other.UseFieldId) == true)) &&
                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : this.Accounts.ToString())}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.VehicleRegistrationNumber = {(this.VehicleRegistrationNumber == null ? "null" : this.VehicleRegistrationNumber)}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.PurchasedInCountry = {(this.PurchasedInCountry == null ? "null" : this.PurchasedInCountry)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.SortOrder = {(this.SortOrder == null ? "null" : this.SortOrder)}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.SiteCode = {(this.SiteCode == null ? "null" : this.SiteCode)}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.PostingDateFrom = {(this.PostingDateFrom == null ? "null" : this.PostingDateFrom)}");
            toStringOutput.Add($"this.PostingDateTo = {(this.PostingDateTo == null ? "null" : this.PostingDateTo)}");
            toStringOutput.Add($"this.SalesItemId = {(this.SalesItemId == null ? "null" : this.SalesItemId)}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.ValidInvoiceDateOnly = {(this.ValidInvoiceDateOnly == null ? "null" : this.ValidInvoiceDateOnly.ToString())}");
            toStringOutput.Add($"this.InvoiceFromDate = {(this.InvoiceFromDate == null ? "null" : this.InvoiceFromDate)}");
            toStringOutput.Add($"this.InvoiceToDate = {(this.InvoiceToDate == null ? "null" : this.InvoiceToDate)}");
            toStringOutput.Add($"this.FuelOnly = {(this.FuelOnly == null ? "null" : this.FuelOnly.ToString())}");
            toStringOutput.Add($"this.IncludeFees = {(this.IncludeFees == null ? "null" : this.IncludeFees.ToString())}");
            toStringOutput.Add($"this.UseFieldId = {(this.UseFieldId == null ? "null" : this.UseFieldId.ToString())}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
        }
    }
}