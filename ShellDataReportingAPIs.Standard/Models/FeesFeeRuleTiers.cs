// <copyright file="FeesFeeRuleTiers.cs" company="APIMatic">
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
    /// FeesFeeRuleTiers.
    /// </summary>
    public class FeesFeeRuleTiers
    {
        private int? tierMin;
        private int? tierMax;
        private string dateEffective;
        private string dateTerminated;
        private double? tierValue;
        private int? feeRuleBasisID;
        private string feeRuleBasisDescription;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "TierMin", false },
            { "TierMax", false },
            { "DateEffective", false },
            { "DateTerminated", false },
            { "TierValue", false },
            { "FeeRuleBasisID", false },
            { "FeeRuleBasisDescription", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesFeeRuleTiers"/> class.
        /// </summary>
        public FeesFeeRuleTiers()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeesFeeRuleTiers"/> class.
        /// </summary>
        /// <param name="tierMin">TierMin.</param>
        /// <param name="tierMax">TierMax.</param>
        /// <param name="dateEffective">DateEffective.</param>
        /// <param name="dateTerminated">DateTerminated.</param>
        /// <param name="tierValue">TierValue.</param>
        /// <param name="feeRuleBasisID">FeeRuleBasisID.</param>
        /// <param name="feeRuleBasisDescription">FeeRuleBasisDescription.</param>
        public FeesFeeRuleTiers(
            int? tierMin = null,
            int? tierMax = null,
            string dateEffective = null,
            string dateTerminated = null,
            double? tierValue = null,
            int? feeRuleBasisID = null,
            string feeRuleBasisDescription = null)
        {
            if (tierMin != null)
            {
                this.TierMin = tierMin;
            }

            if (tierMax != null)
            {
                this.TierMax = tierMax;
            }

            if (dateEffective != null)
            {
                this.DateEffective = dateEffective;
            }

            if (dateTerminated != null)
            {
                this.DateTerminated = dateTerminated;
            }

            if (tierValue != null)
            {
                this.TierValue = tierValue;
            }

            if (feeRuleBasisID != null)
            {
                this.FeeRuleBasisID = feeRuleBasisID;
            }

            if (feeRuleBasisDescription != null)
            {
                this.FeeRuleBasisDescription = feeRuleBasisDescription;
            }

        }

        /// <summary>
        /// Gets or sets TierMin.
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
        /// Gets or sets TierMax.
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
        /// Gets or sets DateEffective.
        /// </summary>
        [JsonProperty("DateEffective")]
        public string DateEffective
        {
            get
            {
                return this.dateEffective;
            }

            set
            {
                this.shouldSerialize["DateEffective"] = true;
                this.dateEffective = value;
            }
        }

        /// <summary>
        /// Gets or sets DateTerminated.
        /// </summary>
        [JsonProperty("DateTerminated")]
        public string DateTerminated
        {
            get
            {
                return this.dateTerminated;
            }

            set
            {
                this.shouldSerialize["DateTerminated"] = true;
                this.dateTerminated = value;
            }
        }

        /// <summary>
        /// Gets or sets TierValue.
        /// </summary>
        [JsonProperty("TierValue")]
        public double? TierValue
        {
            get
            {
                return this.tierValue;
            }

            set
            {
                this.shouldSerialize["TierValue"] = true;
                this.tierValue = value;
            }
        }

        /// <summary>
        /// Gets or sets FeeRuleBasisID.
        /// </summary>
        [JsonProperty("FeeRuleBasisID")]
        public int? FeeRuleBasisID
        {
            get
            {
                return this.feeRuleBasisID;
            }

            set
            {
                this.shouldSerialize["FeeRuleBasisID"] = true;
                this.feeRuleBasisID = value;
            }
        }

        /// <summary>
        /// Gets or sets FeeRuleBasisDescription.
        /// </summary>
        [JsonProperty("FeeRuleBasisDescription")]
        public string FeeRuleBasisDescription
        {
            get
            {
                return this.feeRuleBasisDescription;
            }

            set
            {
                this.shouldSerialize["FeeRuleBasisDescription"] = true;
                this.feeRuleBasisDescription = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FeesFeeRuleTiers : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetDateEffective()
        {
            this.shouldSerialize["DateEffective"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateTerminated()
        {
            this.shouldSerialize["DateTerminated"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTierValue()
        {
            this.shouldSerialize["TierValue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleBasisID()
        {
            this.shouldSerialize["FeeRuleBasisID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleBasisDescription()
        {
            this.shouldSerialize["FeeRuleBasisDescription"] = false;
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
        public bool ShouldSerializeDateEffective()
        {
            return this.shouldSerialize["DateEffective"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateTerminated()
        {
            return this.shouldSerialize["DateTerminated"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTierValue()
        {
            return this.shouldSerialize["TierValue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleBasisID()
        {
            return this.shouldSerialize["FeeRuleBasisID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleBasisDescription()
        {
            return this.shouldSerialize["FeeRuleBasisDescription"];
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
            return obj is FeesFeeRuleTiers other &&                ((this.TierMin == null && other.TierMin == null) || (this.TierMin?.Equals(other.TierMin) == true)) &&
                ((this.TierMax == null && other.TierMax == null) || (this.TierMax?.Equals(other.TierMax) == true)) &&
                ((this.DateEffective == null && other.DateEffective == null) || (this.DateEffective?.Equals(other.DateEffective) == true)) &&
                ((this.DateTerminated == null && other.DateTerminated == null) || (this.DateTerminated?.Equals(other.DateTerminated) == true)) &&
                ((this.TierValue == null && other.TierValue == null) || (this.TierValue?.Equals(other.TierValue) == true)) &&
                ((this.FeeRuleBasisID == null && other.FeeRuleBasisID == null) || (this.FeeRuleBasisID?.Equals(other.FeeRuleBasisID) == true)) &&
                ((this.FeeRuleBasisDescription == null && other.FeeRuleBasisDescription == null) || (this.FeeRuleBasisDescription?.Equals(other.FeeRuleBasisDescription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TierMin = {(this.TierMin == null ? "null" : this.TierMin.ToString())}");
            toStringOutput.Add($"this.TierMax = {(this.TierMax == null ? "null" : this.TierMax.ToString())}");
            toStringOutput.Add($"this.DateEffective = {(this.DateEffective == null ? "null" : this.DateEffective)}");
            toStringOutput.Add($"this.DateTerminated = {(this.DateTerminated == null ? "null" : this.DateTerminated)}");
            toStringOutput.Add($"this.TierValue = {(this.TierValue == null ? "null" : this.TierValue.ToString())}");
            toStringOutput.Add($"this.FeeRuleBasisID = {(this.FeeRuleBasisID == null ? "null" : this.FeeRuleBasisID.ToString())}");
            toStringOutput.Add($"this.FeeRuleBasisDescription = {(this.FeeRuleBasisDescription == null ? "null" : this.FeeRuleBasisDescription)}");
        }
    }
}