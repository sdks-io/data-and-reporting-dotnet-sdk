// <copyright file="ExceptionProduct.cs" company="APIMatic">
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
    /// ExceptionProduct.
    /// </summary>
    public class ExceptionProduct
    {
        private int? productid;
        private string productCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "Productid", false },
            { "ProductCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionProduct"/> class.
        /// </summary>
        public ExceptionProduct()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExceptionProduct"/> class.
        /// </summary>
        /// <param name="productid">Productid.</param>
        /// <param name="productCode">ProductCode.</param>
        public ExceptionProduct(
            int? productid = null,
            string productCode = null)
        {
            if (productid != null)
            {
                this.Productid = productid;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

        }

        /// <summary>
        /// Product Id
        /// Optional if ProductCode is passed else Mandatory.
        /// </summary>
        [JsonProperty("Productid")]
        public int? Productid
        {
            get
            {
                return this.productid;
            }

            set
            {
                this.shouldSerialize["Productid"] = true;
                this.productid = value;
            }
        }

        /// <summary>
        /// Product Code
        /// Optional if ProductId is passed else Mandatory.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ExceptionProduct : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductid()
        {
            this.shouldSerialize["Productid"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductCode()
        {
            this.shouldSerialize["ProductCode"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductid()
        {
            return this.shouldSerialize["Productid"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductCode()
        {
            return this.shouldSerialize["ProductCode"];
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
            return obj is ExceptionProduct other &&                ((this.Productid == null && other.Productid == null) || (this.Productid?.Equals(other.Productid) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Productid = {(this.Productid == null ? "null" : this.Productid.ToString())}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
        }
    }
}