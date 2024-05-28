// <copyright file="CustomerController.cs" company="APIMatic">
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
    /// CustomerController.
    /// </summary>
    public class CustomerController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerController"/> class.
        /// </summary>
        internal CustomerController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// <![CDATA[
        /// This API allows querying the user data of the logged in user.</br>.
        /// This API will return the user access details such as payers and/or accounts. </br>.
        /// This API will also validate that logged in user has access to the requested API, on failure it will return HasAPIAccess flag as false in response.</br>.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Logged in user request body.</param>
        /// <returns>Returns the Models.LoggedInUserResponse response from the API call.</returns>
        public Models.LoggedInUserResponse LoggedinUser(
                string apikey,
                string requestId,
                Models.LoggedInUserRequest body = null)
            => CoreHelper.RunTask(LoggedinUserAsync(apikey, requestId, body));

        /// <summary>
        /// <![CDATA[
        /// This API allows querying the user data of the logged in user.</br>.
        /// This API will return the user access details such as payers and/or accounts. </br>.
        /// This API will also validate that logged in user has access to the requested API, on failure it will return HasAPIAccess flag as false in response.</br>.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Logged in user request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.LoggedInUserResponse response from the API call.</returns>
        public async Task<Models.LoggedInUserResponse> LoggedinUserAsync(
                string apikey,
                string requestId,
                Models.LoggedInUserRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.LoggedInUserResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/user/loggedinuser")
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
        /// This API allows querying the payer accounts details from the Shell Cards.
        /// Platform. It provides flexible search criteria for searching payer.
        /// information and supports paging. .
        /// Paging is applicable only when all the.
        /// payers passed in the input are from the same ColCo. .
        /// However, paging will.
        /// be ignored and the API will return all the matching data by merging the.
        /// data queried from each ColCo when payers passed in the input are from.
        /// multiple ColCos.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Serach payers request body.</param>
        /// <returns>Returns the Models.PayerResponse response from the API call.</returns>
        public Models.PayerResponse Payers(
                string apikey,
                string requestId,
                Models.PayerRequest body = null)
            => CoreHelper.RunTask(PayersAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows querying the payer accounts details from the Shell Cards.
        /// Platform. It provides flexible search criteria for searching payer.
        /// information and supports paging. .
        /// Paging is applicable only when all the.
        /// payers passed in the input are from the same ColCo. .
        /// However, paging will.
        /// be ignored and the API will return all the matching data by merging the.
        /// data queried from each ColCo when payers passed in the input are from.
        /// multiple ColCos.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Serach payers request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.PayerResponse response from the API call.</returns>
        public async Task<Models.PayerResponse> PayersAsync(
                string apikey,
                string requestId,
                Models.PayerRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.PayerResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/customer/payers")
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
        /// This API allows querying the card delivery addresses of a given account from the Shell Cards Platform. .
        /// Only active delivery addresses will be returned.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Customerdetails request body.</param>
        /// <returns>Returns the Models.CustomerDetailResponse response from the API call.</returns>
        public Models.CustomerDetailResponse Customer(
                string apikey,
                string requestId,
                Models.CustomerDetailRequest body = null)
            => CoreHelper.RunTask(CustomerAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows querying the card delivery addresses of a given account from the Shell Cards Platform. .
        /// Only active delivery addresses will be returned.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Customerdetails request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerDetailResponse response from the API call.</returns>
        public async Task<Models.CustomerDetailResponse> CustomerAsync(
                string apikey,
                string requestId,
                Models.CustomerDetailRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerDetailResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/customer/customer")
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
        /// - This operation fetches the International and National Price List and discount values set on pump prices & List Prices.
        /// - It allows searching price list and discount values set on pump prices that are applicable for a given customer .
        /// **Note**: Accounts with cancelled status will not be considered for this operation for the configured .
        /// - When the search is based on customer specific price list then the customer price list is returned based on the associated pricing customer.
        /// - The discount values set on pump prices, which are returned by the operation are always customer specific values based on the customer associated price rules.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Customerdetails request body.</param>
        /// <returns>Returns the Models.CustomerPriceListResponse response from the API call.</returns>
        public Models.CustomerPriceListResponse CustomerPriceList(
                string apikey,
                string requestId,
                Models.CustomerPriceListRequest body = null)
            => CoreHelper.RunTask(CustomerPriceListAsync(apikey, requestId, body));

        /// <summary>
        /// <![CDATA[
        /// - This operation fetches the International and National Price List and discount values set on pump prices & List Prices.
        /// - It allows searching price list and discount values set on pump prices that are applicable for a given customer .
        /// **Note**: Accounts with cancelled status will not be considered for this operation for the configured .
        /// - When the search is based on customer specific price list then the customer price list is returned based on the associated pricing customer.
        /// - The discount values set on pump prices, which are returned by the operation are always customer specific values based on the customer associated price rules.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Customerdetails request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CustomerPriceListResponse response from the API call.</returns>
        public async Task<Models.CustomerPriceListResponse> CustomerPriceListAsync(
                string apikey,
                string requestId,
                Models.CustomerPriceListRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CustomerPriceListResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v2/customer/pricelist")
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
        /// This API allows querying the customer account details from the Shell Cards Platform. .
        /// It provides a flexible search criterion and supports paging".
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.AccountResponse response from the API call.</returns>
        public Models.AccountResponse Accounts(
                string apikey,
                string requestId,
                Models.AccountRequest body = null)
            => CoreHelper.RunTask(AccountsAsync(apikey, requestId, body));

        /// <summary>
        /// This API allows querying the customer account details from the Shell Cards Platform. .
        /// It provides a flexible search criterion and supports paging".
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AccountResponse response from the API call.</returns>
        public async Task<Models.AccountResponse> AccountsAsync(
                string apikey,
                string requestId,
                Models.AccountRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AccountResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/customer/accounts")
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
        /// This operation allows querying card types that are associated to the given account and are allowed to be shown to users.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Get CardType Request Body.</param>
        /// <returns>Returns the Models.CardTypeResponse response from the API call.</returns>
        public Models.CardTypeResponse CardType(
                string apikey,
                string requestId,
                Models.CardTypeRequest body = null)
            => CoreHelper.RunTask(CardTypeAsync(apikey, requestId, body));

        /// <summary>
        /// This operation allows querying card types that are associated to the given account and are allowed to be shown to users.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Get CardType Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardTypeResponse response from the API call.</returns>
        public async Task<Models.CardTypeResponse> CardTypeAsync(
                string apikey,
                string requestId,
                Models.CardTypeRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardTypeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v2/customer/cardtype")
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
        /// This operation allows querying the card group details . It provides flexible search criteria and supports paging.\.
        /// When the card group type is configured as ‘Vertical’ in cards platform, this operation will return all card groups from the given account or if no account is passed in the input, then will return card groups from all the accounts under the payer.
        /// When the card group type is configured as ‘Horizontal’ in cards platform, this API will return all card groups configured directly under the payer.
        /// Accounts with cancelled status will not be considered for cardgroups search for the configured (E.g., SFH) set of client apps.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Request Body.</param>
        /// <returns>Returns the Models.CardGroupResponse response from the API call.</returns>
        public Models.CardGroupResponse CardGroups(
                string apikey,
                string requestId,
                Models.CardGroupRequest body = null)
            => CoreHelper.RunTask(CardGroupsAsync(apikey, requestId, body));

        /// <summary>
        /// This operation allows querying the card group details . It provides flexible search criteria and supports paging.\.
        /// When the card group type is configured as ‘Vertical’ in cards platform, this operation will return all card groups from the given account or if no account is passed in the input, then will return card groups from all the accounts under the payer.
        /// When the card group type is configured as ‘Horizontal’ in cards platform, this API will return all card groups configured directly under the payer.
        /// Accounts with cancelled status will not be considered for cardgroups search for the configured (E.g., SFH) set of client apps.
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: Request Body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.CardGroupResponse response from the API call.</returns>
        public async Task<Models.CardGroupResponse> CardGroupsAsync(
                string apikey,
                string requestId,
                Models.CardGroupRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CardGroupResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/customer/cardgroups")
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
        /// This operation allows users to fetch audit data of account or card operations performed by users of a given customer.
        /// The audit data includes details of below API operations.
        /// * Order Card .
        /// * Create Card Group .
        /// * PIN reminder .
        /// * Move Cards .
        /// * Update Card Status .
        /// * Update Card Group .
        /// * Auto renew .
        /// * Bulk card order .
        /// * Bulk card block .
        /// * Bulk Card Order (Multi Account) .
        /// * BCOSummary .
        /// * BCOMultiAccountSummary .
        /// * BCBSummary .
        /// * Mobile Payment .
        /// * Registration .
        /// * Fund Transfer (Scheduled & Realtime) .
        /// * Delivery Address Update.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: request body.</param>
        /// <returns>Returns the Models.AuditResponse response from the API call.</returns>
        public Models.AuditResponse AuditReport(
                string apikey,
                string requestId,
                Models.AuditRequest body = null)
            => CoreHelper.RunTask(AuditReportAsync(apikey, requestId, body));

        /// <summary>
        /// <![CDATA[
        /// This operation allows users to fetch audit data of account or card operations performed by users of a given customer.
        /// The audit data includes details of below API operations.
        /// * Order Card .
        /// * Create Card Group .
        /// * PIN reminder .
        /// * Move Cards .
        /// * Update Card Status .
        /// * Update Card Group .
        /// * Auto renew .
        /// * Bulk card order .
        /// * Bulk card block .
        /// * Bulk Card Order (Multi Account) .
        /// * BCOSummary .
        /// * BCOMultiAccountSummary .
        /// * BCBSummary .
        /// * Mobile Payment .
        /// * Registration .
        /// * Fund Transfer (Scheduled & Realtime) .
        /// * Delivery Address Update.
        /// ]]>
        /// </summary>
        /// <param name="apikey">Required parameter: This is the API key of the specific environment which needs to be passed by the client..</param>
        /// <param name="requestId">Required parameter: Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request..</param>
        /// <param name="body">Optional parameter: request body.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.AuditResponse response from the API call.</returns>
        public async Task<Models.AuditResponse> AuditReportAsync(
                string apikey,
                string requestId,
                Models.AuditRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuditResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/fleetmanagement/v1/customer/auditreport")
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
    }
}