// <copyright file="TransactionExceptionsResponse.cs" company="APIMatic">
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
    /// TransactionExceptionsResponse.
    /// </summary>
    public class TransactionExceptionsResponse
    {
        private List<Models.TransactionExceptions> transactionExceptions;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "TransactionExceptions", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionExceptionsResponse"/> class.
        /// </summary>
        public TransactionExceptionsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionExceptionsResponse"/> class.
        /// </summary>
        /// <param name="cardExceptions">CardExceptions.</param>
        /// <param name="transactionExceptions">TransactionExceptions.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public TransactionExceptionsResponse(
            List<Models.CardExceptions> cardExceptions = null,
            List<Models.TransactionExceptions> transactionExceptions = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.CardExceptions = cardExceptions;
            if (transactionExceptions != null)
            {
                this.TransactionExceptions = transactionExceptions;
            }

            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets CardExceptions.
        /// </summary>
        [JsonProperty("CardExceptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardExceptions> CardExceptions { get; set; }

        /// <summary>
        /// Gets or sets TransactionExceptions.
        /// </summary>
        [JsonProperty("TransactionExceptions")]
        public List<Models.TransactionExceptions> TransactionExceptions
        {
            get
            {
                return this.transactionExceptions;
            }

            set
            {
                this.shouldSerialize["TransactionExceptions"] = true;
                this.transactionExceptions = value;
            }
        }

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

            return $"TransactionExceptionsResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionExceptions()
        {
            this.shouldSerialize["TransactionExceptions"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionExceptions()
        {
            return this.shouldSerialize["TransactionExceptions"];
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
            return obj is TransactionExceptionsResponse other &&                ((this.CardExceptions == null && other.CardExceptions == null) || (this.CardExceptions?.Equals(other.CardExceptions) == true)) &&
                ((this.TransactionExceptions == null && other.TransactionExceptions == null) || (this.TransactionExceptions?.Equals(other.TransactionExceptions) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardExceptions = {(this.CardExceptions == null ? "null" : $"[{string.Join(", ", this.CardExceptions)} ]")}");
            toStringOutput.Add($"this.TransactionExceptions = {(this.TransactionExceptions == null ? "null" : $"[{string.Join(", ", this.TransactionExceptions)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}