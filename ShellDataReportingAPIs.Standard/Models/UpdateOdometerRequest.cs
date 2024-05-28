// <copyright file="UpdateOdometerRequest.cs" company="APIMatic">
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
    /// UpdateOdometerRequest.
    /// </summary>
    public class UpdateOdometerRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometerRequest"/> class.
        /// </summary>
        public UpdateOdometerRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometerRequest"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="updateOdometers">UpdateOdometers.</param>
        /// <param name="notifyCaller">NotifyCaller.</param>
        /// <param name="caller">Caller.</param>
        public UpdateOdometerRequest(
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            int? accountId = null,
            string accountNumber = null,
            List<Models.UpdateOdometer> updateOdometers = null,
            bool? notifyCaller = null,
            string caller = null)
        {
            this.ColCoId = colCoId;
            this.ColCoCode = colCoCode;
            this.PayerId = payerId;
            this.AccountId = accountId;
            this.AccountNumber = accountNumber;
            this.UpdateOdometers = updateOdometers;
            this.NotifyCaller = notifyCaller;
            this.Caller = caller;
        }

        /// <summary>
        /// Collecting Company Id  of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Collecting Company Code (Shell Code) of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Payer Id (i.e. Customer Id of the Payment Customer in Cards Platform) of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Account Id (i.e. Customer Id of the Sub Account in GFN) of the selected account.
        /// Optional if AccountNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("AccountId", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccountId { get; set; }

        /// <summary>
        /// Account Number (ex: GB000000123) of the selected account.
        /// Optional if AccountId is passed else Mandatory
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets UpdateOdometers.
        /// </summary>
        [JsonProperty("UpdateOdometers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateOdometer> UpdateOdometers { get; set; }

        /// <summary>
        /// True/False.
        /// Optional.
        /// Default: False
        /// If true, the caller would be notified back with the status as success or failure after the update odometer is processed.
        /// </summary>
        [JsonProperty("NotifyCaller", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NotifyCaller { get; set; }

        /// <summary>
        /// The caller to be notified with the status of the update odometer.
        /// Mandatory, if NotifyCaller is true.
        /// </summary>
        [JsonProperty("Caller", NullValueHandling = NullValueHandling.Ignore)]
        public string Caller { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateOdometerRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateOdometerRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.UpdateOdometers == null && other.UpdateOdometers == null) || (this.UpdateOdometers?.Equals(other.UpdateOdometers) == true)) &&
                ((this.NotifyCaller == null && other.NotifyCaller == null) || (this.NotifyCaller?.Equals(other.NotifyCaller) == true)) &&
                ((this.Caller == null && other.Caller == null) || (this.Caller?.Equals(other.Caller) == true));
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
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.UpdateOdometers = {(this.UpdateOdometers == null ? "null" : $"[{string.Join(", ", this.UpdateOdometers)} ]")}");
            toStringOutput.Add($"this.NotifyCaller = {(this.NotifyCaller == null ? "null" : this.NotifyCaller.ToString())}");
            toStringOutput.Add($"this.Caller = {(this.Caller == null ? "null" : this.Caller)}");
        }
    }
}