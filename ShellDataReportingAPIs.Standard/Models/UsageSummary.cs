// <copyright file="UsageSummary.cs" company="APIMatic">
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
    /// UsageSummary.
    /// </summary>
    public class UsageSummary
    {
        private string date;
        private int? productId;
        private string productCode;
        private string productName;
        private bool? isFuelProduct;
        private int? siteGroupId;
        private string siteGroupName;
        private double? totalVolume;
        private double? totalGross;
        private double? totalNet;
        private string currencyCode;
        private string currencySymbol;
        private int? productGroupID;
        private string productGroupName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Date", false },
            { "ProductId", false },
            { "ProductCode", false },
            { "ProductName", false },
            { "IsFuelProduct", false },
            { "SiteGroupId", false },
            { "SiteGroupName", false },
            { "TotalVolume", false },
            { "TotalGross", false },
            { "TotalNet", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "ProductGroupID", false },
            { "ProductGroupName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummary"/> class.
        /// </summary>
        public UsageSummary()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSummary"/> class.
        /// </summary>
        /// <param name="date">Date.</param>
        /// <param name="productId">ProductId.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="isFuelProduct">IsFuelProduct.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="siteGroupName">SiteGroupName.</param>
        /// <param name="totalVolume">TotalVolume.</param>
        /// <param name="totalGross">TotalGross.</param>
        /// <param name="totalNet">TotalNet.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="productGroupID">ProductGroupID.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        public UsageSummary(
            string date = null,
            int? productId = null,
            string productCode = null,
            string productName = null,
            bool? isFuelProduct = null,
            int? siteGroupId = null,
            string siteGroupName = null,
            double? totalVolume = null,
            double? totalGross = null,
            double? totalNet = null,
            string currencyCode = null,
            string currencySymbol = null,
            int? productGroupID = null,
            string productGroupName = null)
        {
            if (date != null)
            {
                this.Date = date;
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

            if (isFuelProduct != null)
            {
                this.IsFuelProduct = isFuelProduct;
            }

            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (siteGroupName != null)
            {
                this.SiteGroupName = siteGroupName;
            }

            if (totalVolume != null)
            {
                this.TotalVolume = totalVolume;
            }

            if (totalGross != null)
            {
                this.TotalGross = totalGross;
            }

            if (totalNet != null)
            {
                this.TotalNet = totalNet;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (productGroupID != null)
            {
                this.ProductGroupID = productGroupID;
            }

            if (productGroupName != null)
            {
                this.ProductGroupName = productGroupName;
            }

        }

        /// <summary>
        /// Transaction date.
        /// The records will be sorted by this field in ascending order.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("Date")]
        public string Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.shouldSerialize["Date"] = true;
                this.date = value;
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
        /// Client Product code
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
        /// Product name in English
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
        /// Whether the product is fuel or non-fuel
        /// </summary>
        [JsonProperty("IsFuelProduct")]
        public bool? IsFuelProduct
        {
            get
            {
                return this.isFuelProduct;
            }

            set
            {
                this.shouldSerialize["IsFuelProduct"] = true;
                this.isFuelProduct = value;
            }
        }

        /// <summary>
        /// Site Group Id
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
        /// Total Volume
        /// </summary>
        [JsonProperty("TotalVolume")]
        public double? TotalVolume
        {
            get
            {
                return this.totalVolume;
            }

            set
            {
                this.shouldSerialize["TotalVolume"] = true;
                this.totalVolume = value;
            }
        }

        /// <summary>
        /// Total Gross in Customer Currency
        /// </summary>
        [JsonProperty("TotalGross")]
        public double? TotalGross
        {
            get
            {
                return this.totalGross;
            }

            set
            {
                this.shouldSerialize["TotalGross"] = true;
                this.totalGross = value;
            }
        }

        /// <summary>
        /// Total Net in Customer Currency
        /// </summary>
        [JsonProperty("TotalNet")]
        public double? TotalNet
        {
            get
            {
                return this.totalNet;
            }

            set
            {
                this.shouldSerialize["TotalNet"] = true;
                this.totalNet = value;
            }
        }

        /// <summary>
        /// Customer Currency Code
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
        /// Customer Currency Symbol
        /// </summary>
        [JsonProperty("CurrencySymbol")]
        public string CurrencySymbol
        {
            get
            {
                return this.currencySymbol;
            }

            set
            {
                this.shouldSerialize["CurrencySymbol"] = true;
                this.currencySymbol = value;
            }
        }

        /// <summary>
        /// Product group ID
        /// </summary>
        [JsonProperty("ProductGroupID")]
        public int? ProductGroupID
        {
            get
            {
                return this.productGroupID;
            }

            set
            {
                this.shouldSerialize["ProductGroupID"] = true;
                this.productGroupID = value;
            }
        }

        /// <summary>
        /// Product group Name
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UsageSummary : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDate()
        {
            this.shouldSerialize["Date"] = false;
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
        public void UnsetIsFuelProduct()
        {
            this.shouldSerialize["IsFuelProduct"] = false;
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
        public void UnsetTotalVolume()
        {
            this.shouldSerialize["TotalVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalGross()
        {
            this.shouldSerialize["TotalGross"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalNet()
        {
            this.shouldSerialize["TotalNet"] = false;
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
        public void UnsetCurrencySymbol()
        {
            this.shouldSerialize["CurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductGroupID()
        {
            this.shouldSerialize["ProductGroupID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductGroupName()
        {
            this.shouldSerialize["ProductGroupName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDate()
        {
            return this.shouldSerialize["Date"];
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
        public bool ShouldSerializeIsFuelProduct()
        {
            return this.shouldSerialize["IsFuelProduct"];
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
        public bool ShouldSerializeTotalVolume()
        {
            return this.shouldSerialize["TotalVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalGross()
        {
            return this.shouldSerialize["TotalGross"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalNet()
        {
            return this.shouldSerialize["TotalNet"];
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
        public bool ShouldSerializeCurrencySymbol()
        {
            return this.shouldSerialize["CurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroupID()
        {
            return this.shouldSerialize["ProductGroupID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroupName()
        {
            return this.shouldSerialize["ProductGroupName"];
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
            return obj is UsageSummary other &&                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.IsFuelProduct == null && other.IsFuelProduct == null) || (this.IsFuelProduct?.Equals(other.IsFuelProduct) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.SiteGroupName == null && other.SiteGroupName == null) || (this.SiteGroupName?.Equals(other.SiteGroupName) == true)) &&
                ((this.TotalVolume == null && other.TotalVolume == null) || (this.TotalVolume?.Equals(other.TotalVolume) == true)) &&
                ((this.TotalGross == null && other.TotalGross == null) || (this.TotalGross?.Equals(other.TotalGross) == true)) &&
                ((this.TotalNet == null && other.TotalNet == null) || (this.TotalNet?.Equals(other.TotalNet) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.ProductGroupID == null && other.ProductGroupID == null) || (this.ProductGroupID?.Equals(other.ProductGroupID) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.IsFuelProduct = {(this.IsFuelProduct == null ? "null" : this.IsFuelProduct.ToString())}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.SiteGroupName = {(this.SiteGroupName == null ? "null" : this.SiteGroupName)}");
            toStringOutput.Add($"this.TotalVolume = {(this.TotalVolume == null ? "null" : this.TotalVolume.ToString())}");
            toStringOutput.Add($"this.TotalGross = {(this.TotalGross == null ? "null" : this.TotalGross.ToString())}");
            toStringOutput.Add($"this.TotalNet = {(this.TotalNet == null ? "null" : this.TotalNet.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.ProductGroupID = {(this.ProductGroupID == null ? "null" : this.ProductGroupID.ToString())}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
        }
    }
}