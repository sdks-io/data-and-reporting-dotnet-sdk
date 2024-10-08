// <copyright file="SearchSOAReq.cs" company="APIMatic">
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
    /// SearchSOAReq.
    /// </summary>
    public class SearchSOAReq
    {
        private int? colCoCode;
        private string payerNumber;
        private string invoiceNumber;
        private string fromDate;
        private string toDate;
        private int? period;
        private string invoiceDate;
        private int? colCoId;
        private int? payerId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoCode", false },
            { "PayerNumber", false },
            { "InvoiceNumber", false },
            { "FromDate", false },
            { "ToDate", false },
            { "Period", false },
            { "InvoiceDate", false },
            { "ColCoId", false },
            { "PayerId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSOAReq"/> class.
        /// </summary>
        public SearchSOAReq()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchSOAReq"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="invoiceNumber">InvoiceNumber.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="period">Period.</param>
        /// <param name="invoiceDate">InvoiceDate.</param>
        /// <param name="invoiceStatus">InvoiceStatus.</param>
        /// <param name="sortBy">SortBy.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="payerId">PayerId.</param>
        public SearchSOAReq(
            int? colCoCode = null,
            string payerNumber = null,
            string invoiceNumber = null,
            string fromDate = null,
            string toDate = null,
            int? period = null,
            string invoiceDate = null,
            List<string> invoiceStatus = null,
            List<int> sortBy = null,
            int? colCoId = null,
            int? payerId = null)
        {
            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (invoiceNumber != null)
            {
                this.InvoiceNumber = invoiceNumber;
            }

            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            if (period != null)
            {
                this.Period = period;
            }

            if (invoiceDate != null)
            {
                this.InvoiceDate = invoiceDate;
            }

            this.InvoiceStatus = invoiceStatus;
            this.SortBy = sortBy;
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

        }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory.
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <summary>
        /// Invoice number.
        /// Optional.
        /// This input is a search criterion, if given.
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
        /// SOA searched from this date.
        /// Optional.
        /// This input is a search criterion, if given.
        /// Date format: yyyy/MM/dd
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
        /// This input is a search criterion, if given.
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
        /// Invoice date search period. Valid values -
        /// Last 7 days – Issued in last 7 days.
        /// Last 30 days – Issued in last 30 days.
        /// Last 90 days – Issued in last 90 days.
        /// Optional.
        /// This input is a search criterion, if given.
        /// </summary>
        [JsonProperty("Period")]
        public int? Period
        {
            get
            {
                return this.period;
            }

            set
            {
                this.shouldSerialize["Period"] = true;
                this.period = value;
            }
        }

        /// <summary>
        /// Date of invoicing.
        /// Optional.
        /// This input is a search criterion, if given.
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
        /// Possible options are:
        /// 1.    StatementDate ASC
        /// 2.    StatementDate DESC
        /// Optional
        /// Note:
        /// This option uses a column name with a combination of “ASC or DESC” for sorting.
        /// If only the column name is provided, it is sorted by ascending.
        /// Sorting is allowed only ASC or DESC, If both provided in the input ASC will be taken as precedence.
        /// </summary>
        [JsonProperty("InvoiceStatus", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvoiceStatus { get; set; }

        /// <summary>
        /// Possible options are:
        /// 1.    StatementDate ASC
        /// 2.    StatementDate DESC
        /// Optional
        /// Note:
        /// This option uses a column name with a combination of “ASC or DESC” for sorting.
        /// If only the column name is provided, it is sorted by ascending.
        /// Sorting is allowed only ASC or DESC, If both provided in the input ASC will be taken as precedence.
        /// </summary>
        [JsonProperty("SortBy", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> SortBy { get; set; }

        /// <summary>
        /// Collecting Company Id  of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1-Philippines
        /// 5-UK
        /// </summary>
        [JsonProperty("ColCoId")]
        public int? ColCoId
        {
            get
            {
                return this.colCoId;
            }

            set
            {
                this.shouldSerialize["ColCoId"] = true;
                this.colCoId = value;
            }
        }

        /// <summary>
        /// Payer Id  of the selected payer.
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SearchSOAReq : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
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
        public void UnsetPeriod()
        {
            this.shouldSerialize["Period"] = false;
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
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
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
        public bool ShouldSerializePeriod()
        {
            return this.shouldSerialize["Period"];
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
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
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
            return obj is SearchSOAReq other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.InvoiceNumber == null && other.InvoiceNumber == null) || (this.InvoiceNumber?.Equals(other.InvoiceNumber) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.Period == null && other.Period == null) || (this.Period?.Equals(other.Period) == true)) &&
                ((this.InvoiceDate == null && other.InvoiceDate == null) || (this.InvoiceDate?.Equals(other.InvoiceDate) == true)) &&
                ((this.InvoiceStatus == null && other.InvoiceStatus == null) || (this.InvoiceStatus?.Equals(other.InvoiceStatus) == true)) &&
                ((this.SortBy == null && other.SortBy == null) || (this.SortBy?.Equals(other.SortBy) == true)) &&
                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.InvoiceNumber = {(this.InvoiceNumber == null ? "null" : this.InvoiceNumber)}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.Period = {(this.Period == null ? "null" : this.Period.ToString())}");
            toStringOutput.Add($"this.InvoiceDate = {(this.InvoiceDate == null ? "null" : this.InvoiceDate)}");
            toStringOutput.Add($"this.InvoiceStatus = {(this.InvoiceStatus == null ? "null" : $"[{string.Join(", ", this.InvoiceStatus)} ]")}");
            toStringOutput.Add($"this.SortBy = {(this.SortBy == null ? "null" : $"[{string.Join(", ", this.SortBy)} ]")}");
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
        }
    }
}