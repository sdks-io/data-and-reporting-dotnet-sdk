// <copyright file="PricedTransSummaryResponse.cs" company="APIMatic">
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
    /// PricedTransSummaryResponse.
    /// </summary>
    public class PricedTransSummaryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransSummaryResponse"/> class.
        /// </summary>
        public PricedTransSummaryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransSummaryResponse"/> class.
        /// </summary>
        /// <param name="transactionsSummary">TransactionsSummary.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public PricedTransSummaryResponse(
            List<Models.PricedTransSummaryResponseTransactionsSummaryItems> transactionsSummary = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.TransactionsSummary = transactionsSummary;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets TransactionsSummary.
        /// </summary>
        [JsonProperty("TransactionsSummary", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PricedTransSummaryResponseTransactionsSummaryItems> TransactionsSummary { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricedTransSummaryResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PricedTransSummaryResponse other &&                ((this.TransactionsSummary == null && other.TransactionsSummary == null) || (this.TransactionsSummary?.Equals(other.TransactionsSummary) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TransactionsSummary = {(this.TransactionsSummary == null ? "null" : $"[{string.Join(", ", this.TransactionsSummary)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}