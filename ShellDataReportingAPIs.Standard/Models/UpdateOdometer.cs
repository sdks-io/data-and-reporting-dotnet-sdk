// <copyright file="UpdateOdometer.cs" company="APIMatic">
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
    /// UpdateOdometer.
    /// </summary>
    public class UpdateOdometer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometer"/> class.
        /// </summary>
        public UpdateOdometer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometer"/> class.
        /// </summary>
        /// <param name="salesItemId">SalesItemId.</param>
        /// <param name="newOdometerValue">NewOdometerValue.</param>
        public UpdateOdometer(
            string salesItemId = null,
            int? newOdometerValue = null)
        {
            this.SalesItemId = salesItemId;
            this.NewOdometerValue = newOdometerValue;
        }

        /// <summary>
        /// Unique SalesItemId (Either Billed on Unbilled)
        /// Mandatory
        /// </summary>
        [JsonProperty("SalesItemId", NullValueHandling = NullValueHandling.Include)]
        public string SalesItemId { get; set; }

        /// <summary>
        /// NewOdometerValue that needs to be updated
        /// </summary>
        [JsonProperty("NewOdometerValue", NullValueHandling = NullValueHandling.Include)]
        public int? NewOdometerValue { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateOdometer : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateOdometer other &&                ((this.SalesItemId == null && other.SalesItemId == null) || (this.SalesItemId?.Equals(other.SalesItemId) == true)) &&
                ((this.NewOdometerValue == null && other.NewOdometerValue == null) || (this.NewOdometerValue?.Equals(other.NewOdometerValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SalesItemId = {(this.SalesItemId == null ? "null" : this.SalesItemId)}");
            toStringOutput.Add($"this.NewOdometerValue = {(this.NewOdometerValue == null ? "null" : this.NewOdometerValue.ToString())}");
        }
    }
}