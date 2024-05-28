// <copyright file="CustomerPriceListRequest.cs" company="APIMatic">
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
    /// CustomerPriceListRequest.
    /// </summary>
    public class CustomerPriceListRequest
    {
        private int? colCoId;
        private int? colCoCode;
        private int? payerId;
        private string payerNumber;
        private int? accountId;
        private string accountNumber;
        private int? customerSpecificList;
        private int? priceListType;
        private int? delCoId;
        private bool? includePumpPriceDiscounts;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ColCoId", false },
            { "ColCoCode", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "AccountId", false },
            { "AccountNumber", false },
            { "CustomerSpecificList", false },
            { "PriceListType", false },
            { "DelCoId", false },
            { "IncludePumpPriceDiscounts", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPriceListRequest"/> class.
        /// </summary>
        public CustomerPriceListRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPriceListRequest"/> class.
        /// </summary>
        /// <param name="colCoId">ColCoId.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="customerSpecificList">CustomerSpecificList.</param>
        /// <param name="priceListType">PriceListType.</param>
        /// <param name="delCoId">DelCoId.</param>
        /// <param name="fromDate">FromDate.</param>
        /// <param name="toDate">ToDate.</param>
        /// <param name="includePumpPriceDiscounts">IncludePumpPriceDiscounts.</param>
        public CustomerPriceListRequest(
            int? colCoId = null,
            int? colCoCode = null,
            int? payerId = null,
            string payerNumber = null,
            int? accountId = null,
            string accountNumber = null,
            int? customerSpecificList = null,
            int? priceListType = null,
            int? delCoId = null,
            string fromDate = null,
            string toDate = null,
            bool? includePumpPriceDiscounts = null)
        {
            if (colCoId != null)
            {
                this.ColCoId = colCoId;
            }

            if (colCoCode != null)
            {
                this.ColCoCode = colCoCode;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (customerSpecificList != null)
            {
                this.CustomerSpecificList = customerSpecificList;
            }

            if (priceListType != null)
            {
                this.PriceListType = priceListType;
            }

            if (delCoId != null)
            {
                this.DelCoId = delCoId;
            }

            this.FromDate = fromDate;
            this.ToDate = toDate;
            if (includePumpPriceDiscounts != null)
            {
                this.IncludePumpPriceDiscounts = includePumpPriceDiscounts;
            }

        }

        /// <summary>
        /// Gets or sets ColCoId.
        /// </summary>
        [JsonProperty("ColCoId")]
        public int? ColCoId
        {
            get
            {
                return this.colCoId;
            }

            set
            {
                this.shouldSerialize["ColCoId"] = true;
                this.colCoId = value;
            }
        }

        /// <summary>
        /// Gets or sets ColCoCode.
        /// </summary>
        [JsonProperty("ColCoCode")]
        public int? ColCoCode
        {
            get
            {
                return this.colCoCode;
            }

            set
            {
                this.shouldSerialize["ColCoCode"] = true;
                this.colCoCode = value;
            }
        }

        /// <summary>
        /// Payer Id of the selected payer.
        /// Optional if PayerNumber is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerId")]
        public int? PayerId
        {
            get
            {
                return this.payerId;
            }

            set
            {
                this.shouldSerialize["PayerId"] = true;
                this.payerId = value;
            }
        }

        /// <summary>
        /// Payer Number of the selected payer.
        /// Optional if PayerId is passed else Mandatory
        /// </summary>
        [JsonProperty("PayerNumber")]
        public string PayerNumber
        {
            get
            {
                return this.payerNumber;
            }

            set
            {
                this.shouldSerialize["PayerNumber"] = true;
                this.payerNumber = value;
            }
        }

        /// <summary>
        /// Account Id of the customer.
        /// Optional
        /// </summary>
        [JsonProperty("AccountId")]
        public int? AccountId
        {
            get
            {
                return this.accountId;
            }

            set
            {
                this.shouldSerialize["AccountId"] = true;
                this.accountId = value;
            }
        }

        /// <summary>
        /// Account Number of the customer.
        /// Optional
        /// </summary>
        [JsonProperty("AccountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["AccountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Whether customer specific price lists and customer specific discount values set on pump prices are to be returned or not.
        /// </summary>
        [JsonProperty("CustomerSpecificList")]
        public int? CustomerSpecificList
        {
            get
            {
                return this.customerSpecificList;
            }

            set
            {
                this.shouldSerialize["CustomerSpecificList"] = true;
                this.customerSpecificList = value;
            }
        }

        /// <summary>
        /// Specifies the type of price lists to be included in the response.
        /// Optional – default value is zero.
        /// Allowed values:
        /// 0 – All
        /// 1 – National Only
        /// 2 – International Only
        /// </summary>
        [JsonProperty("PriceListType")]
        public int? PriceListType
        {
            get
            {
                return this.priceListType;
            }

            set
            {
                this.shouldSerialize["PriceListType"] = true;
                this.priceListType = value;
            }
        }

        /// <summary>
        /// Delivering Company ID
        /// Optional.
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
        /// Start date to fetch the price lists, discount values on pump prices and VAT rates.
        /// Mandatory
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("FromDate", NullValueHandling = NullValueHandling.Include)]
        public string FromDate { get; set; }

        /// <summary>
        /// End date to fetch the price lists, discount values on pump prices and VAT rates.
        /// Mandatory and greater than or equal to FromDate.
        /// Maximum of 30 (configurable) day’s duration is allowed between ‘From’ and ‘To’ dates.
        /// Format: yyyyMMdd
        /// </summary>
        [JsonProperty("ToDate", NullValueHandling = NullValueHandling.Include)]
        public string ToDate { get; set; }

        /// <summary>
        /// True / False.
        /// A flag to request the discount information set on pump prices for the customer to be included in the response.
        /// Optional
        /// Default value: False
        /// </summary>
        [JsonProperty("IncludePumpPriceDiscounts")]
        public bool? IncludePumpPriceDiscounts
        {
            get
            {
                return this.includePumpPriceDiscounts;
            }

            set
            {
                this.shouldSerialize["IncludePumpPriceDiscounts"] = true;
                this.includePumpPriceDiscounts = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerPriceListRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoId()
        {
            this.shouldSerialize["ColCoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetColCoCode()
        {
            this.shouldSerialize["ColCoCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerId()
        {
            this.shouldSerialize["PayerId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayerNumber()
        {
            this.shouldSerialize["PayerNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountId()
        {
            this.shouldSerialize["AccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerSpecificList()
        {
            this.shouldSerialize["CustomerSpecificList"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPriceListType()
        {
            this.shouldSerialize["PriceListType"] = false;
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
        public void UnsetIncludePumpPriceDiscounts()
        {
            this.shouldSerialize["IncludePumpPriceDiscounts"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoId()
        {
            return this.shouldSerialize["ColCoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeColCoCode()
        {
            return this.shouldSerialize["ColCoCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerId()
        {
            return this.shouldSerialize["PayerId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayerNumber()
        {
            return this.shouldSerialize["PayerNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountId()
        {
            return this.shouldSerialize["AccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["AccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerSpecificList()
        {
            return this.shouldSerialize["CustomerSpecificList"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePriceListType()
        {
            return this.shouldSerialize["PriceListType"];
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
        public bool ShouldSerializeIncludePumpPriceDiscounts()
        {
            return this.shouldSerialize["IncludePumpPriceDiscounts"];
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
            return obj is CustomerPriceListRequest other &&                ((this.ColCoId == null && other.ColCoId == null) || (this.ColCoId?.Equals(other.ColCoId) == true)) &&
                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.CustomerSpecificList == null && other.CustomerSpecificList == null) || (this.CustomerSpecificList?.Equals(other.CustomerSpecificList) == true)) &&
                ((this.PriceListType == null && other.PriceListType == null) || (this.PriceListType?.Equals(other.PriceListType) == true)) &&
                ((this.DelCoId == null && other.DelCoId == null) || (this.DelCoId?.Equals(other.DelCoId) == true)) &&
                ((this.FromDate == null && other.FromDate == null) || (this.FromDate?.Equals(other.FromDate) == true)) &&
                ((this.ToDate == null && other.ToDate == null) || (this.ToDate?.Equals(other.ToDate) == true)) &&
                ((this.IncludePumpPriceDiscounts == null && other.IncludePumpPriceDiscounts == null) || (this.IncludePumpPriceDiscounts?.Equals(other.IncludePumpPriceDiscounts) == true));
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
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.CustomerSpecificList = {(this.CustomerSpecificList == null ? "null" : this.CustomerSpecificList.ToString())}");
            toStringOutput.Add($"this.PriceListType = {(this.PriceListType == null ? "null" : this.PriceListType.ToString())}");
            toStringOutput.Add($"this.DelCoId = {(this.DelCoId == null ? "null" : this.DelCoId.ToString())}");
            toStringOutput.Add($"this.FromDate = {(this.FromDate == null ? "null" : this.FromDate)}");
            toStringOutput.Add($"this.ToDate = {(this.ToDate == null ? "null" : this.ToDate)}");
            toStringOutput.Add($"this.IncludePumpPriceDiscounts = {(this.IncludePumpPriceDiscounts == null ? "null" : this.IncludePumpPriceDiscounts.ToString())}");
        }
    }
}