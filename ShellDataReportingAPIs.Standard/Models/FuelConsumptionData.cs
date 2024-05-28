// <copyright file="FuelConsumptionData.cs" company="APIMatic">
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
    /// FuelConsumptionData.
    /// </summary>
    public class FuelConsumptionData
    {
        private string accountName;
        private string accountNumber;
        private string payerName;
        private string payerNumber;
        private string cardNumber;
        private int? cardGroupId;
        private string cardGroupName;
        private string driverName;
        private string licenseNumber;
        private double? initialOdometer;
        private double? lastOdometer;
        private double? distance;
        private double? fuelConsumption;
        private double? fuelNetAmount;
        private double? discount;
        private double? fuelTax;
        private double? fuelVolume;
        private double? grossNonFuelExpenses;
        private double? cO2Produced;
        private double? transactionCount;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AccountName", false },
            { "AccountNumber", false },
            { "PayerName", false },
            { "PayerNumber", false },
            { "CardNumber", false },
            { "CardGroupId", false },
            { "CardGroupName", false },
            { "DriverName", false },
            { "LicenseNumber", false },
            { "InitialOdometer", false },
            { "LastOdometer", false },
            { "Distance", false },
            { "FuelConsumption", false },
            { "FuelNetAmount", false },
            { "Discount", false },
            { "FuelTax", false },
            { "FuelVolume", false },
            { "GrossNonFuelExpenses", false },
            { "CO2Produced", false },
            { "TransactionCount", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FuelConsumptionData"/> class.
        /// </summary>
        public FuelConsumptionData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FuelConsumptionData"/> class.
        /// </summary>
        /// <param name="accountName">AccountName.</param>
        /// <param name="accountNumber">AccountNumber.</param>
        /// <param name="payerName">PayerName.</param>
        /// <param name="payerNumber">PayerNumber.</param>
        /// <param name="cardNumber">CardNumber.</param>
        /// <param name="cardGroupId">CardGroupId.</param>
        /// <param name="cardGroupName">CardGroupName.</param>
        /// <param name="driverName">DriverName.</param>
        /// <param name="licenseNumber">LicenseNumber.</param>
        /// <param name="initialOdometer">InitialOdometer.</param>
        /// <param name="lastOdometer">LastOdometer.</param>
        /// <param name="distance">Distance.</param>
        /// <param name="fuelConsumption">FuelConsumption.</param>
        /// <param name="fuelNetAmount">FuelNetAmount.</param>
        /// <param name="discount">Discount.</param>
        /// <param name="fuelTax">FuelTax.</param>
        /// <param name="fuelVolume">FuelVolume.</param>
        /// <param name="grossNonFuelExpenses">GrossNonFuelExpenses.</param>
        /// <param name="cO2Produced">CO2Produced.</param>
        /// <param name="transactionCount">TransactionCount.</param>
        public FuelConsumptionData(
            string accountName = null,
            string accountNumber = null,
            string payerName = null,
            string payerNumber = null,
            string cardNumber = null,
            int? cardGroupId = null,
            string cardGroupName = null,
            string driverName = null,
            string licenseNumber = null,
            double? initialOdometer = null,
            double? lastOdometer = null,
            double? distance = null,
            double? fuelConsumption = null,
            double? fuelNetAmount = null,
            double? discount = null,
            double? fuelTax = null,
            double? fuelVolume = null,
            double? grossNonFuelExpenses = null,
            double? cO2Produced = null,
            double? transactionCount = null)
        {
            if (accountName != null)
            {
                this.AccountName = accountName;
            }

            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (payerName != null)
            {
                this.PayerName = payerName;
            }

            if (payerNumber != null)
            {
                this.PayerNumber = payerNumber;
            }

            if (cardNumber != null)
            {
                this.CardNumber = cardNumber;
            }

            if (cardGroupId != null)
            {
                this.CardGroupId = cardGroupId;
            }

            if (cardGroupName != null)
            {
                this.CardGroupName = cardGroupName;
            }

            if (driverName != null)
            {
                this.DriverName = driverName;
            }

            if (licenseNumber != null)
            {
                this.LicenseNumber = licenseNumber;
            }

            if (initialOdometer != null)
            {
                this.InitialOdometer = initialOdometer;
            }

            if (lastOdometer != null)
            {
                this.LastOdometer = lastOdometer;
            }

            if (distance != null)
            {
                this.Distance = distance;
            }

            if (fuelConsumption != null)
            {
                this.FuelConsumption = fuelConsumption;
            }

            if (fuelNetAmount != null)
            {
                this.FuelNetAmount = fuelNetAmount;
            }

            if (discount != null)
            {
                this.Discount = discount;
            }

            if (fuelTax != null)
            {
                this.FuelTax = fuelTax;
            }

            if (fuelVolume != null)
            {
                this.FuelVolume = fuelVolume;
            }

            if (grossNonFuelExpenses != null)
            {
                this.GrossNonFuelExpenses = grossNonFuelExpenses;
            }

            if (cO2Produced != null)
            {
                this.CO2Produced = cO2Produced;
            }

            if (transactionCount != null)
            {
                this.TransactionCount = transactionCount;
            }

        }

        /// <summary>
        /// Account Name
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName
        {
            get
            {
                return this.accountName;
            }

            set
            {
                this.shouldSerialize["AccountName"] = true;
                this.accountName = value;
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
        /// Payment customer Name
        /// </summary>
        [JsonProperty("PayerName")]
        public string PayerName
        {
            get
            {
                return this.payerName;
            }

            set
            {
                this.shouldSerialize["PayerName"] = true;
                this.payerName = value;
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
        /// Card PAN
        /// </summary>
        [JsonProperty("CardNumber")]
        public string CardNumber
        {
            get
            {
                return this.cardNumber;
            }

            set
            {
                this.shouldSerialize["CardNumber"] = true;
                this.cardNumber = value;
            }
        }

        /// <summary>
        /// Card group ID
        /// </summary>
        [JsonProperty("CardGroupId")]
        public int? CardGroupId
        {
            get
            {
                return this.cardGroupId;
            }

            set
            {
                this.shouldSerialize["CardGroupId"] = true;
                this.cardGroupId = value;
            }
        }

        /// <summary>
        /// Card group name
        /// </summary>
        [JsonProperty("CardGroupName")]
        public string CardGroupName
        {
            get
            {
                return this.cardGroupName;
            }

            set
            {
                this.shouldSerialize["CardGroupName"] = true;
                this.cardGroupName = value;
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
        /// Vehicle registration number
        /// </summary>
        [JsonProperty("LicenseNumber")]
        public string LicenseNumber
        {
            get
            {
                return this.licenseNumber;
            }

            set
            {
                this.shouldSerialize["LicenseNumber"] = true;
                this.licenseNumber = value;
            }
        }

        /// <summary>
        /// First transaction odometer reading
        /// </summary>
        [JsonProperty("InitialOdometer")]
        public double? InitialOdometer
        {
            get
            {
                return this.initialOdometer;
            }

            set
            {
                this.shouldSerialize["InitialOdometer"] = true;
                this.initialOdometer = value;
            }
        }

        /// <summary>
        /// Last transaction odometer reading
        /// </summary>
        [JsonProperty("LastOdometer")]
        public double? LastOdometer
        {
            get
            {
                return this.lastOdometer;
            }

            set
            {
                this.shouldSerialize["LastOdometer"] = true;
                this.lastOdometer = value;
            }
        }

        /// <summary>
        /// Distance in  KM or Miles based on Customer and Colco Settings
        /// </summary>
        [JsonProperty("Distance")]
        public double? Distance
        {
            get
            {
                return this.distance;
            }

            set
            {
                this.shouldSerialize["Distance"] = true;
                this.distance = value;
            }
        }

        /// <summary>
        /// Total Fuel Consumption.
        /// </summary>
        [JsonProperty("FuelConsumption")]
        public double? FuelConsumption
        {
            get
            {
                return this.fuelConsumption;
            }

            set
            {
                this.shouldSerialize["FuelConsumption"] = true;
                this.fuelConsumption = value;
            }
        }

        /// <summary>
        /// Net Fuel Amount
        /// </summary>
        [JsonProperty("FuelNetAmount")]
        public double? FuelNetAmount
        {
            get
            {
                return this.fuelNetAmount;
            }

            set
            {
                this.shouldSerialize["FuelNetAmount"] = true;
                this.fuelNetAmount = value;
            }
        }

        /// <summary>
        /// Total Discount
        /// </summary>
        [JsonProperty("Discount")]
        public double? Discount
        {
            get
            {
                return this.discount;
            }

            set
            {
                this.shouldSerialize["Discount"] = true;
                this.discount = value;
            }
        }

        /// <summary>
        /// Fuel Tax Amount
        /// </summary>
        [JsonProperty("FuelTax")]
        public double? FuelTax
        {
            get
            {
                return this.fuelTax;
            }

            set
            {
                this.shouldSerialize["FuelTax"] = true;
                this.fuelTax = value;
            }
        }

        /// <summary>
        /// Total Fuel Volume in Litres
        /// </summary>
        [JsonProperty("FuelVolume")]
        public double? FuelVolume
        {
            get
            {
                return this.fuelVolume;
            }

            set
            {
                this.shouldSerialize["FuelVolume"] = true;
                this.fuelVolume = value;
            }
        }

        /// <summary>
        /// Gross Nonfuel Amount
        /// </summary>
        [JsonProperty("GrossNonFuelExpenses")]
        public double? GrossNonFuelExpenses
        {
            get
            {
                return this.grossNonFuelExpenses;
            }

            set
            {
                this.shouldSerialize["GrossNonFuelExpenses"] = true;
                this.grossNonFuelExpenses = value;
            }
        }

        /// <summary>
        /// Total Co2 produced
        /// </summary>
        [JsonProperty("CO2Produced")]
        public double? CO2Produced
        {
            get
            {
                return this.cO2Produced;
            }

            set
            {
                this.shouldSerialize["CO2Produced"] = true;
                this.cO2Produced = value;
            }
        }

        /// <summary>
        /// Total Transaction Count
        /// </summary>
        [JsonProperty("TransactionCount")]
        public double? TransactionCount
        {
            get
            {
                return this.transactionCount;
            }

            set
            {
                this.shouldSerialize["TransactionCount"] = true;
                this.transactionCount = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FuelConsumptionData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountName()
        {
            this.shouldSerialize["AccountName"] = false;
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
        public void UnsetPayerName()
        {
            this.shouldSerialize["PayerName"] = false;
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
        public void UnsetCardNumber()
        {
            this.shouldSerialize["CardNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupId()
        {
            this.shouldSerialize["CardGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardGroupName()
        {
            this.shouldSerialize["CardGroupName"] = false;
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
        public void UnsetLicenseNumber()
        {
            this.shouldSerialize["LicenseNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInitialOdometer()
        {
            this.shouldSerialize["InitialOdometer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastOdometer()
        {
            this.shouldSerialize["LastOdometer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDistance()
        {
            this.shouldSerialize["Distance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelConsumption()
        {
            this.shouldSerialize["FuelConsumption"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelNetAmount()
        {
            this.shouldSerialize["FuelNetAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDiscount()
        {
            this.shouldSerialize["Discount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelTax()
        {
            this.shouldSerialize["FuelTax"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelVolume()
        {
            this.shouldSerialize["FuelVolume"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetGrossNonFuelExpenses()
        {
            this.shouldSerialize["GrossNonFuelExpenses"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCO2Produced()
        {
            this.shouldSerialize["CO2Produced"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionCount()
        {
            this.shouldSerialize["TransactionCount"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountName()
        {
            return this.shouldSerialize["AccountName"];
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
        public bool ShouldSerializePayerName()
        {
            return this.shouldSerialize["PayerName"];
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
        public bool ShouldSerializeCardNumber()
        {
            return this.shouldSerialize["CardNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupId()
        {
            return this.shouldSerialize["CardGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardGroupName()
        {
            return this.shouldSerialize["CardGroupName"];
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
        public bool ShouldSerializeLicenseNumber()
        {
            return this.shouldSerialize["LicenseNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInitialOdometer()
        {
            return this.shouldSerialize["InitialOdometer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastOdometer()
        {
            return this.shouldSerialize["LastOdometer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDistance()
        {
            return this.shouldSerialize["Distance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelConsumption()
        {
            return this.shouldSerialize["FuelConsumption"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelNetAmount()
        {
            return this.shouldSerialize["FuelNetAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDiscount()
        {
            return this.shouldSerialize["Discount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelTax()
        {
            return this.shouldSerialize["FuelTax"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelVolume()
        {
            return this.shouldSerialize["FuelVolume"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeGrossNonFuelExpenses()
        {
            return this.shouldSerialize["GrossNonFuelExpenses"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCO2Produced()
        {
            return this.shouldSerialize["CO2Produced"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionCount()
        {
            return this.shouldSerialize["TransactionCount"];
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
            return obj is FuelConsumptionData other &&                ((this.AccountName == null && other.AccountName == null) || (this.AccountName?.Equals(other.AccountName) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.PayerName == null && other.PayerName == null) || (this.PayerName?.Equals(other.PayerName) == true)) &&
                ((this.PayerNumber == null && other.PayerNumber == null) || (this.PayerNumber?.Equals(other.PayerNumber) == true)) &&
                ((this.CardNumber == null && other.CardNumber == null) || (this.CardNumber?.Equals(other.CardNumber) == true)) &&
                ((this.CardGroupId == null && other.CardGroupId == null) || (this.CardGroupId?.Equals(other.CardGroupId) == true)) &&
                ((this.CardGroupName == null && other.CardGroupName == null) || (this.CardGroupName?.Equals(other.CardGroupName) == true)) &&
                ((this.DriverName == null && other.DriverName == null) || (this.DriverName?.Equals(other.DriverName) == true)) &&
                ((this.LicenseNumber == null && other.LicenseNumber == null) || (this.LicenseNumber?.Equals(other.LicenseNumber) == true)) &&
                ((this.InitialOdometer == null && other.InitialOdometer == null) || (this.InitialOdometer?.Equals(other.InitialOdometer) == true)) &&
                ((this.LastOdometer == null && other.LastOdometer == null) || (this.LastOdometer?.Equals(other.LastOdometer) == true)) &&
                ((this.Distance == null && other.Distance == null) || (this.Distance?.Equals(other.Distance) == true)) &&
                ((this.FuelConsumption == null && other.FuelConsumption == null) || (this.FuelConsumption?.Equals(other.FuelConsumption) == true)) &&
                ((this.FuelNetAmount == null && other.FuelNetAmount == null) || (this.FuelNetAmount?.Equals(other.FuelNetAmount) == true)) &&
                ((this.Discount == null && other.Discount == null) || (this.Discount?.Equals(other.Discount) == true)) &&
                ((this.FuelTax == null && other.FuelTax == null) || (this.FuelTax?.Equals(other.FuelTax) == true)) &&
                ((this.FuelVolume == null && other.FuelVolume == null) || (this.FuelVolume?.Equals(other.FuelVolume) == true)) &&
                ((this.GrossNonFuelExpenses == null && other.GrossNonFuelExpenses == null) || (this.GrossNonFuelExpenses?.Equals(other.GrossNonFuelExpenses) == true)) &&
                ((this.CO2Produced == null && other.CO2Produced == null) || (this.CO2Produced?.Equals(other.CO2Produced) == true)) &&
                ((this.TransactionCount == null && other.TransactionCount == null) || (this.TransactionCount?.Equals(other.TransactionCount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountName = {(this.AccountName == null ? "null" : this.AccountName)}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.PayerName = {(this.PayerName == null ? "null" : this.PayerName)}");
            toStringOutput.Add($"this.PayerNumber = {(this.PayerNumber == null ? "null" : this.PayerNumber)}");
            toStringOutput.Add($"this.CardNumber = {(this.CardNumber == null ? "null" : this.CardNumber)}");
            toStringOutput.Add($"this.CardGroupId = {(this.CardGroupId == null ? "null" : this.CardGroupId.ToString())}");
            toStringOutput.Add($"this.CardGroupName = {(this.CardGroupName == null ? "null" : this.CardGroupName)}");
            toStringOutput.Add($"this.DriverName = {(this.DriverName == null ? "null" : this.DriverName)}");
            toStringOutput.Add($"this.LicenseNumber = {(this.LicenseNumber == null ? "null" : this.LicenseNumber)}");
            toStringOutput.Add($"this.InitialOdometer = {(this.InitialOdometer == null ? "null" : this.InitialOdometer.ToString())}");
            toStringOutput.Add($"this.LastOdometer = {(this.LastOdometer == null ? "null" : this.LastOdometer.ToString())}");
            toStringOutput.Add($"this.Distance = {(this.Distance == null ? "null" : this.Distance.ToString())}");
            toStringOutput.Add($"this.FuelConsumption = {(this.FuelConsumption == null ? "null" : this.FuelConsumption.ToString())}");
            toStringOutput.Add($"this.FuelNetAmount = {(this.FuelNetAmount == null ? "null" : this.FuelNetAmount.ToString())}");
            toStringOutput.Add($"this.Discount = {(this.Discount == null ? "null" : this.Discount.ToString())}");
            toStringOutput.Add($"this.FuelTax = {(this.FuelTax == null ? "null" : this.FuelTax.ToString())}");
            toStringOutput.Add($"this.FuelVolume = {(this.FuelVolume == null ? "null" : this.FuelVolume.ToString())}");
            toStringOutput.Add($"this.GrossNonFuelExpenses = {(this.GrossNonFuelExpenses == null ? "null" : this.GrossNonFuelExpenses.ToString())}");
            toStringOutput.Add($"this.CO2Produced = {(this.CO2Produced == null ? "null" : this.CO2Produced.ToString())}");
            toStringOutput.Add($"this.TransactionCount = {(this.TransactionCount == null ? "null" : this.TransactionCount.ToString())}");
        }
    }
}