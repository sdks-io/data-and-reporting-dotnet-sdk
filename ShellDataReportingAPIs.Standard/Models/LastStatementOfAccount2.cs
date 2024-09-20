// <copyright file="LastStatementOfAccount2.cs" company="APIMatic">
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
    /// LastStatementOfAccount2.
    /// </summary>
    public class LastStatementOfAccount2
    {
        private double? amountDue;
        private double? amountNotOverdue;
        private double? amountOverdue;
        private int? creditLimit;
        private string creditLimitCurrencyCode;
        private string creditLimitCurrencySymbol;
        private double? creditLimitInCustomerCurrency;
        private string currencyCode;
        private string currencySymbol;
        private string lastPaymentCurrencyCode;
        private string lastPaymentCurrencySymbol;
        private string lastPaymentDate;
        private double? lastPaymentValue;
        private double? outstandingBalance;
        private int? payerId;
        private string payerNumber;
        private string paymentDueDate;
        private string paymentMethod;
        private int? paymentMethodId;
        private string paymentTerms;
        private int? paymentTermsId;
        private string soAReferenceNumber;
        private string statementDate;
        private int? statementOfAccountId;
        private int? totalBillingDocuments;
        private int? totalSummaryBillingDocuments;
        private int? unallocatedPayment;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AmountDue", false },
            { "AmountNotOverdue", false },
            { "AmountOverdue", false },
            { "CreditLimit", false },
            { "CreditLimitCurrencyCode", false },
            { "CreditLimitCurrencySymbol", false },
            { "CreditLimitInCustomerCurrency", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "LastPaymentCurrencyCode", false },
            { "LastPaymentCurrencySymbol", false },
            { "LastPaymentDate", false },
            { "LastPaymentValue", false },
            { "OutstandingBalance", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PaymentDueDate", false },
            { "PaymentMethod", false },
            { "PaymentMethodId", false },
            { "PaymentTerms", false },
            { "PaymentTermsId", false },
            { "SoAReferenceNumber", false },
            { "StatementDate", false },
            { "StatementOfAccountId", false },
            { "TotalBillingDocuments", false },
            { "TotalSummaryBillingDocuments", false },
            { "UnallocatedPayment", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LastStatementOfAccount2"/> class.
        /// </summary>
        public LastStatementOfAccount2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastStatementOfAccount2"/> class.
        /// </summary>
        /// <param name="amountDue">AmountDue.</param>
        /// <param name="amountNotOverdue">AmountNotOverdue.</param>
        /// <param name="amountOverdue">AmountOverdue.</param>
        /// <param name="creditLimit">CreditLimit.</param>
        /// <param name="creditLimitCurrencyCode">CreditLimitCurrencyCode.</param>
        /// <param name="creditLimitCurrencySymbol">CreditLimitCurrencySymbol.</param>
        /// <param name="creditLimitInCustomerCurrency">CreditLimitInCustomerCurrency.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="lastPaymentCurrencyCode">LastPaymentCurrencyCode.</param>
        /// <param name="lastPaymentCurrencySymbol">LastPaymentCurrencySymbol.</param>
        /// <param name="lastPaymentDate">LastPaymentDate.</param>
        /// <param name="lastPaymentValue">LastPaymentValue.</param>
        /// <param name="outstandingBalance">OutstandingBalance.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="paymentDueDate">PaymentDueDate.</param>
        /// <param name="paymentMethod">PaymentMethod.</param>
        /// <param name="paymentMethodId">PaymentMethodId.</param>
        /// <param name="paymentTerms">PaymentTerms.</param>
        /// <param name="paymentTermsId">PaymentTermsId.</param>
        /// <param name="soAReferenceNumber">SoAReferenceNumber.</param>
        /// <param name="statementDate">StatementDate.</param>
        /// <param name="statementOfAccountId">StatementOfAccountId.</param>
        /// <param name="totalBillingDocuments">TotalBillingDocuments.</param>
        /// <param name="totalSummaryBillingDocuments">TotalSummaryBillingDocuments.</param>
        /// <param name="unallocatedPayment">UnallocatedPayment.</param>
        public LastStatementOfAccount2(
            double? amountDue = null,
            double? amountNotOverdue = null,
            double? amountOverdue = null,
            int? creditLimit = null,
            string creditLimitCurrencyCode = null,
            string creditLimitCurrencySymbol = null,
            double? creditLimitInCustomerCurrency = null,
            string currencyCode = null,
            string currencySymbol = null,
            string lastPaymentCurrencyCode = null,
            string lastPaymentCurrencySymbol = null,
            string lastPaymentDate = null,
            double? lastPaymentValue = null,
            double? outstandingBalance = null,
            int? payerId = null,
            string payerNumber = null,
            string paymentDueDate = null,
            string paymentMethod = null,
            int? paymentMethodId = null,
            string paymentTerms = null,
            int? paymentTermsId = null,
            string soAReferenceNumber = null,
            string statementDate = null,
            int? statementOfAccountId = null,
            int? totalBillingDocuments = null,
            int? totalSummaryBillingDocuments = null,
            int? unallocatedPayment = null)
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

            if (creditLimit != null)
            {
                this.CreditLimit = creditLimit;
            }

            if (creditLimitCurrencyCode != null)
            {
                this.CreditLimitCurrencyCode = creditLimitCurrencyCode;
            }

            if (creditLimitCurrencySymbol != null)
            {
                this.CreditLimitCurrencySymbol = creditLimitCurrencySymbol;
            }

            if (creditLimitInCustomerCurrency != null)
            {
                this.CreditLimitInCustomerCurrency = creditLimitInCustomerCurrency;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (lastPaymentCurrencyCode != null)
            {
                this.LastPaymentCurrencyCode = lastPaymentCurrencyCode;
            }

            if (lastPaymentCurrencySymbol != null)
            {
                this.LastPaymentCurrencySymbol = lastPaymentCurrencySymbol;
            }

            if (lastPaymentDate != null)
            {
                this.LastPaymentDate = lastPaymentDate;
            }

            if (lastPaymentValue != null)
            {
                this.LastPaymentValue = lastPaymentValue;
            }

            if (outstandingBalance != null)
            {
                this.OutstandingBalance = outstandingBalance;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (paymentDueDate != null)
            {
                this.PaymentDueDate = paymentDueDate;
            }

            if (paymentMethod != null)
            {
                this.PaymentMethod = paymentMethod;
            }

            if (paymentMethodId != null)
            {
                this.PaymentMethodId = paymentMethodId;
            }

            if (paymentTerms != null)
            {
                this.PaymentTerms = paymentTerms;
            }

            if (paymentTermsId != null)
            {
                this.PaymentTermsId = paymentTermsId;
            }

            if (soAReferenceNumber != null)
            {
                this.SoAReferenceNumber = soAReferenceNumber;
            }

            if (statementDate != null)
            {
                this.StatementDate = statementDate;
            }

            if (statementOfAccountId != null)
            {
                this.StatementOfAccountId = statementOfAccountId;
            }

            if (totalBillingDocuments != null)
            {
                this.TotalBillingDocuments = totalBillingDocuments;
            }

            if (totalSummaryBillingDocuments != null)
            {
                this.TotalSummaryBillingDocuments = totalSummaryBillingDocuments;
            }

            if (unallocatedPayment != null)
            {
                this.UnallocatedPayment = unallocatedPayment;
            }

        }

        /// <summary>
        /// Invoiced amount and due for payment.
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
        /// Invoiced amount and not overdue for payment.
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
        /// Credit limit.
        /// </summary>
        [JsonProperty("CreditLimit")]
        public int? CreditLimit
        {
            get
            {
                return this.creditLimit;
            }

            set
            {
                this.shouldSerialize["CreditLimit"] = true;
                this.creditLimit = value;
            }
        }

        /// <summary>
        /// ISO code of the credit limit’s currency.
        /// Example: EUR
        /// </summary>
        [JsonProperty("CreditLimitCurrencyCode")]
        public string CreditLimitCurrencyCode
        {
            get
            {
                return this.creditLimitCurrencyCode;
            }

            set
            {
                this.shouldSerialize["CreditLimitCurrencyCode"] = true;
                this.creditLimitCurrencyCode = value;
            }
        }

        /// <summary>
        /// Symbol of the credit limit’s currency.
        /// Example: €
        /// </summary>
        [JsonProperty("CreditLimitCurrencySymbol")]
        public string CreditLimitCurrencySymbol
        {
            get
            {
                return this.creditLimitCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["CreditLimitCurrencySymbol"] = true;
                this.creditLimitCurrencySymbol = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Credit limit in Customer currency.
        /// **Note**: For currency details refer the parameters CurrencyCode & CurrencySymbol in the StatementOfAccount response.
        /// ]]>
        /// </summary>
        [JsonProperty("CreditLimitInCustomerCurrency")]
        public double? CreditLimitInCustomerCurrency
        {
            get
            {
                return this.creditLimitInCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["CreditLimitInCustomerCurrency"] = true;
                this.creditLimitInCustomerCurrency = value;
            }
        }

        /// <summary>
        /// ISO code of SOA currency.
        /// Example: EUR
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
        /// ISO code of Last Payment currency.
        /// Example: EUR
        /// </summary>
        [JsonProperty("LastPaymentCurrencyCode")]
        public string LastPaymentCurrencyCode
        {
            get
            {
                return this.lastPaymentCurrencyCode;
            }

            set
            {
                this.shouldSerialize["LastPaymentCurrencyCode"] = true;
                this.lastPaymentCurrencyCode = value;
            }
        }

        /// <summary>
        /// Symbol of Last Payment currency.
        /// Example: €
        /// </summary>
        [JsonProperty("LastPaymentCurrencySymbol")]
        public string LastPaymentCurrencySymbol
        {
            get
            {
                return this.lastPaymentCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["LastPaymentCurrencySymbol"] = true;
                this.lastPaymentCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Last payment date. Format: yyyyMMdd
        /// </summary>
        [JsonProperty("LastPaymentDate")]
        public string LastPaymentDate
        {
            get
            {
                return this.lastPaymentDate;
            }

            set
            {
                this.shouldSerialize["LastPaymentDate"] = true;
                this.lastPaymentDate = value;
            }
        }

        /// <summary>
        /// Last payment value.
        /// </summary>
        [JsonProperty("LastPaymentValue")]
        public double? LastPaymentValue
        {
            get
            {
                return this.lastPaymentValue;
            }

            set
            {
                this.shouldSerialize["LastPaymentValue"] = true;
                this.lastPaymentValue = value;
            }
        }

        /// <summary>
        /// Current outstanding balance amount.
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
        /// Due date for payment. Format: yyyyMMdd
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
        /// <![CDATA[
        /// Payment method description of the Payer.
        /// Example: Id & Description
        /// •    Incoming - Direct Debit
        /// •    Incoming - Cheque
        /// •    Incoming - Direct Debit A
        /// •    Incoming - Bank Transfer
        /// •    Incoming - Cash
        /// ]]>
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod
        {
            get
            {
                return this.paymentMethod;
            }

            set
            {
                this.shouldSerialize["PaymentMethod"] = true;
                this.paymentMethod = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Payment method Id of the Payer.
        /// Example: Id & Description
        /// •    Incoming - Direct Debit
        /// •    Incoming - Cheque
        /// •    Incoming - Direct Debit A
        /// •    Incoming - Bank Transfer
        /// •    Incoming - Cash
        /// ]]>
        /// </summary>
        [JsonProperty("PaymentMethodId")]
        public int? PaymentMethodId
        {
            get
            {
                return this.paymentMethodId;
            }

            set
            {
                this.shouldSerialize["PaymentMethodId"] = true;
                this.paymentMethodId = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Payment terms description of the Payer.
        /// Example: Id & Description
        /// •    14 days after Invoice
        /// •    15 days after Invoice
        /// •    21 days after Invoice
        /// •    30 days after Invoice
        /// •    45 days after Invoice
        /// •    0 days after invoice
        /// •    days after invoice
        /// •    days after invoice
        /// •    7 days after invoice
        /// •    10th of the following month
        /// ]]>
        /// </summary>
        [JsonProperty("PaymentTerms")]
        public string PaymentTerms
        {
            get
            {
                return this.paymentTerms;
            }

            set
            {
                this.shouldSerialize["PaymentTerms"] = true;
                this.paymentTerms = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Payment terms Id of the Payer.
        /// Example: Id & Description
        /// •    14 days after Invoice
        /// •    15 days after Invoice
        /// •    21 days after Invoice
        /// •    30 days after Invoice
        /// •    45 days after Invoice
        /// •    0 days after invoice
        /// •    days after invoice
        /// •    days after invoice
        /// •    7 days after invoice
        /// •    10th of the following month
        /// ]]>
        /// </summary>
        [JsonProperty("PaymentTermsId")]
        public int? PaymentTermsId
        {
            get
            {
                return this.paymentTermsId;
            }

            set
            {
                this.shouldSerialize["PaymentTermsId"] = true;
                this.paymentTermsId = value;
            }
        }

        /// <summary>
        /// Statement of account reference number
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
        /// Statement of account identifier,
        /// Example: 1
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
        /// Total number of billing documents for this Statement of Account
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
        /// Total number of summary billing documents for this Statement of Account
        /// </summary>
        [JsonProperty("TotalSummaryBillingDocuments")]
        public int? TotalSummaryBillingDocuments
        {
            get
            {
                return this.totalSummaryBillingDocuments;
            }

            set
            {
                this.shouldSerialize["TotalSummaryBillingDocuments"] = true;
                this.totalSummaryBillingDocuments = value;
            }
        }

        /// <summary>
        /// Unallocated payment.
        /// When negative, indicates overdue amount.
        /// </summary>
        [JsonProperty("UnallocatedPayment")]
        public int? UnallocatedPayment
        {
            get
            {
                return this.unallocatedPayment;
            }

            set
            {
                this.shouldSerialize["UnallocatedPayment"] = true;
                this.unallocatedPayment = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LastStatementOfAccount2 : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCreditLimit()
        {
            this.shouldSerialize["CreditLimit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditLimitCurrencyCode()
        {
            this.shouldSerialize["CreditLimitCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditLimitCurrencySymbol()
        {
            this.shouldSerialize["CreditLimitCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditLimitInCustomerCurrency()
        {
            this.shouldSerialize["CreditLimitInCustomerCurrency"] = false;
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
        public void UnsetLastPaymentCurrencyCode()
        {
            this.shouldSerialize["LastPaymentCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastPaymentCurrencySymbol()
        {
            this.shouldSerialize["LastPaymentCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastPaymentDate()
        {
            this.shouldSerialize["LastPaymentDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastPaymentValue()
        {
            this.shouldSerialize["LastPaymentValue"] = false;
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
        public void UnsetPaymentDueDate()
        {
            this.shouldSerialize["PaymentDueDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentMethod()
        {
            this.shouldSerialize["PaymentMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentMethodId()
        {
            this.shouldSerialize["PaymentMethodId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentTerms()
        {
            this.shouldSerialize["PaymentTerms"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentTermsId()
        {
            this.shouldSerialize["PaymentTermsId"] = false;
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
        public void UnsetStatementOfAccountId()
        {
            this.shouldSerialize["StatementOfAccountId"] = false;
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
        public void UnsetTotalSummaryBillingDocuments()
        {
            this.shouldSerialize["TotalSummaryBillingDocuments"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnallocatedPayment()
        {
            this.shouldSerialize["UnallocatedPayment"] = false;
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
        public bool ShouldSerializeCreditLimit()
        {
            return this.shouldSerialize["CreditLimit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditLimitCurrencyCode()
        {
            return this.shouldSerialize["CreditLimitCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditLimitCurrencySymbol()
        {
            return this.shouldSerialize["CreditLimitCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditLimitInCustomerCurrency()
        {
            return this.shouldSerialize["CreditLimitInCustomerCurrency"];
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
        public bool ShouldSerializeLastPaymentCurrencyCode()
        {
            return this.shouldSerialize["LastPaymentCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastPaymentCurrencySymbol()
        {
            return this.shouldSerialize["LastPaymentCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastPaymentDate()
        {
            return this.shouldSerialize["LastPaymentDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastPaymentValue()
        {
            return this.shouldSerialize["LastPaymentValue"];
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
        public bool ShouldSerializePaymentDueDate()
        {
            return this.shouldSerialize["PaymentDueDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMethod()
        {
            return this.shouldSerialize["PaymentMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMethodId()
        {
            return this.shouldSerialize["PaymentMethodId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentTerms()
        {
            return this.shouldSerialize["PaymentTerms"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentTermsId()
        {
            return this.shouldSerialize["PaymentTermsId"];
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
        public bool ShouldSerializeStatementOfAccountId()
        {
            return this.shouldSerialize["StatementOfAccountId"];
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
        public bool ShouldSerializeTotalSummaryBillingDocuments()
        {
            return this.shouldSerialize["TotalSummaryBillingDocuments"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnallocatedPayment()
        {
            return this.shouldSerialize["UnallocatedPayment"];
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
            return obj is LastStatementOfAccount2 other &&                ((this.AmountDue == null && other.AmountDue == null) || (this.AmountDue?.Equals(other.AmountDue) == true)) &&
                ((this.AmountNotOverdue == null && other.AmountNotOverdue == null) || (this.AmountNotOverdue?.Equals(other.AmountNotOverdue) == true)) &&
                ((this.AmountOverdue == null && other.AmountOverdue == null) || (this.AmountOverdue?.Equals(other.AmountOverdue) == true)) &&
                ((this.CreditLimit == null && other.CreditLimit == null) || (this.CreditLimit?.Equals(other.CreditLimit) == true)) &&
                ((this.CreditLimitCurrencyCode == null && other.CreditLimitCurrencyCode == null) || (this.CreditLimitCurrencyCode?.Equals(other.CreditLimitCurrencyCode) == true)) &&
                ((this.CreditLimitCurrencySymbol == null && other.CreditLimitCurrencySymbol == null) || (this.CreditLimitCurrencySymbol?.Equals(other.CreditLimitCurrencySymbol) == true)) &&
                ((this.CreditLimitInCustomerCurrency == null && other.CreditLimitInCustomerCurrency == null) || (this.CreditLimitInCustomerCurrency?.Equals(other.CreditLimitInCustomerCurrency) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.LastPaymentCurrencyCode == null && other.LastPaymentCurrencyCode == null) || (this.LastPaymentCurrencyCode?.Equals(other.LastPaymentCurrencyCode) == true)) &&
                ((this.LastPaymentCurrencySymbol == null && other.LastPaymentCurrencySymbol == null) || (this.LastPaymentCurrencySymbol?.Equals(other.LastPaymentCurrencySymbol) == true)) &&
                ((this.LastPaymentDate == null && other.LastPaymentDate == null) || (this.LastPaymentDate?.Equals(other.LastPaymentDate) == true)) &&
                ((this.LastPaymentValue == null && other.LastPaymentValue == null) || (this.LastPaymentValue?.Equals(other.LastPaymentValue) == true)) &&
                ((this.OutstandingBalance == null && other.OutstandingBalance == null) || (this.OutstandingBalance?.Equals(other.OutstandingBalance) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PaymentDueDate == null && other.PaymentDueDate == null) || (this.PaymentDueDate?.Equals(other.PaymentDueDate) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.PaymentMethodId == null && other.PaymentMethodId == null) || (this.PaymentMethodId?.Equals(other.PaymentMethodId) == true)) &&
                ((this.PaymentTerms == null && other.PaymentTerms == null) || (this.PaymentTerms?.Equals(other.PaymentTerms) == true)) &&
                ((this.PaymentTermsId == null && other.PaymentTermsId == null) || (this.PaymentTermsId?.Equals(other.PaymentTermsId) == true)) &&
                ((this.SoAReferenceNumber == null && other.SoAReferenceNumber == null) || (this.SoAReferenceNumber?.Equals(other.SoAReferenceNumber) == true)) &&
                ((this.StatementDate == null && other.StatementDate == null) || (this.StatementDate?.Equals(other.StatementDate) == true)) &&
                ((this.StatementOfAccountId == null && other.StatementOfAccountId == null) || (this.StatementOfAccountId?.Equals(other.StatementOfAccountId) == true)) &&
                ((this.TotalBillingDocuments == null && other.TotalBillingDocuments == null) || (this.TotalBillingDocuments?.Equals(other.TotalBillingDocuments) == true)) &&
                ((this.TotalSummaryBillingDocuments == null && other.TotalSummaryBillingDocuments == null) || (this.TotalSummaryBillingDocuments?.Equals(other.TotalSummaryBillingDocuments) == true)) &&
                ((this.UnallocatedPayment == null && other.UnallocatedPayment == null) || (this.UnallocatedPayment?.Equals(other.UnallocatedPayment) == true));
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
            toStringOutput.Add($"this.CreditLimit = {(this.CreditLimit == null ? "null" : this.CreditLimit.ToString())}");
            toStringOutput.Add($"this.CreditLimitCurrencyCode = {(this.CreditLimitCurrencyCode == null ? "null" : this.CreditLimitCurrencyCode)}");
            toStringOutput.Add($"this.CreditLimitCurrencySymbol = {(this.CreditLimitCurrencySymbol == null ? "null" : this.CreditLimitCurrencySymbol)}");
            toStringOutput.Add($"this.CreditLimitInCustomerCurrency = {(this.CreditLimitInCustomerCurrency == null ? "null" : this.CreditLimitInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.LastPaymentCurrencyCode = {(this.LastPaymentCurrencyCode == null ? "null" : this.LastPaymentCurrencyCode)}");
            toStringOutput.Add($"this.LastPaymentCurrencySymbol = {(this.LastPaymentCurrencySymbol == null ? "null" : this.LastPaymentCurrencySymbol)}");
            toStringOutput.Add($"this.LastPaymentDate = {(this.LastPaymentDate == null ? "null" : this.LastPaymentDate)}");
            toStringOutput.Add($"this.LastPaymentValue = {(this.LastPaymentValue == null ? "null" : this.LastPaymentValue.ToString())}");
            toStringOutput.Add($"this.OutstandingBalance = {(this.OutstandingBalance == null ? "null" : this.OutstandingBalance.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PaymentDueDate = {(this.PaymentDueDate == null ? "null" : this.PaymentDueDate)}");
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod)}");
            toStringOutput.Add($"this.PaymentMethodId = {(this.PaymentMethodId == null ? "null" : this.PaymentMethodId.ToString())}");
            toStringOutput.Add($"this.PaymentTerms = {(this.PaymentTerms == null ? "null" : this.PaymentTerms)}");
            toStringOutput.Add($"this.PaymentTermsId = {(this.PaymentTermsId == null ? "null" : this.PaymentTermsId.ToString())}");
            toStringOutput.Add($"this.SoAReferenceNumber = {(this.SoAReferenceNumber == null ? "null" : this.SoAReferenceNumber)}");
            toStringOutput.Add($"this.StatementDate = {(this.StatementDate == null ? "null" : this.StatementDate)}");
            toStringOutput.Add($"this.StatementOfAccountId = {(this.StatementOfAccountId == null ? "null" : this.StatementOfAccountId.ToString())}");
            toStringOutput.Add($"this.TotalBillingDocuments = {(this.TotalBillingDocuments == null ? "null" : this.TotalBillingDocuments.ToString())}");
            toStringOutput.Add($"this.TotalSummaryBillingDocuments = {(this.TotalSummaryBillingDocuments == null ? "null" : this.TotalSummaryBillingDocuments.ToString())}");
            toStringOutput.Add($"this.UnallocatedPayment = {(this.UnallocatedPayment == null ? "null" : this.UnallocatedPayment.ToString())}");
        }
    }
}