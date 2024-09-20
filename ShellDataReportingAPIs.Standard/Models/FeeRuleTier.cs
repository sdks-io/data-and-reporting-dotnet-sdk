// <copyright file="FeeRuleTier.cs" company="APIMatic">
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
    /// FeeRuleTier.
    /// </summary>
    public class FeeRuleTier
    {
        private int? tierMinimum;
        private double? mValue;
        private int? tierMaximum;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "TierMinimum", false },
            { "Value", false },
            { "TierMaximum", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRuleTier"/> class.
        /// </summary>
        public FeeRuleTier()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRuleTier"/> class.
        /// </summary>
        /// <param name="tierMinimum">TierMinimum.</param>
        /// <param name="mValue">Value.</param>
        /// <param name="tierMaximum">TierMaximum.</param>
        public FeeRuleTier(
            int? tierMinimum = null,
            double? mValue = null,
            int? tierMaximum = null)
        {
            if (tierMinimum != null)
            {
                this.TierMinimum = tierMinimum;
            }

            if (mValue != null)
            {
                this.MValue = mValue;
            }

            if (tierMaximum != null)
            {
                this.TierMaximum = tierMaximum;
            }

        }

        /// <summary>
        /// Minimum consumption configured in the tier.
        /// </summary>
        [JsonProperty("TierMinimum")]
        public int? TierMinimum
        {
            get
            {
                return this.tierMinimum;
            }

            set
            {
                this.shouldSerialize["TierMinimum"] = true;
                this.tierMinimum = value;
            }
        }

        /// <summary>
        /// Bonus value for the tier.
        /// </summary>
        [JsonProperty("Value")]
        public double? MValue
        {
            get
            {
                return this.mValue;
            }

            set
            {
                this.shouldSerialize["Value"] = true;
                this.mValue = value;
            }
        }

        /// <summary>
        /// Maximum consumption configured in the tier.
        /// </summary>
        [JsonProperty("TierMaximum")]
        public int? TierMaximum
        {
            get
            {
                return this.tierMaximum;
            }

            set
            {
                this.shouldSerialize["TierMaximum"] = true;
                this.tierMaximum = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FeeRuleTier : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTierMinimum()
        {
            this.shouldSerialize["TierMinimum"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMValue()
        {
            this.shouldSerialize["Value"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTierMaximum()
        {
            this.shouldSerialize["TierMaximum"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTierMinimum()
        {
            return this.shouldSerialize["TierMinimum"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMValue()
        {
            return this.shouldSerialize["Value"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTierMaximum()
        {
            return this.shouldSerialize["TierMaximum"];
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
            return obj is FeeRuleTier other &&                ((this.TierMinimum == null && other.TierMinimum == null) || (this.TierMinimum?.Equals(other.TierMinimum) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.TierMaximum == null && other.TierMaximum == null) || (this.TierMaximum?.Equals(other.TierMaximum) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TierMinimum = {(this.TierMinimum == null ? "null" : this.TierMinimum.ToString())}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"this.TierMaximum = {(this.TierMaximum == null ? "null" : this.TierMaximum.ToString())}");
        }
    }
}