// <copyright file="InvoiceSearchRequest.cs" company="APIMatic">
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
    /// InvoiceSearchRequest.
    /// </summary>
    public class InvoiceSearchRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchRequest"/> class.
        /// </summary>
        public InvoiceSearchRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchRequest"/> class.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="page">Page.</param>
        /// <param name="sortBy">SortBy.</param>
        public InvoiceSearchRequest(
            Models.InvoiceSearchRequestFilters filters = null,
            int? pageSize = null,
            int? page = null,
            List<int> sortBy = null)
        {
            this.Filters = filters;
            this.PageSize = pageSize;
            this.Page = page;
            this.SortBy = sortBy;
        }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("Filters", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceSearchRequestFilters Filters { get; set; }

        /// <summary>
        /// Gets or sets PageSize.
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Gets or sets Page.
        /// </summary>
        [JsonProperty("Page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Sort option –
        /// 1.	InvoiceDate ASC
        /// 2.	InvoiceDate DESC
        /// 3.	NetAmountCustomerCurrency ASC
        /// 4.	NetAmountCustomerCurrency DESC
        /// Optional
        /// Note:
        /// This option uses a column name with a combination of “ASC or DESC” for sorting.
        /// If only the column name is provided, it is sorted by ascending.
        /// Example values to be passed:
        /// [“InvoiceDate”, “NetAmountCustomerCurrency DESC”]
        /// </summary>
        [JsonProperty("SortBy", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> SortBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceSearchRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceSearchRequest other &&                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.SortBy == null && other.SortBy == null) || (this.SortBy?.Equals(other.SortBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.SortBy = {(this.SortBy == null ? "null" : $"[{string.Join(", ", this.SortBy)} ]")}");
        }
    }
}