// <copyright file="CardGroupResponse.cs" company="APIMatic">
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
    /// CardGroupResponse.
    /// </summary>
    public class CardGroupResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardGroupResponse"/> class.
        /// </summary>
        public CardGroupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardGroupResponse"/> class.
        /// </summary>
        /// <param name="cardGroups">CardGroups.</param>
        /// <param name="currentPage">CurrentPage.</param>
        /// <param name="rowCount">RowCount.</param>
        /// <param name="totalPages">TotalPages.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public CardGroupResponse(
            List<Models.CardGroupResponseCardGroupsItems> cardGroups = null,
            int? currentPage = null,
            int? rowCount = null,
            int? totalPages = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.CardGroups = cardGroups;
            this.CurrentPage = currentPage;
            this.RowCount = rowCount;
            this.TotalPages = totalPages;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Gets or sets CardGroups.
        /// </summary>
        [JsonProperty("CardGroups", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CardGroupResponseCardGroupsItems> CardGroups { get; set; }

        /// <summary>
        /// current page
        /// </summary>
        [JsonProperty("CurrentPage", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// number of records in current response
        /// </summary>
        [JsonProperty("RowCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? RowCount { get; set; }

        /// <summary>
        /// Total pages available
        /// </summary>
        [JsonProperty("TotalPages", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or sets Error.
        /// </summary>
        [JsonProperty("Error", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ErrorStatus Error { get; set; }

        /// <summary>
        /// API Request id
        /// </summary>
        [JsonProperty("RequestId", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardGroupResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardGroupResponse other &&                ((this.CardGroups == null && other.CardGroups == null) || (this.CardGroups?.Equals(other.CardGroups) == true)) &&
                ((this.CurrentPage == null && other.CurrentPage == null) || (this.CurrentPage?.Equals(other.CurrentPage) == true)) &&
                ((this.RowCount == null && other.RowCount == null) || (this.RowCount?.Equals(other.RowCount) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardGroups = {(this.CardGroups == null ? "null" : $"[{string.Join(", ", this.CardGroups)} ]")}");
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.RowCount = {(this.RowCount == null ? "null" : this.RowCount.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}