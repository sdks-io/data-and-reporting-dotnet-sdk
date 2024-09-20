// <copyright file="StatementOfAccountRequestFilters.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
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

namespace ShellDataReportingAPIs.Standard.Models
{
    /// <summary>
    /// StatementOfAccountRequestFilters.
    /// </summary>
    public class StatementOfAccountRequestFilters
    {
        private int? colCoCode;
        private int? payerId;
        private string payerNumber;
        private bool? includeMonthlyInvoiceTrend;
        private bool? includePastStatementOfAccounts;
        private bool? dueOrOverDueSOADocumentsOnly;
        private int? numberOfSOADocuments;
        private bool? includeAccountInvoicesSummary;
        private int? colCoId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoCode", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "IncludeMonthlyInvoiceTrend", false },
            { "IncludePastStatementOfAccounts", false },
            { "DueOrOverDueSOADocumentsOnly", false },
            { "NumberOfSOADocuments", false },
            { "IncludeAccountInvoicesSummary", false },
            { "ColCoId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementOfAccountRequestFilters"/> class.
        /// </summary>
        public StatementOfAccountRequestFilters()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementOfAccountRequestFilters"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="includeMonthlyInvoiceTrend">IncludeMonthlyInvoiceTrend.</param>
        /// <param name="includePastStatementOfAccounts">IncludePastStatementOfAccounts.</param>
        /// <param name="dueOrOverDueSOADocumentsOnly">DueOrOverDueSOADocumentsOnly.</param>
        /// <param name="numberOfSOADocuments">NumberOfSOADocuments.</param>
        /// <param name="includeAccountInvoicesSummary">IncludeAccountInvoicesSummary.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="accounts">Accounts.</param>
        public StatementOfAccountRequestFilters(
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            bool? includeMonthlyInvoiceTrend = null,
            bool? includePastStatementOfAccounts = null,
            bool? dueOrOverDueSOADocumentsOnly = null,
            int? numberOfSOADocuments = null,
            bool? includeAccountInvoicesSummary = null,
            int? colCoId = null,
            List<Models.Accounts> accounts = null)
        {
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

            if (includeMonthlyInvoiceTrend != null)
            {
                this.IncludeMonthlyInvoiceTrend = includeMonthlyInvoiceTrend;
            }

            if (includePastStatementOfAccounts != null)
            {
                this.IncludePastStatementOfAccounts = includePastStatementOfAccounts;
            }

            if (dueOrOverDueSOADocumentsOnly != null)
            {
                this.DueOrOverDueSOADocumentsOnly = dueOrOverDueSOADocumentsOnly;
            }

            if (numberOfSOADocuments != null)
            {
                this.NumberOfSOADocuments = numberOfSOADocuments;
            }

            if (includeAccountInvoicesSummary != null)
            {
                this.IncludeAccountInvoicesSummary = includeAccountInvoicesSummary;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            this.Accounts = accounts;
        }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Optional If ColCo Id is passed else Mandatory.
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
        /// Optional if PayerNumber is passed else Mandatory.
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
        /// Optional if PayerId is passed else Mandatory.
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
        /// True/False.
        /// Optional. Default is False.
        /// True if the past 13 monthly invoice trend to be included as part of the response. Else false.
        /// </summary>
        [JsonProperty("IncludeMonthlyInvoiceTrend")]
        public bool? IncludeMonthlyInvoiceTrend
        {
            get
            {
                return this.includeMonthlyInvoiceTrend;
            }

            set
            {
                this.shouldSerialize["IncludeMonthlyInvoiceTrend"] = true;
                this.includeMonthlyInvoiceTrend = value;
            }
        }

        /// <summary>
        /// True/False.
        /// Optional. Default is False.
        /// True if the past X SOA documents are to be included as part of the response. Else false.
        /// </summary>
        [JsonProperty("IncludePastStatementOfAccounts")]
        public bool? IncludePastStatementOfAccounts
        {
            get
            {
                return this.includePastStatementOfAccounts;
            }

            set
            {
                this.shouldSerialize["IncludePastStatementOfAccounts"] = true;
                this.includePastStatementOfAccounts = value;
            }
        }

        /// <summary>
        /// True/False
        /// Optional Default is False.
        /// If true PastStatementOfAccounts entity on this API output should contain the SOA documents that are due or overdue only.
        /// </summary>
        [JsonProperty("DueOrOverDueSOADocumentsOnly")]
        public bool? DueOrOverDueSOADocumentsOnly
        {
            get
            {
                return this.dueOrOverDueSOADocumentsOnly;
            }

            set
            {
                this.shouldSerialize["DueOrOverDueSOADocumentsOnly"] = true;
                this.dueOrOverDueSOADocumentsOnly = value;
            }
        }

        /// <summary>
        /// This parameter is only applicable when “IncludePastStatementOfAccounts” parameter is set to True.
        /// </summary>
        [JsonProperty("NumberOfSOADocuments")]
        public int? NumberOfSOADocuments
        {
            get
            {
                return this.numberOfSOADocuments;
            }

            set
            {
                this.shouldSerialize["NumberOfSOADocuments"] = true;
                this.numberOfSOADocuments = value;
            }
        }

        /// <summary>
        /// True/False
        /// Optional.
        /// Default value is false.
        /// When true InvoicesSummaries list will be returned in the API output.
        /// </summary>
        [JsonProperty("IncludeAccountInvoicesSummary")]
        public bool? IncludeAccountInvoicesSummary
        {
            get
            {
                return this.includeAccountInvoicesSummary;
            }

            set
            {
                this.shouldSerialize["IncludeAccountInvoicesSummary"] = true;
                this.includeAccountInvoicesSummary = value;
            }
        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional If ColCo Code is passed else Mandatory.
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
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Accounts> Accounts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StatementOfAccountRequestFilters : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetIncludeMonthlyInvoiceTrend()
        {
            this.shouldSerialize["IncludeMonthlyInvoiceTrend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncludePastStatementOfAccounts()
        {
            this.shouldSerialize["IncludePastStatementOfAccounts"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDueOrOverDueSOADocumentsOnly()
        {
            this.shouldSerialize["DueOrOverDueSOADocumentsOnly"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNumberOfSOADocuments()
        {
            this.shouldSerialize["NumberOfSOADocuments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncludeAccountInvoicesSummary()
        {
            this.shouldSerialize["IncludeAccountInvoicesSummary"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
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
        public bool ShouldSerializeIncludeMonthlyInvoiceTrend()
        {
            return this.shouldSerialize["IncludeMonthlyInvoiceTrend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludePastStatementOfAccounts()
        {
            return this.shouldSerialize["IncludePastStatementOfAccounts"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueOrOverDueSOADocumentsOnly()
        {
            return this.shouldSerialize["DueOrOverDueSOADocumentsOnly"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNumberOfSOADocuments()
        {
            return this.shouldSerialize["NumberOfSOADocuments"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludeAccountInvoicesSummary()
        {
            return this.shouldSerialize["IncludeAccountInvoicesSummary"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
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
            return obj is StatementOfAccountRequestFilters other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.IncludeMonthlyInvoiceTrend == null && other.IncludeMonthlyInvoiceTrend == null) || (this.IncludeMonthlyInvoiceTrend?.Equals(other.IncludeMonthlyInvoiceTrend) == true)) &&
                ((this.IncludePastStatementOfAccounts == null && other.IncludePastStatementOfAccounts == null) || (this.IncludePastStatementOfAccounts?.Equals(other.IncludePastStatementOfAccounts) == true)) &&
                ((this.DueOrOverDueSOADocumentsOnly == null && other.DueOrOverDueSOADocumentsOnly == null) || (this.DueOrOverDueSOADocumentsOnly?.Equals(other.DueOrOverDueSOADocumentsOnly) == true)) &&
                ((this.NumberOfSOADocuments == null && other.NumberOfSOADocuments == null) || (this.NumberOfSOADocuments?.Equals(other.NumberOfSOADocuments) == true)) &&
                ((this.IncludeAccountInvoicesSummary == null && other.IncludeAccountInvoicesSummary == null) || (this.IncludeAccountInvoicesSummary?.Equals(other.IncludeAccountInvoicesSummary) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.IncludeMonthlyInvoiceTrend = {(this.IncludeMonthlyInvoiceTrend == null ? "null" : this.IncludeMonthlyInvoiceTrend.ToString())}");
            toStringOutput.Add($"this.IncludePastStatementOfAccounts = {(this.IncludePastStatementOfAccounts == null ? "null" : this.IncludePastStatementOfAccounts.ToString())}");
            toStringOutput.Add($"this.DueOrOverDueSOADocumentsOnly = {(this.DueOrOverDueSOADocumentsOnly == null ? "null" : this.DueOrOverDueSOADocumentsOnly.ToString())}");
            toStringOutput.Add($"this.NumberOfSOADocuments = {(this.NumberOfSOADocuments == null ? "null" : this.NumberOfSOADocuments.ToString())}");
            toStringOutput.Add($"this.IncludeAccountInvoicesSummary = {(this.IncludeAccountInvoicesSummary == null ? "null" : this.IncludeAccountInvoicesSummary.ToString())}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
        }
    }
}