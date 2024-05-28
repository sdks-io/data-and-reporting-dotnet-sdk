// <copyright file="FeeItem.cs" company="APIMatic">
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
    /// FeeItem.
    /// </summary>
    public class FeeItem
    {
        private int? feeItemId;
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private int? invoiceAccountId;
        private string invoiceAccountNumber;
        private string invoiceAccountShortName;
        private int? payerId;
        private string payerNumber;
        private string payerShortName;
        private int? cardId;
        private string pAN;
        private int? cardGroupId;
        private string cardGroupName;
        private int? feeTypeId;
        private string feeType;
        private string feeTypeGroup;
        private int? feeRuleId;
        private string feeRuleDescription;
        private string feeItemDate;
        private string feeItemTime;
        private bool? isManual;
        private bool? isCancelled;
        private string customerCurrencyCode;
        private string customerCurrencySymbol;
        private int? productId;
        private string productCode;
        private string productName;
        private int? productGroupId;
        private string productGroupName;
        private string lineItemDescription;
        private int? quantity;
        private bool? isInvoiced;
        private string vATCountryCode;
        private string vATCountryName;
        private double? vATPercentage;
        private int? vATCategoryID;
        private string vATCategoryDescription;
        private int? legislativeRegionId;
        private string legislativeRegionName;
        private string systemEntryDate;
        private string systemEntryTime;
        private double? colCoNetAmount;
        private double? colCoVATAmount;
        private double? colCoGrossAmount;
        private int? interimInvoiceId;
        private string interimInvoiceNumber;
        private int? invoiceId;
        private string invoiceNumber;
        private string invoiceDate;
        private double? customerExchangeRate;
        private double? invoiceNetAmount;
        private double? invoiceGrossAmount;
        private double? invoiceVATAmount;
        private bool? reverseCharge;
        private int? originalFeeItemId;
        private string originalCurrencyCode;
        private string originalCurrencySymbol;
        private double? originalUnitPrice;
        private double? originalNetAmount;
        private double? originalVATAmount;
        private double? originalGrossAmount;
        private double? originalExchangeRate;
        private int? originalLegislativeRegionId;
        private string originalLegislativeRegionName;
        private string frequency;
        private string feeItemCardLevelBreakup;
        private int? originalFeeItemInvoiceId;
        private string originalFeeItemInvoiceNumber;
        private string originalFeeItemInvoiceDate;
        private string driverName;
        private string embossText;
        private string vRN;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "FeeItemId", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "InvoiceAccountId", false },
            { "InvoiceAccountNumber", false },
            { "InvoiceAccountShortName", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PayerShortName", false },
            { "CardId", false },
            { "PAN", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "FeeTypeId", false },
            { "FeeType", false },
            { "FeeTypeGroup", false },
            { "FeeRuleId", false },
            { "FeeRuleDescription", false },
            { "FeeItemDate", false },
            { "FeeItemTime", false },
            { "IsManual", false },
            { "IsCancelled", false },
            { "CustomerCurrencyCode", false },
            { "CustomerCurrencySymbol", false },
            { "ProductId", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "ProductGroupId", false },
            { "ProductGroupName", false },
            { "LineItemDescription", false },
            { "Quantity", false },
            { "IsInvoiced", false },
            { "VATCountryCode", false },
            { "VATCountryName", false },
            { "VATPercentage", false },
            { "VATCategoryID", false },
            { "VATCategoryDescription", false },
            { "LegislativeRegionId", false },
            { "LegislativeRegionName", false },
            { "SystemEntryDate", false },
            { "SystemEntryTime", false },
            { "ColCoNetAmount", false },
            { "ColCoVATAmount", false },
            { "ColCoGrossAmount", false },
            { "InterimInvoiceId", false },
            { "InterimInvoiceNumber", false },
            { "InvoiceId", false },
            { "InvoiceNumber", false },
            { "InvoiceDate", false },
            { "CustomerExchangeRate", false },
            { "InvoiceNetAmount", false },
            { "InvoiceGrossAmount", false },
            { "InvoiceVATAmount", false },
            { "ReverseCharge", false },
            { "OriginalFeeItemId", false },
            { "OriginalCurrencyCode", false },
            { "OriginalCurrencySymbol", false },
            { "OriginalUnitPrice", false },
            { "OriginalNetAmount", false },
            { "OriginalVATAmount", false },
            { "OriginalGrossAmount", false },
            { "OriginalExchangeRate", false },
            { "OriginalLegislativeRegionId", false },
            { "OriginalLegislativeRegionName", false },
            { "Frequency", false },
            { "FeeItemCardLevelBreakup", false },
            { "OriginalFeeItemInvoiceId", false },
            { "OriginalFeeItemInvoiceNumber", false },
            { "OriginalFeeItemInvoiceDate", false },
            { "DriverName", false },
            { "EmbossText", false },
            { "VRN", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeItem"/> class.
        /// </summary>
        public FeeItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeItem"/> class.
        /// </summary>
        /// <param name="feeItemId">FeeItemId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="invoiceAccountId">InvoiceAccountId.</param>
        /// <param name="invoiceAccountNumber">InvoiceAccountNumber.</param>
        /// <param name="invoiceAccountShortName">InvoiceAccountShortName.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerShortName">PayerShortName.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="feeTypeId">FeeTypeId.</param>
        /// <param name="feeType">FeeType.</param>
        /// <param name="feeTypeGroup">FeeTypeGroup.</param>
        /// <param name="feeRuleId">FeeRuleId.</param>
        /// <param name="feeRuleDescription">FeeRuleDescription.</param>
        /// <param name="feeRuleTiers">FeeRuleTiers.</param>
        /// <param name="feeItemDate">FeeItemDate.</param>
        /// <param name="feeItemTime">FeeItemTime.</param>
        /// <param name="isManual">IsManual.</param>
        /// <param name="isCancelled">IsCancelled.</param>
        /// <param name="customerCurrencyCode">CustomerCurrencyCode.</param>
        /// <param name="customerCurrencySymbol">CustomerCurrencySymbol.</param>
        /// <param name="productId">ProductId.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="productGroupId">ProductGroupId.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="lineItemDescription">LineItemDescription.</param>
        /// <param name="quantity">Quantity.</param>
        /// <param name="isInvoiced">IsInvoiced.</param>
        /// <param name="vATCountryCode">VATCountryCode.</param>
        /// <param name="vATCountryName">VATCountryName.</param>
        /// <param name="vATPercentage">VATPercentage.</param>
        /// <param name="vATCategoryID">VATCategoryID.</param>
        /// <param name="vATCategoryDescription">VATCategoryDescription.</param>
        /// <param name="legislativeRegionId">LegislativeRegionId.</param>
        /// <param name="legislativeRegionName">LegislativeRegionName.</param>
        /// <param name="systemEntryDate">SystemEntryDate.</param>
        /// <param name="systemEntryTime">SystemEntryTime.</param>
        /// <param name="colCoNetAmount">ColCoNetAmount.</param>
        /// <param name="colCoVATAmount">ColCoVATAmount.</param>
        /// <param name="colCoGrossAmount">ColCoGrossAmount.</param>
        /// <param name="interimInvoiceId">InterimInvoiceId.</param>
        /// <param name="interimInvoiceNumber">InterimInvoiceNumber.</param>
        /// <param name="invoiceId">InvoiceId.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="customerExchangeRate">CustomerExchangeRate.</param>
        /// <param name="invoiceNetAmount">InvoiceNetAmount.</param>
        /// <param name="invoiceGrossAmount">InvoiceGrossAmount.</param>
        /// <param name="invoiceVATAmount">InvoiceVATAmount.</param>
        /// <param name="reverseCharge">ReverseCharge.</param>
        /// <param name="originalFeeItemId">OriginalFeeItemId.</param>
        /// <param name="originalCurrencyCode">OriginalCurrencyCode.</param>
        /// <param name="originalCurrencySymbol">OriginalCurrencySymbol.</param>
        /// <param name="originalUnitPrice">OriginalUnitPrice.</param>
        /// <param name="originalNetAmount">OriginalNetAmount.</param>
        /// <param name="originalVATAmount">OriginalVATAmount.</param>
        /// <param name="originalGrossAmount">OriginalGrossAmount.</param>
        /// <param name="originalExchangeRate">OriginalExchangeRate.</param>
        /// <param name="originalLegislativeRegionId">OriginalLegislativeRegionId.</param>
        /// <param name="originalLegislativeRegionName">OriginalLegislativeRegionName.</param>
        /// <param name="frequency">Frequency.</param>
        /// <param name="feeItemCardLevelBreakup">FeeItemCardLevelBreakup.</param>
        /// <param name="originalFeeItemInvoiceId">OriginalFeeItemInvoiceId.</param>
        /// <param name="originalFeeItemInvoiceNumber">OriginalFeeItemInvoiceNumber.</param>
        /// <param name="originalFeeItemInvoiceDate">OriginalFeeItemInvoiceDate.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="embossText">EmbossText.</param>
        /// <param name="vRN">VRN.</param>
        public FeeItem(
            int? feeItemId = null,
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            int? invoiceAccountId = null,
            string invoiceAccountNumber = null,
            string invoiceAccountShortName = null,
            int? payerId = null,
            string payerNumber = null,
            string payerShortName = null,
            int? cardId = null,
            string pAN = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            int? feeTypeId = null,
            string feeType = null,
            string feeTypeGroup = null,
            int? feeRuleId = null,
            string feeRuleDescription = null,
            List<Models.FeesFeeRuleTiers> feeRuleTiers = null,
            string feeItemDate = null,
            string feeItemTime = null,
            bool? isManual = null,
            bool? isCancelled = null,
            string customerCurrencyCode = null,
            string customerCurrencySymbol = null,
            int? productId = null,
            string productCode = null,
            string productName = null,
            int? productGroupId = null,
            string productGroupName = null,
            string lineItemDescription = null,
            int? quantity = null,
            bool? isInvoiced = null,
            string vATCountryCode = null,
            string vATCountryName = null,
            double? vATPercentage = null,
            int? vATCategoryID = null,
            string vATCategoryDescription = null,
            int? legislativeRegionId = null,
            string legislativeRegionName = null,
            string systemEntryDate = null,
            string systemEntryTime = null,
            double? colCoNetAmount = null,
            double? colCoVATAmount = null,
            double? colCoGrossAmount = null,
            int? interimInvoiceId = null,
            string interimInvoiceNumber = null,
            int? invoiceId = null,
            string invoiceNumber = null,
            string invoiceDate = null,
            double? customerExchangeRate = null,
            double? invoiceNetAmount = null,
            double? invoiceGrossAmount = null,
            double? invoiceVATAmount = null,
            bool? reverseCharge = null,
            int? originalFeeItemId = null,
            string originalCurrencyCode = null,
            string originalCurrencySymbol = null,
            double? originalUnitPrice = null,
            double? originalNetAmount = null,
            double? originalVATAmount = null,
            double? originalGrossAmount = null,
            double? originalExchangeRate = null,
            int? originalLegislativeRegionId = null,
            string originalLegislativeRegionName = null,
            string frequency = null,
            string feeItemCardLevelBreakup = null,
            int? originalFeeItemInvoiceId = null,
            string originalFeeItemInvoiceNumber = null,
            string originalFeeItemInvoiceDate = null,
            string driverName = null,
            string embossText = null,
            string vRN = null)
        {
            if (feeItemId != null)
            {
                this.FeeItemId = feeItemId;
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

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            if (feeTypeId != null)
            {
                this.FeeTypeId = feeTypeId;
            }

            if (feeType != null)
            {
                this.FeeType = feeType;
            }

            if (feeTypeGroup != null)
            {
                this.FeeTypeGroup = feeTypeGroup;
            }

            if (feeRuleId != null)
            {
                this.FeeRuleId = feeRuleId;
            }

            if (feeRuleDescription != null)
            {
                this.FeeRuleDescription = feeRuleDescription;
            }

            this.FeeRuleTiers = feeRuleTiers;
            if (feeItemDate != null)
            {
                this.FeeItemDate = feeItemDate;
            }

            if (feeItemTime != null)
            {
                this.FeeItemTime = feeItemTime;
            }

            if (isManual != null)
            {
                this.IsManual = isManual;
            }

            if (isCancelled != null)
            {
                this.IsCancelled = isCancelled;
            }

            if (customerCurrencyCode != null)
            {
                this.CustomerCurrencyCode = customerCurrencyCode;
            }

            if (customerCurrencySymbol != null)
            {
                this.CustomerCurrencySymbol = customerCurrencySymbol;
            }

            if (productId != null)
            {
                this.ProductId = productId;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (productName != null)
            {
                this.ProductName = productName;
            }

            if (productGroupId != null)
            {
                this.ProductGroupId = productGroupId;
            }

            if (productGroupName != null)
            {
                this.ProductGroupName = productGroupName;
            }

            if (lineItemDescription != null)
            {
                this.LineItemDescription = lineItemDescription;
            }

            if (quantity != null)
            {
                this.Quantity = quantity;
            }

            if (isInvoiced != null)
            {
                this.IsInvoiced = isInvoiced;
            }

            if (vATCountryCode != null)
            {
                this.VATCountryCode = vATCountryCode;
            }

            if (vATCountryName != null)
            {
                this.VATCountryName = vATCountryName;
            }

            if (vATPercentage != null)
            {
                this.VATPercentage = vATPercentage;
            }

            if (vATCategoryID != null)
            {
                this.VATCategoryID = vATCategoryID;
            }

            if (vATCategoryDescription != null)
            {
                this.VATCategoryDescription = vATCategoryDescription;
            }

            if (legislativeRegionId != null)
            {
                this.LegislativeRegionId = legislativeRegionId;
            }

            if (legislativeRegionName != null)
            {
                this.LegislativeRegionName = legislativeRegionName;
            }

            if (systemEntryDate != null)
            {
                this.SystemEntryDate = systemEntryDate;
            }

            if (systemEntryTime != null)
            {
                this.SystemEntryTime = systemEntryTime;
            }

            if (colCoNetAmount != null)
            {
                this.ColCoNetAmount = colCoNetAmount;
            }

            if (colCoVATAmount != null)
            {
                this.ColCoVATAmount = colCoVATAmount;
            }

            if (colCoGrossAmount != null)
            {
                this.ColCoGrossAmount = colCoGrossAmount;
            }

            if (interimInvoiceId != null)
            {
                this.InterimInvoiceId = interimInvoiceId;
            }

            if (interimInvoiceNumber != null)
            {
                this.InterimInvoiceNumber = interimInvoiceNumber;
            }

            if (invoiceId != null)
            {
                this.InvoiceId = invoiceId;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (customerExchangeRate != null)
            {
                this.CustomerExchangeRate = customerExchangeRate;
            }

            if (invoiceNetAmount != null)
            {
                this.InvoiceNetAmount = invoiceNetAmount;
            }

            if (invoiceGrossAmount != null)
            {
                this.InvoiceGrossAmount = invoiceGrossAmount;
            }

            if (invoiceVATAmount != null)
            {
                this.InvoiceVATAmount = invoiceVATAmount;
            }

            if (reverseCharge != null)
            {
                this.ReverseCharge = reverseCharge;
            }

            if (originalFeeItemId != null)
            {
                this.OriginalFeeItemId = originalFeeItemId;
            }

            if (originalCurrencyCode != null)
            {
                this.OriginalCurrencyCode = originalCurrencyCode;
            }

            if (originalCurrencySymbol != null)
            {
                this.OriginalCurrencySymbol = originalCurrencySymbol;
            }

            if (originalUnitPrice != null)
            {
                this.OriginalUnitPrice = originalUnitPrice;
            }

            if (originalNetAmount != null)
            {
                this.OriginalNetAmount = originalNetAmount;
            }

            if (originalVATAmount != null)
            {
                this.OriginalVATAmount = originalVATAmount;
            }

            if (originalGrossAmount != null)
            {
                this.OriginalGrossAmount = originalGrossAmount;
            }

            if (originalExchangeRate != null)
            {
                this.OriginalExchangeRate = originalExchangeRate;
            }

            if (originalLegislativeRegionId != null)
            {
                this.OriginalLegislativeRegionId = originalLegislativeRegionId;
            }

            if (originalLegislativeRegionName != null)
            {
                this.OriginalLegislativeRegionName = originalLegislativeRegionName;
            }

            if (frequency != null)
            {
                this.Frequency = frequency;
            }

            if (feeItemCardLevelBreakup != null)
            {
                this.FeeItemCardLevelBreakup = feeItemCardLevelBreakup;
            }

            if (originalFeeItemInvoiceId != null)
            {
                this.OriginalFeeItemInvoiceId = originalFeeItemInvoiceId;
            }

            if (originalFeeItemInvoiceNumber != null)
            {
                this.OriginalFeeItemInvoiceNumber = originalFeeItemInvoiceNumber;
            }

            if (originalFeeItemInvoiceDate != null)
            {
                this.OriginalFeeItemInvoiceDate = originalFeeItemInvoiceDate;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (embossText != null)
            {
                this.EmbossText = embossText;
            }

            if (vRN != null)
            {
                this.VRN = vRN;
            }

        }

        /// <summary>
        /// Fee Item unique identifier in the H3 Cards Platform
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
        /// Account Number
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
        /// Account short Number
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
        /// Invoice Account Number
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
        /// Invoice Account short Name
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
        /// Payer Number
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
        /// Payer short Name
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
        /// Unique Card Id
        /// </summary>
        [JsonProperty("CardId")]
        public int? CardId
        {
            get
            {
                return this.cardId;
            }

            set
            {
                this.shouldSerialize["CardId"] = true;
                this.cardId = value;
            }
        }

        /// <summary>
        /// Card PAN
        /// </summary>
        [JsonProperty("PAN")]
        public string PAN
        {
            get
            {
                return this.pAN;
            }

            set
            {
                this.shouldSerialize["PAN"] = true;
                this.pAN = value;
            }
        }

        /// <summary>
        /// Card Group Id
        /// </summary>
        [JsonProperty("CardGroupId")]
        public int? CardGroupId
        {
            get
            {
                return this.cardGroupId;
            }

            set
            {
                this.shouldSerialize["CardGroupId"] = true;
                this.cardGroupId = value;
            }
        }

        /// <summary>
        /// Card Group Name
        /// </summary>
        [JsonProperty("CardGroupName")]
        public string CardGroupName
        {
            get
            {
                return this.cardGroupName;
            }

            set
            {
                this.shouldSerialize["CardGroupName"] = true;
                this.cardGroupName = value;
            }
        }

        /// <summary>
        /// Fee type identifier.
        /// </summary>
        [JsonProperty("FeeTypeId")]
        public int? FeeTypeId
        {
            get
            {
                return this.feeTypeId;
            }

            set
            {
                this.shouldSerialize["FeeTypeId"] = true;
                this.feeTypeId = value;
            }
        }

        /// <summary>
        /// Fee type description
        /// </summary>
        [JsonProperty("FeeType")]
        public string FeeType
        {
            get
            {
                return this.feeType;
            }

            set
            {
                this.shouldSerialize["FeeType"] = true;
                this.feeType = value;
            }
        }

        /// <summary>
        /// Fee type group in under which the Fee item is generated.
        /// Example:
        /// Account
        /// Card
        /// Others
        /// </summary>
        [JsonProperty("FeeTypeGroup")]
        public string FeeTypeGroup
        {
            get
            {
                return this.feeTypeGroup;
            }

            set
            {
                this.shouldSerialize["FeeTypeGroup"] = true;
                this.feeTypeGroup = value;
            }
        }

        /// <summary>
        /// Fee rule identifier
        /// </summary>
        [JsonProperty("FeeRuleId")]
        public int? FeeRuleId
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
        /// Fee rule description
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
        /// Gets or sets FeeRuleTiers.
        /// </summary>
        [JsonProperty("FeeRuleTiers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FeesFeeRuleTiers> FeeRuleTiers { get; set; }

        /// <summary>
        /// Local Fee Item Date of when the transaction took place
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("FeeItemDate")]
        public string FeeItemDate
        {
            get
            {
                return this.feeItemDate;
            }

            set
            {
                this.shouldSerialize["FeeItemDate"] = true;
                this.feeItemDate = value;
            }
        }

        /// <summary>
        /// Local Fee Item Time of where the transaction took place
        /// Format: HH:mm:ss (24 hours format)
        /// </summary>
        [JsonProperty("FeeItemTime")]
        public string FeeItemTime
        {
            get
            {
                return this.feeItemTime;
            }

            set
            {
                this.shouldSerialize["FeeItemTime"] = true;
                this.feeItemTime = value;
            }
        }

        /// <summary>
        /// True/False.
        /// Is manual
        /// </summary>
        [JsonProperty("IsManual")]
        public bool? IsManual
        {
            get
            {
                return this.isManual;
            }

            set
            {
                this.shouldSerialize["IsManual"] = true;
                this.isManual = value;
            }
        }

        /// <summary>
        /// True/False.
        /// Is cancelled
        /// </summary>
        [JsonProperty("IsCancelled")]
        public bool? IsCancelled
        {
            get
            {
                return this.isCancelled;
            }

            set
            {
                this.shouldSerialize["IsCancelled"] = true;
                this.isCancelled = value;
            }
        }

        /// <summary>
        /// ISO currency code
        /// Example: GBP
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
        /// Currency symbol of the Currency Code
        /// Example: £, $
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
        /// Product Id
        /// Example: Sample list of product ids and description.
        /// 100 Service fee
        /// 102 Invoice production fee
        /// 103 Account fee
        /// 104 Transaction fee
        /// 105 Card membership fee
        /// </summary>
        [JsonProperty("ProductId")]
        public int? ProductId
        {
            get
            {
                return this.productId;
            }

            set
            {
                this.shouldSerialize["ProductId"] = true;
                this.productId = value;
            }
        }

        /// <summary>
        /// Product Code – Global as per GFN configuration
        /// Example:
        /// 2 Service fee
        /// 4 Invoice production fee
        /// 5 Account fee
        /// 6 Transaction fee
        /// 7 Card membership fee
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode
        {
            get
            {
                return this.productCode;
            }

            set
            {
                this.shouldSerialize["ProductCode"] = true;
                this.productCode = value;
            }
        }

        /// <summary>
        /// Product Name
        /// Example: Sample list of product ids and description.
        /// Service fee
        /// Invoice production fee
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                this.shouldSerialize["ProductName"] = true;
                this.productName = value;
            }
        }

        /// <summary>
        /// Product Group Id
        /// Example: Sample list
        /// 22	Card related fees
        /// 23	Monetary Adjustment
        /// </summary>
        [JsonProperty("ProductGroupId")]
        public int? ProductGroupId
        {
            get
            {
                return this.productGroupId;
            }

            set
            {
                this.shouldSerialize["ProductGroupId"] = true;
                this.productGroupId = value;
            }
        }

        /// <summary>
        /// Product Group Name
        /// Example: Sample list
        /// 22	Card related fees
        /// 23	Monetary Adjustment
        /// </summary>
        [JsonProperty("ProductGroupName")]
        public string ProductGroupName
        {
            get
            {
                return this.productGroupName;
            }

            set
            {
                this.shouldSerialize["ProductGroupName"] = true;
                this.productGroupName = value;
            }
        }

        /// <summary>
        /// Line Item Description generally the quantity as printed on Invoice or the manually keyed in description for manual fees
        /// </summary>
        [JsonProperty("LineItemDescription")]
        public string LineItemDescription
        {
            get
            {
                return this.lineItemDescription;
            }

            set
            {
                this.shouldSerialize["LineItemDescription"] = true;
                this.lineItemDescription = value;
            }
        }

        /// <summary>
        /// Quantity
        /// </summary>
        [JsonProperty("Quantity")]
        public int? Quantity
        {
            get
            {
                return this.quantity;
            }

            set
            {
                this.shouldSerialize["Quantity"] = true;
                this.quantity = value;
            }
        }

        /// <summary>
        /// True/False.
        /// Is fee item invoiced
        /// </summary>
        [JsonProperty("IsInvoiced")]
        public bool? IsInvoiced
        {
            get
            {
                return this.isInvoiced;
            }

            set
            {
                this.shouldSerialize["IsInvoiced"] = true;
                this.isInvoiced = value;
            }
        }

        /// <summary>
        /// VAT country ISO code
        /// </summary>
        [JsonProperty("VATCountryCode")]
        public string VATCountryCode
        {
            get
            {
                return this.vATCountryCode;
            }

            set
            {
                this.shouldSerialize["VATCountryCode"] = true;
                this.vATCountryCode = value;
            }
        }

        /// <summary>
        /// VAT country name
        /// </summary>
        [JsonProperty("VATCountryName")]
        public string VATCountryName
        {
            get
            {
                return this.vATCountryName;
            }

            set
            {
                this.shouldSerialize["VATCountryName"] = true;
                this.vATCountryName = value;
            }
        }

        /// <summary>
        /// VAT percentage
        /// </summary>
        [JsonProperty("VATPercentage")]
        public double? VATPercentage
        {
            get
            {
                return this.vATPercentage;
            }

            set
            {
                this.shouldSerialize["VATPercentage"] = true;
                this.vATPercentage = value;
            }
        }

        /// <summary>
        /// VAT Category identifier
        /// </summary>
        [JsonProperty("VATCategoryID")]
        public int? VATCategoryID
        {
            get
            {
                return this.vATCategoryID;
            }

            set
            {
                this.shouldSerialize["VATCategoryID"] = true;
                this.vATCategoryID = value;
            }
        }

        /// <summary>
        /// VAT Category description
        /// </summary>
        [JsonProperty("VATCategoryDescription")]
        public string VATCategoryDescription
        {
            get
            {
                return this.vATCategoryDescription;
            }

            set
            {
                this.shouldSerialize["VATCategoryDescription"] = true;
                this.vATCategoryDescription = value;
            }
        }

        /// <summary>
        /// Legislative region id
        /// </summary>
        [JsonProperty("LegislativeRegionId")]
        public int? LegislativeRegionId
        {
            get
            {
                return this.legislativeRegionId;
            }

            set
            {
                this.shouldSerialize["LegislativeRegionId"] = true;
                this.legislativeRegionId = value;
            }
        }

        /// <summary>
        /// Legislative region name
        /// </summary>
        [JsonProperty("LegislativeRegionName")]
        public string LegislativeRegionName
        {
            get
            {
                return this.legislativeRegionName;
            }

            set
            {
                this.shouldSerialize["LegislativeRegionName"] = true;
                this.legislativeRegionName = value;
            }
        }

        /// <summary>
        /// System entry date
        /// </summary>
        [JsonProperty("SystemEntryDate")]
        public string SystemEntryDate
        {
            get
            {
                return this.systemEntryDate;
            }

            set
            {
                this.shouldSerialize["SystemEntryDate"] = true;
                this.systemEntryDate = value;
            }
        }

        /// <summary>
        /// System entry time
        /// </summary>
        [JsonProperty("SystemEntryTime")]
        public string SystemEntryTime
        {
            get
            {
                return this.systemEntryTime;
            }

            set
            {
                this.shouldSerialize["SystemEntryTime"] = true;
                this.systemEntryTime = value;
            }
        }

        /// <summary>
        /// ColCo net amount
        /// </summary>
        [JsonProperty("ColCoNetAmount")]
        public double? ColCoNetAmount
        {
            get
            {
                return this.colCoNetAmount;
            }

            set
            {
                this.shouldSerialize["ColCoNetAmount"] = true;
                this.colCoNetAmount = value;
            }
        }

        /// <summary>
        /// ColCoVAT amount
        /// </summary>
        [JsonProperty("ColCoVATAmount")]
        public double? ColCoVATAmount
        {
            get
            {
                return this.colCoVATAmount;
            }

            set
            {
                this.shouldSerialize["ColCoVATAmount"] = true;
                this.colCoVATAmount = value;
            }
        }

        /// <summary>
        /// ColCo gross amount
        /// </summary>
        [JsonProperty("ColCoGrossAmount")]
        public double? ColCoGrossAmount
        {
            get
            {
                return this.colCoGrossAmount;
            }

            set
            {
                this.shouldSerialize["ColCoGrossAmount"] = true;
                this.colCoGrossAmount = value;
            }
        }

        /// <summary>
        /// Interim invoice id
        /// </summary>
        [JsonProperty("InterimInvoiceId")]
        public int? InterimInvoiceId
        {
            get
            {
                return this.interimInvoiceId;
            }

            set
            {
                this.shouldSerialize["InterimInvoiceId"] = true;
                this.interimInvoiceId = value;
            }
        }

        /// <summary>
        /// Interim invoice number
        /// </summary>
        [JsonProperty("InterimInvoiceNumber")]
        public string InterimInvoiceNumber
        {
            get
            {
                return this.interimInvoiceNumber;
            }

            set
            {
                this.shouldSerialize["InterimInvoiceNumber"] = true;
                this.interimInvoiceNumber = value;
            }
        }

        /// <summary>
        /// Invoice id
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
        /// Invoice number
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
        /// Invoice date
        /// Format: yyyyMMdd
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
        /// Customer exchange rate
        /// </summary>
        [JsonProperty("CustomerExchangeRate")]
        public double? CustomerExchangeRate
        {
            get
            {
                return this.customerExchangeRate;
            }

            set
            {
                this.shouldSerialize["CustomerExchangeRate"] = true;
                this.customerExchangeRate = value;
            }
        }

        /// <summary>
        /// Invoice net amount
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
        /// Invoice gross amount
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
        /// Invoice VAT amount
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
        /// True/False.
        /// Reverse charge.
        /// </summary>
        [JsonProperty("ReverseCharge")]
        public bool? ReverseCharge
        {
            get
            {
                return this.reverseCharge;
            }

            set
            {
                this.shouldSerialize["ReverseCharge"] = true;
                this.reverseCharge = value;
            }
        }

        /// <summary>
        /// Original Fee Item id.
        /// </summary>
        [JsonProperty("OriginalFeeItemId")]
        public int? OriginalFeeItemId
        {
            get
            {
                return this.originalFeeItemId;
            }

            set
            {
                this.shouldSerialize["OriginalFeeItemId"] = true;
                this.originalFeeItemId = value;
            }
        }

        /// <summary>
        /// Original FeeItem Currency ISO code.
        /// </summary>
        [JsonProperty("OriginalCurrencyCode")]
        public string OriginalCurrencyCode
        {
            get
            {
                return this.originalCurrencyCode;
            }

            set
            {
                this.shouldSerialize["OriginalCurrencyCode"] = true;
                this.originalCurrencyCode = value;
            }
        }

        /// <summary>
        /// Original FeeItem currency symbol
        /// </summary>
        [JsonProperty("OriginalCurrencySymbol")]
        public string OriginalCurrencySymbol
        {
            get
            {
                return this.originalCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["OriginalCurrencySymbol"] = true;
                this.originalCurrencySymbol = value;
            }
        }

        /// <summary>
        /// Original FeeItem unit price
        /// </summary>
        [JsonProperty("OriginalUnitPrice")]
        public double? OriginalUnitPrice
        {
            get
            {
                return this.originalUnitPrice;
            }

            set
            {
                this.shouldSerialize["OriginalUnitPrice"] = true;
                this.originalUnitPrice = value;
            }
        }

        /// <summary>
        /// Original FeeItem net amount
        /// </summary>
        [JsonProperty("OriginalNetAmount")]
        public double? OriginalNetAmount
        {
            get
            {
                return this.originalNetAmount;
            }

            set
            {
                this.shouldSerialize["OriginalNetAmount"] = true;
                this.originalNetAmount = value;
            }
        }

        /// <summary>
        /// Original FeeItem VAT amount
        /// </summary>
        [JsonProperty("OriginalVATAmount")]
        public double? OriginalVATAmount
        {
            get
            {
                return this.originalVATAmount;
            }

            set
            {
                this.shouldSerialize["OriginalVATAmount"] = true;
                this.originalVATAmount = value;
            }
        }

        /// <summary>
        /// Original FeeItem gross amount
        /// </summary>
        [JsonProperty("OriginalGrossAmount")]
        public double? OriginalGrossAmount
        {
            get
            {
                return this.originalGrossAmount;
            }

            set
            {
                this.shouldSerialize["OriginalGrossAmount"] = true;
                this.originalGrossAmount = value;
            }
        }

        /// <summary>
        /// Original FeeItem exchange rate
        /// </summary>
        [JsonProperty("OriginalExchangeRate")]
        public double? OriginalExchangeRate
        {
            get
            {
                return this.originalExchangeRate;
            }

            set
            {
                this.shouldSerialize["OriginalExchangeRate"] = true;
                this.originalExchangeRate = value;
            }
        }

        /// <summary>
        /// Original legislative region id
        /// </summary>
        [JsonProperty("OriginalLegislativeRegionId")]
        public int? OriginalLegislativeRegionId
        {
            get
            {
                return this.originalLegislativeRegionId;
            }

            set
            {
                this.shouldSerialize["OriginalLegislativeRegionId"] = true;
                this.originalLegislativeRegionId = value;
            }
        }

        /// <summary>
        /// Original legislative region name
        /// </summary>
        [JsonProperty("OriginalLegislativeRegionName")]
        public string OriginalLegislativeRegionName
        {
            get
            {
                return this.originalLegislativeRegionName;
            }

            set
            {
                this.shouldSerialize["OriginalLegislativeRegionName"] = true;
                this.originalLegislativeRegionName = value;
            }
        }

        /// <summary>
        /// Fee frequency derived from Fee rules if applicable
        /// Returns ID-Description in one field
        /// Example:
        /// 1- Daily (all days)
        /// 2-Daily (only working days)
        /// 3-Weekly – Monday
        /// 4-Weekly - Tuesday
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency
        {
            get
            {
                return this.frequency;
            }

            set
            {
                this.shouldSerialize["Frequency"] = true;
                this.frequency = value;
            }
        }

        /// <summary>
        /// Fee breakup at card level for Fee Items where applicable.
        /// </summary>
        [JsonProperty("FeeItemCardLevelBreakup")]
        public string FeeItemCardLevelBreakup
        {
            get
            {
                return this.feeItemCardLevelBreakup;
            }

            set
            {
                this.shouldSerialize["FeeItemCardLevelBreakup"] = true;
                this.feeItemCardLevelBreakup = value;
            }
        }

        /// <summary>
        /// Invoice Id/ Billing Document Id of the original fee item (when not null).
        /// Applicable only for fee items that are refund to an original fee item that is already invoiced.
        /// </summary>
        [JsonProperty("OriginalFeeItemInvoiceId")]
        public int? OriginalFeeItemInvoiceId
        {
            get
            {
                return this.originalFeeItemInvoiceId;
            }

            set
            {
                this.shouldSerialize["OriginalFeeItemInvoiceId"] = true;
                this.originalFeeItemInvoiceId = value;
            }
        }

        /// <summary>
        /// Invoice Number of the original fee item (when not null).
        /// Applicable only for fee items that are refund to an original fee item that is already invoiced.
        /// </summary>
        [JsonProperty("OriginalFeeItemInvoiceNumber")]
        public string OriginalFeeItemInvoiceNumber
        {
            get
            {
                return this.originalFeeItemInvoiceNumber;
            }

            set
            {
                this.shouldSerialize["OriginalFeeItemInvoiceNumber"] = true;
                this.originalFeeItemInvoiceNumber = value;
            }
        }

        /// <summary>
        /// Invoice Date of the original fee item (when not null).
        /// Applicable only for fee items that are refund to an original fee item that is already invoiced.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("OriginalFeeItemInvoiceDate")]
        public string OriginalFeeItemInvoiceDate
        {
            get
            {
                return this.originalFeeItemInvoiceDate;
            }

            set
            {
                this.shouldSerialize["OriginalFeeItemInvoiceDate"] = true;
                this.originalFeeItemInvoiceDate = value;
            }
        }

        /// <summary>
        /// Driver name embossed on the Card
        /// </summary>
        [JsonProperty("DriverName")]
        public string DriverName
        {
            get
            {
                return this.driverName;
            }

            set
            {
                this.shouldSerialize["DriverName"] = true;
                this.driverName = value;
            }
        }

        /// <summary>
        /// Text embossed on the Card
        /// </summary>
        [JsonProperty("EmbossText")]
        public string EmbossText
        {
            get
            {
                return this.embossText;
            }

            set
            {
                this.shouldSerialize["EmbossText"] = true;
                this.embossText = value;
            }
        }

        /// <summary>
        /// Reg. Number embossed on the Card
        /// </summary>
        [JsonProperty("VRN")]
        public string VRN
        {
            get
            {
                return this.vRN;
            }

            set
            {
                this.shouldSerialize["VRN"] = true;
                this.vRN = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FeeItem : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPAN()
        {
            this.shouldSerialize["PAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupId()
        {
            this.shouldSerialize["CardGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupName()
        {
            this.shouldSerialize["CardGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeTypeId()
        {
            this.shouldSerialize["FeeTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeType()
        {
            this.shouldSerialize["FeeType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeTypeGroup()
        {
            this.shouldSerialize["FeeTypeGroup"] = false;
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
        public void UnsetFeeItemDate()
        {
            this.shouldSerialize["FeeItemDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeItemTime()
        {
            this.shouldSerialize["FeeItemTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsManual()
        {
            this.shouldSerialize["IsManual"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsCancelled()
        {
            this.shouldSerialize["IsCancelled"] = false;
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
        public void UnsetProductId()
        {
            this.shouldSerialize["ProductId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductCode()
        {
            this.shouldSerialize["ProductCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductName()
        {
            this.shouldSerialize["ProductName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductGroupId()
        {
            this.shouldSerialize["ProductGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductGroupName()
        {
            this.shouldSerialize["ProductGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLineItemDescription()
        {
            this.shouldSerialize["LineItemDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetQuantity()
        {
            this.shouldSerialize["Quantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsInvoiced()
        {
            this.shouldSerialize["IsInvoiced"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountryCode()
        {
            this.shouldSerialize["VATCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountryName()
        {
            this.shouldSerialize["VATCountryName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATPercentage()
        {
            this.shouldSerialize["VATPercentage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCategoryID()
        {
            this.shouldSerialize["VATCategoryID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCategoryDescription()
        {
            this.shouldSerialize["VATCategoryDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLegislativeRegionId()
        {
            this.shouldSerialize["LegislativeRegionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLegislativeRegionName()
        {
            this.shouldSerialize["LegislativeRegionName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSystemEntryDate()
        {
            this.shouldSerialize["SystemEntryDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSystemEntryTime()
        {
            this.shouldSerialize["SystemEntryTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoNetAmount()
        {
            this.shouldSerialize["ColCoNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoVATAmount()
        {
            this.shouldSerialize["ColCoVATAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoGrossAmount()
        {
            this.shouldSerialize["ColCoGrossAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInterimInvoiceId()
        {
            this.shouldSerialize["InterimInvoiceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInterimInvoiceNumber()
        {
            this.shouldSerialize["InterimInvoiceNumber"] = false;
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
        public void UnsetInvoiceDate()
        {
            this.shouldSerialize["InvoiceDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerExchangeRate()
        {
            this.shouldSerialize["CustomerExchangeRate"] = false;
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
        public void UnsetInvoiceGrossAmount()
        {
            this.shouldSerialize["InvoiceGrossAmount"] = false;
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
        public void UnsetReverseCharge()
        {
            this.shouldSerialize["ReverseCharge"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalFeeItemId()
        {
            this.shouldSerialize["OriginalFeeItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalCurrencyCode()
        {
            this.shouldSerialize["OriginalCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalCurrencySymbol()
        {
            this.shouldSerialize["OriginalCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalUnitPrice()
        {
            this.shouldSerialize["OriginalUnitPrice"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalNetAmount()
        {
            this.shouldSerialize["OriginalNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalVATAmount()
        {
            this.shouldSerialize["OriginalVATAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalGrossAmount()
        {
            this.shouldSerialize["OriginalGrossAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalExchangeRate()
        {
            this.shouldSerialize["OriginalExchangeRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalLegislativeRegionId()
        {
            this.shouldSerialize["OriginalLegislativeRegionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalLegislativeRegionName()
        {
            this.shouldSerialize["OriginalLegislativeRegionName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFrequency()
        {
            this.shouldSerialize["Frequency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeItemCardLevelBreakup()
        {
            this.shouldSerialize["FeeItemCardLevelBreakup"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalFeeItemInvoiceId()
        {
            this.shouldSerialize["OriginalFeeItemInvoiceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalFeeItemInvoiceNumber()
        {
            this.shouldSerialize["OriginalFeeItemInvoiceNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalFeeItemInvoiceDate()
        {
            this.shouldSerialize["OriginalFeeItemInvoiceDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDriverName()
        {
            this.shouldSerialize["DriverName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEmbossText()
        {
            this.shouldSerialize["EmbossText"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVRN()
        {
            this.shouldSerialize["VRN"] = false;
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
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePAN()
        {
            return this.shouldSerialize["PAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupId()
        {
            return this.shouldSerialize["CardGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupName()
        {
            return this.shouldSerialize["CardGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeTypeId()
        {
            return this.shouldSerialize["FeeTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeType()
        {
            return this.shouldSerialize["FeeType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeTypeGroup()
        {
            return this.shouldSerialize["FeeTypeGroup"];
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
        public bool ShouldSerializeFeeItemDate()
        {
            return this.shouldSerialize["FeeItemDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeItemTime()
        {
            return this.shouldSerialize["FeeItemTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsManual()
        {
            return this.shouldSerialize["IsManual"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsCancelled()
        {
            return this.shouldSerialize["IsCancelled"];
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
        public bool ShouldSerializeProductId()
        {
            return this.shouldSerialize["ProductId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductCode()
        {
            return this.shouldSerialize["ProductCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductName()
        {
            return this.shouldSerialize["ProductName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroupId()
        {
            return this.shouldSerialize["ProductGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroupName()
        {
            return this.shouldSerialize["ProductGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLineItemDescription()
        {
            return this.shouldSerialize["LineItemDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeQuantity()
        {
            return this.shouldSerialize["Quantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsInvoiced()
        {
            return this.shouldSerialize["IsInvoiced"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountryCode()
        {
            return this.shouldSerialize["VATCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountryName()
        {
            return this.shouldSerialize["VATCountryName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATPercentage()
        {
            return this.shouldSerialize["VATPercentage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCategoryID()
        {
            return this.shouldSerialize["VATCategoryID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCategoryDescription()
        {
            return this.shouldSerialize["VATCategoryDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLegislativeRegionId()
        {
            return this.shouldSerialize["LegislativeRegionId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLegislativeRegionName()
        {
            return this.shouldSerialize["LegislativeRegionName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSystemEntryDate()
        {
            return this.shouldSerialize["SystemEntryDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSystemEntryTime()
        {
            return this.shouldSerialize["SystemEntryTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoNetAmount()
        {
            return this.shouldSerialize["ColCoNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoVATAmount()
        {
            return this.shouldSerialize["ColCoVATAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoGrossAmount()
        {
            return this.shouldSerialize["ColCoGrossAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInterimInvoiceId()
        {
            return this.shouldSerialize["InterimInvoiceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInterimInvoiceNumber()
        {
            return this.shouldSerialize["InterimInvoiceNumber"];
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
        public bool ShouldSerializeInvoiceDate()
        {
            return this.shouldSerialize["InvoiceDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerExchangeRate()
        {
            return this.shouldSerialize["CustomerExchangeRate"];
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
        public bool ShouldSerializeInvoiceGrossAmount()
        {
            return this.shouldSerialize["InvoiceGrossAmount"];
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
        public bool ShouldSerializeReverseCharge()
        {
            return this.shouldSerialize["ReverseCharge"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalFeeItemId()
        {
            return this.shouldSerialize["OriginalFeeItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalCurrencyCode()
        {
            return this.shouldSerialize["OriginalCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalCurrencySymbol()
        {
            return this.shouldSerialize["OriginalCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalUnitPrice()
        {
            return this.shouldSerialize["OriginalUnitPrice"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalNetAmount()
        {
            return this.shouldSerialize["OriginalNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalVATAmount()
        {
            return this.shouldSerialize["OriginalVATAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalGrossAmount()
        {
            return this.shouldSerialize["OriginalGrossAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalExchangeRate()
        {
            return this.shouldSerialize["OriginalExchangeRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalLegislativeRegionId()
        {
            return this.shouldSerialize["OriginalLegislativeRegionId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalLegislativeRegionName()
        {
            return this.shouldSerialize["OriginalLegislativeRegionName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFrequency()
        {
            return this.shouldSerialize["Frequency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeItemCardLevelBreakup()
        {
            return this.shouldSerialize["FeeItemCardLevelBreakup"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalFeeItemInvoiceId()
        {
            return this.shouldSerialize["OriginalFeeItemInvoiceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalFeeItemInvoiceNumber()
        {
            return this.shouldSerialize["OriginalFeeItemInvoiceNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalFeeItemInvoiceDate()
        {
            return this.shouldSerialize["OriginalFeeItemInvoiceDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDriverName()
        {
            return this.shouldSerialize["DriverName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmbossText()
        {
            return this.shouldSerialize["EmbossText"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVRN()
        {
            return this.shouldSerialize["VRN"];
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
            return obj is FeeItem other &&                ((this.FeeItemId == null && other.FeeItemId == null) || (this.FeeItemId?.Equals(other.FeeItemId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.InvoiceAccountId == null && other.InvoiceAccountId == null) || (this.InvoiceAccountId?.Equals(other.InvoiceAccountId) == true)) &&
                ((this.InvoiceAccountNumber == null && other.InvoiceAccountNumber == null) || (this.InvoiceAccountNumber?.Equals(other.InvoiceAccountNumber) == true)) &&
                ((this.InvoiceAccountShortName == null && other.InvoiceAccountShortName == null) || (this.InvoiceAccountShortName?.Equals(other.InvoiceAccountShortName) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerShortName == null && other.PayerShortName == null) || (this.PayerShortName?.Equals(other.PayerShortName) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.FeeTypeId == null && other.FeeTypeId == null) || (this.FeeTypeId?.Equals(other.FeeTypeId) == true)) &&
                ((this.FeeType == null && other.FeeType == null) || (this.FeeType?.Equals(other.FeeType) == true)) &&
                ((this.FeeTypeGroup == null && other.FeeTypeGroup == null) || (this.FeeTypeGroup?.Equals(other.FeeTypeGroup) == true)) &&
                ((this.FeeRuleId == null && other.FeeRuleId == null) || (this.FeeRuleId?.Equals(other.FeeRuleId) == true)) &&
                ((this.FeeRuleDescription == null && other.FeeRuleDescription == null) || (this.FeeRuleDescription?.Equals(other.FeeRuleDescription) == true)) &&
                ((this.FeeRuleTiers == null && other.FeeRuleTiers == null) || (this.FeeRuleTiers?.Equals(other.FeeRuleTiers) == true)) &&
                ((this.FeeItemDate == null && other.FeeItemDate == null) || (this.FeeItemDate?.Equals(other.FeeItemDate) == true)) &&
                ((this.FeeItemTime == null && other.FeeItemTime == null) || (this.FeeItemTime?.Equals(other.FeeItemTime) == true)) &&
                ((this.IsManual == null && other.IsManual == null) || (this.IsManual?.Equals(other.IsManual) == true)) &&
                ((this.IsCancelled == null && other.IsCancelled == null) || (this.IsCancelled?.Equals(other.IsCancelled) == true)) &&
                ((this.CustomerCurrencyCode == null && other.CustomerCurrencyCode == null) || (this.CustomerCurrencyCode?.Equals(other.CustomerCurrencyCode) == true)) &&
                ((this.CustomerCurrencySymbol == null && other.CustomerCurrencySymbol == null) || (this.CustomerCurrencySymbol?.Equals(other.CustomerCurrencySymbol) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductGroupId == null && other.ProductGroupId == null) || (this.ProductGroupId?.Equals(other.ProductGroupId) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true)) &&
                ((this.LineItemDescription == null && other.LineItemDescription == null) || (this.LineItemDescription?.Equals(other.LineItemDescription) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.IsInvoiced == null && other.IsInvoiced == null) || (this.IsInvoiced?.Equals(other.IsInvoiced) == true)) &&
                ((this.VATCountryCode == null && other.VATCountryCode == null) || (this.VATCountryCode?.Equals(other.VATCountryCode) == true)) &&
                ((this.VATCountryName == null && other.VATCountryName == null) || (this.VATCountryName?.Equals(other.VATCountryName) == true)) &&
                ((this.VATPercentage == null && other.VATPercentage == null) || (this.VATPercentage?.Equals(other.VATPercentage) == true)) &&
                ((this.VATCategoryID == null && other.VATCategoryID == null) || (this.VATCategoryID?.Equals(other.VATCategoryID) == true)) &&
                ((this.VATCategoryDescription == null && other.VATCategoryDescription == null) || (this.VATCategoryDescription?.Equals(other.VATCategoryDescription) == true)) &&
                ((this.LegislativeRegionId == null && other.LegislativeRegionId == null) || (this.LegislativeRegionId?.Equals(other.LegislativeRegionId) == true)) &&
                ((this.LegislativeRegionName == null && other.LegislativeRegionName == null) || (this.LegislativeRegionName?.Equals(other.LegislativeRegionName) == true)) &&
                ((this.SystemEntryDate == null && other.SystemEntryDate == null) || (this.SystemEntryDate?.Equals(other.SystemEntryDate) == true)) &&
                ((this.SystemEntryTime == null && other.SystemEntryTime == null) || (this.SystemEntryTime?.Equals(other.SystemEntryTime) == true)) &&
                ((this.ColCoNetAmount == null && other.ColCoNetAmount == null) || (this.ColCoNetAmount?.Equals(other.ColCoNetAmount) == true)) &&
                ((this.ColCoVATAmount == null && other.ColCoVATAmount == null) || (this.ColCoVATAmount?.Equals(other.ColCoVATAmount) == true)) &&
                ((this.ColCoGrossAmount == null && other.ColCoGrossAmount == null) || (this.ColCoGrossAmount?.Equals(other.ColCoGrossAmount) == true)) &&
                ((this.InterimInvoiceId == null && other.InterimInvoiceId == null) || (this.InterimInvoiceId?.Equals(other.InterimInvoiceId) == true)) &&
                ((this.InterimInvoiceNumber == null && other.InterimInvoiceNumber == null) || (this.InterimInvoiceNumber?.Equals(other.InterimInvoiceNumber) == true)) &&
                ((this.InvoiceId == null && other.InvoiceId == null) || (this.InvoiceId?.Equals(other.InvoiceId) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.CustomerExchangeRate == null && other.CustomerExchangeRate == null) || (this.CustomerExchangeRate?.Equals(other.CustomerExchangeRate) == true)) &&
                ((this.InvoiceNetAmount == null && other.InvoiceNetAmount == null) || (this.InvoiceNetAmount?.Equals(other.InvoiceNetAmount) == true)) &&
                ((this.InvoiceGrossAmount == null && other.InvoiceGrossAmount == null) || (this.InvoiceGrossAmount?.Equals(other.InvoiceGrossAmount) == true)) &&
                ((this.InvoiceVATAmount == null && other.InvoiceVATAmount == null) || (this.InvoiceVATAmount?.Equals(other.InvoiceVATAmount) == true)) &&
                ((this.ReverseCharge == null && other.ReverseCharge == null) || (this.ReverseCharge?.Equals(other.ReverseCharge) == true)) &&
                ((this.OriginalFeeItemId == null && other.OriginalFeeItemId == null) || (this.OriginalFeeItemId?.Equals(other.OriginalFeeItemId) == true)) &&
                ((this.OriginalCurrencyCode == null && other.OriginalCurrencyCode == null) || (this.OriginalCurrencyCode?.Equals(other.OriginalCurrencyCode) == true)) &&
                ((this.OriginalCurrencySymbol == null && other.OriginalCurrencySymbol == null) || (this.OriginalCurrencySymbol?.Equals(other.OriginalCurrencySymbol) == true)) &&
                ((this.OriginalUnitPrice == null && other.OriginalUnitPrice == null) || (this.OriginalUnitPrice?.Equals(other.OriginalUnitPrice) == true)) &&
                ((this.OriginalNetAmount == null && other.OriginalNetAmount == null) || (this.OriginalNetAmount?.Equals(other.OriginalNetAmount) == true)) &&
                ((this.OriginalVATAmount == null && other.OriginalVATAmount == null) || (this.OriginalVATAmount?.Equals(other.OriginalVATAmount) == true)) &&
                ((this.OriginalGrossAmount == null && other.OriginalGrossAmount == null) || (this.OriginalGrossAmount?.Equals(other.OriginalGrossAmount) == true)) &&
                ((this.OriginalExchangeRate == null && other.OriginalExchangeRate == null) || (this.OriginalExchangeRate?.Equals(other.OriginalExchangeRate) == true)) &&
                ((this.OriginalLegislativeRegionId == null && other.OriginalLegislativeRegionId == null) || (this.OriginalLegislativeRegionId?.Equals(other.OriginalLegislativeRegionId) == true)) &&
                ((this.OriginalLegislativeRegionName == null && other.OriginalLegislativeRegionName == null) || (this.OriginalLegislativeRegionName?.Equals(other.OriginalLegislativeRegionName) == true)) &&
                ((this.Frequency == null && other.Frequency == null) || (this.Frequency?.Equals(other.Frequency) == true)) &&
                ((this.FeeItemCardLevelBreakup == null && other.FeeItemCardLevelBreakup == null) || (this.FeeItemCardLevelBreakup?.Equals(other.FeeItemCardLevelBreakup) == true)) &&
                ((this.OriginalFeeItemInvoiceId == null && other.OriginalFeeItemInvoiceId == null) || (this.OriginalFeeItemInvoiceId?.Equals(other.OriginalFeeItemInvoiceId) == true)) &&
                ((this.OriginalFeeItemInvoiceNumber == null && other.OriginalFeeItemInvoiceNumber == null) || (this.OriginalFeeItemInvoiceNumber?.Equals(other.OriginalFeeItemInvoiceNumber) == true)) &&
                ((this.OriginalFeeItemInvoiceDate == null && other.OriginalFeeItemInvoiceDate == null) || (this.OriginalFeeItemInvoiceDate?.Equals(other.OriginalFeeItemInvoiceDate) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.EmbossText == null && other.EmbossText == null) || (this.EmbossText?.Equals(other.EmbossText) == true)) &&
                ((this.VRN == null && other.VRN == null) || (this.VRN?.Equals(other.VRN) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FeeItemId = {(this.FeeItemId == null ? "null" : this.FeeItemId.ToString())}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.InvoiceAccountId = {(this.InvoiceAccountId == null ? "null" : this.InvoiceAccountId.ToString())}");
            toStringOutput.Add($"this.InvoiceAccountNumber = {(this.InvoiceAccountNumber == null ? "null" : this.InvoiceAccountNumber)}");
            toStringOutput.Add($"this.InvoiceAccountShortName = {(this.InvoiceAccountShortName == null ? "null" : this.InvoiceAccountShortName)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerShortName = {(this.PayerShortName == null ? "null" : this.PayerShortName)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.FeeTypeId = {(this.FeeTypeId == null ? "null" : this.FeeTypeId.ToString())}");
            toStringOutput.Add($"this.FeeType = {(this.FeeType == null ? "null" : this.FeeType)}");
            toStringOutput.Add($"this.FeeTypeGroup = {(this.FeeTypeGroup == null ? "null" : this.FeeTypeGroup)}");
            toStringOutput.Add($"this.FeeRuleId = {(this.FeeRuleId == null ? "null" : this.FeeRuleId.ToString())}");
            toStringOutput.Add($"this.FeeRuleDescription = {(this.FeeRuleDescription == null ? "null" : this.FeeRuleDescription)}");
            toStringOutput.Add($"this.FeeRuleTiers = {(this.FeeRuleTiers == null ? "null" : $"[{string.Join(", ", this.FeeRuleTiers)} ]")}");
            toStringOutput.Add($"this.FeeItemDate = {(this.FeeItemDate == null ? "null" : this.FeeItemDate)}");
            toStringOutput.Add($"this.FeeItemTime = {(this.FeeItemTime == null ? "null" : this.FeeItemTime)}");
            toStringOutput.Add($"this.IsManual = {(this.IsManual == null ? "null" : this.IsManual.ToString())}");
            toStringOutput.Add($"this.IsCancelled = {(this.IsCancelled == null ? "null" : this.IsCancelled.ToString())}");
            toStringOutput.Add($"this.CustomerCurrencyCode = {(this.CustomerCurrencyCode == null ? "null" : this.CustomerCurrencyCode)}");
            toStringOutput.Add($"this.CustomerCurrencySymbol = {(this.CustomerCurrencySymbol == null ? "null" : this.CustomerCurrencySymbol)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductGroupId = {(this.ProductGroupId == null ? "null" : this.ProductGroupId.ToString())}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
            toStringOutput.Add($"this.LineItemDescription = {(this.LineItemDescription == null ? "null" : this.LineItemDescription)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.IsInvoiced = {(this.IsInvoiced == null ? "null" : this.IsInvoiced.ToString())}");
            toStringOutput.Add($"this.VATCountryCode = {(this.VATCountryCode == null ? "null" : this.VATCountryCode)}");
            toStringOutput.Add($"this.VATCountryName = {(this.VATCountryName == null ? "null" : this.VATCountryName)}");
            toStringOutput.Add($"this.VATPercentage = {(this.VATPercentage == null ? "null" : this.VATPercentage.ToString())}");
            toStringOutput.Add($"this.VATCategoryID = {(this.VATCategoryID == null ? "null" : this.VATCategoryID.ToString())}");
            toStringOutput.Add($"this.VATCategoryDescription = {(this.VATCategoryDescription == null ? "null" : this.VATCategoryDescription)}");
            toStringOutput.Add($"this.LegislativeRegionId = {(this.LegislativeRegionId == null ? "null" : this.LegislativeRegionId.ToString())}");
            toStringOutput.Add($"this.LegislativeRegionName = {(this.LegislativeRegionName == null ? "null" : this.LegislativeRegionName)}");
            toStringOutput.Add($"this.SystemEntryDate = {(this.SystemEntryDate == null ? "null" : this.SystemEntryDate)}");
            toStringOutput.Add($"this.SystemEntryTime = {(this.SystemEntryTime == null ? "null" : this.SystemEntryTime)}");
            toStringOutput.Add($"this.ColCoNetAmount = {(this.ColCoNetAmount == null ? "null" : this.ColCoNetAmount.ToString())}");
            toStringOutput.Add($"this.ColCoVATAmount = {(this.ColCoVATAmount == null ? "null" : this.ColCoVATAmount.ToString())}");
            toStringOutput.Add($"this.ColCoGrossAmount = {(this.ColCoGrossAmount == null ? "null" : this.ColCoGrossAmount.ToString())}");
            toStringOutput.Add($"this.InterimInvoiceId = {(this.InterimInvoiceId == null ? "null" : this.InterimInvoiceId.ToString())}");
            toStringOutput.Add($"this.InterimInvoiceNumber = {(this.InterimInvoiceNumber == null ? "null" : this.InterimInvoiceNumber)}");
            toStringOutput.Add($"this.InvoiceId = {(this.InvoiceId == null ? "null" : this.InvoiceId.ToString())}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.CustomerExchangeRate = {(this.CustomerExchangeRate == null ? "null" : this.CustomerExchangeRate.ToString())}");
            toStringOutput.Add($"this.InvoiceNetAmount = {(this.InvoiceNetAmount == null ? "null" : this.InvoiceNetAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceGrossAmount = {(this.InvoiceGrossAmount == null ? "null" : this.InvoiceGrossAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceVATAmount = {(this.InvoiceVATAmount == null ? "null" : this.InvoiceVATAmount.ToString())}");
            toStringOutput.Add($"this.ReverseCharge = {(this.ReverseCharge == null ? "null" : this.ReverseCharge.ToString())}");
            toStringOutput.Add($"this.OriginalFeeItemId = {(this.OriginalFeeItemId == null ? "null" : this.OriginalFeeItemId.ToString())}");
            toStringOutput.Add($"this.OriginalCurrencyCode = {(this.OriginalCurrencyCode == null ? "null" : this.OriginalCurrencyCode)}");
            toStringOutput.Add($"this.OriginalCurrencySymbol = {(this.OriginalCurrencySymbol == null ? "null" : this.OriginalCurrencySymbol)}");
            toStringOutput.Add($"this.OriginalUnitPrice = {(this.OriginalUnitPrice == null ? "null" : this.OriginalUnitPrice.ToString())}");
            toStringOutput.Add($"this.OriginalNetAmount = {(this.OriginalNetAmount == null ? "null" : this.OriginalNetAmount.ToString())}");
            toStringOutput.Add($"this.OriginalVATAmount = {(this.OriginalVATAmount == null ? "null" : this.OriginalVATAmount.ToString())}");
            toStringOutput.Add($"this.OriginalGrossAmount = {(this.OriginalGrossAmount == null ? "null" : this.OriginalGrossAmount.ToString())}");
            toStringOutput.Add($"this.OriginalExchangeRate = {(this.OriginalExchangeRate == null ? "null" : this.OriginalExchangeRate.ToString())}");
            toStringOutput.Add($"this.OriginalLegislativeRegionId = {(this.OriginalLegislativeRegionId == null ? "null" : this.OriginalLegislativeRegionId.ToString())}");
            toStringOutput.Add($"this.OriginalLegislativeRegionName = {(this.OriginalLegislativeRegionName == null ? "null" : this.OriginalLegislativeRegionName)}");
            toStringOutput.Add($"this.Frequency = {(this.Frequency == null ? "null" : this.Frequency)}");
            toStringOutput.Add($"this.FeeItemCardLevelBreakup = {(this.FeeItemCardLevelBreakup == null ? "null" : this.FeeItemCardLevelBreakup)}");
            toStringOutput.Add($"this.OriginalFeeItemInvoiceId = {(this.OriginalFeeItemInvoiceId == null ? "null" : this.OriginalFeeItemInvoiceId.ToString())}");
            toStringOutput.Add($"this.OriginalFeeItemInvoiceNumber = {(this.OriginalFeeItemInvoiceNumber == null ? "null" : this.OriginalFeeItemInvoiceNumber)}");
            toStringOutput.Add($"this.OriginalFeeItemInvoiceDate = {(this.OriginalFeeItemInvoiceDate == null ? "null" : this.OriginalFeeItemInvoiceDate)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.EmbossText = {(this.EmbossText == null ? "null" : this.EmbossText)}");
            toStringOutput.Add($"this.VRN = {(this.VRN == null ? "null" : this.VRN)}");
        }
    }
}