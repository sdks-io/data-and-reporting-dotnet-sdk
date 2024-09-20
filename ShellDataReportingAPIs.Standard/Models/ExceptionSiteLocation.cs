// <copyright file="ExceptionSiteLocation.cs" company="APIMatic">
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
    /// ExceptionSiteLocation.
    /// </summary>
    public class ExceptionSiteLocation
    {
        private string lat;
        private string lng;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Lat", false },
            { "Lng", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionSiteLocation"/> class.
        /// </summary>
        public ExceptionSiteLocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionSiteLocation"/> class.
        /// </summary>
        /// <param name="lat">Lat.</param>
        /// <param name="lng">Lng.</param>
        public ExceptionSiteLocation(
            string lat = null,
            string lng = null)
        {
            if (lat != null)
            {
                this.Lat = lat;
            }

            if (lng != null)
            {
                this.Lng = lng;
            }

        }

        /// <summary>
        /// Latitude for the Site Geographic Location
        /// </summary>
        [JsonProperty("Lat")]
        public string Lat
        {
            get
            {
                return this.lat;
            }

            set
            {
                this.shouldSerialize["Lat"] = true;
                this.lat = value;
            }
        }

        /// <summary>
        /// Longitude for the Site Geographic Location
        /// </summary>
        [JsonProperty("Lng")]
        public string Lng
        {
            get
            {
                return this.lng;
            }

            set
            {
                this.shouldSerialize["Lng"] = true;
                this.lng = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExceptionSiteLocation : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLat()
        {
            this.shouldSerialize["Lat"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLng()
        {
            this.shouldSerialize["Lng"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLat()
        {
            return this.shouldSerialize["Lat"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLng()
        {
            return this.shouldSerialize["Lng"];
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
            return obj is ExceptionSiteLocation other &&                ((this.Lat == null && other.Lat == null) || (this.Lat?.Equals(other.Lat) == true)) &&
                ((this.Lng == null && other.Lng == null) || (this.Lng?.Equals(other.Lng) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Lat = {(this.Lat == null ? "null" : this.Lat)}");
            toStringOutput.Add($"this.Lng = {(this.Lng == null ? "null" : this.Lng)}");
        }
    }
}