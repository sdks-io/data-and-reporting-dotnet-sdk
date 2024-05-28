// <copyright file="InvoiceSummaryDetails.cs" company="APIMatic">
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
    /// InvoiceSummaryDetails.
    /// </summary>
    public class InvoiceSummaryDetails
    {
        private int? totalInvoices;
        private double? totalGrossAmountCustomerCurrency;
        private double? totalNetAmountCustomerCurrency;
        private double? totalVATAmountCustomerCurrency;
        private string customerCurrencyCode;
        private string customerCurrencySymbol;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "TotalInvoices", false },
            { "TotalGrossAmountCustomerCurrency", false },
            { "TotalNetAmountCustomerCurrency", false },
            { "TotalVATAmountCustomerCurrency", false },
            { "CustomerCurrencyCode", false },
            { "CustomerCurrencySymbol", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSummaryDetails"/> class.
        /// </summary>
        public InvoiceSummaryDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSummaryDetails"/> class.
        /// </summary>
        /// <param name="totalInvoices">TotalInvoices.</param>
        /// <param name="totalGrossAmountCustomerCurrency">TotalGrossAmountCustomerCurrency.</param>
        /// <param name="totalNetAmountCustomerCurrency">TotalNetAmountCustomerCurrency.</param>
        /// <param name="totalVATAmountCustomerCurrency">TotalVATAmountCustomerCurrency.</param>
        /// <param name="customerCurrencyCode">CustomerCurrencyCode.</param>
        /// <param name="customerCurrencySymbol">CustomerCurrencySymbol.</param>
        public InvoiceSummaryDetails(
            int? totalInvoices = null,
            double? totalGrossAmountCustomerCurrency = null,
            double? totalNetAmountCustomerCurrency = null,
            double? totalVATAmountCustomerCurrency = null,
            string customerCurrencyCode = null,
            string customerCurrencySymbol = null)
        {
            if (totalInvoices != null)
            {
                this.TotalInvoices = totalInvoices;
            }

            if (totalGrossAmountCustomerCurrency != null)
            {
                this.TotalGrossAmountCustomerCurrency = totalGrossAmountCustomerCurrency;
            }

            if (totalNetAmountCustomerCurrency != null)
            {
                this.TotalNetAmountCustomerCurrency = totalNetAmountCustomerCurrency;
            }

            if (totalVATAmountCustomerCurrency != null)
            {
                this.TotalVATAmountCustomerCurrency = totalVATAmountCustomerCurrency;
            }

            if (customerCurrencyCode != null)
            {
                this.CustomerCurrencyCode = customerCurrencyCode;
            }

            if (customerCurrencySymbol != null)
            {
                this.CustomerCurrencySymbol = customerCurrencySymbol;
            }

        }

        /// <summary>
        /// Total number of invoices matching with the given search criteria.
        /// </summary>
        [JsonProperty("TotalInvoices")]
        public int? TotalInvoices
        {
            get
            {
                return this.totalInvoices;
            }

            set
            {
                this.shouldSerialize["TotalInvoices"] = true;
                this.totalInvoices = value;
            }
        }

        /// <summary>
        /// Total gross amount in customer currency combined from all the invoices matching with the given search criteria.
        /// </summary>
        [JsonProperty("TotalGrossAmountCustomerCurrency")]
        public double? TotalGrossAmountCustomerCurrency
        {
            get
            {
                return this.totalGrossAmountCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["TotalGrossAmountCustomerCurrency"] = true;
                this.totalGrossAmountCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Total net amount in customer currency combined from all the invoices matching with the given search criteria.
        /// </summary>
        [JsonProperty("TotalNetAmountCustomerCurrency")]
        public double? TotalNetAmountCustomerCurrency
        {
            get
            {
                return this.totalNetAmountCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["TotalNetAmountCustomerCurrency"] = true;
                this.totalNetAmountCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Total VAT amount in customer currency combined from all the invoices matching with the given search criteria.
        /// </summary>
        [JsonProperty("TotalVATAmountCustomerCurrency")]
        public double? TotalVATAmountCustomerCurrency
        {
            get
            {
                return this.totalVATAmountCustomerCurrency;
            }

            set
            {
                this.shouldSerialize["TotalVATAmountCustomerCurrency"] = true;
                this.totalVATAmountCustomerCurrency = value;
            }
        }

        /// <summary>
        /// Customer currency ISO code.
        /// Example: EUR
        /// </summary>
        [JsonProperty("CustomerCurrencyCode")]
        public string CustomerCurrencyCode
        {
            get
            {
                return this.customerCurrencyCode;
            }

            set
            {
                this.shouldSerialize["CustomerCurrencyCode"] = true;
                this.customerCurrencyCode = value;
            }
        }

        /// <summary>
        /// Customer currency code.
        /// Example: €
        /// </summary>
        [JsonProperty("CustomerCurrencySymbol")]
        public string CustomerCurrencySymbol
        {
            get
            {
                return this.customerCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["CustomerCurrencySymbol"] = true;
                this.customerCurrencySymbol = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceSummaryDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalInvoices()
        {
            this.shouldSerialize["TotalInvoices"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalGrossAmountCustomerCurrency()
        {
            this.shouldSerialize["TotalGrossAmountCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalNetAmountCustomerCurrency()
        {
            this.shouldSerialize["TotalNetAmountCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalVATAmountCustomerCurrency()
        {
            this.shouldSerialize["TotalVATAmountCustomerCurrency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerCurrencyCode()
        {
            this.shouldSerialize["CustomerCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerCurrencySymbol()
        {
            this.shouldSerialize["CustomerCurrencySymbol"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalInvoices()
        {
            return this.shouldSerialize["TotalInvoices"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalGrossAmountCustomerCurrency()
        {
            return this.shouldSerialize["TotalGrossAmountCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalNetAmountCustomerCurrency()
        {
            return this.shouldSerialize["TotalNetAmountCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalVATAmountCustomerCurrency()
        {
            return this.shouldSerialize["TotalVATAmountCustomerCurrency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerCurrencyCode()
        {
            return this.shouldSerialize["CustomerCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerCurrencySymbol()
        {
            return this.shouldSerialize["CustomerCurrencySymbol"];
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
            return obj is InvoiceSummaryDetails other &&                ((this.TotalInvoices == null && other.TotalInvoices == null) || (this.TotalInvoices?.Equals(other.TotalInvoices) == true)) &&
                ((this.TotalGrossAmountCustomerCurrency == null && other.TotalGrossAmountCustomerCurrency == null) || (this.TotalGrossAmountCustomerCurrency?.Equals(other.TotalGrossAmountCustomerCurrency) == true)) &&
                ((this.TotalNetAmountCustomerCurrency == null && other.TotalNetAmountCustomerCurrency == null) || (this.TotalNetAmountCustomerCurrency?.Equals(other.TotalNetAmountCustomerCurrency) == true)) &&
                ((this.TotalVATAmountCustomerCurrency == null && other.TotalVATAmountCustomerCurrency == null) || (this.TotalVATAmountCustomerCurrency?.Equals(other.TotalVATAmountCustomerCurrency) == true)) &&
                ((this.CustomerCurrencyCode == null && other.CustomerCurrencyCode == null) || (this.CustomerCurrencyCode?.Equals(other.CustomerCurrencyCode) == true)) &&
                ((this.CustomerCurrencySymbol == null && other.CustomerCurrencySymbol == null) || (this.CustomerCurrencySymbol?.Equals(other.CustomerCurrencySymbol) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TotalInvoices = {(this.TotalInvoices == null ? "null" : this.TotalInvoices.ToString())}");
            toStringOutput.Add($"this.TotalGrossAmountCustomerCurrency = {(this.TotalGrossAmountCustomerCurrency == null ? "null" : this.TotalGrossAmountCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.TotalNetAmountCustomerCurrency = {(this.TotalNetAmountCustomerCurrency == null ? "null" : this.TotalNetAmountCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.TotalVATAmountCustomerCurrency = {(this.TotalVATAmountCustomerCurrency == null ? "null" : this.TotalVATAmountCustomerCurrency.ToString())}");
            toStringOutput.Add($"this.CustomerCurrencyCode = {(this.CustomerCurrencyCode == null ? "null" : this.CustomerCurrencyCode)}");
            toStringOutput.Add($"this.CustomerCurrencySymbol = {(this.CustomerCurrencySymbol == null ? "null" : this.CustomerCurrencySymbol)}");
        }
    }
}