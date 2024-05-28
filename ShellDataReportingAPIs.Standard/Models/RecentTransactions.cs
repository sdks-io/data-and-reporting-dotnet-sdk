// <copyright file="RecentTransactions.cs" company="APIMatic">
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
    /// RecentTransactions.
    /// </summary>
    public class RecentTransactions
    {
        private int? colCoCode;
        private string payerNumber;
        private string accountNumber;
        private string cardIssueNumber;
        private string collectingCompanyCurrencyCode;
        private string custDataCustomerEntered;
        private string custDataDriverId;
        private string custDataFleetDescription;
        private string fleetIdInput;
        private double? amount;
        private string euroshellSiteNumber;
        private string incomingProductCode;
        private string productCode;
        private string productName;
        private int? siteCode;
        private string hostingCollectingCompanyName;
        private string hostingCollectingCompanyNumber;
        private string iccdataTranTypeCode;
        private string transactionType;
        private string latitude;
        private string longitude;
        private string merchantCategory;
        private string merchantCategoryDescription;
        private string purchasedInCountry;
        private string merchantId;
        private string siteName;
        private string network;
        private string delcoCode;
        private string odometerInput;
        private string odometerReadingKm;
        private string odometerReadingMiles;
        private string cardPAN;
        private string pINIndicator;
        private string pOIReceiptNumber;
        private string productsCodeAdditional;
        private string productsTaxCode;
        private double? fuelVolume;
        private string sfgwCardDateOfExpiry;
        private string siteCurrencyISOCode;
        private string cardId;
        private DateTime? transactionDate;
        private string transactionDateTime;
        private string transactionId;
        private string transactionStatus;
        private string unitOfMeasure;
        private string vehicleRegistrationNumber;
        private string networkDelcoName;
        private string productGroupName;
        private string fuelProduct;
        private string accountCustomerName;
        private string payerName;
        private string transactionTime;
        private string transactionCurrency;
        private double? unitPrice;
        private string authorisedFlag;
        private string transactionTimeGMT;
        private string reasonCode;
        private string issuerActionCode;
        private string issuerActionCodeDescription;
        private string declinedReason;
        private string cardStatusReasonDescription;
        private string transactionCountry;
        private string issuingCollectingCompanyName;
        private string cardIssuerName;
        private string driverName;
        private string bearerDescription;
        private string cardCategoryDescription;
        private string cardTypeDescription;
        private string cardTokenTypeDescription;
        private string embossType;
        private string eVPrintedNumber;
        private bool? isRFID;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoCode", false },
            { "PayerNumber", false },
            { "AccountNumber", false },
            { "CardIssueNumber", false },
            { "CollectingCompanyCurrencyCode", false },
            { "CustDataCustomerEntered", false },
            { "CustDataDriverId", false },
            { "CustDataFleetDescription", false },
            { "FleetIdInput", false },
            { "Amount", false },
            { "EuroshellSiteNumber", false },
            { "IncomingProductCode", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "SiteCode", false },
            { "HostingCollectingCompanyName", false },
            { "HostingCollectingCompanyNumber", false },
            { "IccdataTranTypeCode", false },
            { "TransactionType", false },
            { "Latitude", false },
            { "Longitude", false },
            { "MerchantCategory", false },
            { "MerchantCategoryDescription", false },
            { "PurchasedInCountry", false },
            { "MerchantId", false },
            { "SiteName", false },
            { "Network", false },
            { "DelcoCode", false },
            { "OdometerInput", false },
            { "OdometerReadingKm", false },
            { "OdometerReadingMiles", false },
            { "CardPAN", false },
            { "PINIndicator", false },
            { "POIReceiptNumber", false },
            { "ProductsCodeAdditional", false },
            { "ProductsTaxCode", false },
            { "FuelVolume", false },
            { "SfgwCardDateOfExpiry", false },
            { "SiteCurrencyISOCode", false },
            { "CardId", false },
            { "TransactionDate", false },
            { "TransactionDateTime", false },
            { "TransactionId", false },
            { "TransactionStatus", false },
            { "UnitOfMeasure", false },
            { "VehicleRegistrationNumber", false },
            { "NetworkDelcoName", false },
            { "ProductGroupName", false },
            { "FuelProduct", false },
            { "AccountCustomerName", false },
            { "PayerName", false },
            { "TransactionTime", false },
            { "TransactionCurrency", false },
            { "UnitPrice", false },
            { "AuthorisedFlag", false },
            { "TransactionTimeGMT", false },
            { "ReasonCode", false },
            { "IssuerActionCode", false },
            { "IssuerActionCodeDescription", false },
            { "DeclinedReason", false },
            { "CardStatusReasonDescription", false },
            { "TransactionCountry", false },
            { "IssuingCollectingCompanyName", false },
            { "CardIssuerName", false },
            { "DriverName", false },
            { "BearerDescription", false },
            { "CardCategoryDescription", false },
            { "CardTypeDescription", false },
            { "CardTokenTypeDescription", false },
            { "EmbossType", false },
            { "EVPrintedNumber", false },
            { "IsRFID", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RecentTransactions"/> class.
        /// </summary>
        public RecentTransactions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecentTransactions"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="cardIssueNumber">CardIssueNumber.</param>
        /// <param name="collectingCompanyCurrencyCode">CollectingCompanyCurrencyCode.</param>
        /// <param name="custDataCustomerEntered">CustDataCustomerEntered.</param>
        /// <param name="custDataDriverId">CustDataDriverId.</param>
        /// <param name="custDataFleetDescription">CustDataFleetDescription.</param>
        /// <param name="fleetIdInput">FleetIdInput.</param>
        /// <param name="amount">Amount.</param>
        /// <param name="euroshellSiteNumber">EuroshellSiteNumber.</param>
        /// <param name="incomingProductCode">IncomingProductCode.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="siteCode">SiteCode.</param>
        /// <param name="hostingCollectingCompanyName">HostingCollectingCompanyName.</param>
        /// <param name="hostingCollectingCompanyNumber">HostingCollectingCompanyNumber.</param>
        /// <param name="iccdataTranTypeCode">IccdataTranTypeCode.</param>
        /// <param name="transactionType">TransactionType.</param>
        /// <param name="latitude">Latitude.</param>
        /// <param name="longitude">Longitude.</param>
        /// <param name="merchantCategory">MerchantCategory.</param>
        /// <param name="merchantCategoryDescription">MerchantCategoryDescription.</param>
        /// <param name="purchasedInCountry">PurchasedInCountry.</param>
        /// <param name="merchantId">MerchantId.</param>
        /// <param name="siteName">SiteName.</param>
        /// <param name="network">Network.</param>
        /// <param name="delcoCode">DelcoCode.</param>
        /// <param name="odometerInput">OdometerInput.</param>
        /// <param name="odometerReadingKm">OdometerReadingKm.</param>
        /// <param name="odometerReadingMiles">OdometerReadingMiles.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="pINIndicator">PINIndicator.</param>
        /// <param name="pOIReceiptNumber">POIReceiptNumber.</param>
        /// <param name="productsCodeAdditional">ProductsCodeAdditional.</param>
        /// <param name="productsTaxCode">ProductsTaxCode.</param>
        /// <param name="fuelVolume">FuelVolume.</param>
        /// <param name="sfgwCardDateOfExpiry">SfgwCardDateOfExpiry.</param>
        /// <param name="siteCurrencyISOCode">SiteCurrencyISOCode.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="transactionDate">TransactionDate.</param>
        /// <param name="transactionDateTime">TransactionDateTime.</param>
        /// <param name="transactionId">TransactionId.</param>
        /// <param name="transactionStatus">TransactionStatus.</param>
        /// <param name="unitOfMeasure">UnitOfMeasure.</param>
        /// <param name="vehicleRegistrationNumber">VehicleRegistrationNumber.</param>
        /// <param name="networkDelcoName">NetworkDelcoName.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="fuelProduct">FuelProduct.</param>
        /// <param name="accountCustomerName">AccountCustomerName.</param>
        /// <param name="payerName">PayerName.</param>
        /// <param name="transactionTime">TransactionTime.</param>
        /// <param name="transactionCurrency">TransactionCurrency.</param>
        /// <param name="unitPrice">UnitPrice.</param>
        /// <param name="authorisedFlag">AuthorisedFlag.</param>
        /// <param name="transactionTimeGMT">TransactionTimeGMT.</param>
        /// <param name="reasonCode">ReasonCode.</param>
        /// <param name="issuerActionCode">IssuerActionCode.</param>
        /// <param name="issuerActionCodeDescription">IssuerActionCodeDescription.</param>
        /// <param name="declinedReason">DeclinedReason.</param>
        /// <param name="cardStatusReasonDescription">CardStatusReasonDescription.</param>
        /// <param name="transactionCountry">TransactionCountry.</param>
        /// <param name="issuingCollectingCompanyName">IssuingCollectingCompanyName.</param>
        /// <param name="cardIssuerName">CardIssuerName.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="bearerDescription">BearerDescription.</param>
        /// <param name="cardCategoryDescription">CardCategoryDescription.</param>
        /// <param name="cardTypeDescription">CardTypeDescription.</param>
        /// <param name="cardTokenTypeDescription">CardTokenTypeDescription.</param>
        /// <param name="embossType">EmbossType.</param>
        /// <param name="eVPrintedNumber">EVPrintedNumber.</param>
        /// <param name="isRFID">IsRFID.</param>
        public RecentTransactions(
            int? colCoCode = null,
            string payerNumber = null,
            string accountNumber = null,
            string cardIssueNumber = null,
            string collectingCompanyCurrencyCode = null,
            string custDataCustomerEntered = null,
            string custDataDriverId = null,
            string custDataFleetDescription = null,
            string fleetIdInput = null,
            double? amount = null,
            string euroshellSiteNumber = null,
            string incomingProductCode = null,
            string productCode = null,
            string productName = null,
            int? siteCode = null,
            string hostingCollectingCompanyName = null,
            string hostingCollectingCompanyNumber = null,
            string iccdataTranTypeCode = null,
            string transactionType = null,
            string latitude = null,
            string longitude = null,
            string merchantCategory = null,
            string merchantCategoryDescription = null,
            string purchasedInCountry = null,
            string merchantId = null,
            string siteName = null,
            string network = null,
            string delcoCode = null,
            string odometerInput = null,
            string odometerReadingKm = null,
            string odometerReadingMiles = null,
            string cardPAN = null,
            string pINIndicator = null,
            string pOIReceiptNumber = null,
            string productsCodeAdditional = null,
            string productsTaxCode = null,
            double? fuelVolume = null,
            string sfgwCardDateOfExpiry = null,
            string siteCurrencyISOCode = null,
            string cardId = null,
            DateTime? transactionDate = null,
            string transactionDateTime = null,
            string transactionId = null,
            string transactionStatus = null,
            string unitOfMeasure = null,
            string vehicleRegistrationNumber = null,
            string networkDelcoName = null,
            string productGroupName = null,
            string fuelProduct = null,
            string accountCustomerName = null,
            string payerName = null,
            string transactionTime = null,
            string transactionCurrency = null,
            double? unitPrice = null,
            string authorisedFlag = null,
            string transactionTimeGMT = null,
            string reasonCode = null,
            string issuerActionCode = null,
            string issuerActionCodeDescription = null,
            string declinedReason = null,
            string cardStatusReasonDescription = null,
            string transactionCountry = null,
            string issuingCollectingCompanyName = null,
            string cardIssuerName = null,
            string driverName = null,
            string bearerDescription = null,
            string cardCategoryDescription = null,
            string cardTypeDescription = null,
            string cardTokenTypeDescription = null,
            string embossType = null,
            string eVPrintedNumber = null,
            bool? isRFID = null)
        {
            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (cardIssueNumber != null)
            {
                this.CardIssueNumber = cardIssueNumber;
            }

            if (collectingCompanyCurrencyCode != null)
            {
                this.CollectingCompanyCurrencyCode = collectingCompanyCurrencyCode;
            }

            if (custDataCustomerEntered != null)
            {
                this.CustDataCustomerEntered = custDataCustomerEntered;
            }

            if (custDataDriverId != null)
            {
                this.CustDataDriverId = custDataDriverId;
            }

            if (custDataFleetDescription != null)
            {
                this.CustDataFleetDescription = custDataFleetDescription;
            }

            if (fleetIdInput != null)
            {
                this.FleetIdInput = fleetIdInput;
            }

            if (amount != null)
            {
                this.Amount = amount;
            }

            if (euroshellSiteNumber != null)
            {
                this.EuroshellSiteNumber = euroshellSiteNumber;
            }

            if (incomingProductCode != null)
            {
                this.IncomingProductCode = incomingProductCode;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (productName != null)
            {
                this.ProductName = productName;
            }

            if (siteCode != null)
            {
                this.SiteCode = siteCode;
            }

            if (hostingCollectingCompanyName != null)
            {
                this.HostingCollectingCompanyName = hostingCollectingCompanyName;
            }

            if (hostingCollectingCompanyNumber != null)
            {
                this.HostingCollectingCompanyNumber = hostingCollectingCompanyNumber;
            }

            if (iccdataTranTypeCode != null)
            {
                this.IccdataTranTypeCode = iccdataTranTypeCode;
            }

            if (transactionType != null)
            {
                this.TransactionType = transactionType;
            }

            if (latitude != null)
            {
                this.Latitude = latitude;
            }

            if (longitude != null)
            {
                this.Longitude = longitude;
            }

            if (merchantCategory != null)
            {
                this.MerchantCategory = merchantCategory;
            }

            if (merchantCategoryDescription != null)
            {
                this.MerchantCategoryDescription = merchantCategoryDescription;
            }

            if (purchasedInCountry != null)
            {
                this.PurchasedInCountry = purchasedInCountry;
            }

            if (merchantId != null)
            {
                this.MerchantId = merchantId;
            }

            if (siteName != null)
            {
                this.SiteName = siteName;
            }

            if (network != null)
            {
                this.Network = network;
            }

            if (delcoCode != null)
            {
                this.DelcoCode = delcoCode;
            }

            if (odometerInput != null)
            {
                this.OdometerInput = odometerInput;
            }

            if (odometerReadingKm != null)
            {
                this.OdometerReadingKm = odometerReadingKm;
            }

            if (odometerReadingMiles != null)
            {
                this.OdometerReadingMiles = odometerReadingMiles;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (pINIndicator != null)
            {
                this.PINIndicator = pINIndicator;
            }

            if (pOIReceiptNumber != null)
            {
                this.POIReceiptNumber = pOIReceiptNumber;
            }

            if (productsCodeAdditional != null)
            {
                this.ProductsCodeAdditional = productsCodeAdditional;
            }

            if (productsTaxCode != null)
            {
                this.ProductsTaxCode = productsTaxCode;
            }

            if (fuelVolume != null)
            {
                this.FuelVolume = fuelVolume;
            }

            if (sfgwCardDateOfExpiry != null)
            {
                this.SfgwCardDateOfExpiry = sfgwCardDateOfExpiry;
            }

            if (siteCurrencyISOCode != null)
            {
                this.SiteCurrencyISOCode = siteCurrencyISOCode;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (transactionDate != null)
            {
                this.TransactionDate = transactionDate;
            }

            if (transactionDateTime != null)
            {
                this.TransactionDateTime = transactionDateTime;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

            if (transactionStatus != null)
            {
                this.TransactionStatus = transactionStatus;
            }

            if (unitOfMeasure != null)
            {
                this.UnitOfMeasure = unitOfMeasure;
            }

            if (vehicleRegistrationNumber != null)
            {
                this.VehicleRegistrationNumber = vehicleRegistrationNumber;
            }

            if (networkDelcoName != null)
            {
                this.NetworkDelcoName = networkDelcoName;
            }

            if (productGroupName != null)
            {
                this.ProductGroupName = productGroupName;
            }

            if (fuelProduct != null)
            {
                this.FuelProduct = fuelProduct;
            }

            if (accountCustomerName != null)
            {
                this.AccountCustomerName = accountCustomerName;
            }

            if (payerName != null)
            {
                this.PayerName = payerName;
            }

            if (transactionTime != null)
            {
                this.TransactionTime = transactionTime;
            }

            if (transactionCurrency != null)
            {
                this.TransactionCurrency = transactionCurrency;
            }

            if (unitPrice != null)
            {
                this.UnitPrice = unitPrice;
            }

            if (authorisedFlag != null)
            {
                this.AuthorisedFlag = authorisedFlag;
            }

            if (transactionTimeGMT != null)
            {
                this.TransactionTimeGMT = transactionTimeGMT;
            }

            if (reasonCode != null)
            {
                this.ReasonCode = reasonCode;
            }

            if (issuerActionCode != null)
            {
                this.IssuerActionCode = issuerActionCode;
            }

            if (issuerActionCodeDescription != null)
            {
                this.IssuerActionCodeDescription = issuerActionCodeDescription;
            }

            if (declinedReason != null)
            {
                this.DeclinedReason = declinedReason;
            }

            if (cardStatusReasonDescription != null)
            {
                this.CardStatusReasonDescription = cardStatusReasonDescription;
            }

            if (transactionCountry != null)
            {
                this.TransactionCountry = transactionCountry;
            }

            if (issuingCollectingCompanyName != null)
            {
                this.IssuingCollectingCompanyName = issuingCollectingCompanyName;
            }

            if (cardIssuerName != null)
            {
                this.CardIssuerName = cardIssuerName;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (bearerDescription != null)
            {
                this.BearerDescription = bearerDescription;
            }

            if (cardCategoryDescription != null)
            {
                this.CardCategoryDescription = cardCategoryDescription;
            }

            if (cardTypeDescription != null)
            {
                this.CardTypeDescription = cardTypeDescription;
            }

            if (cardTokenTypeDescription != null)
            {
                this.CardTokenTypeDescription = cardTokenTypeDescription;
            }

            if (embossType != null)
            {
                this.EmbossType = embossType;
            }

            if (eVPrintedNumber != null)
            {
                this.EVPrintedNumber = eVPrintedNumber;
            }

            if (isRFID != null)
            {
                this.IsRFID = isRFID;
            }

        }

        /// <summary>
        /// ColCoCode
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
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
        /// PayerNumber
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
        /// Card Issue Number
        /// </summary>
        [JsonProperty("CardIssueNumber")]
        public string CardIssueNumber
        {
            get
            {
                return this.cardIssueNumber;
            }

            set
            {
                this.shouldSerialize["CardIssueNumber"] = true;
                this.cardIssueNumber = value;
            }
        }

        /// <summary>
        /// Collecting Company Currency IsoCode
        /// </summary>
        [JsonProperty("CollectingCompanyCurrencyCode")]
        public string CollectingCompanyCurrencyCode
        {
            get
            {
                return this.collectingCompanyCurrencyCode;
            }

            set
            {
                this.shouldSerialize["CollectingCompanyCurrencyCode"] = true;
                this.collectingCompanyCurrencyCode = value;
            }
        }

        /// <summary>
        /// Customer entered data for reference.
        /// </summary>
        [JsonProperty("CustDataCustomerEntered")]
        public string CustDataCustomerEntered
        {
            get
            {
                return this.custDataCustomerEntered;
            }

            set
            {
                this.shouldSerialize["CustDataCustomerEntered"] = true;
                this.custDataCustomerEntered = value;
            }
        }

        /// <summary>
        /// Customer Data DriverId
        /// </summary>
        [JsonProperty("CustDataDriverId")]
        public string CustDataDriverId
        {
            get
            {
                return this.custDataDriverId;
            }

            set
            {
                this.shouldSerialize["CustDataDriverId"] = true;
                this.custDataDriverId = value;
            }
        }

        /// <summary>
        /// Cust Data Fleet Description
        /// </summary>
        [JsonProperty("CustDataFleetDescription")]
        public string CustDataFleetDescription
        {
            get
            {
                return this.custDataFleetDescription;
            }

            set
            {
                this.shouldSerialize["CustDataFleetDescription"] = true;
                this.custDataFleetDescription = value;
            }
        }

        /// <summary>
        /// Fleet Id Input
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
        /// Amount
        /// </summary>
        [JsonProperty("Amount")]
        public double? Amount
        {
            get
            {
                return this.amount;
            }

            set
            {
                this.shouldSerialize["Amount"] = true;
                this.amount = value;
            }
        }

        /// <summary>
        /// EuroshellSiteNumber
        /// </summary>
        [JsonProperty("EuroshellSiteNumber")]
        public string EuroshellSiteNumber
        {
            get
            {
                return this.euroshellSiteNumber;
            }

            set
            {
                this.shouldSerialize["EuroshellSiteNumber"] = true;
                this.euroshellSiteNumber = value;
            }
        }

        /// <summary>
        /// IncomingProductCode
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
        /// ProductCode
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
        /// ProductName
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
        /// SiteCode
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
        /// HostingCollectingCompanyName
        /// </summary>
        [JsonProperty("HostingCollectingCompanyName")]
        public string HostingCollectingCompanyName
        {
            get
            {
                return this.hostingCollectingCompanyName;
            }

            set
            {
                this.shouldSerialize["HostingCollectingCompanyName"] = true;
                this.hostingCollectingCompanyName = value;
            }
        }

        /// <summary>
        /// HostingCollectingCompanyNumber
        /// </summary>
        [JsonProperty("HostingCollectingCompanyNumber")]
        public string HostingCollectingCompanyNumber
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
        /// Transaction type code
        /// </summary>
        [JsonProperty("IccdataTranTypeCode")]
        public string IccdataTranTypeCode
        {
            get
            {
                return this.iccdataTranTypeCode;
            }

            set
            {
                this.shouldSerialize["IccdataTranTypeCode"] = true;
                this.iccdataTranTypeCode = value;
            }
        }

        /// <summary>
        /// Transaction type description.
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
        /// Latitude of the Coordinate 3.11573
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude
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
        /// Longitude of the Coordinate
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude
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
        /// Merchant category
        /// </summary>
        [JsonProperty("MerchantCategory")]
        public string MerchantCategory
        {
            get
            {
                return this.merchantCategory;
            }

            set
            {
                this.shouldSerialize["MerchantCategory"] = true;
                this.merchantCategory = value;
            }
        }

        /// <summary>
        /// Merchant category description
        /// </summary>
        [JsonProperty("MerchantCategoryDescription")]
        public string MerchantCategoryDescription
        {
            get
            {
                return this.merchantCategoryDescription;
            }

            set
            {
                this.shouldSerialize["MerchantCategoryDescription"] = true;
                this.merchantCategoryDescription = value;
            }
        }

        /// <summary>
        /// Purchased in country
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
        /// Merchant Id
        /// </summary>
        [JsonProperty("MerchantId")]
        public string MerchantId
        {
            get
            {
                return this.merchantId;
            }

            set
            {
                this.shouldSerialize["MerchantId"] = true;
                this.merchantId = value;
            }
        }

        /// <summary>
        /// Site name
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
        /// Network
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
        /// Three character DelcoCode
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
        /// Odometer input
        /// </summary>
        [JsonProperty("OdometerInput")]
        public string OdometerInput
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
        /// Odometer reading in Kms
        /// </summary>
        [JsonProperty("OdometerReadingKm")]
        public string OdometerReadingKm
        {
            get
            {
                return this.odometerReadingKm;
            }

            set
            {
                this.shouldSerialize["OdometerReadingKm"] = true;
                this.odometerReadingKm = value;
            }
        }

        /// <summary>
        /// Odometer reading in miles
        /// </summary>
        [JsonProperty("OdometerReadingMiles")]
        public string OdometerReadingMiles
        {
            get
            {
                return this.odometerReadingMiles;
            }

            set
            {
                this.shouldSerialize["OdometerReadingMiles"] = true;
                this.odometerReadingMiles = value;
            }
        }

        /// <summary>
        /// Masked Card PAN
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
        /// POIReceiptNumber
        /// </summary>
        [JsonProperty("POIReceiptNumber")]
        public string POIReceiptNumber
        {
            get
            {
                return this.pOIReceiptNumber;
            }

            set
            {
                this.shouldSerialize["POIReceiptNumber"] = true;
                this.pOIReceiptNumber = value;
            }
        }

        /// <summary>
        /// Additinal Products Code
        /// </summary>
        [JsonProperty("ProductsCodeAdditional")]
        public string ProductsCodeAdditional
        {
            get
            {
                return this.productsCodeAdditional;
            }

            set
            {
                this.shouldSerialize["ProductsCodeAdditional"] = true;
                this.productsCodeAdditional = value;
            }
        }

        /// <summary>
        /// Products tax code
        /// </summary>
        [JsonProperty("ProductsTaxCode")]
        public string ProductsTaxCode
        {
            get
            {
                return this.productsTaxCode;
            }

            set
            {
                this.shouldSerialize["ProductsTaxCode"] = true;
                this.productsTaxCode = value;
            }
        }

        /// <summary>
        /// Fuel volume
        /// </summary>
        [JsonProperty("FuelVolume")]
        public double? FuelVolume
        {
            get
            {
                return this.fuelVolume;
            }

            set
            {
                this.shouldSerialize["FuelVolume"] = true;
                this.fuelVolume = value;
            }
        }

        /// <summary>
        /// SfgwCard expiry date
        /// </summary>
        [JsonProperty("SfgwCardDateOfExpiry")]
        public string SfgwCardDateOfExpiry
        {
            get
            {
                return this.sfgwCardDateOfExpiry;
            }

            set
            {
                this.shouldSerialize["SfgwCardDateOfExpiry"] = true;
                this.sfgwCardDateOfExpiry = value;
            }
        }

        /// <summary>
        /// Three character Site currency ISO code
        /// </summary>
        [JsonProperty("SiteCurrencyISOCode")]
        public string SiteCurrencyISOCode
        {
            get
            {
                return this.siteCurrencyISOCode;
            }

            set
            {
                this.shouldSerialize["SiteCurrencyISOCode"] = true;
                this.siteCurrencyISOCode = value;
            }
        }

        /// <summary>
        /// Card ID
        /// </summary>
        [JsonProperty("CardId")]
        public string CardId
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
        /// ISO8601-compliant UTC datetime of the last update of the EVSE
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("TransactionDate")]
        public DateTime? TransactionDate
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
        /// ISO8601-compliant UTC datetime of the last update of the EVSE
        /// </summary>
        [JsonProperty("TransactionDateTime")]
        public string TransactionDateTime
        {
            get
            {
                return this.transactionDateTime;
            }

            set
            {
                this.shouldSerialize["TransactionDateTime"] = true;
                this.transactionDateTime = value;
            }
        }

        /// <summary>
        /// TransactionId
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
        /// Type of the connector in the EVSE unit.
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
        /// VehicleRegistrationNumber
        /// </summary>
        [JsonProperty("VehicleRegistrationNumber")]
        public string VehicleRegistrationNumber
        {
            get
            {
                return this.vehicleRegistrationNumber;
            }

            set
            {
                this.shouldSerialize["VehicleRegistrationNumber"] = true;
                this.vehicleRegistrationNumber = value;
            }
        }

        /// <summary>
        /// Network Delco name
        /// </summary>
        [JsonProperty("NetworkDelcoName")]
        public string NetworkDelcoName
        {
            get
            {
                return this.networkDelcoName;
            }

            set
            {
                this.shouldSerialize["NetworkDelcoName"] = true;
                this.networkDelcoName = value;
            }
        }

        /// <summary>
        /// ProductGroupName
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
        /// FuelProduct
        /// </summary>
        [JsonProperty("FuelProduct")]
        public string FuelProduct
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
        /// AccountCustomerName
        /// </summary>
        [JsonProperty("AccountCustomerName")]
        public string AccountCustomerName
        {
            get
            {
                return this.accountCustomerName;
            }

            set
            {
                this.shouldSerialize["AccountCustomerName"] = true;
                this.accountCustomerName = value;
            }
        }

        /// <summary>
        /// PayerName
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
        /// ISO8601-compliant UTC datetime of the last update of the EVSE
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
        /// TransactionCurrencySymbol
        /// </summary>
        [JsonProperty("TransactionCurrency")]
        public string TransactionCurrency
        {
            get
            {
                return this.transactionCurrency;
            }

            set
            {
                this.shouldSerialize["TransactionCurrency"] = true;
                this.transactionCurrency = value;
            }
        }

        /// <summary>
        /// UnitPrice
        /// </summary>
        [JsonProperty("UnitPrice")]
        public double? UnitPrice
        {
            get
            {
                return this.unitPrice;
            }

            set
            {
                this.shouldSerialize["UnitPrice"] = true;
                this.unitPrice = value;
            }
        }

        /// <summary>
        /// AuthorisedFlag
        /// </summary>
        [JsonProperty("AuthorisedFlag")]
        public string AuthorisedFlag
        {
            get
            {
                return this.authorisedFlag;
            }

            set
            {
                this.shouldSerialize["AuthorisedFlag"] = true;
                this.authorisedFlag = value;
            }
        }

        /// <summary>
        /// TransactionTimeGMT update of the EVSE
        /// </summary>
        [JsonProperty("TransactionTimeGMT")]
        public string TransactionTimeGMT
        {
            get
            {
                return this.transactionTimeGMT;
            }

            set
            {
                this.shouldSerialize["TransactionTimeGMT"] = true;
                this.transactionTimeGMT = value;
            }
        }

        /// <summary>
        /// ReasonCode
        /// </summary>
        [JsonProperty("ReasonCode")]
        public string ReasonCode
        {
            get
            {
                return this.reasonCode;
            }

            set
            {
                this.shouldSerialize["ReasonCode"] = true;
                this.reasonCode = value;
            }
        }

        /// <summary>
        /// IssuerActionCode
        /// </summary>
        [JsonProperty("IssuerActionCode")]
        public string IssuerActionCode
        {
            get
            {
                return this.issuerActionCode;
            }

            set
            {
                this.shouldSerialize["IssuerActionCode"] = true;
                this.issuerActionCode = value;
            }
        }

        /// <summary>
        /// IssuerActionCodeDescription.
        /// </summary>
        [JsonProperty("IssuerActionCodeDescription")]
        public string IssuerActionCodeDescription
        {
            get
            {
                return this.issuerActionCodeDescription;
            }

            set
            {
                this.shouldSerialize["IssuerActionCodeDescription"] = true;
                this.issuerActionCodeDescription = value;
            }
        }

        /// <summary>
        /// DeclinedReason.
        /// </summary>
        [JsonProperty("DeclinedReason")]
        public string DeclinedReason
        {
            get
            {
                return this.declinedReason;
            }

            set
            {
                this.shouldSerialize["DeclinedReason"] = true;
                this.declinedReason = value;
            }
        }

        /// <summary>
        /// CardStatusReasonDescription.
        /// </summary>
        [JsonProperty("CardStatusReasonDescription")]
        public string CardStatusReasonDescription
        {
            get
            {
                return this.cardStatusReasonDescription;
            }

            set
            {
                this.shouldSerialize["CardStatusReasonDescription"] = true;
                this.cardStatusReasonDescription = value;
            }
        }

        /// <summary>
        /// TransactionCountry
        /// </summary>
        [JsonProperty("TransactionCountry")]
        public string TransactionCountry
        {
            get
            {
                return this.transactionCountry;
            }

            set
            {
                this.shouldSerialize["TransactionCountry"] = true;
                this.transactionCountry = value;
            }
        }

        /// <summary>
        /// IssuingCollectingCompanyName.
        /// </summary>
        [JsonProperty("IssuingCollectingCompanyName")]
        public string IssuingCollectingCompanyName
        {
            get
            {
                return this.issuingCollectingCompanyName;
            }

            set
            {
                this.shouldSerialize["IssuingCollectingCompanyName"] = true;
                this.issuingCollectingCompanyName = value;
            }
        }

        /// <summary>
        /// CardIssuerName.
        /// </summary>
        [JsonProperty("CardIssuerName")]
        public string CardIssuerName
        {
            get
            {
                return this.cardIssuerName;
            }

            set
            {
                this.shouldSerialize["CardIssuerName"] = true;
                this.cardIssuerName = value;
            }
        }

        /// <summary>
        /// DriverName.
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
        /// BearerDescription.
        /// </summary>
        [JsonProperty("BearerDescription")]
        public string BearerDescription
        {
            get
            {
                return this.bearerDescription;
            }

            set
            {
                this.shouldSerialize["BearerDescription"] = true;
                this.bearerDescription = value;
            }
        }

        /// <summary>
        /// CardCategoryDescription.
        /// </summary>
        [JsonProperty("CardCategoryDescription")]
        public string CardCategoryDescription
        {
            get
            {
                return this.cardCategoryDescription;
            }

            set
            {
                this.shouldSerialize["CardCategoryDescription"] = true;
                this.cardCategoryDescription = value;
            }
        }

        /// <summary>
        /// CardTypeDescription.
        /// </summary>
        [JsonProperty("CardTypeDescription")]
        public string CardTypeDescription
        {
            get
            {
                return this.cardTypeDescription;
            }

            set
            {
                this.shouldSerialize["CardTypeDescription"] = true;
                this.cardTypeDescription = value;
            }
        }

        /// <summary>
        /// CardTokenTypeDescription.
        /// </summary>
        [JsonProperty("CardTokenTypeDescription")]
        public string CardTokenTypeDescription
        {
            get
            {
                return this.cardTokenTypeDescription;
            }

            set
            {
                this.shouldSerialize["CardTokenTypeDescription"] = true;
                this.cardTokenTypeDescription = value;
            }
        }

        /// <summary>
        /// EmbossType.
        /// </summary>
        [JsonProperty("EmbossType")]
        public string EmbossType
        {
            get
            {
                return this.embossType;
            }

            set
            {
                this.shouldSerialize["EmbossType"] = true;
                this.embossType = value;
            }
        }

        /// <summary>
        /// The EVPrintedNumber which can be found on the Shell EV Card
        /// </summary>
        [JsonProperty("EVPrintedNumber")]
        public string EVPrintedNumber
        {
            get
            {
                return this.eVPrintedNumber;
            }

            set
            {
                this.shouldSerialize["EVPrintedNumber"] = true;
                this.eVPrintedNumber = value;
            }
        }

        /// <summary>
        /// Whether the card type is enabled for RFID (Radio Frequency Identification)
        /// </summary>
        [JsonProperty("IsRFID")]
        public bool? IsRFID
        {
            get
            {
                return this.isRFID;
            }

            set
            {
                this.shouldSerialize["IsRFID"] = true;
                this.isRFID = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RecentTransactions : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
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
        public void UnsetCardIssueNumber()
        {
            this.shouldSerialize["CardIssueNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCollectingCompanyCurrencyCode()
        {
            this.shouldSerialize["CollectingCompanyCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustDataCustomerEntered()
        {
            this.shouldSerialize["CustDataCustomerEntered"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustDataDriverId()
        {
            this.shouldSerialize["CustDataDriverId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustDataFleetDescription()
        {
            this.shouldSerialize["CustDataFleetDescription"] = false;
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
        public void UnsetAmount()
        {
            this.shouldSerialize["Amount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEuroshellSiteNumber()
        {
            this.shouldSerialize["EuroshellSiteNumber"] = false;
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
        public void UnsetSiteCode()
        {
            this.shouldSerialize["SiteCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHostingCollectingCompanyName()
        {
            this.shouldSerialize["HostingCollectingCompanyName"] = false;
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
        public void UnsetIccdataTranTypeCode()
        {
            this.shouldSerialize["IccdataTranTypeCode"] = false;
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
        public void UnsetMerchantCategory()
        {
            this.shouldSerialize["MerchantCategory"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMerchantCategoryDescription()
        {
            this.shouldSerialize["MerchantCategoryDescription"] = false;
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
        public void UnsetMerchantId()
        {
            this.shouldSerialize["MerchantId"] = false;
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
        public void UnsetNetwork()
        {
            this.shouldSerialize["Network"] = false;
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
        public void UnsetOdometerInput()
        {
            this.shouldSerialize["OdometerInput"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOdometerReadingKm()
        {
            this.shouldSerialize["OdometerReadingKm"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetOdometerReadingMiles()
        {
            this.shouldSerialize["OdometerReadingMiles"] = false;
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
        public void UnsetPINIndicator()
        {
            this.shouldSerialize["PINIndicator"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPOIReceiptNumber()
        {
            this.shouldSerialize["POIReceiptNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductsCodeAdditional()
        {
            this.shouldSerialize["ProductsCodeAdditional"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductsTaxCode()
        {
            this.shouldSerialize["ProductsTaxCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelVolume()
        {
            this.shouldSerialize["FuelVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSfgwCardDateOfExpiry()
        {
            this.shouldSerialize["SfgwCardDateOfExpiry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteCurrencyISOCode()
        {
            this.shouldSerialize["SiteCurrencyISOCode"] = false;
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
        public void UnsetTransactionDate()
        {
            this.shouldSerialize["TransactionDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionDateTime()
        {
            this.shouldSerialize["TransactionDateTime"] = false;
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
        public void UnsetTransactionStatus()
        {
            this.shouldSerialize["TransactionStatus"] = false;
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
        public void UnsetVehicleRegistrationNumber()
        {
            this.shouldSerialize["VehicleRegistrationNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetworkDelcoName()
        {
            this.shouldSerialize["NetworkDelcoName"] = false;
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
        public void UnsetFuelProduct()
        {
            this.shouldSerialize["FuelProduct"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountCustomerName()
        {
            this.shouldSerialize["AccountCustomerName"] = false;
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
        public void UnsetTransactionTime()
        {
            this.shouldSerialize["TransactionTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionCurrency()
        {
            this.shouldSerialize["TransactionCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUnitPrice()
        {
            this.shouldSerialize["UnitPrice"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAuthorisedFlag()
        {
            this.shouldSerialize["AuthorisedFlag"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionTimeGMT()
        {
            this.shouldSerialize["TransactionTimeGMT"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReasonCode()
        {
            this.shouldSerialize["ReasonCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuerActionCode()
        {
            this.shouldSerialize["IssuerActionCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuerActionCodeDescription()
        {
            this.shouldSerialize["IssuerActionCodeDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDeclinedReason()
        {
            this.shouldSerialize["DeclinedReason"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardStatusReasonDescription()
        {
            this.shouldSerialize["CardStatusReasonDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionCountry()
        {
            this.shouldSerialize["TransactionCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuingCollectingCompanyName()
        {
            this.shouldSerialize["IssuingCollectingCompanyName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardIssuerName()
        {
            this.shouldSerialize["CardIssuerName"] = false;
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
        public void UnsetBearerDescription()
        {
            this.shouldSerialize["BearerDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardCategoryDescription()
        {
            this.shouldSerialize["CardCategoryDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardTypeDescription()
        {
            this.shouldSerialize["CardTypeDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardTokenTypeDescription()
        {
            this.shouldSerialize["CardTokenTypeDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEmbossType()
        {
            this.shouldSerialize["EmbossType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEVPrintedNumber()
        {
            this.shouldSerialize["EVPrintedNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsRFID()
        {
            this.shouldSerialize["IsRFID"] = false;
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
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
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
        public bool ShouldSerializeCardIssueNumber()
        {
            return this.shouldSerialize["CardIssueNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCollectingCompanyCurrencyCode()
        {
            return this.shouldSerialize["CollectingCompanyCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustDataCustomerEntered()
        {
            return this.shouldSerialize["CustDataCustomerEntered"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustDataDriverId()
        {
            return this.shouldSerialize["CustDataDriverId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustDataFleetDescription()
        {
            return this.shouldSerialize["CustDataFleetDescription"];
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
        public bool ShouldSerializeAmount()
        {
            return this.shouldSerialize["Amount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEuroshellSiteNumber()
        {
            return this.shouldSerialize["EuroshellSiteNumber"];
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
        public bool ShouldSerializeSiteCode()
        {
            return this.shouldSerialize["SiteCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHostingCollectingCompanyName()
        {
            return this.shouldSerialize["HostingCollectingCompanyName"];
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
        public bool ShouldSerializeIccdataTranTypeCode()
        {
            return this.shouldSerialize["IccdataTranTypeCode"];
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
        public bool ShouldSerializeMerchantCategory()
        {
            return this.shouldSerialize["MerchantCategory"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMerchantCategoryDescription()
        {
            return this.shouldSerialize["MerchantCategoryDescription"];
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
        public bool ShouldSerializeMerchantId()
        {
            return this.shouldSerialize["MerchantId"];
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
        public bool ShouldSerializeNetwork()
        {
            return this.shouldSerialize["Network"];
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
        public bool ShouldSerializeOdometerInput()
        {
            return this.shouldSerialize["OdometerInput"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOdometerReadingKm()
        {
            return this.shouldSerialize["OdometerReadingKm"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeOdometerReadingMiles()
        {
            return this.shouldSerialize["OdometerReadingMiles"];
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
        public bool ShouldSerializePINIndicator()
        {
            return this.shouldSerialize["PINIndicator"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePOIReceiptNumber()
        {
            return this.shouldSerialize["POIReceiptNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductsCodeAdditional()
        {
            return this.shouldSerialize["ProductsCodeAdditional"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductsTaxCode()
        {
            return this.shouldSerialize["ProductsTaxCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelVolume()
        {
            return this.shouldSerialize["FuelVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSfgwCardDateOfExpiry()
        {
            return this.shouldSerialize["SfgwCardDateOfExpiry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteCurrencyISOCode()
        {
            return this.shouldSerialize["SiteCurrencyISOCode"];
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
        public bool ShouldSerializeTransactionDate()
        {
            return this.shouldSerialize["TransactionDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionDateTime()
        {
            return this.shouldSerialize["TransactionDateTime"];
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
        public bool ShouldSerializeTransactionStatus()
        {
            return this.shouldSerialize["TransactionStatus"];
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
        public bool ShouldSerializeVehicleRegistrationNumber()
        {
            return this.shouldSerialize["VehicleRegistrationNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetworkDelcoName()
        {
            return this.shouldSerialize["NetworkDelcoName"];
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
        public bool ShouldSerializeFuelProduct()
        {
            return this.shouldSerialize["FuelProduct"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountCustomerName()
        {
            return this.shouldSerialize["AccountCustomerName"];
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
        public bool ShouldSerializeTransactionTime()
        {
            return this.shouldSerialize["TransactionTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionCurrency()
        {
            return this.shouldSerialize["TransactionCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUnitPrice()
        {
            return this.shouldSerialize["UnitPrice"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAuthorisedFlag()
        {
            return this.shouldSerialize["AuthorisedFlag"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionTimeGMT()
        {
            return this.shouldSerialize["TransactionTimeGMT"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReasonCode()
        {
            return this.shouldSerialize["ReasonCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuerActionCode()
        {
            return this.shouldSerialize["IssuerActionCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuerActionCodeDescription()
        {
            return this.shouldSerialize["IssuerActionCodeDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDeclinedReason()
        {
            return this.shouldSerialize["DeclinedReason"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardStatusReasonDescription()
        {
            return this.shouldSerialize["CardStatusReasonDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionCountry()
        {
            return this.shouldSerialize["TransactionCountry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuingCollectingCompanyName()
        {
            return this.shouldSerialize["IssuingCollectingCompanyName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardIssuerName()
        {
            return this.shouldSerialize["CardIssuerName"];
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
        public bool ShouldSerializeBearerDescription()
        {
            return this.shouldSerialize["BearerDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardCategoryDescription()
        {
            return this.shouldSerialize["CardCategoryDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTypeDescription()
        {
            return this.shouldSerialize["CardTypeDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardTokenTypeDescription()
        {
            return this.shouldSerialize["CardTokenTypeDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmbossType()
        {
            return this.shouldSerialize["EmbossType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEVPrintedNumber()
        {
            return this.shouldSerialize["EVPrintedNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsRFID()
        {
            return this.shouldSerialize["IsRFID"];
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
            return obj is RecentTransactions other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.CardIssueNumber == null && other.CardIssueNumber == null) || (this.CardIssueNumber?.Equals(other.CardIssueNumber) == true)) &&
                ((this.CollectingCompanyCurrencyCode == null && other.CollectingCompanyCurrencyCode == null) || (this.CollectingCompanyCurrencyCode?.Equals(other.CollectingCompanyCurrencyCode) == true)) &&
                ((this.CustDataCustomerEntered == null && other.CustDataCustomerEntered == null) || (this.CustDataCustomerEntered?.Equals(other.CustDataCustomerEntered) == true)) &&
                ((this.CustDataDriverId == null && other.CustDataDriverId == null) || (this.CustDataDriverId?.Equals(other.CustDataDriverId) == true)) &&
                ((this.CustDataFleetDescription == null && other.CustDataFleetDescription == null) || (this.CustDataFleetDescription?.Equals(other.CustDataFleetDescription) == true)) &&
                ((this.FleetIdInput == null && other.FleetIdInput == null) || (this.FleetIdInput?.Equals(other.FleetIdInput) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.EuroshellSiteNumber == null && other.EuroshellSiteNumber == null) || (this.EuroshellSiteNumber?.Equals(other.EuroshellSiteNumber) == true)) &&
                ((this.IncomingProductCode == null && other.IncomingProductCode == null) || (this.IncomingProductCode?.Equals(other.IncomingProductCode) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.SiteCode == null && other.SiteCode == null) || (this.SiteCode?.Equals(other.SiteCode) == true)) &&
                ((this.HostingCollectingCompanyName == null && other.HostingCollectingCompanyName == null) || (this.HostingCollectingCompanyName?.Equals(other.HostingCollectingCompanyName) == true)) &&
                ((this.HostingCollectingCompanyNumber == null && other.HostingCollectingCompanyNumber == null) || (this.HostingCollectingCompanyNumber?.Equals(other.HostingCollectingCompanyNumber) == true)) &&
                ((this.IccdataTranTypeCode == null && other.IccdataTranTypeCode == null) || (this.IccdataTranTypeCode?.Equals(other.IccdataTranTypeCode) == true)) &&
                ((this.TransactionType == null && other.TransactionType == null) || (this.TransactionType?.Equals(other.TransactionType) == true)) &&
                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true)) &&
                ((this.MerchantCategory == null && other.MerchantCategory == null) || (this.MerchantCategory?.Equals(other.MerchantCategory) == true)) &&
                ((this.MerchantCategoryDescription == null && other.MerchantCategoryDescription == null) || (this.MerchantCategoryDescription?.Equals(other.MerchantCategoryDescription) == true)) &&
                ((this.PurchasedInCountry == null && other.PurchasedInCountry == null) || (this.PurchasedInCountry?.Equals(other.PurchasedInCountry) == true)) &&
                ((this.MerchantId == null && other.MerchantId == null) || (this.MerchantId?.Equals(other.MerchantId) == true)) &&
                ((this.SiteName == null && other.SiteName == null) || (this.SiteName?.Equals(other.SiteName) == true)) &&
                ((this.Network == null && other.Network == null) || (this.Network?.Equals(other.Network) == true)) &&
                ((this.DelcoCode == null && other.DelcoCode == null) || (this.DelcoCode?.Equals(other.DelcoCode) == true)) &&
                ((this.OdometerInput == null && other.OdometerInput == null) || (this.OdometerInput?.Equals(other.OdometerInput) == true)) &&
                ((this.OdometerReadingKm == null && other.OdometerReadingKm == null) || (this.OdometerReadingKm?.Equals(other.OdometerReadingKm) == true)) &&
                ((this.OdometerReadingMiles == null && other.OdometerReadingMiles == null) || (this.OdometerReadingMiles?.Equals(other.OdometerReadingMiles) == true)) &&
                ((this.CardPAN == null && other.CardPAN == null) || (this.CardPAN?.Equals(other.CardPAN) == true)) &&
                ((this.PINIndicator == null && other.PINIndicator == null) || (this.PINIndicator?.Equals(other.PINIndicator) == true)) &&
                ((this.POIReceiptNumber == null && other.POIReceiptNumber == null) || (this.POIReceiptNumber?.Equals(other.POIReceiptNumber) == true)) &&
                ((this.ProductsCodeAdditional == null && other.ProductsCodeAdditional == null) || (this.ProductsCodeAdditional?.Equals(other.ProductsCodeAdditional) == true)) &&
                ((this.ProductsTaxCode == null && other.ProductsTaxCode == null) || (this.ProductsTaxCode?.Equals(other.ProductsTaxCode) == true)) &&
                ((this.FuelVolume == null && other.FuelVolume == null) || (this.FuelVolume?.Equals(other.FuelVolume) == true)) &&
                ((this.SfgwCardDateOfExpiry == null && other.SfgwCardDateOfExpiry == null) || (this.SfgwCardDateOfExpiry?.Equals(other.SfgwCardDateOfExpiry) == true)) &&
                ((this.SiteCurrencyISOCode == null && other.SiteCurrencyISOCode == null) || (this.SiteCurrencyISOCode?.Equals(other.SiteCurrencyISOCode) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.TransactionDate == null && other.TransactionDate == null) || (this.TransactionDate?.Equals(other.TransactionDate) == true)) &&
                ((this.TransactionDateTime == null && other.TransactionDateTime == null) || (this.TransactionDateTime?.Equals(other.TransactionDateTime) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true)) &&
                ((this.TransactionStatus == null && other.TransactionStatus == null) || (this.TransactionStatus?.Equals(other.TransactionStatus) == true)) &&
                ((this.UnitOfMeasure == null && other.UnitOfMeasure == null) || (this.UnitOfMeasure?.Equals(other.UnitOfMeasure) == true)) &&
                ((this.VehicleRegistrationNumber == null && other.VehicleRegistrationNumber == null) || (this.VehicleRegistrationNumber?.Equals(other.VehicleRegistrationNumber) == true)) &&
                ((this.NetworkDelcoName == null && other.NetworkDelcoName == null) || (this.NetworkDelcoName?.Equals(other.NetworkDelcoName) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true)) &&
                ((this.FuelProduct == null && other.FuelProduct == null) || (this.FuelProduct?.Equals(other.FuelProduct) == true)) &&
                ((this.AccountCustomerName == null && other.AccountCustomerName == null) || (this.AccountCustomerName?.Equals(other.AccountCustomerName) == true)) &&
                ((this.PayerName == null && other.PayerName == null) || (this.PayerName?.Equals(other.PayerName) == true)) &&
                ((this.TransactionTime == null && other.TransactionTime == null) || (this.TransactionTime?.Equals(other.TransactionTime) == true)) &&
                ((this.TransactionCurrency == null && other.TransactionCurrency == null) || (this.TransactionCurrency?.Equals(other.TransactionCurrency) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.AuthorisedFlag == null && other.AuthorisedFlag == null) || (this.AuthorisedFlag?.Equals(other.AuthorisedFlag) == true)) &&
                ((this.TransactionTimeGMT == null && other.TransactionTimeGMT == null) || (this.TransactionTimeGMT?.Equals(other.TransactionTimeGMT) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                ((this.IssuerActionCode == null && other.IssuerActionCode == null) || (this.IssuerActionCode?.Equals(other.IssuerActionCode) == true)) &&
                ((this.IssuerActionCodeDescription == null && other.IssuerActionCodeDescription == null) || (this.IssuerActionCodeDescription?.Equals(other.IssuerActionCodeDescription) == true)) &&
                ((this.DeclinedReason == null && other.DeclinedReason == null) || (this.DeclinedReason?.Equals(other.DeclinedReason) == true)) &&
                ((this.CardStatusReasonDescription == null && other.CardStatusReasonDescription == null) || (this.CardStatusReasonDescription?.Equals(other.CardStatusReasonDescription) == true)) &&
                ((this.TransactionCountry == null && other.TransactionCountry == null) || (this.TransactionCountry?.Equals(other.TransactionCountry) == true)) &&
                ((this.IssuingCollectingCompanyName == null && other.IssuingCollectingCompanyName == null) || (this.IssuingCollectingCompanyName?.Equals(other.IssuingCollectingCompanyName) == true)) &&
                ((this.CardIssuerName == null && other.CardIssuerName == null) || (this.CardIssuerName?.Equals(other.CardIssuerName) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.BearerDescription == null && other.BearerDescription == null) || (this.BearerDescription?.Equals(other.BearerDescription) == true)) &&
                ((this.CardCategoryDescription == null && other.CardCategoryDescription == null) || (this.CardCategoryDescription?.Equals(other.CardCategoryDescription) == true)) &&
                ((this.CardTypeDescription == null && other.CardTypeDescription == null) || (this.CardTypeDescription?.Equals(other.CardTypeDescription) == true)) &&
                ((this.CardTokenTypeDescription == null && other.CardTokenTypeDescription == null) || (this.CardTokenTypeDescription?.Equals(other.CardTokenTypeDescription) == true)) &&
                ((this.EmbossType == null && other.EmbossType == null) || (this.EmbossType?.Equals(other.EmbossType) == true)) &&
                ((this.EVPrintedNumber == null && other.EVPrintedNumber == null) || (this.EVPrintedNumber?.Equals(other.EVPrintedNumber) == true)) &&
                ((this.IsRFID == null && other.IsRFID == null) || (this.IsRFID?.Equals(other.IsRFID) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.CardIssueNumber = {(this.CardIssueNumber == null ? "null" : this.CardIssueNumber)}");
            toStringOutput.Add($"this.CollectingCompanyCurrencyCode = {(this.CollectingCompanyCurrencyCode == null ? "null" : this.CollectingCompanyCurrencyCode)}");
            toStringOutput.Add($"this.CustDataCustomerEntered = {(this.CustDataCustomerEntered == null ? "null" : this.CustDataCustomerEntered)}");
            toStringOutput.Add($"this.CustDataDriverId = {(this.CustDataDriverId == null ? "null" : this.CustDataDriverId)}");
            toStringOutput.Add($"this.CustDataFleetDescription = {(this.CustDataFleetDescription == null ? "null" : this.CustDataFleetDescription)}");
            toStringOutput.Add($"this.FleetIdInput = {(this.FleetIdInput == null ? "null" : this.FleetIdInput)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.EuroshellSiteNumber = {(this.EuroshellSiteNumber == null ? "null" : this.EuroshellSiteNumber)}");
            toStringOutput.Add($"this.IncomingProductCode = {(this.IncomingProductCode == null ? "null" : this.IncomingProductCode)}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.SiteCode = {(this.SiteCode == null ? "null" : this.SiteCode.ToString())}");
            toStringOutput.Add($"this.HostingCollectingCompanyName = {(this.HostingCollectingCompanyName == null ? "null" : this.HostingCollectingCompanyName)}");
            toStringOutput.Add($"this.HostingCollectingCompanyNumber = {(this.HostingCollectingCompanyNumber == null ? "null" : this.HostingCollectingCompanyNumber)}");
            toStringOutput.Add($"this.IccdataTranTypeCode = {(this.IccdataTranTypeCode == null ? "null" : this.IccdataTranTypeCode)}");
            toStringOutput.Add($"this.TransactionType = {(this.TransactionType == null ? "null" : this.TransactionType)}");
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude)}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude)}");
            toStringOutput.Add($"this.MerchantCategory = {(this.MerchantCategory == null ? "null" : this.MerchantCategory)}");
            toStringOutput.Add($"this.MerchantCategoryDescription = {(this.MerchantCategoryDescription == null ? "null" : this.MerchantCategoryDescription)}");
            toStringOutput.Add($"this.PurchasedInCountry = {(this.PurchasedInCountry == null ? "null" : this.PurchasedInCountry)}");
            toStringOutput.Add($"this.MerchantId = {(this.MerchantId == null ? "null" : this.MerchantId)}");
            toStringOutput.Add($"this.SiteName = {(this.SiteName == null ? "null" : this.SiteName)}");
            toStringOutput.Add($"this.Network = {(this.Network == null ? "null" : this.Network)}");
            toStringOutput.Add($"this.DelcoCode = {(this.DelcoCode == null ? "null" : this.DelcoCode)}");
            toStringOutput.Add($"this.OdometerInput = {(this.OdometerInput == null ? "null" : this.OdometerInput)}");
            toStringOutput.Add($"this.OdometerReadingKm = {(this.OdometerReadingKm == null ? "null" : this.OdometerReadingKm)}");
            toStringOutput.Add($"this.OdometerReadingMiles = {(this.OdometerReadingMiles == null ? "null" : this.OdometerReadingMiles)}");
            toStringOutput.Add($"this.CardPAN = {(this.CardPAN == null ? "null" : this.CardPAN)}");
            toStringOutput.Add($"this.PINIndicator = {(this.PINIndicator == null ? "null" : this.PINIndicator)}");
            toStringOutput.Add($"this.POIReceiptNumber = {(this.POIReceiptNumber == null ? "null" : this.POIReceiptNumber)}");
            toStringOutput.Add($"this.ProductsCodeAdditional = {(this.ProductsCodeAdditional == null ? "null" : this.ProductsCodeAdditional)}");
            toStringOutput.Add($"this.ProductsTaxCode = {(this.ProductsTaxCode == null ? "null" : this.ProductsTaxCode)}");
            toStringOutput.Add($"this.FuelVolume = {(this.FuelVolume == null ? "null" : this.FuelVolume.ToString())}");
            toStringOutput.Add($"this.SfgwCardDateOfExpiry = {(this.SfgwCardDateOfExpiry == null ? "null" : this.SfgwCardDateOfExpiry)}");
            toStringOutput.Add($"this.SiteCurrencyISOCode = {(this.SiteCurrencyISOCode == null ? "null" : this.SiteCurrencyISOCode)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId)}");
            toStringOutput.Add($"this.TransactionDate = {(this.TransactionDate == null ? "null" : this.TransactionDate.ToString())}");
            toStringOutput.Add($"this.TransactionDateTime = {(this.TransactionDateTime == null ? "null" : this.TransactionDateTime)}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId)}");
            toStringOutput.Add($"this.TransactionStatus = {(this.TransactionStatus == null ? "null" : this.TransactionStatus)}");
            toStringOutput.Add($"this.UnitOfMeasure = {(this.UnitOfMeasure == null ? "null" : this.UnitOfMeasure)}");
            toStringOutput.Add($"this.VehicleRegistrationNumber = {(this.VehicleRegistrationNumber == null ? "null" : this.VehicleRegistrationNumber)}");
            toStringOutput.Add($"this.NetworkDelcoName = {(this.NetworkDelcoName == null ? "null" : this.NetworkDelcoName)}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
            toStringOutput.Add($"this.FuelProduct = {(this.FuelProduct == null ? "null" : this.FuelProduct)}");
            toStringOutput.Add($"this.AccountCustomerName = {(this.AccountCustomerName == null ? "null" : this.AccountCustomerName)}");
            toStringOutput.Add($"this.PayerName = {(this.PayerName == null ? "null" : this.PayerName)}");
            toStringOutput.Add($"this.TransactionTime = {(this.TransactionTime == null ? "null" : this.TransactionTime)}");
            toStringOutput.Add($"this.TransactionCurrency = {(this.TransactionCurrency == null ? "null" : this.TransactionCurrency)}");
            toStringOutput.Add($"this.UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"this.AuthorisedFlag = {(this.AuthorisedFlag == null ? "null" : this.AuthorisedFlag)}");
            toStringOutput.Add($"this.TransactionTimeGMT = {(this.TransactionTimeGMT == null ? "null" : this.TransactionTimeGMT)}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
            toStringOutput.Add($"this.IssuerActionCode = {(this.IssuerActionCode == null ? "null" : this.IssuerActionCode)}");
            toStringOutput.Add($"this.IssuerActionCodeDescription = {(this.IssuerActionCodeDescription == null ? "null" : this.IssuerActionCodeDescription)}");
            toStringOutput.Add($"this.DeclinedReason = {(this.DeclinedReason == null ? "null" : this.DeclinedReason)}");
            toStringOutput.Add($"this.CardStatusReasonDescription = {(this.CardStatusReasonDescription == null ? "null" : this.CardStatusReasonDescription)}");
            toStringOutput.Add($"this.TransactionCountry = {(this.TransactionCountry == null ? "null" : this.TransactionCountry)}");
            toStringOutput.Add($"this.IssuingCollectingCompanyName = {(this.IssuingCollectingCompanyName == null ? "null" : this.IssuingCollectingCompanyName)}");
            toStringOutput.Add($"this.CardIssuerName = {(this.CardIssuerName == null ? "null" : this.CardIssuerName)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.BearerDescription = {(this.BearerDescription == null ? "null" : this.BearerDescription)}");
            toStringOutput.Add($"this.CardCategoryDescription = {(this.CardCategoryDescription == null ? "null" : this.CardCategoryDescription)}");
            toStringOutput.Add($"this.CardTypeDescription = {(this.CardTypeDescription == null ? "null" : this.CardTypeDescription)}");
            toStringOutput.Add($"this.CardTokenTypeDescription = {(this.CardTokenTypeDescription == null ? "null" : this.CardTokenTypeDescription)}");
            toStringOutput.Add($"this.EmbossType = {(this.EmbossType == null ? "null" : this.EmbossType)}");
            toStringOutput.Add($"this.EVPrintedNumber = {(this.EVPrintedNumber == null ? "null" : this.EVPrintedNumber)}");
            toStringOutput.Add($"this.IsRFID = {(this.IsRFID == null ? "null" : this.IsRFID.ToString())}");
        }
    }
}