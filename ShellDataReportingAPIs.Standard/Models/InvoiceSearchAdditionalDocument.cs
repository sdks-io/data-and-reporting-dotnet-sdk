// <copyright file="InvoiceSearchAdditionalDocument.cs" company="APIMatic">
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
    /// InvoiceSearchAdditionalDocument.
    /// </summary>
    public class InvoiceSearchAdditionalDocument
    {
        private string reference;
        private string type;
        private string isApplicable;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Reference", false },
            { "Type", false },
            { "IsApplicable", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchAdditionalDocument"/> class.
        /// </summary>
        public InvoiceSearchAdditionalDocument()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSearchAdditionalDocument"/> class.
        /// </summary>
        /// <param name="reference">Reference.</param>
        /// <param name="type">Type.</param>
        /// <param name="isApplicable">IsApplicable.</param>
        public InvoiceSearchAdditionalDocument(
            string reference = null,
            string type = null,
            string isApplicable = null)
        {
            if (reference != null)
            {
                this.Reference = reference;
            }

            if (type != null)
            {
                this.Type = type;
            }

            if (isApplicable != null)
            {
                this.IsApplicable = isApplicable;
            }

        }

        /// <summary>
        /// Unique ID for the additional invoice document.
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference
        {
            get
            {
                return this.reference;
            }

            set
            {
                this.shouldSerialize["Reference"] = true;
                this.reference = value;
            }
        }

        /// <summary>
        /// Type of the additional document.
        /// Mandatory
        /// Possible values:
        /// •    KSeF - Applicable for Poland market.
        /// </summary>
        [JsonProperty("Type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["Type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// True if a KSeF PDF will be produced for the customer.
        /// </summary>
        [JsonProperty("IsApplicable")]
        public string IsApplicable
        {
            get
            {
                return this.isApplicable;
            }

            set
            {
                this.shouldSerialize["IsApplicable"] = true;
                this.isApplicable = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceSearchAdditionalDocument : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReference()
        {
            this.shouldSerialize["Reference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["Type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsApplicable()
        {
            this.shouldSerialize["IsApplicable"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReference()
        {
            return this.shouldSerialize["Reference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["Type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsApplicable()
        {
            return this.shouldSerialize["IsApplicable"];
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
            return obj is InvoiceSearchAdditionalDocument other &&                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.IsApplicable == null && other.IsApplicable == null) || (this.IsApplicable?.Equals(other.IsApplicable) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.IsApplicable = {(this.IsApplicable == null ? "null" : this.IsApplicable)}");
        }
    }
}