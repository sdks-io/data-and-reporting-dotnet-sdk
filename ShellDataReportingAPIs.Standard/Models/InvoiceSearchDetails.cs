// <copyright file="InvoiceSearchDetails.cs" company="APIMatic">
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
    /// InvoiceSearchDetails.
    /// </summary>
    public class InvoiceSearchDetails
    {
        private string accountFullName;
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private int? colCoId;
        private string colCoOpCoId;
        private string currentBillingFrequency;
        private int? currentBillingFrequencyId;
        private string currentDistributionMethod;
        private int? currentDistributionMethodId;
        private string customerCurrencyCode;
        private string customerCurrencySymbol;
        private string delCoClientNumber;
        private int? delCoId;
        private string delCoOpCoId;
        private string documentType;
        private int? documentTypeId;
        private string dueDate;
        private double? grossAmountCustomerCurrency;
        private double? grossAmountTransactionCurrency;
        private string invoiceDate;
        private string invoicedBy;
        private string invoicedOnBehalfOf;
        private int? invoiceId;
        private string invoiceNumber;
        private bool? isInternational;
        private bool? isNational;
        private double? netAmountCustomerCurrency;
        private double? netAmountTransactionCurrency;
        private int? payerId;
        private string payerNumber;
        private string paymentTerms;
        private int? paymentTermsId;
        private int? replacementInvoiceId;
        private int? reversalInvoiceId;
        private string status;
        private string summaryDocumentBillingType;
        private int? summaryDocumentBillingTypeId;
        private string summaryDocumentDate;
        private double? summaryDocumentDDAmount;
        private string summaryDocumentDueDate;
        private int? summaryDocumentId;
        private bool? summaryDocumentIsFullyPaid;
        private string summaryDocumentNumber;
        private double? summaryDocumentPaidAmount;
        private string summaryDocumentSoAReferenceNumber;
        private int? summaryDocumentStatementOfAccountId;
        private string transactionCurrencyCode;
        private string transactionCurrencySymbol;
        private string type;
        private int? typeId;
        private double? vATAmountCustomerCurrency;
        private double? vATAmountTransactionCurrency;
        private string vATCountry;
        private int? vATCountryId;
        private string vATCountryISOCode;
        private string vATCountryOpCoId;
        private string documentReference;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountFullName", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "ColCoId", false },
            { "ColCoOpCoId", false },
            { "CurrentBillingFrequency", false },
            { "CurrentBillingFrequencyId", false },
            { "CurrentDistributionMethod", false },
            { "CurrentDistributionMethodId", false },
            { "CustomerCurrencyCode", false },
            { "CustomerCurrencySymbol", false },
            { "DelCoClientNumber", false },
            { "DelCoId", false },
            { "DelCoOpCoId", false },
            { "DocumentType", false },
            { "DocumentTypeId", false },
            { "DueDate", false },
            { "GrossAmountCustomerCurrency", false },
            { "GrossAmountTransactionCurrency", false },
            { "InvoiceDate", false },
            { "InvoicedBy", false },
            { "InvoicedOnBehalfOf", false },
            { "InvoiceId", false },
            { "InvoiceNumber", false },
            { "IsInternational", false },
            { "IsNational", false },
            { "NetAmountCustomerCurrency", false },
            { "NetAmountTransactionCurrency", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PaymentTerms", false },
            { "PaymentTermsId", false },
            { "ReplacementInvoiceId", false },
            { "ReversalInvoiceId", false },
            { "Status", false },
            { "SummaryDocumentBillingType", false },
            { "SummaryDocumentBillingTypeId", false },
            { "SummaryDocumentDate", false },
            { "SummaryDocumentDDAmount", false },
            { "SummaryDocumentDueDate", false },
            { "SummaryDocumentId", false },
            { "SummaryDocumentIsFullyPaid", false },
            { "SummaryDocumentNumber", false },
            { "SummaryDocumentPaidAmount", false },
            { "SummaryDocumentSoAReferenceNumber", false },
            { "SummaryDocumentStatementOfAccountId", false },
            { "TransactionCurrencyCode", false },
            { "TransactionCurrencySymbol", false },
            { "Type", false },
            { "TypeId", false },
            { "VATAmountCustomerCurrency", false },
            { "VATAmountTransactionCurrency", false },
            { "VATCountry", false },
            { "VATCountryId", false },
            { "VATCountryISOCode", false },
            { "VATCountryOpCoId", false },
            { "DocumentReference", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchDetails"/> class.
        /// </summary>
        public InvoiceSearchDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchDetails"/> class.
        /// </summary>
        /// <param name="accountFullName">AccountFullName.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoOpCoId">ColCoOpCoId.</param>
        /// <param name="currentBillingFrequency">CurrentBillingFrequency.</param>
        /// <param name="currentBillingFrequencyId">CurrentBillingFrequencyId.</param>
        /// <param name="currentDistributionMethod">CurrentDistributionMethod.</param>
        /// <param name="currentDistributionMethodId">CurrentDistributionMethodId.</param>
        /// <param name="customerCurrencyCode">CustomerCurrencyCode.</param>
        /// <param name="customerCurrencySymbol">CustomerCurrencySymbol.</param>
        /// <param name="delCoClientNumber">DelCoClientNumber.</param>
        /// <param name="delCoId">DelCoId.</param>
        /// <param name="delCoOpCoId">DelCoOpCoId.</param>
        /// <param name="documentType">DocumentType.</param>
        /// <param name="documentTypeId">DocumentTypeId.</param>
        /// <param name="dueDate">DueDate.</param>
        /// <param name="grossAmountCustomerCurrency">GrossAmountCustomerCurrency.</param>
        /// <param name="grossAmountTransactionCurrency">GrossAmountTransactionCurrency.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="invoicedBy">InvoicedBy.</param>
        /// <param name="invoicedOnBehalfOf">InvoicedOnBehalfOf.</param>
        /// <param name="invoiceId">InvoiceId.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="isInternational">IsInternational.</param>
        /// <param name="isNational">IsNational.</param>
        /// <param name="netAmountCustomerCurrency">NetAmountCustomerCurrency.</param>
        /// <param name="netAmountTransactionCurrency">NetAmountTransactionCurrency.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="paymentTerms">PaymentTerms.</param>
        /// <param name="paymentTermsId">PaymentTermsId.</param>
        /// <param name="replacementInvoiceId">ReplacementInvoiceId.</param>
        /// <param name="reversalInvoiceId">ReversalInvoiceId.</param>
        /// <param name="status">Status.</param>
        /// <param name="summaryDocumentBillingType">SummaryDocumentBillingType.</param>
        /// <param name="summaryDocumentBillingTypeId">SummaryDocumentBillingTypeId.</param>
        /// <param name="summaryDocumentDate">SummaryDocumentDate.</param>
        /// <param name="summaryDocumentDDAmount">SummaryDocumentDDAmount.</param>
        /// <param name="summaryDocumentDueDate">SummaryDocumentDueDate.</param>
        /// <param name="summaryDocumentId">SummaryDocumentId.</param>
        /// <param name="summaryDocumentIsFullyPaid">SummaryDocumentIsFullyPaid.</param>
        /// <param name="summaryDocumentNumber">SummaryDocumentNumber.</param>
        /// <param name="summaryDocumentPaidAmount">SummaryDocumentPaidAmount.</param>
        /// <param name="summaryDocumentSoAReferenceNumber">SummaryDocumentSoAReferenceNumber.</param>
        /// <param name="summaryDocumentStatementOfAccountId">SummaryDocumentStatementOfAccountId.</param>
        /// <param name="transactionCurrencyCode">TransactionCurrencyCode.</param>
        /// <param name="transactionCurrencySymbol">TransactionCurrencySymbol.</param>
        /// <param name="type">Type.</param>
        /// <param name="typeId">TypeId.</param>
        /// <param name="vATAmountCustomerCurrency">VATAmountCustomerCurrency.</param>
        /// <param name="vATAmountTransactionCurrency">VATAmountTransactionCurrency.</param>
        /// <param name="vATCountry">VATCountry.</param>
        /// <param name="vATCountryId">VATCountryId.</param>
        /// <param name="vATCountryISOCode">VATCountryISOCode.</param>
        /// <param name="vATCountryOpCoId">VATCountryOpCoId.</param>
        /// <param name="documentReference">DocumentReference.</param>
        /// <param name="additionalDocuments">AdditionalDocuments.</param>
        public InvoiceSearchDetails(
            string accountFullName = null,
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            int? colCoId = null,
            string colCoOpCoId = null,
            string currentBillingFrequency = null,
            int? currentBillingFrequencyId = null,
            string currentDistributionMethod = null,
            int? currentDistributionMethodId = null,
            string customerCurrencyCode = null,
            string customerCurrencySymbol = null,
            string delCoClientNumber = null,
            int? delCoId = null,
            string delCoOpCoId = null,
            string documentType = null,
            int? documentTypeId = null,
            string dueDate = null,
            double? grossAmountCustomerCurrency = null,
            double? grossAmountTransactionCurrency = null,
            string invoiceDate = null,
            string invoicedBy = null,
            string invoicedOnBehalfOf = null,
            int? invoiceId = null,
            string invoiceNumber = null,
            bool? isInternational = null,
            bool? isNational = null,
            double? netAmountCustomerCurrency = null,
            double? netAmountTransactionCurrency = null,
            int? payerId = null,
            string payerNumber = null,
            string paymentTerms = null,
            int? paymentTermsId = null,
            int? replacementInvoiceId = null,
            int? reversalInvoiceId = null,
            string status = null,
            string summaryDocumentBillingType = null,
            int? summaryDocumentBillingTypeId = null,
            string summaryDocumentDate = null,
            double? summaryDocumentDDAmount = null,
            string summaryDocumentDueDate = null,
            int? summaryDocumentId = null,
            bool? summaryDocumentIsFullyPaid = null,
            string summaryDocumentNumber = null,
            double? summaryDocumentPaidAmount = null,
            string summaryDocumentSoAReferenceNumber = null,
            int? summaryDocumentStatementOfAccountId = null,
            string transactionCurrencyCode = null,
            string transactionCurrencySymbol = null,
            string type = null,
            int? typeId = null,
            double? vATAmountCustomerCurrency = null,
            double? vATAmountTransactionCurrency = null,
            string vATCountry = null,
            int? vATCountryId = null,
            string vATCountryISOCode = null,
            string vATCountryOpCoId = null,
            string documentReference = null,
            List<Models.InvoiceSearchAdditionalDocument> additionalDocuments = null)
        {
            if (accountFullName != null)
            {
                this.AccountFullName = accountFullName;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountShortName != null)
            {
                this.AccountShortName = accountShortName;
            }

            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoOpCoId != null)
            {
                this.ColCoOpCoId = colCoOpCoId;
            }

            if (currentBillingFrequency != null)
            {
                this.CurrentBillingFrequency = currentBillingFrequency;
            }

            if (currentBillingFrequencyId != null)
            {
                this.CurrentBillingFrequencyId = currentBillingFrequencyId;
            }

            if (currentDistributionMethod != null)
            {
                this.CurrentDistributionMethod = currentDistributionMethod;
            }

            if (currentDistributionMethodId != null)
            {
                this.CurrentDistributionMethodId = currentDistributionMethodId;
            }

            if (customerCurrencyCode != null)
            {
                this.CustomerCurrencyCode = customerCurrencyCode;
            }

            if (customerCurrencySymbol != null)
            {
                this.CustomerCurrencySymbol = customerCurrencySymbol;
            }

            if (delCoClientNumber != null)
            {
                this.DelCoClientNumber = delCoClientNumber;
            }

            if (delCoId != null)
            {
                this.DelCoId = delCoId;
            }

            if (delCoOpCoId != null)
            {
                this.DelCoOpCoId = delCoOpCoId;
            }

            if (documentType != null)
            {
                this.DocumentType = documentType;
            }

            if (documentTypeId != null)
            {
                this.DocumentTypeId = documentTypeId;
            }

            if (dueDate != null)
            {
                this.DueDate = dueDate;
            }

            if (grossAmountCustomerCurrency != null)
            {
                this.GrossAmountCustomerCurrency = grossAmountCustomerCurrency;
            }

            if (grossAmountTransactionCurrency != null)
            {
                this.GrossAmountTransactionCurrency = grossAmountTransactionCurrency;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (invoicedBy != null)
            {
                this.InvoicedBy = invoicedBy;
            }

            if (invoicedOnBehalfOf != null)
            {
                this.InvoicedOnBehalfOf = invoicedOnBehalfOf;
            }

            if (invoiceId != null)
            {
                this.InvoiceId = invoiceId;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (isInternational != null)
            {
                this.IsInternational = isInternational;
            }

            if (isNational != null)
            {
                this.IsNational = isNational;
            }

            if (netAmountCustomerCurrency != null)
            {
                this.NetAmountCustomerCurrency = netAmountCustomerCurrency;
            }

            if (netAmountTransactionCurrency != null)
            {
                this.NetAmountTransactionCurrency = netAmountTransactionCurrency;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (paymentTerms != null)
            {
                this.PaymentTerms = paymentTerms;
            }

            if (paymentTermsId != null)
            {
                this.PaymentTermsId = paymentTermsId;
            }

            if (replacementInvoiceId != null)
            {
                this.ReplacementInvoiceId = replacementInvoiceId;
            }

            if (reversalInvoiceId != null)
            {
                this.ReversalInvoiceId = reversalInvoiceId;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (summaryDocumentBillingType != null)
            {
                this.SummaryDocumentBillingType = summaryDocumentBillingType;
            }

            if (summaryDocumentBillingTypeId != null)
            {
                this.SummaryDocumentBillingTypeId = summaryDocumentBillingTypeId;
            }

            if (summaryDocumentDate != null)
            {
                this.SummaryDocumentDate = summaryDocumentDate;
            }

            if (summaryDocumentDDAmount != null)
            {
                this.SummaryDocumentDDAmount = summaryDocumentDDAmount;
            }

            if (summaryDocumentDueDate != null)
            {
                this.SummaryDocumentDueDate = summaryDocumentDueDate;
            }

            if (summaryDocumentId != null)
            {
                this.SummaryDocumentId = summaryDocumentId;
            }

            if (summaryDocumentIsFullyPaid != null)
            {
                this.SummaryDocumentIsFullyPaid = summaryDocumentIsFullyPaid;
            }

            if (summaryDocumentNumber != null)
            {
                this.SummaryDocumentNumber = summaryDocumentNumber;
            }

            if (summaryDocumentPaidAmount != null)
            {
                this.SummaryDocumentPaidAmount = summaryDocumentPaidAmount;
            }

            if (summaryDocumentSoAReferenceNumber != null)
            {
                this.SummaryDocumentSoAReferenceNumber = summaryDocumentSoAReferenceNumber;
            }

            if (summaryDocumentStatementOfAccountId != null)
            {
                this.SummaryDocumentStatementOfAccountId = summaryDocumentStatementOfAccountId;
            }

            if (transactionCurrencyCode != null)
            {
                this.TransactionCurrencyCode = transactionCurrencyCode;
            }

            if (transactionCurrencySymbol != null)
            {
                this.TransactionCurrencySymbol = transactionCurrencySymbol;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (typeId != null)
            {
                this.TypeId = typeId;
            }

            if (vATAmountCustomerCurrency != null)
            {
                this.VATAmountCustomerCurrency = vATAmountCustomerCurrency;
            }

            if (vATAmountTransactionCurrency != null)
            {
                this.VATAmountTransactionCurrency = vATAmountTransactionCurrency;
            }

            if (vATCountry != null)
            {
                this.VATCountry = vATCountry;
            }

            if (vATCountryId != null)
            {
                this.VATCountryId = vATCountryId;
            }

            if (vATCountryISOCode != null)
            {
                this.VATCountryISOCode = vATCountryISOCode;
            }

            if (vATCountryOpCoId != null)
            {
                this.VATCountryOpCoId = vATCountryOpCoId;
            }

            if (documentReference != null)
            {
                this.DocumentReference = documentReference;
            }

            this.AdditionalDocuments = additionalDocuments;
        }

        /// <summary>
        /// Account Full Name
        /// Example: AT_reversal customer_FN
        /// </summary>
        [JsonProperty("AccountFullName")]
        public string AccountFullName
        {
            get
            {
                return this.accountFullName;
            }

            set
            {
                this.shouldSerialize["AccountFullName"] = true;
                this.accountFullName = value;
            }
        }

        /// <summary>
        /// Account ID
        /// Example: 29484
        /// </summary>
        [JsonProperty("AccountId")]
        public int? AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.shouldSerialize["AccountId"] = true;
                this.accountId = value;
            }
        }

        /// <summary>
        /// Account Number
        /// Example: GB99215176
        /// </summary>
        [JsonProperty("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["AccountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Account Short Name
        /// Example: AT Earth Movers-SN
        /// </summary>
        [JsonProperty("AccountShortName")]
        public string AccountShortName
        {
            get
            {
                return this.accountShortName;
            }

            set
            {
                this.shouldSerialize["AccountShortName"] = true;
                this.accountShortName = value;
            }
        }

        /// <summary>
        /// ColCo Id.
        /// Example: 18
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
        /// ColCo’s OpCo Id.
        /// Example: 018
        /// </summary>
        [JsonProperty("ColCoOpCoId")]
        public string ColCoOpCoId
        {
            get
            {
                return this.colCoOpCoId;
            }

            set
            {
                this.shouldSerialize["ColCoOpCoId"] = true;
                this.colCoOpCoId = value;
            }
        }

        /// <summary>
        /// Current billing frequency of the account.
        /// A few of the possible IDs and Description are below:
        /// 1	Daily (all days)
        /// 2	Daily (only working days)
        /// 3	Weekly - Monday
        /// 4	Weekly - Tuesday
        /// 5	Weekly - Wednesday
        /// 6	Weekly - Thursday
        /// 7	Weekly - Friday
        /// 8	Weekly - Saturday
        /// 9	Weekly - Sunday
        /// 10	Monthly - 1st
        /// Example: Weekly – Wednesday
        /// </summary>
        [JsonProperty("CurrentBillingFrequency")]
        public string CurrentBillingFrequency
        {
            get
            {
                return this.currentBillingFrequency;
            }

            set
            {
                this.shouldSerialize["CurrentBillingFrequency"] = true;
                this.currentBillingFrequency = value;
            }
        }

        /// <summary>
        /// Current billing frequency id of the account.
        /// A few of the possible IDs and Description are below:
        /// 1	Daily (all days)
        /// 2	Daily (only working days)
        /// 3	Weekly - Monday
        /// 4	Weekly - Tuesday
        /// 5	Weekly - Wednesday
        /// 6	Weekly - Thursday
        /// 7	Weekly - Friday
        /// 8	Weekly - Saturday
        /// 9	Weekly - Sunday
        /// 10	Monthly - 1st
        /// Example: 5
        /// </summary>
        [JsonProperty("CurrentBillingFrequencyId")]
        public int? CurrentBillingFrequencyId
        {
            get
            {
                return this.currentBillingFrequencyId;
            }

            set
            {
                this.shouldSerialize["CurrentBillingFrequencyId"] = true;
                this.currentBillingFrequencyId = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Current distribution method name of the account.
        /// Example : Id & Description
        /// 1	e-mail
        /// 2	Fax
        /// 3	Courier to Customer
        /// 4	Courier to Client
        /// 5	Print
        /// 6	FTP
        /// 7	SMS
        /// ]]>
        /// </summary>
        [JsonProperty("CurrentDistributionMethod")]
        public string CurrentDistributionMethod
        {
            get
            {
                return this.currentDistributionMethod;
            }

            set
            {
                this.shouldSerialize["CurrentDistributionMethod"] = true;
                this.currentDistributionMethod = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Current distribution method id of the account.
        /// Example : Id & Description
        /// 1	e-mail
        /// 2	Fax
        /// 3	Courier to Customer
        /// 4	Courier to Client
        /// 5	Print
        /// 6	FTP
        /// 7	SMS
        /// ]]>
        /// </summary>
        [JsonProperty("CurrentDistributionMethodId")]
        public int? CurrentDistributionMethodId
        {
            get
            {
                return this.currentDistributionMethodId;
            }

            set
            {
                this.shouldSerialize["CurrentDistributionMethodId"] = true;
                this.currentDistributionMethodId = value;
            }
        }

        /// <summary>
        /// Customer currency ISO code.
        /// Example: EUR
        /// </summary>
        [JsonProperty("CustomerCurrencyCode")]
        public string CustomerCurrencyCode
        {
            get
            {
                return this.customerCurrencyCode;
            }

            set
            {
                this.shouldSerialize["CustomerCurrencyCode"] = true;
                this.customerCurrencyCode = value;
            }
        }

        /// <summary>
        /// Customer currency code.
        /// Example: €
        /// </summary>
        [JsonProperty("CustomerCurrencySymbol")]
        public string CustomerCurrencySymbol
        {
            get
            {
                return this.customerCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["CustomerCurrencySymbol"] = true;
                this.customerCurrencySymbol = value;
            }
        }

        /// <summary>
        /// DelCo’s client company number.
        /// Example: 132
        /// </summary>
        [JsonProperty("DelCoClientNumber")]
        public string DelCoClientNumber
        {
            get
            {
                return this.delCoClientNumber;
            }

            set
            {
                this.shouldSerialize["DelCoClientNumber"] = true;
                this.delCoClientNumber = value;
            }
        }

        /// <summary>
        /// DelCo Id.
        /// Example: 132
        /// </summary>
        [JsonProperty("DelCoId")]
        public int? DelCoId
        {
            get
            {
                return this.delCoId;
            }

            set
            {
                this.shouldSerialize["DelCoId"] = true;
                this.delCoId = value;
            }
        }

        /// <summary>
        /// DelCo’s OpCo Id.
        /// Example: 032
        /// </summary>
        [JsonProperty("DelCoOpCoId")]
        public string DelCoOpCoId
        {
            get
            {
                return this.delCoOpCoId;
            }

            set
            {
                this.shouldSerialize["DelCoOpCoId"] = true;
                this.delCoOpCoId = value;
            }
        }

        /// <summary>
        /// Document type Id description.
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType
        {
            get
            {
                return this.documentType;
            }

            set
            {
                this.shouldSerialize["DocumentType"] = true;
                this.documentType = value;
            }
        }

        /// <summary>
        /// Document type Id.
        /// </summary>
        [JsonProperty("DocumentTypeId")]
        public int? DocumentTypeId
        {
            get
            {
                return this.documentTypeId;
            }

            set
            {
                this.shouldSerialize["DocumentTypeId"] = true;
                this.documentTypeId = value;
            }
        }

        /// <summary>
        /// Due date. Format: yyyyMMdd.
        /// Example: 20170115
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
        /// Gross amount in customer currency in the document.
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
        /// Gross amount in transaction currency in the document
        /// </summary>
        [JsonProperty("GrossAmountTransactionCurrency")]
        public double? GrossAmountTransactionCurrency
        {
            get
            {
                return this.grossAmountTransactionCurrency;
            }

            set
            {
                this.shouldSerialize["GrossAmountTransactionCurrency"] = true;
                this.grossAmountTransactionCurrency = value;
            }
        }

        /// <summary>
        /// Invoicing date. Format: yyyyMMdd
        /// Example: 20170101
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
        /// Company name.
        /// </summary>
        [JsonProperty("InvoicedBy")]
        public string InvoicedBy
        {
            get
            {
                return this.invoicedBy;
            }

            set
            {
                this.shouldSerialize["InvoicedBy"] = true;
                this.invoicedBy = value;
            }
        }

        /// <summary>
        /// Country Name.
        /// Example: Czech Republic
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
        /// Invoice id.
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
        /// True/False.
        /// True if this is an International invoice, else false.
        /// </summary>
        [JsonProperty("IsInternational")]
        public bool? IsInternational
        {
            get
            {
                return this.isInternational;
            }

            set
            {
                this.shouldSerialize["IsInternational"] = true;
                this.isInternational = value;
            }
        }

        /// <summary>
        /// True/False.
        /// True if this is a National invoice, else false.
        /// </summary>
        [JsonProperty("IsNational")]
        public bool? IsNational
        {
            get
            {
                return this.isNational;
            }

            set
            {
                this.shouldSerialize["IsNational"] = true;
                this.isNational = value;
            }
        }

        /// <summary>
        /// Net amount in customer currency in the document.
        /// </summary>
        [JsonProperty("NetAmountCustomerCurrency")]
        public double? NetAmountCustomerCurrency
        {
            get
            {
                return this.netAmountCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["NetAmountCustomerCurrency"] = true;
                this.netAmountCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Net amount in transaction currency in the document.
        /// </summary>
        [JsonProperty("NetAmountTransactionCurrency")]
        public double? NetAmountTransactionCurrency
        {
            get
            {
                return this.netAmountTransactionCurrency;
            }

            set
            {
                this.shouldSerialize["NetAmountTransactionCurrency"] = true;
                this.netAmountTransactionCurrency = value;
            }
        }

        /// <summary>
        /// Payment customer id of the customer.
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
        /// Payment customer number.
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
        /// A few of the possible IDs and Descriptions are below:
        /// 1	14 days after Invoice
        /// 2	15 days after Invoice
        /// 3	21 days after Invoice
        /// 4	30 days after Invoice
        /// 5	45 days after Invoice
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
        /// Payment terms id of the payment customer.
        /// A few of the possible IDs and Descriptions are below:
        /// 1	14 days after Invoice
        /// 2	15 days after Invoice
        /// 3	21 days after Invoice
        /// 4	30 days after Invoice
        /// 5	45 days after Invoice
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
        /// Replaced document id.
        /// Example: 2
        /// </summary>
        [JsonProperty("ReplacementInvoiceId")]
        public int? ReplacementInvoiceId
        {
            get
            {
                return this.replacementInvoiceId;
            }

            set
            {
                this.shouldSerialize["ReplacementInvoiceId"] = true;
                this.replacementInvoiceId = value;
            }
        }

        /// <summary>
        /// Reversed document id.
        /// Example: 3
        /// </summary>
        [JsonProperty("ReversalInvoiceId")]
        public int? ReversalInvoiceId
        {
            get
            {
                return this.reversalInvoiceId;
            }

            set
            {
                this.shouldSerialize["ReversalInvoiceId"] = true;
                this.reversalInvoiceId = value;
            }
        }

        /// <summary>
        /// Status of the document. Valid values –
        /// •	[Empty] – For all document types except for Invoice and Statement.
        /// •	Due – Invoices/Statements due for payment and is within the due date.
        /// •	Paid – Fully paid Invoices/Statements.
        /// Overdue – Invoices/Statements due of payment and has crossed the due date.
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
        /// <![CDATA[
        /// Billing type description.
        /// Example: Id & Description
        /// -3	Guarantee History
        /// -1	Initial Balance
        /// 0	Standard Invoice
        /// 1	Immediate Invoice
        /// 2	Guarantee
        /// 4	Advanced DD Invoice
        /// ]]>
        /// </summary>
        [JsonProperty("SummaryDocumentBillingType")]
        public string SummaryDocumentBillingType
        {
            get
            {
                return this.summaryDocumentBillingType;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentBillingType"] = true;
                this.summaryDocumentBillingType = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Billing type id.
        /// Example: Id & Description
        /// -3	Guarantee History
        /// -1	Initial Balance
        /// 0	Standard Invoice
        /// 1	Immediate Invoice
        /// 2	Guarantee
        /// 4	Advanced DD Invoice
        /// ]]>
        /// </summary>
        [JsonProperty("SummaryDocumentBillingTypeId")]
        public int? SummaryDocumentBillingTypeId
        {
            get
            {
                return this.summaryDocumentBillingTypeId;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentBillingTypeId"] = true;
                this.summaryDocumentBillingTypeId = value;
            }
        }

        /// <summary>
        /// Document generated date. Format: yyyyMMdd
        /// Example: 20170101
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
        /// DD amount.
        /// </summary>
        [JsonProperty("SummaryDocumentDDAmount")]
        public double? SummaryDocumentDDAmount
        {
            get
            {
                return this.summaryDocumentDDAmount;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentDDAmount"] = true;
                this.summaryDocumentDDAmount = value;
            }
        }

        /// <summary>
        /// Due date for document. Format: yyyyMMdd
        /// Example: 20170115
        /// </summary>
        [JsonProperty("SummaryDocumentDueDate")]
        public string SummaryDocumentDueDate
        {
            get
            {
                return this.summaryDocumentDueDate;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentDueDate"] = true;
                this.summaryDocumentDueDate = value;
            }
        }

        /// <summary>
        /// Summary document identifier
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
        /// True/False
        /// True if invoice amount is fully paid, else false
        /// </summary>
        [JsonProperty("SummaryDocumentIsFullyPaid")]
        public bool? SummaryDocumentIsFullyPaid
        {
            get
            {
                return this.summaryDocumentIsFullyPaid;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentIsFullyPaid"] = true;
                this.summaryDocumentIsFullyPaid = value;
            }
        }

        /// <summary>
        /// Summary document number
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
        /// Total amount paid.
        /// </summary>
        [JsonProperty("SummaryDocumentPaidAmount")]
        public double? SummaryDocumentPaidAmount
        {
            get
            {
                return this.summaryDocumentPaidAmount;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentPaidAmount"] = true;
                this.summaryDocumentPaidAmount = value;
            }
        }

        /// <summary>
        /// Statement of Account reference number of the payment customer.
        /// </summary>
        [JsonProperty("SummaryDocumentSoAReferenceNumber")]
        public string SummaryDocumentSoAReferenceNumber
        {
            get
            {
                return this.summaryDocumentSoAReferenceNumber;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentSoAReferenceNumber"] = true;
                this.summaryDocumentSoAReferenceNumber = value;
            }
        }

        /// <summary>
        /// Statement of Account Id of the payment customer.
        /// </summary>
        [JsonProperty("SummaryDocumentStatementOfAccountId")]
        public int? SummaryDocumentStatementOfAccountId
        {
            get
            {
                return this.summaryDocumentStatementOfAccountId;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentStatementOfAccountId"] = true;
                this.summaryDocumentStatementOfAccountId = value;
            }
        }

        /// <summary>
        /// Transaction currency ISO code.
        /// Example: EUR
        /// </summary>
        [JsonProperty("TransactionCurrencyCode")]
        public string TransactionCurrencyCode
        {
            get
            {
                return this.transactionCurrencyCode;
            }

            set
            {
                this.shouldSerialize["TransactionCurrencyCode"] = true;
                this.transactionCurrencyCode = value;
            }
        }

        /// <summary>
        /// Transaction currency symbol.
        /// Example: €
        /// </summary>
        [JsonProperty("TransactionCurrencySymbol")]
        public string TransactionCurrencySymbol
        {
            get
            {
                return this.transactionCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["TransactionCurrencySymbol"] = true;
                this.transactionCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Invoice type description.
        /// A few of the possible IDs and Description are below:
        /// 1	Original
        /// 2	Reversal
        /// 3	Replacement
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

        /// <summary>
        /// Invoice type id.
        /// A few of the possible IDs and Descriptions are below:
        /// 1	Original
        /// 2	Reversal
        /// 3	Replacement
        /// Example: 1
        /// </summary>
        [JsonProperty("TypeId")]
        public int? TypeId
        {
            get
            {
                return this.typeId;
            }

            set
            {
                this.shouldSerialize["TypeId"] = true;
                this.typeId = value;
            }
        }

        /// <summary>
        /// VAT amount in customer currency in the document
        /// </summary>
        [JsonProperty("VATAmountCustomerCurrency")]
        public double? VATAmountCustomerCurrency
        {
            get
            {
                return this.vATAmountCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["VATAmountCustomerCurrency"] = true;
                this.vATAmountCustomerCurrency = value;
            }
        }

        /// <summary>
        /// VAT amount in transaction currency in the document
        /// </summary>
        [JsonProperty("VATAmountTransactionCurrency")]
        public double? VATAmountTransactionCurrency
        {
            get
            {
                return this.vATAmountTransactionCurrency;
            }

            set
            {
                this.shouldSerialize["VATAmountTransactionCurrency"] = true;
                this.vATAmountTransactionCurrency = value;
            }
        }

        /// <summary>
        /// Country name of the VAT country.
        /// Example: France, Germany
        /// </summary>
        [JsonProperty("VATCountry")]
        public string VATCountry
        {
            get
            {
                return this.vATCountry;
            }

            set
            {
                this.shouldSerialize["VATCountry"] = true;
                this.vATCountry = value;
            }
        }

        /// <summary>
        /// Country Id of the VAT country.
        /// Example: 1,2
        /// </summary>
        [JsonProperty("VATCountryId")]
        public int? VATCountryId
        {
            get
            {
                return this.vATCountryId;
            }

            set
            {
                this.shouldSerialize["VATCountryId"] = true;
                this.vATCountryId = value;
            }
        }

        /// <summary>
        /// Country ISO code of the VAT country.
        /// Example : CZ, SK, UK, etc.,
        /// </summary>
        [JsonProperty("VATCountryISOCode")]
        public string VATCountryISOCode
        {
            get
            {
                return this.vATCountryISOCode;
            }

            set
            {
                this.shouldSerialize["VATCountryISOCode"] = true;
                this.vATCountryISOCode = value;
            }
        }

        /// <summary>
        /// VAT country’s OpCo Id.
        /// Example: 032
        /// </summary>
        [JsonProperty("VATCountryOpCoId")]
        public string VATCountryOpCoId
        {
            get
            {
                return this.vATCountryOpCoId;
            }

            set
            {
                this.shouldSerialize["VATCountryOpCoId"] = true;
                this.vATCountryOpCoId = value;
            }
        }

        /// <summary>
        /// document reference number of the Invoice file
        /// </summary>
        [JsonProperty("DocumentReference")]
        public string DocumentReference
        {
            get
            {
                return this.documentReference;
            }

            set
            {
                this.shouldSerialize["DocumentReference"] = true;
                this.documentReference = value;
            }
        }

        /// <summary>
        /// Gets or sets AdditionalDocuments.
        /// </summary>
        [JsonProperty("AdditionalDocuments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceSearchAdditionalDocument> AdditionalDocuments { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceSearchDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountFullName()
        {
            this.shouldSerialize["AccountFullName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountShortName()
        {
            this.shouldSerialize["AccountShortName"] = false;
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
        public void UnsetColCoOpCoId()
        {
            this.shouldSerialize["ColCoOpCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrentBillingFrequency()
        {
            this.shouldSerialize["CurrentBillingFrequency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrentBillingFrequencyId()
        {
            this.shouldSerialize["CurrentBillingFrequencyId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrentDistributionMethod()
        {
            this.shouldSerialize["CurrentDistributionMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrentDistributionMethodId()
        {
            this.shouldSerialize["CurrentDistributionMethodId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerCurrencyCode()
        {
            this.shouldSerialize["CustomerCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerCurrencySymbol()
        {
            this.shouldSerialize["CustomerCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelCoClientNumber()
        {
            this.shouldSerialize["DelCoClientNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelCoId()
        {
            this.shouldSerialize["DelCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelCoOpCoId()
        {
            this.shouldSerialize["DelCoOpCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentType()
        {
            this.shouldSerialize["DocumentType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentTypeId()
        {
            this.shouldSerialize["DocumentTypeId"] = false;
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
        public void UnsetGrossAmountCustomerCurrency()
        {
            this.shouldSerialize["GrossAmountCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGrossAmountTransactionCurrency()
        {
            this.shouldSerialize["GrossAmountTransactionCurrency"] = false;
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
        public void UnsetInvoicedBy()
        {
            this.shouldSerialize["InvoicedBy"] = false;
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
        public void UnsetIsInternational()
        {
            this.shouldSerialize["IsInternational"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsNational()
        {
            this.shouldSerialize["IsNational"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetAmountCustomerCurrency()
        {
            this.shouldSerialize["NetAmountCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetAmountTransactionCurrency()
        {
            this.shouldSerialize["NetAmountTransactionCurrency"] = false;
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
        public void UnsetReplacementInvoiceId()
        {
            this.shouldSerialize["ReplacementInvoiceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReversalInvoiceId()
        {
            this.shouldSerialize["ReversalInvoiceId"] = false;
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
        public void UnsetSummaryDocumentBillingType()
        {
            this.shouldSerialize["SummaryDocumentBillingType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentBillingTypeId()
        {
            this.shouldSerialize["SummaryDocumentBillingTypeId"] = false;
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
        public void UnsetSummaryDocumentDDAmount()
        {
            this.shouldSerialize["SummaryDocumentDDAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentDueDate()
        {
            this.shouldSerialize["SummaryDocumentDueDate"] = false;
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
        public void UnsetSummaryDocumentIsFullyPaid()
        {
            this.shouldSerialize["SummaryDocumentIsFullyPaid"] = false;
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
        public void UnsetSummaryDocumentPaidAmount()
        {
            this.shouldSerialize["SummaryDocumentPaidAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentSoAReferenceNumber()
        {
            this.shouldSerialize["SummaryDocumentSoAReferenceNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentStatementOfAccountId()
        {
            this.shouldSerialize["SummaryDocumentStatementOfAccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionCurrencyCode()
        {
            this.shouldSerialize["TransactionCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionCurrencySymbol()
        {
            this.shouldSerialize["TransactionCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["Type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTypeId()
        {
            this.shouldSerialize["TypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATAmountCustomerCurrency()
        {
            this.shouldSerialize["VATAmountCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATAmountTransactionCurrency()
        {
            this.shouldSerialize["VATAmountTransactionCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountry()
        {
            this.shouldSerialize["VATCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountryId()
        {
            this.shouldSerialize["VATCountryId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountryISOCode()
        {
            this.shouldSerialize["VATCountryISOCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountryOpCoId()
        {
            this.shouldSerialize["VATCountryOpCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentReference()
        {
            this.shouldSerialize["DocumentReference"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountFullName()
        {
            return this.shouldSerialize["AccountFullName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["AccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountShortName()
        {
            return this.shouldSerialize["AccountShortName"];
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
        public bool ShouldSerializeColCoOpCoId()
        {
            return this.shouldSerialize["ColCoOpCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrentBillingFrequency()
        {
            return this.shouldSerialize["CurrentBillingFrequency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrentBillingFrequencyId()
        {
            return this.shouldSerialize["CurrentBillingFrequencyId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrentDistributionMethod()
        {
            return this.shouldSerialize["CurrentDistributionMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrentDistributionMethodId()
        {
            return this.shouldSerialize["CurrentDistributionMethodId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerCurrencyCode()
        {
            return this.shouldSerialize["CustomerCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerCurrencySymbol()
        {
            return this.shouldSerialize["CustomerCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelCoClientNumber()
        {
            return this.shouldSerialize["DelCoClientNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelCoId()
        {
            return this.shouldSerialize["DelCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelCoOpCoId()
        {
            return this.shouldSerialize["DelCoOpCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentType()
        {
            return this.shouldSerialize["DocumentType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentTypeId()
        {
            return this.shouldSerialize["DocumentTypeId"];
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
        public bool ShouldSerializeGrossAmountCustomerCurrency()
        {
            return this.shouldSerialize["GrossAmountCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrossAmountTransactionCurrency()
        {
            return this.shouldSerialize["GrossAmountTransactionCurrency"];
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
        public bool ShouldSerializeInvoicedBy()
        {
            return this.shouldSerialize["InvoicedBy"];
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
        public bool ShouldSerializeIsInternational()
        {
            return this.shouldSerialize["IsInternational"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsNational()
        {
            return this.shouldSerialize["IsNational"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetAmountCustomerCurrency()
        {
            return this.shouldSerialize["NetAmountCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetAmountTransactionCurrency()
        {
            return this.shouldSerialize["NetAmountTransactionCurrency"];
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
        public bool ShouldSerializeReplacementInvoiceId()
        {
            return this.shouldSerialize["ReplacementInvoiceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReversalInvoiceId()
        {
            return this.shouldSerialize["ReversalInvoiceId"];
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
        public bool ShouldSerializeSummaryDocumentBillingType()
        {
            return this.shouldSerialize["SummaryDocumentBillingType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentBillingTypeId()
        {
            return this.shouldSerialize["SummaryDocumentBillingTypeId"];
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
        public bool ShouldSerializeSummaryDocumentDDAmount()
        {
            return this.shouldSerialize["SummaryDocumentDDAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentDueDate()
        {
            return this.shouldSerialize["SummaryDocumentDueDate"];
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
        public bool ShouldSerializeSummaryDocumentIsFullyPaid()
        {
            return this.shouldSerialize["SummaryDocumentIsFullyPaid"];
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
        public bool ShouldSerializeSummaryDocumentPaidAmount()
        {
            return this.shouldSerialize["SummaryDocumentPaidAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentSoAReferenceNumber()
        {
            return this.shouldSerialize["SummaryDocumentSoAReferenceNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentStatementOfAccountId()
        {
            return this.shouldSerialize["SummaryDocumentStatementOfAccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionCurrencyCode()
        {
            return this.shouldSerialize["TransactionCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionCurrencySymbol()
        {
            return this.shouldSerialize["TransactionCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["Type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTypeId()
        {
            return this.shouldSerialize["TypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATAmountCustomerCurrency()
        {
            return this.shouldSerialize["VATAmountCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATAmountTransactionCurrency()
        {
            return this.shouldSerialize["VATAmountTransactionCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountry()
        {
            return this.shouldSerialize["VATCountry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountryId()
        {
            return this.shouldSerialize["VATCountryId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountryISOCode()
        {
            return this.shouldSerialize["VATCountryISOCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountryOpCoId()
        {
            return this.shouldSerialize["VATCountryOpCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentReference()
        {
            return this.shouldSerialize["DocumentReference"];
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
            return obj is InvoiceSearchDetails other &&                ((this.AccountFullName == null && other.AccountFullName == null) || (this.AccountFullName?.Equals(other.AccountFullName) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoOpCoId == null && other.ColCoOpCoId == null) || (this.ColCoOpCoId?.Equals(other.ColCoOpCoId) == true)) &&
                ((this.CurrentBillingFrequency == null && other.CurrentBillingFrequency == null) || (this.CurrentBillingFrequency?.Equals(other.CurrentBillingFrequency) == true)) &&
                ((this.CurrentBillingFrequencyId == null && other.CurrentBillingFrequencyId == null) || (this.CurrentBillingFrequencyId?.Equals(other.CurrentBillingFrequencyId) == true)) &&
                ((this.CurrentDistributionMethod == null && other.CurrentDistributionMethod == null) || (this.CurrentDistributionMethod?.Equals(other.CurrentDistributionMethod) == true)) &&
                ((this.CurrentDistributionMethodId == null && other.CurrentDistributionMethodId == null) || (this.CurrentDistributionMethodId?.Equals(other.CurrentDistributionMethodId) == true)) &&
                ((this.CustomerCurrencyCode == null && other.CustomerCurrencyCode == null) || (this.CustomerCurrencyCode?.Equals(other.CustomerCurrencyCode) == true)) &&
                ((this.CustomerCurrencySymbol == null && other.CustomerCurrencySymbol == null) || (this.CustomerCurrencySymbol?.Equals(other.CustomerCurrencySymbol) == true)) &&
                ((this.DelCoClientNumber == null && other.DelCoClientNumber == null) || (this.DelCoClientNumber?.Equals(other.DelCoClientNumber) == true)) &&
                ((this.DelCoId == null && other.DelCoId == null) || (this.DelCoId?.Equals(other.DelCoId) == true)) &&
                ((this.DelCoOpCoId == null && other.DelCoOpCoId == null) || (this.DelCoOpCoId?.Equals(other.DelCoOpCoId) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true)) &&
                ((this.DocumentTypeId == null && other.DocumentTypeId == null) || (this.DocumentTypeId?.Equals(other.DocumentTypeId) == true)) &&
                ((this.DueDate == null && other.DueDate == null) || (this.DueDate?.Equals(other.DueDate) == true)) &&
                ((this.GrossAmountCustomerCurrency == null && other.GrossAmountCustomerCurrency == null) || (this.GrossAmountCustomerCurrency?.Equals(other.GrossAmountCustomerCurrency) == true)) &&
                ((this.GrossAmountTransactionCurrency == null && other.GrossAmountTransactionCurrency == null) || (this.GrossAmountTransactionCurrency?.Equals(other.GrossAmountTransactionCurrency) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.InvoicedBy == null && other.InvoicedBy == null) || (this.InvoicedBy?.Equals(other.InvoicedBy) == true)) &&
                ((this.InvoicedOnBehalfOf == null && other.InvoicedOnBehalfOf == null) || (this.InvoicedOnBehalfOf?.Equals(other.InvoicedOnBehalfOf) == true)) &&
                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.IsInternational == null && other.IsInternational == null) || (this.IsInternational?.Equals(other.IsInternational) == true)) &&
                ((this.IsNational == null && other.IsNational == null) || (this.IsNational?.Equals(other.IsNational) == true)) &&
                ((this.NetAmountCustomerCurrency == null && other.NetAmountCustomerCurrency == null) || (this.NetAmountCustomerCurrency?.Equals(other.NetAmountCustomerCurrency) == true)) &&
                ((this.NetAmountTransactionCurrency == null && other.NetAmountTransactionCurrency == null) || (this.NetAmountTransactionCurrency?.Equals(other.NetAmountTransactionCurrency) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PaymentTerms == null && other.PaymentTerms == null) || (this.PaymentTerms?.Equals(other.PaymentTerms) == true)) &&
                ((this.PaymentTermsId == null && other.PaymentTermsId == null) || (this.PaymentTermsId?.Equals(other.PaymentTermsId) == true)) &&
                ((this.ReplacementInvoiceId == null && other.ReplacementInvoiceId == null) || (this.ReplacementInvoiceId?.Equals(other.ReplacementInvoiceId) == true)) &&
                ((this.ReversalInvoiceId == null && other.ReversalInvoiceId == null) || (this.ReversalInvoiceId?.Equals(other.ReversalInvoiceId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.SummaryDocumentBillingType == null && other.SummaryDocumentBillingType == null) || (this.SummaryDocumentBillingType?.Equals(other.SummaryDocumentBillingType) == true)) &&
                ((this.SummaryDocumentBillingTypeId == null && other.SummaryDocumentBillingTypeId == null) || (this.SummaryDocumentBillingTypeId?.Equals(other.SummaryDocumentBillingTypeId) == true)) &&
                ((this.SummaryDocumentDate == null && other.SummaryDocumentDate == null) || (this.SummaryDocumentDate?.Equals(other.SummaryDocumentDate) == true)) &&
                ((this.SummaryDocumentDDAmount == null && other.SummaryDocumentDDAmount == null) || (this.SummaryDocumentDDAmount?.Equals(other.SummaryDocumentDDAmount) == true)) &&
                ((this.SummaryDocumentDueDate == null && other.SummaryDocumentDueDate == null) || (this.SummaryDocumentDueDate?.Equals(other.SummaryDocumentDueDate) == true)) &&
                ((this.SummaryDocumentId == null && other.SummaryDocumentId == null) || (this.SummaryDocumentId?.Equals(other.SummaryDocumentId) == true)) &&
                ((this.SummaryDocumentIsFullyPaid == null && other.SummaryDocumentIsFullyPaid == null) || (this.SummaryDocumentIsFullyPaid?.Equals(other.SummaryDocumentIsFullyPaid) == true)) &&
                ((this.SummaryDocumentNumber == null && other.SummaryDocumentNumber == null) || (this.SummaryDocumentNumber?.Equals(other.SummaryDocumentNumber) == true)) &&
                ((this.SummaryDocumentPaidAmount == null && other.SummaryDocumentPaidAmount == null) || (this.SummaryDocumentPaidAmount?.Equals(other.SummaryDocumentPaidAmount) == true)) &&
                ((this.SummaryDocumentSoAReferenceNumber == null && other.SummaryDocumentSoAReferenceNumber == null) || (this.SummaryDocumentSoAReferenceNumber?.Equals(other.SummaryDocumentSoAReferenceNumber) == true)) &&
                ((this.SummaryDocumentStatementOfAccountId == null && other.SummaryDocumentStatementOfAccountId == null) || (this.SummaryDocumentStatementOfAccountId?.Equals(other.SummaryDocumentStatementOfAccountId) == true)) &&
                ((this.TransactionCurrencyCode == null && other.TransactionCurrencyCode == null) || (this.TransactionCurrencyCode?.Equals(other.TransactionCurrencyCode) == true)) &&
                ((this.TransactionCurrencySymbol == null && other.TransactionCurrencySymbol == null) || (this.TransactionCurrencySymbol?.Equals(other.TransactionCurrencySymbol) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.TypeId == null && other.TypeId == null) || (this.TypeId?.Equals(other.TypeId) == true)) &&
                ((this.VATAmountCustomerCurrency == null && other.VATAmountCustomerCurrency == null) || (this.VATAmountCustomerCurrency?.Equals(other.VATAmountCustomerCurrency) == true)) &&
                ((this.VATAmountTransactionCurrency == null && other.VATAmountTransactionCurrency == null) || (this.VATAmountTransactionCurrency?.Equals(other.VATAmountTransactionCurrency) == true)) &&
                ((this.VATCountry == null && other.VATCountry == null) || (this.VATCountry?.Equals(other.VATCountry) == true)) &&
                ((this.VATCountryId == null && other.VATCountryId == null) || (this.VATCountryId?.Equals(other.VATCountryId) == true)) &&
                ((this.VATCountryISOCode == null && other.VATCountryISOCode == null) || (this.VATCountryISOCode?.Equals(other.VATCountryISOCode) == true)) &&
                ((this.VATCountryOpCoId == null && other.VATCountryOpCoId == null) || (this.VATCountryOpCoId?.Equals(other.VATCountryOpCoId) == true)) &&
                ((this.DocumentReference == null && other.DocumentReference == null) || (this.DocumentReference?.Equals(other.DocumentReference) == true)) &&
                ((this.AdditionalDocuments == null && other.AdditionalDocuments == null) || (this.AdditionalDocuments?.Equals(other.AdditionalDocuments) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountFullName = {(this.AccountFullName == null ? "null" : this.AccountFullName)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoOpCoId = {(this.ColCoOpCoId == null ? "null" : this.ColCoOpCoId)}");
            toStringOutput.Add($"this.CurrentBillingFrequency = {(this.CurrentBillingFrequency == null ? "null" : this.CurrentBillingFrequency)}");
            toStringOutput.Add($"this.CurrentBillingFrequencyId = {(this.CurrentBillingFrequencyId == null ? "null" : this.CurrentBillingFrequencyId.ToString())}");
            toStringOutput.Add($"this.CurrentDistributionMethod = {(this.CurrentDistributionMethod == null ? "null" : this.CurrentDistributionMethod)}");
            toStringOutput.Add($"this.CurrentDistributionMethodId = {(this.CurrentDistributionMethodId == null ? "null" : this.CurrentDistributionMethodId.ToString())}");
            toStringOutput.Add($"this.CustomerCurrencyCode = {(this.CustomerCurrencyCode == null ? "null" : this.CustomerCurrencyCode)}");
            toStringOutput.Add($"this.CustomerCurrencySymbol = {(this.CustomerCurrencySymbol == null ? "null" : this.CustomerCurrencySymbol)}");
            toStringOutput.Add($"this.DelCoClientNumber = {(this.DelCoClientNumber == null ? "null" : this.DelCoClientNumber)}");
            toStringOutput.Add($"this.DelCoId = {(this.DelCoId == null ? "null" : this.DelCoId.ToString())}");
            toStringOutput.Add($"this.DelCoOpCoId = {(this.DelCoOpCoId == null ? "null" : this.DelCoOpCoId)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType)}");
            toStringOutput.Add($"this.DocumentTypeId = {(this.DocumentTypeId == null ? "null" : this.DocumentTypeId.ToString())}");
            toStringOutput.Add($"this.DueDate = {(this.DueDate == null ? "null" : this.DueDate)}");
            toStringOutput.Add($"this.GrossAmountCustomerCurrency = {(this.GrossAmountCustomerCurrency == null ? "null" : this.GrossAmountCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.GrossAmountTransactionCurrency = {(this.GrossAmountTransactionCurrency == null ? "null" : this.GrossAmountTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.InvoicedBy = {(this.InvoicedBy == null ? "null" : this.InvoicedBy)}");
            toStringOutput.Add($"this.InvoicedOnBehalfOf = {(this.InvoicedOnBehalfOf == null ? "null" : this.InvoicedOnBehalfOf)}");
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId.ToString())}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.IsInternational = {(this.IsInternational == null ? "null" : this.IsInternational.ToString())}");
            toStringOutput.Add($"this.IsNational = {(this.IsNational == null ? "null" : this.IsNational.ToString())}");
            toStringOutput.Add($"this.NetAmountCustomerCurrency = {(this.NetAmountCustomerCurrency == null ? "null" : this.NetAmountCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.NetAmountTransactionCurrency = {(this.NetAmountTransactionCurrency == null ? "null" : this.NetAmountTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PaymentTerms = {(this.PaymentTerms == null ? "null" : this.PaymentTerms)}");
            toStringOutput.Add($"this.PaymentTermsId = {(this.PaymentTermsId == null ? "null" : this.PaymentTermsId.ToString())}");
            toStringOutput.Add($"this.ReplacementInvoiceId = {(this.ReplacementInvoiceId == null ? "null" : this.ReplacementInvoiceId.ToString())}");
            toStringOutput.Add($"this.ReversalInvoiceId = {(this.ReversalInvoiceId == null ? "null" : this.ReversalInvoiceId.ToString())}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.SummaryDocumentBillingType = {(this.SummaryDocumentBillingType == null ? "null" : this.SummaryDocumentBillingType)}");
            toStringOutput.Add($"this.SummaryDocumentBillingTypeId = {(this.SummaryDocumentBillingTypeId == null ? "null" : this.SummaryDocumentBillingTypeId.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentDate = {(this.SummaryDocumentDate == null ? "null" : this.SummaryDocumentDate)}");
            toStringOutput.Add($"this.SummaryDocumentDDAmount = {(this.SummaryDocumentDDAmount == null ? "null" : this.SummaryDocumentDDAmount.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentDueDate = {(this.SummaryDocumentDueDate == null ? "null" : this.SummaryDocumentDueDate)}");
            toStringOutput.Add($"this.SummaryDocumentId = {(this.SummaryDocumentId == null ? "null" : this.SummaryDocumentId.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentIsFullyPaid = {(this.SummaryDocumentIsFullyPaid == null ? "null" : this.SummaryDocumentIsFullyPaid.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentNumber = {(this.SummaryDocumentNumber == null ? "null" : this.SummaryDocumentNumber)}");
            toStringOutput.Add($"this.SummaryDocumentPaidAmount = {(this.SummaryDocumentPaidAmount == null ? "null" : this.SummaryDocumentPaidAmount.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentSoAReferenceNumber = {(this.SummaryDocumentSoAReferenceNumber == null ? "null" : this.SummaryDocumentSoAReferenceNumber)}");
            toStringOutput.Add($"this.SummaryDocumentStatementOfAccountId = {(this.SummaryDocumentStatementOfAccountId == null ? "null" : this.SummaryDocumentStatementOfAccountId.ToString())}");
            toStringOutput.Add($"this.TransactionCurrencyCode = {(this.TransactionCurrencyCode == null ? "null" : this.TransactionCurrencyCode)}");
            toStringOutput.Add($"this.TransactionCurrencySymbol = {(this.TransactionCurrencySymbol == null ? "null" : this.TransactionCurrencySymbol)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.TypeId = {(this.TypeId == null ? "null" : this.TypeId.ToString())}");
            toStringOutput.Add($"this.VATAmountCustomerCurrency = {(this.VATAmountCustomerCurrency == null ? "null" : this.VATAmountCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.VATAmountTransactionCurrency = {(this.VATAmountTransactionCurrency == null ? "null" : this.VATAmountTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.VATCountry = {(this.VATCountry == null ? "null" : this.VATCountry)}");
            toStringOutput.Add($"this.VATCountryId = {(this.VATCountryId == null ? "null" : this.VATCountryId.ToString())}");
            toStringOutput.Add($"this.VATCountryISOCode = {(this.VATCountryISOCode == null ? "null" : this.VATCountryISOCode)}");
            toStringOutput.Add($"this.VATCountryOpCoId = {(this.VATCountryOpCoId == null ? "null" : this.VATCountryOpCoId)}");
            toStringOutput.Add($"this.DocumentReference = {(this.DocumentReference == null ? "null" : this.DocumentReference)}");
            toStringOutput.Add($"this.AdditionalDocuments = {(this.AdditionalDocuments == null ? "null" : $"[{string.Join(", ", this.AdditionalDocuments)} ]")}");
        }
    }
}