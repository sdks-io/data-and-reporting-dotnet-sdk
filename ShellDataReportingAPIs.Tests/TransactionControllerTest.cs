// <copyright file="TransactionControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;
using ShellDataReportingAPIs.Standard;
using ShellDataReportingAPIs.Standard.Controllers;
using ShellDataReportingAPIs.Standard.Exceptions;
using ShellDataReportingAPIs.Standard.Http.Client;
using ShellDataReportingAPIs.Standard.Http.Response;
using ShellDataReportingAPIs.Standard.Models.Containers;
using ShellDataReportingAPIs.Standard.Utilities;

namespace ShellDataReportingAPIs.Tests
{
    /// <summary>
    /// TransactionControllerTest.
    /// </summary>
    [TestFixture]
    public class TransactionControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private TransactionController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.TransactionController;
        }

        /// <summary>
        /// This endpoint allows querying last 48 hours of transaction data of Shell Card (i.e. Priced, Billed, Unbilled etc. sales items). It provides a flexible search criteria and supports pagination. E.g., if the request is made at 08:30 AM on 18 Aug 2022 then transactions until 16 Aug 2022 08:30 AM (including) can be retrieved.
        ///
        ///
        ///#### Supported operations
        ///
        ///    * Search by Date and Time range (within the last 48 hours only)
        ///
        ///    * Search by Payer and/or Account number
        ///
        ///    * Search by Card
        ///
        ///    * Search by Purchased Country
        ///
        ///    * Search by Transaction posting date
        ///
        ///    * Search by Driver Name or Vehicle registration number
        ///
        ///    * Search by Fuel only transactions
        ///
        ///    * Search by Product and/or Product group.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestRecentTransactionsNew()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.RecentTransactionRequest body = ApiHelper.JsonDeserialize<Standard.Models.RecentTransactionRequest>("{\"PageSize\":1,\"Page\":1,\"Filters\":{\"ColCoCode\":14,\"PayerNumber\":\"GB00001232\",\"AccountNumber\":\"GB00001233\",\"ProductCode\":\"22\",\"PurchasedInCountry\":\"GB\",\"CardPAN\":\"700205******890645\",\"FromDateTime\":\"2020-11-09 13:56:03.000\",\"ToDateTime\":\"2020-12-09 13:56:03.000\",\"TransactionStatus\":\"APPROVED\",\"FuelOnly\":\"False\",\"ProductGroupName\":\"Motor gasoline\",\"VehicleRegistrationNumber\":\"YG67OUM\",\"IncludeDeclines\":true,\"CardIssuerName\":\"Mathew\",\"ColumnList\":\"PayerNumber,AccountNumber,ProductName,FuelVolume,PAN\"}}");

            // Perform API call
            Standard.Models.RecentTransactionsResponse result = null;
            try
            {
                result = await this.controller.RecentTransactionsNewAsync(requestId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"RequestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"Status\":\"SUCCESS\",\"Page\":1,\"RowCount\":2,\"TotalPages\":1,\"Data\":[{\"ColCoCode\":84,\"PayerNumber\":\"MY00200653\",\"AccountNumber\":\"MY00200653\",\"CardIssueNumber\":\"1\",\"CollectingCompanyCurrencyCode\":\"MYR\",\"CustDataCustomerEntered\":\"PartnerId\",\"CustDataDriverId\":\"D123\",\"CustDataFleetDescription\":\"Fleet-Truck\",\"FleetIdInput\":\"AS2344\",\"Amount\":62.47,\"EuroshellSiteNumber\":\"1231\",\"IncomingProductCode\":\"10\",\"ProductCode\":\"23\",\"ProductName\":\"Unleaded - Low octane\",\"SiteCode\":3350,\"HostingCollectingCompanyName\":\"Shell Malaysia Trading Sdn Bhd\",\"HostingCollectingCompanyNumber\":\"84\",\"IccdataTranTypeCode\":\"1\",\"TransactionType\":\"Transaction Type description\",\"Latitude\":\"52.143814\",\"Longitude\":\"101.72869\",\"MerchantCategory\":\"5542\",\"MerchantCategoryDescription\":\"Description\",\"PurchasedInCountry\":\"MY\",\"MerchantId\":\"MY1737000000000\",\"SiteName\":\"ShellPT3895 BATU 4    KUALA LUMPUR MY\",\"Network\":\"458\",\"DelcoCode\":\"084\",\"OdometerInput\":\"201620\",\"OdometerReadingKm\":\"201620\",\"OdometerReadingMiles\":\"201620\",\"CardPAN\":\"700214*******780061\",\"PINIndicator\":\"Y\",\"POIReceiptNumber\":\"417662\",\"ProductsCodeAdditional\":\"Additional Code\",\"ProductsTaxCode\":\"0\",\"FuelVolume\":34.15,\"SfgwCardDateOfExpiry\":\"2024-12\",\"SiteCurrencyISOCode\":\"MYR\",\"CardId\":\"330743\",\"TransactionDate\":\"2021-11-11\",\"TransactionDateTime\":\"2021-11-11 16:32:09.000\",\"TransactionId\":\"864220307\",\"TransactionStatus\":\"Approved\",\"UnitOfMeasure\":\"L\",\"VehicleRegistrationNumber\":\"WD33637\",\"NetworkDelcoName\":\"Shell Malaysia Trading Sdn Bhd\",\"ProductGroupName\":\"Motor gasoline\",\"FuelProduct\":\"All Fuels\",\"AccountCustomerName\":\"WCT BERHAD\",\"PayerName\":\"WCT BERHAD\",\"TransactionTime\":\"2021-11-11\",\"TransactionCurrency\":\"RM\",\"UnitPrice\":0.02050073206442167,\"AuthorisedFlag\":\"Y\",\"TransactionTimeGMT\":\"08:41:02\",\"ReasonCode\":\"10\",\"IssuerActionCode\":\"2\",\"IssuerActionCodeDescription\":\"Approved, partial\",\"DeclinedReason\":\"partial\",\"CardStatusReasonDescription\":\"Approved, partial\",\"TransactionCountry\":\"458\",\"IssuingCollectingCompanyName\":\"Partner Name\",\"CardIssuerName\":\"John\",\"DriverName\":\"PAK PAK\",\"BearerDescription\":\"Description\",\"CardCategoryDescription\":\"Driver Card\",\"CardTypeDescription\":\"SHELL FLEET- HONG KONG 7002821\",\"CardTokenTypeDescription\":\"HK FLE NAT SIN R1 - CHIP\",\"EmbossType\":\"Driver\",\"EVPrintedNumber\":\"NL-TNM-C00122045-K\",\"IsRFID\":false}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria and supports paging. 
        ///The version 2 is an enhancement to the version 1 where EV transactions and their details are added in the response. 
        ///
        ///Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.
        ///
        ///#### Supported operations
        ///  * Get sales items and fee transactions
        ///    * Search by invoice status
        ///    * Search by fixed date period
        ///    * Search by date range
        ///    * Search by account
        ///    * Search by card
        ///  * Get sales items only
        ///    * Search by transaction Id or location
        ///    * Search by transaction posting date
        ///    * Search by invoice number or date
        ///    * Search by driver name or vehicle registration number
        ///    * Search by card group
        ///    * Search by fuel only transactions
        ///    * Search by product
        /// * EV transaction details - Below are EV specific parameters
        ///    * EVOperator
        ///    * EVSerialId
        ///    * EVChargePointSerial
        ///    * EVChargePointConnectorType
        ///    * EVChargePointConnectorTypeDescription
        ///    * EVChargeDuration
        ///    * EVChargeStartDate
        ///    * EVChargeStartTime
        ///    * EVChargeEndDate
        ///    * EVChargeEndTime.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestPricedTransactionsV2()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.PricedTransactionRequestV2 body = ApiHelper.JsonDeserialize<Standard.Models.PricedTransactionRequestV2>("{\"PageSize\":1,\"Page\":1,\"Filters\":{\"ColCoCode\":\"032\",\"InvoiceStatus\":\"A\",\"PayerNumber\":\"DE26685263\",\"AccountId\":29484,\"AccountNumber\":\"DE26667080\",\"DriverName\":\"HH NX 508\",\"CardGroupId\":40000,\"CardPAN\":\"7002051006629890645\",\"ProductCode\":\"10\",\"ProductName\":\"Diesel AGO\",\"SiteCode\":\"05000100\",\"IncomingSiteNumber\":\"100021\",\"InvoiceDate\":\"2021-01-01\",\"InvoiceNumber\":\"3201016193\",\"PurchasedInCountryCode\":\"GB\",\"PurchasedInCountry\":\"United Kingdom\",\"SiteGroupId\":202,\"VehicleRegistrationNumber\":\"4K46801\",\"FeeTypeId\":275549,\"LineItemDescription\":\"ABC3\",\"Cards\":[0],\"SortOrder\":\"5\",\"FromDate\":\"2022-01-01 00:00:00\",\"ToDate\":\"2022-01-01 00:00:00\",\"Period\":3,\"PostingDateFrom\":\"2022-01-01 00:00:00\",\"PostingDateTo\":\"2022-01-01 00:00:00\",\"TransactionItemId\":\"1208176398\",\"FuelOnly\":false,\"IncludeFees\":true,\"IsMultipayer\":true,\"ValidInvoiceDateOnly\":false,\"InvoiceFromDate\":\"2022-01-01 00:00:00\",\"InvoiceToDate\":\"2022-01-01 00:00:00\",\"HostingCollectingCompanyNumber\":\"032\",\"Search\":\"2K89909\",\"TransactionId\":\"io9KVXk1UkW57XWKyeaHHg\"}}");

            // Perform API call
            Standard.Models.PricedTransactionResponseV2 result = null;
            try
            {
                result = await this.controller.PricedTransactionsV2Async(requestId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.IsTrue(
                    TestHelper.IsProperSubsetOf(
                    "{\"RequestId\":\"9d2dee33-7803-485a-a2b1-2c7538e597ee\",\"Status\":\"SUCCESS\",\"Data\":[{\"AccountName\":\"Blue Colour Ltd\",\"AccountId\":29484,\"AccountNumber\":\"DE26667080\",\"AccountShortName\":\"Mathew\",\"Additional1\":\"GBALLEGO0002452\",\"Additional2\":\"GBALLEGO0002452\",\"Additional3\":\"GBALLEGO0002452\",\"Additional4\":\"GBALLEGO0002452\",\"AllowClearing\":\"Null\",\"AuthorisationCode\":300796,\"TransactionStatus\":\"Y\",\"DriverName\":\"SATTY BHAMRA\",\"CardExpiryPeriod\":2204,\"CardExpiry\":\"20220101\",\"CardGroupId\":40000,\"CardGroupName\":\"006240 FIRE BRIGHT SOLUTIONS\",\"IssuerCode\":7002,\"CardPAN\":\"7002053465789891000\",\"ReleaseCode\":9,\"CardSequenceNumber\":617,\"CardType\":\"GB STD FLT NAT SINGLE R9\",\"ColCoCode\":\"014\",\"UnitDiscountInvoiceCurrency\":-0.0051,\"ColCoExchangeRate\":0.851858,\"InvoiceCurrencySymbol\":\"GBP\",\"CorrectionFlag\":true,\"CRMNumber\":10,\"CustomerCountry\":\"United Kingdom\",\"CustomerCurrencyCode\":\"GBP\",\"CustomerCurrencySymbol\":\"£\",\"RebateonNetAmountInCustomerCurrency\":0,\"EffectiveDiscountInCustomerCurrency\":-0.22,\"EffectiveUnitDiscountInCustomerCurrency\":-0.0051,\"UnitPriceInInvoiceCurrency\":1.1024,\"InvoiceTax\":0,\"InvoiceGrossAmount\":57.25,\"InvoiceNetAmount\":47.71,\"VATonNetAmountInCustomerCurrency\":9.54,\"CustomerRetailPriceUnitGross\":0,\"CustomerRetailValueTotalGross\":57.52,\"CustomerRetailValueTotalNet\":47.93,\"TransactionTypeDescription\":9.59,\"RebateonNetAmountInTransactionCurrency\":-0.22,\"EffectiveDiscountInTrxCurrency\":-0.22,\"DelCoToColCoExchangeRate\":0,\"Cards\":[275549],\"UnitDiscountTransactionCurrency\":-0.005,\"TransactionGrossAmount\":57.25,\"TransactionNetAmount\":47.71,\"TransactionTax\":9.54,\"VATonNetAmount\":9.54,\"DelcoListPriceUnitNet\":0,\"DelcoRetailPriceUnitGross\":1.32888,\"UnitPriceInTransactionCurrency\":1.1074,\"DelcoRetailPriceUnitNet\":1.1074,\"DelcoRetailValueTotalGross\":57.52,\"DelcoRetailValueTotalNet\":47.93,\"TransactionCurrencySymbol\":\"$\",\"DiscountType\":\"Retail\",\"DisputeStatus\":false,\"IsShellSite\":false,\"FleetIdInput\":\"YG67OUM\",\"IncomingProductCode\":23,\"PostingDate\":\"20210802\",\"PostingTime\":\"14:15:22\",\"ProductCode\":30,\"ProductName\":\"Unleaded - Medium octane\",\"ProductGroupId\":22,\"IncomingCurrencyCode\":\"GBP\",\"IncomingSiteDescription\":\"Shell Broadway Ring\",\"Location\":\"Shell Broadway Ring\",\"SiteName\":\"Shell Broadway Ring\",\"SiteCode\":32,\"IncomingSiteNumber\":15,\"InvoiceCurrencyCode\":\"GBP\",\"InvoiceDate\":\"20210802\",\"InvoiceNumber\":3201016193,\"FuelProduct\":true,\"VATApplicable\":\"Y\",\"PayerName\":\"Colours Services Ltd\",\"PayerNumber\":\"GB12121212\",\"ParentCustomerNumber\":\"GB12121212\",\"PayerGroup\":\"H312066\",\"PayerGroupName\":\"12162566 - FUEL CARD SERVICE\",\"CheckDigit\":6,\"NetInvoiceIndicator\":\"Y\",\"DelcoCode\":5,\"NetworkCode\":3,\"PurchasedInCountry\":\"United Kingdom\",\"SiteCountry\":\"United Kingdom\",\"VATCountry\":\"United Kingdom\",\"DelcoName\":\"Shell U.K. Oil Products Limited\",\"Network\":\"Shell\",\"OdometerInput\":0,\"OriginalSalesItemId\":\"Null\",\"FleetIDDescription\":\"YG67OUM\",\"ParentCustomerId\":6494,\"PINIndicator\":\"Y, N\",\"ProductGroupName\":\"Fees\",\"PurchasedInCountryCode\":\"GB\",\"Quantity\":43.28,\"RebateRate\":0.0022,\"ReceiptNumber\":6803,\"RefundFlag\":\"Y\",\"SiteGroupId\":202,\"SiteGroupName\":\"CZ 9100 ECONOMY NETWORK\",\"Latitude\":53.83606,\"Longitude\":-1.61854,\"DelCoExchangeRate\":0.851858,\"EuroRebateAmount\":-0.258259,\"NetEuroAmount\":56.01,\"EuroVATAmount\":11.2,\"ParentCustomerName\":\"FUEL CARD SERVICES LTD\",\"IsInvoiced\":false,\"TransactionCurrencyCode\":\"GBP\",\"CreditDebitCode\":\"D or C\",\"TransactionDate\":\"20210801\",\"TransactionTime\":\"12:16:58\",\"TransactionItemId\":\"H305908971030\",\"TrnIdentifier\":\"H305908971030\",\"Type\":\"SALE\",\"TransactionLine\":1,\"TransactionType\":\"Purchase\",\"UTCOffset\":\"Europe/London\",\"VATCategory\":\"United Kingdom Standard VAT Rate\",\"VATRate\":0.2,\"VehicleRegistration\":\"YG67OUM\",\"IsCancelled\":\"Y\",\"ColCoGrossAmount\":57.25,\"ColCoNetAmount\":47.71,\"ColCoVATAmount\":9.54,\"OriginalCurrencySymbol\":\"$\",\"OriginalCurrencyCode\":\"$\",\"OriginalVATAmount\":0,\"EmbossText\":\"PARKLANE PROPERTIES LTD\",\"OriginalExchangeRate\":0,\"OriginalTransactionItemInvoiceDate\":\"20220202\",\"FeeTypeId\":1,\"LineItemDescription\":true,\"FeeRuleDescription\":\"Simple Fee\",\"Frequency\":1,\"FeeRuleId\":1,\"SystemEntryDate\":\"20210828\",\"SystemEntryTime\":\"20:21:08\",\"IsManual\":\"Y\",\"OriginalTransactionItemId\":\"Y\",\"OriginalTransactionItemInvoiceNumber\":6750802,\"OriginalTransactionItemInvoiceId\":234,\"PayerShortName\":\"FUEL CARD SERVICES LTD\",\"ReverseCharge\":\"Y\",\"OriginalGrossAmount\":57.25,\"OriginalNetAmount\":57.25,\"UnitOfMeasure\":\"L\",\"RoadType\":\"National Road\",\"CustomerCountryIsoCode\":\"DE\",\"EVOperator\":\"Shell Recharge\",\"EVSerialId\":\"GBALLEGO0002452\",\"EVChargePointSerial\":\"GBALLEGO0002452\",\"EVChargePointConnectorType\":5,\"EVChargePointConnectorTypeDescription\":\"DC 50 kW\",\"EVChargeDuration\":\"PT3205S\",\"EVChargeStartDate\":\"2021-08-01\",\"EVChargeStartTime\":\"20:08:01\",\"EVChargeEndDate\":\"2022-08-01\",\"EVChargeEndTime\":\"20:08:01\",\"HostingCollectingCompanyNumber\":0,\"TransactionId\":0,\"FuelOnly\":true}],\"Page\":3,\"PageSize\":30,\"TotalPages\":5}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }
    }
}