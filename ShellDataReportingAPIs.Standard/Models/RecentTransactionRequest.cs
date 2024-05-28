// <copyright file="RecentTransactionRequest.cs" company="APIMatic">
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
    /// RecentTransactionRequest.
    /// </summary>
    public class RecentTransactionRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentTransactionRequest"/> class.
        /// </summary>
        public RecentTransactionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecentTransactionRequest"/> class.
        /// </summary>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="page">Page.</param>
        /// <param name="filters">Filters.</param>
        public RecentTransactionRequest(
            int pageSize,
            int page,
            Models.RecentTransactionReq filters)
        {
            this.PageSize = pageSize;
            this.Page = page;
            this.Filters = filters;
        }

        /// <summary>
        /// Specify the number of records to returned; Max 1000
        /// </summary>
        [JsonProperty("PageSize")]
        public int PageSize { get; set; }

        /// <summary>
        /// Specify the page of results to be returned.
        /// </summary>
        [JsonProperty("Page")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets Filters.
        /// </summary>
        [JsonProperty("Filters")]
        public Models.RecentTransactionReq Filters { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RecentTransactionRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RecentTransactionRequest other &&                this.PageSize.Equals(other.PageSize) &&
                this.Page.Equals(other.Page) &&
                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PageSize = {this.PageSize}");
            toStringOutput.Add($"this.Page = {this.Page}");
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
        }
    }
}