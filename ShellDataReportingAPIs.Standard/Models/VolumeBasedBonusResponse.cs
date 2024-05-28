// <copyright file="VolumeBasedBonusResponse.cs" company="APIMatic">
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
    /// VolumeBasedBonusResponse.
    /// </summary>
    public class VolumeBasedBonusResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeBasedBonusResponse"/> class.
        /// </summary>
        public VolumeBasedBonusResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeBasedBonusResponse"/> class.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        /// <param name="currentPeriodConsumption">CurrentPeriodConsumption.</param>
        /// <param name="historicalBonusPaid">HistoricalBonusPaid.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public VolumeBasedBonusResponse(
            List<Models.BonusConfiguration> configuration = null,
            List<Models.CurrentVolume> currentPeriodConsumption = null,
            List<Models.BonusHistory> historicalBonusPaid = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.Configuration = configuration;
            this.CurrentPeriodConsumption = currentPeriodConsumption;
            this.HistoricalBonusPaid = historicalBonusPaid;
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
        public List<Models.CurrentVolume> CurrentPeriodConsumption { get; set; }

        /// <summary>
        /// Gets or sets HistoricalBonusPaid.
        /// </summary>
        [JsonProperty("HistoricalBonusPaid", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BonusHistory> HistoricalBonusPaid { get; set; }

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

            return $"VolumeBasedBonusResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is VolumeBasedBonusResponse other &&                ((this.Configuration == null && other.Configuration == null) || (this.Configuration?.Equals(other.Configuration) == true)) &&
                ((this.CurrentPeriodConsumption == null && other.CurrentPeriodConsumption == null) || (this.CurrentPeriodConsumption?.Equals(other.CurrentPeriodConsumption) == true)) &&
                ((this.HistoricalBonusPaid == null && other.HistoricalBonusPaid == null) || (this.HistoricalBonusPaid?.Equals(other.HistoricalBonusPaid) == true)) &&
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
            toStringOutput.Add($"this.HistoricalBonusPaid = {(this.HistoricalBonusPaid == null ? "null" : $"[{string.Join(", ", this.HistoricalBonusPaid)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}