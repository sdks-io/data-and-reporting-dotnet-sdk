// <copyright file="CardExceptions.cs" company="APIMatic">
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
    /// CardExceptions.
    /// </summary>
    public class CardExceptions
    {
        private int? accountId;
        private string accountNumber;
        private string accountShortName;
        private int? cardId;
        private string currencyCode;
        private string currencySymbol;
        private int? day;
        private string driverName;
        private int? month;
        private string pAN;
        private int? payerId;
        private string payerNumber;
        private string payerShortName;
        private double? totalAmount;
        private int? totalQuantity;
        private int? totalSalesItems;
        private int? totalTransactions;
        private string vRN;
        private int? week;
        private int? year;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountId", false },
            { "AccountNumber", false },
            { "AccountShortName", false },
            { "CardId", false },
            { "CurrencyCode", false },
            { "CurrencySymbol", false },
            { "Day", false },
            { "DriverName", false },
            { "Month", false },
            { "PAN", false },
            { "PayerId", false },
            { "PayerNumber", false },
            { "PayerShortName", false },
            { "TotalAmount", false },
            { "TotalQuantity", false },
            { "TotalSalesItems", false },
            { "TotalTransactions", false },
            { "VRN", false },
            { "Week", false },
            { "Year", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardExceptions"/> class.
        /// </summary>
        public CardExceptions()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardExceptions"/> class.
        /// </summary>
        /// <param name="accountId">AccountId.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="accountShortName">AccountShortName.</param>
        /// <param name="cardId">CardId.</param>
        /// <param name="currencyCode">CurrencyCode.</param>
        /// <param name="currencySymbol">CurrencySymbol.</param>
        /// <param name="day">Day.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="month">Month.</param>
        /// <param name="pAN">PAN.</param>
        /// <param name="payerId">PayerId.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="payerShortName">PayerShortName.</param>
        /// <param name="totalAmount">TotalAmount.</param>
        /// <param name="totalQuantity">TotalQuantity.</param>
        /// <param name="totalSalesItems">TotalSalesItems.</param>
        /// <param name="totalTransactions">TotalTransactions.</param>
        /// <param name="vRN">VRN.</param>
        /// <param name="week">Week.</param>
        /// <param name="year">Year.</param>
        public CardExceptions(
            int? accountId = null,
            string accountNumber = null,
            string accountShortName = null,
            int? cardId = null,
            string currencyCode = null,
            string currencySymbol = null,
            int? day = null,
            string driverName = null,
            int? month = null,
            string pAN = null,
            int? payerId = null,
            string payerNumber = null,
            string payerShortName = null,
            double? totalAmount = null,
            int? totalQuantity = null,
            int? totalSalesItems = null,
            int? totalTransactions = null,
            string vRN = null,
            int? week = null,
            int? year = null)
        {
            if (accountId != null)
            {
                this.AccountId = accountId;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (accountShortName != null)
            {
                this.AccountShortName = accountShortName;
            }

            if (cardId != null)
            {
                this.CardId = cardId;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

            if (currencySymbol != null)
            {
                this.CurrencySymbol = currencySymbol;
            }

            if (day != null)
            {
                this.Day = day;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (month != null)
            {
                this.Month = month;
            }

            if (pAN != null)
            {
                this.PAN = pAN;
            }

            if (payerId != null)
            {
                this.PayerId = payerId;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (payerShortName != null)
            {
                this.PayerShortName = payerShortName;
            }

            if (totalAmount != null)
            {
                this.TotalAmount = totalAmount;
            }

            if (totalQuantity != null)
            {
                this.TotalQuantity = totalQuantity;
            }

            if (totalSalesItems != null)
            {
                this.TotalSalesItems = totalSalesItems;
            }

            if (totalTransactions != null)
            {
                this.TotalTransactions = totalTransactions;
            }

            if (vRN != null)
            {
                this.VRN = vRN;
            }

            if (week != null)
            {
                this.Week = week;
            }

            if (year != null)
            {
                this.Year = year;
            }

        }

        /// <summary>
        /// Account Id
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
        /// Account Number
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
        /// Account Short Name
        /// </summary>
        [JsonProperty("AccountShortName")]
        public string AccountShortName
        {
            get
            {
                return this.accountShortName;
            }

            set
            {
                this.shouldSerialize["AccountShortName"] = true;
                this.accountShortName = value;
            }
        }

        /// <summary>
        /// Unique Card Id
        /// </summary>
        [JsonProperty("CardId")]
        public int? CardId
        {
            get
            {
                return this.cardId;
            }

            set
            {
                this.shouldSerialize["CardId"] = true;
                this.cardId = value;
            }
        }

        /// <summary>
        /// ISO currency code
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
        /// Currency symbol of the Invoice Currency Code
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
        /// Summary Day: Populated when the Period is passed as ‘Day’.
        /// </summary>
        [JsonProperty("Day")]
        public int? Day
        {
            get
            {
                return this.day;
            }

            set
            {
                this.shouldSerialize["Day"] = true;
                this.day = value;
            }
        }

        /// <summary>
        /// Driver name
        /// </summary>
        [JsonProperty("DriverName")]
        public string DriverName
        {
            get
            {
                return this.driverName;
            }

            set
            {
                this.shouldSerialize["DriverName"] = true;
                this.driverName = value;
            }
        }

        /// <summary>
        /// Summary Month: Populated when the Value of Period is Passed as ‘Month’.
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
        /// Card PAN
        /// </summary>
        [JsonProperty("PAN")]
        public string PAN
        {
            get
            {
                return this.pAN;
            }

            set
            {
                this.shouldSerialize["PAN"] = true;
                this.pAN = value;
            }
        }

        /// <summary>
        /// Payment customer id of the customer
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
        /// Payment customer number
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
        /// Payer Short Name
        /// </summary>
        [JsonProperty("PayerShortName")]
        public string PayerShortName
        {
            get
            {
                return this.payerShortName;
            }

            set
            {
                this.shouldSerialize["PayerShortName"] = true;
                this.payerShortName = value;
            }
        }

        /// <summary>
        /// Total Amount (In Customer Currency) of Transactions met with the given exceptions criteria.
        /// </summary>
        [JsonProperty("TotalAmount")]
        public double? TotalAmount
        {
            get
            {
                return this.totalAmount;
            }

            set
            {
                this.shouldSerialize["TotalAmount"] = true;
                this.totalAmount = value;
            }
        }

        /// <summary>
        /// Total Quantity of Transactions met with the given exceptions criteria.
        /// </summary>
        [JsonProperty("TotalQuantity")]
        public int? TotalQuantity
        {
            get
            {
                return this.totalQuantity;
            }

            set
            {
                this.shouldSerialize["TotalQuantity"] = true;
                this.totalQuantity = value;
            }
        }

        /// <summary>
        /// Total number of Sales Items met with the given exception criteria.
        /// </summary>
        [JsonProperty("TotalSalesItems")]
        public int? TotalSalesItems
        {
            get
            {
                return this.totalSalesItems;
            }

            set
            {
                this.shouldSerialize["TotalSalesItems"] = true;
                this.totalSalesItems = value;
            }
        }

        /// <summary>
        /// Total number of Transactions met with the given exception criteria.
        /// </summary>
        [JsonProperty("TotalTransactions")]
        public int? TotalTransactions
        {
            get
            {
                return this.totalTransactions;
            }

            set
            {
                this.shouldSerialize["TotalTransactions"] = true;
                this.totalTransactions = value;
            }
        }

        /// <summary>
        /// Vehicle Registration Number
        /// </summary>
        [JsonProperty("VRN")]
        public string VRN
        {
            get
            {
                return this.vRN;
            }

            set
            {
                this.shouldSerialize["VRN"] = true;
                this.vRN = value;
            }
        }

        /// <summary>
        /// Summary Week Number with in the given date range. Populated when the Value of Period is Passed as ‘Week’.
        /// </summary>
        [JsonProperty("Week")]
        public int? Week
        {
            get
            {
                return this.week;
            }

            set
            {
                this.shouldSerialize["Week"] = true;
                this.week = value;
            }
        }

        /// <summary>
        /// Summary Year: Populated when the Value of Period is Passed as ‘Month’.
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

            return $"CardExceptions : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAccountShortName()
        {
            this.shouldSerialize["AccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardId()
        {
            this.shouldSerialize["CardId"] = false;
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
        public void UnsetDay()
        {
            this.shouldSerialize["Day"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDriverName()
        {
            this.shouldSerialize["DriverName"] = false;
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
        public void UnsetPAN()
        {
            this.shouldSerialize["PAN"] = false;
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
        public void UnsetPayerShortName()
        {
            this.shouldSerialize["PayerShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalAmount()
        {
            this.shouldSerialize["TotalAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalQuantity()
        {
            this.shouldSerialize["TotalQuantity"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalSalesItems()
        {
            this.shouldSerialize["TotalSalesItems"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTotalTransactions()
        {
            this.shouldSerialize["TotalTransactions"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetVRN()
        {
            this.shouldSerialize["VRN"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWeek()
        {
            this.shouldSerialize["Week"] = false;
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
        public bool ShouldSerializeAccountShortName()
        {
            return this.shouldSerialize["AccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardId()
        {
            return this.shouldSerialize["CardId"];
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
        public bool ShouldSerializeDay()
        {
            return this.shouldSerialize["Day"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDriverName()
        {
            return this.shouldSerialize["DriverName"];
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
        public bool ShouldSerializePAN()
        {
            return this.shouldSerialize["PAN"];
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
        public bool ShouldSerializePayerShortName()
        {
            return this.shouldSerialize["PayerShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalAmount()
        {
            return this.shouldSerialize["TotalAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalQuantity()
        {
            return this.shouldSerialize["TotalQuantity"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalSalesItems()
        {
            return this.shouldSerialize["TotalSalesItems"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTotalTransactions()
        {
            return this.shouldSerialize["TotalTransactions"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeVRN()
        {
            return this.shouldSerialize["VRN"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWeek()
        {
            return this.shouldSerialize["Week"];
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
            return obj is CardExceptions other &&                ((this.AccountId == null && other.AccountId == null) || (this.AccountId?.Equals(other.AccountId) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.AccountShortName == null && other.AccountShortName == null) || (this.AccountShortName?.Equals(other.AccountShortName) == true)) &&
                ((this.CardId == null && other.CardId == null) || (this.CardId?.Equals(other.CardId) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true)) &&
                ((this.CurrencySymbol == null && other.CurrencySymbol == null) || (this.CurrencySymbol?.Equals(other.CurrencySymbol) == true)) &&
                ((this.Day == null && other.Day == null) || (this.Day?.Equals(other.Day) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.Month == null && other.Month == null) || (this.Month?.Equals(other.Month) == true)) &&
                ((this.PAN == null && other.PAN == null) || (this.PAN?.Equals(other.PAN) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.PayerShortName == null && other.PayerShortName == null) || (this.PayerShortName?.Equals(other.PayerShortName) == true)) &&
                ((this.TotalAmount == null && other.TotalAmount == null) || (this.TotalAmount?.Equals(other.TotalAmount) == true)) &&
                ((this.TotalQuantity == null && other.TotalQuantity == null) || (this.TotalQuantity?.Equals(other.TotalQuantity) == true)) &&
                ((this.TotalSalesItems == null && other.TotalSalesItems == null) || (this.TotalSalesItems?.Equals(other.TotalSalesItems) == true)) &&
                ((this.TotalTransactions == null && other.TotalTransactions == null) || (this.TotalTransactions?.Equals(other.TotalTransactions) == true)) &&
                ((this.VRN == null && other.VRN == null) || (this.VRN?.Equals(other.VRN) == true)) &&
                ((this.Week == null && other.Week == null) || (this.Week?.Equals(other.Week) == true)) &&
                ((this.Year == null && other.Year == null) || (this.Year?.Equals(other.Year) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountId = {(this.AccountId == null ? "null" : this.AccountId.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.AccountShortName = {(this.AccountShortName == null ? "null" : this.AccountShortName)}");
            toStringOutput.Add($"this.CardId = {(this.CardId == null ? "null" : this.CardId.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode)}");
            toStringOutput.Add($"this.CurrencySymbol = {(this.CurrencySymbol == null ? "null" : this.CurrencySymbol)}");
            toStringOutput.Add($"this.Day = {(this.Day == null ? "null" : this.Day.ToString())}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.Month = {(this.Month == null ? "null" : this.Month.ToString())}");
            toStringOutput.Add($"this.PAN = {(this.PAN == null ? "null" : this.PAN)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId.ToString())}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.PayerShortName = {(this.PayerShortName == null ? "null" : this.PayerShortName)}");
            toStringOutput.Add($"this.TotalAmount = {(this.TotalAmount == null ? "null" : this.TotalAmount.ToString())}");
            toStringOutput.Add($"this.TotalQuantity = {(this.TotalQuantity == null ? "null" : this.TotalQuantity.ToString())}");
            toStringOutput.Add($"this.TotalSalesItems = {(this.TotalSalesItems == null ? "null" : this.TotalSalesItems.ToString())}");
            toStringOutput.Add($"this.TotalTransactions = {(this.TotalTransactions == null ? "null" : this.TotalTransactions.ToString())}");
            toStringOutput.Add($"this.VRN = {(this.VRN == null ? "null" : this.VRN)}");
            toStringOutput.Add($"this.Week = {(this.Week == null ? "null" : this.Week.ToString())}");
            toStringOutput.Add($"this.Year = {(this.Year == null ? "null" : this.Year.ToString())}");
        }
    }
}