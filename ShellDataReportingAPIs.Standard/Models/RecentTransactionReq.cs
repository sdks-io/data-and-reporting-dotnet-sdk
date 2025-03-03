// <copyright file="RecentTransactionReq.cs" company="APIMatic">
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
    /// RecentTransactionReq.
    /// </summary>
    public class RecentTransactionReq
    {
        private string accountNumber;
        private string productCode;
        private string purchasedInCountry;
        private string cardPAN;
        private string fromDateTime;
        private string toDateTime;
        private string transactionStatus;
        private string fuelOnly;
        private string productGroupName;
        private string vehicleRegistrationNumber;
        private bool? includeDeclines;
        private string cardIssuerName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountNumber", false },
            { "ProductCode", false },
            { "PurchasedInCountry", false },
            { "CardPAN", false },
            { "FromDateTime", false },
            { "ToDateTime", false },
            { "TransactionStatus", false },
            { "FuelOnly", false },
            { "ProductGroupName", false },
            { "VehicleRegistrationNumber", false },
            { "IncludeDeclines", false },
            { "CardIssuerName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="RecentTransactionReq"/> class.
        /// </summary>
        public RecentTransactionReq()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecentTransactionReq"/> class.
        /// </summary>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="productCode">ProductCode.</param>
        /// <param name="purchasedInCountry">PurchasedInCountry.</param>
        /// <param name="cardPAN">CardPAN.</param>
        /// <param name="fromDateTime">FromDateTime.</param>
        /// <param name="toDateTime">ToDateTime.</param>
        /// <param name="transactionStatus">TransactionStatus.</param>
        /// <param name="fuelOnly">FuelOnly.</param>
        /// <param name="productGroupName">ProductGroupName.</param>
        /// <param name="vehicleRegistrationNumber">VehicleRegistrationNumber.</param>
        /// <param name="includeDeclines">IncludeDeclines.</param>
        /// <param name="cardIssuerName">CardIssuerName.</param>
        /// <param name="columnList">ColumnList.</param>
        public RecentTransactionReq(
            int? colCoCode = null,
            string payerNumber = null,
            string accountNumber = null,
            string productCode = null,
            string purchasedInCountry = null,
            string cardPAN = null,
            string fromDateTime = null,
            string toDateTime = null,
            string transactionStatus = null,
            string fuelOnly = null,
            string productGroupName = null,
            string vehicleRegistrationNumber = null,
            bool? includeDeclines = null,
            string cardIssuerName = null,
            string columnList = null)
        {
            this.ColCoCode = colCoCode;
            this.PayerNumber = payerNumber;

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            if (purchasedInCountry != null)
            {
                this.PurchasedInCountry = purchasedInCountry;
            }

            if (cardPAN != null)
            {
                this.CardPAN = cardPAN;
            }

            if (fromDateTime != null)
            {
                this.FromDateTime = fromDateTime;
            }

            if (toDateTime != null)
            {
                this.ToDateTime = toDateTime;
            }

            if (transactionStatus != null)
            {
                this.TransactionStatus = transactionStatus;
            }

            if (fuelOnly != null)
            {
                this.FuelOnly = fuelOnly;
            }

            if (productGroupName != null)
            {
                this.ProductGroupName = productGroupName;
            }

            if (vehicleRegistrationNumber != null)
            {
                this.VehicleRegistrationNumber = vehicleRegistrationNumber;
            }

            if (includeDeclines != null)
            {
                this.IncludeDeclines = includeDeclines;
            }

            if (cardIssuerName != null)
            {
                this.CardIssuerName = cardIssuerName;
            }
            this.ColumnList = columnList;
        }

        /// <summary>
        /// Three character Collecting Company Code (Shell Code) of the selected payer
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Include)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Unique Identifier for the customer at payment point.
        /// </summary>
        [JsonProperty("PayerNumber", NullValueHandling = NullValueHandling.Include)]
        public string PayerNumber { get; set; }

        /// <summary>
        /// Customer account number.
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
        /// Global product code
        /// </summary>
        [JsonProperty("ProductCode")]
        public string ProductCode
        {
            get
            {
                return this.productCode;
            }

            set
            {
                this.shouldSerialize["ProductCode"] = true;
                this.productCode = value;
            }
        }

        /// <summary>
        /// Delco country
        /// </summary>
        [JsonProperty("PurchasedInCountry")]
        public string PurchasedInCountry
        {
            get
            {
                return this.purchasedInCountry;
            }

            set
            {
                this.shouldSerialize["PurchasedInCountry"] = true;
                this.purchasedInCountry = value;
            }
        }

        /// <summary>
        /// Card identifier number masked
        /// </summary>
        [JsonProperty("CardPAN")]
        public string CardPAN
        {
            get
            {
                return this.cardPAN;
            }

            set
            {
                this.shouldSerialize["CardPAN"] = true;
                this.cardPAN = value;
            }
        }

        /// <summary>
        /// Start date and time of transactions
        /// </summary>
        [JsonProperty("FromDateTime")]
        public string FromDateTime
        {
            get
            {
                return this.fromDateTime;
            }

            set
            {
                this.shouldSerialize["FromDateTime"] = true;
                this.fromDateTime = value;
            }
        }

        /// <summary>
        /// End date and time of transactions. Mandatory if FromDateTime is provided.
        /// </summary>
        [JsonProperty("ToDateTime")]
        public string ToDateTime
        {
            get
            {
                return this.toDateTime;
            }

            set
            {
                this.shouldSerialize["ToDateTime"] = true;
                this.toDateTime = value;
            }
        }

        /// <summary>
        /// Status of transaction. DO NOT pass the value if includeDeclines is passed
        /// </summary>
        [JsonProperty("TransactionStatus")]
        public string TransactionStatus
        {
            get
            {
                return this.transactionStatus;
            }

            set
            {
                this.shouldSerialize["TransactionStatus"] = true;
                this.transactionStatus = value;
            }
        }

        /// <summary>
        /// When passed as ‘true’ Only returned records with Fuel transactions.(All Fuels).When passed as ‘false’ the above condition will not be checked. (Both All Fuels and Non-Fuel)
        /// </summary>
        [JsonProperty("FuelOnly")]
        public string FuelOnly
        {
            get
            {
                return this.fuelOnly;
            }

            set
            {
                this.shouldSerialize["FuelOnly"] = true;
                this.fuelOnly = value;
            }
        }

        /// <summary>
        /// Product group name
        /// </summary>
        [JsonProperty("ProductGroupName")]
        public string ProductGroupName
        {
            get
            {
                return this.productGroupName;
            }

            set
            {
                this.shouldSerialize["ProductGroupName"] = true;
                this.productGroupName = value;
            }
        }

        /// <summary>
        /// Vehicle registration number embossed on the card
        /// </summary>
        [JsonProperty("VehicleRegistrationNumber")]
        public string VehicleRegistrationNumber
        {
            get
            {
                return this.vehicleRegistrationNumber;
            }

            set
            {
                this.shouldSerialize["VehicleRegistrationNumber"] = true;
                this.vehicleRegistrationNumber = value;
            }
        }

        /// <summary>
        /// Flag to enable to get declined records
        /// </summary>
        [JsonProperty("IncludeDeclines")]
        public bool? IncludeDeclines
        {
            get
            {
                return this.includeDeclines;
            }

            set
            {
                this.shouldSerialize["IncludeDeclines"] = true;
                this.includeDeclines = value;
            }
        }

        /// <summary>
        /// Card issuer name
        /// </summary>
        [JsonProperty("CardIssuerName")]
        public string CardIssuerName
        {
            get
            {
                return this.cardIssuerName;
            }

            set
            {
                this.shouldSerialize["CardIssuerName"] = true;
                this.cardIssuerName = value;
            }
        }

        /// <summary>
        /// Column list to be part of response, it can be 'All' to return all possible column. E.g. 'All'
        /// To get specific columns pass multiple columns name separated by comma along with 'PayerNumber'. E.g. "PayerNumber,ProductCode"
        /// </summary>
        [JsonProperty("ColumnList", NullValueHandling = NullValueHandling.Ignore)]
        public string ColumnList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"RecentTransactionReq : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["AccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetProductCode()
        {
            this.shouldSerialize["ProductCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPurchasedInCountry()
        {
            this.shouldSerialize["PurchasedInCountry"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardPAN()
        {
            this.shouldSerialize["CardPAN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFromDateTime()
        {
            this.shouldSerialize["FromDateTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetToDateTime()
        {
            this.shouldSerialize["ToDateTime"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTransactionStatus()
        {
            this.shouldSerialize["TransactionStatus"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFuelOnly()
        {
            this.shouldSerialize["FuelOnly"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetProductGroupName()
        {
            this.shouldSerialize["ProductGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetVehicleRegistrationNumber()
        {
            this.shouldSerialize["VehicleRegistrationNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIncludeDeclines()
        {
            this.shouldSerialize["IncludeDeclines"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetCardIssuerName()
        {
            this.shouldSerialize["CardIssuerName"] = false;
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
        public bool ShouldSerializeProductCode()
        {
            return this.shouldSerialize["ProductCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchasedInCountry()
        {
            return this.shouldSerialize["PurchasedInCountry"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardPAN()
        {
            return this.shouldSerialize["CardPAN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFromDateTime()
        {
            return this.shouldSerialize["FromDateTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeToDateTime()
        {
            return this.shouldSerialize["ToDateTime"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionStatus()
        {
            return this.shouldSerialize["TransactionStatus"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelOnly()
        {
            return this.shouldSerialize["FuelOnly"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductGroupName()
        {
            return this.shouldSerialize["ProductGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVehicleRegistrationNumber()
        {
            return this.shouldSerialize["VehicleRegistrationNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIncludeDeclines()
        {
            return this.shouldSerialize["IncludeDeclines"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardIssuerName()
        {
            return this.shouldSerialize["CardIssuerName"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is RecentTransactionReq other &&
                (this.ColCoCode == null && other.ColCoCode == null ||
                 this.ColCoCode?.Equals(other.ColCoCode) == true) &&
                (this.PayerNumber == null && other.PayerNumber == null ||
                 this.PayerNumber?.Equals(other.PayerNumber) == true) &&
                (this.AccountNumber == null && other.AccountNumber == null ||
                 this.AccountNumber?.Equals(other.AccountNumber) == true) &&
                (this.ProductCode == null && other.ProductCode == null ||
                 this.ProductCode?.Equals(other.ProductCode) == true) &&
                (this.PurchasedInCountry == null && other.PurchasedInCountry == null ||
                 this.PurchasedInCountry?.Equals(other.PurchasedInCountry) == true) &&
                (this.CardPAN == null && other.CardPAN == null ||
                 this.CardPAN?.Equals(other.CardPAN) == true) &&
                (this.FromDateTime == null && other.FromDateTime == null ||
                 this.FromDateTime?.Equals(other.FromDateTime) == true) &&
                (this.ToDateTime == null && other.ToDateTime == null ||
                 this.ToDateTime?.Equals(other.ToDateTime) == true) &&
                (this.TransactionStatus == null && other.TransactionStatus == null ||
                 this.TransactionStatus?.Equals(other.TransactionStatus) == true) &&
                (this.FuelOnly == null && other.FuelOnly == null ||
                 this.FuelOnly?.Equals(other.FuelOnly) == true) &&
                (this.ProductGroupName == null && other.ProductGroupName == null ||
                 this.ProductGroupName?.Equals(other.ProductGroupName) == true) &&
                (this.VehicleRegistrationNumber == null && other.VehicleRegistrationNumber == null ||
                 this.VehicleRegistrationNumber?.Equals(other.VehicleRegistrationNumber) == true) &&
                (this.IncludeDeclines == null && other.IncludeDeclines == null ||
                 this.IncludeDeclines?.Equals(other.IncludeDeclines) == true) &&
                (this.CardIssuerName == null && other.CardIssuerName == null ||
                 this.CardIssuerName?.Equals(other.CardIssuerName) == true) &&
                (this.ColumnList == null && other.ColumnList == null ||
                 this.ColumnList?.Equals(other.ColumnList) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"PayerNumber = {this.PayerNumber ?? "null"}");
            toStringOutput.Add($"AccountNumber = {this.AccountNumber ?? "null"}");
            toStringOutput.Add($"ProductCode = {this.ProductCode ?? "null"}");
            toStringOutput.Add($"PurchasedInCountry = {this.PurchasedInCountry ?? "null"}");
            toStringOutput.Add($"CardPAN = {this.CardPAN ?? "null"}");
            toStringOutput.Add($"FromDateTime = {this.FromDateTime ?? "null"}");
            toStringOutput.Add($"ToDateTime = {this.ToDateTime ?? "null"}");
            toStringOutput.Add($"TransactionStatus = {this.TransactionStatus ?? "null"}");
            toStringOutput.Add($"FuelOnly = {this.FuelOnly ?? "null"}");
            toStringOutput.Add($"ProductGroupName = {this.ProductGroupName ?? "null"}");
            toStringOutput.Add($"VehicleRegistrationNumber = {this.VehicleRegistrationNumber ?? "null"}");
            toStringOutput.Add($"IncludeDeclines = {(this.IncludeDeclines == null ? "null" : this.IncludeDeclines.ToString())}");
            toStringOutput.Add($"CardIssuerName = {this.CardIssuerName ?? "null"}");
            toStringOutput.Add($"ColumnList = {this.ColumnList ?? "null"}");
        }
    }
}