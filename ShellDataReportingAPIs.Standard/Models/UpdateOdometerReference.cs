// <copyright file="UpdateOdometerReference.cs" company="APIMatic">
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
    /// UpdateOdometerReference.
    /// </summary>
    public class UpdateOdometerReference
    {
        private int? salesItemId;
        private int? updateOdometerReferenceId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "SalesItemId", false },
            { "UpdateOdometerReferenceId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometerReference"/> class.
        /// </summary>
        public UpdateOdometerReference()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOdometerReference"/> class.
        /// </summary>
        /// <param name="salesItemId">SalesItemId.</param>
        /// <param name="updateOdometerReferenceId">UpdateOdometerReferenceId.</param>
        public UpdateOdometerReference(
            int? salesItemId = null,
            int? updateOdometerReferenceId = null)
        {
            if (salesItemId != null)
            {
                this.SalesItemId = salesItemId;
            }

            if (updateOdometerReferenceId != null)
            {
                this.UpdateOdometerReferenceId = updateOdometerReferenceId;
            }

        }

        /// <summary>
        /// SalesItemId of input parameter
        /// </summary>
        [JsonProperty("SalesItemId")]
        public int? SalesItemId
        {
            get
            {
                return this.salesItemId;
            }

            set
            {
                this.shouldSerialize["SalesItemId"] = true;
                this.salesItemId = value;
            }
        }

        /// <summary>
        /// Reference number for each individual update odometer reference.
        /// </summary>
        [JsonProperty("UpdateOdometerReferenceId")]
        public int? UpdateOdometerReferenceId
        {
            get
            {
                return this.updateOdometerReferenceId;
            }

            set
            {
                this.shouldSerialize["UpdateOdometerReferenceId"] = true;
                this.updateOdometerReferenceId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"UpdateOdometerReference : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSalesItemId()
        {
            this.shouldSerialize["SalesItemId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUpdateOdometerReferenceId()
        {
            this.shouldSerialize["UpdateOdometerReferenceId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSalesItemId()
        {
            return this.shouldSerialize["SalesItemId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdateOdometerReferenceId()
        {
            return this.shouldSerialize["UpdateOdometerReferenceId"];
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
            return obj is UpdateOdometerReference other &&                ((this.SalesItemId == null && other.SalesItemId == null) || (this.SalesItemId?.Equals(other.SalesItemId) == true)) &&
                ((this.UpdateOdometerReferenceId == null && other.UpdateOdometerReferenceId == null) || (this.UpdateOdometerReferenceId?.Equals(other.UpdateOdometerReferenceId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SalesItemId = {(this.SalesItemId == null ? "null" : this.SalesItemId.ToString())}");
            toStringOutput.Add($"this.UpdateOdometerReferenceId = {(this.UpdateOdometerReferenceId == null ? "null" : this.UpdateOdometerReferenceId.ToString())}");
        }
    }
}