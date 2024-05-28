// <copyright file="EIDDocument.cs" company="APIMatic">
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
    /// EIDDocument.
    /// </summary>
    public class EIDDocument
    {
        private int? documentId;
        private string accountGroupId;
        private string accountGroupName;
        private string documentType;
        private string documentFormat;
        private string documentDate;
        private int? numberOfInvoices;
        private int? fileSize;
        private string documentStatus;
        private string documentName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DocumentId", false },
            { "AccountGroupId", false },
            { "AccountGroupName", false },
            { "DocumentType", false },
            { "DocumentFormat", false },
            { "DocumentDate", false },
            { "NumberOfInvoices", false },
            { "FileSize", false },
            { "DocumentStatus", false },
            { "DocumentName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="EIDDocument"/> class.
        /// </summary>
        public EIDDocument()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EIDDocument"/> class.
        /// </summary>
        /// <param name="documentId">DocumentId.</param>
        /// <param name="accountGroupId">AccountGroupId.</param>
        /// <param name="accountGroupName">AccountGroupName.</param>
        /// <param name="documentType">DocumentType.</param>
        /// <param name="documentFormat">DocumentFormat.</param>
        /// <param name="documentDate">DocumentDate.</param>
        /// <param name="numberOfInvoices">NumberOfInvoices.</param>
        /// <param name="fileSize">FileSize.</param>
        /// <param name="documentStatus">DocumentStatus.</param>
        /// <param name="documentName">DocumentName.</param>
        public EIDDocument(
            int? documentId = null,
            string accountGroupId = null,
            string accountGroupName = null,
            string documentType = null,
            string documentFormat = null,
            string documentDate = null,
            int? numberOfInvoices = null,
            int? fileSize = null,
            string documentStatus = null,
            string documentName = null)
        {
            if (documentId != null)
            {
                this.DocumentId = documentId;
            }

            if (accountGroupId != null)
            {
                this.AccountGroupId = accountGroupId;
            }

            if (accountGroupName != null)
            {
                this.AccountGroupName = accountGroupName;
            }

            if (documentType != null)
            {
                this.DocumentType = documentType;
            }

            if (documentFormat != null)
            {
                this.DocumentFormat = documentFormat;
            }

            if (documentDate != null)
            {
                this.DocumentDate = documentDate;
            }

            if (numberOfInvoices != null)
            {
                this.NumberOfInvoices = numberOfInvoices;
            }

            if (fileSize != null)
            {
                this.FileSize = fileSize;
            }

            if (documentStatus != null)
            {
                this.DocumentStatus = documentStatus;
            }

            if (documentName != null)
            {
                this.DocumentName = documentName;
            }

        }

        /// <summary>
        /// Technical identifier for the EID file. Should not be stored in database as it is not guaranteed to stay unchanged over time.
        /// </summary>
        [JsonProperty("DocumentId")]
        public int? DocumentId
        {
            get
            {
                return this.documentId;
            }

            set
            {
                this.shouldSerialize["DocumentId"] = true;
                this.documentId = value;
            }
        }

        /// <summary>
        /// Account Group Id
        /// </summary>
        [JsonProperty("AccountGroupId")]
        public string AccountGroupId
        {
            get
            {
                return this.accountGroupId;
            }

            set
            {
                this.shouldSerialize["AccountGroupId"] = true;
                this.accountGroupId = value;
            }
        }

        /// <summary>
        /// Account group name
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
        /// Document type.
        /// Possible values:
        /// •	NAT (National)
        /// •	INT (International)
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
        /// Document format (CHORUS, DIFI etc.)
        /// </summary>
        [JsonProperty("DocumentFormat")]
        public string DocumentFormat
        {
            get
            {
                return this.documentFormat;
            }

            set
            {
                this.shouldSerialize["DocumentFormat"] = true;
                this.documentFormat = value;
            }
        }

        /// <summary>
        /// Document date.
        /// Example: 20170101
        /// </summary>
        [JsonProperty("DocumentDate")]
        public string DocumentDate
        {
            get
            {
                return this.documentDate;
            }

            set
            {
                this.shouldSerialize["DocumentDate"] = true;
                this.documentDate = value;
            }
        }

        /// <summary>
        /// Number of invoices
        /// </summary>
        [JsonProperty("NumberOfInvoices")]
        public int? NumberOfInvoices
        {
            get
            {
                return this.numberOfInvoices;
            }

            set
            {
                this.shouldSerialize["NumberOfInvoices"] = true;
                this.numberOfInvoices = value;
            }
        }

        /// <summary>
        /// Document size
        /// </summary>
        [JsonProperty("FileSize")]
        public int? FileSize
        {
            get
            {
                return this.fileSize;
            }

            set
            {
                this.shouldSerialize["FileSize"] = true;
                this.fileSize = value;
            }
        }

        /// <summary>
        /// Document status.
        /// Possible values:
        /// •	NEW
        /// •	VIEWED
        /// •	DOWNLOADED
        /// •	RESTORED
        /// </summary>
        [JsonProperty("DocumentStatus")]
        public string DocumentStatus
        {
            get
            {
                return this.documentStatus;
            }

            set
            {
                this.shouldSerialize["DocumentStatus"] = true;
                this.documentStatus = value;
            }
        }

        /// <summary>
        /// Document file name.
        /// </summary>
        [JsonProperty("DocumentName")]
        public string DocumentName
        {
            get
            {
                return this.documentName;
            }

            set
            {
                this.shouldSerialize["DocumentName"] = true;
                this.documentName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EIDDocument : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentId()
        {
            this.shouldSerialize["DocumentId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountGroupId()
        {
            this.shouldSerialize["AccountGroupId"] = false;
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
        public void UnsetDocumentType()
        {
            this.shouldSerialize["DocumentType"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentFormat()
        {
            this.shouldSerialize["DocumentFormat"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentDate()
        {
            this.shouldSerialize["DocumentDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNumberOfInvoices()
        {
            this.shouldSerialize["NumberOfInvoices"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFileSize()
        {
            this.shouldSerialize["FileSize"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentStatus()
        {
            this.shouldSerialize["DocumentStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDocumentName()
        {
            this.shouldSerialize["DocumentName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentId()
        {
            return this.shouldSerialize["DocumentId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountGroupId()
        {
            return this.shouldSerialize["AccountGroupId"];
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
        public bool ShouldSerializeDocumentType()
        {
            return this.shouldSerialize["DocumentType"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentFormat()
        {
            return this.shouldSerialize["DocumentFormat"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentDate()
        {
            return this.shouldSerialize["DocumentDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNumberOfInvoices()
        {
            return this.shouldSerialize["NumberOfInvoices"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFileSize()
        {
            return this.shouldSerialize["FileSize"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentStatus()
        {
            return this.shouldSerialize["DocumentStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDocumentName()
        {
            return this.shouldSerialize["DocumentName"];
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
            return obj is EIDDocument other &&                ((this.DocumentId == null && other.DocumentId == null) || (this.DocumentId?.Equals(other.DocumentId) == true)) &&
                ((this.AccountGroupId == null && other.AccountGroupId == null) || (this.AccountGroupId?.Equals(other.AccountGroupId) == true)) &&
                ((this.AccountGroupName == null && other.AccountGroupName == null) || (this.AccountGroupName?.Equals(other.AccountGroupName) == true)) &&
                ((this.DocumentType == null && other.DocumentType == null) || (this.DocumentType?.Equals(other.DocumentType) == true)) &&
                ((this.DocumentFormat == null && other.DocumentFormat == null) || (this.DocumentFormat?.Equals(other.DocumentFormat) == true)) &&
                ((this.DocumentDate == null && other.DocumentDate == null) || (this.DocumentDate?.Equals(other.DocumentDate) == true)) &&
                ((this.NumberOfInvoices == null && other.NumberOfInvoices == null) || (this.NumberOfInvoices?.Equals(other.NumberOfInvoices) == true)) &&
                ((this.FileSize == null && other.FileSize == null) || (this.FileSize?.Equals(other.FileSize) == true)) &&
                ((this.DocumentStatus == null && other.DocumentStatus == null) || (this.DocumentStatus?.Equals(other.DocumentStatus) == true)) &&
                ((this.DocumentName == null && other.DocumentName == null) || (this.DocumentName?.Equals(other.DocumentName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DocumentId = {(this.DocumentId == null ? "null" : this.DocumentId.ToString())}");
            toStringOutput.Add($"this.AccountGroupId = {(this.AccountGroupId == null ? "null" : this.AccountGroupId)}");
            toStringOutput.Add($"this.AccountGroupName = {(this.AccountGroupName == null ? "null" : this.AccountGroupName)}");
            toStringOutput.Add($"this.DocumentType = {(this.DocumentType == null ? "null" : this.DocumentType)}");
            toStringOutput.Add($"this.DocumentFormat = {(this.DocumentFormat == null ? "null" : this.DocumentFormat)}");
            toStringOutput.Add($"this.DocumentDate = {(this.DocumentDate == null ? "null" : this.DocumentDate)}");
            toStringOutput.Add($"this.NumberOfInvoices = {(this.NumberOfInvoices == null ? "null" : this.NumberOfInvoices.ToString())}");
            toStringOutput.Add($"this.FileSize = {(this.FileSize == null ? "null" : this.FileSize.ToString())}");
            toStringOutput.Add($"this.DocumentStatus = {(this.DocumentStatus == null ? "null" : this.DocumentStatus)}");
            toStringOutput.Add($"this.DocumentName = {(this.DocumentName == null ? "null" : this.DocumentName)}");
        }
    }
}