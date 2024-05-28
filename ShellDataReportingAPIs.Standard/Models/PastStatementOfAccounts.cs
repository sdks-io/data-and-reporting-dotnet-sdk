// <copyright file="PastStatementOfAccounts.cs" company="APIMatic">
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
    /// PastStatementOfAccounts.
    /// </summary>
    public class PastStatementOfAccounts
    {
        private double? amountDue;
        private double? amountNotOverdue;
        private double? amountOverdue;
        private double? amountOverdueFromUnallocated;
        private double? amountPaid;
        private double? balanceOnThisStatement;
        private string billingCurrencyCode;
        private string billingCurrencySymbol;
        private double? creditLimit;
        private string creditLimitCurrencyCode;
        private string creditLimitCurrencySymbol;
        private double? creditLimitInCustomerCurrency;
        private string currencyCode;
        private string currencySymbol;
        private bool? fullyPaid;
        private string lastPaymentCurrencyCode;
        private string lastPaymentCurrencySymbol;
        private string lastPaymentDate;
        private double? lastPaymentValue;
        private double? outstandingBalance;
        private int? payerId;
        private string payerNumber;
        private string paymentDueDate;
        private string soAReferenceNumber;
        private string statementDate;
        private int? statementOfAccountId;
        private int? totalBillingDocuments;
        private double? totalNetAmountBillingCurrency;
        private double? totalSummaryBillingDocuments;
        private double? totalVATAmountBillingCurrency;
        private double? unallocatedPayment;
        private string localCurrencyCode;
        private string localCurrencySymbol;
        private double? localCurrencyExchangeRate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AmountDue", false },
            { "AmountNotOverdue", false },
            { "AmountOverdue", false },
            { "AmountOverdueFromUnallocated", false },
            { "AmountPaid", false },
            { "BalanceOnThisStatement", false },
            { "BillingCurrencyCode", false },
            { "BillingCurrencySymbol", false },
            { "CreditLimit", false },
            { "CreditLimitCurrencyCode", false },
            { "CreditLimitCurrencySymbol", false },
            { "CreditLimitInCustomerCurrency", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "FullyPaid", false },
            { "LastPaymentCurrencyCode", false },
            { "LastPaymentCurrencySymbol", false },
            { "LastPaymentDate", false },
            { "LastPaymentValue", false },
            { "OutstandingBalance", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PaymentDueDate", false },
            { "SoAReferenceNumber", false },
            { "StatementDate", false },
            { "StatementOfAccountId", false },
            { "TotalBillingDocuments", false },
            { "TotalNetAmountBillingCurrency", false },
            { "TotalSummaryBillingDocuments", false },
            { "TotalVATAmountBillingCurrency", false },
            { "UnallocatedPayment", false },
            { "LocalCurrencyCode", false },
            { "LocalCurrencySymbol", false },
            { "LocalCurrencyExchangeRate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PastStatementOfAccounts"/> class.
        /// </summary>
        public PastStatementOfAccounts()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PastStatementOfAccounts"/> class.
        /// </summary>
        /// <param name="amountDue">AmountDue.</param>
        /// <param name="amountNotOverdue">AmountNotOverdue.</param>
        /// <param name="amountOverdue">AmountOverdue.</param>
        /// <param name="amountOverdueFromUnallocated">AmountOverdueFromUnallocated.</param>
        /// <param name="amountPaid">AmountPaid.</param>
        /// <param name="balanceOnThisStatement">BalanceOnThisStatement.</param>
        /// <param name="billingCurrencyCode">BillingCurrencyCode.</param>
        /// <param name="billingCurrencySymbol">BillingCurrencySymbol.</param>
        /// <param name="creditLimit">CreditLimit.</param>
        /// <param name="creditLimitCurrencyCode">CreditLimitCurrencyCode.</param>
        /// <param name="creditLimitCurrencySymbol">CreditLimitCurrencySymbol.</param>
        /// <param name="creditLimitInCustomerCurrency">CreditLimitInCustomerCurrency.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="fullyPaid">FullyPaid.</param>
        /// <param name="lastPaymentCurrencyCode">LastPaymentCurrencyCode.</param>
        /// <param name="lastPaymentCurrencySymbol">LastPaymentCurrencySymbol.</param>
        /// <param name="lastPaymentDate">LastPaymentDate.</param>
        /// <param name="lastPaymentValue">LastPaymentValue.</param>
        /// <param name="outstandingBalance">OutstandingBalance.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="paymentDueDate">PaymentDueDate.</param>
        /// <param name="soAReferenceNumber">SoAReferenceNumber.</param>
        /// <param name="statementDate">StatementDate.</param>
        /// <param name="statementOfAccountId">StatementOfAccountId.</param>
        /// <param name="totalBillingDocuments">TotalBillingDocuments.</param>
        /// <param name="totalNetAmountBillingCurrency">TotalNetAmountBillingCurrency.</param>
        /// <param name="totalSummaryBillingDocuments">TotalSummaryBillingDocuments.</param>
        /// <param name="totalVATAmountBillingCurrency">TotalVATAmountBillingCurrency.</param>
        /// <param name="unallocatedPayment">UnallocatedPayment.</param>
        /// <param name="localCurrencyCode">LocalCurrencyCode.</param>
        /// <param name="localCurrencySymbol">LocalCurrencySymbol.</param>
        /// <param name="localCurrencyExchangeRate">LocalCurrencyExchangeRate.</param>
        public PastStatementOfAccounts(
            double? amountDue = null,
            double? amountNotOverdue = null,
            double? amountOverdue = null,
            double? amountOverdueFromUnallocated = null,
            double? amountPaid = null,
            double? balanceOnThisStatement = null,
            string billingCurrencyCode = null,
            string billingCurrencySymbol = null,
            double? creditLimit = null,
            string creditLimitCurrencyCode = null,
            string creditLimitCurrencySymbol = null,
            double? creditLimitInCustomerCurrency = null,
            string currencyCode = null,
            string currencySymbol = null,
            bool? fullyPaid = null,
            string lastPaymentCurrencyCode = null,
            string lastPaymentCurrencySymbol = null,
            string lastPaymentDate = null,
            double? lastPaymentValue = null,
            double? outstandingBalance = null,
            int? payerId = null,
            string payerNumber = null,
            string paymentDueDate = null,
            string soAReferenceNumber = null,
            string statementDate = null,
            int? statementOfAccountId = null,
            int? totalBillingDocuments = null,
            double? totalNetAmountBillingCurrency = null,
            double? totalSummaryBillingDocuments = null,
            double? totalVATAmountBillingCurrency = null,
            double? unallocatedPayment = null,
            string localCurrencyCode = null,
            string localCurrencySymbol = null,
            double? localCurrencyExchangeRate = null)
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

            if (amountOverdueFromUnallocated != null)
            {
                this.AmountOverdueFromUnallocated = amountOverdueFromUnallocated;
            }

            if (amountPaid != null)
            {
                this.AmountPaid = amountPaid;
            }

            if (balanceOnThisStatement != null)
            {
                this.BalanceOnThisStatement = balanceOnThisStatement;
            }

            if (billingCurrencyCode != null)
            {
                this.BillingCurrencyCode = billingCurrencyCode;
            }

            if (billingCurrencySymbol != null)
            {
                this.BillingCurrencySymbol = billingCurrencySymbol;
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

            if (fullyPaid != null)
            {
                this.FullyPaid = fullyPaid;
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

            if (totalNetAmountBillingCurrency != null)
            {
                this.TotalNetAmountBillingCurrency = totalNetAmountBillingCurrency;
            }

            if (totalSummaryBillingDocuments != null)
            {
                this.TotalSummaryBillingDocuments = totalSummaryBillingDocuments;
            }

            if (totalVATAmountBillingCurrency != null)
            {
                this.TotalVATAmountBillingCurrency = totalVATAmountBillingCurrency;
            }

            if (unallocatedPayment != null)
            {
                this.UnallocatedPayment = unallocatedPayment;
            }

            if (localCurrencyCode != null)
            {
                this.LocalCurrencyCode = localCurrencyCode;
            }

            if (localCurrencySymbol != null)
            {
                this.LocalCurrencySymbol = localCurrencySymbol;
            }

            if (localCurrencyExchangeRate != null)
            {
                this.LocalCurrencyExchangeRate = localCurrencyExchangeRate;
            }

        }

        /// <summary>
        /// Invoiced amount under this statement of account and due for payment.
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
        /// Total Invoiced amount until this SOA and not overdue for payment.
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
        /// Overdue amount from the previously generated statement of accounts.
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
        /// Overdue amount calculated from unallocated payment.
        /// </summary>
        [JsonProperty("AmountOverdueFromUnallocated")]
        public double? AmountOverdueFromUnallocated
        {
            get
            {
                return this.amountOverdueFromUnallocated;
            }

            set
            {
                this.shouldSerialize["AmountOverdueFromUnallocated"] = true;
                this.amountOverdueFromUnallocated = value;
            }
        }

        /// <summary>
        /// Amount settled for this Statement.
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
        /// Balance amount to be settled on this SOA.
        /// </summary>
        [JsonProperty("BalanceOnThisStatement")]
        public double? BalanceOnThisStatement
        {
            get
            {
                return this.balanceOnThisStatement;
            }

            set
            {
                this.shouldSerialize["BalanceOnThisStatement"] = true;
                this.balanceOnThisStatement = value;
            }
        }

        /// <summary>
        /// Billing currency ISO code.
        /// Example: EUR
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
        /// Credit limit.
        /// </summary>
        [JsonProperty("CreditLimit")]
        public double? CreditLimit
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
        /// Note: For currency details refer the parameters CurrencyCode & CurrencySymbol in the SOADetail response.
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
        /// True If all summary billing documents under this SOA are fully paid (i.e., the fully paid flag is set to true for all documents or the amount allocated is greater than or equal to the amount due under this SOA.
        /// </summary>
        [JsonProperty("FullyPaid")]
        public bool? FullyPaid
        {
            get
            {
                return this.fullyPaid;
            }

            set
            {
                this.shouldSerialize["FullyPaid"] = true;
                this.fullyPaid = value;
            }
        }

        /// <summary>
        /// ISO code of last payment currency.
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
        /// Symbol of last payment currency.
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
        /// Total outstanding balance at the time of this SOA generation.
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
        /// Statement of account reference number.
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
        /// Total number of billing documents generated under this Statement of Account.
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
        /// Total NET amount from all billing documents in this SOA.
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
        /// Total number of summary billing documents for this Statement of Account
        /// </summary>
        [JsonProperty("TotalSummaryBillingDocuments")]
        public double? TotalSummaryBillingDocuments
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
        /// Total VAT amount from all billing documents in this SOA.
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

        /// <summary>
        /// Amount paid but not allocated to any invoices at the time of this SOA generation.
        /// </summary>
        [JsonProperty("UnallocatedPayment")]
        public double? UnallocatedPayment
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

        /// <summary>
        /// Currency ISO code of the local country. It is derived based on CountryCode from microservice configuration. This field is expected to have different value than the previously mentioned field CurrencyCode, only in the case of serviced OUs.
        /// Example: EUR
        /// </summary>
        [JsonProperty("LocalCurrencyCode")]
        public string LocalCurrencyCode
        {
            get
            {
                return this.localCurrencyCode;
            }

            set
            {
                this.shouldSerialize["LocalCurrencyCode"] = true;
                this.localCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency Symbol of the local country. It is derived based on CountryCode from microservice configuration. This field is expected to have different value than the previously mentioned field CurrencySymbol, only in the case of serviced OUs.
        /// Example: €
        /// </summary>
        [JsonProperty("LocalCurrencySymbol")]
        public string LocalCurrencySymbol
        {
            get
            {
                return this.localCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["LocalCurrencySymbol"] = true;
                this.localCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Exchange rate from Billing currency to local currency.
        /// Example: 1.2
        /// </summary>
        [JsonProperty("LocalCurrencyExchangeRate")]
        public double? LocalCurrencyExchangeRate
        {
            get
            {
                return this.localCurrencyExchangeRate;
            }

            set
            {
                this.shouldSerialize["LocalCurrencyExchangeRate"] = true;
                this.localCurrencyExchangeRate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PastStatementOfAccounts : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAmountOverdueFromUnallocated()
        {
            this.shouldSerialize["AmountOverdueFromUnallocated"] = false;
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
        public void UnsetBalanceOnThisStatement()
        {
            this.shouldSerialize["BalanceOnThisStatement"] = false;
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
        public void UnsetFullyPaid()
        {
            this.shouldSerialize["FullyPaid"] = false;
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
        public void UnsetTotalNetAmountBillingCurrency()
        {
            this.shouldSerialize["TotalNetAmountBillingCurrency"] = false;
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
        public void UnsetTotalVATAmountBillingCurrency()
        {
            this.shouldSerialize["TotalVATAmountBillingCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnallocatedPayment()
        {
            this.shouldSerialize["UnallocatedPayment"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocalCurrencyCode()
        {
            this.shouldSerialize["LocalCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocalCurrencySymbol()
        {
            this.shouldSerialize["LocalCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLocalCurrencyExchangeRate()
        {
            this.shouldSerialize["LocalCurrencyExchangeRate"] = false;
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
        public bool ShouldSerializeAmountOverdueFromUnallocated()
        {
            return this.shouldSerialize["AmountOverdueFromUnallocated"];
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
        public bool ShouldSerializeBalanceOnThisStatement()
        {
            return this.shouldSerialize["BalanceOnThisStatement"];
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
        public bool ShouldSerializeFullyPaid()
        {
            return this.shouldSerialize["FullyPaid"];
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
        public bool ShouldSerializeTotalNetAmountBillingCurrency()
        {
            return this.shouldSerialize["TotalNetAmountBillingCurrency"];
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
        public bool ShouldSerializeTotalVATAmountBillingCurrency()
        {
            return this.shouldSerialize["TotalVATAmountBillingCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnallocatedPayment()
        {
            return this.shouldSerialize["UnallocatedPayment"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocalCurrencyCode()
        {
            return this.shouldSerialize["LocalCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocalCurrencySymbol()
        {
            return this.shouldSerialize["LocalCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLocalCurrencyExchangeRate()
        {
            return this.shouldSerialize["LocalCurrencyExchangeRate"];
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
            return obj is PastStatementOfAccounts other &&                ((this.AmountDue == null && other.AmountDue == null) || (this.AmountDue?.Equals(other.AmountDue) == true)) &&
                ((this.AmountNotOverdue == null && other.AmountNotOverdue == null) || (this.AmountNotOverdue?.Equals(other.AmountNotOverdue) == true)) &&
                ((this.AmountOverdue == null && other.AmountOverdue == null) || (this.AmountOverdue?.Equals(other.AmountOverdue) == true)) &&
                ((this.AmountOverdueFromUnallocated == null && other.AmountOverdueFromUnallocated == null) || (this.AmountOverdueFromUnallocated?.Equals(other.AmountOverdueFromUnallocated) == true)) &&
                ((this.AmountPaid == null && other.AmountPaid == null) || (this.AmountPaid?.Equals(other.AmountPaid) == true)) &&
                ((this.BalanceOnThisStatement == null && other.BalanceOnThisStatement == null) || (this.BalanceOnThisStatement?.Equals(other.BalanceOnThisStatement) == true)) &&
                ((this.BillingCurrencyCode == null && other.BillingCurrencyCode == null) || (this.BillingCurrencyCode?.Equals(other.BillingCurrencyCode) == true)) &&
                ((this.BillingCurrencySymbol == null && other.BillingCurrencySymbol == null) || (this.BillingCurrencySymbol?.Equals(other.BillingCurrencySymbol) == true)) &&
                ((this.CreditLimit == null && other.CreditLimit == null) || (this.CreditLimit?.Equals(other.CreditLimit) == true)) &&
                ((this.CreditLimitCurrencyCode == null && other.CreditLimitCurrencyCode == null) || (this.CreditLimitCurrencyCode?.Equals(other.CreditLimitCurrencyCode) == true)) &&
                ((this.CreditLimitCurrencySymbol == null && other.CreditLimitCurrencySymbol == null) || (this.CreditLimitCurrencySymbol?.Equals(other.CreditLimitCurrencySymbol) == true)) &&
                ((this.CreditLimitInCustomerCurrency == null && other.CreditLimitInCustomerCurrency == null) || (this.CreditLimitInCustomerCurrency?.Equals(other.CreditLimitInCustomerCurrency) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.FullyPaid == null && other.FullyPaid == null) || (this.FullyPaid?.Equals(other.FullyPaid) == true)) &&
                ((this.LastPaymentCurrencyCode == null && other.LastPaymentCurrencyCode == null) || (this.LastPaymentCurrencyCode?.Equals(other.LastPaymentCurrencyCode) == true)) &&
                ((this.LastPaymentCurrencySymbol == null && other.LastPaymentCurrencySymbol == null) || (this.LastPaymentCurrencySymbol?.Equals(other.LastPaymentCurrencySymbol) == true)) &&
                ((this.LastPaymentDate == null && other.LastPaymentDate == null) || (this.LastPaymentDate?.Equals(other.LastPaymentDate) == true)) &&
                ((this.LastPaymentValue == null && other.LastPaymentValue == null) || (this.LastPaymentValue?.Equals(other.LastPaymentValue) == true)) &&
                ((this.OutstandingBalance == null && other.OutstandingBalance == null) || (this.OutstandingBalance?.Equals(other.OutstandingBalance) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PaymentDueDate == null && other.PaymentDueDate == null) || (this.PaymentDueDate?.Equals(other.PaymentDueDate) == true)) &&
                ((this.SoAReferenceNumber == null && other.SoAReferenceNumber == null) || (this.SoAReferenceNumber?.Equals(other.SoAReferenceNumber) == true)) &&
                ((this.StatementDate == null && other.StatementDate == null) || (this.StatementDate?.Equals(other.StatementDate) == true)) &&
                ((this.StatementOfAccountId == null && other.StatementOfAccountId == null) || (this.StatementOfAccountId?.Equals(other.StatementOfAccountId) == true)) &&
                ((this.TotalBillingDocuments == null && other.TotalBillingDocuments == null) || (this.TotalBillingDocuments?.Equals(other.TotalBillingDocuments) == true)) &&
                ((this.TotalNetAmountBillingCurrency == null && other.TotalNetAmountBillingCurrency == null) || (this.TotalNetAmountBillingCurrency?.Equals(other.TotalNetAmountBillingCurrency) == true)) &&
                ((this.TotalSummaryBillingDocuments == null && other.TotalSummaryBillingDocuments == null) || (this.TotalSummaryBillingDocuments?.Equals(other.TotalSummaryBillingDocuments) == true)) &&
                ((this.TotalVATAmountBillingCurrency == null && other.TotalVATAmountBillingCurrency == null) || (this.TotalVATAmountBillingCurrency?.Equals(other.TotalVATAmountBillingCurrency) == true)) &&
                ((this.UnallocatedPayment == null && other.UnallocatedPayment == null) || (this.UnallocatedPayment?.Equals(other.UnallocatedPayment) == true)) &&
                ((this.LocalCurrencyCode == null && other.LocalCurrencyCode == null) || (this.LocalCurrencyCode?.Equals(other.LocalCurrencyCode) == true)) &&
                ((this.LocalCurrencySymbol == null && other.LocalCurrencySymbol == null) || (this.LocalCurrencySymbol?.Equals(other.LocalCurrencySymbol) == true)) &&
                ((this.LocalCurrencyExchangeRate == null && other.LocalCurrencyExchangeRate == null) || (this.LocalCurrencyExchangeRate?.Equals(other.LocalCurrencyExchangeRate) == true));
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
            toStringOutput.Add($"this.AmountOverdueFromUnallocated = {(this.AmountOverdueFromUnallocated == null ? "null" : this.AmountOverdueFromUnallocated.ToString())}");
            toStringOutput.Add($"this.AmountPaid = {(this.AmountPaid == null ? "null" : this.AmountPaid.ToString())}");
            toStringOutput.Add($"this.BalanceOnThisStatement = {(this.BalanceOnThisStatement == null ? "null" : this.BalanceOnThisStatement.ToString())}");
            toStringOutput.Add($"this.BillingCurrencyCode = {(this.BillingCurrencyCode == null ? "null" : this.BillingCurrencyCode)}");
            toStringOutput.Add($"this.BillingCurrencySymbol = {(this.BillingCurrencySymbol == null ? "null" : this.BillingCurrencySymbol)}");
            toStringOutput.Add($"this.CreditLimit = {(this.CreditLimit == null ? "null" : this.CreditLimit.ToString())}");
            toStringOutput.Add($"this.CreditLimitCurrencyCode = {(this.CreditLimitCurrencyCode == null ? "null" : this.CreditLimitCurrencyCode)}");
            toStringOutput.Add($"this.CreditLimitCurrencySymbol = {(this.CreditLimitCurrencySymbol == null ? "null" : this.CreditLimitCurrencySymbol)}");
            toStringOutput.Add($"this.CreditLimitInCustomerCurrency = {(this.CreditLimitInCustomerCurrency == null ? "null" : this.CreditLimitInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.FullyPaid = {(this.FullyPaid == null ? "null" : this.FullyPaid.ToString())}");
            toStringOutput.Add($"this.LastPaymentCurrencyCode = {(this.LastPaymentCurrencyCode == null ? "null" : this.LastPaymentCurrencyCode)}");
            toStringOutput.Add($"this.LastPaymentCurrencySymbol = {(this.LastPaymentCurrencySymbol == null ? "null" : this.LastPaymentCurrencySymbol)}");
            toStringOutput.Add($"this.LastPaymentDate = {(this.LastPaymentDate == null ? "null" : this.LastPaymentDate)}");
            toStringOutput.Add($"this.LastPaymentValue = {(this.LastPaymentValue == null ? "null" : this.LastPaymentValue.ToString())}");
            toStringOutput.Add($"this.OutstandingBalance = {(this.OutstandingBalance == null ? "null" : this.OutstandingBalance.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PaymentDueDate = {(this.PaymentDueDate == null ? "null" : this.PaymentDueDate)}");
            toStringOutput.Add($"this.SoAReferenceNumber = {(this.SoAReferenceNumber == null ? "null" : this.SoAReferenceNumber)}");
            toStringOutput.Add($"this.StatementDate = {(this.StatementDate == null ? "null" : this.StatementDate)}");
            toStringOutput.Add($"this.StatementOfAccountId = {(this.StatementOfAccountId == null ? "null" : this.StatementOfAccountId.ToString())}");
            toStringOutput.Add($"this.TotalBillingDocuments = {(this.TotalBillingDocuments == null ? "null" : this.TotalBillingDocuments.ToString())}");
            toStringOutput.Add($"this.TotalNetAmountBillingCurrency = {(this.TotalNetAmountBillingCurrency == null ? "null" : this.TotalNetAmountBillingCurrency.ToString())}");
            toStringOutput.Add($"this.TotalSummaryBillingDocuments = {(this.TotalSummaryBillingDocuments == null ? "null" : this.TotalSummaryBillingDocuments.ToString())}");
            toStringOutput.Add($"this.TotalVATAmountBillingCurrency = {(this.TotalVATAmountBillingCurrency == null ? "null" : this.TotalVATAmountBillingCurrency.ToString())}");
            toStringOutput.Add($"this.UnallocatedPayment = {(this.UnallocatedPayment == null ? "null" : this.UnallocatedPayment.ToString())}");
            toStringOutput.Add($"this.LocalCurrencyCode = {(this.LocalCurrencyCode == null ? "null" : this.LocalCurrencyCode)}");
            toStringOutput.Add($"this.LocalCurrencySymbol = {(this.LocalCurrencySymbol == null ? "null" : this.LocalCurrencySymbol)}");
            toStringOutput.Add($"this.LocalCurrencyExchangeRate = {(this.LocalCurrencyExchangeRate == null ? "null" : this.LocalCurrencyExchangeRate.ToString())}");
        }
    }
}