// <copyright file="MonthlyInvoiceTrend.cs" company="APIMatic">
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
    /// MonthlyInvoiceTrend.
    /// </summary>
    public class MonthlyInvoiceTrend
    {
        private string currencyCode;
        private string currencySymbol;
        private int? month;
        private double? totalNetAmount;
        private double? totalVATAmount;
        private int? year;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "Month", false },
            { "TotalNetAmount", false },
            { "TotalVATAmount", false },
            { "Year", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyInvoiceTrend"/> class.
        /// </summary>
        public MonthlyInvoiceTrend()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyInvoiceTrend"/> class.
        /// </summary>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="month">Month.</param>
        /// <param name="totalNetAmount">TotalNetAmount.</param>
        /// <param name="totalVATAmount">TotalVATAmount.</param>
        /// <param name="year">Year.</param>
        public MonthlyInvoiceTrend(
            string currencyCode = null,
            string currencySymbol = null,
            int? month = null,
            double? totalNetAmount = null,
            double? totalVATAmount = null,
            int? year = null)
        {
            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (month != null)
            {
                this.Month = month;
            }

            if (totalNetAmount != null)
            {
                this.TotalNetAmount = totalNetAmount;
            }

            if (totalVATAmount != null)
            {
                this.TotalVATAmount = totalVATAmount;
            }

            if (year != null)
            {
                this.Year = year;
            }

        }

        /// <summary>
        /// ISO code of invoice currency.
        /// Example: EUR
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
        /// Symbol of invoice currency.
        /// Example: €
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
        /// Month.
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
        /// Total net amount invoiced in this month.
        /// </summary>
        [JsonProperty("TotalNetAmount")]
        public double? TotalNetAmount
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
        /// Total VAT amount invoiced in this month.
        /// </summary>
        [JsonProperty("TotalVATAmount")]
        public double? TotalVATAmount
        {
            get
            {
                return this.totalVATAmount;
            }

            set
            {
                this.shouldSerialize["TotalVATAmount"] = true;
                this.totalVATAmount = value;
            }
        }

        /// <summary>
        /// Year.
        /// </summary>
        [JsonProperty("Year")]
        public int? Year
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MonthlyInvoiceTrend : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetMonth()
        {
            this.shouldSerialize["Month"] = false;
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
        public void UnsetTotalVATAmount()
        {
            this.shouldSerialize["TotalVATAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetYear()
        {
            this.shouldSerialize["Year"] = false;
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
        public bool ShouldSerializeMonth()
        {
            return this.shouldSerialize["Month"];
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
        public bool ShouldSerializeTotalVATAmount()
        {
            return this.shouldSerialize["TotalVATAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeYear()
        {
            return this.shouldSerialize["Year"];
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
            return obj is MonthlyInvoiceTrend other &&                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.Month == null && other.Month == null) || (this.Month?.Equals(other.Month) == true)) &&
                ((this.TotalNetAmount == null && other.TotalNetAmount == null) || (this.TotalNetAmount?.Equals(other.TotalNetAmount) == true)) &&
                ((this.TotalVATAmount == null && other.TotalVATAmount == null) || (this.TotalVATAmount?.Equals(other.TotalVATAmount) == true)) &&
                ((this.Year == null && other.Year == null) || (this.Year?.Equals(other.Year) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.Month = {(this.Month == null ? "null" : this.Month.ToString())}");
            toStringOutput.Add($"this.TotalNetAmount = {(this.TotalNetAmount == null ? "null" : this.TotalNetAmount.ToString())}");
            toStringOutput.Add($"this.TotalVATAmount = {(this.TotalVATAmount == null ? "null" : this.TotalVATAmount.ToString())}");
            toStringOutput.Add($"this.Year = {(this.Year == null ? "null" : this.Year.ToString())}");
        }
    }
}