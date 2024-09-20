// <copyright file="SearchDocumentsInvoice.cs" company="APIMatic">
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
    /// SearchDocumentsInvoice.
    /// </summary>
    public class SearchDocumentsInvoice
    {
        private string invoiceNumber;
        private string payerName;
        private string accountNumber;
        private string accountName;
        private string documentType;
        private double? grossAmount;
        private double? netAmount;
        private double? taxAmount;
        private string currencyCode;
        private string invoiceStatus;
        private string invoiceDate;
        private string dueDate;
        private string vATCountryISOCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "InvoiceNumber", false },
            { "PayerName", false },
            { "AccountNumber", false },
            { "AccountName", false },
            { "DocumentType", false },
            { "GrossAmount", false },
            { "NetAmount", false },
            { "TaxAmount", false },
            { "CurrencyCode", false },
            { "InvoiceStatus", false },
            { "InvoiceDate", false },
            { "DueDate", false },
            { "VATCountryISOCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocumentsInvoice"/> class.
        /// </summary>
        public SearchDocumentsInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocumentsInvoice"/> class.
        /// </summary>
        /// <param name="documentReference">DocumentReference.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="payerName">PayerName.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountName">AccountName.</param>
        /// <param name="documentType">DocumentType.</param>
        /// <param name="grossAmount">GrossAmount.</param>
        /// <param name="netAmount">NetAmount.</param>
        /// <param name="taxAmount">TaxAmount.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="dueDate">DueDate.</param>
        /// <param name="vATCountryISOCode">VATCountryISOCode.</param>
        public SearchDocumentsInvoice(
            int? documentReference = null,
            string invoiceNumber = null,
            string payerName = null,
            string accountNumber = null,
            string accountName = null,
            string documentType = null,
            double? grossAmount = null,
            double? netAmount = null,
            double? taxAmount = null,
            string currencyCode = null,
            string invoiceStatus = null,
            string invoiceDate = null,
            string dueDate = null,
            string vATCountryISOCode = null)
        {
            this.DocumentReference = documentReference;
            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (payerName != null)
            {
                this.PayerName = payerName;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountName != null)
            {
                this.AccountName = accountName;
            }

            if (documentType != null)
            {
                this.DocumentType = documentType;
            }

            if (grossAmount != null)
            {
                this.GrossAmount = grossAmount;
            }

            if (netAmount != null)
            {
                this.NetAmount = netAmount;
            }

            if (taxAmount != null)
            {
                this.TaxAmount = taxAmount;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (invoiceStatus != null)
            {
                this.InvoiceStatus = invoiceStatus;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            if (dueDate != null)
            {
                this.DueDate = dueDate;
            }

            if (vATCountryISOCode != null)
            {
                this.VATCountryISOCode = vATCountryISOCode;
            }

        }

        /// <summary>
        /// Unique Invoice Reference id of the invoice for downloading the zip file containing PDF and proofing elements.
        /// Example: 123456
        /// </summary>
        [JsonProperty("DocumentReference", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocumentReference { get; set; }

        /// <summary>
        /// Payment customer number.
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("InvoiceNumber")]
        public string InvoiceNumber
        {
            get
            {
                return this.invoiceNumber;
            }

            set
            {
                this.shouldSerialize["InvoiceNumber"] = true;
                this.invoiceNumber = value;
            }
        }

        /// <summary>
        /// Customer payer name
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName
        {
            get
            {
                return this.payerName;
            }

            set
            {
                this.shouldSerialize["PayerName"] = true;
                this.payerName = value;
            }
        }

        /// <summary>
        /// Account Number
        /// Example: GB99215176
        /// </summary>
        [JsonProperty("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["AccountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Invoice account name
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName
        {
            get
            {
                return this.accountName;
            }

            set
            {
                this.shouldSerialize["AccountName"] = true;
                this.accountName = value;
            }
        }

        /// <summary>
        /// Document type
        /// String containing one of the following values:
        /// •    NAT (National)
        /// •    INT (International)
        /// •    SOA (Statement of Account)
        /// </summary>
        [JsonProperty("DocumentType")]
        public string DocumentType
        {
            get
            {
                return this.documentType;
            }

            set
            {
                this.shouldSerialize["DocumentType"] = true;
                this.documentType = value;
            }
        }

        /// <summary>
        /// Included tax amount in the invoice
        /// </summary>
        [JsonProperty("GrossAmount")]
        public double? GrossAmount
        {
            get
            {
                return this.grossAmount;
            }

            set
            {
                this.shouldSerialize["GrossAmount"] = true;
                this.grossAmount = value;
            }
        }

        /// <summary>
        /// Gets or sets NetAmount.
        /// </summary>
        [JsonProperty("NetAmount")]
        public double? NetAmount
        {
            get
            {
                return this.netAmount;
            }

            set
            {
                this.shouldSerialize["NetAmount"] = true;
                this.netAmount = value;
            }
        }

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonProperty("TaxAmount")]
        public double? TaxAmount
        {
            get
            {
                return this.taxAmount;
            }

            set
            {
                this.shouldSerialize["TaxAmount"] = true;
                this.taxAmount = value;
            }
        }

        /// <summary>
        /// Gets or sets CurrencyCode.
        /// </summary>
        [JsonProperty("CurrencyCode")]
        public string CurrencyCode
        {
            get
            {
                return this.currencyCode;
            }

            set
            {
                this.shouldSerialize["CurrencyCode"] = true;
                this.currencyCode = value;
            }
        }

        /// <summary>
        /// Gets or sets InvoiceStatus.
        /// </summary>
        [JsonProperty("InvoiceStatus")]
        public string InvoiceStatus
        {
            get
            {
                return this.invoiceStatus;
            }

            set
            {
                this.shouldSerialize["InvoiceStatus"] = true;
                this.invoiceStatus = value;
            }
        }

        /// <summary>
        /// Gets or sets InvoiceDate.
        /// </summary>
        [JsonProperty("InvoiceDate")]
        public string InvoiceDate
        {
            get
            {
                return this.invoiceDate;
            }

            set
            {
                this.shouldSerialize["InvoiceDate"] = true;
                this.invoiceDate = value;
            }
        }

        /// <summary>
        /// Gets or sets DueDate.
        /// </summary>
        [JsonProperty("DueDate")]
        public string DueDate
        {
            get
            {
                return this.dueDate;
            }

            set
            {
                this.shouldSerialize["DueDate"] = true;
                this.dueDate = value;
            }
        }

        /// <summary>
        /// Gets or sets VATCountryISOCode.
        /// </summary>
        [JsonProperty("VATCountryISOCode")]
        public string VATCountryISOCode
        {
            get
            {
                return this.vATCountryISOCode;
            }

            set
            {
                this.shouldSerialize["VATCountryISOCode"] = true;
                this.vATCountryISOCode = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchDocumentsInvoice : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceNumber()
        {
            this.shouldSerialize["InvoiceNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerName()
        {
            this.shouldSerialize["PayerName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentType()
        {
            this.shouldSerialize["DocumentType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGrossAmount()
        {
            this.shouldSerialize["GrossAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetAmount()
        {
            this.shouldSerialize["NetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTaxAmount()
        {
            this.shouldSerialize["TaxAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrencyCode()
        {
            this.shouldSerialize["CurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceStatus()
        {
            this.shouldSerialize["InvoiceStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceDate()
        {
            this.shouldSerialize["InvoiceDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDueDate()
        {
            this.shouldSerialize["DueDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATCountryISOCode()
        {
            this.shouldSerialize["VATCountryISOCode"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceNumber()
        {
            return this.shouldSerialize["InvoiceNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerName()
        {
            return this.shouldSerialize["PayerName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountName()
        {
            return this.shouldSerialize["AccountName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentType()
        {
            return this.shouldSerialize["DocumentType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrossAmount()
        {
            return this.shouldSerialize["GrossAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetAmount()
        {
            return this.shouldSerialize["NetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTaxAmount()
        {
            return this.shouldSerialize["TaxAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrencyCode()
        {
            return this.shouldSerialize["CurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceStatus()
        {
            return this.shouldSerialize["InvoiceStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceDate()
        {
            return this.shouldSerialize["InvoiceDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueDate()
        {
            return this.shouldSerialize["DueDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATCountryISOCode()
        {
            return this.shouldSerialize["VATCountryISOCode"];
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
            return obj is SearchDocumentsInvoice other &&                ((this.DocumentReference == null && other.DocumentReference == null) || (this.DocumentReference?.Equals(other.DocumentReference) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.PayerName == null && other.PayerName == null) || (this.PayerName?.Equals(other.PayerName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true)) &&
                ((this.GrossAmount == null && other.GrossAmount == null) || (this.GrossAmount?.Equals(other.GrossAmount) == true)) &&
                ((this.NetAmount == null && other.NetAmount == null) || (this.NetAmount?.Equals(other.NetAmount) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.DueDate == null && other.DueDate == null) || (this.DueDate?.Equals(other.DueDate) == true)) &&
                ((this.VATCountryISOCode == null && other.VATCountryISOCode == null) || (this.VATCountryISOCode?.Equals(other.VATCountryISOCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DocumentReference = {(this.DocumentReference == null ? "null" : this.DocumentReference.ToString())}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.PayerName = {(this.PayerName == null ? "null" : this.PayerName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType)}");
            toStringOutput.Add($"this.GrossAmount = {(this.GrossAmount == null ? "null" : this.GrossAmount.ToString())}");
            toStringOutput.Add($"this.NetAmount = {(this.NetAmount == null ? "null" : this.NetAmount.ToString())}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus)}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.DueDate = {(this.DueDate == null ? "null" : this.DueDate)}");
            toStringOutput.Add($"this.VATCountryISOCode = {(this.VATCountryISOCode == null ? "null" : this.VATCountryISOCode)}");
        }
    }
}