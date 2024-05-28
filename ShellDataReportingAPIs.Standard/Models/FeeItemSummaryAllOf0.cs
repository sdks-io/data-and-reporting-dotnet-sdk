// <copyright file="FeeItemSummaryAllOf0.cs" company="APIMatic">
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
    /// FeeItemSummaryAllOf0.
    /// </summary>
    public class FeeItemSummaryAllOf0
    {
        private string feeTypeGroup;
        private string feeTypeId;
        private int? productId;
        private string productCode;
        private string productName;
        private int? productGroupId;
        private string productGroupName;
        private double? totalQuantity;
        private double? totalInvoiceNetAmount;
        private double? totalInvoiceGrossAmount;
        private double? totalInvoiceVATAmount;
        private string invoiceCurrencyCode;
        private string invoiceCurrencySymbol;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "FeeTypeGroup", false },
            { "FeeTypeId", false },
            { "ProductId", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "ProductGroupId", false },
            { "ProductGroupName", false },
            { "TotalQuantity", false },
            { "TotalInvoiceNetAmount", false },
            { "TotalInvoiceGrossAmount", false },
            { "TotalInvoiceVATAmount", false },
            { "InvoiceCurrencyCode", false },
            { "InvoiceCurrencySymbol", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeItemSummaryAllOf0"/> class.
        /// </summary>
        public FeeItemSummaryAllOf0()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeItemSummaryAllOf0"/> class.
        /// </summary>
        /// <param name="feeTypeGroup">FeeTypeGroup.</param>
        /// <param name="feeTypeId">FeeTypeId.</param>
        /// <param name="productId">ProductId.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="productGroupId">ProductGroupId.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="totalQuantity">TotalQuantity.</param>
        /// <param name="totalInvoiceNetAmount">TotalInvoiceNetAmount.</param>
        /// <param name="totalInvoiceGrossAmount">TotalInvoiceGrossAmount.</param>
        /// <param name="totalInvoiceVATAmount">TotalInvoiceVATAmount.</param>
        /// <param name="invoiceCurrencyCode">InvoiceCurrencyCode.</param>
        /// <param name="invoiceCurrencySymbol">InvoiceCurrencySymbol.</param>
        public FeeItemSummaryAllOf0(
            string feeTypeGroup = null,
            string feeTypeId = null,
            int? productId = null,
            string productCode = null,
            string productName = null,
            int? productGroupId = null,
            string productGroupName = null,
            double? totalQuantity = null,
            double? totalInvoiceNetAmount = null,
            double? totalInvoiceGrossAmount = null,
            double? totalInvoiceVATAmount = null,
            string invoiceCurrencyCode = null,
            string invoiceCurrencySymbol = null)
        {
            if (feeTypeGroup != null)
            {
                this.FeeTypeGroup = feeTypeGroup;
            }

            if (feeTypeId != null)
            {
                this.FeeTypeId = feeTypeId;
            }

            if (productId != null)
            {
                this.ProductId = productId;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (productName != null)
            {
                this.ProductName = productName;
            }

            if (productGroupId != null)
            {
                this.ProductGroupId = productGroupId;
            }

            if (productGroupName != null)
            {
                this.ProductGroupName = productGroupName;
            }

            if (totalQuantity != null)
            {
                this.TotalQuantity = totalQuantity;
            }

            if (totalInvoiceNetAmount != null)
            {
                this.TotalInvoiceNetAmount = totalInvoiceNetAmount;
            }

            if (totalInvoiceGrossAmount != null)
            {
                this.TotalInvoiceGrossAmount = totalInvoiceGrossAmount;
            }

            if (totalInvoiceVATAmount != null)
            {
                this.TotalInvoiceVATAmount = totalInvoiceVATAmount;
            }

            if (invoiceCurrencyCode != null)
            {
                this.InvoiceCurrencyCode = invoiceCurrencyCode;
            }

            if (invoiceCurrencySymbol != null)
            {
                this.InvoiceCurrencySymbol = invoiceCurrencySymbol;
            }

        }

        /// <summary>
        /// Fee type group in under which the Fee item is generated.
        /// </summary>
        [JsonProperty("FeeTypeGroup")]
        public string FeeTypeGroup
        {
            get
            {
                return this.feeTypeGroup;
            }

            set
            {
                this.shouldSerialize["FeeTypeGroup"] = true;
                this.feeTypeGroup = value;
            }
        }

        /// <summary>
        /// Fee Type Id ID  Description
        /// </summary>
        [JsonProperty("FeeTypeId")]
        public string FeeTypeId
        {
            get
            {
                return this.feeTypeId;
            }

            set
            {
                this.shouldSerialize["FeeTypeId"] = true;
                this.feeTypeId = value;
            }
        }

        /// <summary>
        /// Product Id
        /// </summary>
        [JsonProperty("ProductId")]
        public int? ProductId
        {
            get
            {
                return this.productId;
            }

            set
            {
                this.shouldSerialize["ProductId"] = true;
                this.productId = value;
            }
        }

        /// <summary>
        /// Product Code
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode
        {
            get
            {
                return this.productCode;
            }

            set
            {
                this.shouldSerialize["ProductCode"] = true;
                this.productCode = value;
            }
        }

        /// <summary>
        /// Product Name
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName
        {
            get
            {
                return this.productName;
            }

            set
            {
                this.shouldSerialize["ProductName"] = true;
                this.productName = value;
            }
        }

        /// <summary>
        /// Product Group Id
        /// </summary>
        [JsonProperty("ProductGroupId")]
        public int? ProductGroupId
        {
            get
            {
                return this.productGroupId;
            }

            set
            {
                this.shouldSerialize["ProductGroupId"] = true;
                this.productGroupId = value;
            }
        }

        /// <summary>
        /// Product Group Name
        /// </summary>
        [JsonProperty("ProductGroupName")]
        public string ProductGroupName
        {
            get
            {
                return this.productGroupName;
            }

            set
            {
                this.shouldSerialize["ProductGroupName"] = true;
                this.productGroupName = value;
            }
        }

        /// <summary>
        /// Total Quantity
        /// </summary>
        [JsonProperty("TotalQuantity")]
        public double? TotalQuantity
        {
            get
            {
                return this.totalQuantity;
            }

            set
            {
                this.shouldSerialize["TotalQuantity"] = true;
                this.totalQuantity = value;
            }
        }

        /// <summary>
        /// Total Net amount in invoice currency
        /// </summary>
        [JsonProperty("TotalInvoiceNetAmount")]
        public double? TotalInvoiceNetAmount
        {
            get
            {
                return this.totalInvoiceNetAmount;
            }

            set
            {
                this.shouldSerialize["TotalInvoiceNetAmount"] = true;
                this.totalInvoiceNetAmount = value;
            }
        }

        /// <summary>
        /// Total Gross amount in invoice currency
        /// </summary>
        [JsonProperty("TotalInvoiceGrossAmount")]
        public double? TotalInvoiceGrossAmount
        {
            get
            {
                return this.totalInvoiceGrossAmount;
            }

            set
            {
                this.shouldSerialize["TotalInvoiceGrossAmount"] = true;
                this.totalInvoiceGrossAmount = value;
            }
        }

        /// <summary>
        /// Total VAT amount in invoice currency
        /// </summary>
        [JsonProperty("TotalInvoiceVATAmount")]
        public double? TotalInvoiceVATAmount
        {
            get
            {
                return this.totalInvoiceVATAmount;
            }

            set
            {
                this.shouldSerialize["TotalInvoiceVATAmount"] = true;
                this.totalInvoiceVATAmount = value;
            }
        }

        /// <summary>
        /// ISO 4217 currency code of the country
        /// </summary>
        [JsonProperty("InvoiceCurrencyCode")]
        public string InvoiceCurrencyCode
        {
            get
            {
                return this.invoiceCurrencyCode;
            }

            set
            {
                this.shouldSerialize["InvoiceCurrencyCode"] = true;
                this.invoiceCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of the Invoice Currency Code
        /// </summary>
        [JsonProperty("InvoiceCurrencySymbol")]
        public string InvoiceCurrencySymbol
        {
            get
            {
                return this.invoiceCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["InvoiceCurrencySymbol"] = true;
                this.invoiceCurrencySymbol = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FeeItemSummaryAllOf0 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeTypeGroup()
        {
            this.shouldSerialize["FeeTypeGroup"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeTypeId()
        {
            this.shouldSerialize["FeeTypeId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductId()
        {
            this.shouldSerialize["ProductId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductCode()
        {
            this.shouldSerialize["ProductCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductName()
        {
            this.shouldSerialize["ProductName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductGroupId()
        {
            this.shouldSerialize["ProductGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductGroupName()
        {
            this.shouldSerialize["ProductGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalQuantity()
        {
            this.shouldSerialize["TotalQuantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalInvoiceNetAmount()
        {
            this.shouldSerialize["TotalInvoiceNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalInvoiceGrossAmount()
        {
            this.shouldSerialize["TotalInvoiceGrossAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalInvoiceVATAmount()
        {
            this.shouldSerialize["TotalInvoiceVATAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceCurrencyCode()
        {
            this.shouldSerialize["InvoiceCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceCurrencySymbol()
        {
            this.shouldSerialize["InvoiceCurrencySymbol"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeTypeGroup()
        {
            return this.shouldSerialize["FeeTypeGroup"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeTypeId()
        {
            return this.shouldSerialize["FeeTypeId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductId()
        {
            return this.shouldSerialize["ProductId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductCode()
        {
            return this.shouldSerialize["ProductCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductName()
        {
            return this.shouldSerialize["ProductName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroupId()
        {
            return this.shouldSerialize["ProductGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroupName()
        {
            return this.shouldSerialize["ProductGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalQuantity()
        {
            return this.shouldSerialize["TotalQuantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalInvoiceNetAmount()
        {
            return this.shouldSerialize["TotalInvoiceNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalInvoiceGrossAmount()
        {
            return this.shouldSerialize["TotalInvoiceGrossAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalInvoiceVATAmount()
        {
            return this.shouldSerialize["TotalInvoiceVATAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceCurrencyCode()
        {
            return this.shouldSerialize["InvoiceCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceCurrencySymbol()
        {
            return this.shouldSerialize["InvoiceCurrencySymbol"];
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
            return obj is FeeItemSummaryAllOf0 other &&                ((this.FeeTypeGroup == null && other.FeeTypeGroup == null) || (this.FeeTypeGroup?.Equals(other.FeeTypeGroup) == true)) &&
                ((this.FeeTypeId == null && other.FeeTypeId == null) || (this.FeeTypeId?.Equals(other.FeeTypeId) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductGroupId == null && other.ProductGroupId == null) || (this.ProductGroupId?.Equals(other.ProductGroupId) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true)) &&
                ((this.TotalQuantity == null && other.TotalQuantity == null) || (this.TotalQuantity?.Equals(other.TotalQuantity) == true)) &&
                ((this.TotalInvoiceNetAmount == null && other.TotalInvoiceNetAmount == null) || (this.TotalInvoiceNetAmount?.Equals(other.TotalInvoiceNetAmount) == true)) &&
                ((this.TotalInvoiceGrossAmount == null && other.TotalInvoiceGrossAmount == null) || (this.TotalInvoiceGrossAmount?.Equals(other.TotalInvoiceGrossAmount) == true)) &&
                ((this.TotalInvoiceVATAmount == null && other.TotalInvoiceVATAmount == null) || (this.TotalInvoiceVATAmount?.Equals(other.TotalInvoiceVATAmount) == true)) &&
                ((this.InvoiceCurrencyCode == null && other.InvoiceCurrencyCode == null) || (this.InvoiceCurrencyCode?.Equals(other.InvoiceCurrencyCode) == true)) &&
                ((this.InvoiceCurrencySymbol == null && other.InvoiceCurrencySymbol == null) || (this.InvoiceCurrencySymbol?.Equals(other.InvoiceCurrencySymbol) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FeeTypeGroup = {(this.FeeTypeGroup == null ? "null" : this.FeeTypeGroup)}");
            toStringOutput.Add($"this.FeeTypeId = {(this.FeeTypeId == null ? "null" : this.FeeTypeId)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductGroupId = {(this.ProductGroupId == null ? "null" : this.ProductGroupId.ToString())}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
            toStringOutput.Add($"this.TotalQuantity = {(this.TotalQuantity == null ? "null" : this.TotalQuantity.ToString())}");
            toStringOutput.Add($"this.TotalInvoiceNetAmount = {(this.TotalInvoiceNetAmount == null ? "null" : this.TotalInvoiceNetAmount.ToString())}");
            toStringOutput.Add($"this.TotalInvoiceGrossAmount = {(this.TotalInvoiceGrossAmount == null ? "null" : this.TotalInvoiceGrossAmount.ToString())}");
            toStringOutput.Add($"this.TotalInvoiceVATAmount = {(this.TotalInvoiceVATAmount == null ? "null" : this.TotalInvoiceVATAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceCurrencyCode = {(this.InvoiceCurrencyCode == null ? "null" : this.InvoiceCurrencyCode)}");
            toStringOutput.Add($"this.InvoiceCurrencySymbol = {(this.InvoiceCurrencySymbol == null ? "null" : this.InvoiceCurrencySymbol)}");
        }
    }
}