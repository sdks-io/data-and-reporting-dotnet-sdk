// <copyright file="FuelConsumptionResponse.cs" company="APIMatic">
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
    /// FuelConsumptionResponse.
    /// </summary>
    public class FuelConsumptionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuelConsumptionResponse"/> class.
        /// </summary>
        public FuelConsumptionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuelConsumptionResponse"/> class.
        /// </summary>
        /// <param name="fuelConsumption">FuelConsumption.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public FuelConsumptionResponse(
            List<Models.FuelConsumptionData> fuelConsumption = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.FuelConsumption = fuelConsumption;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets FuelConsumption.
        /// </summary>
        [JsonProperty("FuelConsumption", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FuelConsumptionData> FuelConsumption { get; set; }

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

            return $"FuelConsumptionResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is FuelConsumptionResponse other &&                ((this.FuelConsumption == null && other.FuelConsumption == null) || (this.FuelConsumption?.Equals(other.FuelConsumption) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FuelConsumption = {(this.FuelConsumption == null ? "null" : $"[{string.Join(", ", this.FuelConsumption)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}