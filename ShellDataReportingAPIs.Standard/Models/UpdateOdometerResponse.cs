// <copyright file="UpdateOdometerResponse.cs" company="APIMatic">
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
    /// UpdateOdometerResponse.
    /// </summary>
    public class UpdateOdometerResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometerResponse"/> class.
        /// </summary>
        public UpdateOdometerResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometerResponse"/> class.
        /// </summary>
        /// <param name="serviceReference">ServiceReference.</param>
        /// <param name="updateOdometerReferences">UpdateOdometerReferences.</param>
        /// <param name="error">Error.</param>
        /// <param name="requestId">RequestId.</param>
        public UpdateOdometerResponse(
            int? serviceReference = null,
            List<Models.UpdateOdometerReference> updateOdometerReferences = null,
            Models.ErrorStatus error = null,
            string requestId = null)
        {
            this.ServiceReference = serviceReference;
            this.UpdateOdometerReferences = updateOdometerReferences;
            this.Error = error;
            this.RequestId = requestId;
        }

        /// <summary>
        /// Main reference number for tracking.
        /// </summary>
        [JsonProperty("ServiceReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceReference { get; set; }

        /// <summary>
        /// Gets or sets UpdateOdometerReferences.
        /// </summary>
        [JsonProperty("UpdateOdometerReferences", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.UpdateOdometerReference> UpdateOdometerReferences { get; set; }

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

            return $"UpdateOdometerResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is UpdateOdometerResponse other &&                ((this.ServiceReference == null && other.ServiceReference == null) || (this.ServiceReference?.Equals(other.ServiceReference) == true)) &&
                ((this.UpdateOdometerReferences == null && other.UpdateOdometerReferences == null) || (this.UpdateOdometerReferences?.Equals(other.UpdateOdometerReferences) == true)) &&
                ((this.Error == null && other.Error == null) || (this.Error?.Equals(other.Error) == true)) &&
                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ServiceReference = {(this.ServiceReference == null ? "null" : this.ServiceReference.ToString())}");
            toStringOutput.Add($"this.UpdateOdometerReferences = {(this.UpdateOdometerReferences == null ? "null" : $"[{string.Join(", ", this.UpdateOdometerReferences)} ]")}");
            toStringOutput.Add($"this.Error = {(this.Error == null ? "null" : this.Error.ToString())}");
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
        }
    }
}