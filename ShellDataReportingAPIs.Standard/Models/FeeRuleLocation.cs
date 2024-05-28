// <copyright file="FeeRuleLocation.cs" company="APIMatic">
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
    /// FeeRuleLocation.
    /// </summary>
    public class FeeRuleLocation
    {
        private string delcoId;
        private string country;
        private string countryCode;
        private int? fuelNetworkId;
        private string networkName;
        private int? siteGroupId;
        private string siteGroupName;
        private int? siteCode;
        private int? siteId;
        private string siteName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "DelcoId", false },
            { "Country", false },
            { "CountryCode", false },
            { "FuelNetworkId", false },
            { "NetworkName", false },
            { "SiteGroupId", false },
            { "SiteGroupName", false },
            { "SiteCode", false },
            { "SiteId", false },
            { "SiteName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRuleLocation"/> class.
        /// </summary>
        public FeeRuleLocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeeRuleLocation"/> class.
        /// </summary>
        /// <param name="delcoId">DelcoId.</param>
        /// <param name="country">Country.</param>
        /// <param name="countryCode">CountryCode.</param>
        /// <param name="fuelNetworkId">FuelNetworkId.</param>
        /// <param name="networkName">NetworkName.</param>
        /// <param name="siteGroupId">SiteGroupId.</param>
        /// <param name="siteGroupName">SiteGroupName.</param>
        /// <param name="siteCode">SiteCode.</param>
        /// <param name="siteId">SiteId.</param>
        /// <param name="siteName">SiteName.</param>
        public FeeRuleLocation(
            string delcoId = null,
            string country = null,
            string countryCode = null,
            int? fuelNetworkId = null,
            string networkName = null,
            int? siteGroupId = null,
            string siteGroupName = null,
            int? siteCode = null,
            int? siteId = null,
            string siteName = null)
        {
            if (delcoId != null)
            {
                this.DelcoId = delcoId;
            }

            if (country != null)
            {
                this.Country = country;
            }

            if (countryCode != null)
            {
                this.CountryCode = countryCode;
            }

            if (fuelNetworkId != null)
            {
                this.FuelNetworkId = fuelNetworkId;
            }

            if (networkName != null)
            {
                this.NetworkName = networkName;
            }

            if (siteGroupId != null)
            {
                this.SiteGroupId = siteGroupId;
            }

            if (siteGroupName != null)
            {
                this.SiteGroupName = siteGroupName;
            }

            if (siteCode != null)
            {
                this.SiteCode = siteCode;
            }

            if (siteId != null)
            {
                this.SiteId = siteId;
            }

            if (siteName != null)
            {
                this.SiteName = siteName;
            }

        }

        /// <summary>
        /// Delco Identifier.
        /// </summary>
        [JsonProperty("DelcoId")]
        public string DelcoId
        {
            get
            {
                return this.delcoId;
            }

            set
            {
                this.shouldSerialize["DelcoId"] = true;
                this.delcoId = value;
            }
        }

        /// <summary>
        /// Country name.
        /// </summary>
        [JsonProperty("Country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["Country"] = true;
                this.country = value;
            }
        }

        /// <summary>
        /// ISO Code of country.
        /// </summary>
        [JsonProperty("CountryCode")]
        public string CountryCode
        {
            get
            {
                return this.countryCode;
            }

            set
            {
                this.shouldSerialize["CountryCode"] = true;
                this.countryCode = value;
            }
        }

        /// <summary>
        /// Fuel Network Identifier.
        /// </summary>
        [JsonProperty("FuelNetworkId")]
        public int? FuelNetworkId
        {
            get
            {
                return this.fuelNetworkId;
            }

            set
            {
                this.shouldSerialize["FuelNetworkId"] = true;
                this.fuelNetworkId = value;
            }
        }

        /// <summary>
        /// Network Name.
        /// </summary>
        [JsonProperty("NetworkName")]
        public string NetworkName
        {
            get
            {
                return this.networkName;
            }

            set
            {
                this.shouldSerialize["NetworkName"] = true;
                this.networkName = value;
            }
        }

        /// <summary>
        /// Site-Group ID
        /// </summary>
        [JsonProperty("SiteGroupId")]
        public int? SiteGroupId
        {
            get
            {
                return this.siteGroupId;
            }

            set
            {
                this.shouldSerialize["SiteGroupId"] = true;
                this.siteGroupId = value;
            }
        }

        /// <summary>
        /// Site-Group name.
        /// </summary>
        [JsonProperty("SiteGroupName")]
        public string SiteGroupName
        {
            get
            {
                return this.siteGroupName;
            }

            set
            {
                this.shouldSerialize["SiteGroupName"] = true;
                this.siteGroupName = value;
            }
        }

        /// <summary>
        /// Site Code
        /// </summary>
        [JsonProperty("SiteCode")]
        public int? SiteCode
        {
            get
            {
                return this.siteCode;
            }

            set
            {
                this.shouldSerialize["SiteCode"] = true;
                this.siteCode = value;
            }
        }

        /// <summary>
        /// Site Identifier
        /// </summary>
        [JsonProperty("SiteId")]
        public int? SiteId
        {
            get
            {
                return this.siteId;
            }

            set
            {
                this.shouldSerialize["SiteId"] = true;
                this.siteId = value;
            }
        }

        /// <summary>
        /// Site Name
        /// </summary>
        [JsonProperty("SiteName")]
        public string SiteName
        {
            get
            {
                return this.siteName;
            }

            set
            {
                this.shouldSerialize["SiteName"] = true;
                this.siteName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"FeeRuleLocation : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDelcoId()
        {
            this.shouldSerialize["DelcoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["Country"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountryCode()
        {
            this.shouldSerialize["CountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFuelNetworkId()
        {
            this.shouldSerialize["FuelNetworkId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetNetworkName()
        {
            this.shouldSerialize["NetworkName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteGroupId()
        {
            this.shouldSerialize["SiteGroupId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteGroupName()
        {
            this.shouldSerialize["SiteGroupName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteCode()
        {
            this.shouldSerialize["SiteCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteId()
        {
            this.shouldSerialize["SiteId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSiteName()
        {
            this.shouldSerialize["SiteName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDelcoId()
        {
            return this.shouldSerialize["DelcoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["Country"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountryCode()
        {
            return this.shouldSerialize["CountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFuelNetworkId()
        {
            return this.shouldSerialize["FuelNetworkId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNetworkName()
        {
            return this.shouldSerialize["NetworkName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteGroupId()
        {
            return this.shouldSerialize["SiteGroupId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteGroupName()
        {
            return this.shouldSerialize["SiteGroupName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteCode()
        {
            return this.shouldSerialize["SiteCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteId()
        {
            return this.shouldSerialize["SiteId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSiteName()
        {
            return this.shouldSerialize["SiteName"];
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
            return obj is FeeRuleLocation other &&                ((this.DelcoId == null && other.DelcoId == null) || (this.DelcoId?.Equals(other.DelcoId) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true)) &&
                ((this.CountryCode == null && other.CountryCode == null) || (this.CountryCode?.Equals(other.CountryCode) == true)) &&
                ((this.FuelNetworkId == null && other.FuelNetworkId == null) || (this.FuelNetworkId?.Equals(other.FuelNetworkId) == true)) &&
                ((this.NetworkName == null && other.NetworkName == null) || (this.NetworkName?.Equals(other.NetworkName) == true)) &&
                ((this.SiteGroupId == null && other.SiteGroupId == null) || (this.SiteGroupId?.Equals(other.SiteGroupId) == true)) &&
                ((this.SiteGroupName == null && other.SiteGroupName == null) || (this.SiteGroupName?.Equals(other.SiteGroupName) == true)) &&
                ((this.SiteCode == null && other.SiteCode == null) || (this.SiteCode?.Equals(other.SiteCode) == true)) &&
                ((this.SiteId == null && other.SiteId == null) || (this.SiteId?.Equals(other.SiteId) == true)) &&
                ((this.SiteName == null && other.SiteName == null) || (this.SiteName?.Equals(other.SiteName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DelcoId = {(this.DelcoId == null ? "null" : this.DelcoId)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
            toStringOutput.Add($"this.CountryCode = {(this.CountryCode == null ? "null" : this.CountryCode)}");
            toStringOutput.Add($"this.FuelNetworkId = {(this.FuelNetworkId == null ? "null" : this.FuelNetworkId.ToString())}");
            toStringOutput.Add($"this.NetworkName = {(this.NetworkName == null ? "null" : this.NetworkName)}");
            toStringOutput.Add($"this.SiteGroupId = {(this.SiteGroupId == null ? "null" : this.SiteGroupId.ToString())}");
            toStringOutput.Add($"this.SiteGroupName = {(this.SiteGroupName == null ? "null" : this.SiteGroupName)}");
            toStringOutput.Add($"this.SiteCode = {(this.SiteCode == null ? "null" : this.SiteCode.ToString())}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.SiteName = {(this.SiteName == null ? "null" : this.SiteName)}");
        }
    }
}