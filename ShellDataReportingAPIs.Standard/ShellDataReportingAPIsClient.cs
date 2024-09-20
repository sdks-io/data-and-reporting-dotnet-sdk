// <copyright file="ShellDataReportingAPIsClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using ShellDataReportingAPIs.Standard.Authentication;
using ShellDataReportingAPIs.Standard.Controllers;
using ShellDataReportingAPIs.Standard.Http.Client;
using ShellDataReportingAPIs.Standard.Utilities;

namespace ShellDataReportingAPIs.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class ShellDataReportingAPIsClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.SIT, new Dictionary<Enum, string>
                {
                    { Server.OAuthServer, "https://api-test.shell.com" },
                    { Server.Shell, "https://api-test.shell.com/test" },
                }
            },
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.OAuthServer, "https://api.shell.com" },
                    { Server.Shell, "https://api.shell.com" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<CustomerController> customer;
        private readonly Lazy<TransactionController> transaction;
        private readonly Lazy<InvoiceController> invoice;
        private readonly Lazy<OAuthAuthorizationController> oAuthAuthorization;

        private ShellDataReportingAPIsClient(
            Environment environment,
            BasicAuthModel basicAuthModel,
            BearerTokenModel bearerTokenModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            BasicAuthModel = basicAuthModel;
            var basicAuthManager = new BasicAuthManager(basicAuthModel);
            BearerTokenModel = bearerTokenModel;
            var bearerTokenManager = new BearerTokenManager(bearerTokenModel);
            bearerTokenManager.ApplyGlobalConfiguration(() => OAuthAuthorizationController);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"BasicAuth", basicAuthManager},
                    {"BearerToken", bearerTokenManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Shell)
                .UserAgent(userAgent)
                .Build();

            BasicAuthCredentials = basicAuthManager;
            BearerTokenCredentials = bearerTokenManager;

            this.customer = new Lazy<CustomerController>(
                () => new CustomerController(globalConfiguration));
            this.transaction = new Lazy<TransactionController>(
                () => new TransactionController(globalConfiguration));
            this.invoice = new Lazy<InvoiceController>(
                () => new InvoiceController(globalConfiguration));
            this.oAuthAuthorization = new Lazy<OAuthAuthorizationController>(
                () => new OAuthAuthorizationController(globalConfiguration));
        }

        /// <summary>
        /// Gets CustomerController controller.
        /// </summary>
        public CustomerController CustomerController => this.customer.Value;

        /// <summary>
        /// Gets TransactionController controller.
        /// </summary>
        public TransactionController TransactionController => this.transaction.Value;

        /// <summary>
        /// Gets InvoiceController controller.
        /// </summary>
        public InvoiceController InvoiceController => this.invoice.Value;

        /// <summary>
        /// Gets OAuthAuthorizationController controller.
        /// </summary>
        public OAuthAuthorizationController OAuthAuthorizationController => this.oAuthAuthorization.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with BasicAuth.
        /// </summary>
        public IBasicAuthCredentials BasicAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BasicAuth.
        /// </summary>
        public BasicAuthModel BasicAuthModel { get; private set; }

        /// <summary>
        /// Gets the credentials to use with BearerToken.
        /// </summary>
        public IBearerTokenCredentials BearerTokenCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BearerToken.
        /// </summary>
        public BearerTokenModel BearerTokenModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:SHELL.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Shell)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the ShellDataReportingAPIsClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .HttpClientConfig(config => config.Build());

            if (BasicAuthModel != null)
            {
                builder.BasicAuthCredentials(BasicAuthModel.ToBuilder().Build());
            }

            if (BearerTokenModel != null)
            {
                builder.BearerTokenCredentials(BearerTokenModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> ShellDataReportingAPIsClient.</returns>
        internal static ShellDataReportingAPIsClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("SHELL_DATA_REPORTING_AP_IS_STANDARD_ENVIRONMENT");
            string username = System.Environment.GetEnvironmentVariable("SHELL_DATA_REPORTING_AP_IS_STANDARD_USERNAME");
            string password = System.Environment.GetEnvironmentVariable("SHELL_DATA_REPORTING_AP_IS_STANDARD_PASSWORD");
            string oAuthClientId = System.Environment.GetEnvironmentVariable("SHELL_DATA_REPORTING_AP_IS_STANDARD_O_AUTH_CLIENT_ID");
            string oAuthClientSecret = System.Environment.GetEnvironmentVariable("SHELL_DATA_REPORTING_AP_IS_STANDARD_O_AUTH_CLIENT_SECRET");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (username != null && password != null)
            {
                builder.BasicAuthCredentials(new BasicAuthModel
                .Builder(username, password)
                .Build());
            }

            if (oAuthClientId != null && oAuthClientSecret != null)
            {
                builder.BearerTokenCredentials(new BearerTokenModel
                .Builder(oAuthClientId, oAuthClientSecret)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = ShellDataReportingAPIs.Standard.Environment.SIT;
            private BasicAuthModel basicAuthModel = new BasicAuthModel();
            private BearerTokenModel bearerTokenModel = new BearerTokenModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

            /// <summary>
            /// Sets credentials for BasicAuth.
            /// </summary>
            /// <param name="basicAuthModel">BasicAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BasicAuthCredentials(BasicAuthModel basicAuthModel)
            {
                if (basicAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(basicAuthModel));
                }

                this.basicAuthModel = basicAuthModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for BearerToken.
            /// </summary>
            /// <param name="bearerTokenModel">BearerTokenModel.</param>
            /// <returns>Builder.</returns>
            public Builder BearerTokenCredentials(BearerTokenModel bearerTokenModel)
            {
                if (bearerTokenModel is null)
                {
                    throw new ArgumentNullException(nameof(bearerTokenModel));
                }

                this.bearerTokenModel = bearerTokenModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the ShellDataReportingAPIsClient using the values provided for the builder.
            /// </summary>
            /// <returns>ShellDataReportingAPIsClient.</returns>
            public ShellDataReportingAPIsClient Build()
            {
                if (basicAuthModel.Username == null || basicAuthModel.Password == null)
                {
                    basicAuthModel = null;
                }
                if (bearerTokenModel.OAuthClientId == null || bearerTokenModel.OAuthClientSecret == null)
                {
                    bearerTokenModel = null;
                }
                return new ShellDataReportingAPIsClient(
                    environment,
                    basicAuthModel,
                    bearerTokenModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}
