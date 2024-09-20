// <copyright file="PaymentsSinceLastSOA.cs" company="APIMatic">
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
    /// PaymentsSinceLastSOA.
    /// </summary>
    public class PaymentsSinceLastSOA
    {
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private int? summaryDocumentId;
        private string summaryDocumentNumber;
        private string summaryDocumentDate;
        private string summaryDocumentPaymentDueDate;
        private double? summaryDocumentTotalValue;
        private double? summaryDocumentTotalVAT;
        private double? summaryDocumentDDAmount;
        private string paymentDate;
        private string paymentReference;
        private string paymentCurrencyCode;
        private string paymentCurrencySymbol;
        private double? amountPaid;
        private double? balance;
        private string truePayment;
        private double? prepaidBalance;
        private string localCurrencyCode;
        private string localCurrencySymbol;
        private string localCurrencyExchangeRate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "SummaryDocumentId", false },
            { "SummaryDocumentNumber", false },
            { "SummaryDocumentDate", false },
            { "SummaryDocumentPaymentDueDate", false },
            { "SummaryDocumentTotalValue", false },
            { "SummaryDocumentTotalVAT", false },
            { "SummaryDocumentDDAmount", false },
            { "PaymentDate", false },
            { "PaymentReference", false },
            { "PaymentCurrencyCode", false },
            { "PaymentCurrencySymbol", false },
            { "AmountPaid", false },
            { "Balance", false },
            { "TruePayment", false },
            { "PrepaidBalance", false },
            { "LocalCurrencyCode", false },
            { "LocalCurrencySymbol", false },
            { "LocalCurrencyExchangeRate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsSinceLastSOA"/> class.
        /// </summary>
        public PaymentsSinceLastSOA()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsSinceLastSOA"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="summaryDocumentId">SummaryDocumentId.</param>
        /// <param name="summaryDocumentNumber">SummaryDocumentNumber.</param>
        /// <param name="summaryDocumentDate">SummaryDocumentDate.</param>
        /// <param name="summaryDocumentPaymentDueDate">SummaryDocumentPaymentDueDate.</param>
        /// <param name="summaryDocumentTotalValue">SummaryDocumentTotalValue.</param>
        /// <param name="summaryDocumentTotalVAT">SummaryDocumentTotalVAT.</param>
        /// <param name="summaryDocumentDDAmount">SummaryDocumentDDAmount.</param>
        /// <param name="paymentDate">PaymentDate.</param>
        /// <param name="paymentReference">PaymentReference.</param>
        /// <param name="paymentCurrencyCode">PaymentCurrencyCode.</param>
        /// <param name="paymentCurrencySymbol">PaymentCurrencySymbol.</param>
        /// <param name="amountPaid">AmountPaid.</param>
        /// <param name="balance">Balance.</param>
        /// <param name="truePayment">TruePayment.</param>
        /// <param name="prepaidBalance">PrepaidBalance.</param>
        /// <param name="localCurrencyCode">LocalCurrencyCode.</param>
        /// <param name="localCurrencySymbol">LocalCurrencySymbol.</param>
        /// <param name="localCurrencyExchangeRate">LocalCurrencyExchangeRate.</param>
        public PaymentsSinceLastSOA(
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            int? summaryDocumentId = null,
            string summaryDocumentNumber = null,
            string summaryDocumentDate = null,
            string summaryDocumentPaymentDueDate = null,
            double? summaryDocumentTotalValue = null,
            double? summaryDocumentTotalVAT = null,
            double? summaryDocumentDDAmount = null,
            string paymentDate = null,
            string paymentReference = null,
            string paymentCurrencyCode = null,
            string paymentCurrencySymbol = null,
            double? amountPaid = null,
            double? balance = null,
            string truePayment = null,
            double? prepaidBalance = null,
            string localCurrencyCode = null,
            string localCurrencySymbol = null,
            string localCurrencyExchangeRate = null)
        {
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

            if (summaryDocumentId != null)
            {
                this.SummaryDocumentId = summaryDocumentId;
            }

            if (summaryDocumentNumber != null)
            {
                this.SummaryDocumentNumber = summaryDocumentNumber;
            }

            if (summaryDocumentDate != null)
            {
                this.SummaryDocumentDate = summaryDocumentDate;
            }

            if (summaryDocumentPaymentDueDate != null)
            {
                this.SummaryDocumentPaymentDueDate = summaryDocumentPaymentDueDate;
            }

            if (summaryDocumentTotalValue != null)
            {
                this.SummaryDocumentTotalValue = summaryDocumentTotalValue;
            }

            if (summaryDocumentTotalVAT != null)
            {
                this.SummaryDocumentTotalVAT = summaryDocumentTotalVAT;
            }

            if (summaryDocumentDDAmount != null)
            {
                this.SummaryDocumentDDAmount = summaryDocumentDDAmount;
            }

            if (paymentDate != null)
            {
                this.PaymentDate = paymentDate;
            }

            if (paymentReference != null)
            {
                this.PaymentReference = paymentReference;
            }

            if (paymentCurrencyCode != null)
            {
                this.PaymentCurrencyCode = paymentCurrencyCode;
            }

            if (paymentCurrencySymbol != null)
            {
                this.PaymentCurrencySymbol = paymentCurrencySymbol;
            }

            if (amountPaid != null)
            {
                this.AmountPaid = amountPaid;
            }

            if (balance != null)
            {
                this.Balance = balance;
            }

            if (truePayment != null)
            {
                this.TruePayment = truePayment;
            }

            if (prepaidBalance != null)
            {
                this.PrepaidBalance = prepaidBalance;
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
        /// Account Identifier for which payment is made.
        /// Example: 12345
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
        /// Account number for which payment is made.
        /// Example: GB000000123
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
        /// Example: GB Earth Movers-SN
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
        /// Summary billing document reference id.
        /// Example: 2
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
        /// Summary billing document reference number.
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
        /// Summary billing document date.
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
        /// Payment due date of the Summary billing document.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("SummaryDocumentPaymentDueDate")]
        public string SummaryDocumentPaymentDueDate
        {
            get
            {
                return this.summaryDocumentPaymentDueDate;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentPaymentDueDate"] = true;
                this.summaryDocumentPaymentDueDate = value;
            }
        }

        /// <summary>
        /// Total value in the Summary billing document.
        /// </summary>
        [JsonProperty("SummaryDocumentTotalValue")]
        public double? SummaryDocumentTotalValue
        {
            get
            {
                return this.summaryDocumentTotalValue;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentTotalValue"] = true;
                this.summaryDocumentTotalValue = value;
            }
        }

        /// <summary>
        /// Total VAT in the Summary billing document.
        /// </summary>
        [JsonProperty("SummaryDocumentTotalVAT")]
        public double? SummaryDocumentTotalVAT
        {
            get
            {
                return this.summaryDocumentTotalVAT;
            }

            set
            {
                this.shouldSerialize["SummaryDocumentTotalVAT"] = true;
                this.summaryDocumentTotalVAT = value;
            }
        }

        /// <summary>
        /// Total DD amount in the Summary billing document.
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
        /// Date of payment.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("PaymentDate")]
        public string PaymentDate
        {
            get
            {
                return this.paymentDate;
            }

            set
            {
                this.shouldSerialize["PaymentDate"] = true;
                this.paymentDate = value;
            }
        }

        /// <summary>
        /// Reference text of the payment.
        /// </summary>
        [JsonProperty("PaymentReference")]
        public string PaymentReference
        {
            get
            {
                return this.paymentReference;
            }

            set
            {
                this.shouldSerialize["PaymentReference"] = true;
                this.paymentReference = value;
            }
        }

        /// <summary>
        /// ISO code of payment currency.
        /// Example: EUR
        /// </summary>
        [JsonProperty("PaymentCurrencyCode")]
        public string PaymentCurrencyCode
        {
            get
            {
                return this.paymentCurrencyCode;
            }

            set
            {
                this.shouldSerialize["PaymentCurrencyCode"] = true;
                this.paymentCurrencyCode = value;
            }
        }

        /// <summary>
        /// Symbol of payment currency.
        /// Example: €
        /// </summary>
        [JsonProperty("PaymentCurrencySymbol")]
        public string PaymentCurrencySymbol
        {
            get
            {
                return this.paymentCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["PaymentCurrencySymbol"] = true;
                this.paymentCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Amount paid.
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
        /// Balance amount to be settled for the Summary document.
        /// </summary>
        [JsonProperty("Balance")]
        public double? Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.shouldSerialize["Balance"] = true;
                this.balance = value;
            }
        }

        /// <summary>
        /// True Payment.
        /// </summary>
        [JsonProperty("TruePayment")]
        public string TruePayment
        {
            get
            {
                return this.truePayment;
            }

            set
            {
                this.shouldSerialize["TruePayment"] = true;
                this.truePayment = value;
            }
        }

        /// <summary>
        /// Balance in the pre-paid amount.
        /// </summary>
        [JsonProperty("PrepaidBalance")]
        public double? PrepaidBalance
        {
            get
            {
                return this.prepaidBalance;
            }

            set
            {
                this.shouldSerialize["PrepaidBalance"] = true;
                this.prepaidBalance = value;
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
        /// Exchange rate from Payment currency to local currency.
        /// </summary>
        [JsonProperty("LocalCurrencyExchangeRate")]
        public string LocalCurrencyExchangeRate
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

            return $"PaymentsSinceLastSOA : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetSummaryDocumentDate()
        {
            this.shouldSerialize["SummaryDocumentDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentPaymentDueDate()
        {
            this.shouldSerialize["SummaryDocumentPaymentDueDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentTotalValue()
        {
            this.shouldSerialize["SummaryDocumentTotalValue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSummaryDocumentTotalVAT()
        {
            this.shouldSerialize["SummaryDocumentTotalVAT"] = false;
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
        public void UnsetPaymentDate()
        {
            this.shouldSerialize["PaymentDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentReference()
        {
            this.shouldSerialize["PaymentReference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentCurrencyCode()
        {
            this.shouldSerialize["PaymentCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentCurrencySymbol()
        {
            this.shouldSerialize["PaymentCurrencySymbol"] = false;
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
        public void UnsetBalance()
        {
            this.shouldSerialize["Balance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTruePayment()
        {
            this.shouldSerialize["TruePayment"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPrepaidBalance()
        {
            this.shouldSerialize["PrepaidBalance"] = false;
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
        public bool ShouldSerializeSummaryDocumentDate()
        {
            return this.shouldSerialize["SummaryDocumentDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentPaymentDueDate()
        {
            return this.shouldSerialize["SummaryDocumentPaymentDueDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentTotalValue()
        {
            return this.shouldSerialize["SummaryDocumentTotalValue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSummaryDocumentTotalVAT()
        {
            return this.shouldSerialize["SummaryDocumentTotalVAT"];
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
        public bool ShouldSerializePaymentDate()
        {
            return this.shouldSerialize["PaymentDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentReference()
        {
            return this.shouldSerialize["PaymentReference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentCurrencyCode()
        {
            return this.shouldSerialize["PaymentCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentCurrencySymbol()
        {
            return this.shouldSerialize["PaymentCurrencySymbol"];
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
        public bool ShouldSerializeBalance()
        {
            return this.shouldSerialize["Balance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTruePayment()
        {
            return this.shouldSerialize["TruePayment"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrepaidBalance()
        {
            return this.shouldSerialize["PrepaidBalance"];
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
            return obj is PaymentsSinceLastSOA other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.SummaryDocumentId == null && other.SummaryDocumentId == null) || (this.SummaryDocumentId?.Equals(other.SummaryDocumentId) == true)) &&
                ((this.SummaryDocumentNumber == null && other.SummaryDocumentNumber == null) || (this.SummaryDocumentNumber?.Equals(other.SummaryDocumentNumber) == true)) &&
                ((this.SummaryDocumentDate == null && other.SummaryDocumentDate == null) || (this.SummaryDocumentDate?.Equals(other.SummaryDocumentDate) == true)) &&
                ((this.SummaryDocumentPaymentDueDate == null && other.SummaryDocumentPaymentDueDate == null) || (this.SummaryDocumentPaymentDueDate?.Equals(other.SummaryDocumentPaymentDueDate) == true)) &&
                ((this.SummaryDocumentTotalValue == null && other.SummaryDocumentTotalValue == null) || (this.SummaryDocumentTotalValue?.Equals(other.SummaryDocumentTotalValue) == true)) &&
                ((this.SummaryDocumentTotalVAT == null && other.SummaryDocumentTotalVAT == null) || (this.SummaryDocumentTotalVAT?.Equals(other.SummaryDocumentTotalVAT) == true)) &&
                ((this.SummaryDocumentDDAmount == null && other.SummaryDocumentDDAmount == null) || (this.SummaryDocumentDDAmount?.Equals(other.SummaryDocumentDDAmount) == true)) &&
                ((this.PaymentDate == null && other.PaymentDate == null) || (this.PaymentDate?.Equals(other.PaymentDate) == true)) &&
                ((this.PaymentReference == null && other.PaymentReference == null) || (this.PaymentReference?.Equals(other.PaymentReference) == true)) &&
                ((this.PaymentCurrencyCode == null && other.PaymentCurrencyCode == null) || (this.PaymentCurrencyCode?.Equals(other.PaymentCurrencyCode) == true)) &&
                ((this.PaymentCurrencySymbol == null && other.PaymentCurrencySymbol == null) || (this.PaymentCurrencySymbol?.Equals(other.PaymentCurrencySymbol) == true)) &&
                ((this.AmountPaid == null && other.AmountPaid == null) || (this.AmountPaid?.Equals(other.AmountPaid) == true)) &&
                ((this.Balance == null && other.Balance == null) || (this.Balance?.Equals(other.Balance) == true)) &&
                ((this.TruePayment == null && other.TruePayment == null) || (this.TruePayment?.Equals(other.TruePayment) == true)) &&
                ((this.PrepaidBalance == null && other.PrepaidBalance == null) || (this.PrepaidBalance?.Equals(other.PrepaidBalance) == true)) &&
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
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.SummaryDocumentId = {(this.SummaryDocumentId == null ? "null" : this.SummaryDocumentId.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentNumber = {(this.SummaryDocumentNumber == null ? "null" : this.SummaryDocumentNumber)}");
            toStringOutput.Add($"this.SummaryDocumentDate = {(this.SummaryDocumentDate == null ? "null" : this.SummaryDocumentDate)}");
            toStringOutput.Add($"this.SummaryDocumentPaymentDueDate = {(this.SummaryDocumentPaymentDueDate == null ? "null" : this.SummaryDocumentPaymentDueDate)}");
            toStringOutput.Add($"this.SummaryDocumentTotalValue = {(this.SummaryDocumentTotalValue == null ? "null" : this.SummaryDocumentTotalValue.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentTotalVAT = {(this.SummaryDocumentTotalVAT == null ? "null" : this.SummaryDocumentTotalVAT.ToString())}");
            toStringOutput.Add($"this.SummaryDocumentDDAmount = {(this.SummaryDocumentDDAmount == null ? "null" : this.SummaryDocumentDDAmount.ToString())}");
            toStringOutput.Add($"this.PaymentDate = {(this.PaymentDate == null ? "null" : this.PaymentDate)}");
            toStringOutput.Add($"this.PaymentReference = {(this.PaymentReference == null ? "null" : this.PaymentReference)}");
            toStringOutput.Add($"this.PaymentCurrencyCode = {(this.PaymentCurrencyCode == null ? "null" : this.PaymentCurrencyCode)}");
            toStringOutput.Add($"this.PaymentCurrencySymbol = {(this.PaymentCurrencySymbol == null ? "null" : this.PaymentCurrencySymbol)}");
            toStringOutput.Add($"this.AmountPaid = {(this.AmountPaid == null ? "null" : this.AmountPaid.ToString())}");
            toStringOutput.Add($"this.Balance = {(this.Balance == null ? "null" : this.Balance.ToString())}");
            toStringOutput.Add($"this.TruePayment = {(this.TruePayment == null ? "null" : this.TruePayment)}");
            toStringOutput.Add($"this.PrepaidBalance = {(this.PrepaidBalance == null ? "null" : this.PrepaidBalance.ToString())}");
            toStringOutput.Add($"this.LocalCurrencyCode = {(this.LocalCurrencyCode == null ? "null" : this.LocalCurrencyCode)}");
            toStringOutput.Add($"this.LocalCurrencySymbol = {(this.LocalCurrencySymbol == null ? "null" : this.LocalCurrencySymbol)}");
            toStringOutput.Add($"this.LocalCurrencyExchangeRate = {(this.LocalCurrencyExchangeRate == null ? "null" : this.LocalCurrencyExchangeRate)}");
        }
    }
}