// <copyright file="InvoicesSummaries.cs" company="APIMatic">
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
    /// InvoicesSummaries.
    /// </summary>
    public class InvoicesSummaries
    {
        private double? amountDue;
        private double? amountNotOverdue;
        private double? amountOverdue;
        private double? amountPaid;
        private string billingCurrencyCode;
        private string billingCurrencySymbol;
        private double? outstandingBalance;
        private string paymentDueDate;
        private string summaryDocumentDate;
        private int? totalBillingDocuments;
        private double? totalGrossAmountBillingCurrency;
        private double? totalNetAmountBillingCurrency;
        private int? totalSummaryDocuments;
        private double? totalVATAmountBillingCurrency;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AmountDue", false },
            { "AmountNotOverdue", false },
            { "AmountOverdue", false },
            { "AmountPaid", false },
            { "BillingCurrencyCode", false },
            { "BillingCurrencySymbol", false },
            { "OutstandingBalance", false },
            { "PaymentDueDate", false },
            { "SummaryDocumentDate", false },
            { "TotalBillingDocuments", false },
            { "TotalGrossAmountBillingCurrency", false },
            { "TotalNetAmountBillingCurrency", false },
            { "TotalSummaryDocuments", false },
            { "TotalVATAmountBillingCurrency", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesSummaries"/> class.
        /// </summary>
        public InvoicesSummaries()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoicesSummaries"/> class.
        /// </summary>
        /// <param name="amountDue">AmountDue.</param>
        /// <param name="amountNotOverdue">AmountNotOverdue.</param>
        /// <param name="amountOverdue">AmountOverdue.</param>
        /// <param name="amountPaid">AmountPaid.</param>
        /// <param name="billingCurrencyCode">BillingCurrencyCode.</param>
        /// <param name="billingCurrencySymbol">BillingCurrencySymbol.</param>
        /// <param name="outstandingBalance">OutstandingBalance.</param>
        /// <param name="paymentDueDate">PaymentDueDate.</param>
        /// <param name="summaryDocumentDate">SummaryDocumentDate.</param>
        /// <param name="totalBillingDocuments">TotalBillingDocuments.</param>
        /// <param name="totalGrossAmountBillingCurrency">TotalGrossAmountBillingCurrency.</param>
        /// <param name="totalNetAmountBillingCurrency">TotalNetAmountBillingCurrency.</param>
        /// <param name="totalSummaryDocuments">TotalSummaryDocuments.</param>
        /// <param name="totalVATAmountBillingCurrency">TotalVATAmountBillingCurrency.</param>
        public InvoicesSummaries(
            double? amountDue = null,
            double? amountNotOverdue = null,
            double? amountOverdue = null,
            double? amountPaid = null,
            string billingCurrencyCode = null,
            string billingCurrencySymbol = null,
            double? outstandingBalance = null,
            string paymentDueDate = null,
            string summaryDocumentDate = null,
            int? totalBillingDocuments = null,
            double? totalGrossAmountBillingCurrency = null,
            double? totalNetAmountBillingCurrency = null,
            int? totalSummaryDocuments = null,
            double? totalVATAmountBillingCurrency = null)
        {
            if (amountDue != null)
            {
                this.AmountDue = amountDue;
            }

            if (amountNotOverdue != null)
            {
                this.AmountNotOverdue = amountNotOverdue;
            }

            if (amountOverdue != null)
            {
                this.AmountOverdue = amountOverdue;
            }

            if (amountPaid != null)
            {
                this.AmountPaid = amountPaid;
            }

            if (billingCurrencyCode != null)
            {
                this.BillingCurrencyCode = billingCurrencyCode;
            }

            if (billingCurrencySymbol != null)
            {
                this.BillingCurrencySymbol = billingCurrencySymbol;
            }

            if (outstandingBalance != null)
            {
                this.OutstandingBalance = outstandingBalance;
            }

            if (paymentDueDate != null)
            {
                this.PaymentDueDate = paymentDueDate;
            }

            if (summaryDocumentDate != null)
            {
                this.SummaryDocumentDate = summaryDocumentDate;
            }

            if (totalBillingDocuments != null)
            {
                this.TotalBillingDocuments = totalBillingDocuments;
            }

            if (totalGrossAmountBillingCurrency != null)
            {
                this.TotalGrossAmountBillingCurrency = totalGrossAmountBillingCurrency;
            }

            if (totalNetAmountBillingCurrency != null)
            {
                this.TotalNetAmountBillingCurrency = totalNetAmountBillingCurrency;
            }

            if (totalSummaryDocuments != null)
            {
                this.TotalSummaryDocuments = totalSummaryDocuments;
            }

            if (totalVATAmountBillingCurrency != null)
            {
                this.TotalVATAmountBillingCurrency = totalVATAmountBillingCurrency;
            }

        }

        /// <summary>
        /// Amount due from last summary document date.
        /// </summary>
        [JsonProperty("AmountDue")]
        public double? AmountDue
        {
            get
            {
                return this.amountDue;
            }

            set
            {
                this.shouldSerialize["AmountDue"] = true;
                this.amountDue = value;
            }
        }

        /// <summary>
        /// Amount that are due from past summary documents.
        /// </summary>
        [JsonProperty("AmountNotOverdue")]
        public double? AmountNotOverdue
        {
            get
            {
                return this.amountNotOverdue;
            }

            set
            {
                this.shouldSerialize["AmountNotOverdue"] = true;
                this.amountNotOverdue = value;
            }
        }

        /// <summary>
        /// Amount that are overdue from past summary documents.
        /// </summary>
        [JsonProperty("AmountOverdue")]
        public double? AmountOverdue
        {
            get
            {
                return this.amountOverdue;
            }

            set
            {
                this.shouldSerialize["AmountOverdue"] = true;
                this.amountOverdue = value;
            }
        }

        /// <summary>
        /// Total amount paid in billing currency.
        /// </summary>
        [JsonProperty("AmountPaid")]
        public double? AmountPaid
        {
            get
            {
                return this.amountPaid;
            }

            set
            {
                this.shouldSerialize["AmountPaid"] = true;
                this.amountPaid = value;
            }
        }

        /// <summary>
        /// Billing currency ISO code.
        /// </summary>
        [JsonProperty("BillingCurrencyCode")]
        public string BillingCurrencyCode
        {
            get
            {
                return this.billingCurrencyCode;
            }

            set
            {
                this.shouldSerialize["BillingCurrencyCode"] = true;
                this.billingCurrencyCode = value;
            }
        }

        /// <summary>
        /// Billing currency symbol.
        /// Example: €
        /// </summary>
        [JsonProperty("BillingCurrencySymbol")]
        public string BillingCurrencySymbol
        {
            get
            {
                return this.billingCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["BillingCurrencySymbol"] = true;
                this.billingCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Current outstanding balance amount
        /// </summary>
        [JsonProperty("OutstandingBalance")]
        public double? OutstandingBalance
        {
            get
            {
                return this.outstandingBalance;
            }

            set
            {
                this.shouldSerialize["OutstandingBalance"] = true;
                this.outstandingBalance = value;
            }
        }

        /// <summary>
        /// Payment due date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("PaymentDueDate")]
        public string PaymentDueDate
        {
            get
            {
                return this.paymentDueDate;
            }

            set
            {
                this.shouldSerialize["PaymentDueDate"] = true;
                this.paymentDueDate = value;
            }
        }

        /// <summary>
        /// Summary document date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("SummaryDocumentDate")]
        public string SummaryDocumentDate
        {
            get
            {
                return this.summaryDocumentDate;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentDate"] = true;
                this.summaryDocumentDate = value;
            }
        }

        /// <summary>
        /// Total number of invoices generated on this date.
        /// </summary>
        [JsonProperty("TotalBillingDocuments")]
        public int? TotalBillingDocuments
        {
            get
            {
                return this.totalBillingDocuments;
            }

            set
            {
                this.shouldSerialize["TotalBillingDocuments"] = true;
                this.totalBillingDocuments = value;
            }
        }

        /// <summary>
        /// Total gross amount in billing currency.
        /// </summary>
        [JsonProperty("TotalGrossAmountBillingCurrency")]
        public double? TotalGrossAmountBillingCurrency
        {
            get
            {
                return this.totalGrossAmountBillingCurrency;
            }

            set
            {
                this.shouldSerialize["TotalGrossAmountBillingCurrency"] = true;
                this.totalGrossAmountBillingCurrency = value;
            }
        }

        /// <summary>
        /// Total net amount in billing currency.
        /// </summary>
        [JsonProperty("TotalNetAmountBillingCurrency")]
        public double? TotalNetAmountBillingCurrency
        {
            get
            {
                return this.totalNetAmountBillingCurrency;
            }

            set
            {
                this.shouldSerialize["TotalNetAmountBillingCurrency"] = true;
                this.totalNetAmountBillingCurrency = value;
            }
        }

        /// <summary>
        /// Total number of summary documents generated on this date.
        /// </summary>
        [JsonProperty("TotalSummaryDocuments")]
        public int? TotalSummaryDocuments
        {
            get
            {
                return this.totalSummaryDocuments;
            }

            set
            {
                this.shouldSerialize["TotalSummaryDocuments"] = true;
                this.totalSummaryDocuments = value;
            }
        }

        /// <summary>
        /// Total VAT amount in billing currency.
        /// </summary>
        [JsonProperty("TotalVATAmountBillingCurrency")]
        public double? TotalVATAmountBillingCurrency
        {
            get
            {
                return this.totalVATAmountBillingCurrency;
            }

            set
            {
                this.shouldSerialize["TotalVATAmountBillingCurrency"] = true;
                this.totalVATAmountBillingCurrency = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoicesSummaries : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountDue()
        {
            this.shouldSerialize["AmountDue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountNotOverdue()
        {
            this.shouldSerialize["AmountNotOverdue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountOverdue()
        {
            this.shouldSerialize["AmountOverdue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAmountPaid()
        {
            this.shouldSerialize["AmountPaid"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingCurrencyCode()
        {
            this.shouldSerialize["BillingCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingCurrencySymbol()
        {
            this.shouldSerialize["BillingCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOutstandingBalance()
        {
            this.shouldSerialize["OutstandingBalance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentDueDate()
        {
            this.shouldSerialize["PaymentDueDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentDate()
        {
            this.shouldSerialize["SummaryDocumentDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalBillingDocuments()
        {
            this.shouldSerialize["TotalBillingDocuments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalGrossAmountBillingCurrency()
        {
            this.shouldSerialize["TotalGrossAmountBillingCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalNetAmountBillingCurrency()
        {
            this.shouldSerialize["TotalNetAmountBillingCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalSummaryDocuments()
        {
            this.shouldSerialize["TotalSummaryDocuments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalVATAmountBillingCurrency()
        {
            this.shouldSerialize["TotalVATAmountBillingCurrency"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountDue()
        {
            return this.shouldSerialize["AmountDue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountNotOverdue()
        {
            return this.shouldSerialize["AmountNotOverdue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountOverdue()
        {
            return this.shouldSerialize["AmountOverdue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAmountPaid()
        {
            return this.shouldSerialize["AmountPaid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingCurrencyCode()
        {
            return this.shouldSerialize["BillingCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingCurrencySymbol()
        {
            return this.shouldSerialize["BillingCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOutstandingBalance()
        {
            return this.shouldSerialize["OutstandingBalance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentDueDate()
        {
            return this.shouldSerialize["PaymentDueDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentDate()
        {
            return this.shouldSerialize["SummaryDocumentDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalBillingDocuments()
        {
            return this.shouldSerialize["TotalBillingDocuments"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalGrossAmountBillingCurrency()
        {
            return this.shouldSerialize["TotalGrossAmountBillingCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalNetAmountBillingCurrency()
        {
            return this.shouldSerialize["TotalNetAmountBillingCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalSummaryDocuments()
        {
            return this.shouldSerialize["TotalSummaryDocuments"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalVATAmountBillingCurrency()
        {
            return this.shouldSerialize["TotalVATAmountBillingCurrency"];
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
            return obj is InvoicesSummaries other &&                ((this.AmountDue == null && other.AmountDue == null) || (this.AmountDue?.Equals(other.AmountDue) == true)) &&
                ((this.AmountNotOverdue == null && other.AmountNotOverdue == null) || (this.AmountNotOverdue?.Equals(other.AmountNotOverdue) == true)) &&
                ((this.AmountOverdue == null && other.AmountOverdue == null) || (this.AmountOverdue?.Equals(other.AmountOverdue) == true)) &&
                ((this.AmountPaid == null && other.AmountPaid == null) || (this.AmountPaid?.Equals(other.AmountPaid) == true)) &&
                ((this.BillingCurrencyCode == null && other.BillingCurrencyCode == null) || (this.BillingCurrencyCode?.Equals(other.BillingCurrencyCode) == true)) &&
                ((this.BillingCurrencySymbol == null && other.BillingCurrencySymbol == null) || (this.BillingCurrencySymbol?.Equals(other.BillingCurrencySymbol) == true)) &&
                ((this.OutstandingBalance == null && other.OutstandingBalance == null) || (this.OutstandingBalance?.Equals(other.OutstandingBalance) == true)) &&
                ((this.PaymentDueDate == null && other.PaymentDueDate == null) || (this.PaymentDueDate?.Equals(other.PaymentDueDate) == true)) &&
                ((this.SummaryDocumentDate == null && other.SummaryDocumentDate == null) || (this.SummaryDocumentDate?.Equals(other.SummaryDocumentDate) == true)) &&
                ((this.TotalBillingDocuments == null && other.TotalBillingDocuments == null) || (this.TotalBillingDocuments?.Equals(other.TotalBillingDocuments) == true)) &&
                ((this.TotalGrossAmountBillingCurrency == null && other.TotalGrossAmountBillingCurrency == null) || (this.TotalGrossAmountBillingCurrency?.Equals(other.TotalGrossAmountBillingCurrency) == true)) &&
                ((this.TotalNetAmountBillingCurrency == null && other.TotalNetAmountBillingCurrency == null) || (this.TotalNetAmountBillingCurrency?.Equals(other.TotalNetAmountBillingCurrency) == true)) &&
                ((this.TotalSummaryDocuments == null && other.TotalSummaryDocuments == null) || (this.TotalSummaryDocuments?.Equals(other.TotalSummaryDocuments) == true)) &&
                ((this.TotalVATAmountBillingCurrency == null && other.TotalVATAmountBillingCurrency == null) || (this.TotalVATAmountBillingCurrency?.Equals(other.TotalVATAmountBillingCurrency) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AmountDue = {(this.AmountDue == null ? "null" : this.AmountDue.ToString())}");
            toStringOutput.Add($"this.AmountNotOverdue = {(this.AmountNotOverdue == null ? "null" : this.AmountNotOverdue.ToString())}");
            toStringOutput.Add($"this.AmountOverdue = {(this.AmountOverdue == null ? "null" : this.AmountOverdue.ToString())}");
            toStringOutput.Add($"this.AmountPaid = {(this.AmountPaid == null ? "null" : this.AmountPaid.ToString())}");
            toStringOutput.Add($"this.BillingCurrencyCode = {(this.BillingCurrencyCode == null ? "null" : this.BillingCurrencyCode)}");
            toStringOutput.Add($"this.BillingCurrencySymbol = {(this.BillingCurrencySymbol == null ? "null" : this.BillingCurrencySymbol)}");
            toStringOutput.Add($"this.OutstandingBalance = {(this.OutstandingBalance == null ? "null" : this.OutstandingBalance.ToString())}");
            toStringOutput.Add($"this.PaymentDueDate = {(this.PaymentDueDate == null ? "null" : this.PaymentDueDate)}");
            toStringOutput.Add($"this.SummaryDocumentDate = {(this.SummaryDocumentDate == null ? "null" : this.SummaryDocumentDate)}");
            toStringOutput.Add($"this.TotalBillingDocuments = {(this.TotalBillingDocuments == null ? "null" : this.TotalBillingDocuments.ToString())}");
            toStringOutput.Add($"this.TotalGrossAmountBillingCurrency = {(this.TotalGrossAmountBillingCurrency == null ? "null" : this.TotalGrossAmountBillingCurrency.ToString())}");
            toStringOutput.Add($"this.TotalNetAmountBillingCurrency = {(this.TotalNetAmountBillingCurrency == null ? "null" : this.TotalNetAmountBillingCurrency.ToString())}");
            toStringOutput.Add($"this.TotalSummaryDocuments = {(this.TotalSummaryDocuments == null ? "null" : this.TotalSummaryDocuments.ToString())}");
            toStringOutput.Add($"this.TotalVATAmountBillingCurrency = {(this.TotalVATAmountBillingCurrency == null ? "null" : this.TotalVATAmountBillingCurrency.ToString())}");
        }
    }
}