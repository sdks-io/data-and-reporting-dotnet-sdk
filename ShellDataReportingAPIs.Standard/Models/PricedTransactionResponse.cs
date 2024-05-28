// <copyright file="PricedTransactionResponse.cs" company="APIMatic">
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
    /// PricedTransactionResponse.
    /// </summary>
    public class PricedTransactionResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransactionResponse"/> class.
        /// </summary>
        public PricedTransactionResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransactionResponse"/> class.
        /// </summary>
        /// <param name="transactions">Transactions.</param>
        public PricedTransactionResponse(
            List<Models.PricedTransactionResponseTransactionsItems> transactions = null)
        {
            this.Transactions = transactions;
        }

        /// <summary>
        /// Gets or sets Transactions.
        /// </summary>
        [JsonProperty("Transactions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PricedTransactionResponseTransactionsItems> Transactions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricedTransactionResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is PricedTransactionResponse other &&                ((this.Transactions == null && other.Transactions == null) || (this.Transactions?.Equals(other.Transactions) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Transactions = {(this.Transactions == null ? "null" : $"[{string.Join(", ", this.Transactions)} ]")}");
        }
    }
}