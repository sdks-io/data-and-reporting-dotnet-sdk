// <copyright file="VolumeBasedPricingResponse.cs" company="APIMatic">
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
    /// VolumeBasedPricingResponse.
    /// </summary>
    public class VolumeBasedPricingResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeBasedPricingResponse"/> class.
        /// </summary>
        public VolumeBasedPricingResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeBasedPricingResponse"/> class.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        /// <param name="currentPeriodConsumption">CurrentPeriodConsumption.</param>
        /// <param name="history">History.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public VolumeBasedPricingResponse(
            List<Models.BonusConfiguration> configuration = null,
            List<Models.PricingCurrentVolume> currentPeriodConsumption = null,
            List<Models.PricingHistory> history = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.Configuration = configuration;
            this.CurrentPeriodConsumption = currentPeriodConsumption;
            this.History = history;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets Configuration.
        /// </summary>
        [JsonProperty("Configuration", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BonusConfiguration> Configuration { get; set; }

        /// <summary>
        /// Gets or sets CurrentPeriodConsumption.
        /// </summary>
        [JsonProperty("CurrentPeriodConsumption", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PricingCurrentVolume> CurrentPeriodConsumption { get; set; }

        /// <summary>
        /// Gets or sets History.
        /// </summary>
        [JsonProperty("History", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PricingHistory> History { get; set; }

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

            return $"VolumeBasedPricingResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is VolumeBasedPricingResponse other &&                ((this.Configuration == null && other.Configuration == null) || (this.Configuration?.Equals(other.Configuration) == true)) &&
                ((this.CurrentPeriodConsumption == null && other.CurrentPeriodConsumption == null) || (this.CurrentPeriodConsumption?.Equals(other.CurrentPeriodConsumption) == true)) &&
                ((this.History == null && other.History == null) || (this.History?.Equals(other.History) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Configuration = {(this.Configuration == null ? "null" : $"[{string.Join(", ", this.Configuration)} ]")}");
            toStringOutput.Add($"this.CurrentPeriodConsumption = {(this.CurrentPeriodConsumption == null ? "null" : $"[{string.Join(", ", this.CurrentPeriodConsumption)} ]")}");
            toStringOutput.Add($"this.History = {(this.History == null ? "null" : $"[{string.Join(", ", this.History)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}