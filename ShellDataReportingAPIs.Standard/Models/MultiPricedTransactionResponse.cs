// <copyright file="MultiPricedTransactionResponse.cs" company="APIMatic">
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
    /// MultiPricedTransactionResponse.
    /// </summary>
    public class MultiPricedTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPricedTransactionResponse"/> class.
        /// </summary>
        public MultiPricedTransactionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiPricedTransactionResponse"/> class.
        /// </summary>
        /// <param name="transactions">Transactions.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="rowCount">RowCount.</param>
        /// <param name="totalPages">TotalPages.</param>
        public MultiPricedTransactionResponse(
            List<Models.MultiPricedTransactionResponseTransactionsItems> transactions = null,
            Models.ErrorStatus error = null,
            string requestId = null,
            int? currentPage = null,
            int? rowCount = null,
            int? totalPages = null)
        {
            this.Transactions = transactions;
            this.Error = error;
            this.RequestId = requestId;
            this.CurrentPage = currentPage;
            this.RowCount = rowCount;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Gets or sets Transactions.
        /// </summary>
        [JsonProperty("Transactions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MultiPricedTransactionResponseTransactionsItems> Transactions { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API Request Id
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Current Page
        /// </summary>
        [JsonProperty("CurrentPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Total row count matched for the given input criteria
        /// </summary>
        [JsonProperty("RowCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowCount { get; set; }

        /// <summary>
        /// Calculated page count based on page size from the incoming API request and total number of rows matched for the given input criteria
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MultiPricedTransactionResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is MultiPricedTransactionResponse other &&                ((this.Transactions == null && other.Transactions == null) || (this.Transactions?.Equals(other.Transactions) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.RowCount == null && other.RowCount == null) || (this.RowCount?.Equals(other.RowCount) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Transactions = {(this.Transactions == null ? "null" : $"[{string.Join(", ", this.Transactions)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.RowCount = {(this.RowCount == null ? "null" : this.RowCount.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
        }
    }
}