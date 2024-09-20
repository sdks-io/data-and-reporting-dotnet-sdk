// <copyright file="PricedResponseData.cs" company="APIMatic">
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
    /// PricedResponseData.
    /// </summary>
    public class PricedResponseData
    {
        private string accountName;
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private string additional1;
        private string additional2;
        private string additional3;
        private string additional4;
        private string allowClearing;
        private int? authorisationCode;
        private string transactionStatus;
        private string driverName;
        private int? cardExpiryPeriod;
        private string cardExpiry;
        private int? cardGroupId;
        private string cardGroupName;
        private int? issuerCode;
        private string cardPAN;
        private int? releaseCode;
        private int? cardSequenceNumber;
        private string cardType;
        private string colCoCode;
        private double? unitDiscountInvoiceCurrency;
        private string invoiceCurrencySymbol;
        private bool? correctionFlag;
        private double? cRMNumber;
        private string customerCountry;
        private string customerCurrencyCode;
        private string customerCurrencySymbol;
        private double? rebateonNetAmountInCustomerCurrency;
        private double? effectiveDiscountInCustomerCurrency;
        private double? effectiveUnitDiscountInCustomerCurrency;
        private double? unitPriceInInvoiceCurrency;
        private double? invoiceTax;
        private double? invoiceGrossAmount;
        private double? invoiceNetAmount;
        private double? vATonNetAmountInCustomerCurrency;
        private double? customerRetailPriceUnitGross;
        private double? customerRetailValueTotalGross;
        private double? customerRetailValueTotalNet;
        private double? transactionTypeDescription;
        private double? rebateonNetAmountInTransactionCurrency;
        private double? effectiveDiscountInTrxCurrency;
        private int? delCoToColCoExchangeRate;
        private double? unitDiscountTransactionCurrency;
        private double? transactionGrossAmount;
        private double? transactionNetAmount;
        private double? transactionTax;
        private double? vATonNetAmount;
        private double? delcoListPriceUnitNet;
        private double? delcoRetailPriceUnitGross;
        private double? unitPriceInTransactionCurrency;
        private double? delcoRetailPriceUnitNet;
        private double? delcoRetailValueTotalGross;
        private double? delcoRetailValueTotalNet;
        private string transactionCurrencySymbol;
        private string discountType;
        private bool? disputeStatus;
        private string fleetIdInput;
        private int? incomingProductCode;
        private string postingDate;
        private string postingTime;
        private int? productCode;
        private string productName;
        private int? productGroupId;
        private string incomingCurrencyCode;
        private string incomingSiteDescription;
        private string location;
        private string siteName;
        private int? siteCode;
        private int? incomingSiteNumber;
        private string invoiceCurrencyCode;
        private string invoiceDate;
        private double? invoiceNumber;
        private bool? fuelProduct;
        private string vATApplicable;
        private string payerName;
        private string payerNumber;
        private string parentCustomerNumber;
        private string payerGroup;
        private string payerGroupName;
        private int? checkDigit;
        private string netInvoiceIndicator;
        private int? delcoCode;
        private int? networkCode;
        private string purchasedInCountry;
        private string siteCountry;
        private string vATCountry;
        private string delcoName;
        private string network;
        private int? odometerInput;
        private string originalSalesItemId;
        private string fleetIDDescription;
        private int? parentCustomerId;
        private string pINIndicator;
        private string productGroupName;
        private string purchasedInCountryCode;
        private double? quantity;
        private double? rebateRate;
        private int? receiptNumber;
        private int? siteGroupId;
        private string siteGroupName;
        private double? latitude;
        private double? longitude;
        private double? delCoExchangeRate;
        private double? euroRebateAmount;
        private double? netEuroAmount;
        private double? euroVATAmount;
        private string parentCustomerName;
        private bool? isInvoiced;
        private string transactionCurrencyCode;
        private string creditDebitCode;
        private string transactionDate;
        private string transactionTime;
        private string transactionItemId;
        private string trnIdentifier;
        private string type;
        private int? transactionLine;
        private string transactionType;
        private string uTCOffset;
        private string vATCategory;
        private double? vATRate;
        private string vehicleRegistration;
        private string isCancelled;
        private double? colCoGrossAmount;
        private double? colCoNetAmount;
        private double? colCoVATAmount;
        private string originalCurrencySymbol;
        private string originalCurrencyCode;
        private double? originalVATAmount;
        private string embossText;
        private double? originalExchangeRate;
        private string originalTransactionItemInvoiceDate;
        private int? feeTypeId;
        private bool? lineItemDescription;
        private string feeRuleDescription;
        private int? frequency;
        private int? feeRuleId;
        private string systemEntryDate;
        private string systemEntryTime;
        private string isManual;
        private string originalTransactionItemId;
        private int? originalTransactionItemInvoiceNumber;
        private int? originalTransactionItemInvoiceId;
        private string payerShortName;
        private string reverseCharge;
        private double? originalGrossAmount;
        private double? originalNetAmount;
        private string unitOfMeasure;
        private string roadType;
        private string customerCountryIsoCode;
        private string eVOperator;
        private string eVSerialId;
        private string eVChargePointSerial;
        private int? eVChargePointConnectorType;
        private string eVChargePointConnectorTypeDescription;
        private string eVChargeDuration;
        private string eVChargeStartDate;
        private string eVChargeStartTime;
        private string eVChargeEndDate;
        private string eVChargeEndTime;
        private int? hostingCollectingCompanyNumber;
        private double? transactionId;
        private bool? fuelOnly;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountName", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "Additional1", false },
            { "Additional2", false },
            { "Additional3", false },
            { "Additional4", false },
            { "AllowClearing", false },
            { "AuthorisationCode", false },
            { "TransactionStatus", false },
            { "DriverName", false },
            { "CardExpiryPeriod", false },
            { "CardExpiry", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "IssuerCode", false },
            { "CardPAN", false },
            { "ReleaseCode", false },
            { "CardSequenceNumber", false },
            { "CardType", false },
            { "ColCoCode", false },
            { "UnitDiscountInvoiceCurrency", false },
            { "InvoiceCurrencySymbol", false },
            { "CorrectionFlag", false },
            { "CRMNumber", false },
            { "CustomerCountry", false },
            { "CustomerCurrencyCode", false },
            { "CustomerCurrencySymbol", false },
            { "RebateonNetAmountInCustomerCurrency", false },
            { "EffectiveDiscountInCustomerCurrency", false },
            { "EffectiveUnitDiscountInCustomerCurrency", false },
            { "UnitPriceInInvoiceCurrency", false },
            { "InvoiceTax", false },
            { "InvoiceGrossAmount", false },
            { "InvoiceNetAmount", false },
            { "VATonNetAmountInCustomerCurrency", false },
            { "CustomerRetailPriceUnitGross", false },
            { "CustomerRetailValueTotalGross", false },
            { "CustomerRetailValueTotalNet", false },
            { "TransactionTypeDescription", false },
            { "RebateonNetAmountInTransactionCurrency", false },
            { "EffectiveDiscountInTrxCurrency", false },
            { "DelCoToColCoExchangeRate", false },
            { "UnitDiscountTransactionCurrency", false },
            { "TransactionGrossAmount", false },
            { "TransactionNetAmount", false },
            { "TransactionTax", false },
            { "VATonNetAmount", false },
            { "DelcoListPriceUnitNet", false },
            { "DelcoRetailPriceUnitGross", false },
            { "UnitPriceInTransactionCurrency", false },
            { "DelcoRetailPriceUnitNet", false },
            { "DelcoRetailValueTotalGross", false },
            { "DelcoRetailValueTotalNet", false },
            { "TransactionCurrencySymbol", false },
            { "DiscountType", false },
            { "DisputeStatus", true },
            { "FleetIdInput", false },
            { "IncomingProductCode", false },
            { "PostingDate", false },
            { "PostingTime", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "ProductGroupId", false },
            { "IncomingCurrencyCode", false },
            { "IncomingSiteDescription", false },
            { "Location", false },
            { "SiteName", false },
            { "SiteCode", false },
            { "IncomingSiteNumber", false },
            { "InvoiceCurrencyCode", false },
            { "InvoiceDate", false },
            { "InvoiceNumber", false },
            { "FuelProduct", false },
            { "VATApplicable", false },
            { "PayerName", false },
            { "PayerNumber", false },
            { "ParentCustomerNumber", false },
            { "PayerGroup", false },
            { "PayerGroupName", false },
            { "CheckDigit", false },
            { "NetInvoiceIndicator", false },
            { "DelcoCode", false },
            { "NetworkCode", false },
            { "PurchasedInCountry", false },
            { "SiteCountry", false },
            { "VATCountry", false },
            { "DelcoName", false },
            { "Network", false },
            { "OdometerInput", false },
            { "OriginalSalesItemId", false },
            { "FleetIDDescription", false },
            { "ParentCustomerId", false },
            { "PINIndicator", false },
            { "ProductGroupName", false },
            { "PurchasedInCountryCode", false },
            { "Quantity", false },
            { "RebateRate", false },
            { "ReceiptNumber", false },
            { "SiteGroupId", false },
            { "SiteGroupName", false },
            { "Latitude", false },
            { "Longitude", false },
            { "DelCoExchangeRate", false },
            { "EuroRebateAmount", false },
            { "NetEuroAmount", false },
            { "EuroVATAmount", false },
            { "ParentCustomerName", false },
            { "IsInvoiced", true },
            { "TransactionCurrencyCode", false },
            { "CreditDebitCode", false },
            { "TransactionDate", false },
            { "TransactionTime", false },
            { "TransactionItemId", false },
            { "TrnIdentifier", false },
            { "Type", false },
            { "TransactionLine", false },
            { "TransactionType", false },
            { "UTCOffset", false },
            { "VATCategory", false },
            { "VATRate", false },
            { "VehicleRegistration", false },
            { "IsCancelled", false },
            { "ColCoGrossAmount", false },
            { "ColCoNetAmount", false },
            { "ColCoVATAmount", false },
            { "OriginalCurrencySymbol", false },
            { "OriginalCurrencyCode", false },
            { "OriginalVATAmount", false },
            { "EmbossText", false },
            { "OriginalExchangeRate", false },
            { "OriginalTransactionItemInvoiceDate", false },
            { "FeeTypeId", false },
            { "LineItemDescription", true },
            { "FeeRuleDescription", false },
            { "Frequency", false },
            { "FeeRuleId", false },
            { "SystemEntryDate", false },
            { "SystemEntryTime", false },
            { "IsManual", false },
            { "OriginalTransactionItemId", false },
            { "OriginalTransactionItemInvoiceNumber", false },
            { "OriginalTransactionItemInvoiceId", false },
            { "PayerShortName", false },
            { "ReverseCharge", false },
            { "OriginalGrossAmount", false },
            { "OriginalNetAmount", false },
            { "UnitOfMeasure", false },
            { "RoadType", false },
            { "CustomerCountryIsoCode", false },
            { "EVOperator", false },
            { "EVSerialId", false },
            { "EVChargePointSerial", false },
            { "EVChargePointConnectorType", false },
            { "EVChargePointConnectorTypeDescription", false },
            { "EVChargeDuration", false },
            { "EVChargeStartDate", false },
            { "EVChargeStartTime", false },
            { "EVChargeEndDate", false },
            { "EVChargeEndTime", false },
            { "HostingCollectingCompanyNumber", false },
            { "TransactionId", false },
            { "FuelOnly", false },
        };

        private Dictionary<string, bool> hasPropertySetterCalledFor = new Dictionary<string, bool>
        {
            { "DisputeStatus", false },
            { "IsInvoiced", false },
            { "LineItemDescription", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedResponseData"/> class.
        /// </summary>
        public PricedResponseData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedResponseData"/> class.
        /// </summary>
        /// <param name="accountName">AccountName.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="additional1">Additional1.</param>
        /// <param name="additional2">Additional2.</param>
        /// <param name="additional3">Additional3.</param>
        /// <param name="additional4">Additional4.</param>
        /// <param name="allowClearing">AllowClearing.</param>
        /// <param name="authorisationCode">AuthorisationCode.</param>
        /// <param name="transactionStatus">TransactionStatus.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="cardExpiryPeriod">CardExpiryPeriod.</param>
        /// <param name="cardExpiry">CardExpiry.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="issuerCode">IssuerCode.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="releaseCode">ReleaseCode.</param>
        /// <param name="cardSequenceNumber">CardSequenceNumber.</param>
        /// <param name="cardType">CardType.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="unitDiscountInvoiceCurrency">UnitDiscountInvoiceCurrency.</param>
        /// <param name="colCoExchangeRate">ColCoExchangeRate.</param>
        /// <param name="invoiceCurrencySymbol">InvoiceCurrencySymbol.</param>
        /// <param name="correctionFlag">CorrectionFlag.</param>
        /// <param name="cRMNumber">CRMNumber.</param>
        /// <param name="customerCountry">CustomerCountry.</param>
        /// <param name="customerCurrencyCode">CustomerCurrencyCode.</param>
        /// <param name="customerCurrencySymbol">CustomerCurrencySymbol.</param>
        /// <param name="rebateonNetAmountInCustomerCurrency">RebateonNetAmountInCustomerCurrency.</param>
        /// <param name="effectiveDiscountInCustomerCurrency">EffectiveDiscountInCustomerCurrency.</param>
        /// <param name="effectiveUnitDiscountInCustomerCurrency">EffectiveUnitDiscountInCustomerCurrency.</param>
        /// <param name="unitPriceInInvoiceCurrency">UnitPriceInInvoiceCurrency.</param>
        /// <param name="invoiceTax">InvoiceTax.</param>
        /// <param name="invoiceGrossAmount">InvoiceGrossAmount.</param>
        /// <param name="invoiceNetAmount">InvoiceNetAmount.</param>
        /// <param name="vATonNetAmountInCustomerCurrency">VATonNetAmountInCustomerCurrency.</param>
        /// <param name="customerRetailPriceUnitGross">CustomerRetailPriceUnitGross.</param>
        /// <param name="customerRetailValueTotalGross">CustomerRetailValueTotalGross.</param>
        /// <param name="customerRetailValueTotalNet">CustomerRetailValueTotalNet.</param>
        /// <param name="transactionTypeDescription">TransactionTypeDescription.</param>
        /// <param name="rebateonNetAmountInTransactionCurrency">RebateonNetAmountInTransactionCurrency.</param>
        /// <param name="effectiveDiscountInTrxCurrency">EffectiveDiscountInTrxCurrency.</param>
        /// <param name="delCoToColCoExchangeRate">DelCoToColCoExchangeRate.</param>
        /// <param name="cards">Cards.</param>
        /// <param name="unitDiscountTransactionCurrency">UnitDiscountTransactionCurrency.</param>
        /// <param name="transactionGrossAmount">TransactionGrossAmount.</param>
        /// <param name="transactionNetAmount">TransactionNetAmount.</param>
        /// <param name="transactionTax">TransactionTax.</param>
        /// <param name="vATonNetAmount">VATonNetAmount.</param>
        /// <param name="delcoListPriceUnitNet">DelcoListPriceUnitNet.</param>
        /// <param name="delcoRetailPriceUnitGross">DelcoRetailPriceUnitGross.</param>
        /// <param name="unitPriceInTransactionCurrency">UnitPriceInTransactionCurrency.</param>
        /// <param name="delcoRetailPriceUnitNet">DelcoRetailPriceUnitNet.</param>
        /// <param name="delcoRetailValueTotalGross">DelcoRetailValueTotalGross.</param>
        /// <param name="delcoRetailValueTotalNet">DelcoRetailValueTotalNet.</param>
        /// <param name="transactionCurrencySymbol">TransactionCurrencySymbol.</param>
        /// <param name="discountType">DiscountType.</param>
        /// <param name="disputeStatus">DisputeStatus.</param>
        /// <param name="isShellSite">IsShellSite.</param>
        /// <param name="fleetIdInput">FleetIdInput.</param>
        /// <param name="incomingProductCode">IncomingProductCode.</param>
        /// <param name="postingDate">PostingDate.</param>
        /// <param name="postingTime">PostingTime.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="productGroupId">ProductGroupId.</param>
        /// <param name="incomingCurrencyCode">IncomingCurrencyCode.</param>
        /// <param name="incomingSiteDescription">IncomingSiteDescription.</param>
        /// <param name="location">Location.</param>
        /// <param name="siteName">SiteName.</param>
        /// <param name="siteCode">SiteCode.</param>
        /// <param name="incomingSiteNumber">IncomingSiteNumber.</param>
        /// <param name="invoiceCurrencyCode">InvoiceCurrencyCode.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="fuelProduct">FuelProduct.</param>
        /// <param name="vATApplicable">VATApplicable.</param>
        /// <param name="payerName">PayerName.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="parentCustomerNumber">ParentCustomerNumber.</param>
        /// <param name="payerGroup">PayerGroup.</param>
        /// <param name="payerGroupName">PayerGroupName.</param>
        /// <param name="checkDigit">CheckDigit.</param>
        /// <param name="netInvoiceIndicator">NetInvoiceIndicator.</param>
        /// <param name="delcoCode">DelcoCode.</param>
        /// <param name="networkCode">NetworkCode.</param>
        /// <param name="purchasedInCountry">PurchasedInCountry.</param>
        /// <param name="siteCountry">SiteCountry.</param>
        /// <param name="vATCountry">VATCountry.</param>
        /// <param name="delcoName">DelcoName.</param>
        /// <param name="network">Network.</param>
        /// <param name="odometerInput">OdometerInput.</param>
        /// <param name="originalSalesItemId">OriginalSalesItemId.</param>
        /// <param name="fleetIDDescription">FleetIDDescription.</param>
        /// <param name="parentCustomerId">ParentCustomerId.</param>
        /// <param name="pINIndicator">PINIndicator.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="purchasedInCountryCode">PurchasedInCountryCode.</param>
        /// <param name="quantity">Quantity.</param>
        /// <param name="rebateRate">RebateRate.</param>
        /// <param name="receiptNumber">ReceiptNumber.</param>
        /// <param name="refundFlag">RefundFlag.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="siteGroupName">SiteGroupName.</param>
        /// <param name="latitude">Latitude.</param>
        /// <param name="longitude">Longitude.</param>
        /// <param name="delCoExchangeRate">DelCoExchangeRate.</param>
        /// <param name="euroRebateAmount">EuroRebateAmount.</param>
        /// <param name="netEuroAmount">NetEuroAmount.</param>
        /// <param name="euroVATAmount">EuroVATAmount.</param>
        /// <param name="parentCustomerName">ParentCustomerName.</param>
        /// <param name="isInvoiced">IsInvoiced.</param>
        /// <param name="transactionCurrencyCode">TransactionCurrencyCode.</param>
        /// <param name="creditDebitCode">CreditDebitCode.</param>
        /// <param name="transactionDate">TransactionDate.</param>
        /// <param name="transactionTime">TransactionTime.</param>
        /// <param name="transactionItemId">TransactionItemId.</param>
        /// <param name="trnIdentifier">TrnIdentifier.</param>
        /// <param name="type">Type.</param>
        /// <param name="transactionLine">TransactionLine.</param>
        /// <param name="transactionType">TransactionType.</param>
        /// <param name="uTCOffset">UTCOffset.</param>
        /// <param name="vATCategory">VATCategory.</param>
        /// <param name="vATRate">VATRate.</param>
        /// <param name="vehicleRegistration">VehicleRegistration.</param>
        /// <param name="isCancelled">IsCancelled.</param>
        /// <param name="colCoGrossAmount">ColCoGrossAmount.</param>
        /// <param name="colCoNetAmount">ColCoNetAmount.</param>
        /// <param name="colCoVATAmount">ColCoVATAmount.</param>
        /// <param name="originalCurrencySymbol">OriginalCurrencySymbol.</param>
        /// <param name="originalCurrencyCode">OriginalCurrencyCode.</param>
        /// <param name="originalVATAmount">OriginalVATAmount.</param>
        /// <param name="embossText">EmbossText.</param>
        /// <param name="originalExchangeRate">OriginalExchangeRate.</param>
        /// <param name="originalTransactionItemInvoiceDate">OriginalTransactionItemInvoiceDate.</param>
        /// <param name="feeTypeId">FeeTypeId.</param>
        /// <param name="lineItemDescription">LineItemDescription.</param>
        /// <param name="feeRuleDescription">FeeRuleDescription.</param>
        /// <param name="frequency">Frequency.</param>
        /// <param name="feeRuleId">FeeRuleId.</param>
        /// <param name="systemEntryDate">SystemEntryDate.</param>
        /// <param name="systemEntryTime">SystemEntryTime.</param>
        /// <param name="isManual">IsManual.</param>
        /// <param name="originalTransactionItemId">OriginalTransactionItemId.</param>
        /// <param name="originalTransactionItemInvoiceNumber">OriginalTransactionItemInvoiceNumber.</param>
        /// <param name="originalTransactionItemInvoiceId">OriginalTransactionItemInvoiceId.</param>
        /// <param name="payerShortName">PayerShortName.</param>
        /// <param name="reverseCharge">ReverseCharge.</param>
        /// <param name="originalGrossAmount">OriginalGrossAmount.</param>
        /// <param name="originalNetAmount">OriginalNetAmount.</param>
        /// <param name="unitOfMeasure">UnitOfMeasure.</param>
        /// <param name="roadType">RoadType.</param>
        /// <param name="customerCountryIsoCode">CustomerCountryIsoCode.</param>
        /// <param name="eVOperator">EVOperator.</param>
        /// <param name="eVSerialId">EVSerialId.</param>
        /// <param name="eVChargePointSerial">EVChargePointSerial.</param>
        /// <param name="eVChargePointConnectorType">EVChargePointConnectorType.</param>
        /// <param name="eVChargePointConnectorTypeDescription">EVChargePointConnectorTypeDescription.</param>
        /// <param name="eVChargeDuration">EVChargeDuration.</param>
        /// <param name="eVChargeStartDate">EVChargeStartDate.</param>
        /// <param name="eVChargeStartTime">EVChargeStartTime.</param>
        /// <param name="eVChargeEndDate">EVChargeEndDate.</param>
        /// <param name="eVChargeEndTime">EVChargeEndTime.</param>
        /// <param name="hostingCollectingCompanyNumber">HostingCollectingCompanyNumber.</param>
        /// <param name="transactionId">TransactionId.</param>
        /// <param name="fuelOnly">FuelOnly.</param>
        public PricedResponseData(
            string accountName = null,
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            string additional1 = null,
            string additional2 = null,
            string additional3 = null,
            string additional4 = null,
            string allowClearing = null,
            int? authorisationCode = null,
            string transactionStatus = null,
            string driverName = null,
            int? cardExpiryPeriod = null,
            string cardExpiry = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            int? issuerCode = null,
            string cardPAN = null,
            int? releaseCode = null,
            int? cardSequenceNumber = null,
            string cardType = null,
            string colCoCode = null,
            double? unitDiscountInvoiceCurrency = null,
            double? colCoExchangeRate = null,
            string invoiceCurrencySymbol = null,
            bool? correctionFlag = null,
            double? cRMNumber = null,
            string customerCountry = null,
            string customerCurrencyCode = null,
            string customerCurrencySymbol = null,
            double? rebateonNetAmountInCustomerCurrency = null,
            double? effectiveDiscountInCustomerCurrency = null,
            double? effectiveUnitDiscountInCustomerCurrency = null,
            double? unitPriceInInvoiceCurrency = null,
            double? invoiceTax = null,
            double? invoiceGrossAmount = null,
            double? invoiceNetAmount = null,
            double? vATonNetAmountInCustomerCurrency = null,
            double? customerRetailPriceUnitGross = null,
            double? customerRetailValueTotalGross = null,
            double? customerRetailValueTotalNet = null,
            double? transactionTypeDescription = null,
            double? rebateonNetAmountInTransactionCurrency = null,
            double? effectiveDiscountInTrxCurrency = null,
            int? delCoToColCoExchangeRate = null,
            List<int> cards = null,
            double? unitDiscountTransactionCurrency = null,
            double? transactionGrossAmount = null,
            double? transactionNetAmount = null,
            double? transactionTax = null,
            double? vATonNetAmount = null,
            double? delcoListPriceUnitNet = null,
            double? delcoRetailPriceUnitGross = null,
            double? unitPriceInTransactionCurrency = null,
            double? delcoRetailPriceUnitNet = null,
            double? delcoRetailValueTotalGross = null,
            double? delcoRetailValueTotalNet = null,
            string transactionCurrencySymbol = null,
            string discountType = null,
            bool? disputeStatus = false,
            bool? isShellSite = false,
            string fleetIdInput = null,
            int? incomingProductCode = null,
            string postingDate = null,
            string postingTime = null,
            int? productCode = null,
            string productName = null,
            int? productGroupId = null,
            string incomingCurrencyCode = null,
            string incomingSiteDescription = null,
            string location = null,
            string siteName = null,
            int? siteCode = null,
            int? incomingSiteNumber = null,
            string invoiceCurrencyCode = null,
            string invoiceDate = null,
            double? invoiceNumber = null,
            bool? fuelProduct = null,
            string vATApplicable = null,
            string payerName = null,
            string payerNumber = null,
            string parentCustomerNumber = null,
            string payerGroup = null,
            string payerGroupName = null,
            int? checkDigit = null,
            string netInvoiceIndicator = null,
            int? delcoCode = null,
            int? networkCode = null,
            string purchasedInCountry = null,
            string siteCountry = null,
            string vATCountry = null,
            string delcoName = null,
            string network = null,
            int? odometerInput = null,
            string originalSalesItemId = null,
            string fleetIDDescription = null,
            int? parentCustomerId = null,
            string pINIndicator = null,
            string productGroupName = null,
            string purchasedInCountryCode = null,
            double? quantity = null,
            double? rebateRate = null,
            int? receiptNumber = null,
            Models.PricedTransactionRespV2RefundFlagEnum? refundFlag = null,
            int? siteGroupId = null,
            string siteGroupName = null,
            double? latitude = null,
            double? longitude = null,
            double? delCoExchangeRate = null,
            double? euroRebateAmount = null,
            double? netEuroAmount = null,
            double? euroVATAmount = null,
            string parentCustomerName = null,
            bool? isInvoiced = false,
            string transactionCurrencyCode = null,
            string creditDebitCode = null,
            string transactionDate = null,
            string transactionTime = null,
            string transactionItemId = null,
            string trnIdentifier = null,
            string type = null,
            int? transactionLine = null,
            string transactionType = null,
            string uTCOffset = null,
            string vATCategory = null,
            double? vATRate = null,
            string vehicleRegistration = null,
            string isCancelled = null,
            double? colCoGrossAmount = null,
            double? colCoNetAmount = null,
            double? colCoVATAmount = null,
            string originalCurrencySymbol = null,
            string originalCurrencyCode = null,
            double? originalVATAmount = null,
            string embossText = null,
            double? originalExchangeRate = null,
            string originalTransactionItemInvoiceDate = null,
            int? feeTypeId = null,
            bool? lineItemDescription = false,
            string feeRuleDescription = null,
            int? frequency = null,
            int? feeRuleId = null,
            string systemEntryDate = null,
            string systemEntryTime = null,
            string isManual = null,
            string originalTransactionItemId = null,
            int? originalTransactionItemInvoiceNumber = null,
            int? originalTransactionItemInvoiceId = null,
            string payerShortName = null,
            string reverseCharge = null,
            double? originalGrossAmount = null,
            double? originalNetAmount = null,
            string unitOfMeasure = null,
            string roadType = null,
            string customerCountryIsoCode = null,
            string eVOperator = null,
            string eVSerialId = null,
            string eVChargePointSerial = null,
            int? eVChargePointConnectorType = null,
            string eVChargePointConnectorTypeDescription = null,
            string eVChargeDuration = null,
            string eVChargeStartDate = null,
            string eVChargeStartTime = null,
            string eVChargeEndDate = null,
            string eVChargeEndTime = null,
            int? hostingCollectingCompanyNumber = null,
            double? transactionId = null,
            bool? fuelOnly = null)
        {
            if (accountName != null)
            {
                this.AccountName = accountName;
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

            if (allowClearing != null)
            {
                this.AllowClearing = allowClearing;
            }

            if (authorisationCode != null)
            {
                this.AuthorisationCode = authorisationCode;
            }

            if (transactionStatus != null)
            {
                this.TransactionStatus = transactionStatus;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (cardExpiryPeriod != null)
            {
                this.CardExpiryPeriod = cardExpiryPeriod;
            }

            if (cardExpiry != null)
            {
                this.CardExpiry = cardExpiry;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            if (issuerCode != null)
            {
                this.IssuerCode = issuerCode;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (releaseCode != null)
            {
                this.ReleaseCode = releaseCode;
            }

            if (cardSequenceNumber != null)
            {
                this.CardSequenceNumber = cardSequenceNumber;
            }

            if (cardType != null)
            {
                this.CardType = cardType;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (unitDiscountInvoiceCurrency != null)
            {
                this.UnitDiscountInvoiceCurrency = unitDiscountInvoiceCurrency;
            }

            this.ColCoExchangeRate = colCoExchangeRate;
            if (invoiceCurrencySymbol != null)
            {
                this.InvoiceCurrencySymbol = invoiceCurrencySymbol;
            }

            if (correctionFlag != null)
            {
                this.CorrectionFlag = correctionFlag;
            }

            if (cRMNumber != null)
            {
                this.CRMNumber = cRMNumber;
            }

            if (customerCountry != null)
            {
                this.CustomerCountry = customerCountry;
            }

            if (customerCurrencyCode != null)
            {
                this.CustomerCurrencyCode = customerCurrencyCode;
            }

            if (customerCurrencySymbol != null)
            {
                this.CustomerCurrencySymbol = customerCurrencySymbol;
            }

            if (rebateonNetAmountInCustomerCurrency != null)
            {
                this.RebateonNetAmountInCustomerCurrency = rebateonNetAmountInCustomerCurrency;
            }

            if (effectiveDiscountInCustomerCurrency != null)
            {
                this.EffectiveDiscountInCustomerCurrency = effectiveDiscountInCustomerCurrency;
            }

            if (effectiveUnitDiscountInCustomerCurrency != null)
            {
                this.EffectiveUnitDiscountInCustomerCurrency = effectiveUnitDiscountInCustomerCurrency;
            }

            if (unitPriceInInvoiceCurrency != null)
            {
                this.UnitPriceInInvoiceCurrency = unitPriceInInvoiceCurrency;
            }

            if (invoiceTax != null)
            {
                this.InvoiceTax = invoiceTax;
            }

            if (invoiceGrossAmount != null)
            {
                this.InvoiceGrossAmount = invoiceGrossAmount;
            }

            if (invoiceNetAmount != null)
            {
                this.InvoiceNetAmount = invoiceNetAmount;
            }

            if (vATonNetAmountInCustomerCurrency != null)
            {
                this.VATonNetAmountInCustomerCurrency = vATonNetAmountInCustomerCurrency;
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

            if (rebateonNetAmountInTransactionCurrency != null)
            {
                this.RebateonNetAmountInTransactionCurrency = rebateonNetAmountInTransactionCurrency;
            }

            if (effectiveDiscountInTrxCurrency != null)
            {
                this.EffectiveDiscountInTrxCurrency = effectiveDiscountInTrxCurrency;
            }

            if (delCoToColCoExchangeRate != null)
            {
                this.DelCoToColCoExchangeRate = delCoToColCoExchangeRate;
            }

            this.Cards = cards;
            if (unitDiscountTransactionCurrency != null)
            {
                this.UnitDiscountTransactionCurrency = unitDiscountTransactionCurrency;
            }

            if (transactionGrossAmount != null)
            {
                this.TransactionGrossAmount = transactionGrossAmount;
            }

            if (transactionNetAmount != null)
            {
                this.TransactionNetAmount = transactionNetAmount;
            }

            if (transactionTax != null)
            {
                this.TransactionTax = transactionTax;
            }

            if (vATonNetAmount != null)
            {
                this.VATonNetAmount = vATonNetAmount;
            }

            if (delcoListPriceUnitNet != null)
            {
                this.DelcoListPriceUnitNet = delcoListPriceUnitNet;
            }

            if (delcoRetailPriceUnitGross != null)
            {
                this.DelcoRetailPriceUnitGross = delcoRetailPriceUnitGross;
            }

            if (unitPriceInTransactionCurrency != null)
            {
                this.UnitPriceInTransactionCurrency = unitPriceInTransactionCurrency;
            }

            if (delcoRetailPriceUnitNet != null)
            {
                this.DelcoRetailPriceUnitNet = delcoRetailPriceUnitNet;
            }

            if (delcoRetailValueTotalGross != null)
            {
                this.DelcoRetailValueTotalGross = delcoRetailValueTotalGross;
            }

            if (delcoRetailValueTotalNet != null)
            {
                this.DelcoRetailValueTotalNet = delcoRetailValueTotalNet;
            }

            if (transactionCurrencySymbol != null)
            {
                this.TransactionCurrencySymbol = transactionCurrencySymbol;
            }

            if (discountType != null)
            {
                this.DiscountType = discountType;
            }

            this.DisputeStatus = disputeStatus;
            this.IsShellSite = isShellSite;
            if (fleetIdInput != null)
            {
                this.FleetIdInput = fleetIdInput;
            }

            if (incomingProductCode != null)
            {
                this.IncomingProductCode = incomingProductCode;
            }

            if (postingDate != null)
            {
                this.PostingDate = postingDate;
            }

            if (postingTime != null)
            {
                this.PostingTime = postingTime;
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

            if (incomingCurrencyCode != null)
            {
                this.IncomingCurrencyCode = incomingCurrencyCode;
            }

            if (incomingSiteDescription != null)
            {
                this.IncomingSiteDescription = incomingSiteDescription;
            }

            if (location != null)
            {
                this.Location = location;
            }

            if (siteName != null)
            {
                this.SiteName = siteName;
            }

            if (siteCode != null)
            {
                this.SiteCode = siteCode;
            }

            if (incomingSiteNumber != null)
            {
                this.IncomingSiteNumber = incomingSiteNumber;
            }

            if (invoiceCurrencyCode != null)
            {
                this.InvoiceCurrencyCode = invoiceCurrencyCode;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (fuelProduct != null)
            {
                this.FuelProduct = fuelProduct;
            }

            if (vATApplicable != null)
            {
                this.VATApplicable = vATApplicable;
            }

            if (payerName != null)
            {
                this.PayerName = payerName;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (parentCustomerNumber != null)
            {
                this.ParentCustomerNumber = parentCustomerNumber;
            }

            if (payerGroup != null)
            {
                this.PayerGroup = payerGroup;
            }

            if (payerGroupName != null)
            {
                this.PayerGroupName = payerGroupName;
            }

            if (checkDigit != null)
            {
                this.CheckDigit = checkDigit;
            }

            if (netInvoiceIndicator != null)
            {
                this.NetInvoiceIndicator = netInvoiceIndicator;
            }

            if (delcoCode != null)
            {
                this.DelcoCode = delcoCode;
            }

            if (networkCode != null)
            {
                this.NetworkCode = networkCode;
            }

            if (purchasedInCountry != null)
            {
                this.PurchasedInCountry = purchasedInCountry;
            }

            if (siteCountry != null)
            {
                this.SiteCountry = siteCountry;
            }

            if (vATCountry != null)
            {
                this.VATCountry = vATCountry;
            }

            if (delcoName != null)
            {
                this.DelcoName = delcoName;
            }

            if (network != null)
            {
                this.Network = network;
            }

            if (odometerInput != null)
            {
                this.OdometerInput = odometerInput;
            }

            if (originalSalesItemId != null)
            {
                this.OriginalSalesItemId = originalSalesItemId;
            }

            if (fleetIDDescription != null)
            {
                this.FleetIDDescription = fleetIDDescription;
            }

            if (parentCustomerId != null)
            {
                this.ParentCustomerId = parentCustomerId;
            }

            if (pINIndicator != null)
            {
                this.PINIndicator = pINIndicator;
            }

            if (productGroupName != null)
            {
                this.ProductGroupName = productGroupName;
            }

            if (purchasedInCountryCode != null)
            {
                this.PurchasedInCountryCode = purchasedInCountryCode;
            }

            if (quantity != null)
            {
                this.Quantity = quantity;
            }

            if (rebateRate != null)
            {
                this.RebateRate = rebateRate;
            }

            if (receiptNumber != null)
            {
                this.ReceiptNumber = receiptNumber;
            }

            this.RefundFlag = refundFlag;
            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (siteGroupName != null)
            {
                this.SiteGroupName = siteGroupName;
            }

            if (latitude != null)
            {
                this.Latitude = latitude;
            }

            if (longitude != null)
            {
                this.Longitude = longitude;
            }

            if (delCoExchangeRate != null)
            {
                this.DelCoExchangeRate = delCoExchangeRate;
            }

            if (euroRebateAmount != null)
            {
                this.EuroRebateAmount = euroRebateAmount;
            }

            if (netEuroAmount != null)
            {
                this.NetEuroAmount = netEuroAmount;
            }

            if (euroVATAmount != null)
            {
                this.EuroVATAmount = euroVATAmount;
            }

            if (parentCustomerName != null)
            {
                this.ParentCustomerName = parentCustomerName;
            }

            this.IsInvoiced = isInvoiced;
            if (transactionCurrencyCode != null)
            {
                this.TransactionCurrencyCode = transactionCurrencyCode;
            }

            if (creditDebitCode != null)
            {
                this.CreditDebitCode = creditDebitCode;
            }

            if (transactionDate != null)
            {
                this.TransactionDate = transactionDate;
            }

            if (transactionTime != null)
            {
                this.TransactionTime = transactionTime;
            }

            if (transactionItemId != null)
            {
                this.TransactionItemId = transactionItemId;
            }

            if (trnIdentifier != null)
            {
                this.TrnIdentifier = trnIdentifier;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (transactionLine != null)
            {
                this.TransactionLine = transactionLine;
            }

            if (transactionType != null)
            {
                this.TransactionType = transactionType;
            }

            if (uTCOffset != null)
            {
                this.UTCOffset = uTCOffset;
            }

            if (vATCategory != null)
            {
                this.VATCategory = vATCategory;
            }

            if (vATRate != null)
            {
                this.VATRate = vATRate;
            }

            if (vehicleRegistration != null)
            {
                this.VehicleRegistration = vehicleRegistration;
            }

            if (isCancelled != null)
            {
                this.IsCancelled = isCancelled;
            }

            if (colCoGrossAmount != null)
            {
                this.ColCoGrossAmount = colCoGrossAmount;
            }

            if (colCoNetAmount != null)
            {
                this.ColCoNetAmount = colCoNetAmount;
            }

            if (colCoVATAmount != null)
            {
                this.ColCoVATAmount = colCoVATAmount;
            }

            if (originalCurrencySymbol != null)
            {
                this.OriginalCurrencySymbol = originalCurrencySymbol;
            }

            if (originalCurrencyCode != null)
            {
                this.OriginalCurrencyCode = originalCurrencyCode;
            }

            if (originalVATAmount != null)
            {
                this.OriginalVATAmount = originalVATAmount;
            }

            if (embossText != null)
            {
                this.EmbossText = embossText;
            }

            if (originalExchangeRate != null)
            {
                this.OriginalExchangeRate = originalExchangeRate;
            }

            if (originalTransactionItemInvoiceDate != null)
            {
                this.OriginalTransactionItemInvoiceDate = originalTransactionItemInvoiceDate;
            }

            if (feeTypeId != null)
            {
                this.FeeTypeId = feeTypeId;
            }

            this.LineItemDescription = lineItemDescription;
            if (feeRuleDescription != null)
            {
                this.FeeRuleDescription = feeRuleDescription;
            }

            if (frequency != null)
            {
                this.Frequency = frequency;
            }

            if (feeRuleId != null)
            {
                this.FeeRuleId = feeRuleId;
            }

            if (systemEntryDate != null)
            {
                this.SystemEntryDate = systemEntryDate;
            }

            if (systemEntryTime != null)
            {
                this.SystemEntryTime = systemEntryTime;
            }

            if (isManual != null)
            {
                this.IsManual = isManual;
            }

            if (originalTransactionItemId != null)
            {
                this.OriginalTransactionItemId = originalTransactionItemId;
            }

            if (originalTransactionItemInvoiceNumber != null)
            {
                this.OriginalTransactionItemInvoiceNumber = originalTransactionItemInvoiceNumber;
            }

            if (originalTransactionItemInvoiceId != null)
            {
                this.OriginalTransactionItemInvoiceId = originalTransactionItemInvoiceId;
            }

            if (payerShortName != null)
            {
                this.PayerShortName = payerShortName;
            }

            if (reverseCharge != null)
            {
                this.ReverseCharge = reverseCharge;
            }

            if (originalGrossAmount != null)
            {
                this.OriginalGrossAmount = originalGrossAmount;
            }

            if (originalNetAmount != null)
            {
                this.OriginalNetAmount = originalNetAmount;
            }

            if (unitOfMeasure != null)
            {
                this.UnitOfMeasure = unitOfMeasure;
            }

            if (roadType != null)
            {
                this.RoadType = roadType;
            }

            if (customerCountryIsoCode != null)
            {
                this.CustomerCountryIsoCode = customerCountryIsoCode;
            }

            if (eVOperator != null)
            {
                this.EVOperator = eVOperator;
            }

            if (eVSerialId != null)
            {
                this.EVSerialId = eVSerialId;
            }

            if (eVChargePointSerial != null)
            {
                this.EVChargePointSerial = eVChargePointSerial;
            }

            if (eVChargePointConnectorType != null)
            {
                this.EVChargePointConnectorType = eVChargePointConnectorType;
            }

            if (eVChargePointConnectorTypeDescription != null)
            {
                this.EVChargePointConnectorTypeDescription = eVChargePointConnectorTypeDescription;
            }

            if (eVChargeDuration != null)
            {
                this.EVChargeDuration = eVChargeDuration;
            }

            if (eVChargeStartDate != null)
            {
                this.EVChargeStartDate = eVChargeStartDate;
            }

            if (eVChargeStartTime != null)
            {
                this.EVChargeStartTime = eVChargeStartTime;
            }

            if (eVChargeEndDate != null)
            {
                this.EVChargeEndDate = eVChargeEndDate;
            }

            if (eVChargeEndTime != null)
            {
                this.EVChargeEndTime = eVChargeEndTime;
            }

            if (hostingCollectingCompanyNumber != null)
            {
                this.HostingCollectingCompanyNumber = hostingCollectingCompanyNumber;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

            if (fuelOnly != null)
            {
                this.FuelOnly = fuelOnly;
            }

        }

        /// <summary>
        /// Name of the account
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
        /// Account Id (i.e. Customer Id of the Sub Account in GFN) of the selected account.
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
        /// AccountNumber of the selected account.
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
        /// Nick name of the account
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
        /// Addtional SerialId or endpoint Id
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
        /// Addtional SerialId or endpoint Id
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
        /// Addtional SerialId or endpoint Id
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
        /// Addtional SerialId or endpoint Id
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
        /// Allow clearings
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
        /// Autorization code
        /// </summary>
        [JsonProperty("AuthorisationCode")]
        public int? AuthorisationCode
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
        /// Status of the transaction
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
        /// Driver Name of Card record
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
        /// Expiry period of the card
        /// </summary>
        [JsonProperty("CardExpiryPeriod")]
        public int? CardExpiryPeriod
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
        /// Card Expiry Date
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
        /// Card Group Code
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
        /// Group nmae of the card
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
        /// Issuer code
        /// </summary>
        [JsonProperty("IssuerCode")]
        public int? IssuerCode
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
        /// Full Card PAN
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
        /// Release code
        /// </summary>
        [JsonProperty("ReleaseCode")]
        public int? ReleaseCode
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
        /// Sequesnce number of the card
        /// </summary>
        [JsonProperty("CardSequenceNumber")]
        public int? CardSequenceNumber
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
        /// Type of card
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
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// </summary>
        [JsonProperty("ColCoCode")]
        public string ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// Unit discount Invoice currency
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
        /// Colco exchange rate
        /// </summary>
        [JsonProperty("ColCoExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public double? ColCoExchangeRate { get; set; }

        /// <summary>
        /// Currency symbol on which the invoice was raised
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
        /// Is there any correction
        /// </summary>
        [JsonProperty("CorrectionFlag")]
        public bool? CorrectionFlag
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
        /// CRM number
        /// </summary>
        [JsonProperty("CRMNumber")]
        public double? CRMNumber
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
        /// Customer country
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
        /// Curreny which customer uses to transact.
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
        /// Custome currency symbol
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
        /// Rebate on net amount in customer currency
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
        /// Effective discount in customers currency
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
        /// effectiive unit discount in customers currency
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
        /// Unitpricing in invoice currency
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
        /// Invoice tax
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
        /// Invoice amount befor tax
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
        /// Invoice amount after tax
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
        /// Vat on net amount in customer currency
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
        /// Customer retail unit price before tax
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
        /// Total Customer retail value before tax
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
        /// Total customer retail value after tax
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
        /// Trasaction type description
        /// </summary>
        [JsonProperty("TransactionTypeDescription")]
        public double? TransactionTypeDescription
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

        /// <summary>
        /// Rebate give to net amountin transaction currency that is used
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
        /// Currency used to giveEffective discount on transactions
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
        /// Exchange rate between Delco and Colco
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
        /// Gets or sets Cards.
        /// </summary>
        [JsonProperty("Cards", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Cards { get; set; }

        /// <summary>
        /// Currency used forto provide unit Transaction discount
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
        /// Transactional amount before tax
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
        /// Transaction net amount after tax
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
        /// Transaction tax
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
        /// Transactinal tax rates
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
        /// Priv
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
        /// Delco retail price per unit before tax
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
        /// Delco retail price per unit after tax
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
        /// Delco retail price per unit
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
        /// Delco retail price before tax
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
        /// Delco per unit price after tax
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
        /// Currency used for transaction.
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
        /// Type of discount available
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
        /// Is there any dispute status?True or False
        /// </summary>
        [JsonProperty("DisputeStatus")]
        public bool? DisputeStatus
        {
            get
            {
                if (!hasPropertySetterCalledFor["DisputeStatus"] &&
                    disputeStatus == null)
                {
                    return false; // Default value
                }

                return this.disputeStatus;
            }

            set
            {
                this.shouldSerialize["DisputeStatus"] = true;
                hasPropertySetterCalledFor["DisputeStatus"] = true;
                this.disputeStatus = value;
            }
        }

        /// <summary>
        /// Is it a shell sites?True or False
        /// </summary>
        [JsonProperty("IsShellSite", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShellSite { get; set; }

        /// <summary>
        /// Fleet identifier
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
        /// In coming product code
        /// </summary>
        [JsonProperty("IncomingProductCode")]
        public int? IncomingProductCode
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
        /// Date of Posting
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
        /// Time whern posting happened
        /// </summary>
        [JsonProperty("PostingTime")]
        public string PostingTime
        {
            get
            {
                return this.postingTime;
            }

            set
            {
                this.shouldSerialize["PostingTime"] = true;
                this.postingTime = value;
            }
        }

        /// <summary>
        /// Product Code - 21 Unleaded - High octane,22 Unleaded - Medium octane,23 Unleaded - Low octane,24 Unleaded Environmental
        /// </summary>
        [JsonProperty("ProductCode")]
        public int? ProductCode
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
        /// Name of the product
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
        /// Id of the product to which group it belongs
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
        /// In coming currecncy code
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
        /// In coming Site description
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
        /// Location of the Shell site
        /// </summary>
        [JsonProperty("Location")]
        public string Location
        {
            get
            {
                return this.location;
            }

            set
            {
                this.shouldSerialize["Location"] = true;
                this.location = value;
            }
        }

        /// <summary>
        /// Shell site name
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
        /// Shell site code
        /// </summary>
        [JsonProperty("SiteCode")]
        public int? SiteCode
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
        /// In coming site number
        /// </summary>
        [JsonProperty("IncomingSiteNumber")]
        public int? IncomingSiteNumber
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
        /// Currency code on which the invoice is raised
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
        /// Date on which the invoice was raised
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
        /// Invoice number
        /// </summary>
        [JsonProperty("InvoiceNumber")]
        public double? InvoiceNumber
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
        /// Is it a fuel product? True or False
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
        /// Is VAT applicable?Y or N
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
        /// Name of the payer
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
        /// Payer account number
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
        /// Parent account number of the payer
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
        /// The group which the payer belongs to
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
        /// Name of the group to which the payer belongs to.
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
        /// Check digit
        /// </summary>
        [JsonProperty("CheckDigit")]
        public int? CheckDigit
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
        /// After tax net invoice number
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
        /// Delco code
        /// </summary>
        [JsonProperty("DelcoCode")]
        public int? DelcoCode
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
        /// Network  code of the payer
        /// </summary>
        [JsonProperty("NetworkCode")]
        public int? NetworkCode
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
        /// Country of purchase
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
        /// Country where the site exists
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
        /// Country where VAT is applicable
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
        /// Name of the delivery company
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
        /// Network of the Delivery company
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
        /// Odometet input
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
        /// Original item identifier for sales
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
        /// Fleet identifier description
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
        /// Identifier of parent customer
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
        /// PIN indicator
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
        /// Name og the group the product belongs to
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
        /// The countroy code where the purchase was made
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
        /// Quantity of the product
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
        /// Rebate rate if any
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
        /// Reciept number
        /// </summary>
        [JsonProperty("ReceiptNumber")]
        public int? ReceiptNumber
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
        /// Gets or sets RefundFlag.
        /// </summary>
        [JsonProperty("RefundFlag", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricedTransactionRespV2RefundFlagEnum? RefundFlag { get; set; }

        /// <summary>
        /// Group identifier for the site
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
        /// Name of the Site group
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
        /// Latitude of the site
        /// </summary>
        [JsonProperty("Latitude")]
        public double? Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                this.shouldSerialize["Latitude"] = true;
                this.latitude = value;
            }
        }

        /// <summary>
        /// Longitude of the site
        /// </summary>
        [JsonProperty("Longitude")]
        public double? Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                this.shouldSerialize["Longitude"] = true;
                this.longitude = value;
            }
        }

        /// <summary>
        /// Delivery company exchange rate
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
        /// Rebate amount in Euros
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
        /// Net amount in Euros
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
        /// Vat amount in Euros
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
        /// Customers parent name
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
        /// Is invoice raised
        /// </summary>
        [JsonProperty("IsInvoiced")]
        public bool? IsInvoiced
        {
            get
            {
                if (!hasPropertySetterCalledFor["IsInvoiced"] &&
                    isInvoiced == null)
                {
                    return false; // Default value
                }

                return this.isInvoiced;
            }

            set
            {
                this.shouldSerialize["IsInvoiced"] = true;
                hasPropertySetterCalledFor["IsInvoiced"] = true;
                this.isInvoiced = value;
            }
        }

        /// <summary>
        /// Transaction currency code
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
        /// Is it Credit or debit C for credit D for Debit
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
        /// Date of transaction
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
        /// Time of transaction
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
        /// Identifier of the Iem in transaction
        /// </summary>
        [JsonProperty("TransactionItemId")]
        public string TransactionItemId
        {
            get
            {
                return this.transactionItemId;
            }

            set
            {
                this.shouldSerialize["TransactionItemId"] = true;
                this.transactionItemId = value;
            }
        }

        /// <summary>
        /// Transaction identifier
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
        /// Transaction type for Delco
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
        /// Gets or sets TransactionLine.
        /// </summary>
        [JsonProperty("TransactionLine")]
        public int? TransactionLine
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
        /// Transaction type Colco
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
        /// Leaving country
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
        /// To which category and counry does the  VAT come under
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
        /// VAT rate
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
        /// Vehicle registration number
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
        /// Check if the pruchase is cancelled
        /// </summary>
        [JsonProperty("IsCancelled")]
        public string IsCancelled
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
        /// Gross amount from Colco
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
        /// Net amount from Colco
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
        /// Colco VAT amount
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
        /// Original currency code
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
        /// Original currency code
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
        /// Original VAT amount
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
        /// Comapany name embosses in text
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
        /// Orginal exchange rate
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
        /// Original treansaction date
        /// </summary>
        [JsonProperty("OriginalTransactionItemInvoiceDate")]
        public string OriginalTransactionItemInvoiceDate
        {
            get
            {
                return this.originalTransactionItemInvoiceDate;
            }

            set
            {
                this.shouldSerialize["OriginalTransactionItemInvoiceDate"] = true;
                this.originalTransactionItemInvoiceDate = value;
            }
        }

        /// <summary>
        /// Fee type identifier
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
        /// Line item identifier of the product
        /// </summary>
        [JsonProperty("LineItemDescription")]
        public bool? LineItemDescription
        {
            get
            {
                if (!hasPropertySetterCalledFor["LineItemDescription"] &&
                    lineItemDescription == null)
                {
                    return false; // Default value
                }

                return this.lineItemDescription;
            }

            set
            {
                this.shouldSerialize["LineItemDescription"] = true;
                hasPropertySetterCalledFor["LineItemDescription"] = true;
                this.lineItemDescription = value;
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
        /// Frequency of transaction
        /// </summary>
        [JsonProperty("Frequency")]
        public int? Frequency
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
        /// Entry date in the system
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
        /// Entry time in the system
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
        /// Checking if its manual
        /// </summary>
        [JsonProperty("IsManual")]
        public string IsManual
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
        /// Is it manual
        /// </summary>
        [JsonProperty("OriginalTransactionItemId")]
        public string OriginalTransactionItemId
        {
            get
            {
                return this.originalTransactionItemId;
            }

            set
            {
                this.shouldSerialize["OriginalTransactionItemId"] = true;
                this.originalTransactionItemId = value;
            }
        }

        /// <summary>
        /// Original invoice transaction number
        /// </summary>
        [JsonProperty("OriginalTransactionItemInvoiceNumber")]
        public int? OriginalTransactionItemInvoiceNumber
        {
            get
            {
                return this.originalTransactionItemInvoiceNumber;
            }

            set
            {
                this.shouldSerialize["OriginalTransactionItemInvoiceNumber"] = true;
                this.originalTransactionItemInvoiceNumber = value;
            }
        }

        /// <summary>
        /// Original Invoice transaction Identifier
        /// </summary>
        [JsonProperty("OriginalTransactionItemInvoiceId")]
        public int? OriginalTransactionItemInvoiceId
        {
            get
            {
                return this.originalTransactionItemInvoiceId;
            }

            set
            {
                this.shouldSerialize["OriginalTransactionItemInvoiceId"] = true;
                this.originalTransactionItemInvoiceId = value;
            }
        }

        /// <summary>
        /// Payers short name
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
        /// Is reverse charge?
        /// </summary>
        [JsonProperty("ReverseCharge")]
        public string ReverseCharge
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
        /// Original gross amount
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
        /// Original Net amount
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
        /// Unit of measure
        /// </summary>
        [JsonProperty("UnitOfMeasure")]
        public string UnitOfMeasure
        {
            get
            {
                return this.unitOfMeasure;
            }

            set
            {
                this.shouldSerialize["UnitOfMeasure"] = true;
                this.unitOfMeasure = value;
            }
        }

        /// <summary>
        /// Type of road
        /// </summary>
        [JsonProperty("RoadType")]
        public string RoadType
        {
            get
            {
                return this.roadType;
            }

            set
            {
                this.shouldSerialize["RoadType"] = true;
                this.roadType = value;
            }
        }

        /// <summary>
        /// Customer country ISO Code
        /// </summary>
        [JsonProperty("CustomerCountryIsoCode")]
        public string CustomerCountryIsoCode
        {
            get
            {
                return this.customerCountryIsoCode;
            }

            set
            {
                this.shouldSerialize["CustomerCountryIsoCode"] = true;
                this.customerCountryIsoCode = value;
            }
        }

        /// <summary>
        /// EvOperator Name
        /// </summary>
        [JsonProperty("EVOperator")]
        public string EVOperator
        {
            get
            {
                return this.eVOperator;
            }

            set
            {
                this.shouldSerialize["EVOperator"] = true;
                this.eVOperator = value;
            }
        }

        /// <summary>
        /// Ev Operator identifier
        /// </summary>
        [JsonProperty("EVSerialId")]
        public string EVSerialId
        {
            get
            {
                return this.eVSerialId;
            }

            set
            {
                this.shouldSerialize["EVSerialId"] = true;
                this.eVSerialId = value;
            }
        }

        /// <summary>
        /// EV Charging point iserial identifier
        /// </summary>
        [JsonProperty("EVChargePointSerial")]
        public string EVChargePointSerial
        {
            get
            {
                return this.eVChargePointSerial;
            }

            set
            {
                this.shouldSerialize["EVChargePointSerial"] = true;
                this.eVChargePointSerial = value;
            }
        }

        /// <summary>
        /// Ev chariging connector type
        /// </summary>
        [JsonProperty("EVChargePointConnectorType")]
        public int? EVChargePointConnectorType
        {
            get
            {
                return this.eVChargePointConnectorType;
            }

            set
            {
                this.shouldSerialize["EVChargePointConnectorType"] = true;
                this.eVChargePointConnectorType = value;
            }
        }

        /// <summary>
        /// EV charging point connector type description
        /// </summary>
        [JsonProperty("EVChargePointConnectorTypeDescription")]
        public string EVChargePointConnectorTypeDescription
        {
            get
            {
                return this.eVChargePointConnectorTypeDescription;
            }

            set
            {
                this.shouldSerialize["EVChargePointConnectorTypeDescription"] = true;
                this.eVChargePointConnectorTypeDescription = value;
            }
        }

        /// <summary>
        /// Ev charging Duration
        /// </summary>
        [JsonProperty("EVChargeDuration")]
        public string EVChargeDuration
        {
            get
            {
                return this.eVChargeDuration;
            }

            set
            {
                this.shouldSerialize["EVChargeDuration"] = true;
                this.eVChargeDuration = value;
            }
        }

        /// <summary>
        /// EvCharging start Date
        /// </summary>
        [JsonProperty("EVChargeStartDate")]
        public string EVChargeStartDate
        {
            get
            {
                return this.eVChargeStartDate;
            }

            set
            {
                this.shouldSerialize["EVChargeStartDate"] = true;
                this.eVChargeStartDate = value;
            }
        }

        /// <summary>
        /// EvCharging start time
        /// </summary>
        [JsonProperty("EVChargeStartTime")]
        public string EVChargeStartTime
        {
            get
            {
                return this.eVChargeStartTime;
            }

            set
            {
                this.shouldSerialize["EVChargeStartTime"] = true;
                this.eVChargeStartTime = value;
            }
        }

        /// <summary>
        /// EvCharging End Date
        /// </summary>
        [JsonProperty("EVChargeEndDate")]
        public string EVChargeEndDate
        {
            get
            {
                return this.eVChargeEndDate;
            }

            set
            {
                this.shouldSerialize["EVChargeEndDate"] = true;
                this.eVChargeEndDate = value;
            }
        }

        /// <summary>
        /// EvCharging End time
        /// </summary>
        [JsonProperty("EVChargeEndTime")]
        public string EVChargeEndTime
        {
            get
            {
                return this.eVChargeEndTime;
            }

            set
            {
                this.shouldSerialize["EVChargeEndTime"] = true;
                this.eVChargeEndTime = value;
            }
        }

        /// <summary>
        /// Gets or sets HostingCollectingCompanyNumber.
        /// </summary>
        [JsonProperty("HostingCollectingCompanyNumber")]
        public int? HostingCollectingCompanyNumber
        {
            get
            {
                return this.hostingCollectingCompanyNumber;
            }

            set
            {
                this.shouldSerialize["HostingCollectingCompanyNumber"] = true;
                this.hostingCollectingCompanyNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets TransactionId.
        /// </summary>
        [JsonProperty("TransactionId")]
        public double? TransactionId
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
        /// Gets or sets FuelOnly.
        /// </summary>
        [JsonProperty("FuelOnly")]
        public bool? FuelOnly
        {
            get
            {
                return this.fuelOnly;
            }

            set
            {
                this.shouldSerialize["FuelOnly"] = true;
                this.fuelOnly = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricedResponseData : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAllowClearing()
        {
            this.shouldSerialize["AllowClearing"] = false;
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
        public void UnsetTransactionStatus()
        {
            this.shouldSerialize["TransactionStatus"] = false;
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
        public void UnsetCardExpiryPeriod()
        {
            this.shouldSerialize["CardExpiryPeriod"] = false;
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
        public void UnsetIssuerCode()
        {
            this.shouldSerialize["IssuerCode"] = false;
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
        public void UnsetReleaseCode()
        {
            this.shouldSerialize["ReleaseCode"] = false;
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
        public void UnsetCardType()
        {
            this.shouldSerialize["CardType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
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
        public void UnsetInvoiceCurrencySymbol()
        {
            this.shouldSerialize["InvoiceCurrencySymbol"] = false;
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
        public void UnsetCRMNumber()
        {
            this.shouldSerialize["CRMNumber"] = false;
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
        public void UnsetRebateonNetAmountInCustomerCurrency()
        {
            this.shouldSerialize["RebateonNetAmountInCustomerCurrency"] = false;
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
        public void UnsetEffectiveUnitDiscountInCustomerCurrency()
        {
            this.shouldSerialize["EffectiveUnitDiscountInCustomerCurrency"] = false;
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
        public void UnsetInvoiceNetAmount()
        {
            this.shouldSerialize["InvoiceNetAmount"] = false;
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRebateonNetAmountInTransactionCurrency()
        {
            this.shouldSerialize["RebateonNetAmountInTransactionCurrency"] = false;
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
        public void UnsetDelCoToColCoExchangeRate()
        {
            this.shouldSerialize["DelCoToColCoExchangeRate"] = false;
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
        public void UnsetTransactionGrossAmount()
        {
            this.shouldSerialize["TransactionGrossAmount"] = false;
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
        public void UnsetVATonNetAmount()
        {
            this.shouldSerialize["VATonNetAmount"] = false;
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
        public void UnsetDelcoRetailPriceUnitGross()
        {
            this.shouldSerialize["DelcoRetailPriceUnitGross"] = false;
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
        public void UnsetDelcoRetailPriceUnitNet()
        {
            this.shouldSerialize["DelcoRetailPriceUnitNet"] = false;
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
        public void UnsetDelcoRetailValueTotalNet()
        {
            this.shouldSerialize["DelcoRetailValueTotalNet"] = false;
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
        public void UnsetDiscountType()
        {
            this.shouldSerialize["DiscountType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDisputeStatus()
        {
            this.shouldSerialize["DisputeStatus"] = false;
            this.hasPropertySetterCalledFor["DisputeStatus"] = false;
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
        public void UnsetIncomingProductCode()
        {
            this.shouldSerialize["IncomingProductCode"] = false;
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
        public void UnsetPostingTime()
        {
            this.shouldSerialize["PostingTime"] = false;
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
        public void UnsetIncomingCurrencyCode()
        {
            this.shouldSerialize["IncomingCurrencyCode"] = false;
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
        public void UnsetLocation()
        {
            this.shouldSerialize["Location"] = false;
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
        public void UnsetSiteCode()
        {
            this.shouldSerialize["SiteCode"] = false;
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
        public void UnsetInvoiceCurrencyCode()
        {
            this.shouldSerialize["InvoiceCurrencyCode"] = false;
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
        public void UnsetInvoiceNumber()
        {
            this.shouldSerialize["InvoiceNumber"] = false;
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
        public void UnsetVATApplicable()
        {
            this.shouldSerialize["VATApplicable"] = false;
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
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
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
        public void UnsetCheckDigit()
        {
            this.shouldSerialize["CheckDigit"] = false;
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
        public void UnsetDelcoCode()
        {
            this.shouldSerialize["DelcoCode"] = false;
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
        public void UnsetPurchasedInCountry()
        {
            this.shouldSerialize["PurchasedInCountry"] = false;
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
        public void UnsetVATCountry()
        {
            this.shouldSerialize["VATCountry"] = false;
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
        public void UnsetNetwork()
        {
            this.shouldSerialize["Network"] = false;
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
        public void UnsetOriginalSalesItemId()
        {
            this.shouldSerialize["OriginalSalesItemId"] = false;
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
        public void UnsetParentCustomerId()
        {
            this.shouldSerialize["ParentCustomerId"] = false;
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
        public void UnsetProductGroupName()
        {
            this.shouldSerialize["ProductGroupName"] = false;
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
        public void UnsetQuantity()
        {
            this.shouldSerialize["Quantity"] = false;
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
        public void UnsetReceiptNumber()
        {
            this.shouldSerialize["ReceiptNumber"] = false;
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
        public void UnsetLatitude()
        {
            this.shouldSerialize["Latitude"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLongitude()
        {
            this.shouldSerialize["Longitude"] = false;
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
        public void UnsetEuroRebateAmount()
        {
            this.shouldSerialize["EuroRebateAmount"] = false;
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
        public void UnsetEuroVATAmount()
        {
            this.shouldSerialize["EuroVATAmount"] = false;
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
        public void UnsetIsInvoiced()
        {
            this.shouldSerialize["IsInvoiced"] = false;
            this.hasPropertySetterCalledFor["IsInvoiced"] = false;
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
        public void UnsetCreditDebitCode()
        {
            this.shouldSerialize["CreditDebitCode"] = false;
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
        public void UnsetTransactionItemId()
        {
            this.shouldSerialize["TransactionItemId"] = false;
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
        public void UnsetType()
        {
            this.shouldSerialize["Type"] = false;
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
        public void UnsetTransactionType()
        {
            this.shouldSerialize["TransactionType"] = false;
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
        public void UnsetVATCategory()
        {
            this.shouldSerialize["VATCategory"] = false;
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
        public void UnsetVehicleRegistration()
        {
            this.shouldSerialize["VehicleRegistration"] = false;
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
        public void UnsetColCoGrossAmount()
        {
            this.shouldSerialize["ColCoGrossAmount"] = false;
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
        public void UnsetOriginalCurrencySymbol()
        {
            this.shouldSerialize["OriginalCurrencySymbol"] = false;
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
        public void UnsetOriginalVATAmount()
        {
            this.shouldSerialize["OriginalVATAmount"] = false;
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
        public void UnsetOriginalExchangeRate()
        {
            this.shouldSerialize["OriginalExchangeRate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalTransactionItemInvoiceDate()
        {
            this.shouldSerialize["OriginalTransactionItemInvoiceDate"] = false;
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
        public void UnsetLineItemDescription()
        {
            this.shouldSerialize["LineItemDescription"] = false;
            this.hasPropertySetterCalledFor["LineItemDescription"] = false;
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
        public void UnsetFrequency()
        {
            this.shouldSerialize["Frequency"] = false;
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
        public void UnsetIsManual()
        {
            this.shouldSerialize["IsManual"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalTransactionItemId()
        {
            this.shouldSerialize["OriginalTransactionItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalTransactionItemInvoiceNumber()
        {
            this.shouldSerialize["OriginalTransactionItemInvoiceNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOriginalTransactionItemInvoiceId()
        {
            this.shouldSerialize["OriginalTransactionItemInvoiceId"] = false;
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
        public void UnsetReverseCharge()
        {
            this.shouldSerialize["ReverseCharge"] = false;
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
        public void UnsetOriginalNetAmount()
        {
            this.shouldSerialize["OriginalNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnitOfMeasure()
        {
            this.shouldSerialize["UnitOfMeasure"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRoadType()
        {
            this.shouldSerialize["RoadType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerCountryIsoCode()
        {
            this.shouldSerialize["CustomerCountryIsoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVOperator()
        {
            this.shouldSerialize["EVOperator"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVSerialId()
        {
            this.shouldSerialize["EVSerialId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargePointSerial()
        {
            this.shouldSerialize["EVChargePointSerial"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargePointConnectorType()
        {
            this.shouldSerialize["EVChargePointConnectorType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargePointConnectorTypeDescription()
        {
            this.shouldSerialize["EVChargePointConnectorTypeDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargeDuration()
        {
            this.shouldSerialize["EVChargeDuration"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargeStartDate()
        {
            this.shouldSerialize["EVChargeStartDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargeStartTime()
        {
            this.shouldSerialize["EVChargeStartTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargeEndDate()
        {
            this.shouldSerialize["EVChargeEndDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVChargeEndTime()
        {
            this.shouldSerialize["EVChargeEndTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHostingCollectingCompanyNumber()
        {
            this.shouldSerialize["HostingCollectingCompanyNumber"] = false;
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
        public void UnsetFuelOnly()
        {
            this.shouldSerialize["FuelOnly"] = false;
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
        public bool ShouldSerializeAllowClearing()
        {
            return this.shouldSerialize["AllowClearing"];
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
        public bool ShouldSerializeTransactionStatus()
        {
            return this.shouldSerialize["TransactionStatus"];
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
        public bool ShouldSerializeCardExpiryPeriod()
        {
            return this.shouldSerialize["CardExpiryPeriod"];
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
        public bool ShouldSerializeIssuerCode()
        {
            return this.shouldSerialize["IssuerCode"];
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
        public bool ShouldSerializeReleaseCode()
        {
            return this.shouldSerialize["ReleaseCode"];
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
        public bool ShouldSerializeCardType()
        {
            return this.shouldSerialize["CardType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
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
        public bool ShouldSerializeInvoiceCurrencySymbol()
        {
            return this.shouldSerialize["InvoiceCurrencySymbol"];
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
        public bool ShouldSerializeCRMNumber()
        {
            return this.shouldSerialize["CRMNumber"];
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
        public bool ShouldSerializeRebateonNetAmountInCustomerCurrency()
        {
            return this.shouldSerialize["RebateonNetAmountInCustomerCurrency"];
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
        public bool ShouldSerializeEffectiveUnitDiscountInCustomerCurrency()
        {
            return this.shouldSerialize["EffectiveUnitDiscountInCustomerCurrency"];
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
        public bool ShouldSerializeInvoiceNetAmount()
        {
            return this.shouldSerialize["InvoiceNetAmount"];
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
        public bool ShouldSerializeEffectiveDiscountInTrxCurrency()
        {
            return this.shouldSerialize["EffectiveDiscountInTrxCurrency"];
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
        public bool ShouldSerializeUnitDiscountTransactionCurrency()
        {
            return this.shouldSerialize["UnitDiscountTransactionCurrency"];
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
        public bool ShouldSerializeVATonNetAmount()
        {
            return this.shouldSerialize["VATonNetAmount"];
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
        public bool ShouldSerializeDelcoRetailPriceUnitGross()
        {
            return this.shouldSerialize["DelcoRetailPriceUnitGross"];
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
        public bool ShouldSerializeDelcoRetailPriceUnitNet()
        {
            return this.shouldSerialize["DelcoRetailPriceUnitNet"];
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
        public bool ShouldSerializeDelcoRetailValueTotalNet()
        {
            return this.shouldSerialize["DelcoRetailValueTotalNet"];
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
        public bool ShouldSerializeDiscountType()
        {
            return this.shouldSerialize["DiscountType"];
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
        public bool ShouldSerializeFleetIdInput()
        {
            return this.shouldSerialize["FleetIdInput"];
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
        public bool ShouldSerializePostingDate()
        {
            return this.shouldSerialize["PostingDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePostingTime()
        {
            return this.shouldSerialize["PostingTime"];
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
        public bool ShouldSerializeIncomingCurrencyCode()
        {
            return this.shouldSerialize["IncomingCurrencyCode"];
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
        public bool ShouldSerializeLocation()
        {
            return this.shouldSerialize["Location"];
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
        public bool ShouldSerializeSiteCode()
        {
            return this.shouldSerialize["SiteCode"];
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
        public bool ShouldSerializeInvoiceCurrencyCode()
        {
            return this.shouldSerialize["InvoiceCurrencyCode"];
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
        public bool ShouldSerializeInvoiceNumber()
        {
            return this.shouldSerialize["InvoiceNumber"];
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
        public bool ShouldSerializeVATApplicable()
        {
            return this.shouldSerialize["VATApplicable"];
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
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
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
        public bool ShouldSerializeCheckDigit()
        {
            return this.shouldSerialize["CheckDigit"];
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
        public bool ShouldSerializeDelcoCode()
        {
            return this.shouldSerialize["DelcoCode"];
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
        public bool ShouldSerializePurchasedInCountry()
        {
            return this.shouldSerialize["PurchasedInCountry"];
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
        public bool ShouldSerializeVATCountry()
        {
            return this.shouldSerialize["VATCountry"];
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
        public bool ShouldSerializeNetwork()
        {
            return this.shouldSerialize["Network"];
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
        public bool ShouldSerializeOriginalSalesItemId()
        {
            return this.shouldSerialize["OriginalSalesItemId"];
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
        public bool ShouldSerializeParentCustomerId()
        {
            return this.shouldSerialize["ParentCustomerId"];
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
        public bool ShouldSerializeProductGroupName()
        {
            return this.shouldSerialize["ProductGroupName"];
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
        public bool ShouldSerializeQuantity()
        {
            return this.shouldSerialize["Quantity"];
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
        public bool ShouldSerializeReceiptNumber()
        {
            return this.shouldSerialize["ReceiptNumber"];
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
        public bool ShouldSerializeLatitude()
        {
            return this.shouldSerialize["Latitude"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLongitude()
        {
            return this.shouldSerialize["Longitude"];
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
        public bool ShouldSerializeEuroRebateAmount()
        {
            return this.shouldSerialize["EuroRebateAmount"];
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
        public bool ShouldSerializeEuroVATAmount()
        {
            return this.shouldSerialize["EuroVATAmount"];
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
        public bool ShouldSerializeIsInvoiced()
        {
            return this.shouldSerialize["IsInvoiced"];
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
        public bool ShouldSerializeCreditDebitCode()
        {
            return this.shouldSerialize["CreditDebitCode"];
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
        public bool ShouldSerializeTransactionItemId()
        {
            return this.shouldSerialize["TransactionItemId"];
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
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["Type"];
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
        public bool ShouldSerializeTransactionType()
        {
            return this.shouldSerialize["TransactionType"];
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
        public bool ShouldSerializeVATCategory()
        {
            return this.shouldSerialize["VATCategory"];
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
        public bool ShouldSerializeVehicleRegistration()
        {
            return this.shouldSerialize["VehicleRegistration"];
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
        public bool ShouldSerializeColCoGrossAmount()
        {
            return this.shouldSerialize["ColCoGrossAmount"];
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
        public bool ShouldSerializeOriginalCurrencySymbol()
        {
            return this.shouldSerialize["OriginalCurrencySymbol"];
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
        public bool ShouldSerializeOriginalVATAmount()
        {
            return this.shouldSerialize["OriginalVATAmount"];
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
        public bool ShouldSerializeOriginalExchangeRate()
        {
            return this.shouldSerialize["OriginalExchangeRate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalTransactionItemInvoiceDate()
        {
            return this.shouldSerialize["OriginalTransactionItemInvoiceDate"];
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
        public bool ShouldSerializeLineItemDescription()
        {
            return this.shouldSerialize["LineItemDescription"];
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
        public bool ShouldSerializeFrequency()
        {
            return this.shouldSerialize["Frequency"];
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
        public bool ShouldSerializeIsManual()
        {
            return this.shouldSerialize["IsManual"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalTransactionItemId()
        {
            return this.shouldSerialize["OriginalTransactionItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalTransactionItemInvoiceNumber()
        {
            return this.shouldSerialize["OriginalTransactionItemInvoiceNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOriginalTransactionItemInvoiceId()
        {
            return this.shouldSerialize["OriginalTransactionItemInvoiceId"];
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
        public bool ShouldSerializeReverseCharge()
        {
            return this.shouldSerialize["ReverseCharge"];
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
        public bool ShouldSerializeOriginalNetAmount()
        {
            return this.shouldSerialize["OriginalNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitOfMeasure()
        {
            return this.shouldSerialize["UnitOfMeasure"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRoadType()
        {
            return this.shouldSerialize["RoadType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerCountryIsoCode()
        {
            return this.shouldSerialize["CustomerCountryIsoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVOperator()
        {
            return this.shouldSerialize["EVOperator"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVSerialId()
        {
            return this.shouldSerialize["EVSerialId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargePointSerial()
        {
            return this.shouldSerialize["EVChargePointSerial"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargePointConnectorType()
        {
            return this.shouldSerialize["EVChargePointConnectorType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargePointConnectorTypeDescription()
        {
            return this.shouldSerialize["EVChargePointConnectorTypeDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargeDuration()
        {
            return this.shouldSerialize["EVChargeDuration"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargeStartDate()
        {
            return this.shouldSerialize["EVChargeStartDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargeStartTime()
        {
            return this.shouldSerialize["EVChargeStartTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargeEndDate()
        {
            return this.shouldSerialize["EVChargeEndDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVChargeEndTime()
        {
            return this.shouldSerialize["EVChargeEndTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHostingCollectingCompanyNumber()
        {
            return this.shouldSerialize["HostingCollectingCompanyNumber"];
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
        public bool ShouldSerializeFuelOnly()
        {
            return this.shouldSerialize["FuelOnly"];
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
            return obj is PricedResponseData other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.Additional1 == null && other.Additional1 == null) || (this.Additional1?.Equals(other.Additional1) == true)) &&
                ((this.Additional2 == null && other.Additional2 == null) || (this.Additional2?.Equals(other.Additional2) == true)) &&
                ((this.Additional3 == null && other.Additional3 == null) || (this.Additional3?.Equals(other.Additional3) == true)) &&
                ((this.Additional4 == null && other.Additional4 == null) || (this.Additional4?.Equals(other.Additional4) == true)) &&
                ((this.AllowClearing == null && other.AllowClearing == null) || (this.AllowClearing?.Equals(other.AllowClearing) == true)) &&
                ((this.AuthorisationCode == null && other.AuthorisationCode == null) || (this.AuthorisationCode?.Equals(other.AuthorisationCode) == true)) &&
                ((this.TransactionStatus == null && other.TransactionStatus == null) || (this.TransactionStatus?.Equals(other.TransactionStatus) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.CardExpiryPeriod == null && other.CardExpiryPeriod == null) || (this.CardExpiryPeriod?.Equals(other.CardExpiryPeriod) == true)) &&
                ((this.CardExpiry == null && other.CardExpiry == null) || (this.CardExpiry?.Equals(other.CardExpiry) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.IssuerCode == null && other.IssuerCode == null) || (this.IssuerCode?.Equals(other.IssuerCode) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.ReleaseCode == null && other.ReleaseCode == null) || (this.ReleaseCode?.Equals(other.ReleaseCode) == true)) &&
                ((this.CardSequenceNumber == null && other.CardSequenceNumber == null) || (this.CardSequenceNumber?.Equals(other.CardSequenceNumber) == true)) &&
                ((this.CardType == null && other.CardType == null) || (this.CardType?.Equals(other.CardType) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.UnitDiscountInvoiceCurrency == null && other.UnitDiscountInvoiceCurrency == null) || (this.UnitDiscountInvoiceCurrency?.Equals(other.UnitDiscountInvoiceCurrency) == true)) &&
                ((this.ColCoExchangeRate == null && other.ColCoExchangeRate == null) || (this.ColCoExchangeRate?.Equals(other.ColCoExchangeRate) == true)) &&
                ((this.InvoiceCurrencySymbol == null && other.InvoiceCurrencySymbol == null) || (this.InvoiceCurrencySymbol?.Equals(other.InvoiceCurrencySymbol) == true)) &&
                ((this.CorrectionFlag == null && other.CorrectionFlag == null) || (this.CorrectionFlag?.Equals(other.CorrectionFlag) == true)) &&
                ((this.CRMNumber == null && other.CRMNumber == null) || (this.CRMNumber?.Equals(other.CRMNumber) == true)) &&
                ((this.CustomerCountry == null && other.CustomerCountry == null) || (this.CustomerCountry?.Equals(other.CustomerCountry) == true)) &&
                ((this.CustomerCurrencyCode == null && other.CustomerCurrencyCode == null) || (this.CustomerCurrencyCode?.Equals(other.CustomerCurrencyCode) == true)) &&
                ((this.CustomerCurrencySymbol == null && other.CustomerCurrencySymbol == null) || (this.CustomerCurrencySymbol?.Equals(other.CustomerCurrencySymbol) == true)) &&
                ((this.RebateonNetAmountInCustomerCurrency == null && other.RebateonNetAmountInCustomerCurrency == null) || (this.RebateonNetAmountInCustomerCurrency?.Equals(other.RebateonNetAmountInCustomerCurrency) == true)) &&
                ((this.EffectiveDiscountInCustomerCurrency == null && other.EffectiveDiscountInCustomerCurrency == null) || (this.EffectiveDiscountInCustomerCurrency?.Equals(other.EffectiveDiscountInCustomerCurrency) == true)) &&
                ((this.EffectiveUnitDiscountInCustomerCurrency == null && other.EffectiveUnitDiscountInCustomerCurrency == null) || (this.EffectiveUnitDiscountInCustomerCurrency?.Equals(other.EffectiveUnitDiscountInCustomerCurrency) == true)) &&
                ((this.UnitPriceInInvoiceCurrency == null && other.UnitPriceInInvoiceCurrency == null) || (this.UnitPriceInInvoiceCurrency?.Equals(other.UnitPriceInInvoiceCurrency) == true)) &&
                ((this.InvoiceTax == null && other.InvoiceTax == null) || (this.InvoiceTax?.Equals(other.InvoiceTax) == true)) &&
                ((this.InvoiceGrossAmount == null && other.InvoiceGrossAmount == null) || (this.InvoiceGrossAmount?.Equals(other.InvoiceGrossAmount) == true)) &&
                ((this.InvoiceNetAmount == null && other.InvoiceNetAmount == null) || (this.InvoiceNetAmount?.Equals(other.InvoiceNetAmount) == true)) &&
                ((this.VATonNetAmountInCustomerCurrency == null && other.VATonNetAmountInCustomerCurrency == null) || (this.VATonNetAmountInCustomerCurrency?.Equals(other.VATonNetAmountInCustomerCurrency) == true)) &&
                ((this.CustomerRetailPriceUnitGross == null && other.CustomerRetailPriceUnitGross == null) || (this.CustomerRetailPriceUnitGross?.Equals(other.CustomerRetailPriceUnitGross) == true)) &&
                ((this.CustomerRetailValueTotalGross == null && other.CustomerRetailValueTotalGross == null) || (this.CustomerRetailValueTotalGross?.Equals(other.CustomerRetailValueTotalGross) == true)) &&
                ((this.CustomerRetailValueTotalNet == null && other.CustomerRetailValueTotalNet == null) || (this.CustomerRetailValueTotalNet?.Equals(other.CustomerRetailValueTotalNet) == true)) &&
                ((this.TransactionTypeDescription == null && other.TransactionTypeDescription == null) || (this.TransactionTypeDescription?.Equals(other.TransactionTypeDescription) == true)) &&
                ((this.RebateonNetAmountInTransactionCurrency == null && other.RebateonNetAmountInTransactionCurrency == null) || (this.RebateonNetAmountInTransactionCurrency?.Equals(other.RebateonNetAmountInTransactionCurrency) == true)) &&
                ((this.EffectiveDiscountInTrxCurrency == null && other.EffectiveDiscountInTrxCurrency == null) || (this.EffectiveDiscountInTrxCurrency?.Equals(other.EffectiveDiscountInTrxCurrency) == true)) &&
                ((this.DelCoToColCoExchangeRate == null && other.DelCoToColCoExchangeRate == null) || (this.DelCoToColCoExchangeRate?.Equals(other.DelCoToColCoExchangeRate) == true)) &&
                ((this.Cards == null && other.Cards == null) || (this.Cards?.Equals(other.Cards) == true)) &&
                ((this.UnitDiscountTransactionCurrency == null && other.UnitDiscountTransactionCurrency == null) || (this.UnitDiscountTransactionCurrency?.Equals(other.UnitDiscountTransactionCurrency) == true)) &&
                ((this.TransactionGrossAmount == null && other.TransactionGrossAmount == null) || (this.TransactionGrossAmount?.Equals(other.TransactionGrossAmount) == true)) &&
                ((this.TransactionNetAmount == null && other.TransactionNetAmount == null) || (this.TransactionNetAmount?.Equals(other.TransactionNetAmount) == true)) &&
                ((this.TransactionTax == null && other.TransactionTax == null) || (this.TransactionTax?.Equals(other.TransactionTax) == true)) &&
                ((this.VATonNetAmount == null && other.VATonNetAmount == null) || (this.VATonNetAmount?.Equals(other.VATonNetAmount) == true)) &&
                ((this.DelcoListPriceUnitNet == null && other.DelcoListPriceUnitNet == null) || (this.DelcoListPriceUnitNet?.Equals(other.DelcoListPriceUnitNet) == true)) &&
                ((this.DelcoRetailPriceUnitGross == null && other.DelcoRetailPriceUnitGross == null) || (this.DelcoRetailPriceUnitGross?.Equals(other.DelcoRetailPriceUnitGross) == true)) &&
                ((this.UnitPriceInTransactionCurrency == null && other.UnitPriceInTransactionCurrency == null) || (this.UnitPriceInTransactionCurrency?.Equals(other.UnitPriceInTransactionCurrency) == true)) &&
                ((this.DelcoRetailPriceUnitNet == null && other.DelcoRetailPriceUnitNet == null) || (this.DelcoRetailPriceUnitNet?.Equals(other.DelcoRetailPriceUnitNet) == true)) &&
                ((this.DelcoRetailValueTotalGross == null && other.DelcoRetailValueTotalGross == null) || (this.DelcoRetailValueTotalGross?.Equals(other.DelcoRetailValueTotalGross) == true)) &&
                ((this.DelcoRetailValueTotalNet == null && other.DelcoRetailValueTotalNet == null) || (this.DelcoRetailValueTotalNet?.Equals(other.DelcoRetailValueTotalNet) == true)) &&
                ((this.TransactionCurrencySymbol == null && other.TransactionCurrencySymbol == null) || (this.TransactionCurrencySymbol?.Equals(other.TransactionCurrencySymbol) == true)) &&
                ((this.DiscountType == null && other.DiscountType == null) || (this.DiscountType?.Equals(other.DiscountType) == true)) &&
                ((this.DisputeStatus == null && other.DisputeStatus == null) || (this.DisputeStatus?.Equals(other.DisputeStatus) == true)) &&
                ((this.IsShellSite == null && other.IsShellSite == null) || (this.IsShellSite?.Equals(other.IsShellSite) == true)) &&
                ((this.FleetIdInput == null && other.FleetIdInput == null) || (this.FleetIdInput?.Equals(other.FleetIdInput) == true)) &&
                ((this.IncomingProductCode == null && other.IncomingProductCode == null) || (this.IncomingProductCode?.Equals(other.IncomingProductCode) == true)) &&
                ((this.PostingDate == null && other.PostingDate == null) || (this.PostingDate?.Equals(other.PostingDate) == true)) &&
                ((this.PostingTime == null && other.PostingTime == null) || (this.PostingTime?.Equals(other.PostingTime) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductGroupId == null && other.ProductGroupId == null) || (this.ProductGroupId?.Equals(other.ProductGroupId) == true)) &&
                ((this.IncomingCurrencyCode == null && other.IncomingCurrencyCode == null) || (this.IncomingCurrencyCode?.Equals(other.IncomingCurrencyCode) == true)) &&
                ((this.IncomingSiteDescription == null && other.IncomingSiteDescription == null) || (this.IncomingSiteDescription?.Equals(other.IncomingSiteDescription) == true)) &&
                ((this.Location == null && other.Location == null) || (this.Location?.Equals(other.Location) == true)) &&
                ((this.SiteName == null && other.SiteName == null) || (this.SiteName?.Equals(other.SiteName) == true)) &&
                ((this.SiteCode == null && other.SiteCode == null) || (this.SiteCode?.Equals(other.SiteCode) == true)) &&
                ((this.IncomingSiteNumber == null && other.IncomingSiteNumber == null) || (this.IncomingSiteNumber?.Equals(other.IncomingSiteNumber) == true)) &&
                ((this.InvoiceCurrencyCode == null && other.InvoiceCurrencyCode == null) || (this.InvoiceCurrencyCode?.Equals(other.InvoiceCurrencyCode) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.FuelProduct == null && other.FuelProduct == null) || (this.FuelProduct?.Equals(other.FuelProduct) == true)) &&
                ((this.VATApplicable == null && other.VATApplicable == null) || (this.VATApplicable?.Equals(other.VATApplicable) == true)) &&
                ((this.PayerName == null && other.PayerName == null) || (this.PayerName?.Equals(other.PayerName) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.ParentCustomerNumber == null && other.ParentCustomerNumber == null) || (this.ParentCustomerNumber?.Equals(other.ParentCustomerNumber) == true)) &&
                ((this.PayerGroup == null && other.PayerGroup == null) || (this.PayerGroup?.Equals(other.PayerGroup) == true)) &&
                ((this.PayerGroupName == null && other.PayerGroupName == null) || (this.PayerGroupName?.Equals(other.PayerGroupName) == true)) &&
                ((this.CheckDigit == null && other.CheckDigit == null) || (this.CheckDigit?.Equals(other.CheckDigit) == true)) &&
                ((this.NetInvoiceIndicator == null && other.NetInvoiceIndicator == null) || (this.NetInvoiceIndicator?.Equals(other.NetInvoiceIndicator) == true)) &&
                ((this.DelcoCode == null && other.DelcoCode == null) || (this.DelcoCode?.Equals(other.DelcoCode) == true)) &&
                ((this.NetworkCode == null && other.NetworkCode == null) || (this.NetworkCode?.Equals(other.NetworkCode) == true)) &&
                ((this.PurchasedInCountry == null && other.PurchasedInCountry == null) || (this.PurchasedInCountry?.Equals(other.PurchasedInCountry) == true)) &&
                ((this.SiteCountry == null && other.SiteCountry == null) || (this.SiteCountry?.Equals(other.SiteCountry) == true)) &&
                ((this.VATCountry == null && other.VATCountry == null) || (this.VATCountry?.Equals(other.VATCountry) == true)) &&
                ((this.DelcoName == null && other.DelcoName == null) || (this.DelcoName?.Equals(other.DelcoName) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.OdometerInput == null && other.OdometerInput == null) || (this.OdometerInput?.Equals(other.OdometerInput) == true)) &&
                ((this.OriginalSalesItemId == null && other.OriginalSalesItemId == null) || (this.OriginalSalesItemId?.Equals(other.OriginalSalesItemId) == true)) &&
                ((this.FleetIDDescription == null && other.FleetIDDescription == null) || (this.FleetIDDescription?.Equals(other.FleetIDDescription) == true)) &&
                ((this.ParentCustomerId == null && other.ParentCustomerId == null) || (this.ParentCustomerId?.Equals(other.ParentCustomerId) == true)) &&
                ((this.PINIndicator == null && other.PINIndicator == null) || (this.PINIndicator?.Equals(other.PINIndicator) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true)) &&
                ((this.PurchasedInCountryCode == null && other.PurchasedInCountryCode == null) || (this.PurchasedInCountryCode?.Equals(other.PurchasedInCountryCode) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.RebateRate == null && other.RebateRate == null) || (this.RebateRate?.Equals(other.RebateRate) == true)) &&
                ((this.ReceiptNumber == null && other.ReceiptNumber == null) || (this.ReceiptNumber?.Equals(other.ReceiptNumber) == true)) &&
                ((this.RefundFlag == null && other.RefundFlag == null) || (this.RefundFlag?.Equals(other.RefundFlag) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.SiteGroupName == null && other.SiteGroupName == null) || (this.SiteGroupName?.Equals(other.SiteGroupName) == true)) &&
                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true)) &&
                ((this.DelCoExchangeRate == null && other.DelCoExchangeRate == null) || (this.DelCoExchangeRate?.Equals(other.DelCoExchangeRate) == true)) &&
                ((this.EuroRebateAmount == null && other.EuroRebateAmount == null) || (this.EuroRebateAmount?.Equals(other.EuroRebateAmount) == true)) &&
                ((this.NetEuroAmount == null && other.NetEuroAmount == null) || (this.NetEuroAmount?.Equals(other.NetEuroAmount) == true)) &&
                ((this.EuroVATAmount == null && other.EuroVATAmount == null) || (this.EuroVATAmount?.Equals(other.EuroVATAmount) == true)) &&
                ((this.ParentCustomerName == null && other.ParentCustomerName == null) || (this.ParentCustomerName?.Equals(other.ParentCustomerName) == true)) &&
                ((this.IsInvoiced == null && other.IsInvoiced == null) || (this.IsInvoiced?.Equals(other.IsInvoiced) == true)) &&
                ((this.TransactionCurrencyCode == null && other.TransactionCurrencyCode == null) || (this.TransactionCurrencyCode?.Equals(other.TransactionCurrencyCode) == true)) &&
                ((this.CreditDebitCode == null && other.CreditDebitCode == null) || (this.CreditDebitCode?.Equals(other.CreditDebitCode) == true)) &&
                ((this.TransactionDate == null && other.TransactionDate == null) || (this.TransactionDate?.Equals(other.TransactionDate) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.TransactionItemId == null && other.TransactionItemId == null) || (this.TransactionItemId?.Equals(other.TransactionItemId) == true)) &&
                ((this.TrnIdentifier == null && other.TrnIdentifier == null) || (this.TrnIdentifier?.Equals(other.TrnIdentifier) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.TransactionLine == null && other.TransactionLine == null) || (this.TransactionLine?.Equals(other.TransactionLine) == true)) &&
                ((this.TransactionType == null && other.TransactionType == null) || (this.TransactionType?.Equals(other.TransactionType) == true)) &&
                ((this.UTCOffset == null && other.UTCOffset == null) || (this.UTCOffset?.Equals(other.UTCOffset) == true)) &&
                ((this.VATCategory == null && other.VATCategory == null) || (this.VATCategory?.Equals(other.VATCategory) == true)) &&
                ((this.VATRate == null && other.VATRate == null) || (this.VATRate?.Equals(other.VATRate) == true)) &&
                ((this.VehicleRegistration == null && other.VehicleRegistration == null) || (this.VehicleRegistration?.Equals(other.VehicleRegistration) == true)) &&
                ((this.IsCancelled == null && other.IsCancelled == null) || (this.IsCancelled?.Equals(other.IsCancelled) == true)) &&
                ((this.ColCoGrossAmount == null && other.ColCoGrossAmount == null) || (this.ColCoGrossAmount?.Equals(other.ColCoGrossAmount) == true)) &&
                ((this.ColCoNetAmount == null && other.ColCoNetAmount == null) || (this.ColCoNetAmount?.Equals(other.ColCoNetAmount) == true)) &&
                ((this.ColCoVATAmount == null && other.ColCoVATAmount == null) || (this.ColCoVATAmount?.Equals(other.ColCoVATAmount) == true)) &&
                ((this.OriginalCurrencySymbol == null && other.OriginalCurrencySymbol == null) || (this.OriginalCurrencySymbol?.Equals(other.OriginalCurrencySymbol) == true)) &&
                ((this.OriginalCurrencyCode == null && other.OriginalCurrencyCode == null) || (this.OriginalCurrencyCode?.Equals(other.OriginalCurrencyCode) == true)) &&
                ((this.OriginalVATAmount == null && other.OriginalVATAmount == null) || (this.OriginalVATAmount?.Equals(other.OriginalVATAmount) == true)) &&
                ((this.EmbossText == null && other.EmbossText == null) || (this.EmbossText?.Equals(other.EmbossText) == true)) &&
                ((this.OriginalExchangeRate == null && other.OriginalExchangeRate == null) || (this.OriginalExchangeRate?.Equals(other.OriginalExchangeRate) == true)) &&
                ((this.OriginalTransactionItemInvoiceDate == null && other.OriginalTransactionItemInvoiceDate == null) || (this.OriginalTransactionItemInvoiceDate?.Equals(other.OriginalTransactionItemInvoiceDate) == true)) &&
                ((this.FeeTypeId == null && other.FeeTypeId == null) || (this.FeeTypeId?.Equals(other.FeeTypeId) == true)) &&
                ((this.LineItemDescription == null && other.LineItemDescription == null) || (this.LineItemDescription?.Equals(other.LineItemDescription) == true)) &&
                ((this.FeeRuleDescription == null && other.FeeRuleDescription == null) || (this.FeeRuleDescription?.Equals(other.FeeRuleDescription) == true)) &&
                ((this.Frequency == null && other.Frequency == null) || (this.Frequency?.Equals(other.Frequency) == true)) &&
                ((this.FeeRuleId == null && other.FeeRuleId == null) || (this.FeeRuleId?.Equals(other.FeeRuleId) == true)) &&
                ((this.SystemEntryDate == null && other.SystemEntryDate == null) || (this.SystemEntryDate?.Equals(other.SystemEntryDate) == true)) &&
                ((this.SystemEntryTime == null && other.SystemEntryTime == null) || (this.SystemEntryTime?.Equals(other.SystemEntryTime) == true)) &&
                ((this.IsManual == null && other.IsManual == null) || (this.IsManual?.Equals(other.IsManual) == true)) &&
                ((this.OriginalTransactionItemId == null && other.OriginalTransactionItemId == null) || (this.OriginalTransactionItemId?.Equals(other.OriginalTransactionItemId) == true)) &&
                ((this.OriginalTransactionItemInvoiceNumber == null && other.OriginalTransactionItemInvoiceNumber == null) || (this.OriginalTransactionItemInvoiceNumber?.Equals(other.OriginalTransactionItemInvoiceNumber) == true)) &&
                ((this.OriginalTransactionItemInvoiceId == null && other.OriginalTransactionItemInvoiceId == null) || (this.OriginalTransactionItemInvoiceId?.Equals(other.OriginalTransactionItemInvoiceId) == true)) &&
                ((this.PayerShortName == null && other.PayerShortName == null) || (this.PayerShortName?.Equals(other.PayerShortName) == true)) &&
                ((this.ReverseCharge == null && other.ReverseCharge == null) || (this.ReverseCharge?.Equals(other.ReverseCharge) == true)) &&
                ((this.OriginalGrossAmount == null && other.OriginalGrossAmount == null) || (this.OriginalGrossAmount?.Equals(other.OriginalGrossAmount) == true)) &&
                ((this.OriginalNetAmount == null && other.OriginalNetAmount == null) || (this.OriginalNetAmount?.Equals(other.OriginalNetAmount) == true)) &&
                ((this.UnitOfMeasure == null && other.UnitOfMeasure == null) || (this.UnitOfMeasure?.Equals(other.UnitOfMeasure) == true)) &&
                ((this.RoadType == null && other.RoadType == null) || (this.RoadType?.Equals(other.RoadType) == true)) &&
                ((this.CustomerCountryIsoCode == null && other.CustomerCountryIsoCode == null) || (this.CustomerCountryIsoCode?.Equals(other.CustomerCountryIsoCode) == true)) &&
                ((this.EVOperator == null && other.EVOperator == null) || (this.EVOperator?.Equals(other.EVOperator) == true)) &&
                ((this.EVSerialId == null && other.EVSerialId == null) || (this.EVSerialId?.Equals(other.EVSerialId) == true)) &&
                ((this.EVChargePointSerial == null && other.EVChargePointSerial == null) || (this.EVChargePointSerial?.Equals(other.EVChargePointSerial) == true)) &&
                ((this.EVChargePointConnectorType == null && other.EVChargePointConnectorType == null) || (this.EVChargePointConnectorType?.Equals(other.EVChargePointConnectorType) == true)) &&
                ((this.EVChargePointConnectorTypeDescription == null && other.EVChargePointConnectorTypeDescription == null) || (this.EVChargePointConnectorTypeDescription?.Equals(other.EVChargePointConnectorTypeDescription) == true)) &&
                ((this.EVChargeDuration == null && other.EVChargeDuration == null) || (this.EVChargeDuration?.Equals(other.EVChargeDuration) == true)) &&
                ((this.EVChargeStartDate == null && other.EVChargeStartDate == null) || (this.EVChargeStartDate?.Equals(other.EVChargeStartDate) == true)) &&
                ((this.EVChargeStartTime == null && other.EVChargeStartTime == null) || (this.EVChargeStartTime?.Equals(other.EVChargeStartTime) == true)) &&
                ((this.EVChargeEndDate == null && other.EVChargeEndDate == null) || (this.EVChargeEndDate?.Equals(other.EVChargeEndDate) == true)) &&
                ((this.EVChargeEndTime == null && other.EVChargeEndTime == null) || (this.EVChargeEndTime?.Equals(other.EVChargeEndTime) == true)) &&
                ((this.HostingCollectingCompanyNumber == null && other.HostingCollectingCompanyNumber == null) || (this.HostingCollectingCompanyNumber?.Equals(other.HostingCollectingCompanyNumber) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.FuelOnly == null && other.FuelOnly == null) || (this.FuelOnly?.Equals(other.FuelOnly) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.Additional1 = {(this.Additional1 == null ? "null" : this.Additional1)}");
            toStringOutput.Add($"this.Additional2 = {(this.Additional2 == null ? "null" : this.Additional2)}");
            toStringOutput.Add($"this.Additional3 = {(this.Additional3 == null ? "null" : this.Additional3)}");
            toStringOutput.Add($"this.Additional4 = {(this.Additional4 == null ? "null" : this.Additional4)}");
            toStringOutput.Add($"this.AllowClearing = {(this.AllowClearing == null ? "null" : this.AllowClearing)}");
            toStringOutput.Add($"this.AuthorisationCode = {(this.AuthorisationCode == null ? "null" : this.AuthorisationCode.ToString())}");
            toStringOutput.Add($"this.TransactionStatus = {(this.TransactionStatus == null ? "null" : this.TransactionStatus)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.CardExpiryPeriod = {(this.CardExpiryPeriod == null ? "null" : this.CardExpiryPeriod.ToString())}");
            toStringOutput.Add($"this.CardExpiry = {(this.CardExpiry == null ? "null" : this.CardExpiry)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.IssuerCode = {(this.IssuerCode == null ? "null" : this.IssuerCode.ToString())}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.ReleaseCode = {(this.ReleaseCode == null ? "null" : this.ReleaseCode.ToString())}");
            toStringOutput.Add($"this.CardSequenceNumber = {(this.CardSequenceNumber == null ? "null" : this.CardSequenceNumber.ToString())}");
            toStringOutput.Add($"this.CardType = {(this.CardType == null ? "null" : this.CardType)}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode)}");
            toStringOutput.Add($"this.UnitDiscountInvoiceCurrency = {(this.UnitDiscountInvoiceCurrency == null ? "null" : this.UnitDiscountInvoiceCurrency.ToString())}");
            toStringOutput.Add($"this.ColCoExchangeRate = {(this.ColCoExchangeRate == null ? "null" : this.ColCoExchangeRate.ToString())}");
            toStringOutput.Add($"this.InvoiceCurrencySymbol = {(this.InvoiceCurrencySymbol == null ? "null" : this.InvoiceCurrencySymbol)}");
            toStringOutput.Add($"this.CorrectionFlag = {(this.CorrectionFlag == null ? "null" : this.CorrectionFlag.ToString())}");
            toStringOutput.Add($"this.CRMNumber = {(this.CRMNumber == null ? "null" : this.CRMNumber.ToString())}");
            toStringOutput.Add($"this.CustomerCountry = {(this.CustomerCountry == null ? "null" : this.CustomerCountry)}");
            toStringOutput.Add($"this.CustomerCurrencyCode = {(this.CustomerCurrencyCode == null ? "null" : this.CustomerCurrencyCode)}");
            toStringOutput.Add($"this.CustomerCurrencySymbol = {(this.CustomerCurrencySymbol == null ? "null" : this.CustomerCurrencySymbol)}");
            toStringOutput.Add($"this.RebateonNetAmountInCustomerCurrency = {(this.RebateonNetAmountInCustomerCurrency == null ? "null" : this.RebateonNetAmountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.EffectiveDiscountInCustomerCurrency = {(this.EffectiveDiscountInCustomerCurrency == null ? "null" : this.EffectiveDiscountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.EffectiveUnitDiscountInCustomerCurrency = {(this.EffectiveUnitDiscountInCustomerCurrency == null ? "null" : this.EffectiveUnitDiscountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.UnitPriceInInvoiceCurrency = {(this.UnitPriceInInvoiceCurrency == null ? "null" : this.UnitPriceInInvoiceCurrency.ToString())}");
            toStringOutput.Add($"this.InvoiceTax = {(this.InvoiceTax == null ? "null" : this.InvoiceTax.ToString())}");
            toStringOutput.Add($"this.InvoiceGrossAmount = {(this.InvoiceGrossAmount == null ? "null" : this.InvoiceGrossAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceNetAmount = {(this.InvoiceNetAmount == null ? "null" : this.InvoiceNetAmount.ToString())}");
            toStringOutput.Add($"this.VATonNetAmountInCustomerCurrency = {(this.VATonNetAmountInCustomerCurrency == null ? "null" : this.VATonNetAmountInCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.CustomerRetailPriceUnitGross = {(this.CustomerRetailPriceUnitGross == null ? "null" : this.CustomerRetailPriceUnitGross.ToString())}");
            toStringOutput.Add($"this.CustomerRetailValueTotalGross = {(this.CustomerRetailValueTotalGross == null ? "null" : this.CustomerRetailValueTotalGross.ToString())}");
            toStringOutput.Add($"this.CustomerRetailValueTotalNet = {(this.CustomerRetailValueTotalNet == null ? "null" : this.CustomerRetailValueTotalNet.ToString())}");
            toStringOutput.Add($"this.TransactionTypeDescription = {(this.TransactionTypeDescription == null ? "null" : this.TransactionTypeDescription.ToString())}");
            toStringOutput.Add($"this.RebateonNetAmountInTransactionCurrency = {(this.RebateonNetAmountInTransactionCurrency == null ? "null" : this.RebateonNetAmountInTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.EffectiveDiscountInTrxCurrency = {(this.EffectiveDiscountInTrxCurrency == null ? "null" : this.EffectiveDiscountInTrxCurrency.ToString())}");
            toStringOutput.Add($"this.DelCoToColCoExchangeRate = {(this.DelCoToColCoExchangeRate == null ? "null" : this.DelCoToColCoExchangeRate.ToString())}");
            toStringOutput.Add($"this.Cards = {(this.Cards == null ? "null" : $"[{string.Join(", ", this.Cards)} ]")}");
            toStringOutput.Add($"this.UnitDiscountTransactionCurrency = {(this.UnitDiscountTransactionCurrency == null ? "null" : this.UnitDiscountTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.TransactionGrossAmount = {(this.TransactionGrossAmount == null ? "null" : this.TransactionGrossAmount.ToString())}");
            toStringOutput.Add($"this.TransactionNetAmount = {(this.TransactionNetAmount == null ? "null" : this.TransactionNetAmount.ToString())}");
            toStringOutput.Add($"this.TransactionTax = {(this.TransactionTax == null ? "null" : this.TransactionTax.ToString())}");
            toStringOutput.Add($"this.VATonNetAmount = {(this.VATonNetAmount == null ? "null" : this.VATonNetAmount.ToString())}");
            toStringOutput.Add($"this.DelcoListPriceUnitNet = {(this.DelcoListPriceUnitNet == null ? "null" : this.DelcoListPriceUnitNet.ToString())}");
            toStringOutput.Add($"this.DelcoRetailPriceUnitGross = {(this.DelcoRetailPriceUnitGross == null ? "null" : this.DelcoRetailPriceUnitGross.ToString())}");
            toStringOutput.Add($"this.UnitPriceInTransactionCurrency = {(this.UnitPriceInTransactionCurrency == null ? "null" : this.UnitPriceInTransactionCurrency.ToString())}");
            toStringOutput.Add($"this.DelcoRetailPriceUnitNet = {(this.DelcoRetailPriceUnitNet == null ? "null" : this.DelcoRetailPriceUnitNet.ToString())}");
            toStringOutput.Add($"this.DelcoRetailValueTotalGross = {(this.DelcoRetailValueTotalGross == null ? "null" : this.DelcoRetailValueTotalGross.ToString())}");
            toStringOutput.Add($"this.DelcoRetailValueTotalNet = {(this.DelcoRetailValueTotalNet == null ? "null" : this.DelcoRetailValueTotalNet.ToString())}");
            toStringOutput.Add($"this.TransactionCurrencySymbol = {(this.TransactionCurrencySymbol == null ? "null" : this.TransactionCurrencySymbol)}");
            toStringOutput.Add($"this.DiscountType = {(this.DiscountType == null ? "null" : this.DiscountType)}");
            toStringOutput.Add($"this.DisputeStatus = {(this.DisputeStatus == null ? "null" : this.DisputeStatus.ToString())}");
            toStringOutput.Add($"this.IsShellSite = {(this.IsShellSite == null ? "null" : this.IsShellSite.ToString())}");
            toStringOutput.Add($"this.FleetIdInput = {(this.FleetIdInput == null ? "null" : this.FleetIdInput)}");
            toStringOutput.Add($"this.IncomingProductCode = {(this.IncomingProductCode == null ? "null" : this.IncomingProductCode.ToString())}");
            toStringOutput.Add($"this.PostingDate = {(this.PostingDate == null ? "null" : this.PostingDate)}");
            toStringOutput.Add($"this.PostingTime = {(this.PostingTime == null ? "null" : this.PostingTime)}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode.ToString())}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductGroupId = {(this.ProductGroupId == null ? "null" : this.ProductGroupId.ToString())}");
            toStringOutput.Add($"this.IncomingCurrencyCode = {(this.IncomingCurrencyCode == null ? "null" : this.IncomingCurrencyCode)}");
            toStringOutput.Add($"this.IncomingSiteDescription = {(this.IncomingSiteDescription == null ? "null" : this.IncomingSiteDescription)}");
            toStringOutput.Add($"this.Location = {(this.Location == null ? "null" : this.Location)}");
            toStringOutput.Add($"this.SiteName = {(this.SiteName == null ? "null" : this.SiteName)}");
            toStringOutput.Add($"this.SiteCode = {(this.SiteCode == null ? "null" : this.SiteCode.ToString())}");
            toStringOutput.Add($"this.IncomingSiteNumber = {(this.IncomingSiteNumber == null ? "null" : this.IncomingSiteNumber.ToString())}");
            toStringOutput.Add($"this.InvoiceCurrencyCode = {(this.InvoiceCurrencyCode == null ? "null" : this.InvoiceCurrencyCode)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber.ToString())}");
            toStringOutput.Add($"this.FuelProduct = {(this.FuelProduct == null ? "null" : this.FuelProduct.ToString())}");
            toStringOutput.Add($"this.VATApplicable = {(this.VATApplicable == null ? "null" : this.VATApplicable)}");
            toStringOutput.Add($"this.PayerName = {(this.PayerName == null ? "null" : this.PayerName)}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.ParentCustomerNumber = {(this.ParentCustomerNumber == null ? "null" : this.ParentCustomerNumber)}");
            toStringOutput.Add($"this.PayerGroup = {(this.PayerGroup == null ? "null" : this.PayerGroup)}");
            toStringOutput.Add($"this.PayerGroupName = {(this.PayerGroupName == null ? "null" : this.PayerGroupName)}");
            toStringOutput.Add($"this.CheckDigit = {(this.CheckDigit == null ? "null" : this.CheckDigit.ToString())}");
            toStringOutput.Add($"this.NetInvoiceIndicator = {(this.NetInvoiceIndicator == null ? "null" : this.NetInvoiceIndicator)}");
            toStringOutput.Add($"this.DelcoCode = {(this.DelcoCode == null ? "null" : this.DelcoCode.ToString())}");
            toStringOutput.Add($"this.NetworkCode = {(this.NetworkCode == null ? "null" : this.NetworkCode.ToString())}");
            toStringOutput.Add($"this.PurchasedInCountry = {(this.PurchasedInCountry == null ? "null" : this.PurchasedInCountry)}");
            toStringOutput.Add($"this.SiteCountry = {(this.SiteCountry == null ? "null" : this.SiteCountry)}");
            toStringOutput.Add($"this.VATCountry = {(this.VATCountry == null ? "null" : this.VATCountry)}");
            toStringOutput.Add($"this.DelcoName = {(this.DelcoName == null ? "null" : this.DelcoName)}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network)}");
            toStringOutput.Add($"this.OdometerInput = {(this.OdometerInput == null ? "null" : this.OdometerInput.ToString())}");
            toStringOutput.Add($"this.OriginalSalesItemId = {(this.OriginalSalesItemId == null ? "null" : this.OriginalSalesItemId)}");
            toStringOutput.Add($"this.FleetIDDescription = {(this.FleetIDDescription == null ? "null" : this.FleetIDDescription)}");
            toStringOutput.Add($"this.ParentCustomerId = {(this.ParentCustomerId == null ? "null" : this.ParentCustomerId.ToString())}");
            toStringOutput.Add($"this.PINIndicator = {(this.PINIndicator == null ? "null" : this.PINIndicator)}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
            toStringOutput.Add($"this.PurchasedInCountryCode = {(this.PurchasedInCountryCode == null ? "null" : this.PurchasedInCountryCode)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.RebateRate = {(this.RebateRate == null ? "null" : this.RebateRate.ToString())}");
            toStringOutput.Add($"this.ReceiptNumber = {(this.ReceiptNumber == null ? "null" : this.ReceiptNumber.ToString())}");
            toStringOutput.Add($"this.RefundFlag = {(this.RefundFlag == null ? "null" : this.RefundFlag.ToString())}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.SiteGroupName = {(this.SiteGroupName == null ? "null" : this.SiteGroupName)}");
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude.ToString())}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude.ToString())}");
            toStringOutput.Add($"this.DelCoExchangeRate = {(this.DelCoExchangeRate == null ? "null" : this.DelCoExchangeRate.ToString())}");
            toStringOutput.Add($"this.EuroRebateAmount = {(this.EuroRebateAmount == null ? "null" : this.EuroRebateAmount.ToString())}");
            toStringOutput.Add($"this.NetEuroAmount = {(this.NetEuroAmount == null ? "null" : this.NetEuroAmount.ToString())}");
            toStringOutput.Add($"this.EuroVATAmount = {(this.EuroVATAmount == null ? "null" : this.EuroVATAmount.ToString())}");
            toStringOutput.Add($"this.ParentCustomerName = {(this.ParentCustomerName == null ? "null" : this.ParentCustomerName)}");
            toStringOutput.Add($"this.IsInvoiced = {(this.IsInvoiced == null ? "null" : this.IsInvoiced.ToString())}");
            toStringOutput.Add($"this.TransactionCurrencyCode = {(this.TransactionCurrencyCode == null ? "null" : this.TransactionCurrencyCode)}");
            toStringOutput.Add($"this.CreditDebitCode = {(this.CreditDebitCode == null ? "null" : this.CreditDebitCode)}");
            toStringOutput.Add($"this.TransactionDate = {(this.TransactionDate == null ? "null" : this.TransactionDate)}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime)}");
            toStringOutput.Add($"this.TransactionItemId = {(this.TransactionItemId == null ? "null" : this.TransactionItemId)}");
            toStringOutput.Add($"this.TrnIdentifier = {(this.TrnIdentifier == null ? "null" : this.TrnIdentifier)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.TransactionLine = {(this.TransactionLine == null ? "null" : this.TransactionLine.ToString())}");
            toStringOutput.Add($"this.TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType)}");
            toStringOutput.Add($"this.UTCOffset = {(this.UTCOffset == null ? "null" : this.UTCOffset)}");
            toStringOutput.Add($"this.VATCategory = {(this.VATCategory == null ? "null" : this.VATCategory)}");
            toStringOutput.Add($"this.VATRate = {(this.VATRate == null ? "null" : this.VATRate.ToString())}");
            toStringOutput.Add($"this.VehicleRegistration = {(this.VehicleRegistration == null ? "null" : this.VehicleRegistration)}");
            toStringOutput.Add($"this.IsCancelled = {(this.IsCancelled == null ? "null" : this.IsCancelled)}");
            toStringOutput.Add($"this.ColCoGrossAmount = {(this.ColCoGrossAmount == null ? "null" : this.ColCoGrossAmount.ToString())}");
            toStringOutput.Add($"this.ColCoNetAmount = {(this.ColCoNetAmount == null ? "null" : this.ColCoNetAmount.ToString())}");
            toStringOutput.Add($"this.ColCoVATAmount = {(this.ColCoVATAmount == null ? "null" : this.ColCoVATAmount.ToString())}");
            toStringOutput.Add($"this.OriginalCurrencySymbol = {(this.OriginalCurrencySymbol == null ? "null" : this.OriginalCurrencySymbol)}");
            toStringOutput.Add($"this.OriginalCurrencyCode = {(this.OriginalCurrencyCode == null ? "null" : this.OriginalCurrencyCode)}");
            toStringOutput.Add($"this.OriginalVATAmount = {(this.OriginalVATAmount == null ? "null" : this.OriginalVATAmount.ToString())}");
            toStringOutput.Add($"this.EmbossText = {(this.EmbossText == null ? "null" : this.EmbossText)}");
            toStringOutput.Add($"this.OriginalExchangeRate = {(this.OriginalExchangeRate == null ? "null" : this.OriginalExchangeRate.ToString())}");
            toStringOutput.Add($"this.OriginalTransactionItemInvoiceDate = {(this.OriginalTransactionItemInvoiceDate == null ? "null" : this.OriginalTransactionItemInvoiceDate)}");
            toStringOutput.Add($"this.FeeTypeId = {(this.FeeTypeId == null ? "null" : this.FeeTypeId.ToString())}");
            toStringOutput.Add($"this.LineItemDescription = {(this.LineItemDescription == null ? "null" : this.LineItemDescription.ToString())}");
            toStringOutput.Add($"this.FeeRuleDescription = {(this.FeeRuleDescription == null ? "null" : this.FeeRuleDescription)}");
            toStringOutput.Add($"this.Frequency = {(this.Frequency == null ? "null" : this.Frequency.ToString())}");
            toStringOutput.Add($"this.FeeRuleId = {(this.FeeRuleId == null ? "null" : this.FeeRuleId.ToString())}");
            toStringOutput.Add($"this.SystemEntryDate = {(this.SystemEntryDate == null ? "null" : this.SystemEntryDate)}");
            toStringOutput.Add($"this.SystemEntryTime = {(this.SystemEntryTime == null ? "null" : this.SystemEntryTime)}");
            toStringOutput.Add($"this.IsManual = {(this.IsManual == null ? "null" : this.IsManual)}");
            toStringOutput.Add($"this.OriginalTransactionItemId = {(this.OriginalTransactionItemId == null ? "null" : this.OriginalTransactionItemId)}");
            toStringOutput.Add($"this.OriginalTransactionItemInvoiceNumber = {(this.OriginalTransactionItemInvoiceNumber == null ? "null" : this.OriginalTransactionItemInvoiceNumber.ToString())}");
            toStringOutput.Add($"this.OriginalTransactionItemInvoiceId = {(this.OriginalTransactionItemInvoiceId == null ? "null" : this.OriginalTransactionItemInvoiceId.ToString())}");
            toStringOutput.Add($"this.PayerShortName = {(this.PayerShortName == null ? "null" : this.PayerShortName)}");
            toStringOutput.Add($"this.ReverseCharge = {(this.ReverseCharge == null ? "null" : this.ReverseCharge)}");
            toStringOutput.Add($"this.OriginalGrossAmount = {(this.OriginalGrossAmount == null ? "null" : this.OriginalGrossAmount.ToString())}");
            toStringOutput.Add($"this.OriginalNetAmount = {(this.OriginalNetAmount == null ? "null" : this.OriginalNetAmount.ToString())}");
            toStringOutput.Add($"this.UnitOfMeasure = {(this.UnitOfMeasure == null ? "null" : this.UnitOfMeasure)}");
            toStringOutput.Add($"this.RoadType = {(this.RoadType == null ? "null" : this.RoadType)}");
            toStringOutput.Add($"this.CustomerCountryIsoCode = {(this.CustomerCountryIsoCode == null ? "null" : this.CustomerCountryIsoCode)}");
            toStringOutput.Add($"this.EVOperator = {(this.EVOperator == null ? "null" : this.EVOperator)}");
            toStringOutput.Add($"this.EVSerialId = {(this.EVSerialId == null ? "null" : this.EVSerialId)}");
            toStringOutput.Add($"this.EVChargePointSerial = {(this.EVChargePointSerial == null ? "null" : this.EVChargePointSerial)}");
            toStringOutput.Add($"this.EVChargePointConnectorType = {(this.EVChargePointConnectorType == null ? "null" : this.EVChargePointConnectorType.ToString())}");
            toStringOutput.Add($"this.EVChargePointConnectorTypeDescription = {(this.EVChargePointConnectorTypeDescription == null ? "null" : this.EVChargePointConnectorTypeDescription)}");
            toStringOutput.Add($"this.EVChargeDuration = {(this.EVChargeDuration == null ? "null" : this.EVChargeDuration)}");
            toStringOutput.Add($"this.EVChargeStartDate = {(this.EVChargeStartDate == null ? "null" : this.EVChargeStartDate)}");
            toStringOutput.Add($"this.EVChargeStartTime = {(this.EVChargeStartTime == null ? "null" : this.EVChargeStartTime)}");
            toStringOutput.Add($"this.EVChargeEndDate = {(this.EVChargeEndDate == null ? "null" : this.EVChargeEndDate)}");
            toStringOutput.Add($"this.EVChargeEndTime = {(this.EVChargeEndTime == null ? "null" : this.EVChargeEndTime)}");
            toStringOutput.Add($"this.HostingCollectingCompanyNumber = {(this.HostingCollectingCompanyNumber == null ? "null" : this.HostingCollectingCompanyNumber.ToString())}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId.ToString())}");
            toStringOutput.Add($"this.FuelOnly = {(this.FuelOnly == null ? "null" : this.FuelOnly.ToString())}");
        }
    }
}