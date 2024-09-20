// <copyright file="CustomerPriceListResponse.cs" company="APIMatic">
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
    /// CustomerPriceListResponse.
    /// </summary>
    public class CustomerPriceListResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPriceListResponse"/> class.
        /// </summary>
        public CustomerPriceListResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPriceListResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="priceList">PriceList.</param>
        /// <param name="error">Error.</param>
        public CustomerPriceListResponse(
            string requestId = null,
            List<Models.PriceList> priceList = null,
            Models.ErrorStatus error = null)
        {
            this.RequestId = requestId;
            this.PriceList = priceList;
            this.Error = error;
        }

        /// <summary>
        /// UUID (according to RFC 4122 standards) for requests and responses. This will be played back in the response from the request.
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or sets PriceList.
        /// </summary>
        [JsonProperty("PriceList", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PriceList> PriceList { get; set; }

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

            return $"CustomerPriceListResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerPriceListResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.PriceList == null && other.PriceList == null) || (this.PriceList?.Equals(other.PriceList) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.PriceList = {(this.PriceList == null ? "null" : $"[{string.Join(", ", this.PriceList)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
        }
    }
}