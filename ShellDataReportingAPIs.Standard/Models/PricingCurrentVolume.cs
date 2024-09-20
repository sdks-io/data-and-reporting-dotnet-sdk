// <copyright file="PricingCurrentVolume.cs" company="APIMatic">
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
    /// PricingCurrentVolume.
    /// </summary>
    public class PricingCurrentVolume
    {
        private int? feeRuleId;
        private string feeRuleDescription;
        private int? priceRuleID;
        private string priceRuleDescription;
        private double? totalVolume;
        private string nextFeeCreationDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "FeeRuleId", false },
            { "FeeRuleDescription", false },
            { "PriceRuleID", false },
            { "PriceRuleDescription", false },
            { "TotalVolume", false },
            { "NextFeeCreationDate", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCurrentVolume"/> class.
        /// </summary>
        public PricingCurrentVolume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCurrentVolume"/> class.
        /// </summary>
        /// <param name="feeRuleId">FeeRuleId.</param>
        /// <param name="feeRuleDescription">FeeRuleDescription.</param>
        /// <param name="priceRuleID">PriceRuleID.</param>
        /// <param name="priceRuleDescription">PriceRuleDescription.</param>
        /// <param name="totalVolume">TotalVolume.</param>
        /// <param name="nextFeeCreationDate">NextFeeCreationDate.</param>
        public PricingCurrentVolume(
            int? feeRuleId = null,
            string feeRuleDescription = null,
            int? priceRuleID = null,
            string priceRuleDescription = null,
            double? totalVolume = null,
            string nextFeeCreationDate = null)
        {
            if (feeRuleId != null)
            {
                this.FeeRuleId = feeRuleId;
            }

            if (feeRuleDescription != null)
            {
                this.FeeRuleDescription = feeRuleDescription;
            }

            if (priceRuleID != null)
            {
                this.PriceRuleID = priceRuleID;
            }

            if (priceRuleDescription != null)
            {
                this.PriceRuleDescription = priceRuleDescription;
            }

            if (totalVolume != null)
            {
                this.TotalVolume = totalVolume;
            }

            if (nextFeeCreationDate != null)
            {
                this.NextFeeCreationDate = nextFeeCreationDate;
            }

        }

        /// <summary>
        /// Bonus or association bonus configuration identifier  that is associated to the payer.
        /// </summary>
        [JsonProperty("FeeRuleId")]
        public int? FeeRuleId
        {
            get
            {
                return this.feeRuleId;
            }

            set
            {
                this.shouldSerialize["FeeRuleId"] = true;
                this.feeRuleId = value;
            }
        }

        /// <summary>
        /// Bonus or association bonus configuration description that is associated to the payer
        /// </summary>
        [JsonProperty("FeeRuleDescription")]
        public string FeeRuleDescription
        {
            get
            {
                return this.feeRuleDescription;
            }

            set
            {
                this.shouldSerialize["FeeRuleDescription"] = true;
                this.feeRuleDescription = value;
            }
        }

        /// <summary>
        /// Pricing current period Pricing Price Rule ID that is associated to the payer.
        /// </summary>
        [JsonProperty("PriceRuleID")]
        public int? PriceRuleID
        {
            get
            {
                return this.priceRuleID;
            }

            set
            {
                this.shouldSerialize["PriceRuleID"] = true;
                this.priceRuleID = value;
            }
        }

        /// <summary>
        /// Pricing current period pricing rule description that is associated to the payer
        /// </summary>
        [JsonProperty("PriceRuleDescription")]
        public string PriceRuleDescription
        {
            get
            {
                return this.priceRuleDescription;
            }

            set
            {
                this.shouldSerialize["PriceRuleDescription"] = true;
                this.priceRuleDescription = value;
            }
        }

        /// <summary>
        /// Total volume consumption for the current period.
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
        /// Next Fee Rule Creation Date for that is associated to the payer.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("NextFeeCreationDate")]
        public string NextFeeCreationDate
        {
            get
            {
                return this.nextFeeCreationDate;
            }

            set
            {
                this.shouldSerialize["NextFeeCreationDate"] = true;
                this.nextFeeCreationDate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricingCurrentVolume : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleId()
        {
            this.shouldSerialize["FeeRuleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleDescription()
        {
            this.shouldSerialize["FeeRuleDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleID()
        {
            this.shouldSerialize["PriceRuleID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceRuleDescription()
        {
            this.shouldSerialize["PriceRuleDescription"] = false;
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
        public void UnsetNextFeeCreationDate()
        {
            this.shouldSerialize["NextFeeCreationDate"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleId()
        {
            return this.shouldSerialize["FeeRuleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleDescription()
        {
            return this.shouldSerialize["FeeRuleDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleID()
        {
            return this.shouldSerialize["PriceRuleID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceRuleDescription()
        {
            return this.shouldSerialize["PriceRuleDescription"];
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
        public bool ShouldSerializeNextFeeCreationDate()
        {
            return this.shouldSerialize["NextFeeCreationDate"];
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
            return obj is PricingCurrentVolume other &&                ((this.FeeRuleId == null && other.FeeRuleId == null) || (this.FeeRuleId?.Equals(other.FeeRuleId) == true)) &&
                ((this.FeeRuleDescription == null && other.FeeRuleDescription == null) || (this.FeeRuleDescription?.Equals(other.FeeRuleDescription) == true)) &&
                ((this.PriceRuleID == null && other.PriceRuleID == null) || (this.PriceRuleID?.Equals(other.PriceRuleID) == true)) &&
                ((this.PriceRuleDescription == null && other.PriceRuleDescription == null) || (this.PriceRuleDescription?.Equals(other.PriceRuleDescription) == true)) &&
                ((this.TotalVolume == null && other.TotalVolume == null) || (this.TotalVolume?.Equals(other.TotalVolume) == true)) &&
                ((this.NextFeeCreationDate == null && other.NextFeeCreationDate == null) || (this.NextFeeCreationDate?.Equals(other.NextFeeCreationDate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FeeRuleId = {(this.FeeRuleId == null ? "null" : this.FeeRuleId.ToString())}");
            toStringOutput.Add($"this.FeeRuleDescription = {(this.FeeRuleDescription == null ? "null" : this.FeeRuleDescription)}");
            toStringOutput.Add($"this.PriceRuleID = {(this.PriceRuleID == null ? "null" : this.PriceRuleID.ToString())}");
            toStringOutput.Add($"this.PriceRuleDescription = {(this.PriceRuleDescription == null ? "null" : this.PriceRuleDescription)}");
            toStringOutput.Add($"this.TotalVolume = {(this.TotalVolume == null ? "null" : this.TotalVolume.ToString())}");
            toStringOutput.Add($"this.NextFeeCreationDate = {(this.NextFeeCreationDate == null ? "null" : this.NextFeeCreationDate)}");
        }
    }
}