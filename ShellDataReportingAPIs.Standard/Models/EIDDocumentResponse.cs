// <copyright file="EIDDocumentResponse.cs" company="APIMatic">
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
using ShellDataReportingAPIs.Standard.Utilities;

namespace ShellDataReportingAPIs.Standard.Models
{
    /// <summary>
    /// EIDDocumentResponse.
    /// </summary>
    public class EIDDocumentResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EIDDocumentResponse"/> class.
        /// </summary>
        public EIDDocumentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EIDDocumentResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="page">Page.</param>
        /// <param name="totalPages">TotalPages.</param>
        /// <param name="totalRecords">TotalRecords.</param>
        /// <param name="isFirstPage">IsFirstPage.</param>
        /// <param name="isLastPage">IsLastPage.</param>
        public EIDDocumentResponse(
            string requestId = null,
            string status = null,
            List<Models.EIDDocument> data = null,
            int? pageSize = null,
            int? page = null,
            int? totalPages = null,
            int? totalRecords = null,
            bool? isFirstPage = null,
            bool? isLastPage = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
            this.PageSize = pageSize;
            this.Page = page;
            this.TotalPages = totalPages;
            this.TotalRecords = totalRecords;
            this.IsFirstPage = isFirstPage;
            this.IsLastPage = isLastPage;
        }

        /// <summary>
        /// UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCESS, FAILED
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.EIDDocument> Data { get; set; }

        /// <summary>
        /// Number of records returned in the response
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Current page
        /// </summary>
        [JsonProperty("Page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Total number of pages available for the requested data
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Total number of elements corresponding to the request
        /// </summary>
        [JsonProperty("TotalRecords", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// True if it is the first page, false otherwise
        /// </summary>
        [JsonProperty("IsFirstPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFirstPage { get; set; }

        /// <summary>
        /// True if it is the last page, false, otherwise.
        /// </summary>
        [JsonProperty("IsLastPage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsLastPage { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EIDDocumentResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is EIDDocumentResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.TotalRecords == null && other.TotalRecords == null) || (this.TotalRecords?.Equals(other.TotalRecords) == true)) &&
                ((this.IsFirstPage == null && other.IsFirstPage == null) || (this.IsFirstPage?.Equals(other.IsFirstPage) == true)) &&
                ((this.IsLastPage == null && other.IsLastPage == null) || (this.IsLastPage?.Equals(other.IsLastPage) == true));
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
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.TotalRecords = {(this.TotalRecords == null ? "null" : this.TotalRecords.ToString())}");
            toStringOutput.Add($"this.IsFirstPage = {(this.IsFirstPage == null ? "null" : this.IsFirstPage.ToString())}");
            toStringOutput.Add($"this.IsLastPage = {(this.IsLastPage == null ? "null" : this.IsLastPage.ToString())}");
        }
    }
}