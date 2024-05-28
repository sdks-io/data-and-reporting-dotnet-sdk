// <copyright file="PricedTransSummaryResponseTransactionsSummaryItems.cs" company="APIMatic">
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
    /// PricedTransSummaryResponseTransactionsSummaryItems.
    /// </summary>
    public class PricedTransSummaryResponseTransactionsSummaryItems
    {
        private int? productId;
        private string productCode;
        private string productName;
        private int? productGroupId;
        private string productGroupName;
        private int? siteGroupId;
        private string siteGroupName;
        private int? totalFuelQuantity;
        private int? totalNetAmount;
        private int? totalGrossAmount;
        private string invoiceCurrencyCode;
        private string invoiceCurrencySymbol;
        private double? customerRetailValueTotalNet;
        private double? customerRetailValueTotalGross;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ProductId", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "ProductGroupId", false },
            { "ProductGroupName", false },
            { "SiteGroupId", false },
            { "SiteGroupName", false },
            { "TotalFuelQuantity", false },
            { "TotalNetAmount", false },
            { "TotalGrossAmount", false },
            { "InvoiceCurrencyCode", false },
            { "InvoiceCurrencySymbol", false },
            { "CustomerRetailValueTotalNet", false },
            { "CustomerRetailValueTotalGross", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransSummaryResponseTransactionsSummaryItems"/> class.
        /// </summary>
        public PricedTransSummaryResponseTransactionsSummaryItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransSummaryResponseTransactionsSummaryItems"/> class.
        /// </summary>
        /// <param name="productId">ProductId.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="productGroupId">ProductGroupId.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="siteGroupName">SiteGroupName.</param>
        /// <param name="totalFuelQuantity">TotalFuelQuantity.</param>
        /// <param name="totalNetAmount">TotalNetAmount.</param>
        /// <param name="totalGrossAmount">TotalGrossAmount.</param>
        /// <param name="invoiceCurrencyCode">InvoiceCurrencyCode.</param>
        /// <param name="invoiceCurrencySymbol">InvoiceCurrencySymbol.</param>
        /// <param name="customerRetailValueTotalNet">CustomerRetailValueTotalNet.</param>
        /// <param name="customerRetailValueTotalGross">CustomerRetailValueTotalGross.</param>
        public PricedTransSummaryResponseTransactionsSummaryItems(
            int? productId = null,
            string productCode = null,
            string productName = null,
            int? productGroupId = null,
            string productGroupName = null,
            int? siteGroupId = null,
            string siteGroupName = null,
            int? totalFuelQuantity = null,
            int? totalNetAmount = null,
            int? totalGrossAmount = null,
            string invoiceCurrencyCode = null,
            string invoiceCurrencySymbol = null,
            double? customerRetailValueTotalNet = null,
            double? customerRetailValueTotalGross = null)
        {
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

            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (siteGroupName != null)
            {
                this.SiteGroupName = siteGroupName;
            }

            if (totalFuelQuantity != null)
            {
                this.TotalFuelQuantity = totalFuelQuantity;
            }

            if (totalNetAmount != null)
            {
                this.TotalNetAmount = totalNetAmount;
            }

            if (totalGrossAmount != null)
            {
                this.TotalGrossAmount = totalGrossAmount;
            }

            if (invoiceCurrencyCode != null)
            {
                this.InvoiceCurrencyCode = invoiceCurrencyCode;
            }

            if (invoiceCurrencySymbol != null)
            {
                this.InvoiceCurrencySymbol = invoiceCurrencySymbol;
            }

            if (customerRetailValueTotalNet != null)
            {
                this.CustomerRetailValueTotalNet = customerRetailValueTotalNet;
            }

            if (customerRetailValueTotalGross != null)
            {
                this.CustomerRetailValueTotalGross = customerRetailValueTotalGross;
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
        /// Examples:
        /// 10	TMF Charges
        /// 11	Tunnel/Bridges
        /// 12	Motorway toll
        /// 13	Ferries
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
        /// Examples:
        /// Unleaded - High octane
        /// Unleaded - Medium octane
        /// Unleaded - Low octane
        /// Unleaded Environmental
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
        /// Example:
        /// 1	Parent Product Group
        /// 2	All Fuels
        /// 3	Motor gasoline
        /// 4	2 stroke
        /// 5	Autogas
        /// 6	CNG
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
        /// Example:
        /// 1	Parent Product Group
        /// 2	All Fuels
        /// 3	Motor gasoline
        /// 4	2 stroke
        /// 5	Autogas
        /// 6	CNG
        /// 7	Automotive Gas Oil
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
        /// Site Group Id
        /// Example: 202
        /// </summary>
        [JsonProperty("SiteGroupId")]
        public int? SiteGroupId
        {
            get
            {
                return this.siteGroupId;
            }

            set
            {
                this.shouldSerialize["SiteGroupId"] = true;
                this.siteGroupId = value;
            }
        }

        /// <summary>
        /// Site Group Name
        /// Example: CZ 9100 ECONOMY NETWORK
        /// </summary>
        [JsonProperty("SiteGroupName")]
        public string SiteGroupName
        {
            get
            {
                return this.siteGroupName;
            }

            set
            {
                this.shouldSerialize["SiteGroupName"] = true;
                this.siteGroupName = value;
            }
        }

        /// <summary>
        /// Total Fuel Quantity
        /// </summary>
        [JsonProperty("TotalFuelQuantity")]
        public int? TotalFuelQuantity
        {
            get
            {
                return this.totalFuelQuantity;
            }

            set
            {
                this.shouldSerialize["TotalFuelQuantity"] = true;
                this.totalFuelQuantity = value;
            }
        }

        /// <summary>
        /// Total Net amount in invoice currency
        /// </summary>
        [JsonProperty("TotalNetAmount")]
        public int? TotalNetAmount
        {
            get
            {
                return this.totalNetAmount;
            }

            set
            {
                this.shouldSerialize["TotalNetAmount"] = true;
                this.totalNetAmount = value;
            }
        }

        /// <summary>
        /// Total Gross amount in invoice currency
        /// </summary>
        [JsonProperty("TotalGrossAmount")]
        public int? TotalGrossAmount
        {
            get
            {
                return this.totalGrossAmount;
            }

            set
            {
                this.shouldSerialize["TotalGrossAmount"] = true;
                this.totalGrossAmount = value;
            }
        }

        /// <summary>
        /// ISO currency code
        /// Example: GBP
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
        /// Example: £, $
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

        /// <summary>
        /// Sum of the retail net price
        /// </summary>
        [JsonProperty("CustomerRetailValueTotalNet")]
        public double? CustomerRetailValueTotalNet
        {
            get
            {
                return this.customerRetailValueTotalNet;
            }

            set
            {
                this.shouldSerialize["CustomerRetailValueTotalNet"] = true;
                this.customerRetailValueTotalNet = value;
            }
        }

        /// <summary>
        /// Sum of the retail gross price
        /// </summary>
        [JsonProperty("CustomerRetailValueTotalGross")]
        public double? CustomerRetailValueTotalGross
        {
            get
            {
                return this.customerRetailValueTotalGross;
            }

            set
            {
                this.shouldSerialize["CustomerRetailValueTotalGross"] = true;
                this.customerRetailValueTotalGross = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricedTransSummaryResponseTransactionsSummaryItems : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetSiteGroupId()
        {
            this.shouldSerialize["SiteGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteGroupName()
        {
            this.shouldSerialize["SiteGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalFuelQuantity()
        {
            this.shouldSerialize["TotalFuelQuantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalNetAmount()
        {
            this.shouldSerialize["TotalNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalGrossAmount()
        {
            this.shouldSerialize["TotalGrossAmount"] = false;
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerRetailValueTotalNet()
        {
            this.shouldSerialize["CustomerRetailValueTotalNet"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerRetailValueTotalGross()
        {
            this.shouldSerialize["CustomerRetailValueTotalGross"] = false;
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
        public bool ShouldSerializeSiteGroupId()
        {
            return this.shouldSerialize["SiteGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteGroupName()
        {
            return this.shouldSerialize["SiteGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalFuelQuantity()
        {
            return this.shouldSerialize["TotalFuelQuantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalNetAmount()
        {
            return this.shouldSerialize["TotalNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalGrossAmount()
        {
            return this.shouldSerialize["TotalGrossAmount"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerRetailValueTotalNet()
        {
            return this.shouldSerialize["CustomerRetailValueTotalNet"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerRetailValueTotalGross()
        {
            return this.shouldSerialize["CustomerRetailValueTotalGross"];
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
            return obj is PricedTransSummaryResponseTransactionsSummaryItems other &&                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.ProductGroupId == null && other.ProductGroupId == null) || (this.ProductGroupId?.Equals(other.ProductGroupId) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.SiteGroupName == null && other.SiteGroupName == null) || (this.SiteGroupName?.Equals(other.SiteGroupName) == true)) &&
                ((this.TotalFuelQuantity == null && other.TotalFuelQuantity == null) || (this.TotalFuelQuantity?.Equals(other.TotalFuelQuantity) == true)) &&
                ((this.TotalNetAmount == null && other.TotalNetAmount == null) || (this.TotalNetAmount?.Equals(other.TotalNetAmount) == true)) &&
                ((this.TotalGrossAmount == null && other.TotalGrossAmount == null) || (this.TotalGrossAmount?.Equals(other.TotalGrossAmount) == true)) &&
                ((this.InvoiceCurrencyCode == null && other.InvoiceCurrencyCode == null) || (this.InvoiceCurrencyCode?.Equals(other.InvoiceCurrencyCode) == true)) &&
                ((this.InvoiceCurrencySymbol == null && other.InvoiceCurrencySymbol == null) || (this.InvoiceCurrencySymbol?.Equals(other.InvoiceCurrencySymbol) == true)) &&
                ((this.CustomerRetailValueTotalNet == null && other.CustomerRetailValueTotalNet == null) || (this.CustomerRetailValueTotalNet?.Equals(other.CustomerRetailValueTotalNet) == true)) &&
                ((this.CustomerRetailValueTotalGross == null && other.CustomerRetailValueTotalGross == null) || (this.CustomerRetailValueTotalGross?.Equals(other.CustomerRetailValueTotalGross) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.ProductGroupId = {(this.ProductGroupId == null ? "null" : this.ProductGroupId.ToString())}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.SiteGroupName = {(this.SiteGroupName == null ? "null" : this.SiteGroupName)}");
            toStringOutput.Add($"this.TotalFuelQuantity = {(this.TotalFuelQuantity == null ? "null" : this.TotalFuelQuantity.ToString())}");
            toStringOutput.Add($"this.TotalNetAmount = {(this.TotalNetAmount == null ? "null" : this.TotalNetAmount.ToString())}");
            toStringOutput.Add($"this.TotalGrossAmount = {(this.TotalGrossAmount == null ? "null" : this.TotalGrossAmount.ToString())}");
            toStringOutput.Add($"this.InvoiceCurrencyCode = {(this.InvoiceCurrencyCode == null ? "null" : this.InvoiceCurrencyCode)}");
            toStringOutput.Add($"this.InvoiceCurrencySymbol = {(this.InvoiceCurrencySymbol == null ? "null" : this.InvoiceCurrencySymbol)}");
            toStringOutput.Add($"this.CustomerRetailValueTotalNet = {(this.CustomerRetailValueTotalNet == null ? "null" : this.CustomerRetailValueTotalNet.ToString())}");
            toStringOutput.Add($"this.CustomerRetailValueTotalGross = {(this.CustomerRetailValueTotalGross == null ? "null" : this.CustomerRetailValueTotalGross.ToString())}");
        }
    }
}