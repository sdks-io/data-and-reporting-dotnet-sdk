// <copyright file="VolumeBasedBonusRequest.cs" company="APIMatic">
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
    /// VolumeBasedBonusRequest.
    /// </summary>
    public class VolumeBasedBonusRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeBasedBonusRequest"/> class.
        /// </summary>
        public VolumeBasedBonusRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeBasedBonusRequest"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="includeHistory">IncludeHistory.</param>
        /// <param name="includeCurrentPeriodVolume">IncludeCurrentPeriodVolume.</param>
        public VolumeBasedBonusRequest(
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            bool? includeHistory = null,
            bool? includeCurrentPeriodVolume = null)
        {
            this.ColCoId = colCoId;
            this.ColCoCode = colCoCode;
            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.IncludeHistory = includeHistory;
            this.IncludeCurrentPeriodVolume = includeCurrentPeriodVolume;
        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Payer Id of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// The API will return the details of the previously calculated/paid bonus and fuel consumption (Volume) in the response when this flag is ‘True’.
        /// </summary>
        [JsonProperty("IncludeHistory", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeHistory { get; set; }

        /// <summary>
        /// The API will return the details of the monthly breakup of current period fuel consumption (Volume) in the response when this flag is ‘True’.
        /// </summary>
        [JsonProperty("IncludeCurrentPeriodVolume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeCurrentPeriodVolume { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VolumeBasedBonusRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is VolumeBasedBonusRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.IncludeHistory == null && other.IncludeHistory == null) || (this.IncludeHistory?.Equals(other.IncludeHistory) == true)) &&
                ((this.IncludeCurrentPeriodVolume == null && other.IncludeCurrentPeriodVolume == null) || (this.IncludeCurrentPeriodVolume?.Equals(other.IncludeCurrentPeriodVolume) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.IncludeHistory = {(this.IncludeHistory == null ? "null" : this.IncludeHistory.ToString())}");
            toStringOutput.Add($"this.IncludeCurrentPeriodVolume = {(this.IncludeCurrentPeriodVolume == null ? "null" : this.IncludeCurrentPeriodVolume.ToString())}");
        }
    }
}