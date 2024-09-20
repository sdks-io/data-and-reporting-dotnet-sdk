// <copyright file="InvoiceManagementV1Searchdocuments401ErrorException.cs" company="APIMatic">
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
using ShellDataReportingAPIs.Standard.Http.Client;
using ShellDataReportingAPIs.Standard.Models;
using ShellDataReportingAPIs.Standard.Utilities;

namespace ShellDataReportingAPIs.Standard.Exceptions
{
    /// <summary>
    /// InvoiceManagementV1Searchdocuments401ErrorException.
    /// </summary>
    public class InvoiceManagementV1Searchdocuments401ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceManagementV1Searchdocuments401ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public InvoiceManagementV1Searchdocuments401ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Unique request identifier passed from end user. This identifier helps in tracing a transaction
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCES, FAILED, PARTIAL_SUCCESS
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("Errors", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ErrorDetails> Errors { get; set; }
    }
}