// <copyright file="SearchStatementOfAccountResponse.cs" company="APIMatic">
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
    /// SearchStatementOfAccountResponse.
    /// </summary>
    public class SearchStatementOfAccountResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStatementOfAccountResponse"/> class.
        /// </summary>
        public SearchStatementOfAccountResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchStatementOfAccountResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="page">Page.</param>
        /// <param name="totalRecords">TotalRecords.</param>
        /// <param name="totalPages">TotalPages.</param>
        /// <param name="pageSize">PageSize.</param>
        public SearchStatementOfAccountResponse(
            string requestId = null,
            string status = null,
            List<Models.SearchStatementOfAccount> data = null,
            int? page = null,
            int? totalRecords = null,
            int? totalPages = null,
            int? pageSize = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
            this.Page = page;
            this.TotalRecords = totalRecords;
            this.TotalPages = totalPages;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Mandatory UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the req
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SearchStatementOfAccount> Data { get; set; }

        /// <summary>
        /// Current page
        /// </summary>
        [JsonProperty("Page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Total Number of records in response
        /// </summary>
        [JsonProperty("TotalRecords", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Total number of pages available for the requested data
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Number of records returned in the response
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchStatementOfAccountResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchStatementOfAccountResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.TotalRecords == null && other.TotalRecords == null) || (this.TotalRecords?.Equals(other.TotalRecords) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.TotalRecords = {(this.TotalRecords == null ? "null" : this.TotalRecords.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
        }
    }
}