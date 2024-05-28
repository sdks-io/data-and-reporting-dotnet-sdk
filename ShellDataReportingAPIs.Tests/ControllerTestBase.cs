// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellDataReportingAPIs.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Types;
    using NUnit.Framework;
    using ShellDataReportingAPIs.Standard;
    using ShellDataReportingAPIs.Standard.Authentication;
    using ShellDataReportingAPIs.Standard.Exceptions;
    using ShellDataReportingAPIs.Standard.Http.Client;
    using ShellDataReportingAPIs.Standard.Models;

    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallBack HttpCallBack { get; private set; } = new HttpCallBack();

        /// <summary>
        /// Gets ShellDataReportingAPIsClient Client.
        /// </summary>
        protected ShellDataReportingAPIsClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            ShellDataReportingAPIsClient config = ShellDataReportingAPIsClient.CreateFromEnvironment();
            this.Client = config.ToBuilder()
                .HttpCallBack(HttpCallBack)
                .Build();

            try
            {
                this.Client = this.Client.ToBuilder().BearerTokenCredentials(Client.BearerTokenModel.ToBuilder()
                    .OAuthToken(this.Client.BearerTokenCredentials.FetchToken()).Build())
                    .Build();
            }
            catch (ApiException) 
            {
                // TODO Auto-generated catch block;
            }
        }
    }
}