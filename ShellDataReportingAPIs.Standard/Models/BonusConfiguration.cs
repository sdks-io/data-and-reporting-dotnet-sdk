// <copyright file="BonusConfiguration.cs" company="APIMatic">
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
    /// BonusConfiguration.
    /// </summary>
    public class BonusConfiguration
    {
        private int? pricingAccountId;
        private string pricingAccountNumber;
        private string pricingAccountShortName;
        private string pricingAccountFullName;
        private int? feeRuleId;
        private string feeRuleDescription;
        private string feeRuleDateEffective;
        private string feeRuleDateTerminated;
        private string bonusPaidTo;
        private int? bonusPaidToAccountId;
        private string bonusPaidToAccountNumber;
        private string bonusPaidToAccountShortName;
        private string bonusPaidToAccountFullName;
        private string frequency;
        private string nextCalculationDate;
        private string previousCalculatedDate;
        private string feeRuleBasis;
        private string feeRuleCurrencyCode;
        private string feeRuleCurrencySymbol;
        private string feeRuleAvailableFrom;
        private string feeRuleAvailableTo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "PricingAccountId", false },
            { "PricingAccountNumber", false },
            { "PricingAccountShortName", false },
            { "PricingAccountFullName", false },
            { "FeeRuleId", false },
            { "FeeRuleDescription", false },
            { "FeeRuleDateEffective", false },
            { "FeeRuleDateTerminated", false },
            { "BonusPaidTo", false },
            { "BonusPaidToAccountId", false },
            { "BonusPaidToAccountNumber", false },
            { "BonusPaidToAccountShortName", false },
            { "BonusPaidToAccountFullName", false },
            { "Frequency", false },
            { "NextCalculationDate", false },
            { "PreviousCalculatedDate", false },
            { "FeeRuleBasis", false },
            { "FeeRuleCurrencyCode", false },
            { "FeeRuleCurrencySymbol", false },
            { "FeeRuleAvailableFrom", false },
            { "FeeRuleAvailableTo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusConfiguration"/> class.
        /// </summary>
        public BonusConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BonusConfiguration"/> class.
        /// </summary>
        /// <param name="pricingAccountId">PricingAccountId.</param>
        /// <param name="pricingAccountNumber">PricingAccountNumber.</param>
        /// <param name="pricingAccountShortName">PricingAccountShortName.</param>
        /// <param name="pricingAccountFullName">PricingAccountFullName.</param>
        /// <param name="feeRuleId">FeeRuleId.</param>
        /// <param name="feeRuleDescription">FeeRuleDescription.</param>
        /// <param name="feeRuleDateEffective">FeeRuleDateEffective.</param>
        /// <param name="feeRuleDateTerminated">FeeRuleDateTerminated.</param>
        /// <param name="bonusPaidTo">BonusPaidTo.</param>
        /// <param name="bonusPaidToAccountId">BonusPaidToAccountId.</param>
        /// <param name="bonusPaidToAccountNumber">BonusPaidToAccountNumber.</param>
        /// <param name="bonusPaidToAccountShortName">BonusPaidToAccountShortName.</param>
        /// <param name="bonusPaidToAccountFullName">BonusPaidToAccountFullName.</param>
        /// <param name="frequency">Frequency.</param>
        /// <param name="nextCalculationDate">NextCalculationDate.</param>
        /// <param name="previousCalculatedDate">PreviousCalculatedDate.</param>
        /// <param name="feeRuleBasis">FeeRuleBasis.</param>
        /// <param name="feeRuleCurrencyCode">FeeRuleCurrencyCode.</param>
        /// <param name="feeRuleCurrencySymbol">FeeRuleCurrencySymbol.</param>
        /// <param name="feeRuleAvailableFrom">FeeRuleAvailableFrom.</param>
        /// <param name="feeRuleAvailableTo">FeeRuleAvailableTo.</param>
        /// <param name="feeRuleLocations">FeeRuleLocations.</param>
        /// <param name="feeRuleTiers">FeeRuleTiers.</param>
        /// <param name="associatedAccounts">AssociatedAccounts.</param>
        /// <param name="feeRuleProducts">FeeRuleProducts.</param>
        public BonusConfiguration(
            int? pricingAccountId = null,
            string pricingAccountNumber = null,
            string pricingAccountShortName = null,
            string pricingAccountFullName = null,
            int? feeRuleId = null,
            string feeRuleDescription = null,
            string feeRuleDateEffective = null,
            string feeRuleDateTerminated = null,
            string bonusPaidTo = null,
            int? bonusPaidToAccountId = null,
            string bonusPaidToAccountNumber = null,
            string bonusPaidToAccountShortName = null,
            string bonusPaidToAccountFullName = null,
            string frequency = null,
            string nextCalculationDate = null,
            string previousCalculatedDate = null,
            string feeRuleBasis = null,
            string feeRuleCurrencyCode = null,
            string feeRuleCurrencySymbol = null,
            string feeRuleAvailableFrom = null,
            string feeRuleAvailableTo = null,
            List<Models.FeeRuleLocation> feeRuleLocations = null,
            List<Models.FeeRuleTier> feeRuleTiers = null,
            List<Models.AssociatedAccount> associatedAccounts = null,
            List<Models.FeeRuleProduct> feeRuleProducts = null)
        {
            if (pricingAccountId != null)
            {
                this.PricingAccountId = pricingAccountId;
            }

            if (pricingAccountNumber != null)
            {
                this.PricingAccountNumber = pricingAccountNumber;
            }

            if (pricingAccountShortName != null)
            {
                this.PricingAccountShortName = pricingAccountShortName;
            }

            if (pricingAccountFullName != null)
            {
                this.PricingAccountFullName = pricingAccountFullName;
            }

            if (feeRuleId != null)
            {
                this.FeeRuleId = feeRuleId;
            }

            if (feeRuleDescription != null)
            {
                this.FeeRuleDescription = feeRuleDescription;
            }

            if (feeRuleDateEffective != null)
            {
                this.FeeRuleDateEffective = feeRuleDateEffective;
            }

            if (feeRuleDateTerminated != null)
            {
                this.FeeRuleDateTerminated = feeRuleDateTerminated;
            }

            if (bonusPaidTo != null)
            {
                this.BonusPaidTo = bonusPaidTo;
            }

            if (bonusPaidToAccountId != null)
            {
                this.BonusPaidToAccountId = bonusPaidToAccountId;
            }

            if (bonusPaidToAccountNumber != null)
            {
                this.BonusPaidToAccountNumber = bonusPaidToAccountNumber;
            }

            if (bonusPaidToAccountShortName != null)
            {
                this.BonusPaidToAccountShortName = bonusPaidToAccountShortName;
            }

            if (bonusPaidToAccountFullName != null)
            {
                this.BonusPaidToAccountFullName = bonusPaidToAccountFullName;
            }

            if (frequency != null)
            {
                this.Frequency = frequency;
            }

            if (nextCalculationDate != null)
            {
                this.NextCalculationDate = nextCalculationDate;
            }

            if (previousCalculatedDate != null)
            {
                this.PreviousCalculatedDate = previousCalculatedDate;
            }

            if (feeRuleBasis != null)
            {
                this.FeeRuleBasis = feeRuleBasis;
            }

            if (feeRuleCurrencyCode != null)
            {
                this.FeeRuleCurrencyCode = feeRuleCurrencyCode;
            }

            if (feeRuleCurrencySymbol != null)
            {
                this.FeeRuleCurrencySymbol = feeRuleCurrencySymbol;
            }

            if (feeRuleAvailableFrom != null)
            {
                this.FeeRuleAvailableFrom = feeRuleAvailableFrom;
            }

            if (feeRuleAvailableTo != null)
            {
                this.FeeRuleAvailableTo = feeRuleAvailableTo;
            }

            this.FeeRuleLocations = feeRuleLocations;
            this.FeeRuleTiers = feeRuleTiers;
            this.AssociatedAccounts = associatedAccounts;
            this.FeeRuleProducts = feeRuleProducts;
        }

        /// <summary>
        /// Account identifier of the Pricing Account associated with the Payer.
        /// </summary>
        [JsonProperty("PricingAccountId")]
        public int? PricingAccountId
        {
            get
            {
                return this.pricingAccountId;
            }

            set
            {
                this.shouldSerialize["PricingAccountId"] = true;
                this.pricingAccountId = value;
            }
        }

        /// <summary>
        /// Account number of the Pricing Account associated with the Payer.
        /// </summary>
        [JsonProperty("PricingAccountNumber")]
        public string PricingAccountNumber
        {
            get
            {
                return this.pricingAccountNumber;
            }

            set
            {
                this.shouldSerialize["PricingAccountNumber"] = true;
                this.pricingAccountNumber = value;
            }
        }

        /// <summary>
        /// Short name of the Pricing Account associated with the Payer.
        /// </summary>
        [JsonProperty("PricingAccountShortName")]
        public string PricingAccountShortName
        {
            get
            {
                return this.pricingAccountShortName;
            }

            set
            {
                this.shouldSerialize["PricingAccountShortName"] = true;
                this.pricingAccountShortName = value;
            }
        }

        /// <summary>
        /// Full name of the Pricing Account associated with the Payer.
        /// </summary>
        [JsonProperty("PricingAccountFullName")]
        public string PricingAccountFullName
        {
            get
            {
                return this.pricingAccountFullName;
            }

            set
            {
                this.shouldSerialize["PricingAccountFullName"] = true;
                this.pricingAccountFullName = value;
            }
        }

        /// <summary>
        /// Bonus or association bonus configuration identifier that is associated to the payer.
        /// </summary>
        [JsonProperty("FeeRuleId")]
        public int? FeeRuleId
        {
            get
            {
                return this.feeRuleId;
            }

            set
            {
                this.shouldSerialize["FeeRuleId"] = true;
                this.feeRuleId = value;
            }
        }

        /// <summary>
        /// Bonus or association bonus configuration description that is associated to the payer.
        /// </summary>
        [JsonProperty("FeeRuleDescription")]
        public string FeeRuleDescription
        {
            get
            {
                return this.feeRuleDescription;
            }

            set
            {
                this.shouldSerialize["FeeRuleDescription"] = true;
                this.feeRuleDescription = value;
            }
        }

        /// <summary>
        /// The bonus or association bonus configuration becomes effective on the payer from this date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("FeeRuleDateEffective")]
        public string FeeRuleDateEffective
        {
            get
            {
                return this.feeRuleDateEffective;
            }

            set
            {
                this.shouldSerialize["FeeRuleDateEffective"] = true;
                this.feeRuleDateEffective = value;
            }
        }

        /// <summary>
        /// The bonus or association bonus configuration is terminated for the payer on this date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("FeeRuleDateTerminated")]
        public string FeeRuleDateTerminated
        {
            get
            {
                return this.feeRuleDateTerminated;
            }

            set
            {
                this.shouldSerialize["FeeRuleDateTerminated"] = true;
                this.feeRuleDateTerminated = value;
            }
        }

        /// <summary>
        /// Configuration to specify how the bonus is paid.
        /// Format: ID-Description
        /// Example:
        /// 1-Pay to Payer
        /// 2-Pay to invoice levels before the payer
        /// 3-Pay to specific customer
        /// 4-Pay to Association Customer
        /// 5-Pay to Associated Customers
        /// </summary>
        [JsonProperty("BonusPaidTo")]
        public string BonusPaidTo
        {
            get
            {
                return this.bonusPaidTo;
            }

            set
            {
                this.shouldSerialize["BonusPaidTo"] = true;
                this.bonusPaidTo = value;
            }
        }

        /// <summary>
        /// Account identifier of the specific account to which the bonus is paid back
        /// </summary>
        [JsonProperty("BonusPaidToAccountId")]
        public int? BonusPaidToAccountId
        {
            get
            {
                return this.bonusPaidToAccountId;
            }

            set
            {
                this.shouldSerialize["BonusPaidToAccountId"] = true;
                this.bonusPaidToAccountId = value;
            }
        }

        /// <summary>
        /// Account number of the specific account to which the bonus is paid back
        /// </summary>
        [JsonProperty("BonusPaidToAccountNumber")]
        public string BonusPaidToAccountNumber
        {
            get
            {
                return this.bonusPaidToAccountNumber;
            }

            set
            {
                this.shouldSerialize["BonusPaidToAccountNumber"] = true;
                this.bonusPaidToAccountNumber = value;
            }
        }

        /// <summary>
        /// Short name of the specific account to which the bonus is paid back
        /// </summary>
        [JsonProperty("BonusPaidToAccountShortName")]
        public string BonusPaidToAccountShortName
        {
            get
            {
                return this.bonusPaidToAccountShortName;
            }

            set
            {
                this.shouldSerialize["BonusPaidToAccountShortName"] = true;
                this.bonusPaidToAccountShortName = value;
            }
        }

        /// <summary>
        /// Full name of the specific account to which the bonus is paid back
        /// </summary>
        [JsonProperty("BonusPaidToAccountFullName")]
        public string BonusPaidToAccountFullName
        {
            get
            {
                return this.bonusPaidToAccountFullName;
            }

            set
            {
                this.shouldSerialize["BonusPaidToAccountFullName"] = true;
                this.bonusPaidToAccountFullName = value;
            }
        }

        /// <summary>
        /// Frequency of the configuration.
        /// Format: ID-Description
        /// Examples:
        /// 1-Daily (all days)
        /// 2-Daily (only working days)
        /// 3-Weekly – Monday
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency
        {
            get
            {
                return this.frequency;
            }

            set
            {
                this.shouldSerialize["Frequency"] = true;
                this.frequency = value;
            }
        }

        /// <summary>
        /// The next bonus is calculated for the payer on this date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("NextCalculationDate")]
        public string NextCalculationDate
        {
            get
            {
                return this.nextCalculationDate;
            }

            set
            {
                this.shouldSerialize["NextCalculationDate"] = true;
                this.nextCalculationDate = value;
            }
        }

        /// <summary>
        /// The previous bonus was calculated for the payer on this date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("PreviousCalculatedDate")]
        public string PreviousCalculatedDate
        {
            get
            {
                return this.previousCalculatedDate;
            }

            set
            {
                this.shouldSerialize["PreviousCalculatedDate"] = true;
                this.previousCalculatedDate = value;
            }
        }

        /// <summary>
        /// Fee Rule Basis configured.
        /// Format: ID-Description
        /// Example:
        /// 1-Currency Per Unit
        /// 2-Percentage of Uplift
        /// 3-Lump Sum
        /// </summary>
        [JsonProperty("FeeRuleBasis")]
        public string FeeRuleBasis
        {
            get
            {
                return this.feeRuleBasis;
            }

            set
            {
                this.shouldSerialize["FeeRuleBasis"] = true;
                this.feeRuleBasis = value;
            }
        }

        /// <summary>
        /// ISO currency code of the currency configured in the Bonus Configuration, if any.
        /// </summary>
        [JsonProperty("FeeRuleCurrencyCode")]
        public string FeeRuleCurrencyCode
        {
            get
            {
                return this.feeRuleCurrencyCode;
            }

            set
            {
                this.shouldSerialize["FeeRuleCurrencyCode"] = true;
                this.feeRuleCurrencyCode = value;
            }
        }

        /// <summary>
        /// Currency symbol of the currency configured in the Bonus Configuration, if any.
        /// </summary>
        [JsonProperty("FeeRuleCurrencySymbol")]
        public string FeeRuleCurrencySymbol
        {
            get
            {
                return this.feeRuleCurrencySymbol;
            }

            set
            {
                this.shouldSerialize["FeeRuleCurrencySymbol"] = true;
                this.feeRuleCurrencySymbol = value;
            }
        }

        /// <summary>
        /// This bonus or association bonus is available from this date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("FeeRuleAvailableFrom")]
        public string FeeRuleAvailableFrom
        {
            get
            {
                return this.feeRuleAvailableFrom;
            }

            set
            {
                this.shouldSerialize["FeeRuleAvailableFrom"] = true;
                this.feeRuleAvailableFrom = value;
            }
        }

        /// <summary>
        /// This bonus or association bonus configuration will not be available from this date.
        /// Format: YYYYMMDD
        /// </summary>
        [JsonProperty("FeeRuleAvailableTo")]
        public string FeeRuleAvailableTo
        {
            get
            {
                return this.feeRuleAvailableTo;
            }

            set
            {
                this.shouldSerialize["FeeRuleAvailableTo"] = true;
                this.feeRuleAvailableTo = value;
            }
        }

        /// <summary>
        /// Gets or sets FeeRuleLocations.
        /// </summary>
        [JsonProperty("FeeRuleLocations", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FeeRuleLocation> FeeRuleLocations { get; set; }

        /// <summary>
        /// Gets or sets FeeRuleTiers.
        /// </summary>
        [JsonProperty("FeeRuleTiers", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FeeRuleTier> FeeRuleTiers { get; set; }

        /// <summary>
        /// Gets or sets AssociatedAccounts.
        /// </summary>
        [JsonProperty("AssociatedAccounts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.AssociatedAccount> AssociatedAccounts { get; set; }

        /// <summary>
        /// Gets or sets FeeRuleProducts.
        /// </summary>
        [JsonProperty("FeeRuleProducts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.FeeRuleProduct> FeeRuleProducts { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BonusConfiguration : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricingAccountId()
        {
            this.shouldSerialize["PricingAccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricingAccountNumber()
        {
            this.shouldSerialize["PricingAccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricingAccountShortName()
        {
            this.shouldSerialize["PricingAccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPricingAccountFullName()
        {
            this.shouldSerialize["PricingAccountFullName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleId()
        {
            this.shouldSerialize["FeeRuleId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleDescription()
        {
            this.shouldSerialize["FeeRuleDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleDateEffective()
        {
            this.shouldSerialize["FeeRuleDateEffective"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleDateTerminated()
        {
            this.shouldSerialize["FeeRuleDateTerminated"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBonusPaidTo()
        {
            this.shouldSerialize["BonusPaidTo"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBonusPaidToAccountId()
        {
            this.shouldSerialize["BonusPaidToAccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBonusPaidToAccountNumber()
        {
            this.shouldSerialize["BonusPaidToAccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBonusPaidToAccountShortName()
        {
            this.shouldSerialize["BonusPaidToAccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBonusPaidToAccountFullName()
        {
            this.shouldSerialize["BonusPaidToAccountFullName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFrequency()
        {
            this.shouldSerialize["Frequency"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNextCalculationDate()
        {
            this.shouldSerialize["NextCalculationDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPreviousCalculatedDate()
        {
            this.shouldSerialize["PreviousCalculatedDate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleBasis()
        {
            this.shouldSerialize["FeeRuleBasis"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleCurrencyCode()
        {
            this.shouldSerialize["FeeRuleCurrencyCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleCurrencySymbol()
        {
            this.shouldSerialize["FeeRuleCurrencySymbol"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleAvailableFrom()
        {
            this.shouldSerialize["FeeRuleAvailableFrom"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFeeRuleAvailableTo()
        {
            this.shouldSerialize["FeeRuleAvailableTo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingAccountId()
        {
            return this.shouldSerialize["PricingAccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingAccountNumber()
        {
            return this.shouldSerialize["PricingAccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingAccountShortName()
        {
            return this.shouldSerialize["PricingAccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricingAccountFullName()
        {
            return this.shouldSerialize["PricingAccountFullName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleId()
        {
            return this.shouldSerialize["FeeRuleId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleDescription()
        {
            return this.shouldSerialize["FeeRuleDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleDateEffective()
        {
            return this.shouldSerialize["FeeRuleDateEffective"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleDateTerminated()
        {
            return this.shouldSerialize["FeeRuleDateTerminated"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBonusPaidTo()
        {
            return this.shouldSerialize["BonusPaidTo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBonusPaidToAccountId()
        {
            return this.shouldSerialize["BonusPaidToAccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBonusPaidToAccountNumber()
        {
            return this.shouldSerialize["BonusPaidToAccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBonusPaidToAccountShortName()
        {
            return this.shouldSerialize["BonusPaidToAccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBonusPaidToAccountFullName()
        {
            return this.shouldSerialize["BonusPaidToAccountFullName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFrequency()
        {
            return this.shouldSerialize["Frequency"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNextCalculationDate()
        {
            return this.shouldSerialize["NextCalculationDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePreviousCalculatedDate()
        {
            return this.shouldSerialize["PreviousCalculatedDate"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleBasis()
        {
            return this.shouldSerialize["FeeRuleBasis"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleCurrencyCode()
        {
            return this.shouldSerialize["FeeRuleCurrencyCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleCurrencySymbol()
        {
            return this.shouldSerialize["FeeRuleCurrencySymbol"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleAvailableFrom()
        {
            return this.shouldSerialize["FeeRuleAvailableFrom"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeeRuleAvailableTo()
        {
            return this.shouldSerialize["FeeRuleAvailableTo"];
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
            return obj is BonusConfiguration other &&                ((this.PricingAccountId == null && other.PricingAccountId == null) || (this.PricingAccountId?.Equals(other.PricingAccountId) == true)) &&
                ((this.PricingAccountNumber == null && other.PricingAccountNumber == null) || (this.PricingAccountNumber?.Equals(other.PricingAccountNumber) == true)) &&
                ((this.PricingAccountShortName == null && other.PricingAccountShortName == null) || (this.PricingAccountShortName?.Equals(other.PricingAccountShortName) == true)) &&
                ((this.PricingAccountFullName == null && other.PricingAccountFullName == null) || (this.PricingAccountFullName?.Equals(other.PricingAccountFullName) == true)) &&
                ((this.FeeRuleId == null && other.FeeRuleId == null) || (this.FeeRuleId?.Equals(other.FeeRuleId) == true)) &&
                ((this.FeeRuleDescription == null && other.FeeRuleDescription == null) || (this.FeeRuleDescription?.Equals(other.FeeRuleDescription) == true)) &&
                ((this.FeeRuleDateEffective == null && other.FeeRuleDateEffective == null) || (this.FeeRuleDateEffective?.Equals(other.FeeRuleDateEffective) == true)) &&
                ((this.FeeRuleDateTerminated == null && other.FeeRuleDateTerminated == null) || (this.FeeRuleDateTerminated?.Equals(other.FeeRuleDateTerminated) == true)) &&
                ((this.BonusPaidTo == null && other.BonusPaidTo == null) || (this.BonusPaidTo?.Equals(other.BonusPaidTo) == true)) &&
                ((this.BonusPaidToAccountId == null && other.BonusPaidToAccountId == null) || (this.BonusPaidToAccountId?.Equals(other.BonusPaidToAccountId) == true)) &&
                ((this.BonusPaidToAccountNumber == null && other.BonusPaidToAccountNumber == null) || (this.BonusPaidToAccountNumber?.Equals(other.BonusPaidToAccountNumber) == true)) &&
                ((this.BonusPaidToAccountShortName == null && other.BonusPaidToAccountShortName == null) || (this.BonusPaidToAccountShortName?.Equals(other.BonusPaidToAccountShortName) == true)) &&
                ((this.BonusPaidToAccountFullName == null && other.BonusPaidToAccountFullName == null) || (this.BonusPaidToAccountFullName?.Equals(other.BonusPaidToAccountFullName) == true)) &&
                ((this.Frequency == null && other.Frequency == null) || (this.Frequency?.Equals(other.Frequency) == true)) &&
                ((this.NextCalculationDate == null && other.NextCalculationDate == null) || (this.NextCalculationDate?.Equals(other.NextCalculationDate) == true)) &&
                ((this.PreviousCalculatedDate == null && other.PreviousCalculatedDate == null) || (this.PreviousCalculatedDate?.Equals(other.PreviousCalculatedDate) == true)) &&
                ((this.FeeRuleBasis == null && other.FeeRuleBasis == null) || (this.FeeRuleBasis?.Equals(other.FeeRuleBasis) == true)) &&
                ((this.FeeRuleCurrencyCode == null && other.FeeRuleCurrencyCode == null) || (this.FeeRuleCurrencyCode?.Equals(other.FeeRuleCurrencyCode) == true)) &&
                ((this.FeeRuleCurrencySymbol == null && other.FeeRuleCurrencySymbol == null) || (this.FeeRuleCurrencySymbol?.Equals(other.FeeRuleCurrencySymbol) == true)) &&
                ((this.FeeRuleAvailableFrom == null && other.FeeRuleAvailableFrom == null) || (this.FeeRuleAvailableFrom?.Equals(other.FeeRuleAvailableFrom) == true)) &&
                ((this.FeeRuleAvailableTo == null && other.FeeRuleAvailableTo == null) || (this.FeeRuleAvailableTo?.Equals(other.FeeRuleAvailableTo) == true)) &&
                ((this.FeeRuleLocations == null && other.FeeRuleLocations == null) || (this.FeeRuleLocations?.Equals(other.FeeRuleLocations) == true)) &&
                ((this.FeeRuleTiers == null && other.FeeRuleTiers == null) || (this.FeeRuleTiers?.Equals(other.FeeRuleTiers) == true)) &&
                ((this.AssociatedAccounts == null && other.AssociatedAccounts == null) || (this.AssociatedAccounts?.Equals(other.AssociatedAccounts) == true)) &&
                ((this.FeeRuleProducts == null && other.FeeRuleProducts == null) || (this.FeeRuleProducts?.Equals(other.FeeRuleProducts) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PricingAccountId = {(this.PricingAccountId == null ? "null" : this.PricingAccountId.ToString())}");
            toStringOutput.Add($"this.PricingAccountNumber = {(this.PricingAccountNumber == null ? "null" : this.PricingAccountNumber)}");
            toStringOutput.Add($"this.PricingAccountShortName = {(this.PricingAccountShortName == null ? "null" : this.PricingAccountShortName)}");
            toStringOutput.Add($"this.PricingAccountFullName = {(this.PricingAccountFullName == null ? "null" : this.PricingAccountFullName)}");
            toStringOutput.Add($"this.FeeRuleId = {(this.FeeRuleId == null ? "null" : this.FeeRuleId.ToString())}");
            toStringOutput.Add($"this.FeeRuleDescription = {(this.FeeRuleDescription == null ? "null" : this.FeeRuleDescription)}");
            toStringOutput.Add($"this.FeeRuleDateEffective = {(this.FeeRuleDateEffective == null ? "null" : this.FeeRuleDateEffective)}");
            toStringOutput.Add($"this.FeeRuleDateTerminated = {(this.FeeRuleDateTerminated == null ? "null" : this.FeeRuleDateTerminated)}");
            toStringOutput.Add($"this.BonusPaidTo = {(this.BonusPaidTo == null ? "null" : this.BonusPaidTo)}");
            toStringOutput.Add($"this.BonusPaidToAccountId = {(this.BonusPaidToAccountId == null ? "null" : this.BonusPaidToAccountId.ToString())}");
            toStringOutput.Add($"this.BonusPaidToAccountNumber = {(this.BonusPaidToAccountNumber == null ? "null" : this.BonusPaidToAccountNumber)}");
            toStringOutput.Add($"this.BonusPaidToAccountShortName = {(this.BonusPaidToAccountShortName == null ? "null" : this.BonusPaidToAccountShortName)}");
            toStringOutput.Add($"this.BonusPaidToAccountFullName = {(this.BonusPaidToAccountFullName == null ? "null" : this.BonusPaidToAccountFullName)}");
            toStringOutput.Add($"this.Frequency = {(this.Frequency == null ? "null" : this.Frequency)}");
            toStringOutput.Add($"this.NextCalculationDate = {(this.NextCalculationDate == null ? "null" : this.NextCalculationDate)}");
            toStringOutput.Add($"this.PreviousCalculatedDate = {(this.PreviousCalculatedDate == null ? "null" : this.PreviousCalculatedDate)}");
            toStringOutput.Add($"this.FeeRuleBasis = {(this.FeeRuleBasis == null ? "null" : this.FeeRuleBasis)}");
            toStringOutput.Add($"this.FeeRuleCurrencyCode = {(this.FeeRuleCurrencyCode == null ? "null" : this.FeeRuleCurrencyCode)}");
            toStringOutput.Add($"this.FeeRuleCurrencySymbol = {(this.FeeRuleCurrencySymbol == null ? "null" : this.FeeRuleCurrencySymbol)}");
            toStringOutput.Add($"this.FeeRuleAvailableFrom = {(this.FeeRuleAvailableFrom == null ? "null" : this.FeeRuleAvailableFrom)}");
            toStringOutput.Add($"this.FeeRuleAvailableTo = {(this.FeeRuleAvailableTo == null ? "null" : this.FeeRuleAvailableTo)}");
            toStringOutput.Add($"this.FeeRuleLocations = {(this.FeeRuleLocations == null ? "null" : $"[{string.Join(", ", this.FeeRuleLocations)} ]")}");
            toStringOutput.Add($"this.FeeRuleTiers = {(this.FeeRuleTiers == null ? "null" : $"[{string.Join(", ", this.FeeRuleTiers)} ]")}");
            toStringOutput.Add($"this.AssociatedAccounts = {(this.AssociatedAccounts == null ? "null" : $"[{string.Join(", ", this.AssociatedAccounts)} ]")}");
            toStringOutput.Add($"this.FeeRuleProducts = {(this.FeeRuleProducts == null ? "null" : $"[{string.Join(", ", this.FeeRuleProducts)} ]")}");
        }
    }
}