// <copyright file="MultiPricedTransactionResponseTransactionsItems.cs" company="APIMatic">
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
    /// MultiPricedTransactionResponseTransactionsItems.
    /// </summary>
    public class MultiPricedTransactionResponseTransactionsItems
    {
        private string type;
        private int? cardId;
        private string cardPAN;
        private string cardExpiry;
        private string transactionDate;
        private string transactionTime;
        private string uTCOffset;
        private string fleetIdInput;
        private int? odometerInput;
        private string driverName;
        private string vehicleRegistration;
        private string invoiceCurrencyCode;
        private string invoiceCurrencySymbol;
        private string transactionCurrencyCode;
        private string transactionCurrencySymbol;
        private int? transactionNetAmount;
        private int? transactionTax;
        private int? transactionGrossAmount;
        private int? invoiceNetAmount;
        private int? invoiceTax;
        private int? invoiceGrossAmount;
        private string purchasedInCountry;
        private int? accountId;
        private string accountNumber;
        private string accountName;
        private string accountShortName;
        private int? quantity;
        private bool? fuelProduct;
        private int? unitPriceInTransactionCurrency;
        private int? unitPriceInInvoiceCurrency;
        private int? unitDiscountTransactionCurrency;
        private int? unitDiscountInvoiceCurrency;
        private bool? isInvoiced;
        private string invoiceNumber;
        private string invoiceDate;
        private string siteCode;
        private string siteName;
        private string siteCountry;
        private string cardGroupName;
        private string receiptNumber;
        private string productCode;
        private string productName;
        private int? productGroupId;
        private string productGroupName;
        private double? delCoExchangeRate;
        private int? colCoExchangeRate;
        private bool? isShellSite;
        private string network;
        private int? siteGroupId;
        private string siteGroupName;
        private string postingDate;
        private string issuerCode;
        private string purchasedInCountryCode;
        private string customerCountryCode;
        private string customerCountry;
        private string releaseCode;
        private string cardGroupId;
        private string cardSequenceNumber;
        private string checkDigit;
        private string fleetIDDescription;
        private double? vATRate;
        private string vATCategory;
        private string vATCountry;
        private double? effectiveDiscountInTrxCurrency;
        private string transactionType;
        private string pINIndicator;
        private string vATApplicable;
        private string netInvoiceIndicator;
        private string customerCurrencyCode;
        private string customerCurrencySymbol;
        private int? effectiveUnitDiscountInCustomerCurrency;
        private int? effectiveDiscountInCustomerCurrency;
        private int? vATonNetAmountInCustomerCurrency;
        private string discountType;
        private string transactionStatus;
        private int? salesItemId;
        private string payerGroup;
        private string payerGroupName;
        private string refundFlag;
        private string originalSalesItemId;
        private string delcoName;
        private string delcoCode;
        private string payerNumber;
        private string payerName;
        private string cardExpiryPeriod;
        private string authorisationCode;
        private string transactionId;
        private string transactionLine;
        private string allowClearing;
        private string cRMNumber;
        private string disputeStatus;
        private double? rebateRate;
        private int? delCoToColCoExchangeRate;
        private double? netEuroAmount;
        private int? euroRebateAmount;
        private double? euroVATAmount;
        private string parentCustomerNumber;
        private string parentCustomerName;
        private int? parentCustomerId;
        private string incomingSiteNumber;
        private string incomingSiteDescription;
        private string incomingCurrencyCode;
        private string incomingProductCode;
        private string creditDebitCode;
        private string correctionFlag;
        private string additional1;
        private string additional2;
        private string additional3;
        private string additional4;
        private double? rebateonNetAmountInCustomerCurrency;
        private double? rebateonNetAmountInTransactionCurrency;
        private string networkCode;
        private string trnIdentifier;
        private string cardType;
        private double? delcoListPriceUnitNet;
        private double? delcoRetailPriceUnitNet;
        private double? delcoRetailPriceUnitGross;
        private double? delcoRetailValueTotalNet;
        private double? delcoRetailValueTotalGross;
        private double? customerRetailPriceUnitGross;
        private double? customerRetailValueTotalGross;
        private double? customerRetailValueTotalNet;
        private string transactionTypeDescription;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Type", false },
            { "CardId", false },
            { "CardPAN", false },
            { "CardExpiry", false },
            { "TransactionDate", false },
            { "TransactionTime", false },
            { "UTCOffset", false },
            { "FleetIdInput", false },
            { "OdometerInput", false },
            { "DriverName", false },
            { "VehicleRegistration", false },
            { "InvoiceCurrencyCode", false },
            { "InvoiceCurrencySymbol", false },
            { "TransactionCurrencyCode", false },
            { "TransactionCurrencySymbol", false },
            { "TransactionNetAmount", false },
            { "TransactionTax", false },
            { "TransactionGrossAmount", false },
            { "InvoiceNetAmount", false },
            { "InvoiceTax", false },
            { "InvoiceGrossAmount", false },
            { "PurchasedInCountry", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountName", false },
            { "AccountShortName", false },
            { "Quantity", false },
            { "FuelProduct", false },
            { "UnitPriceInTransactionCurrency", false },
            { "UnitPriceInInvoiceCurrency", false },
            { "UnitDiscountTransactionCurrency", false },
            { "UnitDiscountInvoiceCurrency", false },
            { "IsInvoiced", false },
            { "InvoiceNumber", false },
            { "InvoiceDate", false },
            { "SiteCode", false },
            { "SiteName", false },
            { "SiteCountry", false },
            { "CardGroupName", false },
            { "ReceiptNumber", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "ProductGroupId", false },
            { "ProductGroupName", false },
            { "DelCoExchangeRate", false },
            { "ColCoExchangeRate", false },
            { "IsShellSite", false },
            { "Network", false },
            { "SiteGroupId", false },
            { "SiteGroupName", false },
            { "PostingDate", false },
            { "IssuerCode", false },
            { "PurchasedInCountryCode", false },
            { "CustomerCountryCode", false },
            { "CustomerCountry", false },
            { "ReleaseCode", false },
            { "CardGroupId", false },
            { "CardSequenceNumber", false },
            { "CheckDigit", false },
            { "FleetIDDescription", false },
            { "VATRate", false },
            { "VATCategory", false },
            { "VATCountry", false },
            { "EffectiveDiscountInTrxCurrency", false },
            { "TransactionType", false },
            { "PINIndicator", false },
            { "VATApplicable", false },
            { "NetInvoiceIndicator", false },
            { "CustomerCurrencyCode", false },
            { "CustomerCurrencySymbol", false },
            { "EffectiveUnitDiscountInCustomerCurrency", false },
            { "EffectiveDiscountInCustomerCurrency", false },
            { "VATonNetAmountInCustomerCurrency", false },
            { "DiscountType", false },
            { "TransactionStatus", false },
            { "SalesItemId", false },
            { "PayerGroup", false },
            { "PayerGroupName", false },
            { "RefundFlag", false },
            { "OriginalSalesItemId", false },
            { "DelcoName", false },
            { "DelcoCode", false },
            { "PayerNumber", false },
            { "PayerName", false },
            { "CardExpiryPeriod", false },
            { "AuthorisationCode", false },
            { "TransactionId", false },
            { "TransactionLine", false },
            { "AllowClearing", false },
            { "CRMNumber", false },
            { "DisputeStatus", false },
            { "RebateRate", false },
            { "DelCoToColCoExchangeRate", false },
            { "NetEuroAmount", false },
            { "EuroRebateAmount", false },
            { "EuroVATAmount", false },
            { "ParentCustomerNumber", false },
            { "ParentCustomerName", false },
            { "ParentCustomerId", false },
            { "IncomingSiteNumber", false },
            { "IncomingSiteDescription", false },
            { "IncomingCurrencyCode", false },
            { "IncomingProductCode", false },
            { "CreditDebitCode", false },
            { "CorrectionFlag", false },
            { "Additional1", false },
            { "Additional2", false },
            { "Additional3", false },
            { "Additional4", false },
            { "RebateonNetAmountInCustomerCurrency", false },
            { "RebateonNetAmountInTransactionCurrency", false },
            { "NetworkCode", false },
            { "TrnIdentifier", false },
            { "CardType", false },
            { "DelcoListPriceUnitNet", false },
            { "DelcoRetailPriceUnitNet", false },
            { "DelcoRetailPriceUnitGross", false },
            { "DelcoRetailValueTotalNet", false },
            { "DelcoRetailValueTotalGross", false },
            { "CustomerRetailPriceUnitGross", false },
            { "CustomerRetailValueTotalGross", false },
            { "CustomerRetailValueTotalNet", false },
            { "TransactionTypeDescription", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPricedTransactionResponseTransactionsItems"/> class.
        /// </summary>
        public MultiPricedTransactionResponseTransactionsItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPricedTransactionResponseTransactionsItems"/> class.
        /// </summary>
        /// <param name="type">Type.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="cardExpiry">CardExpiry.</param>
        /// <param name="transactionDate">TransactionDate.</param>
        /// <param name="transactionTime">TransactionTime.</param>
        /// <param name="uTCOffset">UTCOffset.</param>
        /// <param name="fleetIdInput">FleetIdInput.</param>
        /// <param name="odometerInput">OdometerInput.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="vehicleRegistration">VehicleRegistration.</param>
        /// <param name="invoiceCurrencyCode">InvoiceCurrencyCode.</param>
        /// <param name="invoiceCurrencySymbol">InvoiceCurrencySymbol.</param>
        /// <param name="transactionCurrencyCode">TransactionCurrencyCode.</param>
        /// <param name="transactionCurrencySymbol">TransactionCurrencySymbol.</param>
        /// <param name="transactionNetAmount">TransactionNetAmount.</param>
        /// <param name="transactionTax">TransactionTax.</param>
        /// <param name="transactionGrossAmount">TransactionGrossAmount.</param>
        /// <param name="invoiceNetAmount">InvoiceNetAmount.</param>
        /// <param name="invoiceTax">InvoiceTax.</param>
        /// <param name="invoiceGrossAmount">InvoiceGrossAmount.</param>
        /// <param name="purchasedInCountry">PurchasedInCountry.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="quantity">Quantity.</param>
        /// <param name="fuelProduct">FuelProduct.</param>
        /// <param name="unitPriceInTransactionCurrency">UnitPriceInTransactionCurrency.</param>
        /// <param name="unitPriceInInvoiceCurrency">UnitPriceInInvoiceCurrency.</param>
        /// <param name="unitDiscountTransactionCurrency">UnitDiscountTransactionCurrency.</param>
        /// <param name="unitDiscountInvoiceCurrency">UnitDiscountInvoiceCurrency.</param>
        /// <param name="isInvoiced">IsInvoiced.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="siteCode">SiteCode.</param>
        /// <param name="siteName">SiteName.</param>
        /// <param name="siteCountry">SiteCountry.</param>
        /// <param name="location">Location.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="receiptNumber">ReceiptNumber.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="productGroupId">ProductGroupId.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="delCoExchangeRate">DelCoExchangeRate.</param>
        /// <param name="colCoExchangeRate">ColCoExchangeRate.</param>
        /// <param name="isShellSite">IsShellSite.</param>
        /// <param name="network">Network.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="siteGroupName">SiteGroupName.</param>
        /// <param name="postingDate">PostingDate.</param>
        /// <param name="issuerCode">IssuerCode.</param>
        /// <param name="purchasedInCountryCode">PurchasedInCountryCode.</param>
        /// <param name="customerCountryCode">CustomerCountryCode.</param>
        /// <param name="customerCountry">CustomerCountry.</param>
        /// <param name="releaseCode">ReleaseCode.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardSequenceNumber">CardSequenceNumber.</param>
        /// <param name="checkDigit">CheckDigit.</param>
        /// <param name="fleetIDDescription">FleetIDDescription.</param>
        /// <param name="vATRate">VATRate.</param>
        /// <param name="vATCategory">VATCategory.</param>
        /// <param name="vATCountry">VATCountry.</param>
        /// <param name="effectiveDiscountInTrxCurrency">EffectiveDiscountInTrxCurrency.</param>
        /// <param name="transactionType">TransactionType.</param>
        /// <param name="pINIndicator">PINIndicator.</param>
        /// <param name="vATApplicable">VATApplicable.</param>
        /// <param name="netInvoiceIndicator">NetInvoiceIndicator.</param>
        /// <param name="customerCurrencyCode">CustomerCurrencyCode.</param>
        /// <param name="customerCurrencySymbol">CustomerCurrencySymbol.</param>
        /// <param name="effectiveUnitDiscountInCustomerCurrency">EffectiveUnitDiscountInCustomerCurrency.</param>
        /// <param name="effectiveDiscountInCustomerCurrency">EffectiveDiscountInCustomerCurrency.</param>
        /// <param name="vATonNetAmountInCustomerCurrency">VATonNetAmountInCustomerCurrency.</param>
        /// <param name="discountType">DiscountType.</param>
        /// <param name="transactionStatus">TransactionStatus.</param>
        /// <param name="salesItemId">SalesItemId.</param>
        /// <param name="payerGroup">PayerGroup.</param>
        /// <param name="payerGroupName">PayerGroupName.</param>
        /// <param name="refundFlag">RefundFlag.</param>
        /// <param name="originalSalesItemId">OriginalSalesItemId.</param>
        /// <param name="delcoName">DelcoName.</param>
        /// <param name="delcoCode">DelcoCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerName">PayerName.</param>
        /// <param name="cardExpiryPeriod">CardExpiryPeriod.</param>
        /// <param name="authorisationCode">AuthorisationCode.</param>
        /// <param name="transactionId">TransactionId.</param>
        /// <param name="transactionLine">TransactionLine.</param>
        /// <param name="allowClearing">AllowClearing.</param>
        /// <param name="cRMNumber">CRMNumber.</param>
        /// <param name="disputeStatus">DisputeStatus.</param>
        /// <param name="rebateRate">RebateRate.</param>
        /// <param name="delCoToColCoExchangeRate">DelCoToColCoExchangeRate.</param>
        /// <param name="netEuroAmount">NetEuroAmount.</param>
        /// <param name="euroRebateAmount">EuroRebateAmount.</param>
        /// <param name="euroVATAmount">EuroVATAmount.</param>
        /// <param name="parentCustomerNumber">ParentCustomerNumber.</param>
        /// <param name="parentCustomerName">ParentCustomerName.</param>
        /// <param name="parentCustomerId">ParentCustomerId.</param>
        /// <param name="incomingSiteNumber">IncomingSiteNumber.</param>
        /// <param name="incomingSiteDescription">IncomingSiteDescription.</param>
        /// <param name="incomingCurrencyCode">IncomingCurrencyCode.</param>
        /// <param name="incomingProductCode">IncomingProductCode.</param>
        /// <param name="creditDebitCode">CreditDebitCode.</param>
        /// <param name="correctionFlag">CorrectionFlag.</param>
        /// <param name="additional1">Additional1.</param>
        /// <param name="additional2">Additional2.</param>
        /// <param name="additional3">Additional3.</param>
        /// <param name="additional4">Additional4.</param>
        /// <param name="rebateonNetAmountInCustomerCurrency">RebateonNetAmountInCustomerCurrency.</param>
        /// <param name="rebateonNetAmountInTransactionCurrency">RebateonNetAmountInTransactionCurrency.</param>
        /// <param name="networkCode">NetworkCode.</param>
        /// <param name="trnIdentifier">TrnIdentifier.</param>
        /// <param name="cardType">CardType.</param>
        /// <param name="delcoListPriceUnitNet">DelcoListPriceUnitNet.</param>
        /// <param name="delcoRetailPriceUnitNet">DelcoRetailPriceUnitNet.</param>
        /// <param name="delcoRetailPriceUnitGross">DelcoRetailPriceUnitGross.</param>
        /// <param name="delcoRetailValueTotalNet">DelcoRetailValueTotalNet.</param>
        /// <param name="delcoRetailValueTotalGross">DelcoRetailValueTotalGross.</param>
        /// <param name="customerRetailPriceUnitGross">CustomerRetailPriceUnitGross.</param>
        /// <param name="customerRetailValueTotalGross">CustomerRetailValueTotalGross.</param>
        /// <param name="customerRetailValueTotalNet">CustomerRetailValueTotalNet.</param>
        /// <param name="transactionTypeDescription">TransactionTypeDescription.</param>
        public MultiPricedTransactionResponseTransactionsItems(
            string type = null,
            int? cardId = null,
            string cardPAN = null,
            string cardExpiry = null,
            string transactionDate = null,
            string transactionTime = null,
            string uTCOffset = null,
            string fleetIdInput = null,
            int? odometerInput = null,
            string driverName = null,
            string vehicleRegistration = null,
            string invoiceCurrencyCode = null,
            string invoiceCurrencySymbol = null,
            string transactionCurrencyCode = null,
            string transactionCurrencySymbol = null,
            int? transactionNetAmount = null,
            int? transactionTax = null,
            int? transactionGrossAmount = null,
            int? invoiceNetAmount = null,
            int? invoiceTax = null,
            int? invoiceGrossAmount = null,
            string purchasedInCountry = null,
            int? accountId = null,
            string accountNumber = null,
            string accountName = null,
            string accountShortName = null,
            int? quantity = null,
            bool? fuelProduct = null,
            int? unitPriceInTransactionCurrency = null,
            int? unitPriceInInvoiceCurrency = null,
            int? unitDiscountTransactionCurrency = null,
            int? unitDiscountInvoiceCurrency = null,
            bool? isInvoiced = null,
            string invoiceNumber = null,
            string invoiceDate = null,
            string siteCode = null,
            string siteName = null,
            string siteCountry = null,
            List<Models.SiteLocation> location = null,
            string cardGroupName = null,
            string receiptNumber = null,
            string productCode = null,
            string productName = null,
            int? productGroupId = null,
            string productGroupName = null,
            double? delCoExchangeRate = null,
            int? colCoExchangeRate = null,
            bool? isShellSite = null,
            string network = null,
            int? siteGroupId = null,
            string siteGroupName = null,
            string postingDate = null,
            string issuerCode = null,
            string purchasedInCountryCode = null,
            string customerCountryCode = null,
            string customerCountry = null,
            string releaseCode = null,
            string cardGroupId = null,
            string cardSequenceNumber = null,
            string checkDigit = null,
            string fleetIDDescription = null,
            double? vATRate = null,
            string vATCategory = null,
            string vATCountry = null,
            double? effectiveDiscountInTrxCurrency = null,
            string transactionType = null,
            string pINIndicator = null,
            string vATApplicable = null,
            string netInvoiceIndicator = null,
            string customerCurrencyCode = null,
            string customerCurrencySymbol = null,
            int? effectiveUnitDiscountInCustomerCurrency = null,
            int? effectiveDiscountInCustomerCurrency = null,
            int? vATonNetAmountInCustomerCurrency = null,
            string discountType = null,
            string transactionStatus = null,
            int? salesItemId = null,
            string payerGroup = null,
            string payerGroupName = null,
            string refundFlag = null,
            string originalSalesItemId = null,
            string delcoName = null,
            string delcoCode = null,
            string payerNumber = null,
            string payerName = null,
            string cardExpiryPeriod = null,
            string authorisationCode = null,
            string transactionId = null,
            string transactionLine = null,
            string allowClearing = null,
            string cRMNumber = null,
            string disputeStatus = null,
            double? rebateRate = null,
            int? delCoToColCoExchangeRate = null,
            double? netEuroAmount = null,
            int? euroRebateAmount = null,
            double? euroVATAmount = null,
            string parentCustomerNumber = null,
            string parentCustomerName = null,
            int? parentCustomerId = null,
            string incomingSiteNumber = null,
            string incomingSiteDescription = null,
            string incomingCurrencyCode = null,
            string incomingProductCode = null,
            string creditDebitCode = null,
            string correctionFlag = null,
            string additional1 = null,
            string additional2 = null,
            string additional3 = null,
            string additional4 = null,
            double? rebateonNetAmountInCustomerCurrency = null,
            double? rebateonNetAmountInTransactionCurrency = null,
            string networkCode = null,
            string trnIdentifier = null,
            string cardType = null,
            double? delcoListPriceUnitNet = null,
            double? delcoRetailPriceUnitNet = null,
            double? delcoRetailPriceUnitGross = null,
            double? delcoRetailValueTotalNet = null,
            double? delcoRetailValueTotalGross = null,
            double? customerRetailPriceUnitGross = null,
            double? customerRetailValueTotalGross = null,
            double? customerRetailValueTotalNet = null,
            string transactionTypeDescription = null)
        {
            if (type != null)
            {
                this.Type = type;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (cardExpiry != null)
            {
                this.CardExpiry = cardExpiry;
            }

            if (transactionDate != null)
            {
                this.TransactionDate = transactionDate;
            }

            if (transactionTime != null)
            {
                this.TransactionTime = transactionTime;
            }

            if (uTCOffset != null)
            {
                this.UTCOffset = uTCOffset;
            }

            if (fleetIdInput != null)
            {
                this.FleetIdInput = fleetIdInput;
            }

            if (odometerInput != null)
            {
                this.OdometerInput = odometerInput;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (vehicleRegistration != null)
            {
                this.VehicleRegistration = vehicleRegistration;
            }

            if (invoiceCurrencyCode != null)
            {
                this.InvoiceCurrencyCode = invoiceCurrencyCode;
            }

            if (invoiceCurrencySymbol != null)
            {
                this.InvoiceCurrencySymbol = invoiceCurrencySymbol;
            }

            if (transactionCurrencyCode != null)
            {
                this.TransactionCurrencyCode = transactionCurrencyCode;
            }

            if (transactionCurrencySymbol != null)
            {
                this.TransactionCurrencySymbol = transactionCurrencySymbol;
            }

            if (transactionNetAmount != null)
            {
                this.TransactionNetAmount = transactionNetAmount;
            }

            if (transactionTax != null)
            {
                this.TransactionTax = transactionTax;
            }

            if (transactionGrossAmount != null)
            {
                this.TransactionGrossAmount = transactionGrossAmount;
            }

            if (invoiceNetAmount != null)
            {
                this.InvoiceNetAmount = invoiceNetAmount;
            }

            if (invoiceTax != null)
            {
                this.InvoiceTax = invoiceTax;
            }

            if (invoiceGrossAmount != null)
            {
                this.InvoiceGrossAmount = invoiceGrossAmount;
            }

            if (purchasedInCountry != null)
            {
                this.PurchasedInCountry = purchasedInCountry;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountName != null)
            {
                this.AccountName = accountName;
            }

            if (accountShortName != null)
            {
                this.AccountShortName = accountShortName;
            }

            if (quantity != null)
            {
                this.Quantity = quantity;
            }

            if (fuelProduct != null)
            {
                this.FuelProduct = fuelProduct;
            }

            if (unitPriceInTransactionCurrency != null)
            {
                this.UnitPriceInTransactionCurrency = unitPriceInTransactionCurrency;
            }

            if (unitPriceInInvoiceCurrency != null)
            {
                this.UnitPriceInInvoiceCurrency = unitPriceInInvoiceCurrency;
            }

            if (unitDiscountTransactionCurrency != null)
            {
                this.UnitDiscountTransactionCurrency = unitDiscountTransactionCurrency;
            }

            if (unitDiscountInvoiceCurrency != null)
            {
                this.UnitDiscountInvoiceCurrency = unitDiscountInvoiceCurrency;
            }

            if (isInvoiced != null)
            {
                this.IsInvoiced = isInvoiced;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (siteCode != null)
            {
                this.SiteCode = siteCode;
            }

            if (siteName != null)
            {
                this.SiteName = siteName;
            }

            if (siteCountry != null)
            {
                this.SiteCountry = siteCountry;
            }

            this.Location = location;
            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            if (receiptNumber != null)
            {
                this.ReceiptNumber = receiptNumber;
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

            if (delCoExchangeRate != null)
            {
                this.DelCoExchangeRate = delCoExchangeRate;
            }

            if (colCoExchangeRate != null)
            {
                this.ColCoExchangeRate = colCoExchangeRate;
            }

            if (isShellSite != null)
            {
                this.IsShellSite = isShellSite;
            }

            if (network != null)
            {
                this.Network = network;
            }

            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (siteGroupName != null)
            {
                this.SiteGroupName = siteGroupName;
            }

            if (postingDate != null)
            {
                this.PostingDate = postingDate;
            }

            if (issuerCode != null)
            {
                this.IssuerCode = issuerCode;
            }

            if (purchasedInCountryCode != null)
            {
                this.PurchasedInCountryCode = purchasedInCountryCode;
            }

            if (customerCountryCode != null)
            {
                this.CustomerCountryCode = customerCountryCode;
            }

            if (customerCountry != null)
            {
                this.CustomerCountry = customerCountry;
            }

            if (releaseCode != null)
            {
                this.ReleaseCode = releaseCode;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardSequenceNumber != null)
            {
                this.CardSequenceNumber = cardSequenceNumber;
            }

            if (checkDigit != null)
            {
                this.CheckDigit = checkDigit;
            }

            if (fleetIDDescription != null)
            {
                this.FleetIDDescription = fleetIDDescription;
            }

            if (vATRate != null)
            {
                this.VATRate = vATRate;
            }

            if (vATCategory != null)
            {
                this.VATCategory = vATCategory;
            }

            if (vATCountry != null)
            {
                this.VATCountry = vATCountry;
            }

            if (effectiveDiscountInTrxCurrency != null)
            {
                this.EffectiveDiscountInTrxCurrency = effectiveDiscountInTrxCurrency;
            }

            if (transactionType != null)
            {
                this.TransactionType = transactionType;
            }

            if (pINIndicator != null)
            {
                this.PINIndicator = pINIndicator;
            }

            if (vATApplicable != null)
            {
                this.VATApplicable = vATApplicable;
            }

            if (netInvoiceIndicator != null)
            {
                this.NetInvoiceIndicator = netInvoiceIndicator;
            }

            if (customerCurrencyCode != null)
            {
                this.CustomerCurrencyCode = customerCurrencyCode;
            }

            if (customerCurrencySymbol != null)
            {
                this.CustomerCurrencySymbol = customerCurrencySymbol;
            }

            if (effectiveUnitDiscountInCustomerCurrency != null)
            {
                this.EffectiveUnitDiscountInCustomerCurrency = effectiveUnitDiscountInCustomerCurrency;
            }

            if (effectiveDiscountInCustomerCurrency != null)
            {
                this.EffectiveDiscountInCustomerCurrency = effectiveDiscountInCustomerCurrency;
            }

            if (vATonNetAmountInCustomerCurrency != null)
            {
                this.VATonNetAmountInCustomerCurrency = vATonNetAmountInCustomerCurrency;
            }

            if (discountType != null)
            {
                this.DiscountType = discountType;
            }

            if (transactionStatus != null)
            {
                this.TransactionStatus = transactionStatus;
            }

            if (salesItemId != null)
            {
                this.SalesItemId = salesItemId;
            }

            if (payerGroup != null)
            {
                this.PayerGroup = payerGroup;
            }

            if (payerGroupName != null)
            {
                this.PayerGroupName = payerGroupName;
            }

            if (refundFlag != null)
            {
                this.RefundFlag = refundFlag;
            }

            if (originalSalesItemId != null)
            {
                this.OriginalSalesItemId = originalSalesItemId;
            }

            if (delcoName != null)
            {
                this.DelcoName = delcoName;
            }

            if (delcoCode != null)
            {
                this.DelcoCode = delcoCode;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerName != null)
            {
                this.PayerName = payerName;
            }

            if (cardExpiryPeriod != null)
            {
                this.CardExpiryPeriod = cardExpiryPeriod;
            }

            if (authorisationCode != null)
            {
                this.AuthorisationCode = authorisationCode;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

            if (transactionLine != null)
            {
                this.TransactionLine = transactionLine;
            }

            if (allowClearing != null)
            {
                this.AllowClearing = allowClearing;
            }

            if (cRMNumber != null)
            {
                this.CRMNumber = cRMNumber;
            }

            if (disputeStatus != null)
            {
                this.DisputeStatus = disputeStatus;
            }

            if (rebateRate != null)
            {
                this.RebateRate = rebateRate;
            }

            if (delCoToColCoExchangeRate != null)
            {
                this.DelCoToColCoExchangeRate = delCoToColCoExchangeRate;
            }

            if (netEuroAmount != null)
            {
                this.NetEuroAmount = netEuroAmount;
            }

            if (euroRebateAmount != null)
            {
                this.EuroRebateAmount = euroRebateAmount;
            }

            if (euroVATAmount != null)
            {
                this.EuroVATAmount = euroVATAmount;
            }

            if (parentCustomerNumber != null)
            {
                this.ParentCustomerNumber = parentCustomerNumber;
            }

            if (parentCustomerName != null)
            {
                this.ParentCustomerName = parentCustomerName;
            }

            if (parentCustomerId != null)
            {
                this.ParentCustomerId = parentCustomerId;
            }

            if (incomingSiteNumber != null)
            {
                this.IncomingSiteNumber = incomingSiteNumber;
            }

            if (incomingSiteDescription != null)
            {
                this.IncomingSiteDescription = incomingSiteDescription;
            }

            if (incomingCurrencyCode != null)
            {
                this.IncomingCurrencyCode = incomingCurrencyCode;
            }

            if (incomingProductCode != null)
            {
                this.IncomingProductCode = incomingProductCode;
            }

            if (creditDebitCode != null)
            {
                this.CreditDebitCode = creditDebitCode;
            }

            if (correctionFlag != null)
            {
                this.CorrectionFlag = correctionFlag;
            }

            if (additional1 != null)
            {
                this.Additional1 = additional1;
            }

            if (additional2 != null)
            {
                this.Additional2 = additional2;
            }

            if (additional3 != null)
            {
                this.Additional3 = additional3;
            }

            if (additional4 != null)
            {
                this.Additional4 = additional4;
            }

            if (rebateonNetAmountInCustomerCurrency != null)
            {
                this.RebateonNetAmountInCustomerCurrency = rebateonNetAmountInCustomerCurrency;
            }

            if (rebateonNetAmountInTransactionCurrency != null)
            {
                this.RebateonNetAmountInTransactionCurrency = rebateonNetAmountInTransactionCurrency;
            }

            if (networkCode != null)
            {
                this.NetworkCode = networkCode;
            }

            if (trnIdentifier != null)
            {
                this.TrnIdentifier = trnIdentifier;
            }

            if (cardType != null)
            {
                this.CardType = cardType;
            }

            if (delcoListPriceUnitNet != null)
            {
                this.DelcoListPriceUnitNet = delcoListPriceUnitNet;
            }

            if (delcoRetailPriceUnitNet != null)
            {
                this.DelcoRetailPriceUnitNet = delcoRetailPriceUnitNet;
            }

            if (delcoRetailPriceUnitGross != null)
            {
                this.DelcoRetailPriceUnitGross = delcoRetailPriceUnitGross;
            }

            if (delcoRetailValueTotalNet != null)
            {
                this.DelcoRetailValueTotalNet = delcoRetailValueTotalNet;
            }

            if (delcoRetailValueTotalGross != null)
            {
                this.DelcoRetailValueTotalGross = delcoRetailValueTotalGross;
            }

            if (customerRetailPriceUnitGross != null)
            {
                this.CustomerRetailPriceUnitGross = customerRetailPriceUnitGross;
            }

            if (customerRetailValueTotalGross != null)
            {
                this.CustomerRetailValueTotalGross = customerRetailValueTotalGross;
            }

            if (customerRetailValueTotalNet != null)
            {
                this.CustomerRetailValueTotalNet = customerRetailValueTotalNet;
            }

            if (transactionTypeDescription != null)
            {
                this.TransactionTypeDescription = transactionTypeDescription;
            }

        }

        /// <summary>
        /// TransactionType is the type of transaction.
        /// Example: SalesItem /FeeItem
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
        /// Unique Card Id in GFN
        /// Example: 275549
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
        /// Mask PAN if enabled at Microservices configuration (Mask all digits except the Last 6 digits of the PAN)
        /// Example: 7002051006629890645
        /// </summary>
        [JsonProperty("CardPAN")]
        public string CardPAN
        {
            get
            {
                return this.cardPAN;
            }

            set
            {
                this.shouldSerialize["CardPAN"] = true;
                this.cardPAN = value;
            }
        }

        /// <summary>
        /// Card Expiry Date
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("CardExpiry")]
        public string CardExpiry
        {
            get
            {
                return this.cardExpiry;
            }

            set
            {
                this.shouldSerialize["CardExpiry"] = true;
                this.cardExpiry = value;
            }
        }

        /// <summary>
        /// Local Transaction Date of where the transaction took place
        /// Format: yyyyMMdd
        /// Note: For a fee item, this parameter will be populated with fee date.
        /// </summary>
        [JsonProperty("TransactionDate")]
        public string TransactionDate
        {
            get
            {
                return this.transactionDate;
            }

            set
            {
                this.shouldSerialize["TransactionDate"] = true;
                this.transactionDate = value;
            }
        }

        /// <summary>
        /// Local Transaction Time of where the transaction took place
        /// Format: HH:mm:ss (24 hours format)
        /// Note: For a fee item, this parameter will be populated with fee date.
        /// </summary>
        [JsonProperty("TransactionTime")]
        public string TransactionTime
        {
            get
            {
                return this.transactionTime;
            }

            set
            {
                this.shouldSerialize["TransactionTime"] = true;
                this.transactionTime = value;
            }
        }

        /// <summary>
        /// UTC Offset extracted from Sales Date time.
        /// Note: This may not be accurate for all TPN transactions
        /// Format: +/-HH:mm:ss (24 hours format)
        /// </summary>
        [JsonProperty("UTCOffset")]
        public string UTCOffset
        {
            get
            {
                return this.uTCOffset;
            }

            set
            {
                this.shouldSerialize["UTCOffset"] = true;
                this.uTCOffset = value;
            }
        }

        /// <summary>
        /// Fleet Id Input as entered by the drivers at the time of transaction
        /// Example: XYZ1234
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("FleetIdInput")]
        public string FleetIdInput
        {
            get
            {
                return this.fleetIdInput;
            }

            set
            {
                this.shouldSerialize["FleetIdInput"] = true;
                this.fleetIdInput = value;
            }
        }

        /// <summary>
        /// Odometer Input as entered by the drivers at the time of transaction
        /// Example: 12345
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("OdometerInput")]
        public int? OdometerInput
        {
            get
            {
                return this.odometerInput;
            }

            set
            {
                this.shouldSerialize["OdometerInput"] = true;
                this.odometerInput = value;
            }
        }

        /// <summary>
        /// Driver Name embossed on the card
        /// Example:  ANDREW GILBERRY
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
        /// Vehicle Registration Number embossed on the card
        /// </summary>
        [JsonProperty("VehicleRegistration")]
        public string VehicleRegistration
        {
            get
            {
                return this.vehicleRegistration;
            }

            set
            {
                this.shouldSerialize["VehicleRegistration"] = true;
                this.vehicleRegistration = value;
            }
        }

        /// <summary>
        /// ISO currency code
        /// </summary>
        [JsonProperty("InvoiceCurrencyCode")]
        public string InvoiceCurrencyCode
        {
            get
            {
                return this.invoiceCurrencyCode;
            }

            set
            {
                this.shouldSerialize["InvoiceCurrencyCode"] = true;
                this.invoiceCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of the Invoice Currency Code
        /// Example: £, $
        /// </summary>
        [JsonProperty("InvoiceCurrencySymbol")]
        public string InvoiceCurrencySymbol
        {
            get
            {
                return this.invoiceCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["InvoiceCurrencySymbol"] = true;
                this.invoiceCurrencySymbol = value;
            }
        }

        /// <summary>
        /// ISO currency code
        /// Example: GBP
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
        /// Currency symbol of the Transaction Currency Code
        /// Example: £, $
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
        /// Net Amount
        /// </summary>
        [JsonProperty("TransactionNetAmount")]
        public int? TransactionNetAmount
        {
            get
            {
                return this.transactionNetAmount;
            }

            set
            {
                this.shouldSerialize["TransactionNetAmount"] = true;
                this.transactionNetAmount = value;
            }
        }

        /// <summary>
        /// Tax Amount
        /// </summary>
        [JsonProperty("TransactionTax")]
        public int? TransactionTax
        {
            get
            {
                return this.transactionTax;
            }

            set
            {
                this.shouldSerialize["TransactionTax"] = true;
                this.transactionTax = value;
            }
        }

        /// <summary>
        /// Gross Amount
        /// </summary>
        [JsonProperty("TransactionGrossAmount")]
        public int? TransactionGrossAmount
        {
            get
            {
                return this.transactionGrossAmount;
            }

            set
            {
                this.shouldSerialize["TransactionGrossAmount"] = true;
                this.transactionGrossAmount = value;
            }
        }

        /// <summary>
        /// Invoiced Net Amount
        /// Note: For a fee item, this parameter will be populated with fee InvoiceNetAmount.
        /// </summary>
        [JsonProperty("InvoiceNetAmount")]
        public int? InvoiceNetAmount
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
        /// Invoiced Tax Amount
        /// </summary>
        [JsonProperty("InvoiceTax")]
        public int? InvoiceTax
        {
            get
            {
                return this.invoiceTax;
            }

            set
            {
                this.shouldSerialize["InvoiceTax"] = true;
                this.invoiceTax = value;
            }
        }

        /// <summary>
        /// Invoice Gross Amount
        /// Note: For a fee item, this parameter will be populated with fee InvoiceGrossAmount.
        /// </summary>
        [JsonProperty("InvoiceGrossAmount")]
        public int? InvoiceGrossAmount
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
        /// Country of Purchase
        /// Example: France, Germany
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("PurchasedInCountry")]
        public string PurchasedInCountry
        {
            get
            {
                return this.purchasedInCountry;
            }

            set
            {
                this.shouldSerialize["PurchasedInCountry"] = true;
                this.purchasedInCountry = value;
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
        /// Account Name
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName
        {
            get
            {
                return this.accountName;
            }

            set
            {
                this.shouldSerialize["AccountName"] = true;
                this.accountName = value;
            }
        }

        /// <summary>
        /// Account Short Name
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
        /// Quantity/Volume
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
        /// True if the product on transaction is listed as a fuel product else return false
        /// </summary>
        [JsonProperty("FuelProduct")]
        public bool? FuelProduct
        {
            get
            {
                return this.fuelProduct;
            }

            set
            {
                this.shouldSerialize["FuelProduct"] = true;
                this.fuelProduct = value;
            }
        }

        /// <summary>
        /// Product Unit Price in transaction currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("UnitPriceInTransactionCurrency")]
        public int? UnitPriceInTransactionCurrency
        {
            get
            {
                return this.unitPriceInTransactionCurrency;
            }

            set
            {
                this.shouldSerialize["UnitPriceInTransactionCurrency"] = true;
                this.unitPriceInTransactionCurrency = value;
            }
        }

        /// <summary>
        /// Product Unit Price in invoice currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("UnitPriceInInvoiceCurrency")]
        public int? UnitPriceInInvoiceCurrency
        {
            get
            {
                return this.unitPriceInInvoiceCurrency;
            }

            set
            {
                this.shouldSerialize["UnitPriceInInvoiceCurrency"] = true;
                this.unitPriceInInvoiceCurrency = value;
            }
        }

        /// <summary>
        /// Unit Discount in transaction currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("UnitDiscountTransactionCurrency")]
        public int? UnitDiscountTransactionCurrency
        {
            get
            {
                return this.unitDiscountTransactionCurrency;
            }

            set
            {
                this.shouldSerialize["UnitDiscountTransactionCurrency"] = true;
                this.unitDiscountTransactionCurrency = value;
            }
        }

        /// <summary>
        /// Unit Discount in invoice currency
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("UnitDiscountInvoiceCurrency")]
        public int? UnitDiscountInvoiceCurrency
        {
            get
            {
                return this.unitDiscountInvoiceCurrency;
            }

            set
            {
                this.shouldSerialize["UnitDiscountInvoiceCurrency"] = true;
                this.unitDiscountInvoiceCurrency = value;
            }
        }

        /// <summary>
        /// True when the transaction is already invoice, else return False
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
        /// Invoice Number if invoiced
        /// Example:
        /// S04500493
        /// S04478304
        /// S04490319
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
        /// Invoice Date
        /// Format: yyyyMMdd HH:mm:ss
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
        /// Site Code
        /// Example:
        /// 050001 -	CHARNOCK RICHARD NTHBOUND MWSA 0755
        /// </summary>
        [JsonProperty("SiteCode")]
        public string SiteCode
        {
            get
            {
                return this.siteCode;
            }

            set
            {
                this.shouldSerialize["SiteCode"] = true;
                this.siteCode = value;
            }
        }

        /// <summary>
        /// Site Name
        /// Example:
        /// 050001 -	CHARNOCK RICHARD NTHBOUND MWSA 0755
        /// </summary>
        [JsonProperty("SiteName")]
        public string SiteName
        {
            get
            {
                return this.siteName;
            }

            set
            {
                this.shouldSerialize["SiteName"] = true;
                this.siteName = value;
            }
        }

        /// <summary>
        /// Site Country
        /// Example: France, Germany
        /// </summary>
        [JsonProperty("SiteCountry")]
        public string SiteCountry
        {
            get
            {
                return this.siteCountry;
            }

            set
            {
                this.shouldSerialize["SiteCountry"] = true;
                this.siteCountry = value;
            }
        }

        /// <summary>
        /// Gets or sets Location.
        /// </summary>
        [JsonProperty("Location", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SiteLocation> Location { get; set; }

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
        /// ReceiptNumber
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public string ReceiptNumber
        {
            get
            {
                return this.receiptNumber;
            }

            set
            {
                this.shouldSerialize["ReceiptNumber"] = true;
                this.receiptNumber = value;
            }
        }

        /// <summary>
        /// Product Code
        /// 10	TMF Charges
        /// 11	Tunnel/Bridges
        /// 12	Motorway toll
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
        /// Example:
        /// Unleaded - High octane
        /// Unleaded - Medium octane
        /// Unleaded - Low octane
        /// Unleaded Environmental
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
        /// Example:
        /// 1	Parent Product Group
        /// 2	All Fuels
        /// 3	Motor gasoline
        /// 4	2 stroke
        /// 5	Autogas
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
        /// Example:
        /// 1	Parent Product Group
        /// 2	All Fuels
        /// 3	Motor gasoline
        /// 4	2 stroke
        /// 5	Autogas
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
        /// DelCo Exchange Rate (Site exchange rate)
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("DelCoExchangeRate")]
        public double? DelCoExchangeRate
        {
            get
            {
                return this.delCoExchangeRate;
            }

            set
            {
                this.shouldSerialize["DelCoExchangeRate"] = true;
                this.delCoExchangeRate = value;
            }
        }

        /// <summary>
        /// ColCo Exchange Rate (Customer exchange rate)
        /// </summary>
        [JsonProperty("ColCoExchangeRate")]
        public int? ColCoExchangeRate
        {
            get
            {
                return this.colCoExchangeRate;
            }

            set
            {
                this.shouldSerialize["ColCoExchangeRate"] = true;
                this.colCoExchangeRate = value;
            }
        }

        /// <summary>
        /// True when transaction occurred at a Shell site else return False
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("IsShellSite")]
        public bool? IsShellSite
        {
            get
            {
                return this.isShellSite;
            }

            set
            {
                this.shouldSerialize["IsShellSite"] = true;
                this.isShellSite = value;
            }
        }

        /// <summary>
        /// Network  (Shell PH, ESSO, etc.,)
        /// 100013	STEINDORFER
        /// 100015	S.A. BELGIAN SHELL N.V.
        /// 100016	ESSO BE
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("Network")]
        public string Network
        {
            get
            {
                return this.network;
            }

            set
            {
                this.shouldSerialize["Network"] = true;
                this.network = value;
            }
        }

        /// <summary>
        /// Site Group Id
        /// Example: 202
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("SiteGroupId")]
        public int? SiteGroupId
        {
            get
            {
                return this.siteGroupId;
            }

            set
            {
                this.shouldSerialize["SiteGroupId"] = true;
                this.siteGroupId = value;
            }
        }

        /// <summary>
        /// Site GroupName
        /// Example: CZ 9100 ECONOMY NETWORK
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("SiteGroupName")]
        public string SiteGroupName
        {
            get
            {
                return this.siteGroupName;
            }

            set
            {
                this.shouldSerialize["SiteGroupName"] = true;
                this.siteGroupName = value;
            }
        }

        /// <summary>
        /// Transaction Posting Date
        /// Format: yyyyMMdd HHmmss
        /// </summary>
        [JsonProperty("PostingDate")]
        public string PostingDate
        {
            get
            {
                return this.postingDate;
            }

            set
            {
                this.shouldSerialize["PostingDate"] = true;
                this.postingDate = value;
            }
        }

        /// <summary>
        /// First digits of the Card PAN
        /// 7002 = Fleet
        /// </summary>
        [JsonProperty("IssuerCode")]
        public string IssuerCode
        {
            get
            {
                return this.issuerCode;
            }

            set
            {
                this.shouldSerialize["IssuerCode"] = true;
                this.issuerCode = value;
            }
        }

        /// <summary>
        /// ISO code of the country where the transaction took place
        /// Example: “NL”
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("PurchasedInCountryCode")]
        public string PurchasedInCountryCode
        {
            get
            {
                return this.purchasedInCountryCode;
            }

            set
            {
                this.shouldSerialize["PurchasedInCountryCode"] = true;
                this.purchasedInCountryCode = value;
            }
        }

        /// <summary>
        /// ISO code of the Customer Country
        /// Example: NL
        /// </summary>
        [JsonProperty("CustomerCountryCode")]
        public string CustomerCountryCode
        {
            get
            {
                return this.customerCountryCode;
            }

            set
            {
                this.shouldSerialize["CustomerCountryCode"] = true;
                this.customerCountryCode = value;
            }
        }

        /// <summary>
        /// Name of the Customer Country
        /// Example: Netherlands
        /// </summary>
        [JsonProperty("CustomerCountry")]
        public string CustomerCountry
        {
            get
            {
                return this.customerCountry;
            }

            set
            {
                this.shouldSerialize["CustomerCountry"] = true;
                this.customerCountry = value;
            }
        }

        /// <summary>
        /// Release code, 7th Digit of the Card PAN
        /// Example: 8 for 7021882
        /// </summary>
        [JsonProperty("ReleaseCode")]
        public string ReleaseCode
        {
            get
            {
                return this.releaseCode;
            }

            set
            {
                this.shouldSerialize["ReleaseCode"] = true;
                this.releaseCode = value;
            }
        }

        /// <summary>
        /// Card group ID
        /// </summary>
        [JsonProperty("CardGroupId")]
        public string CardGroupId
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
        /// 3 digits, Card sequence number and Check digit (Digit 16,17 and 18 on the card pan)
        /// </summary>
        [JsonProperty("CardSequenceNumber")]
        public string CardSequenceNumber
        {
            get
            {
                return this.cardSequenceNumber;
            }

            set
            {
                this.shouldSerialize["CardSequenceNumber"] = true;
                this.cardSequenceNumber = value;
            }
        }

        /// <summary>
        /// Check digit, Last number of the card pan
        /// </summary>
        [JsonProperty("CheckDigit")]
        public string CheckDigit
        {
            get
            {
                return this.checkDigit;
            }

            set
            {
                this.shouldSerialize["CheckDigit"] = true;
                this.checkDigit = value;
            }
        }

        /// <summary>
        /// FleetId/CRN description in Card Platform configured at the account level
        /// </summary>
        [JsonProperty("FleetIDDescription")]
        public string FleetIDDescription
        {
            get
            {
                return this.fleetIDDescription;
            }

            set
            {
                this.shouldSerialize["FleetIDDescription"] = true;
                this.fleetIDDescription = value;
            }
        }

        /// <summary>
        /// VAT Percentage
        /// 0.20 for 20%
        /// Note: This parameter will be populated in the response for both SalesItem and FeeItem
        /// </summary>
        [JsonProperty("VATRate")]
        public double? VATRate
        {
            get
            {
                return this.vATRate;
            }

            set
            {
                this.shouldSerialize["VATRate"] = true;
                this.vATRate = value;
            }
        }

        /// <summary>
        /// VAT Category Id-Description
        /// 1-Zero Rated
        /// </summary>
        [JsonProperty("VATCategory")]
        public string VATCategory
        {
            get
            {
                return this.vATCategory;
            }

            set
            {
                this.shouldSerialize["VATCategory"] = true;
                this.vATCategory = value;
            }
        }

        /// <summary>
        /// VAT Country
        /// Example: Netherlands
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
        /// Effective Discount (excluding VAT, in transaction currency) 4 digits
        /// Example: 0.0000
        /// </summary>
        [JsonProperty("EffectiveDiscountInTrxCurrency")]
        public double? EffectiveDiscountInTrxCurrency
        {
            get
            {
                return this.effectiveDiscountInTrxCurrency;
            }

            set
            {
                this.shouldSerialize["EffectiveDiscountInTrxCurrency"] = true;
                this.effectiveDiscountInTrxCurrency = value;
            }
        }

        /// <summary>
        /// Transaction Type
        /// Example: Purchase when Card is Present else Blank
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("TransactionType")]
        public string TransactionType
        {
            get
            {
                return this.transactionType;
            }

            set
            {
                this.shouldSerialize["TransactionType"] = true;
                this.transactionType = value;
            }
        }

        /// <summary>
        /// Pin Indicator (Indicates whether PIN used or not used at the time of transaction)
        /// Example: “PIN Used'” or “No PIN” or “Unknown”
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("PINIndicator")]
        public string PINIndicator
        {
            get
            {
                return this.pINIndicator;
            }

            set
            {
                this.shouldSerialize["PINIndicator"] = true;
                this.pINIndicator = value;
            }
        }

        /// <summary>
        /// Is VAT Applicable for this transaction
        /// Example: “Y” or “N”
        /// </summary>
        [JsonProperty("VATApplicable")]
        public string VATApplicable
        {
            get
            {
                return this.vATApplicable;
            }

            set
            {
                this.shouldSerialize["VATApplicable"] = true;
                this.vATApplicable = value;
            }
        }

        /// <summary>
        /// Net Invoice Indicator, Will the customer receive an invoice without VAT?
        /// Example: “Y” or “N”
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("NetInvoiceIndicator")]
        public string NetInvoiceIndicator
        {
            get
            {
                return this.netInvoiceIndicator;
            }

            set
            {
                this.shouldSerialize["NetInvoiceIndicator"] = true;
                this.netInvoiceIndicator = value;
            }
        }

        /// <summary>
        /// Customer currency code
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
        /// Customer currency Symbol
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
        /// Effective Unit Discount (excluding VAT in Customer currency)
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("EffectiveUnitDiscountInCustomerCurrency")]
        public int? EffectiveUnitDiscountInCustomerCurrency
        {
            get
            {
                return this.effectiveUnitDiscountInCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["EffectiveUnitDiscountInCustomerCurrency"] = true;
                this.effectiveUnitDiscountInCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Effective Discount (excluding VAT in Customer currency)
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("EffectiveDiscountInCustomerCurrency")]
        public int? EffectiveDiscountInCustomerCurrency
        {
            get
            {
                return this.effectiveDiscountInCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["EffectiveDiscountInCustomerCurrency"] = true;
                this.effectiveDiscountInCustomerCurrency = value;
            }
        }

        /// <summary>
        /// VAT on Net Amount (in Customer currency)
        /// </summary>
        [JsonProperty("VATonNetAmountInCustomerCurrency")]
        public int? VATonNetAmountInCustomerCurrency
        {
            get
            {
                return this.vATonNetAmountInCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["VATonNetAmountInCustomerCurrency"] = true;
                this.vATonNetAmountInCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Discount Type
        /// Example: 1-None
        /// 2-Pence per unit
        /// </summary>
        [JsonProperty("DiscountType")]
        public string DiscountType
        {
            get
            {
                return this.discountType;
            }

            set
            {
                this.shouldSerialize["DiscountType"] = true;
                this.discountType = value;
            }
        }

        /// <summary>
        /// Transaction status "U" or "I"
        /// “U” stands for Uninvoiced
        /// “I” stands for Invoiced
        /// </summary>
        [JsonProperty("TransactionStatus")]
        public string TransactionStatus
        {
            get
            {
                return this.transactionStatus;
            }

            set
            {
                this.shouldSerialize["TransactionStatus"] = true;
                this.transactionStatus = value;
            }
        }

        /// <summary>
        /// Unique Sales Item Identifier
        /// Example: 18315958002
        /// Note: For a fee item, this parameter will be populated with SalesItemId.
        /// </summary>
        [JsonProperty("SalesItemId")]
        public int? SalesItemId
        {
            get
            {
                return this.salesItemId;
            }

            set
            {
                this.shouldSerialize["SalesItemId"] = true;
                this.salesItemId = value;
            }
        }

        /// <summary>
        /// Payer Group applicable for the Large Customer NL+8 digit code
        /// </summary>
        [JsonProperty("PayerGroup")]
        public string PayerGroup
        {
            get
            {
                return this.payerGroup;
            }

            set
            {
                this.shouldSerialize["PayerGroup"] = true;
                this.payerGroup = value;
            }
        }

        /// <summary>
        /// Payer Group Name
        /// </summary>
        [JsonProperty("PayerGroupName")]
        public string PayerGroupName
        {
            get
            {
                return this.payerGroupName;
            }

            set
            {
                this.shouldSerialize["PayerGroupName"] = true;
                this.payerGroupName = value;
            }
        }

        /// <summary>
        /// Refund Flag “N” for Not Refunded and “Y” for Refunded.
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("RefundFlag")]
        public string RefundFlag
        {
            get
            {
                return this.refundFlag;
            }

            set
            {
                this.shouldSerialize["RefundFlag"] = true;
                this.refundFlag = value;
            }
        }

        /// <summary>
        /// Shows Sales Item Id of the original item that was refunded
        /// </summary>
        [JsonProperty("OriginalSalesItemId")]
        public string OriginalSalesItemId
        {
            get
            {
                return this.originalSalesItemId;
            }

            set
            {
                this.shouldSerialize["OriginalSalesItemId"] = true;
                this.originalSalesItemId = value;
            }
        }

        /// <summary>
        /// Delco Name
        /// Example: SHELL NEDERLAND VERKOOPMAATSCHAPPIJ BV
        /// </summary>
        [JsonProperty("DelcoName")]
        public string DelcoName
        {
            get
            {
                return this.delcoName;
            }

            set
            {
                this.shouldSerialize["DelcoName"] = true;
                this.delcoName = value;
            }
        }

        /// <summary>
        /// Delco Code
        /// 014, 018, etc.,
        /// </summary>
        [JsonProperty("DelcoCode")]
        public string DelcoCode
        {
            get
            {
                return this.delcoCode;
            }

            set
            {
                this.shouldSerialize["DelcoCode"] = true;
                this.delcoCode = value;
            }
        }

        /// <summary>
        /// Payer number (Country code+8 digits)
        /// Example: NL10042616
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
        /// Payer name
        /// Example: V.M. LE COMTE
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName
        {
            get
            {
                return this.payerName;
            }

            set
            {
                this.shouldSerialize["PayerName"] = true;
                this.payerName = value;
            }
        }

        /// <summary>
        /// Year/Month of the Card Expiry captured on the transaction
        /// Example: 1901
        /// </summary>
        [JsonProperty("CardExpiryPeriod")]
        public string CardExpiryPeriod
        {
            get
            {
                return this.cardExpiryPeriod;
            }

            set
            {
                this.shouldSerialize["CardExpiryPeriod"] = true;
                this.cardExpiryPeriod = value;
            }
        }

        /// <summary>
        /// Authorisation code of the transaction
        /// Example: 011256
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("AuthorisationCode")]
        public string AuthorisationCode
        {
            get
            {
                return this.authorisationCode;
            }

            set
            {
                this.shouldSerialize["AuthorisationCode"] = true;
                this.authorisationCode = value;
            }
        }

        /// <summary>
        /// Unique id of the transaction that may include one or more salesitems
        /// Example: io9KVXk1UkW57XWKyeaHHg
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("TransactionId")]
        public string TransactionId
        {
            get
            {
                return this.transactionId;
            }

            set
            {
                this.shouldSerialize["TransactionId"] = true;
                this.transactionId = value;
            }
        }

        /// <summary>
        /// Transaction line item number
        /// Example: 1
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("TransactionLine")]
        public string TransactionLine
        {
            get
            {
                return this.transactionLine;
            }

            set
            {
                this.shouldSerialize["TransactionLine"] = true;
                this.transactionLine = value;
            }
        }

        /// <summary>
        /// Is the Sales Item allowed for clearing? i.e. not written off
        /// Example: “Y” or “N”
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("AllowClearing")]
        public string AllowClearing
        {
            get
            {
                return this.allowClearing;
            }

            set
            {
                this.shouldSerialize["AllowClearing"] = true;
                this.allowClearing = value;
            }
        }

        /// <summary>
        /// CRM Case number if the sales item is in dispute.
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("CRMNumber")]
        public string CRMNumber
        {
            get
            {
                return this.cRMNumber;
            }

            set
            {
                this.shouldSerialize["CRMNumber"] = true;
                this.cRMNumber = value;
            }
        }

        /// <summary>
        /// Sales Item Dispute Status if disputed
        /// 0	No Dispute
        /// 1	In Dispute
        /// 2	Re-Instated
        /// 3	Adjusted
        /// 4	Written Off by Colco
        /// 5	Written Off by Delco
        /// 6	Charged Back to Site
        /// </summary>
        [JsonProperty("DisputeStatus")]
        public string DisputeStatus
        {
            get
            {
                return this.disputeStatus;
            }

            set
            {
                this.shouldSerialize["DisputeStatus"] = true;
                this.disputeStatus = value;
            }
        }

        /// <summary>
        /// Unit discount in customer currency.
        /// Example: 28.279000
        /// </summary>
        [JsonProperty("RebateRate")]
        public double? RebateRate
        {
            get
            {
                return this.rebateRate;
            }

            set
            {
                this.shouldSerialize["RebateRate"] = true;
                this.rebateRate = value;
            }
        }

        /// <summary>
        /// Exchange rate from transaction currency to customer currency.
        /// Example: 1
        /// </summary>
        [JsonProperty("DelCoToColCoExchangeRate")]
        public int? DelCoToColCoExchangeRate
        {
            get
            {
                return this.delCoToColCoExchangeRate;
            }

            set
            {
                this.shouldSerialize["DelCoToColCoExchangeRate"] = true;
                this.delCoToColCoExchangeRate = value;
            }
        }

        /// <summary>
        /// Net euro amount.
        /// Example: 37.93
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("NetEuroAmount")]
        public double? NetEuroAmount
        {
            get
            {
                return this.netEuroAmount;
            }

            set
            {
                this.shouldSerialize["NetEuroAmount"] = true;
                this.netEuroAmount = value;
            }
        }

        /// <summary>
        /// Euro rebate amount.
        /// Example: 0
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("EuroRebateAmount")]
        public int? EuroRebateAmount
        {
            get
            {
                return this.euroRebateAmount;
            }

            set
            {
                this.shouldSerialize["EuroRebateAmount"] = true;
                this.euroRebateAmount = value;
            }
        }

        /// <summary>
        /// Euro VAT amount.
        /// Example: 7.96
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("EuroVATAmount")]
        public double? EuroVATAmount
        {
            get
            {
                return this.euroVATAmount;
            }

            set
            {
                this.shouldSerialize["EuroVATAmount"] = true;
                this.euroVATAmount = value;
            }
        }

        /// <summary>
        /// Parent customer number
        /// </summary>
        [JsonProperty("ParentCustomerNumber")]
        public string ParentCustomerNumber
        {
            get
            {
                return this.parentCustomerNumber;
            }

            set
            {
                this.shouldSerialize["ParentCustomerNumber"] = true;
                this.parentCustomerNumber = value;
            }
        }

        /// <summary>
        /// Parent customer name.
        /// </summary>
        [JsonProperty("ParentCustomerName")]
        public string ParentCustomerName
        {
            get
            {
                return this.parentCustomerName;
            }

            set
            {
                this.shouldSerialize["ParentCustomerName"] = true;
                this.parentCustomerName = value;
            }
        }

        /// <summary>
        /// Parent customer id.
        /// </summary>
        [JsonProperty("ParentCustomerId")]
        public int? ParentCustomerId
        {
            get
            {
                return this.parentCustomerId;
            }

            set
            {
                this.shouldSerialize["ParentCustomerId"] = true;
                this.parentCustomerId = value;
            }
        }

        /// <summary>
        /// Incoming Site Number
        /// Example: 100021
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("IncomingSiteNumber")]
        public string IncomingSiteNumber
        {
            get
            {
                return this.incomingSiteNumber;
            }

            set
            {
                this.shouldSerialize["IncomingSiteNumber"] = true;
                this.incomingSiteNumber = value;
            }
        }

        /// <summary>
        /// Incoming Site Description
        /// Example: HN3 INTI_02-82.02
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("IncomingSiteDescription")]
        public string IncomingSiteDescription
        {
            get
            {
                return this.incomingSiteDescription;
            }

            set
            {
                this.shouldSerialize["IncomingSiteDescription"] = true;
                this.incomingSiteDescription = value;
            }
        }

        /// <summary>
        /// Incoming Currency Code
        /// Example: GBP
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("IncomingCurrencyCode")]
        public string IncomingCurrencyCode
        {
            get
            {
                return this.incomingCurrencyCode;
            }

            set
            {
                this.shouldSerialize["IncomingCurrencyCode"] = true;
                this.incomingCurrencyCode = value;
            }
        }

        /// <summary>
        /// Incoming Product Code
        /// Example: 30
        /// </summary>
        [JsonProperty("IncomingProductCode")]
        public string IncomingProductCode
        {
            get
            {
                return this.incomingProductCode;
            }

            set
            {
                this.shouldSerialize["IncomingProductCode"] = true;
                this.incomingProductCode = value;
            }
        }

        /// <summary>
        /// Credit Debit Code
        /// Example: “D” or “C”
        /// The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("CreditDebitCode")]
        public string CreditDebitCode
        {
            get
            {
                return this.creditDebitCode;
            }

            set
            {
                this.shouldSerialize["CreditDebitCode"] = true;
                this.creditDebitCode = value;
            }
        }

        /// <summary>
        /// Correction Flag
        /// Example: “Y” or “N”
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("CorrectionFlag")]
        public string CorrectionFlag
        {
            get
            {
                return this.correctionFlag;
            }

            set
            {
                this.shouldSerialize["CorrectionFlag"] = true;
                this.correctionFlag = value;
            }
        }

        /// <summary>
        /// Additional details
        /// </summary>
        [JsonProperty("Additional1")]
        public string Additional1
        {
            get
            {
                return this.additional1;
            }

            set
            {
                this.shouldSerialize["Additional1"] = true;
                this.additional1 = value;
            }
        }

        /// <summary>
        /// Additional details
        /// </summary>
        [JsonProperty("Additional2")]
        public string Additional2
        {
            get
            {
                return this.additional2;
            }

            set
            {
                this.shouldSerialize["Additional2"] = true;
                this.additional2 = value;
            }
        }

        /// <summary>
        /// Additional details
        /// </summary>
        [JsonProperty("Additional3")]
        public string Additional3
        {
            get
            {
                return this.additional3;
            }

            set
            {
                this.shouldSerialize["Additional3"] = true;
                this.additional3 = value;
            }
        }

        /// <summary>
        /// Additional details
        /// </summary>
        [JsonProperty("Additional4")]
        public string Additional4
        {
            get
            {
                return this.additional4;
            }

            set
            {
                this.shouldSerialize["Additional4"] = true;
                this.additional4 = value;
            }
        }

        /// <summary>
        /// Rebate on Net Amount in Customer Currency
        /// Example: -0.735000000000
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("RebateonNetAmountInCustomerCurrency")]
        public double? RebateonNetAmountInCustomerCurrency
        {
            get
            {
                return this.rebateonNetAmountInCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["RebateonNetAmountInCustomerCurrency"] = true;
                this.rebateonNetAmountInCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Rebate on Net Amount in Transaction Currency
        /// Example: -0.735000000000
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("RebateonNetAmountInTransactionCurrency")]
        public double? RebateonNetAmountInTransactionCurrency
        {
            get
            {
                return this.rebateonNetAmountInTransactionCurrency;
            }

            set
            {
                this.shouldSerialize["RebateonNetAmountInTransactionCurrency"] = true;
                this.rebateonNetAmountInTransactionCurrency = value;
            }
        }

        /// <summary>
        /// Network Code
        /// Example: AVEE PTUAZONW CUBFAO COSFS
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("NetworkCode")]
        public string NetworkCode
        {
            get
            {
                return this.networkCode;
            }

            set
            {
                this.shouldSerialize["NetworkCode"] = true;
                this.networkCode = value;
            }
        }

        /// <summary>
        /// Transaction Identifier
        /// </summary>
        [JsonProperty("TrnIdentifier")]
        public string TrnIdentifier
        {
            get
            {
                return this.trnIdentifier;
            }

            set
            {
                this.shouldSerialize["TrnIdentifier"] = true;
                this.trnIdentifier = value;
            }
        }

        /// <summary>
        /// Card Type
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType
        {
            get
            {
                return this.cardType;
            }

            set
            {
                this.shouldSerialize["CardType"] = true;
                this.cardType = value;
            }
        }

        /// <summary>
        /// Delco List Price Unit Net
        /// Example: 30.500000
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("DelcoListPriceUnitNet")]
        public double? DelcoListPriceUnitNet
        {
            get
            {
                return this.delcoListPriceUnitNet;
            }

            set
            {
                this.shouldSerialize["DelcoListPriceUnitNet"] = true;
                this.delcoListPriceUnitNet = value;
            }
        }

        /// <summary>
        /// Retail Net Price (or pump net price) per Unit in transaction currency
        /// Example: 1.921000
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("DelcoRetailPriceUnitNet")]
        public double? DelcoRetailPriceUnitNet
        {
            get
            {
                return this.delcoRetailPriceUnitNet;
            }

            set
            {
                this.shouldSerialize["DelcoRetailPriceUnitNet"] = true;
                this.delcoRetailPriceUnitNet = value;
            }
        }

        /// <summary>
        /// Retail gross price (or pump gross price) per unit in transaction currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("DelcoRetailPriceUnitGross")]
        public double? DelcoRetailPriceUnitGross
        {
            get
            {
                return this.delcoRetailPriceUnitGross;
            }

            set
            {
                this.shouldSerialize["DelcoRetailPriceUnitGross"] = true;
                this.delcoRetailPriceUnitGross = value;
            }
        }

        /// <summary>
        /// Retail net price (or net pump price) in transaction currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("DelcoRetailValueTotalNet")]
        public double? DelcoRetailValueTotalNet
        {
            get
            {
                return this.delcoRetailValueTotalNet;
            }

            set
            {
                this.shouldSerialize["DelcoRetailValueTotalNet"] = true;
                this.delcoRetailValueTotalNet = value;
            }
        }

        /// <summary>
        /// Retail gross price (or gross pump price) in transaction currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("DelcoRetailValueTotalGross")]
        public double? DelcoRetailValueTotalGross
        {
            get
            {
                return this.delcoRetailValueTotalGross;
            }

            set
            {
                this.shouldSerialize["DelcoRetailValueTotalGross"] = true;
                this.delcoRetailValueTotalGross = value;
            }
        }

        /// <summary>
        /// Retail gross price (or pump gross price) per unit in customer currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("CustomerRetailPriceUnitGross")]
        public double? CustomerRetailPriceUnitGross
        {
            get
            {
                return this.customerRetailPriceUnitGross;
            }

            set
            {
                this.shouldSerialize["CustomerRetailPriceUnitGross"] = true;
                this.customerRetailPriceUnitGross = value;
            }
        }

        /// <summary>
        /// Retail gross price (or gross pump price) in customer currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("CustomerRetailValueTotalGross")]
        public double? CustomerRetailValueTotalGross
        {
            get
            {
                return this.customerRetailValueTotalGross;
            }

            set
            {
                this.shouldSerialize["CustomerRetailValueTotalGross"] = true;
                this.customerRetailValueTotalGross = value;
            }
        }

        /// <summary>
        /// Retail net price (or net pump price) in customer currency
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("CustomerRetailValueTotalNet")]
        public double? CustomerRetailValueTotalNet
        {
            get
            {
                return this.customerRetailValueTotalNet;
            }

            set
            {
                this.shouldSerialize["CustomerRetailValueTotalNet"] = true;
                this.customerRetailValueTotalNet = value;
            }
        }

        /// <summary>
        /// Transaction Type Description
        /// Note: - The value could be null/blank for fees item
        /// </summary>
        [JsonProperty("TransactionTypeDescription")]
        public string TransactionTypeDescription
        {
            get
            {
                return this.transactionTypeDescription;
            }

            set
            {
                this.shouldSerialize["TransactionTypeDescription"] = true;
                this.transactionTypeDescription = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MultiPricedTransactionResponseTransactionsItems : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardPAN()
        {
            this.shouldSerialize["CardPAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardExpiry()
        {
            this.shouldSerialize["CardExpiry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionDate()
        {
            this.shouldSerialize["TransactionDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionTime()
        {
            this.shouldSerialize["TransactionTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUTCOffset()
        {
            this.shouldSerialize["UTCOffset"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFleetIdInput()
        {
            this.shouldSerialize["FleetIdInput"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOdometerInput()
        {
            this.shouldSerialize["OdometerInput"] = false;
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
        public void UnsetVehicleRegistration()
        {
            this.shouldSerialize["VehicleRegistration"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceCurrencyCode()
        {
            this.shouldSerialize["InvoiceCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceCurrencySymbol()
        {
            this.shouldSerialize["InvoiceCurrencySymbol"] = false;
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
        public void UnsetTransactionNetAmount()
        {
            this.shouldSerialize["TransactionNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionTax()
        {
            this.shouldSerialize["TransactionTax"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionGrossAmount()
        {
            this.shouldSerialize["TransactionGrossAmount"] = false;
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
        public void UnsetInvoiceTax()
        {
            this.shouldSerialize["InvoiceTax"] = false;
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
        public void UnsetPurchasedInCountry()
        {
            this.shouldSerialize["PurchasedInCountry"] = false;
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
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
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
        public void UnsetQuantity()
        {
            this.shouldSerialize["Quantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelProduct()
        {
            this.shouldSerialize["FuelProduct"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnitPriceInTransactionCurrency()
        {
            this.shouldSerialize["UnitPriceInTransactionCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnitPriceInInvoiceCurrency()
        {
            this.shouldSerialize["UnitPriceInInvoiceCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnitDiscountTransactionCurrency()
        {
            this.shouldSerialize["UnitDiscountTransactionCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnitDiscountInvoiceCurrency()
        {
            this.shouldSerialize["UnitDiscountInvoiceCurrency"] = false;
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
        public void UnsetSiteCode()
        {
            this.shouldSerialize["SiteCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteName()
        {
            this.shouldSerialize["SiteName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteCountry()
        {
            this.shouldSerialize["SiteCountry"] = false;
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
        public void UnsetReceiptNumber()
        {
            this.shouldSerialize["ReceiptNumber"] = false;
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
        public void UnsetDelCoExchangeRate()
        {
            this.shouldSerialize["DelCoExchangeRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoExchangeRate()
        {
            this.shouldSerialize["ColCoExchangeRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsShellSite()
        {
            this.shouldSerialize["IsShellSite"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetwork()
        {
            this.shouldSerialize["Network"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteGroupId()
        {
            this.shouldSerialize["SiteGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteGroupName()
        {
            this.shouldSerialize["SiteGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPostingDate()
        {
            this.shouldSerialize["PostingDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuerCode()
        {
            this.shouldSerialize["IssuerCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPurchasedInCountryCode()
        {
            this.shouldSerialize["PurchasedInCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerCountryCode()
        {
            this.shouldSerialize["CustomerCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerCountry()
        {
            this.shouldSerialize["CustomerCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReleaseCode()
        {
            this.shouldSerialize["ReleaseCode"] = false;
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
        public void UnsetCardSequenceNumber()
        {
            this.shouldSerialize["CardSequenceNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCheckDigit()
        {
            this.shouldSerialize["CheckDigit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFleetIDDescription()
        {
            this.shouldSerialize["FleetIDDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATRate()
        {
            this.shouldSerialize["VATRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCategory()
        {
            this.shouldSerialize["VATCategory"] = false;
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
        public void UnsetEffectiveDiscountInTrxCurrency()
        {
            this.shouldSerialize["EffectiveDiscountInTrxCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionType()
        {
            this.shouldSerialize["TransactionType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPINIndicator()
        {
            this.shouldSerialize["PINIndicator"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATApplicable()
        {
            this.shouldSerialize["VATApplicable"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetInvoiceIndicator()
        {
            this.shouldSerialize["NetInvoiceIndicator"] = false;
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
        public void UnsetEffectiveUnitDiscountInCustomerCurrency()
        {
            this.shouldSerialize["EffectiveUnitDiscountInCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEffectiveDiscountInCustomerCurrency()
        {
            this.shouldSerialize["EffectiveDiscountInCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATonNetAmountInCustomerCurrency()
        {
            this.shouldSerialize["VATonNetAmountInCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDiscountType()
        {
            this.shouldSerialize["DiscountType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionStatus()
        {
            this.shouldSerialize["TransactionStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSalesItemId()
        {
            this.shouldSerialize["SalesItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerGroup()
        {
            this.shouldSerialize["PayerGroup"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerGroupName()
        {
            this.shouldSerialize["PayerGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRefundFlag()
        {
            this.shouldSerialize["RefundFlag"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalSalesItemId()
        {
            this.shouldSerialize["OriginalSalesItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoName()
        {
            this.shouldSerialize["DelcoName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoCode()
        {
            this.shouldSerialize["DelcoCode"] = false;
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
        public void UnsetPayerName()
        {
            this.shouldSerialize["PayerName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardExpiryPeriod()
        {
            this.shouldSerialize["CardExpiryPeriod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAuthorisationCode()
        {
            this.shouldSerialize["AuthorisationCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionId()
        {
            this.shouldSerialize["TransactionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionLine()
        {
            this.shouldSerialize["TransactionLine"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAllowClearing()
        {
            this.shouldSerialize["AllowClearing"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCRMNumber()
        {
            this.shouldSerialize["CRMNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDisputeStatus()
        {
            this.shouldSerialize["DisputeStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRebateRate()
        {
            this.shouldSerialize["RebateRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelCoToColCoExchangeRate()
        {
            this.shouldSerialize["DelCoToColCoExchangeRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetEuroAmount()
        {
            this.shouldSerialize["NetEuroAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEuroRebateAmount()
        {
            this.shouldSerialize["EuroRebateAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEuroVATAmount()
        {
            this.shouldSerialize["EuroVATAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentCustomerNumber()
        {
            this.shouldSerialize["ParentCustomerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentCustomerName()
        {
            this.shouldSerialize["ParentCustomerName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetParentCustomerId()
        {
            this.shouldSerialize["ParentCustomerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncomingSiteNumber()
        {
            this.shouldSerialize["IncomingSiteNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncomingSiteDescription()
        {
            this.shouldSerialize["IncomingSiteDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncomingCurrencyCode()
        {
            this.shouldSerialize["IncomingCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIncomingProductCode()
        {
            this.shouldSerialize["IncomingProductCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCreditDebitCode()
        {
            this.shouldSerialize["CreditDebitCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCorrectionFlag()
        {
            this.shouldSerialize["CorrectionFlag"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAdditional1()
        {
            this.shouldSerialize["Additional1"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAdditional2()
        {
            this.shouldSerialize["Additional2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAdditional3()
        {
            this.shouldSerialize["Additional3"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAdditional4()
        {
            this.shouldSerialize["Additional4"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRebateonNetAmountInCustomerCurrency()
        {
            this.shouldSerialize["RebateonNetAmountInCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRebateonNetAmountInTransactionCurrency()
        {
            this.shouldSerialize["RebateonNetAmountInTransactionCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetworkCode()
        {
            this.shouldSerialize["NetworkCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrnIdentifier()
        {
            this.shouldSerialize["TrnIdentifier"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardType()
        {
            this.shouldSerialize["CardType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoListPriceUnitNet()
        {
            this.shouldSerialize["DelcoListPriceUnitNet"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoRetailPriceUnitNet()
        {
            this.shouldSerialize["DelcoRetailPriceUnitNet"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoRetailPriceUnitGross()
        {
            this.shouldSerialize["DelcoRetailPriceUnitGross"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoRetailValueTotalNet()
        {
            this.shouldSerialize["DelcoRetailValueTotalNet"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoRetailValueTotalGross()
        {
            this.shouldSerialize["DelcoRetailValueTotalGross"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerRetailPriceUnitGross()
        {
            this.shouldSerialize["CustomerRetailPriceUnitGross"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerRetailValueTotalGross()
        {
            this.shouldSerialize["CustomerRetailValueTotalGross"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerRetailValueTotalNet()
        {
            this.shouldSerialize["CustomerRetailValueTotalNet"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionTypeDescription()
        {
            this.shouldSerialize["TransactionTypeDescription"] = false;
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
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardPAN()
        {
            return this.shouldSerialize["CardPAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardExpiry()
        {
            return this.shouldSerialize["CardExpiry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionDate()
        {
            return this.shouldSerialize["TransactionDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionTime()
        {
            return this.shouldSerialize["TransactionTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUTCOffset()
        {
            return this.shouldSerialize["UTCOffset"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFleetIdInput()
        {
            return this.shouldSerialize["FleetIdInput"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOdometerInput()
        {
            return this.shouldSerialize["OdometerInput"];
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
        public bool ShouldSerializeVehicleRegistration()
        {
            return this.shouldSerialize["VehicleRegistration"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceCurrencyCode()
        {
            return this.shouldSerialize["InvoiceCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceCurrencySymbol()
        {
            return this.shouldSerialize["InvoiceCurrencySymbol"];
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
        public bool ShouldSerializeTransactionNetAmount()
        {
            return this.shouldSerialize["TransactionNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionTax()
        {
            return this.shouldSerialize["TransactionTax"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionGrossAmount()
        {
            return this.shouldSerialize["TransactionGrossAmount"];
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
        public bool ShouldSerializeInvoiceTax()
        {
            return this.shouldSerialize["InvoiceTax"];
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
        public bool ShouldSerializePurchasedInCountry()
        {
            return this.shouldSerialize["PurchasedInCountry"];
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
        public bool ShouldSerializeAccountName()
        {
            return this.shouldSerialize["AccountName"];
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
        public bool ShouldSerializeQuantity()
        {
            return this.shouldSerialize["Quantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelProduct()
        {
            return this.shouldSerialize["FuelProduct"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitPriceInTransactionCurrency()
        {
            return this.shouldSerialize["UnitPriceInTransactionCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitPriceInInvoiceCurrency()
        {
            return this.shouldSerialize["UnitPriceInInvoiceCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitDiscountTransactionCurrency()
        {
            return this.shouldSerialize["UnitDiscountTransactionCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitDiscountInvoiceCurrency()
        {
            return this.shouldSerialize["UnitDiscountInvoiceCurrency"];
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
        public bool ShouldSerializeSiteCode()
        {
            return this.shouldSerialize["SiteCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteName()
        {
            return this.shouldSerialize["SiteName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteCountry()
        {
            return this.shouldSerialize["SiteCountry"];
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
        public bool ShouldSerializeReceiptNumber()
        {
            return this.shouldSerialize["ReceiptNumber"];
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
        public bool ShouldSerializeDelCoExchangeRate()
        {
            return this.shouldSerialize["DelCoExchangeRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoExchangeRate()
        {
            return this.shouldSerialize["ColCoExchangeRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsShellSite()
        {
            return this.shouldSerialize["IsShellSite"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetwork()
        {
            return this.shouldSerialize["Network"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteGroupId()
        {
            return this.shouldSerialize["SiteGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteGroupName()
        {
            return this.shouldSerialize["SiteGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePostingDate()
        {
            return this.shouldSerialize["PostingDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuerCode()
        {
            return this.shouldSerialize["IssuerCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchasedInCountryCode()
        {
            return this.shouldSerialize["PurchasedInCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerCountryCode()
        {
            return this.shouldSerialize["CustomerCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerCountry()
        {
            return this.shouldSerialize["CustomerCountry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReleaseCode()
        {
            return this.shouldSerialize["ReleaseCode"];
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
        public bool ShouldSerializeCardSequenceNumber()
        {
            return this.shouldSerialize["CardSequenceNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCheckDigit()
        {
            return this.shouldSerialize["CheckDigit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFleetIDDescription()
        {
            return this.shouldSerialize["FleetIDDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATRate()
        {
            return this.shouldSerialize["VATRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCategory()
        {
            return this.shouldSerialize["VATCategory"];
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
        public bool ShouldSerializeEffectiveDiscountInTrxCurrency()
        {
            return this.shouldSerialize["EffectiveDiscountInTrxCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionType()
        {
            return this.shouldSerialize["TransactionType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePINIndicator()
        {
            return this.shouldSerialize["PINIndicator"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATApplicable()
        {
            return this.shouldSerialize["VATApplicable"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetInvoiceIndicator()
        {
            return this.shouldSerialize["NetInvoiceIndicator"];
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
        public bool ShouldSerializeEffectiveUnitDiscountInCustomerCurrency()
        {
            return this.shouldSerialize["EffectiveUnitDiscountInCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEffectiveDiscountInCustomerCurrency()
        {
            return this.shouldSerialize["EffectiveDiscountInCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATonNetAmountInCustomerCurrency()
        {
            return this.shouldSerialize["VATonNetAmountInCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDiscountType()
        {
            return this.shouldSerialize["DiscountType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionStatus()
        {
            return this.shouldSerialize["TransactionStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSalesItemId()
        {
            return this.shouldSerialize["SalesItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerGroup()
        {
            return this.shouldSerialize["PayerGroup"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerGroupName()
        {
            return this.shouldSerialize["PayerGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRefundFlag()
        {
            return this.shouldSerialize["RefundFlag"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalSalesItemId()
        {
            return this.shouldSerialize["OriginalSalesItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoName()
        {
            return this.shouldSerialize["DelcoName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoCode()
        {
            return this.shouldSerialize["DelcoCode"];
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
        public bool ShouldSerializePayerName()
        {
            return this.shouldSerialize["PayerName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardExpiryPeriod()
        {
            return this.shouldSerialize["CardExpiryPeriod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAuthorisationCode()
        {
            return this.shouldSerialize["AuthorisationCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionId()
        {
            return this.shouldSerialize["TransactionId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionLine()
        {
            return this.shouldSerialize["TransactionLine"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAllowClearing()
        {
            return this.shouldSerialize["AllowClearing"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCRMNumber()
        {
            return this.shouldSerialize["CRMNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDisputeStatus()
        {
            return this.shouldSerialize["DisputeStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRebateRate()
        {
            return this.shouldSerialize["RebateRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelCoToColCoExchangeRate()
        {
            return this.shouldSerialize["DelCoToColCoExchangeRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetEuroAmount()
        {
            return this.shouldSerialize["NetEuroAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEuroRebateAmount()
        {
            return this.shouldSerialize["EuroRebateAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEuroVATAmount()
        {
            return this.shouldSerialize["EuroVATAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentCustomerNumber()
        {
            return this.shouldSerialize["ParentCustomerNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentCustomerName()
        {
            return this.shouldSerialize["ParentCustomerName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeParentCustomerId()
        {
            return this.shouldSerialize["ParentCustomerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncomingSiteNumber()
        {
            return this.shouldSerialize["IncomingSiteNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncomingSiteDescription()
        {
            return this.shouldSerialize["IncomingSiteDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncomingCurrencyCode()
        {
            return this.shouldSerialize["IncomingCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncomingProductCode()
        {
            return this.shouldSerialize["IncomingProductCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCreditDebitCode()
        {
            return this.shouldSerialize["CreditDebitCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCorrectionFlag()
        {
            return this.shouldSerialize["CorrectionFlag"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditional1()
        {
            return this.shouldSerialize["Additional1"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditional2()
        {
            return this.shouldSerialize["Additional2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditional3()
        {
            return this.shouldSerialize["Additional3"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAdditional4()
        {
            return this.shouldSerialize["Additional4"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRebateonNetAmountInCustomerCurrency()
        {
            return this.shouldSerialize["RebateonNetAmountInCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRebateonNetAmountInTransactionCurrency()
        {
            return this.shouldSerialize["RebateonNetAmountInTransactionCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetworkCode()
        {
            return this.shouldSerialize["NetworkCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrnIdentifier()
        {
            return this.shouldSerialize["TrnIdentifier"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardType()
        {
            return this.shouldSerialize["CardType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoListPriceUnitNet()
        {
            return this.shouldSerialize["DelcoListPriceUnitNet"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoRetailPriceUnitNet()
        {
            return this.shouldSerialize["DelcoRetailPriceUnitNet"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoRetailPriceUnitGross()
        {
            return this.shouldSerialize["DelcoRetailPriceUnitGross"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoRetailValueTotalNet()
        {
            return this.shouldSerialize["DelcoRetailValueTotalNet"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoRetailValueTotalGross()
        {
            return this.shouldSerialize["DelcoRetailValueTotalGross"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerRetailPriceUnitGross()
        {
            return this.shouldSerialize["CustomerRetailPriceUnitGross"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerRetailValueTotalGross()
        {
            return this.shouldSerialize["CustomerRetailValueTotalGross"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerRetailValueTotalNet()
        {
            return this.shouldSerialize["CustomerRetailValueTotalNet"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionTypeDescription()
        {
            return this.shouldSerialize["TransactionTypeDescription"];
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
            return obj is MultiPricedTransactionResponseTransactionsItems other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.CardExpiry == null && other.CardExpiry == null) || (this.CardExpiry?.Equals(other.CardExpiry) == true)) &&
                ((this.TransactionDate == null && other.TransactionDate == null) || (this.TransactionDate?.Equals(other.TransactionDate) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.UTCOffset == null && other.UTCOffset == null) || (this.UTCOffset?.Equals(other.UTCOffset) == true)) &&
                ((this.FleetIdInput == null && other.FleetIdInput == null) || (this.FleetIdInput?.Equals(other.FleetIdInput) == true)) &&
                ((this.OdometerInput == null && other.OdometerInput == null) || (this.OdometerInput?.Equals(other.OdometerInput) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.VehicleRegistration == null && other.VehicleRegistration == null) || (this.VehicleRegistration?.Equals(other.VehicleRegistration) == true)) &&
                ((this.InvoiceCurrencyCode == null && other.InvoiceCurrencyCode == null) || (this.InvoiceCurrencyCode?.Equals(other.InvoiceCurrencyCode) == true)) &&
                ((this.InvoiceCurrencySymbol == null && other.InvoiceCurrencySymbol == null) || (this.InvoiceCurrencySymbol?.Equals(other.InvoiceCurrencySymbol) == true)) &&
                ((this.TransactionCurrencyCode == null && other.TransactionCurrencyCode == null) || (this.TransactionCurrencyCode?.Equals(other.TransactionCurrencyCode) == true)) &&
                ((this.TransactionCurrencySymbol == null && other.TransactionCurrencySymbol == null) || (this.TransactionCurrencySymbol?.Equals(other.TransactionCurrencySymbol) == true)) &&
                ((this.TransactionNetAmount == null && other.TransactionNetAmount == null) || (this.TransactionNetAmount?.Equals(other.TransactionNetAmount) == true)) &&
                ((this.TransactionTax == null && other.TransactionTax == null) || (this.TransactionTax?.Equals(other.TransactionTax) == true)) &&
                ((this.TransactionGrossAmount == null && other.TransactionGrossAmount == null) || (this.TransactionGrossAmount?.Equals(other.TransactionGrossAmount) == true)) &&
                ((this.InvoiceNetAmount == null && other.InvoiceNetAmount == null) || (this.InvoiceNetAmount?.Equals(other.InvoiceNetAmount) == true)) &&
                ((this.InvoiceTax == null && other.InvoiceTax == null) || (this.InvoiceTax?.Equals(other.InvoiceTax) == true)) &&
                ((this.InvoiceGrossAmount == null && other.InvoiceGrossAmount == null) || (this.InvoiceGrossAmount?.Equals(other.InvoiceGrossAmount) == true)) &&
                ((this.PurchasedInCountry == null && other.PurchasedInCountry == null) || (this.PurchasedInCountry?.Equals(other.PurchasedInCountry) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.FuelProduct == null && other.FuelProduct == null) || (this.FuelProduct?.Equals(other.FuelProduct) == true)) &&
                ((this.UnitPriceInTransactionCurrency == null && other.UnitPriceInTransactionCurrency == null) || (this.UnitPriceInTransactionCurrency?.Equals(other.UnitPriceInTransactionCurrency) == true)) &&
                ((this.UnitPriceInInvoiceCurrency == null && other.UnitPriceInInvoiceCurrency == null) || (this.UnitPriceInInvoiceCurrency?.Equals(other.UnitPriceInInvoiceCurrency) == true)) &&
                ((this.UnitDiscountTransactionCurrency == null && other.UnitDiscountTransactionCurrency == null) || (this.UnitDiscountTransactionCurrency?.Equals(other.UnitDiscountTransactionCurrency) == true)) &&
                ((this.UnitDiscountInvoiceCurrency == null && other.UnitDiscountInvoiceCurrency == null) || (this.UnitDiscountInvoiceCurrency?.Equals(other.UnitDiscountInvoiceCurrency) == true)) &&
                ((this.IsInvoiced == null && other.IsInvoiced == null) || (this.IsInvoiced?.Equals(other.IsInvoiced) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.SiteCode == null && other.SiteCode == null) || (this.SiteCode?.Equals(other.SiteCode) == true)) &&
                ((this.SiteName == null && other.SiteName == null) || (this.SiteName?.Equals(other.SiteName) == true)) &&
                ((this.SiteCountry == null && other.SiteCountry == null) || (this.SiteCountry?.Equals(other.SiteCountry) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.ReceiptNumber == null && other.ReceiptNumber == null) || (this.ReceiptNumber?.Equals(other.ReceiptNumber) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductGroupId == null && other.ProductGroupId == null) || (this.ProductGroupId?.Equals(other.ProductGroupId) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true)) &&
                ((this.DelCoExchangeRate == null && other.DelCoExchangeRate == null) || (this.DelCoExchangeRate?.Equals(other.DelCoExchangeRate) == true)) &&
                ((this.ColCoExchangeRate == null && other.ColCoExchangeRate == null) || (this.ColCoExchangeRate?.Equals(other.ColCoExchangeRate) == true)) &&
                ((this.IsShellSite == null && other.IsShellSite == null) || (this.IsShellSite?.Equals(other.IsShellSite) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.SiteGroupName == null && other.SiteGroupName == null) || (this.SiteGroupName?.Equals(other.SiteGroupName) == true)) &&
                ((this.PostingDate == null && other.PostingDate == null) || (this.PostingDate?.Equals(other.PostingDate) == true)) &&
                ((this.IssuerCode == null && other.IssuerCode == null) || (this.IssuerCode?.Equals(other.IssuerCode) == true)) &&
                ((this.PurchasedInCountryCode == null && other.PurchasedInCountryCode == null) || (this.PurchasedInCountryCode?.Equals(other.PurchasedInCountryCode) == true)) &&
                ((this.CustomerCountryCode == null && other.CustomerCountryCode == null) || (this.CustomerCountryCode?.Equals(other.CustomerCountryCode) == true)) &&
                ((this.CustomerCountry == null && other.CustomerCountry == null) || (this.CustomerCountry?.Equals(other.CustomerCountry) == true)) &&
                ((this.ReleaseCode == null && other.ReleaseCode == null) || (this.ReleaseCode?.Equals(other.ReleaseCode) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardSequenceNumber == null && other.CardSequenceNumber == null) || (this.CardSequenceNumber?.Equals(other.CardSequenceNumber) == true)) &&
                ((this.CheckDigit == null && other.CheckDigit == null) || (this.CheckDigit?.Equals(other.CheckDigit) == true)) &&
                ((this.FleetIDDescription == null && other.FleetIDDescription == null) || (this.FleetIDDescription?.Equals(other.FleetIDDescription) == true)) &&
                ((this.VATRate == null && other.VATRate == null) || (this.VATRate?.Equals(other.VATRate) == true)) &&
                ((this.VATCategory == null && other.VATCategory == null) || (this.VATCategory?.Equals(other.VATCategory) == true)) &&
                ((this.VATCountry == null && other.VATCountry == null) || (this.VATCountry?.Equals(other.VATCountry) == true)) &&
                ((this.EffectiveDiscountInTrxCurrency == null && other.EffectiveDiscountInTrxCurrency == null) || (this.EffectiveDiscountInTrxCurrency?.Equals(other.EffectiveDiscountInTrxCurrency) == true)) &&
                ((this.TransactionType == null && other.TransactionType == null) || (this.TransactionType?.Equals(other.TransactionType) == true)) &&
                ((this.PINIndicator == null && other.PINIndicator == null) || (this.PINIndicator?.Equals(other.PINIndicator) == true)) &&
                ((this.VATApplicable == null && other.VATApplicable == null) || (this.VATApplicable?.Equals(other.VATApplicable) == true)) &&
                ((this.NetInvoiceIndicator == null && other.NetInvoiceIndicator == null) || (this.NetInvoiceIndicator?.Equals(other.NetInvoiceIndicator) == true)) &&
                ((this.CustomerCurrencyCode == null && other.CustomerCurrencyCode == null) || (this.CustomerCurrencyCode?.Equals(other.CustomerCurrencyCode) == true)) &&
                ((this.CustomerCurrencySymbol == null && other.CustomerCurrencySymbol == null) || (this.CustomerCurrencySymbol?.Equals(other.CustomerCurrencySymbol) == true)) &&
                ((this.EffectiveUnitDiscountInCustomerCurrency == null && other.EffectiveUnitDiscountInCustomerCurrency == null) || (this.EffectiveUnitDiscountInCustomerCurrency?.Equals(other.EffectiveUnitDiscountInCustomerCurrency) == true)) &&
                ((this.EffectiveDiscountInCustomerCurrency == null && other.EffectiveDiscountInCustomerCurrency == null) || (this.EffectiveDiscountInCustomerCurrency?.Equals(other.EffectiveDiscountInCustomerCurrency) == true)) &&
                ((this.VATonNetAmountInCustomerCurrency == null && other.VATonNetAmountInCustomerCurrency == null) || (this.VATonNetAmountInCustomerCurrency?.Equals(other.VATonNetAmountInCustomerCurrency) == true)) &&
                ((this.DiscountType == null && other.DiscountType == null) || (this.DiscountType?.Equals(other.DiscountType) == true)) &&
                ((this.TransactionStatus == null && other.TransactionStatus == null) || (this.TransactionStatus?.Equals(other.TransactionStatus) == true)) &&
                ((this.SalesItemId == null && other.SalesItemId == null) || (this.SalesItemId?.Equals(other.SalesItemId) == true)) &&
                ((this.PayerGroup == null && other.PayerGroup == null) || (this.PayerGroup?.Equals(other.PayerGroup) == true)) &&
                ((this.PayerGroupName == null && other.PayerGroupName == null) || (this.PayerGroupName?.Equals(other.PayerGroupName) == true)) &&
                ((this.RefundFlag == null && other.RefundFlag == null) || (this.RefundFlag?.Equals(other.RefundFlag) == true)) &&
                ((this.OriginalSalesItemId == null && other.OriginalSalesItemId == null) || (this.OriginalSalesItemId?.Equals(other.OriginalSalesItemId) == true)) &&
                ((this.DelcoName == null && other.DelcoName == null) || (this.DelcoName?.Equals(other.DelcoName) == true)) &&
                ((this.DelcoCode == null && other.DelcoCode == null) || (this.DelcoCode?.Equals(other.DelcoCode) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerName == null && other.PayerName == null) || (this.PayerName?.Equals(other.PayerName) == true)) &&
                ((this.CardExpiryPeriod == null && other.CardExpiryPeriod == null) || (this.CardExpiryPeriod?.Equals(other.CardExpiryPeriod) == true)) &&
                ((this.AuthorisationCode == null && other.AuthorisationCode == null) || (this.AuthorisationCode?.Equals(other.AuthorisationCode) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.TransactionLine == null && other.TransactionLine == null) || (this.TransactionLine?.Equals(other.TransactionLine) == true)) &&
                ((this.AllowClearing == null && other.AllowClearing == null) || (this.AllowClearing?.Equals(other.AllowClearing) == true)) &&
                ((this.CRMNumber == null && other.CRMNumber == null) || (this.CRMNumber?.Equals(other.CRMNumber) == true)) &&
                ((this.DisputeStatus == null && other.DisputeStatus == null) || (this.DisputeStatus?.Equals(other.DisputeStatus) == true)) &&
                ((this.RebateRate == null && other.RebateRate == null) || (this.RebateRate?.Equals(other.RebateRate) == true)) &&
                ((this.DelCoToColCoExchangeRate == null && other.DelCoToColCoExchangeRate == null) || (this.DelCoToColCoExchangeRate?.Equals(other.DelCoToColCoExchangeRate) == true)) &&
                ((this.NetEuroAmount == null && other.NetEuroAmount == null) || (this.NetEuroAmount?.Equals(other.NetEuroAmount) == true)) &&
                ((this.EuroRebateAmount == null && other.EuroRebateAmount == null) || (this.EuroRebateAmount?.Equals(other.EuroRebateAmount) == true)) &&
                ((this.EuroVATAmount == null && other.EuroVATAmount == null) || (this.EuroVATAmount?.Equals(other.EuroVATAmount) == true)) &&
                ((this.ParentCustomerNumber == null && other.ParentCustomerNumber == null) || (this.ParentCustomerNumber?.Equals(other.ParentCustomerNumber) == true)) &&
                ((this.ParentCustomerName == null && other.ParentCustomerName == null) || (this.ParentCustomerName?.Equals(other.ParentCustomerName) == true)) &&
                ((this.ParentCustomerId == null && other.ParentCustomerId == null) || (this.ParentCustomerId?.Equals(other.ParentCustomerId) == true)) &&
                ((this.IncomingSiteNumber == null && other.IncomingSiteNumber == null) || (this.IncomingSiteNumber?.Equals(other.IncomingSiteNumber) == true)) &&
                ((this.IncomingSiteDescription == null && other.IncomingSiteDescription == null) || (this.IncomingSiteDescription?.Equals(other.IncomingSiteDescription) == true)) &&
                ((this.IncomingCurrencyCode == null && other.IncomingCurrencyCode == null) || (this.IncomingCurrencyCode?.Equals(other.IncomingCurrencyCode) == true)) &&
                ((this.IncomingProductCode == null && other.IncomingProductCode == null) || (this.IncomingProductCode?.Equals(other.IncomingProductCode) == true)) &&
                ((this.CreditDebitCode == null && other.CreditDebitCode == null) || (this.CreditDebitCode?.Equals(other.CreditDebitCode) == true)) &&
                ((this.CorrectionFlag == null && other.CorrectionFlag == null) || (this.CorrectionFlag?.Equals(other.CorrectionFlag) == true)) &&
                ((this.Additional1 == null && other.Additional1 == null) || (this.Additional1?.Equals(other.Additional1) == true)) &&
                ((this.Additional2 == null && other.Additional2 == null) || (this.Additional2?.Equals(other.Additional2) == true)) &&
                ((this.Additional3 == null && other.Additional3 == null) || (this.Additional3?.Equals(other.Additional3) == true)) &&
                ((this.Additional4 == null && other.Additional4 == null) || (this.Additional4?.Equals(other.Additional4) == true)) &&
                ((this.RebateonNetAmountInCustomerCurrency == null && other.RebateonNetAmountInCustomerCurrency == null) || (this.RebateonNetAmountInCustomerCurrency?.Equals(other.RebateonNetAmountInCustomerCurrency) == true)) &&
                ((this.RebateonNetAmountInTransactionCurrency == null && other.RebateonNetAmountInTransactionCurrency == null) || (this.RebateonNetAmountInTransactionCurrency?.Equals(other.RebateonNetAmountInTransactionCurrency) == true)) &&
                ((this.NetworkCode == null && other.NetworkCode == null) || (this.NetworkCode?.Equals(other.NetworkCode) == true)) &&
                ((this.TrnIdentifier == null && other.TrnIdentifier == null) || (this.TrnIdentifier?.Equals(other.TrnIdentifier) == true)) &&
                ((this.CardType == null && other.CardType == null) || (this.CardType?.Equals(other.CardType) == true)) &&
                ((this.DelcoListPriceUnitNet == null && other.DelcoListPriceUnitNet == null) || (this.DelcoListPriceUnitNet?.Equals(other.DelcoListPriceUnitNet) == true)) &&
                ((this.DelcoRetailPriceUnitNet == null && other.DelcoRetailPriceUnitNet == null) || (this.DelcoRetailPriceUnitNet?.Equals(other.DelcoRetailPriceUnitNet) == true)) &&
                ((this.DelcoRetailPriceUnitGross == null && other.DelcoRetailPriceUnitGross == null) || (this.DelcoRetailPriceUnitGross?.Equals(other.DelcoRetailPriceUnitGross) == true)) &&
                ((this.DelcoRetailValueTotalNet == null && other.DelcoRetailValueTotalNet == null) || (this.DelcoRetailValueTotalNet?.Equals(other.DelcoRetailValueTotalNet) == true)) &&
                ((this.DelcoRetailValueTotalGross == null && other.DelcoRetailValueTotalGross == null) || (this.DelcoRetailValueTotalGross?.Equals(other.DelcoRetailValueTotalGross) == true)) &&
                ((this.CustomerRetailPriceUnitGross == null && other.CustomerRetailPriceUnitGross == null) || (this.CustomerRetailPriceUnitGross?.Equals(other.CustomerRetailPriceUnitGross) == true)) &&
                ((this.CustomerRetailValueTotalGross == null && other.CustomerRetailValueTotalGross == null) || (this.CustomerRetailValueTotalGross?.Equals(other.CustomerRetailValueTotalGross) == true)) &&
                ((this.CustomerRetailValueTotalNet == null && other.CustomerRetailValueTotalNet == null) || (this.CustomerRetailValueTotalNet?.Equals(other.CustomerRetailValueTotalNet) == true)) &&
                ((this.TransactionTypeDescription == null && other.TransactionTypeDescription == null) || (this.TransactionTypeDescription?.Equals(other.TransactionTypeDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.CardExpiry = {(this.CardExpiry == null ? "null" : this.CardExpiry)}");
            toStringOutput.Add($"this.TransactionDate = {(this.TransactionDate == null ? "null" : this.TransactionDate)}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime)}");
            toStringOutput.Add($"this.UTCOffset = {(this.UTCOffset == null ? "null" : this.UTCOffset)}");
            toStringOutput.Add($"this.FleetIdInput = {(this.FleetIdInput == null ? "null" : this.FleetIdInput)}");
            toStringOutput.Add($"this.OdometerInput = {(this.OdometerInput == null ? "null" : this.OdometerInput.ToString())}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.VehicleRegistration = {(this.VehicleRegistration == null ? "null" : this.VehicleRegistration)}");
            toStringOutput.Add($"this.InvoiceCurrencyCode = {(this.InvoiceCurrencyCode == null ? "null" : this.InvoiceCurrencyCode)}");
            toStringOutput.Add($"this.InvoiceCurrencySymbol = {(this.InvoiceCurrencySymbol == null ? "null" : this.InvoiceCurrencySymbol)}");
            toStringOutput.Add($"this.TransactionCurrencyCode = {(this.TransactionCurrencyCode == null ? "null" : this.TransactionCurrencyCode)}");
            toStringOutput.Add($"this.TransactionCurrencySymbol = {(this.TransactionCurrencySymbol == null ? "null" : this.TransactionCurrencySymbol)}");
            toStringOutput.Add($"this.TransactionNetAmount = {(this.TransactionNetAmount == null ? "null" : this.TransactionNetAmount.ToString())}");
            toStringOutput.Add($"this.TransactionTax = {(this.TransactionTax == null ? "null" : this.TransactionTax.ToString())}");
            toStringOutput.Add($"this.TransactionGrossAmount = {(this.TransactionGrossAmount == null ? "null" : this.TransactionGrossAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceNetAmount = {(this.InvoiceNetAmount == null ? "null" : this.InvoiceNetAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceTax = {(this.InvoiceTax == null ? "null" : this.InvoiceTax.ToString())}");
            toStringOutput.Add($"this.InvoiceGrossAmount = {(this.InvoiceGrossAmount == null ? "null" : this.InvoiceGrossAmount.ToString())}");
            toStringOutput.Add($"this.PurchasedInCountry = {(this.PurchasedInCountry == null ? "null" : this.PurchasedInCountry)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.FuelProduct = {(this.FuelProduct == null ? "null" : this.FuelProduct.ToString())}");
            toStringOutput.Add($"this.UnitPriceInTransactionCurrency = {(this.UnitPriceInTransactionCurrency == null ? "null" : this.UnitPriceInTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.UnitPriceInInvoiceCurrency = {(this.UnitPriceInInvoiceCurrency == null ? "null" : this.UnitPriceInInvoiceCurrency.ToString())}");
            toStringOutput.Add($"this.UnitDiscountTransactionCurrency = {(this.UnitDiscountTransactionCurrency == null ? "null" : this.UnitDiscountTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.UnitDiscountInvoiceCurrency = {(this.UnitDiscountInvoiceCurrency == null ? "null" : this.UnitDiscountInvoiceCurrency.ToString())}");
            toStringOutput.Add($"this.IsInvoiced = {(this.IsInvoiced == null ? "null" : this.IsInvoiced.ToString())}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.SiteCode = {(this.SiteCode == null ? "null" : this.SiteCode)}");
            toStringOutput.Add($"this.SiteName = {(this.SiteName == null ? "null" : this.SiteName)}");
            toStringOutput.Add($"this.SiteCountry = {(this.SiteCountry == null ? "null" : this.SiteCountry)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : $"[{string.Join(", ", this.Location)} ]")}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.ReceiptNumber = {(this.ReceiptNumber == null ? "null" : this.ReceiptNumber)}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductGroupId = {(this.ProductGroupId == null ? "null" : this.ProductGroupId.ToString())}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
            toStringOutput.Add($"this.DelCoExchangeRate = {(this.DelCoExchangeRate == null ? "null" : this.DelCoExchangeRate.ToString())}");
            toStringOutput.Add($"this.ColCoExchangeRate = {(this.ColCoExchangeRate == null ? "null" : this.ColCoExchangeRate.ToString())}");
            toStringOutput.Add($"this.IsShellSite = {(this.IsShellSite == null ? "null" : this.IsShellSite.ToString())}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network)}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.SiteGroupName = {(this.SiteGroupName == null ? "null" : this.SiteGroupName)}");
            toStringOutput.Add($"this.PostingDate = {(this.PostingDate == null ? "null" : this.PostingDate)}");
            toStringOutput.Add($"this.IssuerCode = {(this.IssuerCode == null ? "null" : this.IssuerCode)}");
            toStringOutput.Add($"this.PurchasedInCountryCode = {(this.PurchasedInCountryCode == null ? "null" : this.PurchasedInCountryCode)}");
            toStringOutput.Add($"this.CustomerCountryCode = {(this.CustomerCountryCode == null ? "null" : this.CustomerCountryCode)}");
            toStringOutput.Add($"this.CustomerCountry = {(this.CustomerCountry == null ? "null" : this.CustomerCountry)}");
            toStringOutput.Add($"this.ReleaseCode = {(this.ReleaseCode == null ? "null" : this.ReleaseCode)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId)}");
            toStringOutput.Add($"this.CardSequenceNumber = {(this.CardSequenceNumber == null ? "null" : this.CardSequenceNumber)}");
            toStringOutput.Add($"this.CheckDigit = {(this.CheckDigit == null ? "null" : this.CheckDigit)}");
            toStringOutput.Add($"this.FleetIDDescription = {(this.FleetIDDescription == null ? "null" : this.FleetIDDescription)}");
            toStringOutput.Add($"this.VATRate = {(this.VATRate == null ? "null" : this.VATRate.ToString())}");
            toStringOutput.Add($"this.VATCategory = {(this.VATCategory == null ? "null" : this.VATCategory)}");
            toStringOutput.Add($"this.VATCountry = {(this.VATCountry == null ? "null" : this.VATCountry)}");
            toStringOutput.Add($"this.EffectiveDiscountInTrxCurrency = {(this.EffectiveDiscountInTrxCurrency == null ? "null" : this.EffectiveDiscountInTrxCurrency.ToString())}");
            toStringOutput.Add($"this.TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType)}");
            toStringOutput.Add($"this.PINIndicator = {(this.PINIndicator == null ? "null" : this.PINIndicator)}");
            toStringOutput.Add($"this.VATApplicable = {(this.VATApplicable == null ? "null" : this.VATApplicable)}");
            toStringOutput.Add($"this.NetInvoiceIndicator = {(this.NetInvoiceIndicator == null ? "null" : this.NetInvoiceIndicator)}");
            toStringOutput.Add($"this.CustomerCurrencyCode = {(this.CustomerCurrencyCode == null ? "null" : this.CustomerCurrencyCode)}");
            toStringOutput.Add($"this.CustomerCurrencySymbol = {(this.CustomerCurrencySymbol == null ? "null" : this.CustomerCurrencySymbol)}");
            toStringOutput.Add($"this.EffectiveUnitDiscountInCustomerCurrency = {(this.EffectiveUnitDiscountInCustomerCurrency == null ? "null" : this.EffectiveUnitDiscountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.EffectiveDiscountInCustomerCurrency = {(this.EffectiveDiscountInCustomerCurrency == null ? "null" : this.EffectiveDiscountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.VATonNetAmountInCustomerCurrency = {(this.VATonNetAmountInCustomerCurrency == null ? "null" : this.VATonNetAmountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.DiscountType = {(this.DiscountType == null ? "null" : this.DiscountType)}");
            toStringOutput.Add($"this.TransactionStatus = {(this.TransactionStatus == null ? "null" : this.TransactionStatus)}");
            toStringOutput.Add($"this.SalesItemId = {(this.SalesItemId == null ? "null" : this.SalesItemId.ToString())}");
            toStringOutput.Add($"this.PayerGroup = {(this.PayerGroup == null ? "null" : this.PayerGroup)}");
            toStringOutput.Add($"this.PayerGroupName = {(this.PayerGroupName == null ? "null" : this.PayerGroupName)}");
            toStringOutput.Add($"this.RefundFlag = {(this.RefundFlag == null ? "null" : this.RefundFlag)}");
            toStringOutput.Add($"this.OriginalSalesItemId = {(this.OriginalSalesItemId == null ? "null" : this.OriginalSalesItemId)}");
            toStringOutput.Add($"this.DelcoName = {(this.DelcoName == null ? "null" : this.DelcoName)}");
            toStringOutput.Add($"this.DelcoCode = {(this.DelcoCode == null ? "null" : this.DelcoCode)}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerName = {(this.PayerName == null ? "null" : this.PayerName)}");
            toStringOutput.Add($"this.CardExpiryPeriod = {(this.CardExpiryPeriod == null ? "null" : this.CardExpiryPeriod)}");
            toStringOutput.Add($"this.AuthorisationCode = {(this.AuthorisationCode == null ? "null" : this.AuthorisationCode)}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId)}");
            toStringOutput.Add($"this.TransactionLine = {(this.TransactionLine == null ? "null" : this.TransactionLine)}");
            toStringOutput.Add($"this.AllowClearing = {(this.AllowClearing == null ? "null" : this.AllowClearing)}");
            toStringOutput.Add($"this.CRMNumber = {(this.CRMNumber == null ? "null" : this.CRMNumber)}");
            toStringOutput.Add($"this.DisputeStatus = {(this.DisputeStatus == null ? "null" : this.DisputeStatus)}");
            toStringOutput.Add($"this.RebateRate = {(this.RebateRate == null ? "null" : this.RebateRate.ToString())}");
            toStringOutput.Add($"this.DelCoToColCoExchangeRate = {(this.DelCoToColCoExchangeRate == null ? "null" : this.DelCoToColCoExchangeRate.ToString())}");
            toStringOutput.Add($"this.NetEuroAmount = {(this.NetEuroAmount == null ? "null" : this.NetEuroAmount.ToString())}");
            toStringOutput.Add($"this.EuroRebateAmount = {(this.EuroRebateAmount == null ? "null" : this.EuroRebateAmount.ToString())}");
            toStringOutput.Add($"this.EuroVATAmount = {(this.EuroVATAmount == null ? "null" : this.EuroVATAmount.ToString())}");
            toStringOutput.Add($"this.ParentCustomerNumber = {(this.ParentCustomerNumber == null ? "null" : this.ParentCustomerNumber)}");
            toStringOutput.Add($"this.ParentCustomerName = {(this.ParentCustomerName == null ? "null" : this.ParentCustomerName)}");
            toStringOutput.Add($"this.ParentCustomerId = {(this.ParentCustomerId == null ? "null" : this.ParentCustomerId.ToString())}");
            toStringOutput.Add($"this.IncomingSiteNumber = {(this.IncomingSiteNumber == null ? "null" : this.IncomingSiteNumber)}");
            toStringOutput.Add($"this.IncomingSiteDescription = {(this.IncomingSiteDescription == null ? "null" : this.IncomingSiteDescription)}");
            toStringOutput.Add($"this.IncomingCurrencyCode = {(this.IncomingCurrencyCode == null ? "null" : this.IncomingCurrencyCode)}");
            toStringOutput.Add($"this.IncomingProductCode = {(this.IncomingProductCode == null ? "null" : this.IncomingProductCode)}");
            toStringOutput.Add($"this.CreditDebitCode = {(this.CreditDebitCode == null ? "null" : this.CreditDebitCode)}");
            toStringOutput.Add($"this.CorrectionFlag = {(this.CorrectionFlag == null ? "null" : this.CorrectionFlag)}");
            toStringOutput.Add($"this.Additional1 = {(this.Additional1 == null ? "null" : this.Additional1)}");
            toStringOutput.Add($"this.Additional2 = {(this.Additional2 == null ? "null" : this.Additional2)}");
            toStringOutput.Add($"this.Additional3 = {(this.Additional3 == null ? "null" : this.Additional3)}");
            toStringOutput.Add($"this.Additional4 = {(this.Additional4 == null ? "null" : this.Additional4)}");
            toStringOutput.Add($"this.RebateonNetAmountInCustomerCurrency = {(this.RebateonNetAmountInCustomerCurrency == null ? "null" : this.RebateonNetAmountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.RebateonNetAmountInTransactionCurrency = {(this.RebateonNetAmountInTransactionCurrency == null ? "null" : this.RebateonNetAmountInTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.NetworkCode = {(this.NetworkCode == null ? "null" : this.NetworkCode)}");
            toStringOutput.Add($"this.TrnIdentifier = {(this.TrnIdentifier == null ? "null" : this.TrnIdentifier)}");
            toStringOutput.Add($"this.CardType = {(this.CardType == null ? "null" : this.CardType)}");
            toStringOutput.Add($"this.DelcoListPriceUnitNet = {(this.DelcoListPriceUnitNet == null ? "null" : this.DelcoListPriceUnitNet.ToString())}");
            toStringOutput.Add($"this.DelcoRetailPriceUnitNet = {(this.DelcoRetailPriceUnitNet == null ? "null" : this.DelcoRetailPriceUnitNet.ToString())}");
            toStringOutput.Add($"this.DelcoRetailPriceUnitGross = {(this.DelcoRetailPriceUnitGross == null ? "null" : this.DelcoRetailPriceUnitGross.ToString())}");
            toStringOutput.Add($"this.DelcoRetailValueTotalNet = {(this.DelcoRetailValueTotalNet == null ? "null" : this.DelcoRetailValueTotalNet.ToString())}");
            toStringOutput.Add($"this.DelcoRetailValueTotalGross = {(this.DelcoRetailValueTotalGross == null ? "null" : this.DelcoRetailValueTotalGross.ToString())}");
            toStringOutput.Add($"this.CustomerRetailPriceUnitGross = {(this.CustomerRetailPriceUnitGross == null ? "null" : this.CustomerRetailPriceUnitGross.ToString())}");
            toStringOutput.Add($"this.CustomerRetailValueTotalGross = {(this.CustomerRetailValueTotalGross == null ? "null" : this.CustomerRetailValueTotalGross.ToString())}");
            toStringOutput.Add($"this.CustomerRetailValueTotalNet = {(this.CustomerRetailValueTotalNet == null ? "null" : this.CustomerRetailValueTotalNet.ToString())}");
            toStringOutput.Add($"this.TransactionTypeDescription = {(this.TransactionTypeDescription == null ? "null" : this.TransactionTypeDescription)}");
        }
    }
}