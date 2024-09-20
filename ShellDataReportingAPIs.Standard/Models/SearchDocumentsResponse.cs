// <copyright file="SearchDocumentsResponse.cs" company="APIMatic">
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
    /// SearchDocumentsResponse.
    /// </summary>
    public class SearchDocumentsResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocumentsResponse"/> class.
        /// </summary>
        public SearchDocumentsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocumentsResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="totalRecords">TotalRecords.</param>
        /// <param name="totalRecordsOnPage">TotalRecordsOnPage.</param>
        /// <param name="isFirstPage">IsFirstPage.</param>
        /// <param name="isLastPage">IsLastPage.</param>
        public SearchDocumentsResponse(
            string requestId = null,
            string status = null,
            List<Models.SearchDocumentsInvoice> data = null,
            int? totalRecords = null,
            int? totalRecordsOnPage = null,
            bool? isFirstPage = null,
            bool? isLastPage = null)
        {
            this.RequestId = requestId;
            this.Status = status;
            this.Data = data;
            this.TotalRecords = totalRecords;
            this.TotalRecordsOnPage = totalRecordsOnPage;
            this.IsFirstPage = isFirstPage;
            this.IsLastPage = isLastPage;
        }

        /// <summary>
        /// UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCES, FAILED
        /// </summary>
        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SearchDocumentsInvoice> Data { get; set; }

        /// <summary>
        /// Total number of elements corresponding to the request
        /// </summary>
        [JsonProperty("TotalRecords", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecords { get; set; }

        /// <summary>
        /// Number of elements in the page content. Will be lesser or equal to the size param.
        /// </summary>
        [JsonProperty("TotalRecordsOnPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalRecordsOnPage { get; set; }

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

            return $"SearchDocumentsResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SearchDocumentsResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.TotalRecords == null && other.TotalRecords == null) || (this.TotalRecords?.Equals(other.TotalRecords) == true)) &&
                ((this.TotalRecordsOnPage == null && other.TotalRecordsOnPage == null) || (this.TotalRecordsOnPage?.Equals(other.TotalRecordsOnPage) == true)) &&
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
            toStringOutput.Add($"this.TotalRecords = {(this.TotalRecords == null ? "null" : this.TotalRecords.ToString())}");
            toStringOutput.Add($"this.TotalRecordsOnPage = {(this.TotalRecordsOnPage == null ? "null" : this.TotalRecordsOnPage.ToString())}");
            toStringOutput.Add($"this.IsFirstPage = {(this.IsFirstPage == null ? "null" : this.IsFirstPage.ToString())}");
            toStringOutput.Add($"this.IsLastPage = {(this.IsLastPage == null ? "null" : this.IsLastPage.ToString())}");
        }
    }
}