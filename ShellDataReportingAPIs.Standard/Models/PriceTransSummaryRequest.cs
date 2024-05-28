// <copyright file="PriceTransSummaryRequest.cs" company="APIMatic">
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
    /// PriceTransSummaryRequest.
    /// </summary>
    public class PriceTransSummaryRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTransSummaryRequest"/> class.
        /// </summary>
        public PriceTransSummaryRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceTransSummaryRequest"/> class.
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
        public PriceTransSummaryRequest(
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
            bool? includeFees = null)
        {
            this.ColCoId = colCoId;
            this.ColCoCode = colCoCode;
            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.Accounts = accounts;
            this.CardId = cardId;
            this.CardPAN = cardPAN;
            this.DriverName = driverName;
            this.VehicleRegistrationNumber = vehicleRegistrationNumber;
            this.InvoiceStatus = invoiceStatus;
            this.ProductId = productId;
            this.ProductCode = productCode;
            this.PurchasedInCountry = purchasedInCountry;
            this.CardGroupId = cardGroupId;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.Period = period;
            this.SiteCode = siteCode;
            this.SiteGroupId = siteGroupId;
            this.PostingDateFrom = postingDateFrom;
            this.PostingDateTo = postingDateTo;
            this.SalesItemId = salesItemId;
            this.TransactionId = transactionId;
            this.InvoiceDate = invoiceDate;
            this.InvoiceNumber = invoiceNumber;
            this.ValidInvoiceDateOnly = validInvoiceDateOnly;
            this.InvoiceFromDate = invoiceFromDate;
            this.InvoiceToDate = invoiceToDate;
            this.FuelOnly = fuelOnly;
            this.IncludeFees = includeFees;
        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Collecting Company Code  of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Payer Id  of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Payer Number (Ex: GB000000123) of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

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
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// Full Card PAN
        /// Optional
        /// When both Card Id and Card PAN are not present on request, the response will have transactions of all cards under the selected payer or account.
        /// </summary>
        [JsonProperty("CardPAN", NullValueHandling = NullValueHandling.Ignore)]
        public string CardPAN { get; set; }

        /// <summary>
        /// Driver Name (of Card record)
        /// Optional
        /// Minimum of 4 characters should be provided else not considered
        /// Transactions of the card having the entered value at any part of the Driver Name will be returned
        /// </summary>
        [JsonProperty("DriverName", NullValueHandling = NullValueHandling.Ignore)]
        public string DriverName { get; set; }

        /// <summary>
        /// Vehicle Registration (of Card record)
        /// Optional
        /// Minimum of 4 characters should be provided else not considered
        /// Transactions of the card having the entered value at any part of the VRN will be returned
        /// </summary>
        [JsonProperty("VehicleRegistrationNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string VehicleRegistrationNumber { get; set; }

        /// <summary>
        /// Invoice status of the transactions.
        /// Mandatory
        /// Possible options:
        /// I - Invoiced
        /// U – Un-Invoiced
        /// A – All
        /// </summary>
        [JsonProperty("InvoiceStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// Product Id
        /// Example:
        /// 21	Unleaded - High octane
        /// 22	Unleaded - Medium octane
        /// 23	Unleaded - Low octane
        /// 24	Unleaded Environmental
        /// </summary>
        [JsonProperty("ProductId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

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
        [JsonProperty("ProductCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductCode { get; set; }

        /// <summary>
        /// ISO Country Code (ex: UK, FR)
        /// Note: If IncludeFees is true then this filter will be ignored
        /// </summary>
        [JsonProperty("PurchasedInCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchasedInCountry { get; set; }

        /// <summary>
        /// Card Group Id in GFN
        /// </summary>
        [JsonProperty("CardGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardGroupId { get; set; }

        /// <summary>
        /// Transactions from Date/Time.
        /// Optional – When provided, it should be with in last 24 months.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("FromDate", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        /// <summary>
        /// Transactions to Date/Time.
        /// Optional- Refer introduction section of this operation for the priority and sequence of different date and invoice number filters that are conditionally applied.
        /// Note:
        /// 1) When the value is blank and FromDate is provided on the input, all transactions took place 210(Configurable) days after the given FromDate is returned.
        /// 2) Difference between FromDate and ToDate cannot be more than 210 (Configurable) days.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("ToDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDate { get; set; }

        /// <summary>
        /// Transactions Period.
        /// Possible values are:
        /// 1.	Last 7 Days
        /// 2.	Last 30 Days
        /// 3.	Last 90 Days
        /// Optional - Refer introduction section of this operation for the priority and sequence of different date and invoice number filters that are conditionally applied.
        /// </summary>
        [JsonProperty("Period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// Site Code as configured in GFN
        /// Example:
        /// 050001 -	CHARNOCK RICHARD NTHBOUND MWSA 0755
        /// 050002 -	CHARNOCK RICHARD STHBOUND MWSA 0755
        /// 050005 -	HARTSHEAD MOOR EASTBOUND MWSA 0761.
        /// 050006 -	HARTSHEAD MOOR WESTBOUND MWSA.
        /// Note: If IncludeFees is true then this filter will be ignored
        /// </summary>
        [JsonProperty("SiteCode", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCode { get; set; }

        /// <summary>
        /// Site Group Id in GFN
        /// Optional
        /// Example: 202
        /// Note: If IncludeFees is true then this filter will be ignored
        /// </summary>
        [JsonProperty("SiteGroupId", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteGroupId { get; set; }

        /// <summary>
        /// Transaction Posting Date/time in the Cards Platform - From Date/time.
        /// Note:
        /// 1) When the value of both PostingDateFrom and PostingDateTo are present in the request then the value of PostingDateFrom must be less than PostingDateTo.
        /// 2) If IncludeFees is true then this filter will be ignored
        /// Format: yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonProperty("PostingDateFrom", NullValueHandling = NullValueHandling.Ignore)]
        public string PostingDateFrom { get; set; }

        /// <summary>
        /// Transaction Posting Date/time in the Cards Platform – To Date/time.
        /// Note:
        /// 1) If IncludeFees is true then this filter will be ignored.
        /// 2) When the value of both PostingDateFrom and PostingDateTo are present in the request then the value of PostingDateFrom must be less than PostingDateTo.
        /// Format: yyyyMMdd HH:mm:ss
        /// </summary>
        [JsonProperty("PostingDateTo", NullValueHandling = NullValueHandling.Ignore)]
        public string PostingDateTo { get; set; }

        /// <summary>
        /// Unique SalesItemId (Either Billed on Unbilled)
        /// Optional
        /// Note: If IncludeFees is true then this filter will be ignored
        /// </summary>
        [JsonProperty("SalesItemId", NullValueHandling = NullValueHandling.Ignore)]
        public string SalesItemId { get; set; }

        /// <summary>
        /// Unique Transaction Id
        /// Optional
        /// Note: If IncludeFees is true then this filter will be ignored
        /// </summary>
        [JsonProperty("TransactionId", NullValueHandling = NullValueHandling.Ignore)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Invoice Date.
        /// Optional
        /// Note:
        /// 1) If value is not blank then the system will ignore the InvoiceStatus parameter and it will return all the billed transactions for the given invoice date.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("InvoiceDate", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Invoice Number.
        /// Optional
        /// Note:
        /// 1) If value is not blank then the system will ignore the InvoiceStatus parameter and it will return all the billed transactions for the given invoice date.
        /// </summary>
        [JsonProperty("InvoiceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// True/False
        /// Optional
        /// Default value: True.
        /// When passed as ‘True’ the transactions records with report date not equal to 9999-12-30 will be returned.
        /// When passed as ‘False’ the above condition will not be checked.
        /// </summary>
        [JsonProperty("ValidInvoiceDateOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidInvoiceDateOnly { get; set; }

        /// <summary>
        /// Start date for transaction search by invoice date.
        /// Optional
        /// Note:
        /// 1) Value should be with in last 24 months (if provided).
        /// 2) Maximum of 90(Configurable) day’s duration allowed per search.
        /// 3) When provided, InvoiceFromDate has to be less than or equal to InvoiceToDate.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("InvoiceFromDate", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceFromDate { get; set; }

        /// <summary>
        /// End date for transaction search by invoice date.
        /// Optional
        /// Note:
        /// 1) When InvoiceFromDate is provided and InvoiceToDate is null, then InvoiceToDate will be calculated as (InvoiceFromDate + 90 days) or (CurrentDate) whichever is lesser.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("InvoiceToDate", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceToDate { get; set; }

        /// <summary>
        /// True/False
        /// Optional
        /// Default value: False.
        /// When passed as ‘True’ Only returned records with Fuel transactions.
        /// When passed as ‘False’ the above condition will not be checked.
        /// </summary>
        [JsonProperty("FuelOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FuelOnly { get; set; }

        /// <summary>
        /// True/False
        /// Optional
        /// Default value: False
        /// When passed as ‘True’ then  ignore few filters, all sales items along with fees included on the same response
        /// </summary>
        [JsonProperty("IncludeFees", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeFees { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PriceTransSummaryRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is PriceTransSummaryRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
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
                ((this.IncludeFees == null && other.IncludeFees == null) || (this.IncludeFees?.Equals(other.IncludeFees) == true));
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
        }
    }
}