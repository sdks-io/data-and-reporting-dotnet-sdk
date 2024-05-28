// <copyright file="PricedTransactionRequestV2.cs" company="APIMatic">
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
    /// PricedTransactionRequestV2.
    /// </summary>
    public class PricedTransactionRequestV2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransactionRequestV2"/> class.
        /// </summary>
        public PricedTransactionRequestV2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransactionRequestV2"/> class.
        /// </summary>
        /// <param name="filters">Filters.</param>
        /// <param name="page">Page.</param>
        /// <param name="pageSize">PageSize.</param>
        public PricedTransactionRequestV2(
            Models.PricedRequestData filters = null,
            int? page = null,
            int? pageSize = null)
        {
            this.Filters = filters;
            this.Page = page;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// This endpoint allows querying the transaction data (i.e. Priced, Billed and Unbilled sales items) from SFSBI. It provides a flexible search criteria and supports paging
        /// </summary>
        [JsonProperty("Filters", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PricedRequestData Filters { get; set; }

        /// <summary>
        /// Specify the page of results to be returned.
        /// </summary>
        [JsonProperty("Page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// Specify the number of records to returned; Max 1000
        /// </summary>
        [JsonProperty("PageSize", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricedTransactionRequestV2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is PricedTransactionRequestV2 other &&                ((this.Filters == null && other.Filters == null) || (this.Filters?.Equals(other.Filters) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Filters = {(this.Filters == null ? "null" : this.Filters.ToString())}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
        }
    }
}