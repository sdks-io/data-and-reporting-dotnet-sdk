// <copyright file="FeeSummaryResponse.cs" company="APIMatic">
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
    /// FeeSummaryResponse.
    /// </summary>
    public class FeeSummaryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FeeSummaryResponse"/> class.
        /// </summary>
        public FeeSummaryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeSummaryResponse"/> class.
        /// </summary>
        /// <param name="feeItemsSummary">FeeItemsSummary.</param>
        /// <param name="requestId">RequestId.</param>
        /// <param name="error">Error.</param>
        public FeeSummaryResponse(
            List<Models.FeeItemSummaryAllOf0> feeItemsSummary = null,
            string requestId = null,
            Models.ErrorStatus error = null)
        {
            this.FeeItemsSummary = feeItemsSummary;
            this.RequestId = requestId;
            this.Error = error;
        }

        /// <summary>
        /// Gets or sets FeeItemsSummary.
        /// </summary>
        [JsonProperty("FeeItemsSummary", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FeeItemSummaryAllOf0> FeeItemsSummary { get; set; }

        /// <summary>
        /// A unique request id in GUID format. The value is written to the Shell API Platform audit log for end to end traceability of a request. If a value is not provided by an API client, then a GUID is automatically populated by the Shell API Platform and returned in the API response.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FeeSummaryResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is FeeSummaryResponse other &&                ((this.FeeItemsSummary == null && other.FeeItemsSummary == null) || (this.FeeItemsSummary?.Equals(other.FeeItemsSummary) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FeeItemsSummary = {(this.FeeItemsSummary == null ? "null" : $"[{string.Join(", ", this.FeeItemsSummary)} ]")}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}