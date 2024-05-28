// <copyright file="DefaultErrorFault.cs" company="APIMatic">
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
    /// DefaultErrorFault.
    /// </summary>
    public class DefaultErrorFault
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultErrorFault"/> class.
        /// </summary>
        public DefaultErrorFault()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultErrorFault"/> class.
        /// </summary>
        /// <param name="faultstring">faultstring.</param>
        /// <param name="detail">detail.</param>
        public DefaultErrorFault(
            string faultstring = null,
            Models.DefaultErrorFaultDetail detail = null)
        {
            this.Faultstring = faultstring;
            this.Detail = detail;
        }

        /// <summary>
        /// Error Description
        /// </summary>
        [JsonProperty("faultstring", NullValueHandling = NullValueHandling.Ignore)]
        public string Faultstring { get; set; }

        /// <summary>
        /// Details about the error
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DefaultErrorFaultDetail Detail { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DefaultErrorFault : ({string.Join(", ", toStringOutput)})";
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
            return obj is DefaultErrorFault other &&                ((this.Faultstring == null && other.Faultstring == null) || (this.Faultstring?.Equals(other.Faultstring) == true)) &&
                ((this.Detail == null && other.Detail == null) || (this.Detail?.Equals(other.Detail) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Faultstring = {(this.Faultstring == null ? "null" : this.Faultstring)}");
            toStringOutput.Add($"this.Detail = {(this.Detail == null ? "null" : this.Detail.ToString())}");
        }
    }
}