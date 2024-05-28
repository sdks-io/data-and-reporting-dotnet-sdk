// <copyright file="InvoiceController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellDataReportingAPIs.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using Newtonsoft.Json.Converters;
    using ShellDataReportingAPIs.Standard;
    using ShellDataReportingAPIs.Standard.Exceptions;
    using ShellDataReportingAPIs.Standard.Http.Client;
    using ShellDataReportingAPIs.Standard.Utilities;
    using System.Net.Http;

    /// <summary>
    /// InvoiceController.
    /// </summary>
    public class InvoiceController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceController"/> class.
        /// </summary>
        internal InvoiceController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This API allows to search invoice data in the Shell Card Platform. It provides flexible search criteria in the request body and supports paging. .
        /// This API will also query the relevant invoice documents list and return a reference number that can be used to download invoice documents (PDF and Proofing elements in a zip file).
        /// #### Supported operations.
        ///   * Search invoices by account.
        ///   * Search invoices by invoice type or invoice status.
        ///   * Search invoices by invoice id or number.
        ///   * Search invoices by invoiced country.
        ///   * Search invoices including einvoices.
        ///   * Search invoices by summary document.
        ///   * Search invoices by statement of account.
        ///   * Search invoices by fixed and custom date periods.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Invoice Search RequestBody.</param>
        /// <returns>Returns the Models.InvoiceSearchResponse response from the API call.</returns>
        public Models.InvoiceSearchResponse InvoiceSearch(
                string requestId,
                Models.InvoiceSearchRequest body = null)
            => CoreHelper.RunTask(InvoiceSearchAsync(requestId, body));

        /// <summary>
        /// This API allows to search invoice data in the Shell Card Platform. It provides flexible search criteria in the request body and supports paging. .
        /// This API will also query the relevant invoice documents list and return a reference number that can be used to download invoice documents (PDF and Proofing elements in a zip file).
        /// #### Supported operations.
        ///   * Search invoices by account.
        ///   * Search invoices by invoice type or invoice status.
        ///   * Search invoices by invoice id or number.
        ///   * Search invoices by invoiced country.
        ///   * Search invoices including einvoices.
        ///   * Search invoices by summary document.
        ///   * Search invoices by statement of account.
        ///   * Search invoices by fixed and custom date periods.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Invoice Search RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvoiceSearchResponse response from the API call.</returns>
        public async Task<Models.InvoiceSearchResponse> InvoiceSearchAsync(
                string requestId,
                Models.InvoiceSearchRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvoiceSearchResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/search")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns the high level summary of invoices that match the  given search criteria. The same search criteria as the endpoint `/v1/invoice/search` is supported with the exception of paging related parameters. .
        /// #### Supported operations.
        ///   * Search invoices by account.
        ///   * Search invoices by invoice type or invoice status.
        ///   * Search invoices by invoice id or number.
        ///   * Search invoices by invoiced country.
        ///   * Search invoices including einvoices.
        ///   * Search invoices by summary document.
        ///   * Search invoices by statement of account.
        ///   * Search invoices by fixed and custom date periods.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Invoice Search RequestBody.</param>
        /// <returns>Returns the Models.InvoiceSummaryResponse response from the API call.</returns>
        public Models.InvoiceSummaryResponse InvoiceSummary(
                string requestId,
                Models.InvoiceSummaryRequest body = null)
            => CoreHelper.RunTask(InvoiceSummaryAsync(requestId, body));

        /// <summary>
        /// This API returns the high level summary of invoices that match the  given search criteria. The same search criteria as the endpoint `/v1/invoice/search` is supported with the exception of paging related parameters. .
        /// #### Supported operations.
        ///   * Search invoices by account.
        ///   * Search invoices by invoice type or invoice status.
        ///   * Search invoices by invoice id or number.
        ///   * Search invoices by invoiced country.
        ///   * Search invoices including einvoices.
        ///   * Search invoices by summary document.
        ///   * Search invoices by statement of account.
        ///   * Search invoices by fixed and custom date periods.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Invoice Search RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvoiceSummaryResponse response from the API call.</returns>
        public async Task<Models.InvoiceSummaryResponse> InvoiceSummaryAsync(
                string requestId,
                Models.InvoiceSummaryRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvoiceSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/summary")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows querying the details of the latest statement of account (SOA) generated for a given Payer. .
        /// The endpoint supports querying SOA documents by various input parameters specified in the request body.
        /// #### Supported operations.
        ///   * Search invoice SOA by payer and account.
        ///   * Search invoice SOA including monthly trend (last 13 months invocie trend summary).
        ///   * Search invoice SOA including past SOAs.
        ///   * Search invoice SOA including due/overdue documents.
        ///   * Search invoice SOA including invoice summary.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: StatementOfAccount RequestBody.</param>
        /// <returns>Returns the Models.StatementOfAccountResponse response from the API call.</returns>
        public Models.StatementOfAccountResponse StatementOfAccount(
                string requestId,
                Models.StatementOfAccountRequest body = null)
            => CoreHelper.RunTask(StatementOfAccountAsync(requestId, body));

        /// <summary>
        /// This API allows querying the details of the latest statement of account (SOA) generated for a given Payer. .
        /// The endpoint supports querying SOA documents by various input parameters specified in the request body.
        /// #### Supported operations.
        ///   * Search invoice SOA by payer and account.
        ///   * Search invoice SOA including monthly trend (last 13 months invocie trend summary).
        ///   * Search invoice SOA including past SOAs.
        ///   * Search invoice SOA including due/overdue documents.
        ///   * Search invoice SOA including invoice summary.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: StatementOfAccount RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.StatementOfAccountResponse response from the API call.</returns>
        public async Task<Models.StatementOfAccountResponse> StatementOfAccountAsync(
                string requestId,
                Models.StatementOfAccountRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.StatementOfAccountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/statementofaccount")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API will return the list of Invoice Dates and Numbers for the given date range. If the dates are not provided then it will fetch the data for past 13 months.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: StatementOfAccount RequestBody.</param>
        /// <returns>Returns the Models.InvoiceDatesResponseData response from the API call.</returns>
        public Models.InvoiceDatesResponseData Dates(
                string requestId,
                Models.InvoiceDatesRequest body = null)
            => CoreHelper.RunTask(DatesAsync(requestId, body));

        /// <summary>
        /// - This API will return the list of Invoice Dates and Numbers for the given date range. If the dates are not provided then it will fetch the data for past 13 months.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: StatementOfAccount RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.InvoiceDatesResponseData response from the API call.</returns>
        public async Task<Models.InvoiceDatesResponseData> DatesAsync(
                string requestId,
                Models.InvoiceDatesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.InvoiceDatesResponseData>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/dates")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API will allow querying of SOA from different systems.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: searchstatementofaccount RequestBody.</param>
        /// <returns>Returns the Models.SearchStatementOfAccountResponse response from the API call.</returns>
        public Models.SearchStatementOfAccountResponse SearchStatementOfAccount(
                string requestId,
                Models.SearchStatementOfAccountRequest body = null)
            => CoreHelper.RunTask(SearchStatementOfAccountAsync(requestId, body));

        /// <summary>
        /// - This API will allow querying of SOA from different systems.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: searchstatementofaccount RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SearchStatementOfAccountResponse response from the API call.</returns>
        public async Task<Models.SearchStatementOfAccountResponse> SearchStatementOfAccountAsync(
                string requestId,
                Models.SearchStatementOfAccountRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchStatementOfAccountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/searchstatementofaccount")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API allows querying the details of all invoices successfully uploaded to the Worldline invoice repository and file reference numbers for downloading.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: SearchDocuments RequestBody.</param>
        /// <returns>Returns the Models.SearchDocumentsResponse response from the API call.</returns>
        public Models.SearchDocumentsResponse SearchDocuments(
                string requestId,
                Models.SearchDocumentsRequest body = null)
            => CoreHelper.RunTask(SearchDocumentsAsync(requestId, body));

        /// <summary>
        /// - This API allows querying the details of all invoices successfully uploaded to the Worldline invoice repository and file reference numbers for downloading.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: SearchDocuments RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.SearchDocumentsResponse response from the API call.</returns>
        public async Task<Models.SearchDocumentsResponse> SearchDocumentsAsync(
                string requestId,
                Models.SearchDocumentsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.SearchDocumentsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/searchdocuments")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API provides the functionality needed for the screen “EID FILES” in the web interface. It allows retrieving a list of EIDs based on search criteria.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: EIDSearch RequestBody.</param>
        /// <returns>Returns the Models.EIDDocumentResponse response from the API call.</returns>
        public Models.EIDDocumentResponse EidSearch(
                string requestId,
                Models.EIDSearchRequest body = null)
            => CoreHelper.RunTask(EidSearchAsync(requestId, body));

        /// <summary>
        /// - This API provides the functionality needed for the screen “EID FILES” in the web interface. It allows retrieving a list of EIDs based on search criteria.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: EIDSearch RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.EIDDocumentResponse response from the API call.</returns>
        public async Task<Models.EIDDocumentResponse> EidSearchAsync(
                string requestId,
                Models.EIDSearchRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.EIDDocumentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/eidsearch")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API downloads Invoice Documents i.e., ZIP file with Invoice PDF file and Proofing Elements in XML format from invoice repository.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Invoice Download RequestBody.</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream Download(
                string requestId,
                Models.InvoiceDownloadRequest body = null)
            => CoreHelper.RunTask(DownloadAsync(requestId, body));

        /// <summary>
        /// - This API downloads Invoice Documents i.e., ZIP file with Invoice PDF file and Proofing Elements in XML format from invoice repository.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Invoice Download RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> DownloadAsync(
                string requestId,
                Models.InvoiceDownloadRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/download")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This service allows downloading one or more EID documents and the corresponding signature material (where applicable) in one single request .
        /// - The number of EID that can be downloaded at once is limited to 100 documents.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: EIDInvoice Download RequestBody.</param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public Stream EidDownload(
                string requestId,
                Models.EIDDownloadRequest body = null)
            => CoreHelper.RunTask(EidDownloadAsync(requestId, body));

        /// <summary>
        /// - This service allows downloading one or more EID documents and the corresponding signature material (where applicable) in one single request .
        /// - The number of EID that can be downloaded at once is limited to 100 documents.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: EIDInvoice Download RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Stream response from the API call.</returns>
        public async Task<Stream> EidDownloadAsync(
                string requestId,
                Models.EIDDownloadRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Stream>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/invoice-management/v1/eiddownload")
                  .WithAuth("BearerToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request due to something that is perceived to be a client error (e.g., malformed request syntax, invalid request message framing, or deceptive request routing).\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("Forbidden", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\n", (_reason, _context) => new ErrorObjectException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition that  prevented it from fulfilling the request.\n", (_reason, _context) => new ErrorObjectException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}