// <copyright file="SearchDocReq.cs" company="APIMatic">
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
    /// SearchDocReq.
    /// </summary>
    public class SearchDocReq
    {
        private string accountNumber;
        private string invoiceNumber;
        private string invoiceStatus;
        private string issuingDateFrom;
        private string issuingDateTo;
        private string dueDateFrom;
        private string dueDateTo;
        private string grossAmount;
        private string grossAmountOperator;
        private string documentType;
        private string vATIssuerCountry;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountNumber", false },
            { "InvoiceNumber", false },
            { "InvoiceStatus", false },
            { "IssuingDateFrom", false },
            { "IssuingDateTo", false },
            { "DueDateFrom", false },
            { "DueDateTo", false },
            { "GrossAmount", false },
            { "GrossAmountOperator", false },
            { "DocumentType", false },
            { "VATIssuerCountry", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocReq"/> class.
        /// </summary>
        public SearchDocReq()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchDocReq"/> class.
        /// </summary>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountNumberList">AccountNumberList.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="invoiceNumberList">InvoiceNumberList.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="issuingDateFrom">IssuingDateFrom.</param>
        /// <param name="issuingDateTo">IssuingDateTo.</param>
        /// <param name="dueDateFrom">DueDateFrom.</param>
        /// <param name="dueDateTo">DueDateTo.</param>
        /// <param name="grossAmount">GrossAmount.</param>
        /// <param name="grossAmountOperator">GrossAmountOperator.</param>
        /// <param name="documentType">DocumentType.</param>
        /// <param name="vATIssuerCountry">VATIssuerCountry.</param>
        /// <param name="sortyBy">SortyBy.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        public SearchDocReq(
            string payerNumber = null,
            string accountNumber = null,
            List<string> accountNumberList = null,
            string invoiceNumber = null,
            List<string> invoiceNumberList = null,
            string invoiceStatus = null,
            string issuingDateFrom = null,
            string issuingDateTo = null,
            string dueDateFrom = null,
            string dueDateTo = null,
            string grossAmount = null,
            string grossAmountOperator = null,
            string documentType = null,
            string vATIssuerCountry = null,
            List<string> sortyBy = null,
            int? colCoCode = null)
        {
            this.PayerNumber = payerNumber;
            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            this.AccountNumberList = accountNumberList;
            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            this.InvoiceNumberList = invoiceNumberList;
            if (invoiceStatus != null)
            {
                this.InvoiceStatus = invoiceStatus;
            }

            if (issuingDateFrom != null)
            {
                this.IssuingDateFrom = issuingDateFrom;
            }

            if (issuingDateTo != null)
            {
                this.IssuingDateTo = issuingDateTo;
            }

            if (dueDateFrom != null)
            {
                this.DueDateFrom = dueDateFrom;
            }

            if (dueDateTo != null)
            {
                this.DueDateTo = dueDateTo;
            }

            if (grossAmount != null)
            {
                this.GrossAmount = grossAmount;
            }

            if (grossAmountOperator != null)
            {
                this.GrossAmountOperator = grossAmountOperator;
            }

            if (documentType != null)
            {
                this.DocumentType = documentType;
            }

            if (vATIssuerCountry != null)
            {
                this.VATIssuerCountry = vATIssuerCountry;
            }

            this.SortyBy = sortyBy;
            this.ColCoCode = colCoCode;
        }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Mandatory
        /// Example: GB000000123
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Include)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Account Number of the customer.
        /// Mandatory for customer users else optional.
        /// This input is a search criterion, if given.
        /// Example: GB000000123
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
        /// Account Number of the customers.
        /// optional.
        /// This input is a search criterion, if given.
        /// Example: [“GB00000123”, “GB00000225”]
        /// </summary>
        [JsonProperty("AccountNumberList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccountNumberList { get; set; }

        /// <summary>
        /// Invoice number.
        /// Optional if InvoiceNumberList is passed else Mandatory
        /// This input is a search criterion, if given.
        /// Example: 0123456789
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
        /// List of Invoice number.
        /// Optional if InvoiceNumber is passed else Mandatory
        /// Example: [“0123456789”, “0123459799”]
        /// </summary>
        [JsonProperty("InvoiceNumberList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvoiceNumberList { get; set; }

        /// <summary>
        /// The status of the invoices
        /// Optional
        /// One of the following values:
        /// •    NEW
        /// •    VIEWED
        /// •    DOWNLOADED
        /// •    RESTORED
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
        /// Invoice Issuing Date Range/From
        /// Optional
        /// Format: yyyy/MM/dd
        /// </summary>
        [JsonProperty("IssuingDateFrom")]
        public string IssuingDateFrom
        {
            get
            {
                return this.issuingDateFrom;
            }

            set
            {
                this.shouldSerialize["IssuingDateFrom"] = true;
                this.issuingDateFrom = value;
            }
        }

        /// <summary>
        /// Invoice Issuing Date Range/To
        /// Optional
        /// Format: yyyy/MM/dd
        /// </summary>
        [JsonProperty("IssuingDateTo")]
        public string IssuingDateTo
        {
            get
            {
                return this.issuingDateTo;
            }

            set
            {
                this.shouldSerialize["IssuingDateTo"] = true;
                this.issuingDateTo = value;
            }
        }

        /// <summary>
        /// Invoice Due Date Range/From
        /// Optional
        /// Format: yyyy/MM/dd
        /// </summary>
        [JsonProperty("DueDateFrom")]
        public string DueDateFrom
        {
            get
            {
                return this.dueDateFrom;
            }

            set
            {
                this.shouldSerialize["DueDateFrom"] = true;
                this.dueDateFrom = value;
            }
        }

        /// <summary>
        /// Invoice Due Date Range/To
        /// Optional
        /// Format: yyyy/MM/dd
        /// </summary>
        [JsonProperty("DueDateTo")]
        public string DueDateTo
        {
            get
            {
                return this.dueDateTo;
            }

            set
            {
                this.shouldSerialize["DueDateTo"] = true;
                this.dueDateTo = value;
            }
        }

        /// <summary>
        /// Gross amount of the bill.
        /// Optional
        /// </summary>
        [JsonProperty("GrossAmount")]
        public string GrossAmount
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
        /// Criteria on the gross amount, for instance use GT when to retrieve the invoices for that gross amount is greater than the given amount on GrossAmount parameter above.
        /// Optional
        /// This parameter will be ignored if GrossAmount parameter is not set.
        /// One of the following values:
        /// •    LT (Less Than)
        /// •    LE (Lesser or Equal)
        /// •    EQ (equal)
        /// •    GE (Greater or equal)
        /// •    GT (Greater than)
        /// </summary>
        [JsonProperty("GrossAmountOperator")]
        public string GrossAmountOperator
        {
            get
            {
                return this.grossAmountOperator;
            }

            set
            {
                this.shouldSerialize["GrossAmountOperator"] = true;
                this.grossAmountOperator = value;
            }
        }

        /// <summary>
        /// Document Type
        /// Optional
        /// One of the following values:
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
        /// Two letter ISO country code.
        /// </summary>
        [JsonProperty("VATIssuerCountry")]
        public string VATIssuerCountry
        {
            get
            {
                return this.vATIssuerCountry;
            }

            set
            {
                this.shouldSerialize["VATIssuerCountry"] = true;
                this.vATIssuerCountry = value;
            }
        }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// Mandatory
        /// Example:
        /// 86-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("SortyBy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SortyBy { get; set; }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// Mandatory
        /// Example:
        /// 86-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Include)]
        public int? ColCoCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchDocReq : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetInvoiceNumber()
        {
            this.shouldSerialize["InvoiceNumber"] = false;
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
        public void UnsetIssuingDateFrom()
        {
            this.shouldSerialize["IssuingDateFrom"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIssuingDateTo()
        {
            this.shouldSerialize["IssuingDateTo"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDueDateFrom()
        {
            this.shouldSerialize["DueDateFrom"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDueDateTo()
        {
            this.shouldSerialize["DueDateTo"] = false;
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
        public void UnsetGrossAmountOperator()
        {
            this.shouldSerialize["GrossAmountOperator"] = false;
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
        public void UnsetVATIssuerCountry()
        {
            this.shouldSerialize["VATIssuerCountry"] = false;
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
        public bool ShouldSerializeInvoiceNumber()
        {
            return this.shouldSerialize["InvoiceNumber"];
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
        public bool ShouldSerializeIssuingDateFrom()
        {
            return this.shouldSerialize["IssuingDateFrom"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIssuingDateTo()
        {
            return this.shouldSerialize["IssuingDateTo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueDateFrom()
        {
            return this.shouldSerialize["DueDateFrom"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDueDateTo()
        {
            return this.shouldSerialize["DueDateTo"];
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
        public bool ShouldSerializeGrossAmountOperator()
        {
            return this.shouldSerialize["GrossAmountOperator"];
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
        public bool ShouldSerializeVATIssuerCountry()
        {
            return this.shouldSerialize["VATIssuerCountry"];
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
            return obj is SearchDocReq other &&                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountNumberList == null && other.AccountNumberList == null) || (this.AccountNumberList?.Equals(other.AccountNumberList) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.InvoiceNumberList == null && other.InvoiceNumberList == null) || (this.InvoiceNumberList?.Equals(other.InvoiceNumberList) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.IssuingDateFrom == null && other.IssuingDateFrom == null) || (this.IssuingDateFrom?.Equals(other.IssuingDateFrom) == true)) &&
                ((this.IssuingDateTo == null && other.IssuingDateTo == null) || (this.IssuingDateTo?.Equals(other.IssuingDateTo) == true)) &&
                ((this.DueDateFrom == null && other.DueDateFrom == null) || (this.DueDateFrom?.Equals(other.DueDateFrom) == true)) &&
                ((this.DueDateTo == null && other.DueDateTo == null) || (this.DueDateTo?.Equals(other.DueDateTo) == true)) &&
                ((this.GrossAmount == null && other.GrossAmount == null) || (this.GrossAmount?.Equals(other.GrossAmount) == true)) &&
                ((this.GrossAmountOperator == null && other.GrossAmountOperator == null) || (this.GrossAmountOperator?.Equals(other.GrossAmountOperator) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true)) &&
                ((this.VATIssuerCountry == null && other.VATIssuerCountry == null) || (this.VATIssuerCountry?.Equals(other.VATIssuerCountry) == true)) &&
                ((this.SortyBy == null && other.SortyBy == null) || (this.SortyBy?.Equals(other.SortyBy) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountNumberList = {(this.AccountNumberList == null ? "null" : $"[{string.Join(", ", this.AccountNumberList)} ]")}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.InvoiceNumberList = {(this.InvoiceNumberList == null ? "null" : $"[{string.Join(", ", this.InvoiceNumberList)} ]")}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus)}");
            toStringOutput.Add($"this.IssuingDateFrom = {(this.IssuingDateFrom == null ? "null" : this.IssuingDateFrom)}");
            toStringOutput.Add($"this.IssuingDateTo = {(this.IssuingDateTo == null ? "null" : this.IssuingDateTo)}");
            toStringOutput.Add($"this.DueDateFrom = {(this.DueDateFrom == null ? "null" : this.DueDateFrom)}");
            toStringOutput.Add($"this.DueDateTo = {(this.DueDateTo == null ? "null" : this.DueDateTo)}");
            toStringOutput.Add($"this.GrossAmount = {(this.GrossAmount == null ? "null" : this.GrossAmount)}");
            toStringOutput.Add($"this.GrossAmountOperator = {(this.GrossAmountOperator == null ? "null" : this.GrossAmountOperator)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType)}");
            toStringOutput.Add($"this.VATIssuerCountry = {(this.VATIssuerCountry == null ? "null" : this.VATIssuerCountry)}");
            toStringOutput.Add($"this.SortyBy = {(this.SortyBy == null ? "null" : $"[{string.Join(", ", this.SortyBy)} ]")}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
        }
    }
}