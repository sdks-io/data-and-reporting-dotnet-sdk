// <copyright file="FuelConsumptionCard.cs" company="APIMatic">
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
    /// FuelConsumptionCard.
    /// </summary>
    public class FuelConsumptionCard
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FuelConsumptionCard"/> class.
        /// </summary>
        public FuelConsumptionCard()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuelConsumptionCard"/> class.
        /// </summary>
        /// <param name="cardId">CardId.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="expiryDate">ExpiryDate.</param>
        public FuelConsumptionCard(
            int? cardId = null,
            string pAN = null,
            string expiryDate = null)
        {
            this.CardId = cardId;
            this.PAN = pAN;
            this.ExpiryDate = expiryDate;
        }

        /// <summary>
        /// Card Id
        /// Optional, when PAN is provided else mandatory.
        /// </summary>
        [JsonProperty("CardId", NullValueHandling = NullValueHandling.Ignore)]
        public int? CardId { get; set; }

        /// <summary>
        /// Full Card PAN
        /// Optional, when CardId is provided else mandatory.
        /// </summary>
        [JsonProperty("PAN", NullValueHandling = NullValueHandling.Ignore)]
        public string PAN { get; set; }

        /// <summary>
        /// Card Expiry Date
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("ExpiryDate", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpiryDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FuelConsumptionCard : ({string.Join(", ", toStringOutput)})";
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
            return obj is FuelConsumptionCard other &&                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.ExpiryDate == null && other.ExpiryDate == null) || (this.ExpiryDate?.Equals(other.ExpiryDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.ExpiryDate = {(this.ExpiryDate == null ? "null" : this.ExpiryDate)}");
        }
    }
}