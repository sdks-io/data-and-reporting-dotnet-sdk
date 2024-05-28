// <copyright file="InvoiceDatesData.cs" company="APIMatic">
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
    /// InvoiceDatesData.
    /// </summary>
    public class InvoiceDatesData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDatesData"/> class.
        /// </summary>
        public InvoiceDatesData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDatesData"/> class.
        /// </summary>
        /// <param name="invoiceNumbers">InvoiceNumbers.</param>
        /// <param name="invoiceDates">InvoiceDates.</param>
        public InvoiceDatesData(
            List<string> invoiceNumbers = null,
            List<string> invoiceDates = null)
        {
            this.InvoiceNumbers = invoiceNumbers;
            this.InvoiceDates = invoiceDates;
        }

        /// <summary>
        /// List of Invoice numbers.
        /// </summary>
        [JsonProperty("InvoiceNumbers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvoiceNumbers { get; set; }

        /// <summary>
        /// List of Invoicing dates.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("InvoiceDates", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvoiceDates { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceDatesData : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceDatesData other &&                ((this.InvoiceNumbers == null && other.InvoiceNumbers == null) || (this.InvoiceNumbers?.Equals(other.InvoiceNumbers) == true)) &&
                ((this.InvoiceDates == null && other.InvoiceDates == null) || (this.InvoiceDates?.Equals(other.InvoiceDates) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InvoiceNumbers = {(this.InvoiceNumbers == null ? "null" : $"[{string.Join(", ", this.InvoiceNumbers)} ]")}");
            toStringOutput.Add($"this.InvoiceDates = {(this.InvoiceDates == null ? "null" : $"[{string.Join(", ", this.InvoiceDates)} ]")}");
        }
    }
}