// <copyright file="TransactionController.cs" company="APIMatic">
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
    /// TransactionController.
    /// </summary>
    public class TransactionController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionController"/> class.
        /// </summary>
        internal TransactionController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria and supports paging. .
        /// Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///     * Search by account.
        ///     * Search by card.
        ///   * Get sales items only.
        ///     * Search by transaction Id or location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by driver name or vehicle registration number.
        ///     * Search by card group.
        ///     * Search by fuel only transactions.
        ///     * Search by product.
        ///   .
        ///  This API fetches transactions for a period based on the below parameters and priority order:.
        /// 1.	InvoiceNumber.
        ///  2.	InvoiceDate.
        ///  3.	FromDate, ToDate.
        /// 4.	PostingFromDate, PostingToDate (Can be used only when IncludeFees = false).
        ///  5.	InvoiceDateFrom, InvoiceDateTo.
        ///  6.	Period.
        ///  This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.
        /// If none of the above parameters are provided then last 7 days transactions will be fetched.
        /// This operation can fetch transactions that are old up to 24 (configurable) months. However, the date range between any of the ‘From’ and ‘To’ dates in the above combination cannot be more than 210 (configurable) days.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Priced Transaction Request Body.</param>
        /// <returns>Returns the Models.PricedTransactionResponse response from the API call.</returns>
        public Models.PricedTransactionResponse PricedTransactions(
                string apikey,
                string requestId,
                Models.PriceTransactionRequest body = null)
            => CoreHelper.RunTask(PricedTransactionsAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria and supports paging. .
        /// Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///     * Search by account.
        ///     * Search by card.
        ///   * Get sales items only.
        ///     * Search by transaction Id or location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by driver name or vehicle registration number.
        ///     * Search by card group.
        ///     * Search by fuel only transactions.
        ///     * Search by product.
        ///   .
        ///  This API fetches transactions for a period based on the below parameters and priority order:.
        /// 1.	InvoiceNumber.
        ///  2.	InvoiceDate.
        ///  3.	FromDate, ToDate.
        /// 4.	PostingFromDate, PostingToDate (Can be used only when IncludeFees = false).
        ///  5.	InvoiceDateFrom, InvoiceDateTo.
        ///  6.	Period.
        ///  This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.
        /// If none of the above parameters are provided then last 7 days transactions will be fetched.
        /// This operation can fetch transactions that are old up to 24 (configurable) months. However, the date range between any of the ‘From’ and ‘To’ dates in the above combination cannot be more than 210 (configurable) days.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Priced Transaction Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PricedTransactionResponse response from the API call.</returns>
        public async Task<Models.PricedTransactionResponse> PricedTransactionsAsync(
                string apikey,
                string requestId,
                Models.PriceTransactionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PricedTransactionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/pricedtransactions")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns the transaction summary data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria. .
        /// The API also supports returning Fee Items. Transactions posted for fee items that are in error are not included in the summary.
        /// The endpoint supports the exact same search criteria as the endpoint *transaction/prciedtransactions*.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///     * Search by account.
        ///     * Search by card.
        ///   * Get sales items only.
        ///     * Search by transaction Id or location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by driver name or vehicle registration number.
        ///     * Search by card group.
        ///     * Search by fuel only transactions.
        ///     * Search by product.
        ///   .
        ///  This API fetches transactions for a period based on the below parameters and priority order:.
        ///  1.	InvoiceNumber.
        ///  2.	InvoiceDate.
        ///  3.	FromDate, ToDate.
        ///  4.	PostingFromDate, PostingToDate (Can be used only when IncludeFees = false).
        ///  5.	InvoiceDateFrom, InvoiceDateTo.
        ///  6.	Period.
        ///  This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.
        /// If none of the above parameters are provided then last 7 days transactions will be fetched.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: PricedSummary RequestBody.</param>
        /// <returns>Returns the Models.PricedTransSummaryResponse response from the API call.</returns>
        public Models.PricedTransSummaryResponse PricedTransactionsSummary(
                string apikey,
                string requestId,
                Models.PriceTransSummaryRequest body = null)
            => CoreHelper.RunTask(PricedTransactionsSummaryAsync(apikey, requestId, body));

        /// <summary>
        /// This API returns the transaction summary data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria. .
        /// The API also supports returning Fee Items. Transactions posted for fee items that are in error are not included in the summary.
        /// The endpoint supports the exact same search criteria as the endpoint *transaction/prciedtransactions*.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///     * Search by account.
        ///     * Search by card.
        ///   * Get sales items only.
        ///     * Search by transaction Id or location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by driver name or vehicle registration number.
        ///     * Search by card group.
        ///     * Search by fuel only transactions.
        ///     * Search by product.
        ///   .
        ///  This API fetches transactions for a period based on the below parameters and priority order:.
        ///  1.	InvoiceNumber.
        ///  2.	InvoiceDate.
        ///  3.	FromDate, ToDate.
        ///  4.	PostingFromDate, PostingToDate (Can be used only when IncludeFees = false).
        ///  5.	InvoiceDateFrom, InvoiceDateTo.
        ///  6.	Period.
        ///  This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.
        /// If none of the above parameters are provided then last 7 days transactions will be fetched.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: PricedSummary RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PricedTransSummaryResponse response from the API call.</returns>
        public async Task<Models.PricedTransSummaryResponse> PricedTransactionsSummaryAsync(
                string apikey,
                string requestId,
                Models.PriceTransSummaryRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PricedTransSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/pricedtransactionssummary")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items) for multiple payers. It provides a flexible search criteria and supports paging. .
        /// Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.
        /// At least one payer should be provided. Multiple payers must belong to the same payer group.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions for multiple payers.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///   * Get sales items only for multiple payers.
        ///     * Search by transaction location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by fuel only transactions.
        ///  .
        ///  This API fetches transactions for a period based on the below parameters and priority order:.
        ///  1.	InvoiceNumber.
        ///  2.	InvoiceDate.
        ///  3.	FromDate, ToDate.
        ///  4.	PostingFromDate, PostingToDate (Can be used only when IncludeFees = false).
        ///  5.	InvoiceDateFrom, InvoiceDateTo.
        ///  6.	Period.
        ///  This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.
        /// If none of the above parameters are provided then last 7 days transactions will be fetched.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: MultiPayer RequestBody.</param>
        /// <returns>Returns the Models.MultiPricedTransactionResponse response from the API call.</returns>
        public Models.MultiPricedTransactionResponse MultipricedTransactions(
                string apikey,
                string requestId,
                Models.MultiPricedTransactionRequest body = null)
            => CoreHelper.RunTask(MultipricedTransactionsAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items) for multiple payers. It provides a flexible search criteria and supports paging. .
        /// Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.
        /// At least one payer should be provided. Multiple payers must belong to the same payer group.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions for multiple payers.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///   * Get sales items only for multiple payers.
        ///     * Search by transaction location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by fuel only transactions.
        ///  .
        ///  This API fetches transactions for a period based on the below parameters and priority order:.
        ///  1.	InvoiceNumber.
        ///  2.	InvoiceDate.
        ///  3.	FromDate, ToDate.
        ///  4.	PostingFromDate, PostingToDate (Can be used only when IncludeFees = false).
        ///  5.	InvoiceDateFrom, InvoiceDateTo.
        ///  6.	Period.
        ///  This API considers only one of the above set of parameters at a time. For example, if InvoiceNumber and Period are provided in the input then Period is ignored and transactions associated to the given invoice number are returned.
        /// If none of the above parameters are provided then last 7 days transactions will be fetched.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: MultiPayer RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.MultiPricedTransactionResponse response from the API call.</returns>
        public async Task<Models.MultiPricedTransactionResponse> MultipricedTransactionsAsync(
                string apikey,
                string requestId,
                Models.MultiPricedTransactionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.MultiPricedTransactionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/multipayerspricedtransactions")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// This operation is to provide the expenditure analysis for a card for the past 7 months.
        /// The response contains a daily summary of the transactions (billed & unbilled) from 1st of the last 7 months for the requested card grouped by card, site-group and product.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Card Usage Summary RequestBody.</param>
        /// <returns>Returns the Models.CardUsageSummaryResponse response from the API call.</returns>
        public Models.CardUsageSummaryResponse CardUsageSummary(
                string apikey,
                string requestId,
                Models.CardUsageSummaryRequest body = null)
            => CoreHelper.RunTask(CardUsageSummaryAsync(apikey, requestId, body));

        /// <summary>
        /// <![CDATA[
        /// This operation is to provide the expenditure analysis for a card for the past 7 months.
        /// The response contains a daily summary of the transactions (billed & unbilled) from 1st of the last 7 months for the requested card grouped by card, site-group and product.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Card Usage Summary RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardUsageSummaryResponse response from the API call.</returns>
        public async Task<Models.CardUsageSummaryResponse> CardUsageSummaryAsync(
                string apikey,
                string requestId,
                Models.CardUsageSummaryRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardUsageSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/cardusagesummary")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API provides the details of the bonus and/or association bonus rules setup for the given payer and that are active on the current date.
        /// - This API also returns the details of the monthly breakup of current period consumption as well as the details of the previously calculated bonus and consumption of the applicable payers.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: VolumeBasedBonus RequestBody.</param>
        /// <returns>Returns the Models.VolumeBasedBonusResponse response from the API call.</returns>
        public Models.VolumeBasedBonusResponse VolumeBasedBonus(
                string apikey,
                string requestId,
                Models.VolumeBasedBonusRequest body = null)
            => CoreHelper.RunTask(VolumeBasedBonusAsync(apikey, requestId, body));

        /// <summary>
        /// - This API provides the details of the bonus and/or association bonus rules setup for the given payer and that are active on the current date.
        /// - This API also returns the details of the monthly breakup of current period consumption as well as the details of the previously calculated bonus and consumption of the applicable payers.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: VolumeBasedBonus RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VolumeBasedBonusResponse response from the API call.</returns>
        public async Task<Models.VolumeBasedBonusResponse> VolumeBasedBonusAsync(
                string apikey,
                string requestId,
                Models.VolumeBasedBonusRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VolumeBasedBonusResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/volumebasedbonus")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API will return the details of the in arrear fee rule applied to the payer along with details of locations, products, tiers as applied.  .
        /// - It will also show historical and current volume consumption and related tier applied for the following month.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: VolumeBasedPricing RequestBody.</param>
        /// <returns>Returns the Models.VolumeBasedPricingResponse response from the API call.</returns>
        public Models.VolumeBasedPricingResponse VolumeBasedPricing(
                string apikey,
                string requestId,
                Models.VolumeBasedPricingRequest body = null)
            => CoreHelper.RunTask(VolumeBasedPricingAsync(apikey, requestId, body));

        /// <summary>
        /// - This API will return the details of the in arrear fee rule applied to the payer along with details of locations, products, tiers as applied.  .
        /// - It will also show historical and current volume consumption and related tier applied for the following month.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: VolumeBasedPricing RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.VolumeBasedPricingResponse response from the API call.</returns>
        public async Task<Models.VolumeBasedPricingResponse> VolumeBasedPricingAsync(
                string apikey,
                string requestId,
                Models.VolumeBasedPricingRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.VolumeBasedPricingResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/volumebasedpricing")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns the fee/charges levied from a  customer's account in a billing period or date range. The API returns both billed and unbilled fee items.  .
        /// To get the summary of charges, the endpoint *transaction/feessummary* should be called with the same input criteria.
        /// #### Supported operations.
        ///   * Get fees by invoice status.
        ///   * Get fees by date period.
        ///   * Get fees by account.
        ///   * Get fees by card Id or PAN.
        ///   * Get fees by fee type charges.
        ///   * Get fees including cancelled items.
        ///   * Get fees by line item description.
        ///   * Get fees by product.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Transaction Fees RequestBody.</param>
        /// <returns>Returns the Models.TransactionFeesResponse response from the API call.</returns>
        public Models.TransactionFeesResponse Fees(
                string apikey,
                string requestId,
                Models.TransactionFeesRequest body = null)
            => CoreHelper.RunTask(FeesAsync(apikey, requestId, body));

        /// <summary>
        /// This API returns the fee/charges levied from a  customer's account in a billing period or date range. The API returns both billed and unbilled fee items.  .
        /// To get the summary of charges, the endpoint *transaction/feessummary* should be called with the same input criteria.
        /// #### Supported operations.
        ///   * Get fees by invoice status.
        ///   * Get fees by date period.
        ///   * Get fees by account.
        ///   * Get fees by card Id or PAN.
        ///   * Get fees by fee type charges.
        ///   * Get fees including cancelled items.
        ///   * Get fees by line item description.
        ///   * Get fees by product.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Transaction Fees RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionFeesResponse response from the API call.</returns>
        public async Task<Models.TransactionFeesResponse> FeesAsync(
                string apikey,
                string requestId,
                Models.TransactionFeesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionFeesResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/fees")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This API returns the summary data of the fee/charges levied from a customer's account in a billing period or date range. The API returns both billed and unbilled fee items. .
        /// The endpoint supports the exact same search criteria as the endpoint *transaction/feessummary*.
        /// #### Supported operations.
        ///   * Get fees by invoice status.
        ///   * Get fees by date period.
        ///   * Get fees by account.
        ///   * Get fees by card Id or PAN.
        ///   * Get fees by fee type charges.
        ///   * Get fees including cancelled items.
        ///   * Get fees by line item description.
        ///   * Get fees by product.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: FeeSummary RequestBody.</param>
        /// <returns>Returns the Models.FeeSummaryResponse response from the API call.</returns>
        public Models.FeeSummaryResponse FeeSummaryResponse(
                string apikey,
                string requestId,
                Models.TransactionFeesRequest body = null)
            => CoreHelper.RunTask(FeeSummaryResponseAsync(apikey, requestId, body));

        /// <summary>
        /// This API returns the summary data of the fee/charges levied from a customer's account in a billing period or date range. The API returns both billed and unbilled fee items. .
        /// The endpoint supports the exact same search criteria as the endpoint *transaction/feessummary*.
        /// #### Supported operations.
        ///   * Get fees by invoice status.
        ///   * Get fees by date period.
        ///   * Get fees by account.
        ///   * Get fees by card Id or PAN.
        ///   * Get fees by fee type charges.
        ///   * Get fees including cancelled items.
        ///   * Get fees by line item description.
        ///   * Get fees by product.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: FeeSummary RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FeeSummaryResponse response from the API call.</returns>
        public async Task<Models.FeeSummaryResponse> FeeSummaryResponseAsync(
                string apikey,
                string requestId,
                Models.TransactionFeesRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FeeSummaryResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/feessummary")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// <![CDATA[
        /// - This API returns the customer an overview of how many transactions, how much fuel volume used over a given period and the total volume used by a card .
        /// - This operation response will contains card & transaction details for given period aggregated by payer, account, cardGroup, PAN, DriverName and VRN.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: FuelConsumption RequestBody.</param>
        /// <returns>Returns the Models.FuelConsumptionResponse response from the API call.</returns>
        public Models.FuelConsumptionResponse FuelConsumption(
                string apikey,
                string requestId,
                Models.FuelConsumptionRequest body = null)
            => CoreHelper.RunTask(FuelConsumptionAsync(apikey, requestId, body));

        /// <summary>
        /// <![CDATA[
        /// - This API returns the customer an overview of how many transactions, how much fuel volume used over a given period and the total volume used by a card .
        /// - This operation response will contains card & transaction details for given period aggregated by payer, account, cardGroup, PAN, DriverName and VRN.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: FuelConsumption RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.FuelConsumptionResponse response from the API call.</returns>
        public async Task<Models.FuelConsumptionResponse> FuelConsumptionAsync(
                string apikey,
                string requestId,
                Models.FuelConsumptionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.FuelConsumptionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/fuelconsumption")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API allows the users to update the odometer readings on the sales items (transaction data) .
        /// - This is an asynchronous operation. If opted, the user will be notified on completion of processing.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: updateOdometer RequestBody.</param>
        /// <returns>Returns the Models.UpdateOdometerResponse response from the API call.</returns>
        public Models.UpdateOdometerResponse UpdateOdometer(
                string apikey,
                string requestId,
                Models.UpdateOdometerRequest body = null)
            => CoreHelper.RunTask(UpdateOdometerAsync(apikey, requestId, body));

        /// <summary>
        /// - This API allows the users to update the odometer readings on the sales items (transaction data) .
        /// - This is an asynchronous operation. If opted, the user will be notified on completion of processing.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: updateOdometer RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.UpdateOdometerResponse response from the API call.</returns>
        public async Task<Models.UpdateOdometerResponse> UpdateOdometerAsync(
                string apikey,
                string requestId,
                Models.UpdateOdometerRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.UpdateOdometerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/updateodometer")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// - This API provides the details of the Cards or Transaction related exceptions based on the given conditions for the Requested period.
        /// - This API will return the Transactions related exceptions when the OutputType input parameter is passed as ‘Transaction’ else will return the Cards related exceptions.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Transaction Exceptions RequestBody.</param>
        /// <returns>Returns the Models.TransactionExceptionsResponse response from the API call.</returns>
        public Models.TransactionExceptionsResponse TransactionExceptions(
                string apikey,
                string requestId,
                Models.TransactionExceptionsRequest body = null)
            => CoreHelper.RunTask(TransactionExceptionsAsync(apikey, requestId, body));

        /// <summary>
        /// - This API provides the details of the Cards or Transaction related exceptions based on the given conditions for the Requested period.
        /// - This API will return the Transactions related exceptions when the OutputType input parameter is passed as ‘Transaction’ else will return the Cards related exceptions.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Transaction Exceptions RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.TransactionExceptionsResponse response from the API call.</returns>
        public async Task<Models.TransactionExceptionsResponse> TransactionExceptionsAsync(
                string apikey,
                string requestId,
                Models.TransactionExceptionsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TransactionExceptionsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/transaction/exceptions")
                  .WithAuth("BasicAuth")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("apikey", apikey))
                      .Header(_header => _header.Setup("RequestId", requestId))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("The server cannot or will not process the request  due to something that is perceived to be a client\r\n error (e.g., malformed request syntax, invalid \r\n request message framing, or deceptive request routing).", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("The request has not been applied because it lacks valid  authentication credentials for the target resource.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("403", CreateErrorCase("The server understood the request but refuses to authorize it.\r\n", (_reason, _context) => new ErrorUserAccessError1Exception(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("The origin server did not find a current representation  for the target resource or is not willing to disclose  that one exists.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("The server encountered an unexpected condition the prevented it from fulfilling the request.\r\n", (_reason, _context) => new DefaultErrorException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This endpoint allows querying last 48 hours of transaction data of Shell Card (i.e. Priced, Billed, Unbilled etc. sales items). It provides a flexible search criteria and supports pagination. E.g., if the request is made at 08:30 AM on 18 Aug 2022 then transactions until 16 Aug 2022 08:30 AM (including) can be retrieved.
        /// #### Supported operations.
        ///     * Search by Date and Time range (within the last 48 hours only).
        ///     * Search by Payer and/or Account number.
        ///     * Search by Card.
        ///     * Search by Purchased Country.
        ///     * Search by Transaction posting date.
        ///     * Search by Driver Name or Vehicle registration number.
        ///     * Search by Fuel only transactions.
        ///     * Search by Product and/or Product group.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: New Recent Transaction RequestBody.</param>
        /// <returns>Returns the Models.RecentTransactionsResponse response from the API call.</returns>
        public Models.RecentTransactionsResponse RecentTransactionsNew(
                string requestId,
                Models.RecentTransactionRequest body = null)
            => CoreHelper.RunTask(RecentTransactionsNewAsync(requestId, body));

        /// <summary>
        /// This endpoint allows querying last 48 hours of transaction data of Shell Card (i.e. Priced, Billed, Unbilled etc. sales items). It provides a flexible search criteria and supports pagination. E.g., if the request is made at 08:30 AM on 18 Aug 2022 then transactions until 16 Aug 2022 08:30 AM (including) can be retrieved.
        /// #### Supported operations.
        ///     * Search by Date and Time range (within the last 48 hours only).
        ///     * Search by Payer and/or Account number.
        ///     * Search by Card.
        ///     * Search by Purchased Country.
        ///     * Search by Transaction posting date.
        ///     * Search by Driver Name or Vehicle registration number.
        ///     * Search by Fuel only transactions.
        ///     * Search by Product and/or Product group.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: New Recent Transaction RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.RecentTransactionsResponse response from the API call.</returns>
        public async Task<Models.RecentTransactionsResponse> RecentTransactionsNewAsync(
                string requestId,
                Models.RecentTransactionRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.RecentTransactionsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction-data/v1/recent")
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
        /// This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria and supports paging. .
        /// The version 2 is an enhancement to the version 1 where EV transactions and their details are added in the response. .
        /// Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///     * Search by account.
        ///     * Search by card.
        ///   * Get sales items only.
        ///     * Search by transaction Id or location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by driver name or vehicle registration number.
        ///     * Search by card group.
        ///     * Search by fuel only transactions.
        ///     * Search by product.
        ///  * EV transaction details - Below are EV specific parameters.
        ///     * EVOperator.
        ///     * EVSerialId.
        ///     * EVChargePointSerial.
        ///     * EVChargePointConnectorType.
        ///     * EVChargePointConnectorTypeDescription.
        ///     * EVChargeDuration.
        ///     * EVChargeStartDate.
        ///     * EVChargeStartTime.
        ///     * EVChargeEndDate.
        ///     * EVChargeEndTime.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Priced TransactionV2 RequestBody.</param>
        /// <returns>Returns the Models.PricedTransactionResponseV2 response from the API call.</returns>
        public Models.PricedTransactionResponseV2 PricedTransactionsV2(
                string requestId,
                Models.PricedTransactionRequestV2 body = null)
            => CoreHelper.RunTask(PricedTransactionsV2Async(requestId, body));

        /// <summary>
        /// This API allows querying transaction data (i.e. Priced, Billed and Unbilled sales items). It provides a flexible search criteria and supports paging. .
        /// The version 2 is an enhancement to the version 1 where EV transactions and their details are added in the response. .
        /// Transactions that are posted but not yet priced, billed or that are in error will not be returned by this API. The API also supports returning Fee Items.
        /// #### Supported operations.
        ///   * Get sales items and fee transactions.
        ///     * Search by invoice status.
        ///     * Search by fixed date period.
        ///     * Search by date range.
        ///     * Search by account.
        ///     * Search by card.
        ///   * Get sales items only.
        ///     * Search by transaction Id or location.
        ///     * Search by transaction posting date.
        ///     * Search by invoice number or date.
        ///     * Search by driver name or vehicle registration number.
        ///     * Search by card group.
        ///     * Search by fuel only transactions.
        ///     * Search by product.
        ///  * EV transaction details - Below are EV specific parameters.
        ///     * EVOperator.
        ///     * EVSerialId.
        ///     * EVChargePointSerial.
        ///     * EVChargePointConnectorType.
        ///     * EVChargePointConnectorTypeDescription.
        ///     * EVChargeDuration.
        ///     * EVChargeStartDate.
        ///     * EVChargeStartTime.
        ///     * EVChargeEndDate.
        ///     * EVChargeEndTime.
        /// </summary>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Priced TransactionV2 RequestBody.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PricedTransactionResponseV2 response from the API call.</returns>
        public async Task<Models.PricedTransactionResponseV2> PricedTransactionsV2Async(
                string requestId,
                Models.PricedTransactionRequestV2 body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PricedTransactionResponseV2>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transaction-data/v1/priced")
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