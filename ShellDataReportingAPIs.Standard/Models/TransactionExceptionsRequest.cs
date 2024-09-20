// <copyright file="TransactionExceptionsRequest.cs" company="APIMatic">
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
    /// TransactionExceptionsRequest.
    /// </summary>
    public class TransactionExceptionsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionExceptionsRequest"/> class.
        /// </summary>
        public TransactionExceptionsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionExceptionsRequest"/> class.
        /// </summary>
        /// <param name="transactionsFromDate">TransactionsFromDate.</param>
        /// <param name="transactionsToDate">TransactionsToDate.</param>
        /// <param name="condition">Condition.</param>
        /// <param name="outputType">OutputType.</param>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accounts">Accounts.</param>
        /// <param name="mValue">Value.</param>
        /// <param name="products">Products.</param>
        /// <param name="exceptionPeriod">ExceptionPeriod.</param>
        /// <param name="fuelOnly">FuelOnly.</param>
        /// <param name="siteGroupIds">SiteGroupIds.</param>
        /// <param name="useFieldId">UseFieldId.</param>
        public TransactionExceptionsRequest(
            string transactionsFromDate,
            string transactionsToDate,
            int condition,
            int outputType,
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            List<Models.Accounts> accounts = null,
            double? mValue = null,
            List<Models.ExceptionProduct> products = null,
            int? exceptionPeriod = null,
            bool? fuelOnly = null,
            List<int> siteGroupIds = null,
            bool? useFieldId = null)
        {
            this.ColCoId = colCoId;
            this.ColCoCode = colCoCode;
            this.PayerId = payerId;
            this.PayerNumber = payerNumber;
            this.Accounts = accounts;
            this.TransactionsFromDate = transactionsFromDate;
            this.TransactionsToDate = transactionsToDate;
            this.MValue = mValue;
            this.Condition = condition;
            this.Products = products;
            this.ExceptionPeriod = exceptionPeriod;
            this.OutputType = outputType;
            this.FuelOnly = fuelOnly;
            this.SiteGroupIds = siteGroupIds;
            this.UseFieldId = useFieldId;
        }

        /// <summary>
        /// Collecting Company Id of the selected payer.
        /// Optional if ColCoCode is passed else Mandatory.
        /// Example:
        /// 1 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoId", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoId { get; set; }

        /// <summary>
        /// Collecting Company Code  of the selected payer.
        /// Mandatory for serviced OUs such as Romania, Latvia, Lithuania, Estonia, Ukraine etc. It is optional for other countries if ColCoID is provided.
        /// Example:
        /// 86 for Philippines
        /// 5 for UK
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Payer Id of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId", NullValueHandling = NullValueHandling.Ignore)]
        public int? PayerId { get; set; }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Gets or sets Accounts.
        /// </summary>
        [JsonProperty("Accounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Accounts> Accounts { get; set; }

        /// <summary>
        /// Exceptions to be searched in transactions from date.
        /// Should be with in last 24 months from the ToDate parameter.
        /// Mandatory
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("TransactionsFromDate")]
        public string TransactionsFromDate { get; set; }

        /// <summary>
        /// Exceptions to be searched in transactions until date.
        /// Mandatory.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("TransactionsToDate")]
        public string TransactionsToDate { get; set; }

        /// <summary>
        /// Value to be used on the Filter Condition
        /// </summary>
        [JsonProperty("Value", NullValueHandling = NullValueHandling.Ignore)]
        public double? MValue { get; set; }

        /// <summary>
        /// Filter condition for the Exceptions.
        /// Mandatory
        /// 1. VolumeGreaterThan
        /// 2. VolumeLessThan
        /// 3. UsageGreaterThan
        /// 4. UsageLessThan
        /// 5. ValueGreaterThan (in Customer Currency)
        /// 6. ValueLessThan  (in Customer Currency)
        /// Note: -
        /// When “OutputType” = 1 is passed as input, above 3 and 4 Condition are not applicable.
        /// </summary>
        [JsonProperty("Condition")]
        public int Condition { get; set; }

        /// <summary>
        /// Gets or sets Products.
        /// </summary>
        [JsonProperty("Products", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ExceptionProduct> Products { get; set; }

        /// <summary>
        /// Period in which the Exceptions such as Monthly/Weekly or Daily volume, value or usage to be identified in the given transactions date range. It is only applied when the Output Type is specified as "Cards".
        /// Mandatory when Output Type is Cards
        /// 1.    Month
        /// 2.    Week
        /// 3.    Day
        /// 4.    Date Range
        /// </summary>
        [JsonProperty("ExceptionPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExceptionPeriod { get; set; }

        /// <summary>
        /// Output Type for Exceptions.
        /// Mandatory.
        /// Possible values:
        /// 1.    Transactions
        /// 2.    Cards
        /// </summary>
        [JsonProperty("OutputType")]
        public int OutputType { get; set; }

        /// <summary>
        /// True/False
        /// Optional
        /// Default value: False.
        /// When passed as ‘True’ Only returned records with Fuel transactions.
        /// When passed as ‘False’ the above condition will not be checked.
        /// </summary>
        [JsonProperty("FuelOnly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FuelOnly { get; set; }

        /// <summary>
        /// SiteGroupIds to be applied to the Filter Condition.
        /// Optional
        /// When not passed, ignored.
        /// When passed, transactions that are matching with the provided list of site group id’s are only returned.
        /// </summary>
        [JsonProperty("SiteGroupIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> SiteGroupIds { get; set; }

        /// <summary>
        /// True/False
        /// Optional
        /// Default value – False.
        /// When set to True, the property names in the output will be replaced by Field IDs.
        /// </summary>
        [JsonProperty("UseFieldId", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseFieldId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TransactionExceptionsRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is TransactionExceptionsRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.Accounts == null && other.Accounts == null) || (this.Accounts?.Equals(other.Accounts) == true)) &&
                ((this.TransactionsFromDate == null && other.TransactionsFromDate == null) || (this.TransactionsFromDate?.Equals(other.TransactionsFromDate) == true)) &&
                ((this.TransactionsToDate == null && other.TransactionsToDate == null) || (this.TransactionsToDate?.Equals(other.TransactionsToDate) == true)) &&
                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                this.Condition.Equals(other.Condition) &&
                ((this.Products == null && other.Products == null) || (this.Products?.Equals(other.Products) == true)) &&
                ((this.ExceptionPeriod == null && other.ExceptionPeriod == null) || (this.ExceptionPeriod?.Equals(other.ExceptionPeriod) == true)) &&
                this.OutputType.Equals(other.OutputType) &&
                ((this.FuelOnly == null && other.FuelOnly == null) || (this.FuelOnly?.Equals(other.FuelOnly) == true)) &&
                ((this.SiteGroupIds == null && other.SiteGroupIds == null) || (this.SiteGroupIds?.Equals(other.SiteGroupIds) == true)) &&
                ((this.UseFieldId == null && other.UseFieldId == null) || (this.UseFieldId?.Equals(other.UseFieldId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoId = {(this.ColCoId == null ? "null" : this.ColCoId.ToString())}");
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.Accounts = {(this.Accounts == null ? "null" : $"[{string.Join(", ", this.Accounts)} ]")}");
            toStringOutput.Add($"this.TransactionsFromDate = {(this.TransactionsFromDate == null ? "null" : this.TransactionsFromDate)}");
            toStringOutput.Add($"this.TransactionsToDate = {(this.TransactionsToDate == null ? "null" : this.TransactionsToDate)}");
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"this.Condition = {this.Condition}");
            toStringOutput.Add($"this.Products = {(this.Products == null ? "null" : $"[{string.Join(", ", this.Products)} ]")}");
            toStringOutput.Add($"this.ExceptionPeriod = {(this.ExceptionPeriod == null ? "null" : this.ExceptionPeriod.ToString())}");
            toStringOutput.Add($"this.OutputType = {this.OutputType}");
            toStringOutput.Add($"this.FuelOnly = {(this.FuelOnly == null ? "null" : this.FuelOnly.ToString())}");
            toStringOutput.Add($"this.SiteGroupIds = {(this.SiteGroupIds == null ? "null" : $"[{string.Join(", ", this.SiteGroupIds)} ]")}");
            toStringOutput.Add($"this.UseFieldId = {(this.UseFieldId == null ? "null" : this.UseFieldId.ToString())}");
        }
    }
}