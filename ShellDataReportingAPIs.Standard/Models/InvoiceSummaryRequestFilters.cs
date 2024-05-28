// <copyright file="InvoiceSummaryRequestFilters.cs" company="APIMatic">
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
    /// InvoiceSummaryRequestFilters.
    /// </summary>
    public class InvoiceSummaryRequestFilters
    {
        private int? colCoId;
        private int? payerId;
        private string payerNumber;
        private int? invoiceId;
        private string invoiceNumber;
        private string fromDate;
        private string toDate;
        private string invoiceDate;
        private int? summaryDocumentId;
        private string summaryDocumentNumber;
        private string statementOfAccountId;
        private string soAReferenceNumber;
        private int? period;
        private string invoiceStatus;
        private string invoicedOnBehalfOf;
        private bool? includeEInvoiceDetails;
        private int? colCoCode;
        private string type;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "InvoiceId", false },
            { "InvoiceNumber", false },
            { "FromDate", false },
            { "ToDate", false },
            { "InvoiceDate", false },
            { "SummaryDocumentId", false },
            { "SummaryDocumentNumber", false },
            { "StatementOfAccountId", false },
            { "SoAReferenceNumber", false },
            { "Period", false },
            { "InvoiceStatus", false },
            { "InvoicedOnBehalfOf", false },
            { "IncludeEInvoiceDetails", false },
            { "ColCoCode", false },
            { "Type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSummaryRequestFilters"/> class.
        /// </summary>
        public InvoiceSummaryRequestFilters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSummaryRequestFilters"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="invoiceId">InvoiceId.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="summaryDocumentId">SummaryDocumentId.</param>
        /// <param name="summaryDocumentNumber">SummaryDocumentNumber.</param>
        /// <param name="statementOfAccountId">StatementOfAccountId.</param>
        /// <param name="soAReferenceNumber">SoAReferenceNumber.</param>
        /// <param name="period">Period.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="invoicedOnBehalfOf">InvoicedOnBehalfOf.</param>
        /// <param name="includeEInvoiceDetails">IncludeEInvoiceDetails.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="type">Type.</param>
        public InvoiceSummaryRequestFilters(
            int? colCoId = null,
            int? payerId = null,
            string payerNumber = null,
            int? invoiceId = null,
            string invoiceNumber = null,
            string fromDate = null,
            string toDate = null,
            string invoiceDate = null,
            int? summaryDocumentId = null,
            string summaryDocumentNumber = null,
            string statementOfAccountId = null,
            string soAReferenceNumber = null,
            int? period = null,
            string invoiceStatus = null,
            string invoicedOnBehalfOf = null,
            bool? includeEInvoiceDetails = null,
            int? colCoCode = null,
            List<Models.Accounts> accounts = null,
            string type = null)
        {
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (invoiceId != null)
            {
                this.InvoiceId = invoiceId;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (summaryDocumentId != null)
            {
                this.SummaryDocumentId = summaryDocumentId;
            }

            if (summaryDocumentNumber != null)
            {
                this.SummaryDocumentNumber = summaryDocumentNumber;
            }

            if (statementOfAccountId != null)
            {
                this.StatementOfAccountId = statementOfAccountId;
            }

            if (soAReferenceNumber != null)
            {
                this.SoAReferenceNumber = soAReferenceNumber;
            }

            if (period != null)
            {
                this.Period = period;
            }

            if (invoiceStatus != null)
            {
                this.InvoiceStatus = invoiceStatus;
            }

            if (invoicedOnBehalfOf != null)
            {
                this.InvoicedOnBehalfOf = invoicedOnBehalfOf;
            }

            if (includeEInvoiceDetails != null)
            {
                this.IncludeEInvoiceDetails = includeEInvoiceDetails;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            this.Accounts = accounts;
            if (type != null)
            {
                this.Type = type;
            }

        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional.
        /// Example:
        /// 1-Philippines
        /// 5-UK
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
        /// Payer Number of the selected payer.
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
        /// Invoice id.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Example: 1
        /// </summary>
        [JsonProperty("InvoiceId")]
        public int? InvoiceId
        {
            get
            {
                return this.invoiceId;
            }

            set
            {
                this.shouldSerialize["InvoiceId"] = true;
                this.invoiceId = value;
            }
        }

        /// <summary>
        /// Invoice number.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Example: 0123456789
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
        /// Invoice date searched from this date.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Date format: yyyyMMdd
        /// Example: 20170830
        /// Note: This criterion is ignored if ‘Period’ is given.
        /// Also, this criterion is ignored if ‘ToDate’ is not provided.
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
        /// Invoice date searched until this date.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Date format: yyyyMMdd
        /// Example: 20170830
        /// Note: This criterion is ignored if ‘Period’ is given.
        /// Also, this criterion is ignored if ‘FromDate’ is not provided.
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
        /// Date of invoicing.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Date format: yyyyMMdd
        /// Example: 20170830
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
        /// Summary document id
        /// Optional.
        /// This input is a search criterion, if given.
        /// Example: 1
        /// </summary>
        [JsonProperty("SummaryDocumentId")]
        public int? SummaryDocumentId
        {
            get
            {
                return this.summaryDocumentId;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentId"] = true;
                this.summaryDocumentId = value;
            }
        }

        /// <summary>
        /// Summary document number
        /// Optional.
        /// This input is a search criterion, if given.
        /// Example: ‘0/CZ0000000123456/2017’
        /// </summary>
        [JsonProperty("SummaryDocumentNumber")]
        public string SummaryDocumentNumber
        {
            get
            {
                return this.summaryDocumentNumber;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentNumber"] = true;
                this.summaryDocumentNumber = value;
            }
        }

        /// <summary>
        /// Statement of Account Id of the payment customer.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Example: 1
        /// </summary>
        [JsonProperty("StatementOfAccountId")]
        public string StatementOfAccountId
        {
            get
            {
                return this.statementOfAccountId;
            }

            set
            {
                this.shouldSerialize["StatementOfAccountId"] = true;
                this.statementOfAccountId = value;
            }
        }

        /// <summary>
        /// Statement of Account reference number of the payment customer.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Example: 123
        /// </summary>
        [JsonProperty("SoAReferenceNumber")]
        public string SoAReferenceNumber
        {
            get
            {
                return this.soAReferenceNumber;
            }

            set
            {
                this.shouldSerialize["SoAReferenceNumber"] = true;
                this.soAReferenceNumber = value;
            }
        }

        /// <summary>
        /// Invoice date search period. Valid values –
        /// 1.	Last 7 days – Issued in last 7 days.
        /// 2.	Last 30 days – Issued in last 30 days.
        /// 3.	Last 90 days – Issued in last 90 days.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Example: 1
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
        /// Status of the invoice. Valid values –
        /// •	Due – Invoices due for payment and is within the due date.
        /// •	Paid – Fully paid Invoices.
        /// •	Overdue – Invoices due of payment and has crossed the due date.
        /// •	CreditNote – Credit notes
        /// •	CreditStatement
        /// Optional.
        /// This input is a search criterion, if given.
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
        /// ISO code of the country i.e., UK, DE, MY, etc.
        /// Optional
        /// </summary>
        [JsonProperty("InvoicedOnBehalfOf")]
        public string InvoicedOnBehalfOf
        {
            get
            {
                return this.invoicedOnBehalfOf;
            }

            set
            {
                this.shouldSerialize["InvoicedOnBehalfOf"] = true;
                this.invoicedOnBehalfOf = value;
            }
        }

        /// <summary>
        /// Whether to include the additional invoice details in the API response.
        /// Optional. Default value “False”.
        /// The parameters that are populated
        /// •	DocumentReference
        /// •	AdditionalDocuments
        /// The above fields will not be present in the response when the respective data is not available in the source system.
        /// </summary>
        [JsonProperty("IncludeEInvoiceDetails")]
        public bool? IncludeEInvoiceDetails
        {
            get
            {
                return this.includeEInvoiceDetails;
            }

            set
            {
                this.shouldSerialize["IncludeEInvoiceDetails"] = true;
                this.includeEInvoiceDetails = value;
            }
        }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// Mandatory - It is mandatory field to external source ATOS for E-invoicing.
        /// Example:
        /// 86-Philippines
        /// 5-UK
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
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Accounts> Accounts { get; set; }

        /// <summary>
        /// Invoice type. Allowed values –
        /// •	Original – Original document.
        /// •	Reversal – Reversed document.
        /// •	Replacement – Replaced document.
        /// Optional. (When not passed all invoice, types are considered for search)
        /// This input is a search criterion, if given.
        /// Example: Original
        /// </summary>
        [JsonProperty("Type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["Type"] = true;
                this.type = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceSummaryRequestFilters : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetInvoiceId()
        {
            this.shouldSerialize["InvoiceId"] = false;
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
        public void UnsetInvoiceDate()
        {
            this.shouldSerialize["InvoiceDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentId()
        {
            this.shouldSerialize["SummaryDocumentId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentNumber()
        {
            this.shouldSerialize["SummaryDocumentNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatementOfAccountId()
        {
            this.shouldSerialize["StatementOfAccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSoAReferenceNumber()
        {
            this.shouldSerialize["SoAReferenceNumber"] = false;
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
        public void UnsetInvoiceStatus()
        {
            this.shouldSerialize["InvoiceStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoicedOnBehalfOf()
        {
            this.shouldSerialize["InvoicedOnBehalfOf"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncludeEInvoiceDetails()
        {
            this.shouldSerialize["IncludeEInvoiceDetails"] = false;
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
        public void UnsetType()
        {
            this.shouldSerialize["Type"] = false;
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
        public bool ShouldSerializeInvoiceId()
        {
            return this.shouldSerialize["InvoiceId"];
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
        public bool ShouldSerializeInvoiceDate()
        {
            return this.shouldSerialize["InvoiceDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentId()
        {
            return this.shouldSerialize["SummaryDocumentId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentNumber()
        {
            return this.shouldSerialize["SummaryDocumentNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatementOfAccountId()
        {
            return this.shouldSerialize["StatementOfAccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSoAReferenceNumber()
        {
            return this.shouldSerialize["SoAReferenceNumber"];
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
        public bool ShouldSerializeInvoiceStatus()
        {
            return this.shouldSerialize["InvoiceStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoicedOnBehalfOf()
        {
            return this.shouldSerialize["InvoicedOnBehalfOf"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludeEInvoiceDetails()
        {
            return this.shouldSerialize["IncludeEInvoiceDetails"];
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
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["Type"];
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
            return obj is InvoiceSummaryRequestFilters other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.SummaryDocumentId == null && other.SummaryDocumentId == null) || (this.SummaryDocumentId?.Equals(other.SummaryDocumentId) == true)) &&
                ((this.SummaryDocumentNumber == null && other.SummaryDocumentNumber == null) || (this.SummaryDocumentNumber?.Equals(other.SummaryDocumentNumber) == true)) &&
                ((this.StatementOfAccountId == null && other.StatementOfAccountId == null) || (this.StatementOfAccountId?.Equals(other.StatementOfAccountId) == true)) &&
                ((this.SoAReferenceNumber == null && other.SoAReferenceNumber == null) || (this.SoAReferenceNumber?.Equals(other.SoAReferenceNumber) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.InvoicedOnBehalfOf == null && other.InvoicedOnBehalfOf == null) || (this.InvoicedOnBehalfOf?.Equals(other.InvoicedOnBehalfOf) == true)) &&
                ((this.IncludeEInvoiceDetails == null && other.IncludeEInvoiceDetails == null) || (this.IncludeEInvoiceDetails?.Equals(other.IncludeEInvoiceDetails) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId.ToString())}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.SummaryDocumentId = {(this.SummaryDocumentId == null ? "null" : this.SummaryDocumentId.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentNumber = {(this.SummaryDocumentNumber == null ? "null" : this.SummaryDocumentNumber)}");
            toStringOutput.Add($"this.StatementOfAccountId = {(this.StatementOfAccountId == null ? "null" : this.StatementOfAccountId)}");
            toStringOutput.Add($"this.SoAReferenceNumber = {(this.SoAReferenceNumber == null ? "null" : this.SoAReferenceNumber)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus)}");
            toStringOutput.Add($"this.InvoicedOnBehalfOf = {(this.InvoicedOnBehalfOf == null ? "null" : this.InvoicedOnBehalfOf)}");
            toStringOutput.Add($"this.IncludeEInvoiceDetails = {(this.IncludeEInvoiceDetails == null ? "null" : this.IncludeEInvoiceDetails.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}