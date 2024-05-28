// <copyright file="TransactionFeesRequest.cs" company="APIMatic">
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
    /// TransactionFeesRequest.
    /// </summary>
    public class TransactionFeesRequest
    {
        private int? colCoId;
        private int? colCoCode;
        private int? payerId;
        private string payerNumber;
        private int? cardId;
        private string cardPAN;
        private string invoiceStatus;
        private string feeTypeGroup;
        private int? feeTypeId;
        private string fromDate;
        private string toDate;
        private int? period;
        private bool? includeCancelledItems;
        private int? productId;
        private string productCode;
        private string lineItemDescription;
        private string sortOrder;
        private int? currentPage;
        private int? pageSize;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "ColCoCode", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "CardId", false },
            { "CardPAN", false },
            { "InvoiceStatus", false },
            { "FeeTypeGroup", false },
            { "FeeTypeId", false },
            { "FromDate", false },
            { "ToDate", false },
            { "Period", false },
            { "IncludeCancelledItems", false },
            { "ProductId", false },
            { "ProductCode", false },
            { "LineItemDescription", false },
            { "SortOrder", false },
            { "CurrentPage", false },
            { "PageSize", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFeesRequest"/> class.
        /// </summary>
        public TransactionFeesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionFeesRequest"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="feeTypeGroup">FeeTypeGroup.</param>
        /// <param name="feeTypeId">FeeTypeId.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="period">Period.</param>
        /// <param name="includeCancelledItems">IncludeCancelledItems.</param>
        /// <param name="productId">ProductId.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="lineItemDescription">LineItemDescription.</param>
        /// <param name="sortOrder">SortOrder.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="pageSize">PageSize.</param>
        public TransactionFeesRequest(
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            List<Models.Accounts> accounts = null,
            int? cardId = null,
            string cardPAN = null,
            string invoiceStatus = null,
            string feeTypeGroup = null,
            int? feeTypeId = null,
            string fromDate = null,
            string toDate = null,
            int? period = null,
            bool? includeCancelledItems = null,
            int? productId = null,
            string productCode = null,
            string lineItemDescription = null,
            string sortOrder = null,
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

            if (invoiceStatus != null)
            {
                this.InvoiceStatus = invoiceStatus;
            }

            if (feeTypeGroup != null)
            {
                this.FeeTypeGroup = feeTypeGroup;
            }

            if (feeTypeId != null)
            {
                this.FeeTypeId = feeTypeId;
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

            if (includeCancelledItems != null)
            {
                this.IncludeCancelledItems = includeCancelledItems;
            }

            if (productId != null)
            {
                this.ProductId = productId;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (lineItemDescription != null)
            {
                this.LineItemDescription = lineItemDescription;
            }

            if (sortOrder != null)
            {
                this.SortOrder = sortOrder;
            }

            if (currentPage != null)
            {
                this.CurrentPage = currentPage;
            }

            if (pageSize != null)
            {
                this.PageSize = pageSize;
            }

        }

        /// <summary>
        /// Collecting Company Id  of the selected payer.
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
        /// Collecting Company Code (Shell Code) of the selected payer.
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
        /// Payer Id of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// Example: 123456
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
        public List<Models.Accounts> Accounts { get; set; }

        /// <summary>
        /// Card Id
        /// Optional
        /// When both Card Id and Card PAN are not present on request, the response will have all the fee items under the selected payer or account.
        /// Example: 275549
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
        /// When both Card Id and Card PAN are not present on request, the response will have all the fee items under the selected payer or account or card group.
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
        /// Invoice status of the fee items
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
        /// Fee type group in under which the Fee item is generated.
        /// Optional.
        /// Allowed values:
        /// - Account Charges
        /// - Card Charges
        /// - Others Charges
        /// </summary>
        [JsonProperty("FeeTypeGroup")]
        public string FeeTypeGroup
        {
            get
            {
                return this.feeTypeGroup;
            }

            set
            {
                this.shouldSerialize["FeeTypeGroup"] = true;
                this.feeTypeGroup = value;
            }
        }

        /// <summary>
        /// Fee Type Id.
        /// Optional.
        /// Example:
        /// 1. Simple Fee
        /// 2. Card Event Fee
        /// 3. Customer Event Fee
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
        /// Fee Item FromDate/Time
        /// Should be with in last 24 months
        /// Optional
        /// Maximum of 210 days duration allowed per search, its configurable.
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
        /// Fee Item To Date/Time
        /// Optional
        /// When blank and FromDate is provided on the input, all fee items took place after the given from date/time should be returned. Note that the search is allowed for the maximum of 60 days. Hence if the FromDate is older than 60 days from current date then the fee items for 60 days from FromDate will be returned.
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
        /// Fee items Period. This is ignored when FromDate/Todate is supplied on the request.
        /// 1.	Last 7 Days
        /// 2.	Last 30 Days
        /// 3.	Last 90 Days
        /// 4.	Last 180 Days
        /// Example : Pass 1 for Last 7 days fee items
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
        /// True or False. When True, cancelled fee items are included on API response
        /// </summary>
        [JsonProperty("IncludeCancelledItems")]
        public bool? IncludeCancelledItems
        {
            get
            {
                return this.includeCancelledItems;
            }

            set
            {
                this.shouldSerialize["IncludeCancelledItems"] = true;
                this.includeCancelledItems = value;
            }
        }

        /// <summary>
        /// Product Id
        /// Optional
        /// Example: Sample list of product ids and description.
        /// 100	Service fee
        /// 102	Invoice production fee
        /// 103	Account fee
        /// 104	Transaction fee
        /// 105	Card membership fee
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
        /// Product Code
        /// Optional
        /// Example:
        /// 1. Service fee
        /// 2. Invoice production fee
        /// 3. Account fee
        /// 4. Transaction fee
        /// 5. Card membership fee
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
        /// Line item description.
        /// Optional
        /// Minimum of 4 characters should be provided else not considered
        /// Those fee items that have the entered value at any part of the line item description will be returned.
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
        /// Allowed Sorting Options:
        /// •	FeeDateAscending
        /// •	FeeDateDescending
        /// •	NetAmountAscending
        /// •	NetAmountDescending
        /// Optional.
        /// Default: 1
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
        /// Page Number
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
        /// </summary>
        [JsonProperty("PageSize")]
        public int? PageSize
        {
            get
            {
                return this.pageSize;
            }

            set
            {
                this.shouldSerialize["PageSize"] = true;
                this.pageSize = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionFeesRequest : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetInvoiceStatus()
        {
            this.shouldSerialize["InvoiceStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeTypeGroup()
        {
            this.shouldSerialize["FeeTypeGroup"] = false;
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
        public void UnsetIncludeCancelledItems()
        {
            this.shouldSerialize["IncludeCancelledItems"] = false;
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
        public void UnsetLineItemDescription()
        {
            this.shouldSerialize["LineItemDescription"] = false;
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
        public void UnsetCurrentPage()
        {
            this.shouldSerialize["CurrentPage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPageSize()
        {
            this.shouldSerialize["PageSize"] = false;
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
        public bool ShouldSerializeInvoiceStatus()
        {
            return this.shouldSerialize["InvoiceStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeTypeGroup()
        {
            return this.shouldSerialize["FeeTypeGroup"];
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
        public bool ShouldSerializeIncludeCancelledItems()
        {
            return this.shouldSerialize["IncludeCancelledItems"];
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
        public bool ShouldSerializeLineItemDescription()
        {
            return this.shouldSerialize["LineItemDescription"];
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
        public bool ShouldSerializeCurrentPage()
        {
            return this.shouldSerialize["CurrentPage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePageSize()
        {
            return this.shouldSerialize["PageSize"];
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
            return obj is TransactionFeesRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.FeeTypeGroup == null && other.FeeTypeGroup == null) || (this.FeeTypeGroup?.Equals(other.FeeTypeGroup) == true)) &&
                ((this.FeeTypeId == null && other.FeeTypeId == null) || (this.FeeTypeId?.Equals(other.FeeTypeId) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.IncludeCancelledItems == null && other.IncludeCancelledItems == null) || (this.IncludeCancelledItems?.Equals(other.IncludeCancelledItems) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.LineItemDescription == null && other.LineItemDescription == null) || (this.LineItemDescription?.Equals(other.LineItemDescription) == true)) &&
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
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus)}");
            toStringOutput.Add($"this.FeeTypeGroup = {(this.FeeTypeGroup == null ? "null" : this.FeeTypeGroup)}");
            toStringOutput.Add($"this.FeeTypeId = {(this.FeeTypeId == null ? "null" : this.FeeTypeId.ToString())}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.IncludeCancelledItems = {(this.IncludeCancelledItems == null ? "null" : this.IncludeCancelledItems.ToString())}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.LineItemDescription = {(this.LineItemDescription == null ? "null" : this.LineItemDescription)}");
            toStringOutput.Add($"this.SortOrder = {(this.SortOrder == null ? "null" : this.SortOrder)}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
        }
    }
}