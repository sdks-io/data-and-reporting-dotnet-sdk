// <copyright file="Tier.cs" company="APIMatic">
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
    /// Tier.
    /// </summary>
    public class Tier
    {
        private int? tierPriceListId;
        private string priceListDescription;
        private int? tierMin;
        private int? tierMax;
        private string tieredPricingGroupName;
        private string tieredPricingGroupPeriod;
        private double? discountValue;
        private double? pricePerUnit;
        private double? pricePerUnitAfterDiscount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "TierPriceListId", false },
            { "PriceListDescription", false },
            { "TierMin", false },
            { "TierMax", false },
            { "TieredPricingGroupName", false },
            { "TieredPricingGroupPeriod", false },
            { "DiscountValue", false },
            { "PricePerUnit", false },
            { "PricePerUnitAfterDiscount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Tier"/> class.
        /// </summary>
        public Tier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tier"/> class.
        /// </summary>
        /// <param name="tierPriceListId">TierPriceListId.</param>
        /// <param name="priceListDescription">PriceListDescription.</param>
        /// <param name="tierMin">TierMin.</param>
        /// <param name="tierMax">TierMax.</param>
        /// <param name="tieredPricingGroupName">TieredPricingGroupName.</param>
        /// <param name="tieredPricingGroupPeriod">TieredPricingGroupPeriod.</param>
        /// <param name="discountValue">DiscountValue.</param>
        /// <param name="pricePerUnit">PricePerUnit.</param>
        /// <param name="pricePerUnitAfterDiscount">PricePerUnitAfterDiscount.</param>
        public Tier(
            int? tierPriceListId = null,
            string priceListDescription = null,
            int? tierMin = null,
            int? tierMax = null,
            string tieredPricingGroupName = null,
            string tieredPricingGroupPeriod = null,
            double? discountValue = null,
            double? pricePerUnit = null,
            double? pricePerUnitAfterDiscount = null)
        {
            if (tierPriceListId != null)
            {
                this.TierPriceListId = tierPriceListId;
            }

            if (priceListDescription != null)
            {
                this.PriceListDescription = priceListDescription;
            }

            if (tierMin != null)
            {
                this.TierMin = tierMin;
            }

            if (tierMax != null)
            {
                this.TierMax = tierMax;
            }

            if (tieredPricingGroupName != null)
            {
                this.TieredPricingGroupName = tieredPricingGroupName;
            }

            if (tieredPricingGroupPeriod != null)
            {
                this.TieredPricingGroupPeriod = tieredPricingGroupPeriod;
            }

            if (discountValue != null)
            {
                this.DiscountValue = discountValue;
            }

            if (pricePerUnit != null)
            {
                this.PricePerUnit = pricePerUnit;
            }

            if (pricePerUnitAfterDiscount != null)
            {
                this.PricePerUnitAfterDiscount = pricePerUnitAfterDiscount;
            }

        }

        /// <summary>
        /// The price list if reference price is list price.
        /// Only used when the Price Rule category is set to.
        /// ‘Tiered Pricing’.
        /// </summary>
        [JsonProperty("TierPriceListId")]
        public int? TierPriceListId
        {
            get
            {
                return this.tierPriceListId;
            }

            set
            {
                this.shouldSerialize["TierPriceListId"] = true;
                this.tierPriceListId = value;
            }
        }

        /// <summary>
        /// Price list description of the tier.
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
        /// Minimum tier volume
        /// E.g., 500
        /// </summary>
        [JsonProperty("TierMin")]
        public int? TierMin
        {
            get
            {
                return this.tierMin;
            }

            set
            {
                this.shouldSerialize["TierMin"] = true;
                this.tierMin = value;
            }
        }

        /// <summary>
        /// Maximum tier volume
        /// E.g., 1000
        /// </summary>
        [JsonProperty("TierMax")]
        public int? TierMax
        {
            get
            {
                return this.tierMax;
            }

            set
            {
                this.shouldSerialize["TierMax"] = true;
                this.tierMax = value;
            }
        }

        /// <summary>
        /// Pricing group name of tier
        /// </summary>
        [JsonProperty("TieredPricingGroupName")]
        public string TieredPricingGroupName
        {
            get
            {
                return this.tieredPricingGroupName;
            }

            set
            {
                this.shouldSerialize["TieredPricingGroupName"] = true;
                this.tieredPricingGroupName = value;
            }
        }

        /// <summary>
        /// Tiered pricing group period.
        /// Possible Values
        /// 1.	Monthly
        /// 2.	Quarterly
        /// 3.	Semi Annually
        /// 4.	Annual
        /// </summary>
        [JsonProperty("TieredPricingGroupPeriod")]
        public string TieredPricingGroupPeriod
        {
            get
            {
                return this.tieredPricingGroupPeriod;
            }

            set
            {
                this.shouldSerialize["TieredPricingGroupPeriod"] = true;
                this.tieredPricingGroupPeriod = value;
            }
        }

        /// <summary>
        /// Discount value to be applied to the List price or pump price.
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
        /// Note: This field will not contain any value for discounts on retail prices.
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
        /// Price per unit (List Price)
        /// Note: This field will not contain any value for discounts on retail prices.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Tier : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTierPriceListId()
        {
            this.shouldSerialize["TierPriceListId"] = false;
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
        public void UnsetTierMin()
        {
            this.shouldSerialize["TierMin"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTierMax()
        {
            this.shouldSerialize["TierMax"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTieredPricingGroupName()
        {
            this.shouldSerialize["TieredPricingGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTieredPricingGroupPeriod()
        {
            this.shouldSerialize["TieredPricingGroupPeriod"] = false;
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
        public void UnsetPricePerUnit()
        {
            this.shouldSerialize["PricePerUnit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricePerUnitAfterDiscount()
        {
            this.shouldSerialize["PricePerUnitAfterDiscount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTierPriceListId()
        {
            return this.shouldSerialize["TierPriceListId"];
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
        public bool ShouldSerializeTierMin()
        {
            return this.shouldSerialize["TierMin"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTierMax()
        {
            return this.shouldSerialize["TierMax"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTieredPricingGroupName()
        {
            return this.shouldSerialize["TieredPricingGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTieredPricingGroupPeriod()
        {
            return this.shouldSerialize["TieredPricingGroupPeriod"];
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
        public bool ShouldSerializePricePerUnit()
        {
            return this.shouldSerialize["PricePerUnit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePerUnitAfterDiscount()
        {
            return this.shouldSerialize["PricePerUnitAfterDiscount"];
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
            return obj is Tier other &&                ((this.TierPriceListId == null && other.TierPriceListId == null) || (this.TierPriceListId?.Equals(other.TierPriceListId) == true)) &&
                ((this.PriceListDescription == null && other.PriceListDescription == null) || (this.PriceListDescription?.Equals(other.PriceListDescription) == true)) &&
                ((this.TierMin == null && other.TierMin == null) || (this.TierMin?.Equals(other.TierMin) == true)) &&
                ((this.TierMax == null && other.TierMax == null) || (this.TierMax?.Equals(other.TierMax) == true)) &&
                ((this.TieredPricingGroupName == null && other.TieredPricingGroupName == null) || (this.TieredPricingGroupName?.Equals(other.TieredPricingGroupName) == true)) &&
                ((this.TieredPricingGroupPeriod == null && other.TieredPricingGroupPeriod == null) || (this.TieredPricingGroupPeriod?.Equals(other.TieredPricingGroupPeriod) == true)) &&
                ((this.DiscountValue == null && other.DiscountValue == null) || (this.DiscountValue?.Equals(other.DiscountValue) == true)) &&
                ((this.PricePerUnit == null && other.PricePerUnit == null) || (this.PricePerUnit?.Equals(other.PricePerUnit) == true)) &&
                ((this.PricePerUnitAfterDiscount == null && other.PricePerUnitAfterDiscount == null) || (this.PricePerUnitAfterDiscount?.Equals(other.PricePerUnitAfterDiscount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TierPriceListId = {(this.TierPriceListId == null ? "null" : this.TierPriceListId.ToString())}");
            toStringOutput.Add($"this.PriceListDescription = {(this.PriceListDescription == null ? "null" : this.PriceListDescription)}");
            toStringOutput.Add($"this.TierMin = {(this.TierMin == null ? "null" : this.TierMin.ToString())}");
            toStringOutput.Add($"this.TierMax = {(this.TierMax == null ? "null" : this.TierMax.ToString())}");
            toStringOutput.Add($"this.TieredPricingGroupName = {(this.TieredPricingGroupName == null ? "null" : this.TieredPricingGroupName)}");
            toStringOutput.Add($"this.TieredPricingGroupPeriod = {(this.TieredPricingGroupPeriod == null ? "null" : this.TieredPricingGroupPeriod)}");
            toStringOutput.Add($"this.DiscountValue = {(this.DiscountValue == null ? "null" : this.DiscountValue.ToString())}");
            toStringOutput.Add($"this.PricePerUnit = {(this.PricePerUnit == null ? "null" : this.PricePerUnit.ToString())}");
            toStringOutput.Add($"this.PricePerUnitAfterDiscount = {(this.PricePerUnitAfterDiscount == null ? "null" : this.PricePerUnitAfterDiscount.ToString())}");
        }
    }
}