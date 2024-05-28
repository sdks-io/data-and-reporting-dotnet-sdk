// <copyright file="PriceList.cs" company="APIMatic">
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
    /// PriceList.
    /// </summary>
    public class PriceList
    {
        private string date;
        private string day;
        private string type;
        private int? priceListId;
        private string priceListDescription;
        private int? priceRuleId;
        private string priceRuleName;
        private int? delCoId;
        private string countryCode;
        private string country;
        private int? productGroupId;
        private string productGroupName;
        private string productCode;
        private int? productId;
        private string productName;
        private double? pricePerUnit;
        private string currencyCode;
        private string currencySymbol;
        private string priceType;
        private int? siteGroupId;
        private string siteGroupName;
        private int? siteCode;
        private int? siteId;
        private string siteName;
        private int? fuelNetworkId;
        private string networkName;
        private int? priceRuleDelcoId;
        private string priceRuleDelcoName;
        private string priceRuleCountry;
        private string priceRuleCountryCode;
        private int? priceRuleBasisId;
        private double? discountValue;
        private double? pricePerUnitAfterDiscount;
        private double? vATPercentage;
        private int? priceRuleCategoryId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Date", false },
            { "Day", false },
            { "Type", false },
            { "PriceListId", false },
            { "PriceListDescription", false },
            { "PriceRuleId", false },
            { "PriceRuleName", false },
            { "DelCoId", false },
            { "CountryCode", false },
            { "Country", false },
            { "ProductGroupId", false },
            { "ProductGroupName", false },
            { "ProductCode", false },
            { "ProductId", false },
            { "ProductName", false },
            { "PricePerUnit", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "PriceType", false },
            { "SiteGroupId", false },
            { "SiteGroupName", false },
            { "SiteCode", false },
            { "SiteId", false },
            { "SiteName", false },
            { "FuelNetworkId", false },
            { "NetworkName", false },
            { "PriceRuleDelcoId", false },
            { "PriceRuleDelcoName", false },
            { "PriceRuleCountry", false },
            { "PriceRuleCountryCode", false },
            { "PriceRuleBasisId", false },
            { "DiscountValue", false },
            { "PricePerUnitAfterDiscount", false },
            { "VATPercentage", false },
            { "PriceRuleCategoryId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceList"/> class.
        /// </summary>
        public PriceList()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceList"/> class.
        /// </summary>
        /// <param name="date">Date.</param>
        /// <param name="day">Day.</param>
        /// <param name="type">Type.</param>
        /// <param name="priceListId">PriceListId.</param>
        /// <param name="priceListDescription">PriceListDescription.</param>
        /// <param name="priceRuleId">PriceRuleId.</param>
        /// <param name="priceRuleName">PriceRuleName.</param>
        /// <param name="delCoId">DelCoId.</param>
        /// <param name="countryCode">CountryCode.</param>
        /// <param name="country">Country.</param>
        /// <param name="productGroupId">ProductGroupId.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="productId">ProductId.</param>
        /// <param name="productName">ProductName.</param>
        /// <param name="pricePerUnit">PricePerUnit.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="priceType">PriceType.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="siteGroupName">SiteGroupName.</param>
        /// <param name="siteCode">SiteCode.</param>
        /// <param name="siteId">SiteId.</param>
        /// <param name="siteName">SiteName.</param>
        /// <param name="fuelNetworkId">FuelNetworkId.</param>
        /// <param name="networkName">NetworkName.</param>
        /// <param name="priceRuleDelcoId">PriceRuleDelcoId.</param>
        /// <param name="priceRuleDelcoName">PriceRuleDelcoName.</param>
        /// <param name="priceRuleCountry">PriceRuleCountry.</param>
        /// <param name="priceRuleCountryCode">PriceRuleCountryCode.</param>
        /// <param name="priceRuleBasisId">PriceRuleBasisId.</param>
        /// <param name="discountValue">DiscountValue.</param>
        /// <param name="pricePerUnitAfterDiscount">PricePerUnitAfterDiscount.</param>
        /// <param name="vATPercentage">VATPercentage.</param>
        /// <param name="priceRuleCategoryId">PriceRuleCategoryId.</param>
        /// <param name="tiers">Tiers.</param>
        public PriceList(
            string date = null,
            string day = null,
            string type = null,
            int? priceListId = null,
            string priceListDescription = null,
            int? priceRuleId = null,
            string priceRuleName = null,
            int? delCoId = null,
            string countryCode = null,
            string country = null,
            int? productGroupId = null,
            string productGroupName = null,
            string productCode = null,
            int? productId = null,
            string productName = null,
            double? pricePerUnit = null,
            string currencyCode = null,
            string currencySymbol = null,
            string priceType = null,
            int? siteGroupId = null,
            string siteGroupName = null,
            int? siteCode = null,
            int? siteId = null,
            string siteName = null,
            int? fuelNetworkId = null,
            string networkName = null,
            int? priceRuleDelcoId = null,
            string priceRuleDelcoName = null,
            string priceRuleCountry = null,
            string priceRuleCountryCode = null,
            int? priceRuleBasisId = null,
            double? discountValue = null,
            double? pricePerUnitAfterDiscount = null,
            double? vATPercentage = null,
            int? priceRuleCategoryId = null,
            List<Models.Tier> tiers = null)
        {
            if (date != null)
            {
                this.Date = date;
            }

            if (day != null)
            {
                this.Day = day;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (priceListId != null)
            {
                this.PriceListId = priceListId;
            }

            if (priceListDescription != null)
            {
                this.PriceListDescription = priceListDescription;
            }

            if (priceRuleId != null)
            {
                this.PriceRuleId = priceRuleId;
            }

            if (priceRuleName != null)
            {
                this.PriceRuleName = priceRuleName;
            }

            if (delCoId != null)
            {
                this.DelCoId = delCoId;
            }

            if (countryCode != null)
            {
                this.CountryCode = countryCode;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (productGroupId != null)
            {
                this.ProductGroupId = productGroupId;
            }

            if (productGroupName != null)
            {
                this.ProductGroupName = productGroupName;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (productId != null)
            {
                this.ProductId = productId;
            }

            if (productName != null)
            {
                this.ProductName = productName;
            }

            if (pricePerUnit != null)
            {
                this.PricePerUnit = pricePerUnit;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (priceType != null)
            {
                this.PriceType = priceType;
            }

            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (siteGroupName != null)
            {
                this.SiteGroupName = siteGroupName;
            }

            if (siteCode != null)
            {
                this.SiteCode = siteCode;
            }

            if (siteId != null)
            {
                this.SiteId = siteId;
            }

            if (siteName != null)
            {
                this.SiteName = siteName;
            }

            if (fuelNetworkId != null)
            {
                this.FuelNetworkId = fuelNetworkId;
            }

            if (networkName != null)
            {
                this.NetworkName = networkName;
            }

            if (priceRuleDelcoId != null)
            {
                this.PriceRuleDelcoId = priceRuleDelcoId;
            }

            if (priceRuleDelcoName != null)
            {
                this.PriceRuleDelcoName = priceRuleDelcoName;
            }

            if (priceRuleCountry != null)
            {
                this.PriceRuleCountry = priceRuleCountry;
            }

            if (priceRuleCountryCode != null)
            {
                this.PriceRuleCountryCode = priceRuleCountryCode;
            }

            if (priceRuleBasisId != null)
            {
                this.PriceRuleBasisId = priceRuleBasisId;
            }

            if (discountValue != null)
            {
                this.DiscountValue = discountValue;
            }

            if (pricePerUnitAfterDiscount != null)
            {
                this.PricePerUnitAfterDiscount = pricePerUnitAfterDiscount;
            }

            if (vATPercentage != null)
            {
                this.VATPercentage = vATPercentage;
            }

            if (priceRuleCategoryId != null)
            {
                this.PriceRuleCategoryId = priceRuleCategoryId;
            }

            this.Tiers = tiers;
        }

        /// <summary>
        /// Date on which the price is applicable.
        /// Format: yyyyMMdd
        /// E.g.: 20180131
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
        /// Day on which the price is applicable.
        /// E.g.: Sunday, Monday etc.
        /// </summary>
        [JsonProperty("Day")]
        public string Day
        {
            get
            {
                return this.day;
            }

            set
            {
                this.shouldSerialize["Day"] = true;
                this.day = value;
            }
        }

        /// <summary>
        /// Price list type.
        /// E.g., List, Shell Standard International List
        /// </summary>
        [JsonProperty("Type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["Type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// Price list ID
        /// </summary>
        [JsonProperty("PriceListId")]
        public int? PriceListId
        {
            get
            {
                return this.priceListId;
            }

            set
            {
                this.shouldSerialize["PriceListId"] = true;
                this.priceListId = value;
            }
        }

        /// <summary>
        /// Price list description
        /// E.g., UK Fuels CRT Reseller List Price
        /// </summary>
        [JsonProperty("PriceListDescription")]
        public string PriceListDescription
        {
            get
            {
                return this.priceListDescription;
            }

            set
            {
                this.shouldSerialize["PriceListDescription"] = true;
                this.priceListDescription = value;
            }
        }

        /// <summary>
        /// Price Rule Id
        /// </summary>
        [JsonProperty("PriceRuleId")]
        public int? PriceRuleId
        {
            get
            {
                return this.priceRuleId;
            }

            set
            {
                this.shouldSerialize["PriceRuleId"] = true;
                this.priceRuleId = value;
            }
        }

        /// <summary>
        /// Price Rule Name
        /// </summary>
        [JsonProperty("PriceRuleName")]
        public string PriceRuleName
        {
            get
            {
                return this.priceRuleName;
            }

            set
            {
                this.shouldSerialize["PriceRuleName"] = true;
                this.priceRuleName = value;
            }
        }

        /// <summary>
        /// DelCo Id
        /// </summary>
        [JsonProperty("DelCoId")]
        public int? DelCoId
        {
            get
            {
                return this.delCoId;
            }

            set
            {
                this.shouldSerialize["DelCoId"] = true;
                this.delCoId = value;
            }
        }

        /// <summary>
        /// Country ISO Code
        /// E.g., UK, NL, etc.,
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode
        {
            get
            {
                return this.countryCode;
            }

            set
            {
                this.shouldSerialize["CountryCode"] = true;
                this.countryCode = value;
            }
        }

        /// <summary>
        /// Country
        /// E.g., United Kingdom, Netherlands etc
        /// </summary>
        [JsonProperty("Country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["Country"] = true;
                this.country = value;
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
        /// Product Group name
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
        /// Client Product Code
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
        /// Price per unit
        /// </summary>
        [JsonProperty("PricePerUnit")]
        public double? PricePerUnit
        {
            get
            {
                return this.pricePerUnit;
            }

            set
            {
                this.shouldSerialize["PricePerUnit"] = true;
                this.pricePerUnit = value;
            }
        }

        /// <summary>
        /// Currency Code.
        /// Format : 3 digit ISO code
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
        /// Currency Symbol
        /// Example: £
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
        /// Price Type
        /// Possible Values are:
        /// •	Country– Price rule defined at country whereas Price Rule DelcoId same as ColcoId.
        /// •	TPNDelcoPrice – Price rule defined in the TPN whereas Price Rule DelcoId is different from ColcoId.
        /// •	NetworkPrice – Price rule defined at Fuel Network level.
        /// •	Other – Price rule defined at either Site or SiteGroup level.
        /// </summary>
        [JsonProperty("PriceType")]
        public string PriceType
        {
            get
            {
                return this.priceType;
            }

            set
            {
                this.shouldSerialize["PriceType"] = true;
                this.priceType = value;
            }
        }

        /// <summary>
        /// Site-Group ID
        /// E.g.: 100007
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
        /// Site-Group name
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
        /// Site Code
        /// </summary>
        [JsonProperty("SiteCode")]
        public int? SiteCode
        {
            get
            {
                return this.siteCode;
            }

            set
            {
                this.shouldSerialize["SiteCode"] = true;
                this.siteCode = value;
            }
        }

        /// <summary>
        /// Site ID
        /// </summary>
        [JsonProperty("SiteId")]
        public int? SiteId
        {
            get
            {
                return this.siteId;
            }

            set
            {
                this.shouldSerialize["SiteId"] = true;
                this.siteId = value;
            }
        }

        /// <summary>
        /// Site Name
        /// </summary>
        [JsonProperty("SiteName")]
        public string SiteName
        {
            get
            {
                return this.siteName;
            }

            set
            {
                this.shouldSerialize["SiteName"] = true;
                this.siteName = value;
            }
        }

        /// <summary>
        /// Fuel Network ID
        /// </summary>
        [JsonProperty("FuelNetworkId")]
        public int? FuelNetworkId
        {
            get
            {
                return this.fuelNetworkId;
            }

            set
            {
                this.shouldSerialize["FuelNetworkId"] = true;
                this.fuelNetworkId = value;
            }
        }

        /// <summary>
        /// Network Name
        /// </summary>
        [JsonProperty("NetworkName")]
        public string NetworkName
        {
            get
            {
                return this.networkName;
            }

            set
            {
                this.shouldSerialize["NetworkName"] = true;
                this.networkName = value;
            }
        }

        /// <summary>
        /// PriceRuleDelcoId
        /// </summary>
        [JsonProperty("PriceRuleDelcoId")]
        public int? PriceRuleDelcoId
        {
            get
            {
                return this.priceRuleDelcoId;
            }

            set
            {
                this.shouldSerialize["PriceRuleDelcoId"] = true;
                this.priceRuleDelcoId = value;
            }
        }

        /// <summary>
        /// <![CDATA[
        /// Company Name of the price rule DelCo.
        /// E.g.:
        /// •	Pilipinas Shell Petroleum Corp
        /// •	Shell U.K. Oil Products Limited
        /// •	G & V SERVICE STATIONS NV
        /// ]]>
        /// </summary>
        [JsonProperty("PriceRuleDelcoName")]
        public string PriceRuleDelcoName
        {
            get
            {
                return this.priceRuleDelcoName;
            }

            set
            {
                this.shouldSerialize["PriceRuleDelcoName"] = true;
                this.priceRuleDelcoName = value;
            }
        }

        /// <summary>
        /// PriceRuleCountry
        /// E.g.: United Kingdom
        /// </summary>
        [JsonProperty("PriceRuleCountry")]
        public string PriceRuleCountry
        {
            get
            {
                return this.priceRuleCountry;
            }

            set
            {
                this.shouldSerialize["PriceRuleCountry"] = true;
                this.priceRuleCountry = value;
            }
        }

        /// <summary>
        /// ISO Code of PriceRuleCountry
        /// E.g.: UK, NL, etc.,
        /// </summary>
        [JsonProperty("PriceRuleCountryCode")]
        public string PriceRuleCountryCode
        {
            get
            {
                return this.priceRuleCountryCode;
            }

            set
            {
                this.shouldSerialize["PriceRuleCountryCode"] = true;
                this.priceRuleCountryCode = value;
            }
        }

        /// <summary>
        /// PriceRuleBasisId
        /// </summary>
        [JsonProperty("PriceRuleBasisId")]
        public int? PriceRuleBasisId
        {
            get
            {
                return this.priceRuleBasisId;
            }

            set
            {
                this.shouldSerialize["PriceRuleBasisId"] = true;
                this.priceRuleBasisId = value;
            }
        }

        /// <summary>
        /// Discount value
        /// </summary>
        [JsonProperty("DiscountValue")]
        public double? DiscountValue
        {
            get
            {
                return this.discountValue;
            }

            set
            {
                this.shouldSerialize["DiscountValue"] = true;
                this.discountValue = value;
            }
        }

        /// <summary>
        /// Price per unit after discount
        /// </summary>
        [JsonProperty("PricePerUnitAfterDiscount")]
        public double? PricePerUnitAfterDiscount
        {
            get
            {
                return this.pricePerUnitAfterDiscount;
            }

            set
            {
                this.shouldSerialize["PricePerUnitAfterDiscount"] = true;
                this.pricePerUnitAfterDiscount = value;
            }
        }

        /// <summary>
        /// VAT Percentage
        /// </summary>
        [JsonProperty("VATPercentage")]
        public double? VATPercentage
        {
            get
            {
                return this.vATPercentage;
            }

            set
            {
                this.shouldSerialize["VATPercentage"] = true;
                this.vATPercentage = value;
            }
        }

        /// <summary>
        /// PriceRuleCategoryId
        /// </summary>
        [JsonProperty("PriceRuleCategoryId")]
        public int? PriceRuleCategoryId
        {
            get
            {
                return this.priceRuleCategoryId;
            }

            set
            {
                this.shouldSerialize["PriceRuleCategoryId"] = true;
                this.priceRuleCategoryId = value;
            }
        }

        /// <summary>
        /// Gets or sets Tiers.
        /// </summary>
        [JsonProperty("Tiers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Tier> Tiers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PriceList : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetDay()
        {
            this.shouldSerialize["Day"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["Type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceListId()
        {
            this.shouldSerialize["PriceListId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceListDescription()
        {
            this.shouldSerialize["PriceListDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleId()
        {
            this.shouldSerialize["PriceRuleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleName()
        {
            this.shouldSerialize["PriceRuleName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelCoId()
        {
            this.shouldSerialize["DelCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountryCode()
        {
            this.shouldSerialize["CountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["Country"] = false;
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
        public void UnsetProductCode()
        {
            this.shouldSerialize["ProductCode"] = false;
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
        public void UnsetProductName()
        {
            this.shouldSerialize["ProductName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePerUnit()
        {
            this.shouldSerialize["PricePerUnit"] = false;
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
        public void UnsetPriceType()
        {
            this.shouldSerialize["PriceType"] = false;
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
        public void UnsetSiteCode()
        {
            this.shouldSerialize["SiteCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteId()
        {
            this.shouldSerialize["SiteId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteName()
        {
            this.shouldSerialize["SiteName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelNetworkId()
        {
            this.shouldSerialize["FuelNetworkId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetworkName()
        {
            this.shouldSerialize["NetworkName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleDelcoId()
        {
            this.shouldSerialize["PriceRuleDelcoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleDelcoName()
        {
            this.shouldSerialize["PriceRuleDelcoName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleCountry()
        {
            this.shouldSerialize["PriceRuleCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleCountryCode()
        {
            this.shouldSerialize["PriceRuleCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleBasisId()
        {
            this.shouldSerialize["PriceRuleBasisId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDiscountValue()
        {
            this.shouldSerialize["DiscountValue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePerUnitAfterDiscount()
        {
            this.shouldSerialize["PricePerUnitAfterDiscount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVATPercentage()
        {
            this.shouldSerialize["VATPercentage"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleCategoryId()
        {
            this.shouldSerialize["PriceRuleCategoryId"] = false;
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
        public bool ShouldSerializeDay()
        {
            return this.shouldSerialize["Day"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["Type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceListId()
        {
            return this.shouldSerialize["PriceListId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceListDescription()
        {
            return this.shouldSerialize["PriceListDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleId()
        {
            return this.shouldSerialize["PriceRuleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleName()
        {
            return this.shouldSerialize["PriceRuleName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelCoId()
        {
            return this.shouldSerialize["DelCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountryCode()
        {
            return this.shouldSerialize["CountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["Country"];
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
        public bool ShouldSerializeProductCode()
        {
            return this.shouldSerialize["ProductCode"];
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
        public bool ShouldSerializeProductName()
        {
            return this.shouldSerialize["ProductName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePerUnit()
        {
            return this.shouldSerialize["PricePerUnit"];
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
        public bool ShouldSerializePriceType()
        {
            return this.shouldSerialize["PriceType"];
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
        public bool ShouldSerializeSiteCode()
        {
            return this.shouldSerialize["SiteCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteId()
        {
            return this.shouldSerialize["SiteId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteName()
        {
            return this.shouldSerialize["SiteName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelNetworkId()
        {
            return this.shouldSerialize["FuelNetworkId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetworkName()
        {
            return this.shouldSerialize["NetworkName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleDelcoId()
        {
            return this.shouldSerialize["PriceRuleDelcoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleDelcoName()
        {
            return this.shouldSerialize["PriceRuleDelcoName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleCountry()
        {
            return this.shouldSerialize["PriceRuleCountry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleCountryCode()
        {
            return this.shouldSerialize["PriceRuleCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleBasisId()
        {
            return this.shouldSerialize["PriceRuleBasisId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDiscountValue()
        {
            return this.shouldSerialize["DiscountValue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePerUnitAfterDiscount()
        {
            return this.shouldSerialize["PricePerUnitAfterDiscount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVATPercentage()
        {
            return this.shouldSerialize["VATPercentage"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleCategoryId()
        {
            return this.shouldSerialize["PriceRuleCategoryId"];
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
            return obj is PriceList other &&                ((this.Date == null && other.Date == null) || (this.Date?.Equals(other.Date) == true)) &&
                ((this.Day == null && other.Day == null) || (this.Day?.Equals(other.Day) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.PriceListId == null && other.PriceListId == null) || (this.PriceListId?.Equals(other.PriceListId) == true)) &&
                ((this.PriceListDescription == null && other.PriceListDescription == null) || (this.PriceListDescription?.Equals(other.PriceListDescription) == true)) &&
                ((this.PriceRuleId == null && other.PriceRuleId == null) || (this.PriceRuleId?.Equals(other.PriceRuleId) == true)) &&
                ((this.PriceRuleName == null && other.PriceRuleName == null) || (this.PriceRuleName?.Equals(other.PriceRuleName) == true)) &&
                ((this.DelCoId == null && other.DelCoId == null) || (this.DelCoId?.Equals(other.DelCoId) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.ProductGroupId == null && other.ProductGroupId == null) || (this.ProductGroupId?.Equals(other.ProductGroupId) == true)) &&
                ((this.ProductGroupName == null && other.ProductGroupName == null) || (this.ProductGroupName?.Equals(other.ProductGroupName) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductName == null && other.ProductName == null) || (this.ProductName?.Equals(other.ProductName) == true)) &&
                ((this.PricePerUnit == null && other.PricePerUnit == null) || (this.PricePerUnit?.Equals(other.PricePerUnit) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.PriceType == null && other.PriceType == null) || (this.PriceType?.Equals(other.PriceType) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.SiteGroupName == null && other.SiteGroupName == null) || (this.SiteGroupName?.Equals(other.SiteGroupName) == true)) &&
                ((this.SiteCode == null && other.SiteCode == null) || (this.SiteCode?.Equals(other.SiteCode) == true)) &&
                ((this.SiteId == null && other.SiteId == null) || (this.SiteId?.Equals(other.SiteId) == true)) &&
                ((this.SiteName == null && other.SiteName == null) || (this.SiteName?.Equals(other.SiteName) == true)) &&
                ((this.FuelNetworkId == null && other.FuelNetworkId == null) || (this.FuelNetworkId?.Equals(other.FuelNetworkId) == true)) &&
                ((this.NetworkName == null && other.NetworkName == null) || (this.NetworkName?.Equals(other.NetworkName) == true)) &&
                ((this.PriceRuleDelcoId == null && other.PriceRuleDelcoId == null) || (this.PriceRuleDelcoId?.Equals(other.PriceRuleDelcoId) == true)) &&
                ((this.PriceRuleDelcoName == null && other.PriceRuleDelcoName == null) || (this.PriceRuleDelcoName?.Equals(other.PriceRuleDelcoName) == true)) &&
                ((this.PriceRuleCountry == null && other.PriceRuleCountry == null) || (this.PriceRuleCountry?.Equals(other.PriceRuleCountry) == true)) &&
                ((this.PriceRuleCountryCode == null && other.PriceRuleCountryCode == null) || (this.PriceRuleCountryCode?.Equals(other.PriceRuleCountryCode) == true)) &&
                ((this.PriceRuleBasisId == null && other.PriceRuleBasisId == null) || (this.PriceRuleBasisId?.Equals(other.PriceRuleBasisId) == true)) &&
                ((this.DiscountValue == null && other.DiscountValue == null) || (this.DiscountValue?.Equals(other.DiscountValue) == true)) &&
                ((this.PricePerUnitAfterDiscount == null && other.PricePerUnitAfterDiscount == null) || (this.PricePerUnitAfterDiscount?.Equals(other.PricePerUnitAfterDiscount) == true)) &&
                ((this.VATPercentage == null && other.VATPercentage == null) || (this.VATPercentage?.Equals(other.VATPercentage) == true)) &&
                ((this.PriceRuleCategoryId == null && other.PriceRuleCategoryId == null) || (this.PriceRuleCategoryId?.Equals(other.PriceRuleCategoryId) == true)) &&
                ((this.Tiers == null && other.Tiers == null) || (this.Tiers?.Equals(other.Tiers) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Date = {(this.Date == null ? "null" : this.Date)}");
            toStringOutput.Add($"this.Day = {(this.Day == null ? "null" : this.Day)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.PriceListId = {(this.PriceListId == null ? "null" : this.PriceListId.ToString())}");
            toStringOutput.Add($"this.PriceListDescription = {(this.PriceListDescription == null ? "null" : this.PriceListDescription)}");
            toStringOutput.Add($"this.PriceRuleId = {(this.PriceRuleId == null ? "null" : this.PriceRuleId.ToString())}");
            toStringOutput.Add($"this.PriceRuleName = {(this.PriceRuleName == null ? "null" : this.PriceRuleName)}");
            toStringOutput.Add($"this.DelCoId = {(this.DelCoId == null ? "null" : this.DelCoId.ToString())}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.ProductGroupId = {(this.ProductGroupId == null ? "null" : this.ProductGroupId.ToString())}");
            toStringOutput.Add($"this.ProductGroupName = {(this.ProductGroupName == null ? "null" : this.ProductGroupName)}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductName = {(this.ProductName == null ? "null" : this.ProductName)}");
            toStringOutput.Add($"this.PricePerUnit = {(this.PricePerUnit == null ? "null" : this.PricePerUnit.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.PriceType = {(this.PriceType == null ? "null" : this.PriceType)}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.SiteGroupName = {(this.SiteGroupName == null ? "null" : this.SiteGroupName)}");
            toStringOutput.Add($"this.SiteCode = {(this.SiteCode == null ? "null" : this.SiteCode.ToString())}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.SiteName = {(this.SiteName == null ? "null" : this.SiteName)}");
            toStringOutput.Add($"this.FuelNetworkId = {(this.FuelNetworkId == null ? "null" : this.FuelNetworkId.ToString())}");
            toStringOutput.Add($"this.NetworkName = {(this.NetworkName == null ? "null" : this.NetworkName)}");
            toStringOutput.Add($"this.PriceRuleDelcoId = {(this.PriceRuleDelcoId == null ? "null" : this.PriceRuleDelcoId.ToString())}");
            toStringOutput.Add($"this.PriceRuleDelcoName = {(this.PriceRuleDelcoName == null ? "null" : this.PriceRuleDelcoName)}");
            toStringOutput.Add($"this.PriceRuleCountry = {(this.PriceRuleCountry == null ? "null" : this.PriceRuleCountry)}");
            toStringOutput.Add($"this.PriceRuleCountryCode = {(this.PriceRuleCountryCode == null ? "null" : this.PriceRuleCountryCode)}");
            toStringOutput.Add($"this.PriceRuleBasisId = {(this.PriceRuleBasisId == null ? "null" : this.PriceRuleBasisId.ToString())}");
            toStringOutput.Add($"this.DiscountValue = {(this.DiscountValue == null ? "null" : this.DiscountValue.ToString())}");
            toStringOutput.Add($"this.PricePerUnitAfterDiscount = {(this.PricePerUnitAfterDiscount == null ? "null" : this.PricePerUnitAfterDiscount.ToString())}");
            toStringOutput.Add($"this.VATPercentage = {(this.VATPercentage == null ? "null" : this.VATPercentage.ToString())}");
            toStringOutput.Add($"this.PriceRuleCategoryId = {(this.PriceRuleCategoryId == null ? "null" : this.PriceRuleCategoryId.ToString())}");
            toStringOutput.Add($"this.Tiers = {(this.Tiers == null ? "null" : $"[{string.Join(", ", this.Tiers)} ]")}");
        }
    }
}