// <copyright file="MultiPricedTransactionRequest.cs" company="APIMatic">
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
    /// MultiPricedTransactionRequest.
    /// </summary>
    public class MultiPricedTransactionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPricedTransactionRequest"/> class.
        /// </summary>
        public MultiPricedTransactionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPricedTransactionRequest"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="purchasedInCountry">PurchasedInCountry.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="period">Period.</param>
        /// <param name="postingDateFrom">PostingDateFrom.</param>
        /// <param name="postingDateTo">PostingDateTo.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="validInvoiceDateOnly">ValidInvoiceDateOnly.</param>
        /// <param name="invoiceFromDate">InvoiceFromDate.</param>
        /// <param name="invoiceToDate">InvoiceToDate.</param>
        /// <param name="fuelOnly">FuelOnly.</param>
        /// <param name="includeFees">IncludeFees.</param>
        /// <param name="sortOrder">SortOrder.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="pageSize">PageSize.</param>
        public MultiPricedTransactionRequest(
            int colCoCode,
            List<Models.MultiPricedTransactionRequestAccountsItems> accounts,
            int? colCoId = null,
            string invoiceStatus = null,
            string purchasedInCountry = null,
            string fromDate = null,
            string toDate = null,
            int? period = null,
            string postingDateFrom = null,
            string postingDateTo = null,
            string invoiceDate = null,
            string invoiceNumber = null,
            bool? validInvoiceDateOnly = null,
            string invoiceFromDate = null,
            string invoiceToDate = null,
            bool? fuelOnly = null,
            bool? includeFees = null,
            string sortOrder = null,
            int? currentPage = null,
            int? pageSize = null)
        {
            this.ColCoId = colCoId;
            this.ColCoCode = colCoCode;
            this.Accounts = accounts;
            this.InvoiceStatus = invoiceStatus;
            this.PurchasedInCountry = purchasedInCountry;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.Period = period;
            this.PostingDateFrom = postingDateFrom;
            this.PostingDateTo = postingDateTo;
            this.InvoiceDate = invoiceDate;
            this.InvoiceNumber = invoiceNumber;
            this.ValidInvoiceDateOnly = validInvoiceDateOnly;
            this.InvoiceFromDate = invoiceFromDate;
            this.InvoiceToDate = invoiceToDate;
            this.FuelOnly = fuelOnly;
            this.IncludeFees = includeFees;
            this.SortOrder = sortOrder;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
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
        /// Collecting Company Code of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int ColCoCode { get; set; }

        /// <summary>
        /// List of Payers/Accounts entity.
        /// Mandatory.
        /// •	Max number of payers allowed in the input is 10, if it exceeds in the input it will throw an error.
        /// •	This value is configurable. Initial configuration will be 100 and will change to 10 once SFH changes are integrated.
        /// Note:
        /// 1.	At least one payer should be present.
        /// Accounts information are optional.
        /// </summary>
        [JsonProperty("Accounts")]
        public List<Models.MultiPricedTransactionRequestAccountsItems> Accounts { get; set; }

        /// <summary>
        /// Invoice status of the transactions
        /// Mandatory
        /// Possible options:
        /// I - Invoiced
        /// U – Un-Invoiced
        /// A – All
        /// Max Length: 1
        /// </summary>
        [JsonProperty("InvoiceStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// ISO Country Code (ex: UK, FR)
        /// Optional
        /// Note: If IncludeFees is true then this filter will be ignored
        /// </summary>
        [JsonProperty("PurchasedInCountry", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchasedInCountry { get; set; }

        /// <summary>
        /// Transactions from Date/Time.
        /// Optional – When provided, it should be with in last 24 months.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("FromDate", NullValueHandling = NullValueHandling.Ignore)]
        public string FromDate { get; set; }

        /// <summary>
        /// Transactions to Date/Time.
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
        /// </summary>
        [JsonProperty("Period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

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
        /// Invoice Date.
        /// Optional
        /// Note:
        /// 1) If value is not blank then the system will ignore the InvoiceStatus parameter and it will return all the billed transactions for the given invoice date.
        /// 2) If IncludeFees is true then this filter will be ignored
        /// 
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
        /// Note: If IncludeFees is ‘True’ then this filter will be ignored
        /// </summary>
        [JsonProperty("ValidInvoiceDateOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ValidInvoiceDateOnly { get; set; }

        /// <summary>
        /// Start date for transaction search by invoice date.
        /// Optional
        /// Note:
        /// 1) Value should be with in last 24 months (if provided).
        /// 2) Maximum of 90(Configurable) days duration allowed per search.
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
        /// Note: If IncludeFees is ‘True’ then this filter will be ignored
        /// </summary>
        [JsonProperty("FuelOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FuelOnly { get; set; }

        /// <summary>
        /// True/False
        /// Optional
        /// Default value: False
        /// When passed as ‘True’ then  ignore complex filters, all sales items along with fees included on the same response
        /// </summary>
        [JsonProperty("IncludeFees", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeFees { get; set; }

        /// <summary>
        /// Allowed Sorting Options:
        /// 1.	TransactionDateAscending
        /// 2.	TransactionDateDescending
        /// 3.	GrossAmountDescending
        /// 4.	GrossAmountAscending
        /// 5.	NetAmountAscending
        /// 6.	NetAmountDescensding
        /// Example value to be passed: 1,3
        /// Note: If IncludeFees is ‘True’ then sorting is not allowed. This parameter will be ignored.
        /// </summary>
        [JsonProperty("SortOrder", NullValueHandling = NullValueHandling.Ignore)]
        public string SortOrder { get; set; }

        /// <summary>
        /// Page Number (as shown to the users)
        /// Optional
        /// Default value 1
        /// Note: If IncludeFees is ‘True’ then pagination is not allowed. This parameter will be ignored.
        /// </summary>
        [JsonProperty("CurrentPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Page Size – Number of records to show on a page
        /// Optional
        /// Default value 50
        /// Note: If IncludeFees is ‘True’ then pagination is not allowed. This parameter will be ignored.
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MultiPricedTransactionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is MultiPricedTransactionRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                this.ColCoCode.Equals(other.ColCoCode) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.PurchasedInCountry == null && other.PurchasedInCountry == null) || (this.PurchasedInCountry?.Equals(other.PurchasedInCountry) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.PostingDateFrom == null && other.PostingDateFrom == null) || (this.PostingDateFrom?.Equals(other.PostingDateFrom) == true)) &&
                ((this.PostingDateTo == null && other.PostingDateTo == null) || (this.PostingDateTo?.Equals(other.PostingDateTo) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.ValidInvoiceDateOnly == null && other.ValidInvoiceDateOnly == null) || (this.ValidInvoiceDateOnly?.Equals(other.ValidInvoiceDateOnly) == true)) &&
                ((this.InvoiceFromDate == null && other.InvoiceFromDate == null) || (this.InvoiceFromDate?.Equals(other.InvoiceFromDate) == true)) &&
                ((this.InvoiceToDate == null && other.InvoiceToDate == null) || (this.InvoiceToDate?.Equals(other.InvoiceToDate) == true)) &&
                ((this.FuelOnly == null && other.FuelOnly == null) || (this.FuelOnly?.Equals(other.FuelOnly) == true)) &&
                ((this.IncludeFees == null && other.IncludeFees == null) || (this.IncludeFees?.Equals(other.IncludeFees) == true)) &&
                ((this.SortOrder == null && other.SortOrder == null) || (this.SortOrder?.Equals(other.SortOrder) == true)) &&
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
            toStringOutput.Add($"this.ColCoCode = {this.ColCoCode}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus)}");
            toStringOutput.Add($"this.PurchasedInCountry = {(this.PurchasedInCountry == null ? "null" : this.PurchasedInCountry)}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.PostingDateFrom = {(this.PostingDateFrom == null ? "null" : this.PostingDateFrom)}");
            toStringOutput.Add($"this.PostingDateTo = {(this.PostingDateTo == null ? "null" : this.PostingDateTo)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.ValidInvoiceDateOnly = {(this.ValidInvoiceDateOnly == null ? "null" : this.ValidInvoiceDateOnly.ToString())}");
            toStringOutput.Add($"this.InvoiceFromDate = {(this.InvoiceFromDate == null ? "null" : this.InvoiceFromDate)}");
            toStringOutput.Add($"this.InvoiceToDate = {(this.InvoiceToDate == null ? "null" : this.InvoiceToDate)}");
            toStringOutput.Add($"this.FuelOnly = {(this.FuelOnly == null ? "null" : this.FuelOnly.ToString())}");
            toStringOutput.Add($"this.IncludeFees = {(this.IncludeFees == null ? "null" : this.IncludeFees.ToString())}");
            toStringOutput.Add($"this.SortOrder = {(this.SortOrder == null ? "null" : this.SortOrder)}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
        }
    }
}