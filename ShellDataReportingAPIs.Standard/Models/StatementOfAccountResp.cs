// <copyright file="StatementOfAccountResp.cs" company="APIMatic">
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
    /// StatementOfAccountResp.
    /// </summary>
    public class StatementOfAccountResp
    {
        private List<Models.MonthlyInvoiceTrend> monthlyInvoiceTrend;
        private List<Models.PaymentsSinceLastSOA> paymentsSinceLastSOA;
        private List<Models.InvoicesSummaries> invoicesSummaries;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "MonthlyInvoiceTrend", false },
            { "PaymentsSinceLastSOA", false },
            { "InvoicesSummaries", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementOfAccountResp"/> class.
        /// </summary>
        public StatementOfAccountResp()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatementOfAccountResp"/> class.
        /// </summary>
        /// <param name="lastStatementOfAccount">LastStatementOfAccount.</param>
        /// <param name="monthlyInvoiceTrend">MonthlyInvoiceTrend.</param>
        /// <param name="pastStatementOfAccounts">PastStatementOfAccounts.</param>
        /// <param name="paymentsSinceLastSOA">PaymentsSinceLastSOA.</param>
        /// <param name="invoicesSummaries">InvoicesSummaries.</param>
        public StatementOfAccountResp(
            Models.LastStatementOfAccount2 lastStatementOfAccount = null,
            List<Models.MonthlyInvoiceTrend> monthlyInvoiceTrend = null,
            List<Models.PastStatementOfAccounts> pastStatementOfAccounts = null,
            List<Models.PaymentsSinceLastSOA> paymentsSinceLastSOA = null,
            List<Models.InvoicesSummaries> invoicesSummaries = null)
        {
            this.LastStatementOfAccount = lastStatementOfAccount;
            if (monthlyInvoiceTrend != null)
            {
                this.MonthlyInvoiceTrend = monthlyInvoiceTrend;
            }

            this.PastStatementOfAccounts = pastStatementOfAccounts;
            if (paymentsSinceLastSOA != null)
            {
                this.PaymentsSinceLastSOA = paymentsSinceLastSOA;
            }

            if (invoicesSummaries != null)
            {
                this.InvoicesSummaries = invoicesSummaries;
            }

        }

        /// <summary>
        /// Gets or sets LastStatementOfAccount.
        /// </summary>
        [JsonProperty("LastStatementOfAccount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.LastStatementOfAccount2 LastStatementOfAccount { get; set; }

        /// <summary>
        /// Gets or sets MonthlyInvoiceTrend.
        /// </summary>
        [JsonProperty("MonthlyInvoiceTrend")]
        public List<Models.MonthlyInvoiceTrend> MonthlyInvoiceTrend
        {
            get
            {
                return this.monthlyInvoiceTrend;
            }

            set
            {
                this.shouldSerialize["MonthlyInvoiceTrend"] = true;
                this.monthlyInvoiceTrend = value;
            }
        }

        /// <summary>
        /// Gets or sets PastStatementOfAccounts.
        /// </summary>
        [JsonProperty("PastStatementOfAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PastStatementOfAccounts> PastStatementOfAccounts { get; set; }

        /// <summary>
        /// Gets or sets PaymentsSinceLastSOA.
        /// </summary>
        [JsonProperty("PaymentsSinceLastSOA")]
        public List<Models.PaymentsSinceLastSOA> PaymentsSinceLastSOA
        {
            get
            {
                return this.paymentsSinceLastSOA;
            }

            set
            {
                this.shouldSerialize["PaymentsSinceLastSOA"] = true;
                this.paymentsSinceLastSOA = value;
            }
        }

        /// <summary>
        /// Gets or sets InvoicesSummaries.
        /// </summary>
        [JsonProperty("InvoicesSummaries")]
        public List<Models.InvoicesSummaries> InvoicesSummaries
        {
            get
            {
                return this.invoicesSummaries;
            }

            set
            {
                this.shouldSerialize["InvoicesSummaries"] = true;
                this.invoicesSummaries = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"StatementOfAccountResp : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMonthlyInvoiceTrend()
        {
            this.shouldSerialize["MonthlyInvoiceTrend"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentsSinceLastSOA()
        {
            this.shouldSerialize["PaymentsSinceLastSOA"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoicesSummaries()
        {
            this.shouldSerialize["InvoicesSummaries"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMonthlyInvoiceTrend()
        {
            return this.shouldSerialize["MonthlyInvoiceTrend"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentsSinceLastSOA()
        {
            return this.shouldSerialize["PaymentsSinceLastSOA"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoicesSummaries()
        {
            return this.shouldSerialize["InvoicesSummaries"];
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
            return obj is StatementOfAccountResp other &&                ((this.LastStatementOfAccount == null && other.LastStatementOfAccount == null) || (this.LastStatementOfAccount?.Equals(other.LastStatementOfAccount) == true)) &&
                ((this.MonthlyInvoiceTrend == null && other.MonthlyInvoiceTrend == null) || (this.MonthlyInvoiceTrend?.Equals(other.MonthlyInvoiceTrend) == true)) &&
                ((this.PastStatementOfAccounts == null && other.PastStatementOfAccounts == null) || (this.PastStatementOfAccounts?.Equals(other.PastStatementOfAccounts) == true)) &&
                ((this.PaymentsSinceLastSOA == null && other.PaymentsSinceLastSOA == null) || (this.PaymentsSinceLastSOA?.Equals(other.PaymentsSinceLastSOA) == true)) &&
                ((this.InvoicesSummaries == null && other.InvoicesSummaries == null) || (this.InvoicesSummaries?.Equals(other.InvoicesSummaries) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.LastStatementOfAccount = {(this.LastStatementOfAccount == null ? "null" : this.LastStatementOfAccount.ToString())}");
            toStringOutput.Add($"this.MonthlyInvoiceTrend = {(this.MonthlyInvoiceTrend == null ? "null" : $"[{string.Join(", ", this.MonthlyInvoiceTrend)} ]")}");
            toStringOutput.Add($"this.PastStatementOfAccounts = {(this.PastStatementOfAccounts == null ? "null" : $"[{string.Join(", ", this.PastStatementOfAccounts)} ]")}");
            toStringOutput.Add($"this.PaymentsSinceLastSOA = {(this.PaymentsSinceLastSOA == null ? "null" : $"[{string.Join(", ", this.PaymentsSinceLastSOA)} ]")}");
            toStringOutput.Add($"this.InvoicesSummaries = {(this.InvoicesSummaries == null ? "null" : $"[{string.Join(", ", this.InvoicesSummaries)} ]")}");
        }
    }
}