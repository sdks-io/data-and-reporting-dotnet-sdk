// <copyright file="CardUsageSummaryResponse.cs" company="APIMatic">
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
    /// CardUsageSummaryResponse.
    /// </summary>
    public class CardUsageSummaryResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardUsageSummaryResponse"/> class.
        /// </summary>
        public CardUsageSummaryResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardUsageSummaryResponse"/> class.
        /// </summary>
        /// <param name="usageSummary">UsageSummary.</param>
        /// <param name="requestId">RequestId.</param>
        /// <param name="error">Error.</param>
        public CardUsageSummaryResponse(
            List<Models.UsageSummary> usageSummary = null,
            string requestId = null,
            Models.ErrorStatus error = null)
        {
            this.UsageSummary = usageSummary;
            this.RequestId = requestId;
            this.Error = error;
        }

        /// <summary>
        /// Gets or sets UsageSummary.
        /// </summary>
        [JsonProperty("UsageSummary", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UsageSummary> UsageSummary { get; set; }

        /// <summary>
        /// API Request Id
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

            return $"CardUsageSummaryResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardUsageSummaryResponse other &&                ((this.UsageSummary == null && other.UsageSummary == null) || (this.UsageSummary?.Equals(other.UsageSummary) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.UsageSummary = {(this.UsageSummary == null ? "null" : $"[{string.Join(", ", this.UsageSummary)} ]")}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}