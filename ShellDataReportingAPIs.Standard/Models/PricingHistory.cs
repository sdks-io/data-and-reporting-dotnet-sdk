// <copyright file="PricingHistory.cs" company="APIMatic">
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
    /// PricingHistory.
    /// </summary>
    public class PricingHistory
    {
        private string fromDate;
        private string toDate;
        private int? feesRuleID;
        private string feesRuleDescription;
        private double? totalVolume;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "FromDate", false },
            { "ToDate", false },
            { "FeesRuleID", false },
            { "FeesRuleDescription", false },
            { "TotalVolume", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingHistory"/> class.
        /// </summary>
        public PricingHistory()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingHistory"/> class.
        /// </summary>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="feesRuleID">FeesRuleID.</param>
        /// <param name="feesRuleDescription">FeesRuleDescription.</param>
        /// <param name="totalVolume">TotalVolume.</param>
        public PricingHistory(
            string fromDate = null,
            string toDate = null,
            int? feesRuleID = null,
            string feesRuleDescription = null,
            double? totalVolume = null)
        {
            if (fromDate != null)
            {
                this.FromDate = fromDate;
            }

            if (toDate != null)
            {
                this.ToDate = toDate;
            }

            if (feesRuleID != null)
            {
                this.FeesRuleID = feesRuleID;
            }

            if (feesRuleDescription != null)
            {
                this.FeesRuleDescription = feesRuleDescription;
            }

            if (totalVolume != null)
            {
                this.TotalVolume = totalVolume;
            }

        }

        /// <summary>
        /// Pricing History Period Start date and should be the first date of the month.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("FromDate")]
        public string FromDate
        {
            get
            {
                return this.fromDate;
            }

            set
            {
                this.shouldSerialize["FromDate"] = true;
                this.fromDate = value;
            }
        }

        /// <summary>
        /// Pricing History Period end date and should be the last date of the period month.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("ToDate")]
        public string ToDate
        {
            get
            {
                return this.toDate;
            }

            set
            {
                this.shouldSerialize["ToDate"] = true;
                this.toDate = value;
            }
        }

        /// <summary>
        /// Pricing History Period Fees Rule ID that is associated to the period of that associated payer.
        /// Example: 8101
        /// </summary>
        [JsonProperty("FeesRuleID")]
        public int? FeesRuleID
        {
            get
            {
                return this.feesRuleID;
            }

            set
            {
                this.shouldSerialize["FeesRuleID"] = true;
                this.feesRuleID = value;
            }
        }

        /// <summary>
        /// Pricing History Period Fees Rule Description that is associated to the period of that associated payer.
        /// </summary>
        [JsonProperty("FeesRuleDescription")]
        public string FeesRuleDescription
        {
            get
            {
                return this.feesRuleDescription;
            }

            set
            {
                this.shouldSerialize["FeesRuleDescription"] = true;
                this.feesRuleDescription = value;
            }
        }

        /// <summary>
        /// Total Quantity for the Pricing History Period that is associated to that payer.
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

            return $"PricingHistory : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFromDate()
        {
            this.shouldSerialize["FromDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetToDate()
        {
            this.shouldSerialize["ToDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeesRuleID()
        {
            this.shouldSerialize["FeesRuleID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeesRuleDescription()
        {
            this.shouldSerialize["FeesRuleDescription"] = false;
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
        public bool ShouldSerializeFromDate()
        {
            return this.shouldSerialize["FromDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeToDate()
        {
            return this.shouldSerialize["ToDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeesRuleID()
        {
            return this.shouldSerialize["FeesRuleID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeesRuleDescription()
        {
            return this.shouldSerialize["FeesRuleDescription"];
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
            return obj is PricingHistory other &&                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.FeesRuleID == null && other.FeesRuleID == null) || (this.FeesRuleID?.Equals(other.FeesRuleID) == true)) &&
                ((this.FeesRuleDescription == null && other.FeesRuleDescription == null) || (this.FeesRuleDescription?.Equals(other.FeesRuleDescription) == true)) &&
                ((this.TotalVolume == null && other.TotalVolume == null) || (this.TotalVolume?.Equals(other.TotalVolume) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.FeesRuleID = {(this.FeesRuleID == null ? "null" : this.FeesRuleID.ToString())}");
            toStringOutput.Add($"this.FeesRuleDescription = {(this.FeesRuleDescription == null ? "null" : this.FeesRuleDescription)}");
            toStringOutput.Add($"this.TotalVolume = {(this.TotalVolume == null ? "null" : this.TotalVolume.ToString())}");
        }
    }
}