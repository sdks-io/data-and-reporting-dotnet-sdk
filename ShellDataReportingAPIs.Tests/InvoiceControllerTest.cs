// <copyright file="InvoiceControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellDataReportingAPIs.Tests
{
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
    using ShellDataReportingAPIs.Standard.Utilities;

    /// <summary>
    /// InvoiceControllerTest.
    /// </summary>
    [TestFixture]
    public class InvoiceControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private InvoiceController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.InvoiceController;
        }

        /// <summary>
        /// This API allows to search invoice data in the Shell Card Platform. It provides flexible search criteria in the request body and supports paging. 
        ///
        ///This API will also query the relevant invoice documents list and return a reference number that can be used to download invoice documents (PDF and Proofing elements in a zip file).
        ///
        ///#### Supported operations
        ///  * Search invoices by account
        ///  * Search invoices by invoice type or invoice status
        ///  * Search invoices by invoice id or number
        ///  * Search invoices by invoiced country
        ///  * Search invoices including einvoices
        ///  * Search invoices by summary document
        ///  * Search invoices by statement of account
        ///  * Search invoices by fixed and custom date periods.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestInvoiceSearch()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.InvoiceSearchRequest body = ApiHelper.JsonDeserialize<Standard.Models.InvoiceSearchRequest>("{\"Filters\":{\"ColCoId\":14,\"PayerId\":78,\"PayerNumber\":\"DE26688478\",\"AccountId\":92,\"AccountNumber\":\"DE26702892\",\"InvoiceId\":4013059,\"InvoiceNumber\":\"0123456789\",\"FromDate\":\"20170830\",\"ToDate\":\"20171031\",\"InvoiceDate\":\"20171031\",\"Type\":\"Original\",\"SummaryDocumentId\":1616729,\"SummaryDocumentNumber\":\"1283899/289261063/2019\",\"StatementOfAccountId\":\"DE26702892\",\"SoAReferenceNumber\":\"1283899\",\"Period\":1,\"InvoiceStatus\":\"Due\",\"InvoicedOnBehalfOf\":\"DE\",\"IncludeEInvoiceDetails\":false,\"SortBy\":[1]},\"PageSize\":50,\"Page\":1}");

            // Perform API call
            Standard.Models.InvoiceSearchResponse result = null;
            try
            {
                result = await this.controller.InvoiceSearchAsync(requestId, body);
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
                    "{\"RequestId\":\"18c955d1-b3ec-4dc0-95da-76e67afb891a\",\"Status\":\"SUCCESS\",\"Data\":[{\"AccountFullName\":\"powder ambition ERF  \",\"AccountId\":179827,\"AccountNumber\":\"DE26702892\",\"AccountShortName\":\"soft grocery Argyle  \",\"ColCoId\":14,\"ColCoOpCoId\":\"014\",\"CurrentBillingFrequency\":\"Last day of month\",\"CurrentBillingFrequencyId\":40,\"CurrentDistributionMethod\":\"e-mail\",\"CurrentDistributionMethodId\":1,\"CustomerCurrencyCode\":\"EUR\",\"CustomerCurrencySymbol\":\"€\",\"DelCoClientNumber\":\"014\",\"DelCoId\":14,\"DelCoOpCoId\":\"014\",\"DocumentType\":\"Invoice\",\"DocumentTypeId\":1,\"DueDate\":\"20190707\",\"GrossAmountCustomerCurrency\":22.85,\"GrossAmountTransactionCurrency\":22.85,\"InvoiceDate\":\"20190630\",\"InvoicedBy\":\"euroShell Deutschland GmbH & Co. KG\",\"InvoicedOnBehalfOf\":\"Germany\",\"InvoiceId\":4013059,\"InvoiceNumber\":\"6402009004\",\"IsInternational\":false,\"IsNational\":true,\"NetAmountCustomerCurrency\":19.2,\"NetAmountTransactionCurrency\":19.2,\"PayerId\":164825,\"PayerNumber\":\"DE26688478\",\"PaymentTerms\":\"7 days after invoice\",\"PaymentTermsId\":9,\"ReplacementInvoiceId\":null,\"ReversalInvoiceId\":null,\"Status\":\"Paid\",\"SummaryDocumentBillingType\":\"Standard Invoice\",\"SummaryDocumentBillingTypeId\":0,\"SummaryDocumentDate\":\"20190630\",\"SummaryDocumentDDAmount\":22.85,\"SummaryDocumentDueDate\":\"20190707\",\"SummaryDocumentId\":1616729,\"SummaryDocumentIsFullyPaid\":true,\"SummaryDocumentNumber\":\"1283899/289261063/2019\",\"SummaryDocumentPaidAmount\":22.85,\"SummaryDocumentSoAReferenceNumber\":\"2000745709\",\"SummaryDocumentStatementOfAccountId\":2000745709,\"TransactionCurrencyCode\":\"EUR\",\"TransactionCurrencySymbol\":\"€\",\"Type\":\"Original\",\"TypeId\":1,\"VATAmountCustomerCurrency\":3.65,\"VATAmountTransactionCurrency\":3.65,\"VATCountry\":\"Germany\",\"VATCountryId\":9,\"VATCountryISOCode\":\"DE\",\"VATCountryOpCoId\":\"014\"}],\"Page\":1,\"PageSize\":50,\"TotalRecords\":1,\"TotalPages\":1}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This API returns the high level summary of invoices that match the  given search criteria. The same search criteria as the endpoint `/v1/invoice/search` is supported with the exception of paging related parameters. 
        ///
        ///
        ///#### Supported operations
        ///  * Search invoices by account
        ///  * Search invoices by invoice type or invoice status
        ///  * Search invoices by invoice id or number
        ///  * Search invoices by invoiced country
        ///  * Search invoices including einvoices
        ///  * Search invoices by summary document
        ///  * Search invoices by statement of account
        ///  * Search invoices by fixed and custom date periods.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestInvoiceSummary()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.InvoiceSummaryRequest body = ApiHelper.JsonDeserialize<Standard.Models.InvoiceSummaryRequest>("{\"Filters\":{\"ColCoId\":14,\"PayerId\":78,\"PayerNumber\":\"DE26688478\",\"AccountId\":92,\"AccountNumber\":\"DE26702892\",\"InvoiceId\":4013059,\"InvoiceNumber\":\"0123456789\",\"FromDate\":\"20170830\",\"ToDate\":\"20171031\",\"InvoiceDate\":\"20171031\",\"Type\":\"Original\",\"SummaryDocumentId\":1616729,\"SummaryDocumentNumber\":\"1283899/289261063/2019\",\"StatementOfAccountId\":\"DE26702892\",\"SoAReferenceNumber\":\"1283899\",\"Period\":1,\"InvoiceStatus\":\"Due\",\"InvoicedOnBehalfOf\":\"DE\",\"IncludeEInvoiceDetails\":false}}");

            // Perform API call
            Standard.Models.InvoiceSummaryResponse result = null;
            try
            {
                result = await this.controller.InvoiceSummaryAsync(requestId, body);
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
                    "{\"RequestId\":\"a0a1596f-b242-4672-b513-66c5e5554195\",\"Status\":\"SUCCESS\",\"Data\":[{\"TotalInvoices\":1,\"TotalGrossAmountCustomerCurrency\":22.85,\"TotalNetAmountCustomerCurrency\":19.2,\"TotalVATAmountCustomerCurrency\":3.65,\"CustomerCurrencyCode\":\"EUR\",\"CustomerCurrencySymbol\":\"€\"}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// This API allows querying the details of the latest statement of account (SOA) generated for a given Payer. 
        ///
        ///The endpoint supports querying SOA documents by various input parameters specified in the request body.
        ///
        ///#### Supported operations
        ///  * Search invoice SOA by payer and account
        ///  * Search invoice SOA including monthly trend (last 13 months invocie trend summary)
        ///  * Search invoice SOA including past SOAs
        ///  * Search invoice SOA including due/overdue documents
        ///  * Search invoice SOA including invoice summary.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestStatementOfAccount()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.StatementOfAccountRequest body = ApiHelper.JsonDeserialize<Standard.Models.StatementOfAccountRequest>("{\"Filters\":{\"ColCoCode\":32,\"PayerId\":308,\"PayerNumber\":\"CZ56891709\",\"AccountNumber\":\"CZ56891900\",\"Accountid\":6928,\"IncludeMonthlyInvoiceTrend\":true,\"IncludePastStatementOfAccounts\":true,\"DueOrOverDueSOADocumentsOnly\":false,\"NumberOfSOADocuments\":10,\"IncludeAccountInvoicesSummary\":true}}");

            // Perform API call
            Standard.Models.StatementOfAccountResponse result = null;
            try
            {
                result = await this.controller.StatementOfAccountAsync(requestId, body);
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
                    "{\"RequestId\":\"5acba53b-3ce7-4f4b-ab59-1db09399aa6a\",\"Status\":\"SUCCESS\",\"Data\":[{\"LastStatementOfAccount\":{\"AmountDue\":123699.71,\"AmountNotOverdue\":136604.83,\"AmountOverdue\":926469.11,\"CreditLimit\":7000000,\"CreditLimitCurrencyCode\":\"CZK\",\"CreditLimitCurrencySymbol\":\"Kč\",\"CreditLimitInCustomerCurrency\":286826.469986,\"CurrencyCode\":\"EUR\",\"CurrencySymbol\":\"€\",\"LastPaymentCurrencyCode\":\"EUR\",\"LastPaymentCurrencySymbol\":\"€\",\"LastPaymentDate\":\"20220209\",\"LastPaymentValue\":17918.98,\"OutstandingBalance\":1186773.65,\"PayerId\":308,\"PayerNumber\":\"CZ56891709\",\"PaymentDueDate\":\"20230608\",\"PaymentMethod\":\"Incoming - Bank Transfer\",\"PaymentMethodId\":4,\"PaymentTerms\":\"30 days after Invoice\",\"PaymentTermsId\":4,\"SoAReferenceNumber\":\"2003923319\",\"StatementDate\":\"20230509\",\"StatementOfAccountId\":2003923319,\"TotalBillingDocuments\":6,\"TotalSummaryBillingDocuments\":1,\"UnallocatedPayment\":0},\"MonthlyInvoiceTrend\":null,\"PastStatementOfAccounts\":[{\"AmountDue\":136604.83,\"AmountNotOverdue\":130344.09,\"AmountOverdue\":796109.41,\"AmountOverdueFromUnallocated\":0,\"AmountPaid\":0,\"BalanceOnThisStatement\":5866.1,\"BillingCurrencyCode\":\"EUR\",\"BillingCurrencySymbol\":\"€\",\"CreditLimit\":7000000,\"CreditLimitCurrencyCode\":\"CZK\",\"CreditLimitCurrencySymbol\":\"Kč\",\"CreditLimitInCustomerCurrency\":286826.4699857,\"CurrencyCode\":\"EUR\",\"CurrencySymbol\":\"€\",\"FullyPaid\":false,\"LastPaymentCurrencyCode\":\"EUR\",\"LastPaymentCurrencySymbol\":\"€\",\"LastPaymentDate\":\"20220209\",\"LastPaymentValue\":17918.98,\"OutstandingBalance\":1063058.33,\"PayerId\":308,\"PayerNumber\":\"CZ56891709\",\"PaymentDueDate\":\"20230511\",\"SoAReferenceNumber\":\"2003920583\",\"StatementDate\":\"20230411\",\"StatementOfAccountId\":2003920583,\"TotalBillingDocuments\":3,\"TotalNetAmountBillingCurrency\":4847.94,\"TotalSummaryBillingDocuments\":1,\"TotalVATAmountBillingCurrency\":1018.16,\"UnallocatedPayment\":0,\"LocalCurrencyCode\":\"EUR\",\"LocalCurrencySymbol\":\"€\",\"LocalCurrencyExchangeRate\":24.405}],\"PaymentsSinceLastSOA\":null,\"InvoicesSummaries\":null}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// - This API will return the list of Invoice Dates and Numbers for the given date range. If the dates are not provided then it will fetch the data for past 13 months..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDates()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.InvoiceDatesRequest body = ApiHelper.JsonDeserialize<Standard.Models.InvoiceDatesRequest>("{\"Filters\":{\"ColCoCode\":0,\"PayerId\":0,\"PayerNumber\":\"string\",\"IncludeMonthlyInvoiceTrend\":true,\"IncludePastStatementOfAccounts\":true,\"DueOrOverDueSOADocumentsOnly\":true,\"NumberOfSOADocuments\":0,\"IncludeAccountInvoicesSummary\":true,\"ColCoId\":0,\"Accounts\":[{\"AccountId\":3453,\"AccountNumber\":\"GB000000124\"}]}}");

            // Perform API call
            Standard.Models.InvoiceDatesResponseData result = null;
            try
            {
                result = await this.controller.DatesAsync(requestId, body);
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
                    "{\"RequestId\":\"a0a1596f-b242-4672-b513-66c5e5554195\",\"Status\":\"SUCCESS\",\"Data\":[{\"InvoiceNumbers\":[\"6402009004\"],\"InvoiceDates\":[\"20170101\"]}]}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// - This API will allow querying of SOA from different systems.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSearchStatementOfAccount()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.SearchStatementOfAccountRequest body = ApiHelper.JsonDeserialize<Standard.Models.SearchStatementOfAccountRequest>("{\"Filters\":{\"ColCoCode\":18,\"PayerNumber\":\"NL99781417\",\"InvoiceNumber\":\"0123456789\",\"FromDate\":\"2022/05/04\",\"ToDate\":\"2022/05/10\",\"Period\":1,\"InvoiceDate\":\"20170830\",\"InvoiceStatus\":[\"Due\"],\"SortBy\":[1]},\"Page\":1,\"PageSize\":10}");

            // Perform API call
            Standard.Models.SearchStatementOfAccountResponse result = null;
            try
            {
                result = await this.controller.SearchStatementOfAccountAsync(requestId, body);
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
                    "{\"RequestId\":\"a0a1596f-b242-4672-b513-66c5e5554195\",\"Status\":\"SUCCESS\",\"Data\":[{\"StatementOfAccountId\":2001581712,\"SoAReferenceNumber\":\"2001581712\",\"DocumentReferenceNumber\":null,\"StatementDate\":\"20220505\",\"PayerId\":17150,\"PayerNumber\":\"NL99781417\",\"AmountDue\":0,\"AmountOverdue\":197046.47,\"CurrencyCode\":\"EUR\",\"CurrencySymbol\":\"€\",\"DueDate\":\"20220604\",\"InvoicedOnBehalfOf\":\"Netherlands\",\"Status\":\"OverDue\",\"GrossAmountCustomerCurrency\":0}],\"Page\":1,\"TotalRecords\":62,\"TotalPages\":7,\"PageSize\":10}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// - This API allows querying the details of all invoices successfully uploaded to the Worldline invoice repository and file reference numbers for downloading..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestSearchDocuments()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.SearchDocumentsRequest body = ApiHelper.JsonDeserialize<Standard.Models.SearchDocumentsRequest>("{\"Filters\":{\"PayerNumber\":\"DE00000096\",\"AccountNumber\":\"DE00000096\",\"ColCoCode\":14,\"AccountNumberList\":[\"DE00000123\",\"DE00000225\"],\"InvoiceNumber\":\"1234567\",\"InvoiceNumberList\":[\"6400013693\",\"9421000010\"],\"InvoiceStatus\":\"NEW\",\"IssuingDateFrom\":\"2023/05/01\",\"IssuingDateTo\":\"2023/06/30\",\"DueDateFrom\":\"2023/05/04\",\"DueDateTo\":\"2023/06/30\",\"GrossAmount\":\"1000\",\"GrossAmountOperator\":\"LT\",\"DocumentType\":\"SOA\",\"VATIssuerCountry\":\"DE\",\"SortyBy\":[\"InvoiceNumber ASC\",\"InvoiceDate DESC\"]},\"Page\":\"1\",\"PageSize\":\"50\"}");

            // Perform API call
            Standard.Models.SearchDocumentsResponse result = null;
            try
            {
                result = await this.controller.SearchDocumentsAsync(requestId, body);
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
                    "{\"RequestId\":\"a8b81c1d-f44a-4365-8113-8958061c0b7e\",\"Status\":\"SUCCESS\",\"Data\":[{\"DocumentReference\":311161,\"InvoiceNumber\":\"6400013693\",\"PayerName\":\"DE00000096\",\"AccountNumber\":\"DE00000096\",\"AccountName\":\"DE00000096\",\"DocumentType\":\"NAT\",\"GrossAmount\":-3141.93,\"NetAmount\":0,\"TaxAmount\":0,\"CurrencyCode\":\"EUR\",\"InvoiceStatus\":\"NEW\",\"InvoiceDate\":\"2023/01/31\",\"DueDate\":\"2023/02/07\",\"VATCountryISOCode\":\"DE\"}],\"TotalRecords\":2,\"TotalRecordsOnPage\":2,\"IsFirstPage\":true,\"IsLastPage\":true}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// - This API provides the functionality needed for the screen “EID FILES” in the web interface. It allows retrieving a list of EIDs based on search criteria..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestEidSearch()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.EIDSearchRequest body = ApiHelper.JsonDeserialize<Standard.Models.EIDSearchRequest>("{\"Filters\":{\"ColCoCode\":32,\"AccountGroupCountry\":32,\"AccountGroupId\":[\"122\"],\"AccountGroupName\":null,\"FromDate\":\"2017/08/30\",\"ToDate\":\"2017/10/31\",\"InvoiceType\":\"NAT\",\"InvoiceStatus\":\"NEW\",\"SortBy\":[\"DocumentDate ASC\"]},\"Page\":1,\"PageSize\":10}");

            // Perform API call
            Standard.Models.EIDDocumentResponse result = null;
            try
            {
                result = await this.controller.EidSearchAsync(requestId, body);
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
                    "{\"RequestId\":\"a0a1596f-b242-4672-b513-66c5e5554195\",\"Status\":\"SUCCESS\",\"Data\":[{\"DocumentId\":15029,\"AccountGroupId\":\"122\",\"AccountGroupName\":\"EID-122\",\"DocumentType\":\"INT\",\"DocumentFormat\":\"FLAT\",\"DocumentDate\":\"2022/12/28\",\"NumberOfInvoices\":1,\"FileSize\":1624,\"DocumentStatus\":\"DOWNLOADED\",\"DocumentName\":\"032_122_INT_28122022.TXT\"}],\"PageSize\":1,\"Page\":1,\"TotalPages\":12,\"TotalRecords\":120,\"IsFirstPage\":true,\"IsLastPage\":false}",
                    TestHelper.ConvertStreamToString(HttpCallBack.Response.RawBody),
                    false,
                    true,
                    false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// - This API downloads Invoice Documents i.e., ZIP file with Invoice PDF file and Proofing Elements in XML format from invoice repository..
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestDownload()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.InvoiceDownloadRequest body = ApiHelper.JsonDeserialize<Standard.Models.InvoiceDownloadRequest>("{\"Filters\":{\"ColCoCode\":18,\"PayerNumber\":\"NL99781417\",\"AccountNumber\":[\"NL99781420\"],\"DocumentReference\":[1234567890],\"InvoiceOrSOANumber\":\"2234556\"}}");

            // Perform API call
            Stream result = null;
            try
            {
                result = await this.controller.DownloadAsync(requestId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/octet-stream");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }

        /// <summary>
        /// - This service allows downloading one or more EID documents and the corresponding signature material (where applicable) in one single request 
        ///- The number of EID that can be downloaded at once is limited to 100 documents.
        ///.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestTestEidDownload()
        {
            // Parameters for the API call
            string requestId = "2b0cbe11-f109-4c43-9201-49af0370df1c";
            Standard.Models.EIDDownloadRequest body = ApiHelper.JsonDeserialize<Standard.Models.EIDDownloadRequest>("{\"Filters\":{\"ColCoCode\":18,\"EIDList\":[\"1710187\",\"1734566\"],\"AccountGroupCountry\":18,\"AccountGroupIdList\":[\"26685402\"]}}");

            // Perform API call
            Stream result = null;
            try
            {
                result = await this.controller.EidDownloadAsync(requestId, body);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/octet-stream");

            Assert.IsTrue(
                    TestHelper.AreHeadersProperSubsetOf (
                    headers,
                    HttpCallBack.Response.Headers),
                    "Headers should match");
        }
    }
}