// <copyright file="BonusHistory.cs" company="APIMatic">
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
    /// BonusHistory.
    /// </summary>
    public class BonusHistory
    {
        private int? payerId;
        private string payerNumber;
        private string payerShortName;
        private string payerFullName;
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private string accountFullName;
        private int? invoiceAccountId;
        private string invoiceAccountNumber;
        private string invoiceAccountShortName;
        private string invoiceAccountFullName;
        private string feeRuleId;
        private string feeRuleDescription;
        private string fromDate;
        private string toDate;
        private string bonusPaidTo;
        private int? feeItemId;
        private string feeRuleBasis;
        private string feeItemCurrencyCode;
        private string feeItemCurrencySymbol;
        private double? proratedVolume;
        private double? totalVolume;
        private string feeProduct;
        private double? invoiceGrossAmount;
        private double? invoiceNetAmount;
        private double? invoiceVATAmount;
        private bool? isFeeCancelled;
        private double? feeItemTierProratedVolume;
        private double? feeItemTierTotalVolume;
        private int? tierMinimum;
        private double? tierRate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PayerId", false },
            { "PayerNumber", false },
            { "PayerShortName", false },
            { "PayerFullName", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "AccountFullName", false },
            { "InvoiceAccountId", false },
            { "InvoiceAccountNumber", false },
            { "InvoiceAccountShortName", false },
            { "InvoiceAccountFullName", false },
            { "FeeRuleId", false },
            { "FeeRuleDescription", false },
            { "FromDate", false },
            { "ToDate", false },
            { "BonusPaidTo", false },
            { "FeeItemId", false },
            { "FeeRuleBasis", false },
            { "FeeItemCurrencyCode", false },
            { "FeeItemCurrencySymbol", false },
            { "ProratedVolume", false },
            { "TotalVolume", false },
            { "FeeProduct", false },
            { "InvoiceGrossAmount", false },
            { "InvoiceNetAmount", false },
            { "InvoiceVATAmount", false },
            { "IsFeeCancelled", false },
            { "FeeItemTierProratedVolume", false },
            { "FeeItemTierTotalVolume", false },
            { "TierMinimum", false },
            { "TierRate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusHistory"/> class.
        /// </summary>
        public BonusHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusHistory"/> class.
        /// </summary>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerShortName">PayerShortName.</param>
        /// <param name="payerFullName">PayerFullName.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="accountFullName">AccountFullName.</param>
        /// <param name="invoiceAccountId">InvoiceAccountId.</param>
        /// <param name="invoiceAccountNumber">InvoiceAccountNumber.</param>
        /// <param name="invoiceAccountShortName">InvoiceAccountShortName.</param>
        /// <param name="invoiceAccountFullName">InvoiceAccountFullName.</param>
        /// <param name="feeRuleId">FeeRuleId.</param>
        /// <param name="feeRuleDescription">FeeRuleDescription.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="bonusPaidTo">BonusPaidTo.</param>
        /// <param name="feeItemId">FeeItemId.</param>
        /// <param name="feeRuleBasis">FeeRuleBasis.</param>
        /// <param name="feeItemCurrencyCode">FeeItemCurrencyCode.</param>
        /// <param name="feeItemCurrencySymbol">FeeItemCurrencySymbol.</param>
        /// <param name="proratedVolume">ProratedVolume.</param>
        /// <param name="totalVolume">TotalVolume.</param>
        /// <param name="feeProduct">FeeProduct.</param>
        /// <param name="invoiceGrossAmount">InvoiceGrossAmount.</param>
        /// <param name="invoiceNetAmount">InvoiceNetAmount.</param>
        /// <param name="invoiceVATAmount">InvoiceVATAmount.</param>
        /// <param name="isFeeCancelled">IsFeeCancelled.</param>
        /// <param name="feeItemTierProratedVolume">FeeItemTierProratedVolume.</param>
        /// <param name="feeItemTierTotalVolume">FeeItemTierTotalVolume.</param>
        /// <param name="tierMinimum">TierMinimum.</param>
        /// <param name="tierRate">TierRate.</param>
        public BonusHistory(
            int? payerId = null,
            string payerNumber = null,
            string payerShortName = null,
            string payerFullName = null,
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            string accountFullName = null,
            int? invoiceAccountId = null,
            string invoiceAccountNumber = null,
            string invoiceAccountShortName = null,
            string invoiceAccountFullName = null,
            string feeRuleId = null,
            string feeRuleDescription = null,
            string fromDate = null,
            string toDate = null,
            string bonusPaidTo = null,
            int? feeItemId = null,
            string feeRuleBasis = null,
            string feeItemCurrencyCode = null,
            string feeItemCurrencySymbol = null,
            double? proratedVolume = null,
            double? totalVolume = null,
            string feeProduct = null,
            double? invoiceGrossAmount = null,
            double? invoiceNetAmount = null,
            double? invoiceVATAmount = null,
            bool? isFeeCancelled = null,
            double? feeItemTierProratedVolume = null,
            double? feeItemTierTotalVolume = null,
            int? tierMinimum = null,
            double? tierRate = null)
        {
            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerShortName != null)
            {
                this.PayerShortName = payerShortName;
            }

            if (payerFullName != null)
            {
                this.PayerFullName = payerFullName;
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

            if (accountFullName != null)
            {
                this.AccountFullName = accountFullName;
            }

            if (invoiceAccountId != null)
            {
                this.InvoiceAccountId = invoiceAccountId;
            }

            if (invoiceAccountNumber != null)
            {
                this.InvoiceAccountNumber = invoiceAccountNumber;
            }

            if (invoiceAccountShortName != null)
            {
                this.InvoiceAccountShortName = invoiceAccountShortName;
            }

            if (invoiceAccountFullName != null)
            {
                this.InvoiceAccountFullName = invoiceAccountFullName;
            }

            if (feeRuleId != null)
            {
                this.FeeRuleId = feeRuleId;
            }

            if (feeRuleDescription != null)
            {
                this.FeeRuleDescription = feeRuleDescription;
            }

            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            if (bonusPaidTo != null)
            {
                this.BonusPaidTo = bonusPaidTo;
            }

            if (feeItemId != null)
            {
                this.FeeItemId = feeItemId;
            }

            if (feeRuleBasis != null)
            {
                this.FeeRuleBasis = feeRuleBasis;
            }

            if (feeItemCurrencyCode != null)
            {
                this.FeeItemCurrencyCode = feeItemCurrencyCode;
            }

            if (feeItemCurrencySymbol != null)
            {
                this.FeeItemCurrencySymbol = feeItemCurrencySymbol;
            }

            if (proratedVolume != null)
            {
                this.ProratedVolume = proratedVolume;
            }

            if (totalVolume != null)
            {
                this.TotalVolume = totalVolume;
            }

            if (feeProduct != null)
            {
                this.FeeProduct = feeProduct;
            }

            if (invoiceGrossAmount != null)
            {
                this.InvoiceGrossAmount = invoiceGrossAmount;
            }

            if (invoiceNetAmount != null)
            {
                this.InvoiceNetAmount = invoiceNetAmount;
            }

            if (invoiceVATAmount != null)
            {
                this.InvoiceVATAmount = invoiceVATAmount;
            }

            if (isFeeCancelled != null)
            {
                this.IsFeeCancelled = isFeeCancelled;
            }

            if (feeItemTierProratedVolume != null)
            {
                this.FeeItemTierProratedVolume = feeItemTierProratedVolume;
            }

            if (feeItemTierTotalVolume != null)
            {
                this.FeeItemTierTotalVolume = feeItemTierTotalVolume;
            }

            if (tierMinimum != null)
            {
                this.TierMinimum = tierMinimum;
            }

            if (tierRate != null)
            {
                this.TierRate = tierRate;
            }

        }

        /// <summary>
        /// Payer Id
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
        /// Payer Number of the selected payer
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
        /// Payer short name.
        /// </summary>
        [JsonProperty("PayerShortName")]
        public string PayerShortName
        {
            get
            {
                return this.payerShortName;
            }

            set
            {
                this.shouldSerialize["PayerShortName"] = true;
                this.payerShortName = value;
            }
        }

        /// <summary>
        /// Payer full name.
        /// </summary>
        [JsonProperty("PayerFullName")]
        public string PayerFullName
        {
            get
            {
                return this.payerFullName;
            }

            set
            {
                this.shouldSerialize["PayerFullName"] = true;
                this.payerFullName = value;
            }
        }

        /// <summary>
        /// Account Id
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
        /// Account Number of the selected payer.
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
        /// Account short name.
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
        /// Account full name.
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
        /// Invoice Account Id
        /// </summary>
        [JsonProperty("InvoiceAccountId")]
        public int? InvoiceAccountId
        {
            get
            {
                return this.invoiceAccountId;
            }

            set
            {
                this.shouldSerialize["InvoiceAccountId"] = true;
                this.invoiceAccountId = value;
            }
        }

        /// <summary>
        /// Invoice Account Number of the selected payer.
        /// </summary>
        [JsonProperty("InvoiceAccountNumber")]
        public string InvoiceAccountNumber
        {
            get
            {
                return this.invoiceAccountNumber;
            }

            set
            {
                this.shouldSerialize["InvoiceAccountNumber"] = true;
                this.invoiceAccountNumber = value;
            }
        }

        /// <summary>
        /// Invoice Account short name.
        /// </summary>
        [JsonProperty("InvoiceAccountShortName")]
        public string InvoiceAccountShortName
        {
            get
            {
                return this.invoiceAccountShortName;
            }

            set
            {
                this.shouldSerialize["InvoiceAccountShortName"] = true;
                this.invoiceAccountShortName = value;
            }
        }

        /// <summary>
        /// Invoice Account full name.
        /// </summary>
        [JsonProperty("InvoiceAccountFullName")]
        public string InvoiceAccountFullName
        {
            get
            {
                return this.invoiceAccountFullName;
            }

            set
            {
                this.shouldSerialize["InvoiceAccountFullName"] = true;
                this.invoiceAccountFullName = value;
            }
        }

        /// <summary>
        /// Bonus or association bonus configuration identifier
        /// </summary>
        [JsonProperty("FeeRuleId")]
        public string FeeRuleId
        {
            get
            {
                return this.feeRuleId;
            }

            set
            {
                this.shouldSerialize["FeeRuleId"] = true;
                this.feeRuleId = value;
            }
        }

        /// <summary>
        /// Bonus or association bonus configuration description that is associated to the bonus fee item
        /// </summary>
        [JsonProperty("FeeRuleDescription")]
        public string FeeRuleDescription
        {
            get
            {
                return this.feeRuleDescription;
            }

            set
            {
                this.shouldSerialize["FeeRuleDescription"] = true;
                this.feeRuleDescription = value;
            }
        }

        /// <summary>
        /// Bonus was calculated from this date.
        /// Format: YYYYMMDD
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
        /// Bonus was calculated till this date.
        /// Format: YYYYMMDD
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
        /// Specifies how the bonus was paid back.
        /// Format: ID-Description
        /// Example:
        /// 1-Pay to Payer
        /// 2-Pay to invoice levels before the payer
        /// 3-Pay to specific customer
        /// 4-Pay to Association Customer
        /// 5-Pay to Associated Customers
        /// </summary>
        [JsonProperty("BonusPaidTo")]
        public string BonusPaidTo
        {
            get
            {
                return this.bonusPaidTo;
            }

            set
            {
                this.shouldSerialize["BonusPaidTo"] = true;
                this.bonusPaidTo = value;
            }
        }

        /// <summary>
        /// Bonus fee item identifier.
        /// </summary>
        [JsonProperty("FeeItemId")]
        public int? FeeItemId
        {
            get
            {
                return this.feeItemId;
            }

            set
            {
                this.shouldSerialize["FeeItemId"] = true;
                this.feeItemId = value;
            }
        }

        /// <summary>
        /// Fee Rule Basis of the bonus fee item.
        /// Format: ID-Description
        /// Example:
        /// 1-Currency Per Unit
        /// 2-Percentage of Uplift
        /// 3-Lump Sum
        /// </summary>
        [JsonProperty("FeeRuleBasis")]
        public string FeeRuleBasis
        {
            get
            {
                return this.feeRuleBasis;
            }

            set
            {
                this.shouldSerialize["FeeRuleBasis"] = true;
                this.feeRuleBasis = value;
            }
        }

        /// <summary>
        /// ISO currency code of the currency in which Bonus is paid.
        /// Example: GBP
        /// </summary>
        [JsonProperty("FeeItemCurrencyCode")]
        public string FeeItemCurrencyCode
        {
            get
            {
                return this.feeItemCurrencyCode;
            }

            set
            {
                this.shouldSerialize["FeeItemCurrencyCode"] = true;
                this.feeItemCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of the currency in which Bonus is paid.
        /// </summary>
        [JsonProperty("FeeItemCurrencySymbol")]
        public string FeeItemCurrencySymbol
        {
            get
            {
                return this.feeItemCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["FeeItemCurrencySymbol"] = true;
                this.feeItemCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Prorated volume considered under the account as  configured for the bonus association.
        /// </summary>
        [JsonProperty("ProratedVolume")]
        public double? ProratedVolume
        {
            get
            {
                return this.proratedVolume;
            }

            set
            {
                this.shouldSerialize["ProratedVolume"] = true;
                this.proratedVolume = value;
            }
        }

        /// <summary>
        /// Total volume considered for calculating the bonus.
        /// </summary>
        [JsonProperty("TotalVolume")]
        public double? TotalVolume
        {
            get
            {
                return this.totalVolume;
            }

            set
            {
                this.shouldSerialize["TotalVolume"] = true;
                this.totalVolume = value;
            }
        }

        /// <summary>
        /// Product as shown in the invoice for the bonus paid.
        /// Format: ID-Description
        /// Example: 1562-Bonus diesel Shell Netherlands on agreed site(s)
        /// </summary>
        [JsonProperty("FeeProduct")]
        public string FeeProduct
        {
            get
            {
                return this.feeProduct;
            }

            set
            {
                this.shouldSerialize["FeeProduct"] = true;
                this.feeProduct = value;
            }
        }

        /// <summary>
        /// Gross Amount – Bonus Paid including VAT as shown on the Invoice
        /// </summary>
        [JsonProperty("InvoiceGrossAmount")]
        public double? InvoiceGrossAmount
        {
            get
            {
                return this.invoiceGrossAmount;
            }

            set
            {
                this.shouldSerialize["InvoiceGrossAmount"] = true;
                this.invoiceGrossAmount = value;
            }
        }

        /// <summary>
        /// Net Amount – Bonus Paid excluding VAT as shown on the Invoice
        /// </summary>
        [JsonProperty("InvoiceNetAmount")]
        public double? InvoiceNetAmount
        {
            get
            {
                return this.invoiceNetAmount;
            }

            set
            {
                this.shouldSerialize["InvoiceNetAmount"] = true;
                this.invoiceNetAmount = value;
            }
        }

        /// <summary>
        /// VAT calculated for the bonus paid as shown on the Invoice
        /// </summary>
        [JsonProperty("InvoiceVATAmount")]
        public double? InvoiceVATAmount
        {
            get
            {
                return this.invoiceVATAmount;
            }

            set
            {
                this.shouldSerialize["InvoiceVATAmount"] = true;
                this.invoiceVATAmount = value;
            }
        }

        /// <summary>
        /// True/False
        /// True if bonus is generated but cancelled. When true, consider this as not paid.
        /// </summary>
        [JsonProperty("IsFeeCancelled")]
        public bool? IsFeeCancelled
        {
            get
            {
                return this.isFeeCancelled;
            }

            set
            {
                this.shouldSerialize["IsFeeCancelled"] = true;
                this.isFeeCancelled = value;
            }
        }

        /// <summary>
        /// Prorated volume in the bonus fee item tier.
        /// </summary>
        [JsonProperty("FeeItemTierProratedVolume")]
        public double? FeeItemTierProratedVolume
        {
            get
            {
                return this.feeItemTierProratedVolume;
            }

            set
            {
                this.shouldSerialize["FeeItemTierProratedVolume"] = true;
                this.feeItemTierProratedVolume = value;
            }
        }

        /// <summary>
        /// Total volume in the bonus fee item tier.
        /// </summary>
        [JsonProperty("FeeItemTierTotalVolume")]
        public double? FeeItemTierTotalVolume
        {
            get
            {
                return this.feeItemTierTotalVolume;
            }

            set
            {
                this.shouldSerialize["FeeItemTierTotalVolume"] = true;
                this.feeItemTierTotalVolume = value;
            }
        }

        /// <summary>
        /// Tier minimum value considered for calculation
        /// </summary>
        [JsonProperty("TierMinimum")]
        public int? TierMinimum
        {
            get
            {
                return this.tierMinimum;
            }

            set
            {
                this.shouldSerialize["TierMinimum"] = true;
                this.tierMinimum = value;
            }
        }

        /// <summary>
        /// Tier rate considered for calculation
        /// </summary>
        [JsonProperty("TierRate")]
        public double? TierRate
        {
            get
            {
                return this.tierRate;
            }

            set
            {
                this.shouldSerialize["TierRate"] = true;
                this.tierRate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BonusHistory : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPayerShortName()
        {
            this.shouldSerialize["PayerShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerFullName()
        {
            this.shouldSerialize["PayerFullName"] = false;
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
        public void UnsetAccountFullName()
        {
            this.shouldSerialize["AccountFullName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceAccountId()
        {
            this.shouldSerialize["InvoiceAccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceAccountNumber()
        {
            this.shouldSerialize["InvoiceAccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceAccountShortName()
        {
            this.shouldSerialize["InvoiceAccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceAccountFullName()
        {
            this.shouldSerialize["InvoiceAccountFullName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleId()
        {
            this.shouldSerialize["FeeRuleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleDescription()
        {
            this.shouldSerialize["FeeRuleDescription"] = false;
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
        public void UnsetBonusPaidTo()
        {
            this.shouldSerialize["BonusPaidTo"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeItemId()
        {
            this.shouldSerialize["FeeItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleBasis()
        {
            this.shouldSerialize["FeeRuleBasis"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeItemCurrencyCode()
        {
            this.shouldSerialize["FeeItemCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeItemCurrencySymbol()
        {
            this.shouldSerialize["FeeItemCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProratedVolume()
        {
            this.shouldSerialize["ProratedVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalVolume()
        {
            this.shouldSerialize["TotalVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeProduct()
        {
            this.shouldSerialize["FeeProduct"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceGrossAmount()
        {
            this.shouldSerialize["InvoiceGrossAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceNetAmount()
        {
            this.shouldSerialize["InvoiceNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceVATAmount()
        {
            this.shouldSerialize["InvoiceVATAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsFeeCancelled()
        {
            this.shouldSerialize["IsFeeCancelled"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeItemTierProratedVolume()
        {
            this.shouldSerialize["FeeItemTierProratedVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeItemTierTotalVolume()
        {
            this.shouldSerialize["FeeItemTierTotalVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTierMinimum()
        {
            this.shouldSerialize["TierMinimum"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTierRate()
        {
            this.shouldSerialize["TierRate"] = false;
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
        public bool ShouldSerializePayerShortName()
        {
            return this.shouldSerialize["PayerShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerFullName()
        {
            return this.shouldSerialize["PayerFullName"];
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
        public bool ShouldSerializeAccountFullName()
        {
            return this.shouldSerialize["AccountFullName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceAccountId()
        {
            return this.shouldSerialize["InvoiceAccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceAccountNumber()
        {
            return this.shouldSerialize["InvoiceAccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceAccountShortName()
        {
            return this.shouldSerialize["InvoiceAccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceAccountFullName()
        {
            return this.shouldSerialize["InvoiceAccountFullName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleId()
        {
            return this.shouldSerialize["FeeRuleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleDescription()
        {
            return this.shouldSerialize["FeeRuleDescription"];
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
        public bool ShouldSerializeBonusPaidTo()
        {
            return this.shouldSerialize["BonusPaidTo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeItemId()
        {
            return this.shouldSerialize["FeeItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleBasis()
        {
            return this.shouldSerialize["FeeRuleBasis"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeItemCurrencyCode()
        {
            return this.shouldSerialize["FeeItemCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeItemCurrencySymbol()
        {
            return this.shouldSerialize["FeeItemCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProratedVolume()
        {
            return this.shouldSerialize["ProratedVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalVolume()
        {
            return this.shouldSerialize["TotalVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeProduct()
        {
            return this.shouldSerialize["FeeProduct"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceGrossAmount()
        {
            return this.shouldSerialize["InvoiceGrossAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceNetAmount()
        {
            return this.shouldSerialize["InvoiceNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceVATAmount()
        {
            return this.shouldSerialize["InvoiceVATAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsFeeCancelled()
        {
            return this.shouldSerialize["IsFeeCancelled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeItemTierProratedVolume()
        {
            return this.shouldSerialize["FeeItemTierProratedVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeItemTierTotalVolume()
        {
            return this.shouldSerialize["FeeItemTierTotalVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTierMinimum()
        {
            return this.shouldSerialize["TierMinimum"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTierRate()
        {
            return this.shouldSerialize["TierRate"];
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
            return obj is BonusHistory other &&                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerShortName == null && other.PayerShortName == null) || (this.PayerShortName?.Equals(other.PayerShortName) == true)) &&
                ((this.PayerFullName == null && other.PayerFullName == null) || (this.PayerFullName?.Equals(other.PayerFullName) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.AccountFullName == null && other.AccountFullName == null) || (this.AccountFullName?.Equals(other.AccountFullName) == true)) &&
                ((this.InvoiceAccountId == null && other.InvoiceAccountId == null) || (this.InvoiceAccountId?.Equals(other.InvoiceAccountId) == true)) &&
                ((this.InvoiceAccountNumber == null && other.InvoiceAccountNumber == null) || (this.InvoiceAccountNumber?.Equals(other.InvoiceAccountNumber) == true)) &&
                ((this.InvoiceAccountShortName == null && other.InvoiceAccountShortName == null) || (this.InvoiceAccountShortName?.Equals(other.InvoiceAccountShortName) == true)) &&
                ((this.InvoiceAccountFullName == null && other.InvoiceAccountFullName == null) || (this.InvoiceAccountFullName?.Equals(other.InvoiceAccountFullName) == true)) &&
                ((this.FeeRuleId == null && other.FeeRuleId == null) || (this.FeeRuleId?.Equals(other.FeeRuleId) == true)) &&
                ((this.FeeRuleDescription == null && other.FeeRuleDescription == null) || (this.FeeRuleDescription?.Equals(other.FeeRuleDescription) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.BonusPaidTo == null && other.BonusPaidTo == null) || (this.BonusPaidTo?.Equals(other.BonusPaidTo) == true)) &&
                ((this.FeeItemId == null && other.FeeItemId == null) || (this.FeeItemId?.Equals(other.FeeItemId) == true)) &&
                ((this.FeeRuleBasis == null && other.FeeRuleBasis == null) || (this.FeeRuleBasis?.Equals(other.FeeRuleBasis) == true)) &&
                ((this.FeeItemCurrencyCode == null && other.FeeItemCurrencyCode == null) || (this.FeeItemCurrencyCode?.Equals(other.FeeItemCurrencyCode) == true)) &&
                ((this.FeeItemCurrencySymbol == null && other.FeeItemCurrencySymbol == null) || (this.FeeItemCurrencySymbol?.Equals(other.FeeItemCurrencySymbol) == true)) &&
                ((this.ProratedVolume == null && other.ProratedVolume == null) || (this.ProratedVolume?.Equals(other.ProratedVolume) == true)) &&
                ((this.TotalVolume == null && other.TotalVolume == null) || (this.TotalVolume?.Equals(other.TotalVolume) == true)) &&
                ((this.FeeProduct == null && other.FeeProduct == null) || (this.FeeProduct?.Equals(other.FeeProduct) == true)) &&
                ((this.InvoiceGrossAmount == null && other.InvoiceGrossAmount == null) || (this.InvoiceGrossAmount?.Equals(other.InvoiceGrossAmount) == true)) &&
                ((this.InvoiceNetAmount == null && other.InvoiceNetAmount == null) || (this.InvoiceNetAmount?.Equals(other.InvoiceNetAmount) == true)) &&
                ((this.InvoiceVATAmount == null && other.InvoiceVATAmount == null) || (this.InvoiceVATAmount?.Equals(other.InvoiceVATAmount) == true)) &&
                ((this.IsFeeCancelled == null && other.IsFeeCancelled == null) || (this.IsFeeCancelled?.Equals(other.IsFeeCancelled) == true)) &&
                ((this.FeeItemTierProratedVolume == null && other.FeeItemTierProratedVolume == null) || (this.FeeItemTierProratedVolume?.Equals(other.FeeItemTierProratedVolume) == true)) &&
                ((this.FeeItemTierTotalVolume == null && other.FeeItemTierTotalVolume == null) || (this.FeeItemTierTotalVolume?.Equals(other.FeeItemTierTotalVolume) == true)) &&
                ((this.TierMinimum == null && other.TierMinimum == null) || (this.TierMinimum?.Equals(other.TierMinimum) == true)) &&
                ((this.TierRate == null && other.TierRate == null) || (this.TierRate?.Equals(other.TierRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerShortName = {(this.PayerShortName == null ? "null" : this.PayerShortName)}");
            toStringOutput.Add($"this.PayerFullName = {(this.PayerFullName == null ? "null" : this.PayerFullName)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.AccountFullName = {(this.AccountFullName == null ? "null" : this.AccountFullName)}");
            toStringOutput.Add($"this.InvoiceAccountId = {(this.InvoiceAccountId == null ? "null" : this.InvoiceAccountId.ToString())}");
            toStringOutput.Add($"this.InvoiceAccountNumber = {(this.InvoiceAccountNumber == null ? "null" : this.InvoiceAccountNumber)}");
            toStringOutput.Add($"this.InvoiceAccountShortName = {(this.InvoiceAccountShortName == null ? "null" : this.InvoiceAccountShortName)}");
            toStringOutput.Add($"this.InvoiceAccountFullName = {(this.InvoiceAccountFullName == null ? "null" : this.InvoiceAccountFullName)}");
            toStringOutput.Add($"this.FeeRuleId = {(this.FeeRuleId == null ? "null" : this.FeeRuleId)}");
            toStringOutput.Add($"this.FeeRuleDescription = {(this.FeeRuleDescription == null ? "null" : this.FeeRuleDescription)}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.BonusPaidTo = {(this.BonusPaidTo == null ? "null" : this.BonusPaidTo)}");
            toStringOutput.Add($"this.FeeItemId = {(this.FeeItemId == null ? "null" : this.FeeItemId.ToString())}");
            toStringOutput.Add($"this.FeeRuleBasis = {(this.FeeRuleBasis == null ? "null" : this.FeeRuleBasis)}");
            toStringOutput.Add($"this.FeeItemCurrencyCode = {(this.FeeItemCurrencyCode == null ? "null" : this.FeeItemCurrencyCode)}");
            toStringOutput.Add($"this.FeeItemCurrencySymbol = {(this.FeeItemCurrencySymbol == null ? "null" : this.FeeItemCurrencySymbol)}");
            toStringOutput.Add($"this.ProratedVolume = {(this.ProratedVolume == null ? "null" : this.ProratedVolume.ToString())}");
            toStringOutput.Add($"this.TotalVolume = {(this.TotalVolume == null ? "null" : this.TotalVolume.ToString())}");
            toStringOutput.Add($"this.FeeProduct = {(this.FeeProduct == null ? "null" : this.FeeProduct)}");
            toStringOutput.Add($"this.InvoiceGrossAmount = {(this.InvoiceGrossAmount == null ? "null" : this.InvoiceGrossAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceNetAmount = {(this.InvoiceNetAmount == null ? "null" : this.InvoiceNetAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceVATAmount = {(this.InvoiceVATAmount == null ? "null" : this.InvoiceVATAmount.ToString())}");
            toStringOutput.Add($"this.IsFeeCancelled = {(this.IsFeeCancelled == null ? "null" : this.IsFeeCancelled.ToString())}");
            toStringOutput.Add($"this.FeeItemTierProratedVolume = {(this.FeeItemTierProratedVolume == null ? "null" : this.FeeItemTierProratedVolume.ToString())}");
            toStringOutput.Add($"this.FeeItemTierTotalVolume = {(this.FeeItemTierTotalVolume == null ? "null" : this.FeeItemTierTotalVolume.ToString())}");
            toStringOutput.Add($"this.TierMinimum = {(this.TierMinimum == null ? "null" : this.TierMinimum.ToString())}");
            toStringOutput.Add($"this.TierRate = {(this.TierRate == null ? "null" : this.TierRate.ToString())}");
        }
    }
}