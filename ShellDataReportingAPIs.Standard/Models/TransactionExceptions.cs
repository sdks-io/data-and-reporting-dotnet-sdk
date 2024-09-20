// <copyright file="TransactionExceptions.cs" company="APIMatic">
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
    /// TransactionExceptions.
    /// </summary>
    public class TransactionExceptions
    {
        private double? salesItemId;
        private int? cardId;
        private int? productId;
        private string transactionGUID;
        private string transactionDate;
        private double? customerInvoiceValueTotalGross;
        private string cardPAN;
        private string cardExpiry;
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
        private double? transactionNetAmount;
        private double? transactionTax;
        private double? transactionGrossAmount;
        private double? invoiceNetAmount;
        private double? invoiceTax;
        private double? invoiceGrossAmount;
        private string purchasedInCountry;
        private int? accountId;
        private string accountNumber;
        private string accountName;
        private string accountShortName;
        private double? quantity;
        private bool? fuelProduct;
        private double? unitPriceInTransactionCurrency;
        private double? unitPriceInInvoiceCurrency;
        private double? unitDiscountTransactionCurrency;
        private double? unitDiscountInvoiceCurrency;
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
        private double? colCoExchangeRate;
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
        private string effectiveDiscountInTrxCurrency;
        private string transactionType;
        private string pINIndicator;
        private string vATApplicable;
        private string netInvoiceIndicator;
        private string customerCurrencyCode;
        private string customerCurrencySymbol;
        private double? effectiveUnitDiscountInCustomerCurrency;
        private double? effectiveDiscountInCustomerCurrency;
        private double? vATonNetAmountInCustomerCurrency;
        private string discountType;
        private string transactionStatus;
        private string payerGroup;
        private string refundFlag;
        private double? originalSalesItemId;
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
        private double? delCoToColCoExchangeRate;
        private double? netEuroAmount;
        private double? euroRebateAmount;
        private double? euroVATAmount;
        private string parentCustomerNumber;
        private double? vATonNetAmount;
        private string vATCountry;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "SalesItemId", false },
            { "CardId", false },
            { "ProductId", false },
            { "TransactionGUID", false },
            { "TransactionDate", false },
            { "CustomerInvoiceValueTotalGross", false },
            { "CardPAN", false },
            { "CardExpiry", false },
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
            { "PayerGroup", false },
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
            { "VATonNetAmount", false },
            { "VATCountry", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionExceptions"/> class.
        /// </summary>
        public TransactionExceptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionExceptions"/> class.
        /// </summary>
        /// <param name="salesItemId">SalesItemId.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="productId">ProductId.</param>
        /// <param name="transactionGUID">TransactionGUID.</param>
        /// <param name="transactionDate">TransactionDate.</param>
        /// <param name="customerInvoiceValueTotalGross">CustomerInvoiceValueTotalGross.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="cardExpiry">CardExpiry.</param>
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
        /// <param name="payerGroup">PayerGroup.</param>
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
        /// <param name="vATonNetAmount">VATonNetAmount.</param>
        /// <param name="vATCountry">VATCountry.</param>
        public TransactionExceptions(
            double? salesItemId = null,
            int? cardId = null,
            int? productId = null,
            string transactionGUID = null,
            string transactionDate = null,
            double? customerInvoiceValueTotalGross = null,
            string cardPAN = null,
            string cardExpiry = null,
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
            double? transactionNetAmount = null,
            double? transactionTax = null,
            double? transactionGrossAmount = null,
            double? invoiceNetAmount = null,
            double? invoiceTax = null,
            double? invoiceGrossAmount = null,
            string purchasedInCountry = null,
            int? accountId = null,
            string accountNumber = null,
            string accountName = null,
            string accountShortName = null,
            double? quantity = null,
            bool? fuelProduct = null,
            double? unitPriceInTransactionCurrency = null,
            double? unitPriceInInvoiceCurrency = null,
            double? unitDiscountTransactionCurrency = null,
            double? unitDiscountInvoiceCurrency = null,
            bool? isInvoiced = null,
            string invoiceNumber = null,
            string invoiceDate = null,
            string siteCode = null,
            string siteName = null,
            string siteCountry = null,
            Models.Location location = null,
            string cardGroupName = null,
            string receiptNumber = null,
            string productCode = null,
            string productName = null,
            int? productGroupId = null,
            string productGroupName = null,
            double? delCoExchangeRate = null,
            double? colCoExchangeRate = null,
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
            string effectiveDiscountInTrxCurrency = null,
            string transactionType = null,
            string pINIndicator = null,
            string vATApplicable = null,
            string netInvoiceIndicator = null,
            string customerCurrencyCode = null,
            string customerCurrencySymbol = null,
            double? effectiveUnitDiscountInCustomerCurrency = null,
            double? effectiveDiscountInCustomerCurrency = null,
            double? vATonNetAmountInCustomerCurrency = null,
            string discountType = null,
            string transactionStatus = null,
            string payerGroup = null,
            string refundFlag = null,
            double? originalSalesItemId = null,
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
            double? delCoToColCoExchangeRate = null,
            double? netEuroAmount = null,
            double? euroRebateAmount = null,
            double? euroVATAmount = null,
            string parentCustomerNumber = null,
            double? vATonNetAmount = null,
            string vATCountry = null)
        {
            if (salesItemId != null)
            {
                this.SalesItemId = salesItemId;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (productId != null)
            {
                this.ProductId = productId;
            }

            if (transactionGUID != null)
            {
                this.TransactionGUID = transactionGUID;
            }

            if (transactionDate != null)
            {
                this.TransactionDate = transactionDate;
            }

            if (customerInvoiceValueTotalGross != null)
            {
                this.CustomerInvoiceValueTotalGross = customerInvoiceValueTotalGross;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (cardExpiry != null)
            {
                this.CardExpiry = cardExpiry;
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

            if (payerGroup != null)
            {
                this.PayerGroup = payerGroup;
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

            if (vATonNetAmount != null)
            {
                this.VATonNetAmount = vATonNetAmount;
            }

            if (vATCountry != null)
            {
                this.VATCountry = vATCountry;
            }

        }

        /// <summary>
        /// Unique Sales Item Identifier
        /// </summary>
        [JsonProperty("SalesItemId")]
        public double? SalesItemId
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
        /// Unique Card Identifier
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
        /// Product Id
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
        /// Transaction Unique Identifier
        /// </summary>
        [JsonProperty("TransactionGUID")]
        public string TransactionGUID
        {
            get
            {
                return this.transactionGUID;
            }

            set
            {
                this.shouldSerialize["TransactionGUID"] = true;
                this.transactionGUID = value;
            }
        }

        /// <summary>
        /// Local Transaction Date  of where the transaction took place
        /// Format: yyyyMMdd
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
        /// Total Gross Amount for the Invoice Customer
        /// </summary>
        [JsonProperty("CustomerInvoiceValueTotalGross")]
        public double? CustomerInvoiceValueTotalGross
        {
            get
            {
                return this.customerInvoiceValueTotalGross;
            }

            set
            {
                this.shouldSerialize["CustomerInvoiceValueTotalGross"] = true;
                this.customerInvoiceValueTotalGross = value;
            }
        }

        /// <summary>
        /// Card PAN number
        /// Returns masked PAN number when masking is enabled at the Microservices configuration (Mask all digits except the last 6 digits of the PAN)
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
        /// Local Transaction Time of where the transaction took place
        /// Format: HH:mm:ss (24 hours format)
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
        /// UTC Offset extracted from GFN Sales Date time. Note: This may not be accurate for all TPN transactions
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
        /// ISO currency code (Example: GBP)
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
        /// Currency symbol of the Invoice Currency Code (i.e. £, $, etc.,)
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
        /// Currency symbol of the Transaction Currency Code (i.e. £, $, etc.,)
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
        public double? TransactionNetAmount
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
        public double? TransactionTax
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
        public double? TransactionGrossAmount
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
        /// Invoiced Tax Amount
        /// </summary>
        [JsonProperty("InvoiceTax")]
        public double? InvoiceTax
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
        /// Country of Purchase (Ex: France, Germany, etc.,)
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
        public double? Quantity
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
        /// </summary>
        [JsonProperty("UnitPriceInTransactionCurrency")]
        public double? UnitPriceInTransactionCurrency
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
        /// </summary>
        [JsonProperty("UnitPriceInInvoiceCurrency")]
        public double? UnitPriceInInvoiceCurrency
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
        /// </summary>
        [JsonProperty("UnitDiscountTransactionCurrency")]
        public double? UnitDiscountTransactionCurrency
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
        /// </summary>
        [JsonProperty("UnitDiscountInvoiceCurrency")]
        public double? UnitDiscountInvoiceCurrency
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
        public Models.Location Location { get; set; }

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
        /// Receipt Number
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
        public double? ColCoExchangeRate
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
        /// Network as configured
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
        /// Site GroupName
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
        /// 7077 = CRT
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
        /// ISO code of the  Customer Country
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
        /// 3 digits, Card sequence number and Check digit  (Digit 16,17 and 18 on the card pan)
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
        /// 2-A1 PH-O 12% Sales Domestic
        /// 3-VAT exempt
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
        /// Effective Discount (excluding VAT, in transaction currency)  4 digits
        /// </summary>
        [JsonProperty("EffectiveDiscountInTrxCurrency")]
        public string EffectiveDiscountInTrxCurrency
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
        /// “Y” or “N”
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
        /// Effective Unit Discount
        /// </summary>
        [JsonProperty("EffectiveUnitDiscountInCustomerCurrency")]
        public double? EffectiveUnitDiscountInCustomerCurrency
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
        /// Effective Discount
        /// </summary>
        [JsonProperty("EffectiveDiscountInCustomerCurrency")]
        public double? EffectiveDiscountInCustomerCurrency
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
        /// VAT on Net Amount
        /// </summary>
        [JsonProperty("VATonNetAmountInCustomerCurrency")]
        public double? VATonNetAmountInCustomerCurrency
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
        /// 3-Percentage
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
        /// Transaction status  "U" or "I"
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
        /// Refund Flag “N” for Not Refunded and “Y” for Refunded.
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
        public double? OriginalSalesItemId
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
        /// Payer number
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
        /// CRM Case number if the sales item is in dispute
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
        /// 0    No Dispute
        /// 1    In Dispute
        /// 2    Re-Instated
        /// 3    Adjusted
        /// 4    Written Off by Colco
        /// 5    Written Off by Delco
        /// 6    Charged Back to Site
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
        /// Unit discount in customer currency
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
        /// </summary>
        [JsonProperty("DelCoToColCoExchangeRate")]
        public double? DelCoToColCoExchangeRate
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
        /// </summary>
        [JsonProperty("EuroRebateAmount")]
        public double? EuroRebateAmount
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
        /// VAT on Net Amount (in transaction currency) 2 decimals
        /// </summary>
        [JsonProperty("VATonNetAmount")]
        public double? VATonNetAmount
        {
            get
            {
                return this.vATonNetAmount;
            }

            set
            {
                this.shouldSerialize["VATonNetAmount"] = true;
                this.vATonNetAmount = value;
            }
        }

        /// <summary>
        /// VAT Country
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionExceptions : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
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
        public void UnsetTransactionGUID()
        {
            this.shouldSerialize["TransactionGUID"] = false;
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
        public void UnsetCustomerInvoiceValueTotalGross()
        {
            this.shouldSerialize["CustomerInvoiceValueTotalGross"] = false;
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
        public void UnsetPayerGroup()
        {
            this.shouldSerialize["PayerGroup"] = false;
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
        public void UnsetVATonNetAmount()
        {
            this.shouldSerialize["VATonNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountry()
        {
            this.shouldSerialize["VATCountry"] = false;
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
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
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
        public bool ShouldSerializeTransactionGUID()
        {
            return this.shouldSerialize["TransactionGUID"];
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
        public bool ShouldSerializeCustomerInvoiceValueTotalGross()
        {
            return this.shouldSerialize["CustomerInvoiceValueTotalGross"];
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
        public bool ShouldSerializePayerGroup()
        {
            return this.shouldSerialize["PayerGroup"];
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
        public bool ShouldSerializeVATonNetAmount()
        {
            return this.shouldSerialize["VATonNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountry()
        {
            return this.shouldSerialize["VATCountry"];
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
            return obj is TransactionExceptions other &&                ((this.SalesItemId == null && other.SalesItemId == null) || (this.SalesItemId?.Equals(other.SalesItemId) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.TransactionGUID == null && other.TransactionGUID == null) || (this.TransactionGUID?.Equals(other.TransactionGUID) == true)) &&
                ((this.TransactionDate == null && other.TransactionDate == null) || (this.TransactionDate?.Equals(other.TransactionDate) == true)) &&
                ((this.CustomerInvoiceValueTotalGross == null && other.CustomerInvoiceValueTotalGross == null) || (this.CustomerInvoiceValueTotalGross?.Equals(other.CustomerInvoiceValueTotalGross) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.CardExpiry == null && other.CardExpiry == null) || (this.CardExpiry?.Equals(other.CardExpiry) == true)) &&
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
                ((this.PayerGroup == null && other.PayerGroup == null) || (this.PayerGroup?.Equals(other.PayerGroup) == true)) &&
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
                ((this.VATonNetAmount == null && other.VATonNetAmount == null) || (this.VATonNetAmount?.Equals(other.VATonNetAmount) == true)) &&
                ((this.VATCountry == null && other.VATCountry == null) || (this.VATCountry?.Equals(other.VATCountry) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SalesItemId = {(this.SalesItemId == null ? "null" : this.SalesItemId.ToString())}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.TransactionGUID = {(this.TransactionGUID == null ? "null" : this.TransactionGUID)}");
            toStringOutput.Add($"this.TransactionDate = {(this.TransactionDate == null ? "null" : this.TransactionDate)}");
            toStringOutput.Add($"this.CustomerInvoiceValueTotalGross = {(this.CustomerInvoiceValueTotalGross == null ? "null" : this.CustomerInvoiceValueTotalGross.ToString())}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.CardExpiry = {(this.CardExpiry == null ? "null" : this.CardExpiry)}");
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
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location.ToString())}");
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
            toStringOutput.Add($"this.EffectiveDiscountInTrxCurrency = {(this.EffectiveDiscountInTrxCurrency == null ? "null" : this.EffectiveDiscountInTrxCurrency)}");
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
            toStringOutput.Add($"this.PayerGroup = {(this.PayerGroup == null ? "null" : this.PayerGroup)}");
            toStringOutput.Add($"this.RefundFlag = {(this.RefundFlag == null ? "null" : this.RefundFlag)}");
            toStringOutput.Add($"this.OriginalSalesItemId = {(this.OriginalSalesItemId == null ? "null" : this.OriginalSalesItemId.ToString())}");
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
            toStringOutput.Add($"this.VATonNetAmount = {(this.VATonNetAmount == null ? "null" : this.VATonNetAmount.ToString())}");
            toStringOutput.Add($"this.VATCountry = {(this.VATCountry == null ? "null" : this.VATCountry)}");
        }
    }
}