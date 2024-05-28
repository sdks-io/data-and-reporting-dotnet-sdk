// <copyright file="InvoiceSearchResponse.cs" company="APIMatic">
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
    /// InvoiceSearchResponse.
    /// </summary>
    public class InvoiceSearchResponse
    {
        private string requestId;
        private string status;
        private int? page;
        private int? pageSize;
        private int? totalRecords;
        private int? totalPages;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "RequestId", false },
            { "Status", false },
            { "Page", false },
            { "PageSize", false },
            { "TotalRecords", false },
            { "TotalPages", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchResponse"/> class.
        /// </summary>
        public InvoiceSearchResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchResponse"/> class.
        /// </summary>
        /// <param name="requestId">RequestId.</param>
        /// <param name="status">Status.</param>
        /// <param name="data">Data.</param>
        /// <param name="page">Page.</param>
        /// <param name="pageSize">PageSize.</param>
        /// <param name="totalRecords">TotalRecords.</param>
        /// <param name="totalPages">TotalPages.</param>
        public InvoiceSearchResponse(
            string requestId = null,
            string status = null,
            List<Models.InvoiceSearchDetails> data = null,
            int? page = null,
            int? pageSize = null,
            int? totalRecords = null,
            int? totalPages = null)
        {
            if (requestId != null)
            {
                this.RequestId = requestId;
            }

            if (status != null)
            {
                this.Status = status;
            }

            this.Data = data;
            if (page != null)
            {
                this.Page = page;
            }

            if (pageSize != null)
            {
                this.PageSize = pageSize;
            }

            if (totalRecords != null)
            {
                this.TotalRecords = totalRecords;
            }

            if (totalPages != null)
            {
                this.TotalPages = totalPages;
            }

        }

        /// <summary>
        /// API Request Id
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId
        {
            get
            {
                return this.requestId;
            }

            set
            {
                this.shouldSerialize["RequestId"] = true;
                this.requestId = value;
            }
        }

        /// <summary>
        /// Indicates overall status of the request. Allowed values: SUCCES, FAILED
        /// </summary>
        [JsonProperty("Status")]
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["Status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.InvoiceSearchDetails> Data { get; set; }

        /// <summary>
        /// Specifies the returned page of the results
        /// </summary>
        [JsonProperty("Page")]
        public int? Page
        {
            get
            {
                return this.page;
            }

            set
            {
                this.shouldSerialize["Page"] = true;
                this.page = value;
            }
        }

        /// <summary>
        /// Specifies the number of records to be returned which could be less than the PageSize in the request
        /// </summary>
        [JsonProperty("PageSize")]
        public int? PageSize
        {
            get
            {
                return this.pageSize;
            }

            set
            {
                this.shouldSerialize["PageSize"] = true;
                this.pageSize = value;
            }
        }

        /// <summary>
        /// Specifies the total records available in the result
        /// </summary>
        [JsonProperty("TotalRecords")]
        public int? TotalRecords
        {
            get
            {
                return this.totalRecords;
            }

            set
            {
                this.shouldSerialize["TotalRecords"] = true;
                this.totalRecords = value;
            }
        }

        /// <summary>
        /// Specifies the total pages available in the result
        /// </summary>
        [JsonProperty("TotalPages")]
        public int? TotalPages
        {
            get
            {
                return this.totalPages;
            }

            set
            {
                this.shouldSerialize["TotalPages"] = true;
                this.totalPages = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceSearchResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRequestId()
        {
            this.shouldSerialize["RequestId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["Status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPage()
        {
            this.shouldSerialize["Page"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPageSize()
        {
            this.shouldSerialize["PageSize"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalRecords()
        {
            this.shouldSerialize["TotalRecords"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalPages()
        {
            this.shouldSerialize["TotalPages"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRequestId()
        {
            return this.shouldSerialize["RequestId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["Status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePage()
        {
            return this.shouldSerialize["Page"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePageSize()
        {
            return this.shouldSerialize["PageSize"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalRecords()
        {
            return this.shouldSerialize["TotalRecords"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalPages()
        {
            return this.shouldSerialize["TotalPages"];
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
            return obj is InvoiceSearchResponse other &&                ((this.RequestId == null && other.RequestId == null) || (this.RequestId?.Equals(other.RequestId) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PageSize == null && other.PageSize == null) || (this.PageSize?.Equals(other.PageSize) == true)) &&
                ((this.TotalRecords == null && other.TotalRecords == null) || (this.TotalRecords?.Equals(other.TotalRecords) == true)) &&
                ((this.TotalPages == null && other.TotalPages == null) || (this.TotalPages?.Equals(other.TotalPages) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.RequestId = {(this.RequestId == null ? "null" : this.RequestId)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : $"[{string.Join(", ", this.Data)} ]")}");
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PageSize = {(this.PageSize == null ? "null" : this.PageSize.ToString())}");
            toStringOutput.Add($"this.TotalRecords = {(this.TotalRecords == null ? "null" : this.TotalRecords.ToString())}");
            toStringOutput.Add($"this.TotalPages = {(this.TotalPages == null ? "null" : this.TotalPages.ToString())}");
        }
    }
}