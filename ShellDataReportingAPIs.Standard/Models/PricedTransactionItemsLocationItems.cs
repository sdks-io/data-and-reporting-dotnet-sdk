// <copyright file="PricedTransactionItemsLocationItems.cs" company="APIMatic">
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
    /// PricedTransactionItemsLocationItems.
    /// </summary>
    public class PricedTransactionItemsLocationItems
    {
        private string latitude;
        private string longitude;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Latitude", false },
            { "Longitude", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransactionItemsLocationItems"/> class.
        /// </summary>
        public PricedTransactionItemsLocationItems()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricedTransactionItemsLocationItems"/> class.
        /// </summary>
        /// <param name="latitude">Latitude.</param>
        /// <param name="longitude">Longitude.</param>
        public PricedTransactionItemsLocationItems(
            string latitude = null,
            string longitude = null)
        {
            if (latitude != null)
            {
                this.Latitude = latitude;
            }

            if (longitude != null)
            {
                this.Longitude = longitude;
            }

        }

        /// <summary>
        /// Latitude for the Site Geographic Location
        /// Example: 37.4224764
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                this.shouldSerialize["Latitude"] = true;
                this.latitude = value;
            }
        }

        /// <summary>
        /// Longitude for the Site Geographic Location
        /// Example: 122.0842499
        /// Note: - The value could be null/blank for fees item.
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                this.shouldSerialize["Longitude"] = true;
                this.longitude = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PricedTransactionItemsLocationItems : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLatitude()
        {
            this.shouldSerialize["Latitude"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLongitude()
        {
            this.shouldSerialize["Longitude"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLatitude()
        {
            return this.shouldSerialize["Latitude"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLongitude()
        {
            return this.shouldSerialize["Longitude"];
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
            return obj is PricedTransactionItemsLocationItems other &&                ((this.Latitude == null && other.Latitude == null) || (this.Latitude?.Equals(other.Latitude) == true)) &&
                ((this.Longitude == null && other.Longitude == null) || (this.Longitude?.Equals(other.Longitude) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Latitude = {(this.Latitude == null ? "null" : this.Latitude)}");
            toStringOutput.Add($"this.Longitude = {(this.Longitude == null ? "null" : this.Longitude)}");
        }
    }
}