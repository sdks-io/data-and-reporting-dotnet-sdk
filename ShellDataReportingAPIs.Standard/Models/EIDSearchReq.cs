// <copyright file="EIDSearchReq.cs" company="APIMatic">
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
    /// EIDSearchReq.
    /// </summary>
    public class EIDSearchReq
    {
        private string accountGroupName;
        private string fromDate;
        private string toDate;
        private string invoiceType;
        private string invoiceStatus;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountGroupName", false },
            { "FromDate", false },
            { "ToDate", false },
            { "InvoiceType", false },
            { "InvoiceStatus", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EIDSearchReq"/> class.
        /// </summary>
        public EIDSearchReq()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EIDSearchReq"/> class.
        /// </summary>
        /// <param name="accountGroupId">AccountGroupId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="accountGroupCountry">AccountGroupCountry.</param>
        /// <param name="accountGroupName">AccountGroupName.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="invoiceType">InvoiceType.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="sortBy">SortBy.</param>
        public EIDSearchReq(
            List<string> accountGroupId,
            int? colCoCode = null,
            int? accountGroupCountry = null,
            string accountGroupName = null,
            string fromDate = null,
            string toDate = null,
            string invoiceType = null,
            string invoiceStatus = null,
            List<string> sortBy = null)
        {
            this.ColCoCode = colCoCode;
            this.AccountGroupCountry = accountGroupCountry;
            this.AccountGroupId = accountGroupId;
            if (accountGroupName != null)
            {
                this.AccountGroupName = accountGroupName;
            }

            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            if (invoiceType != null)
            {
                this.InvoiceType = invoiceType;
            }

            if (invoiceStatus != null)
            {
                this.InvoiceStatus = invoiceStatus;
            }

            this.SortBy = sortBy;
        }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// Mandatory
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Include)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Country code (colco code) of the account group.
        /// Mandatory
        /// </summary>
        [JsonProperty("AccountGroupCountry", NullValueHandling = NullValueHandling.Include)]
        public int? AccountGroupCountry { get; set; }

        /// <summary>
        /// List of IDs of the account groups that user has access to.
        /// Mandatory
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public List<string> AccountGroupId { get; set; }

        /// <summary>
        /// Account group name
        /// Optional.
        /// This input is a search criterion, if given.
        /// </summary>
        [JsonProperty("AccountGroupName")]
        public string AccountGroupName
        {
            get
            {
                return this.accountGroupName;
            }

            set
            {
                this.shouldSerialize["AccountGroupName"] = true;
                this.accountGroupName = value;
            }
        }

        /// <summary>
        /// EID date searched from this date.
        /// Optional.
        /// </summary>
        [JsonProperty("FromDate")]
        public string FromDate
        {
            get
            {
                return this.fromDate;
            }

            set
            {
                this.shouldSerialize["FromDate"] = true;
                this.fromDate = value;
            }
        }

        /// <summary>
        /// Invoice date searched until this date.
        /// Optional.
        /// </summary>
        [JsonProperty("ToDate")]
        public string ToDate
        {
            get
            {
                return this.toDate;
            }

            set
            {
                this.shouldSerialize["ToDate"] = true;
                this.toDate = value;
            }
        }

        /// <summary>
        /// Invoice type.
        /// Optional.
        /// Possible values:
        /// •    NAT (National)
        /// •    INT (International)
        /// </summary>
        [JsonProperty("InvoiceType")]
        public string InvoiceType
        {
            get
            {
                return this.invoiceType;
            }

            set
            {
                this.shouldSerialize["InvoiceType"] = true;
                this.invoiceType = value;
            }
        }

        /// <summary>
        /// Status of the document.
        /// Optional.
        /// Possible values:
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
        /// Sort option –
        /// •    InvoiceNumber ASC
        /// •    InvoiceDate ASC
        /// •    InvoiceNumber DESC
        /// •    InvoiceDate DESC
        /// Optional
        /// </summary>
        [JsonProperty("SortBy", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SortBy { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EIDSearchReq : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountGroupName()
        {
            this.shouldSerialize["AccountGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFromDate()
        {
            this.shouldSerialize["FromDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetToDate()
        {
            this.shouldSerialize["ToDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceType()
        {
            this.shouldSerialize["InvoiceType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceStatus()
        {
            this.shouldSerialize["InvoiceStatus"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountGroupName()
        {
            return this.shouldSerialize["AccountGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFromDate()
        {
            return this.shouldSerialize["FromDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeToDate()
        {
            return this.shouldSerialize["ToDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceType()
        {
            return this.shouldSerialize["InvoiceType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceStatus()
        {
            return this.shouldSerialize["InvoiceStatus"];
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
            return obj is EIDSearchReq other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.AccountGroupCountry == null && other.AccountGroupCountry == null) || (this.AccountGroupCountry?.Equals(other.AccountGroupCountry) == true)) &&
                ((this.AccountGroupId == null && other.AccountGroupId == null) || (this.AccountGroupId?.Equals(other.AccountGroupId) == true)) &&
                ((this.AccountGroupName == null && other.AccountGroupName == null) || (this.AccountGroupName?.Equals(other.AccountGroupName) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.InvoiceType == null && other.InvoiceType == null) || (this.InvoiceType?.Equals(other.InvoiceType) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.SortBy == null && other.SortBy == null) || (this.SortBy?.Equals(other.SortBy) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.AccountGroupCountry = {(this.AccountGroupCountry == null ? "null" : this.AccountGroupCountry.ToString())}");
            toStringOutput.Add($"this.AccountGroupId = {(this.AccountGroupId == null ? "null" : $"[{string.Join(", ", this.AccountGroupId)} ]")}");
            toStringOutput.Add($"this.AccountGroupName = {(this.AccountGroupName == null ? "null" : this.AccountGroupName)}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.InvoiceType = {(this.InvoiceType == null ? "null" : this.InvoiceType)}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : this.InvoiceStatus)}");
            toStringOutput.Add($"this.SortBy = {(this.SortBy == null ? "null" : $"[{string.Join(", ", this.SortBy)} ]")}");
        }
    }
}