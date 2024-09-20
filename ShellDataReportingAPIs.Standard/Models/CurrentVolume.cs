// <copyright file="CurrentVolume.cs" company="APIMatic">
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
    /// CurrentVolume.
    /// </summary>
    public class CurrentVolume
    {
        private int? feeRuleId;
        private string feeRuleDescription;
        private int? month;
        private string year;
        private double? totalVolume;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "FeeRuleId", false },
            { "FeeRuleDescription", false },
            { "Month", false },
            { "Year", false },
            { "TotalVolume", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentVolume"/> class.
        /// </summary>
        public CurrentVolume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentVolume"/> class.
        /// </summary>
        /// <param name="feeRuleId">FeeRuleId.</param>
        /// <param name="feeRuleDescription">FeeRuleDescription.</param>
        /// <param name="month">Month.</param>
        /// <param name="year">Year.</param>
        /// <param name="totalVolume">TotalVolume.</param>
        public CurrentVolume(
            int? feeRuleId = null,
            string feeRuleDescription = null,
            int? month = null,
            string year = null,
            double? totalVolume = null)
        {
            if (feeRuleId != null)
            {
                this.FeeRuleId = feeRuleId;
            }

            if (feeRuleDescription != null)
            {
                this.FeeRuleDescription = feeRuleDescription;
            }

            if (month != null)
            {
                this.Month = month;
            }

            if (year != null)
            {
                this.Year = year;
            }

            if (totalVolume != null)
            {
                this.TotalVolume = totalVolume;
            }

        }

        /// <summary>
        /// Bonus or association bonus configuration identifier that is associated to the payer
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
        /// Bonus or association bonus configuration description that is associated to the payer.
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
        /// Consumption(Volume) of the month.
        /// </summary>
        [JsonProperty("Month")]
        public int? Month
        {
            get
            {
                return this.month;
            }

            set
            {
                this.shouldSerialize["Month"] = true;
                this.month = value;
            }
        }

        /// <summary>
        /// Consumption (Volume) of the year.
        /// </summary>
        [JsonProperty("Year")]
        public string Year
        {
            get
            {
                return this.year;
            }

            set
            {
                this.shouldSerialize["Year"] = true;
                this.year = value;
            }
        }

        /// <summary>
        /// Total volume consumption for the month/year above.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CurrentVolume : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetMonth()
        {
            this.shouldSerialize["Month"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetYear()
        {
            this.shouldSerialize["Year"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalVolume()
        {
            this.shouldSerialize["TotalVolume"] = false;
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
        public bool ShouldSerializeMonth()
        {
            return this.shouldSerialize["Month"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeYear()
        {
            return this.shouldSerialize["Year"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalVolume()
        {
            return this.shouldSerialize["TotalVolume"];
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
            return obj is CurrentVolume other &&                ((this.FeeRuleId == null && other.FeeRuleId == null) || (this.FeeRuleId?.Equals(other.FeeRuleId) == true)) &&
                ((this.FeeRuleDescription == null && other.FeeRuleDescription == null) || (this.FeeRuleDescription?.Equals(other.FeeRuleDescription) == true)) &&
                ((this.Month == null && other.Month == null) || (this.Month?.Equals(other.Month) == true)) &&
                ((this.Year == null && other.Year == null) || (this.Year?.Equals(other.Year) == true)) &&
                ((this.TotalVolume == null && other.TotalVolume == null) || (this.TotalVolume?.Equals(other.TotalVolume) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FeeRuleId = {(this.FeeRuleId == null ? "null" : this.FeeRuleId.ToString())}");
            toStringOutput.Add($"this.FeeRuleDescription = {(this.FeeRuleDescription == null ? "null" : this.FeeRuleDescription)}");
            toStringOutput.Add($"this.Month = {(this.Month == null ? "null" : this.Month.ToString())}");
            toStringOutput.Add($"this.Year = {(this.Year == null ? "null" : this.Year)}");
            toStringOutput.Add($"this.TotalVolume = {(this.TotalVolume == null ? "null" : this.TotalVolume.ToString())}");
        }
    }
}