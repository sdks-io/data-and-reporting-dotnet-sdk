// <copyright file="InvoiceDownloadReq.cs" company="APIMatic">
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
    /// InvoiceDownloadReq.
    /// </summary>
    public class InvoiceDownloadReq
    {
        private string invoiceOrSOANumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "InvoiceOrSOANumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDownloadReq"/> class.
        /// </summary>
        public InvoiceDownloadReq()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDownloadReq"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="documentReference">DocumentReference.</param>
        /// <param name="invoiceOrSOANumber">InvoiceOrSOANumber.</param>
        public InvoiceDownloadReq(
            int? colCoCode = null,
            string payerNumber = null,
            List<string> accountNumber = null,
            List<int> documentReference = null,
            string invoiceOrSOANumber = null)
        {
            this.ColCoCode = colCoCode;
            this.PayerNumber = payerNumber;
            this.AccountNumber = accountNumber;
            this.DocumentReference = documentReference;
            if (invoiceOrSOANumber != null)
            {
                this.InvoiceOrSOANumber = invoiceOrSOANumber;
            }

        }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// Mandatory
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Include)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Mandatory
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Include)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// List of Account Numbers of the invoices.
        /// Mandatory for customer users else optional.
        /// </summary>
        [JsonProperty("AccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccountNumber { get; set; }

        /// <summary>
        /// Unique reference ids of invoice document (of zip file).
        /// Optional if InvoiceOrSOANumber is passed else Mandatory.
        /// </summary>
        [JsonProperty("DocumentReference", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> DocumentReference { get; set; }

        /// <summary>
        /// Invoice or the SOA document reference number issued by Card s Platform.
        /// </summary>
        [JsonProperty("InvoiceOrSOANumber")]
        public string InvoiceOrSOANumber
        {
            get
            {
                return this.invoiceOrSOANumber;
            }

            set
            {
                this.shouldSerialize["InvoiceOrSOANumber"] = true;
                this.invoiceOrSOANumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceDownloadReq : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceOrSOANumber()
        {
            this.shouldSerialize["InvoiceOrSOANumber"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceOrSOANumber()
        {
            return this.shouldSerialize["InvoiceOrSOANumber"];
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
            return obj is InvoiceDownloadReq other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.DocumentReference == null && other.DocumentReference == null) || (this.DocumentReference?.Equals(other.DocumentReference) == true)) &&
                ((this.InvoiceOrSOANumber == null && other.InvoiceOrSOANumber == null) || (this.InvoiceOrSOANumber?.Equals(other.InvoiceOrSOANumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : $"[{string.Join(", ", this.AccountNumber)} ]")}");
            toStringOutput.Add($"this.DocumentReference = {(this.DocumentReference == null ? "null" : $"[{string.Join(", ", this.DocumentReference)} ]")}");
            toStringOutput.Add($"this.InvoiceOrSOANumber = {(this.InvoiceOrSOANumber == null ? "null" : this.InvoiceOrSOANumber)}");
        }
    }
}