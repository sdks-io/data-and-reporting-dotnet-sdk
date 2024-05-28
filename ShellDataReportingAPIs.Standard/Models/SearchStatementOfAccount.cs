// <copyright file="SearchStatementOfAccount.cs" company="APIMatic">
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
    /// SearchStatementOfAccount.
    /// </summary>
    public class SearchStatementOfAccount
    {
        private int? statementOfAccountId;
        private string soAReferenceNumber;
        private string statementDate;
        private int? payerId;
        private string payerNumber;
        private double? amountDue;
        private double? amountOverdue;
        private string currencyCode;
        private string currencySymbol;
        private string dueDate;
        private string invoicedOnBehalfOf;
        private string status;
        private double? grossAmountCustomerCurrency;
        private string documentReferenceNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "StatementOfAccountId", false },
            { "SoAReferenceNumber", false },
            { "StatementDate", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "AmountDue", false },
            { "AmountOverdue", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "DueDate", false },
            { "InvoicedOnBehalfOf", false },
            { "Status", false },
            { "GrossAmountCustomerCurrency", false },
            { "DocumentReferenceNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStatementOfAccount"/> class.
        /// </summary>
        public SearchStatementOfAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStatementOfAccount"/> class.
        /// </summary>
        /// <param name="statementOfAccountId">StatementOfAccountId.</param>
        /// <param name="soAReferenceNumber">SoAReferenceNumber.</param>
        /// <param name="statementDate">StatementDate.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="amountDue">AmountDue.</param>
        /// <param name="amountOverdue">AmountOverdue.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="dueDate">DueDate.</param>
        /// <param name="invoicedOnBehalfOf">InvoicedOnBehalfOf.</param>
        /// <param name="status">Status.</param>
        /// <param name="grossAmountCustomerCurrency">GrossAmountCustomerCurrency.</param>
        /// <param name="documentReferenceNumber">DocumentReferenceNumber.</param>
        public SearchStatementOfAccount(
            int? statementOfAccountId = null,
            string soAReferenceNumber = null,
            string statementDate = null,
            int? payerId = null,
            string payerNumber = null,
            double? amountDue = null,
            double? amountOverdue = null,
            string currencyCode = null,
            string currencySymbol = null,
            string dueDate = null,
            string invoicedOnBehalfOf = null,
            string status = null,
            double? grossAmountCustomerCurrency = null,
            string documentReferenceNumber = null)
        {
            if (statementOfAccountId != null)
            {
                this.StatementOfAccountId = statementOfAccountId;
            }

            if (soAReferenceNumber != null)
            {
                this.SoAReferenceNumber = soAReferenceNumber;
            }

            if (statementDate != null)
            {
                this.StatementDate = statementDate;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (amountDue != null)
            {
                this.AmountDue = amountDue;
            }

            if (amountOverdue != null)
            {
                this.AmountOverdue = amountOverdue;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (dueDate != null)
            {
                this.DueDate = dueDate;
            }

            if (invoicedOnBehalfOf != null)
            {
                this.InvoicedOnBehalfOf = invoicedOnBehalfOf;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (grossAmountCustomerCurrency != null)
            {
                this.GrossAmountCustomerCurrency = grossAmountCustomerCurrency;
            }

            if (documentReferenceNumber != null)
            {
                this.DocumentReferenceNumber = documentReferenceNumber;
            }

        }

        /// <summary>
        /// Statement of account identifier
        /// </summary>
        [JsonProperty("StatementOfAccountId")]
        public int? StatementOfAccountId
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
        /// Statement of account reference
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
        /// Date on which the SOA was generated.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("StatementDate")]
        public string StatementDate
        {
            get
            {
                return this.statementDate;
            }

            set
            {
                this.shouldSerialize["StatementDate"] = true;
                this.statementDate = value;
            }
        }

        /// <summary>
        /// Payment customer id of the customer.
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
        /// Payment customer number.
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
        /// Invoiced amount and due for payment
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
        /// Invoiced amount and overdue for payment.
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
        /// ISO code of SOA currency.
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCode;
            }

            set
            {
                this.shouldSerialize["CurrencyCode"] = true;
                this.currencyCode = value;
            }
        }

        /// <summary>
        /// Symbol of SOA currency.
        /// Example: €
        /// </summary>
        [JsonProperty("CurrencySymbol")]
        public string CurrencySymbol
        {
            get
            {
                return this.currencySymbol;
            }

            set
            {
                this.shouldSerialize["CurrencySymbol"] = true;
                this.currencySymbol = value;
            }
        }

        /// <summary>
        /// Due date for payment. Format: yyyyMMdd
        /// Note:
        /// •	Clients to convert this to appropriate DateTime type.
        /// •	SoA due date is considered as the latest due date of the invoices within the SoA
        /// </summary>
        [JsonProperty("DueDate")]
        public string DueDate
        {
            get
            {
                return this.dueDate;
            }

            set
            {
                this.shouldSerialize["DueDate"] = true;
                this.dueDate = value;
            }
        }

        /// <summary>
        /// ISO code of the country i.e., UK, DE, MY, etc.
        /// This is the value of the first invoice within the SoA. It may not be same for all the invoices within the SoA.
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
        /// Status of the document. Valid values –
        /// 1.	Paid – Fully paid all Invoices with in the SOA.
        /// 2.	Overdue – At least one invoice payment due date is less than current date with in the SOA.
        /// 3.	Due – At least one invoice is due for payment and is within the due date. There is no invoice overdue for payment.
        /// </summary>
        [JsonProperty("Status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["Status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Total gross amount in customer currency.
        /// </summary>
        [JsonProperty("GrossAmountCustomerCurrency")]
        public double? GrossAmountCustomerCurrency
        {
            get
            {
                return this.grossAmountCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["GrossAmountCustomerCurrency"] = true;
                this.grossAmountCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Document reference number fetched
        /// </summary>
        [JsonProperty("DocumentReferenceNumber")]
        public string DocumentReferenceNumber
        {
            get
            {
                return this.documentReferenceNumber;
            }

            set
            {
                this.shouldSerialize["DocumentReferenceNumber"] = true;
                this.documentReferenceNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchStatementOfAccount : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetStatementDate()
        {
            this.shouldSerialize["StatementDate"] = false;
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
        public void UnsetAmountDue()
        {
            this.shouldSerialize["AmountDue"] = false;
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
        public void UnsetCurrencyCode()
        {
            this.shouldSerialize["CurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrencySymbol()
        {
            this.shouldSerialize["CurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDueDate()
        {
            this.shouldSerialize["DueDate"] = false;
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
        public void UnsetStatus()
        {
            this.shouldSerialize["Status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGrossAmountCustomerCurrency()
        {
            this.shouldSerialize["GrossAmountCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentReferenceNumber()
        {
            this.shouldSerialize["DocumentReferenceNumber"] = false;
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
        public bool ShouldSerializeStatementDate()
        {
            return this.shouldSerialize["StatementDate"];
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
        public bool ShouldSerializeAmountDue()
        {
            return this.shouldSerialize["AmountDue"];
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
        public bool ShouldSerializeCurrencyCode()
        {
            return this.shouldSerialize["CurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrencySymbol()
        {
            return this.shouldSerialize["CurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueDate()
        {
            return this.shouldSerialize["DueDate"];
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
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["Status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrossAmountCustomerCurrency()
        {
            return this.shouldSerialize["GrossAmountCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentReferenceNumber()
        {
            return this.shouldSerialize["DocumentReferenceNumber"];
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
            return obj is SearchStatementOfAccount other &&                ((this.StatementOfAccountId == null && other.StatementOfAccountId == null) || (this.StatementOfAccountId?.Equals(other.StatementOfAccountId) == true)) &&
                ((this.SoAReferenceNumber == null && other.SoAReferenceNumber == null) || (this.SoAReferenceNumber?.Equals(other.SoAReferenceNumber) == true)) &&
                ((this.StatementDate == null && other.StatementDate == null) || (this.StatementDate?.Equals(other.StatementDate) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AmountDue == null && other.AmountDue == null) || (this.AmountDue?.Equals(other.AmountDue) == true)) &&
                ((this.AmountOverdue == null && other.AmountOverdue == null) || (this.AmountOverdue?.Equals(other.AmountOverdue) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.DueDate == null && other.DueDate == null) || (this.DueDate?.Equals(other.DueDate) == true)) &&
                ((this.InvoicedOnBehalfOf == null && other.InvoicedOnBehalfOf == null) || (this.InvoicedOnBehalfOf?.Equals(other.InvoicedOnBehalfOf) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.GrossAmountCustomerCurrency == null && other.GrossAmountCustomerCurrency == null) || (this.GrossAmountCustomerCurrency?.Equals(other.GrossAmountCustomerCurrency) == true)) &&
                ((this.DocumentReferenceNumber == null && other.DocumentReferenceNumber == null) || (this.DocumentReferenceNumber?.Equals(other.DocumentReferenceNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.StatementOfAccountId = {(this.StatementOfAccountId == null ? "null" : this.StatementOfAccountId.ToString())}");
            toStringOutput.Add($"this.SoAReferenceNumber = {(this.SoAReferenceNumber == null ? "null" : this.SoAReferenceNumber)}");
            toStringOutput.Add($"this.StatementDate = {(this.StatementDate == null ? "null" : this.StatementDate)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AmountDue = {(this.AmountDue == null ? "null" : this.AmountDue.ToString())}");
            toStringOutput.Add($"this.AmountOverdue = {(this.AmountOverdue == null ? "null" : this.AmountOverdue.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.DueDate = {(this.DueDate == null ? "null" : this.DueDate)}");
            toStringOutput.Add($"this.InvoicedOnBehalfOf = {(this.InvoicedOnBehalfOf == null ? "null" : this.InvoicedOnBehalfOf)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.GrossAmountCustomerCurrency = {(this.GrossAmountCustomerCurrency == null ? "null" : this.GrossAmountCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.DocumentReferenceNumber = {(this.DocumentReferenceNumber == null ? "null" : this.DocumentReferenceNumber)}");
        }
    }
}