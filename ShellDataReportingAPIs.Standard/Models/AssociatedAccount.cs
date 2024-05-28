// <copyright file="AssociatedAccount.cs" company="APIMatic">
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
    /// AssociatedAccount.
    /// </summary>
    public class AssociatedAccount
    {
        private int? associatedAccountId;
        private string associatedAccountNumber;
        private string associatedAccountShortName;
        private string associatedAccountFullName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "AssociatedAccountId", false },
            { "AssociatedAccountNumber", false },
            { "AssociatedAccountShortName", false },
            { "AssociatedAccountFullName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedAccount"/> class.
        /// </summary>
        public AssociatedAccount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssociatedAccount"/> class.
        /// </summary>
        /// <param name="associatedAccountId">AssociatedAccountId.</param>
        /// <param name="associatedAccountNumber">AssociatedAccountNumber.</param>
        /// <param name="associatedAccountShortName">AssociatedAccountShortName.</param>
        /// <param name="associatedAccountFullName">AssociatedAccountFullName.</param>
        public AssociatedAccount(
            int? associatedAccountId = null,
            string associatedAccountNumber = null,
            string associatedAccountShortName = null,
            string associatedAccountFullName = null)
        {
            if (associatedAccountId != null)
            {
                this.AssociatedAccountId = associatedAccountId;
            }

            if (associatedAccountNumber != null)
            {
                this.AssociatedAccountNumber = associatedAccountNumber;
            }

            if (associatedAccountShortName != null)
            {
                this.AssociatedAccountShortName = associatedAccountShortName;
            }

            if (associatedAccountFullName != null)
            {
                this.AssociatedAccountFullName = associatedAccountFullName;
            }

        }

        /// <summary>
        /// Account identifier  of the Associated Account associated with the Payer.
        /// </summary>
        [JsonProperty("AssociatedAccountId")]
        public int? AssociatedAccountId
        {
            get
            {
                return this.associatedAccountId;
            }

            set
            {
                this.shouldSerialize["AssociatedAccountId"] = true;
                this.associatedAccountId = value;
            }
        }

        /// <summary>
        /// Account number of the Associated Account associated with the Payer.
        /// </summary>
        [JsonProperty("AssociatedAccountNumber")]
        public string AssociatedAccountNumber
        {
            get
            {
                return this.associatedAccountNumber;
            }

            set
            {
                this.shouldSerialize["AssociatedAccountNumber"] = true;
                this.associatedAccountNumber = value;
            }
        }

        /// <summary>
        /// Account associated with the Payer.
        /// </summary>
        [JsonProperty("AssociatedAccountShortName")]
        public string AssociatedAccountShortName
        {
            get
            {
                return this.associatedAccountShortName;
            }

            set
            {
                this.shouldSerialize["AssociatedAccountShortName"] = true;
                this.associatedAccountShortName = value;
            }
        }

        /// <summary>
        /// Full name of the Associated Account associated with the Payer.
        /// </summary>
        [JsonProperty("AssociatedAccountFullName")]
        public string AssociatedAccountFullName
        {
            get
            {
                return this.associatedAccountFullName;
            }

            set
            {
                this.shouldSerialize["AssociatedAccountFullName"] = true;
                this.associatedAccountFullName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AssociatedAccount : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAssociatedAccountId()
        {
            this.shouldSerialize["AssociatedAccountId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAssociatedAccountNumber()
        {
            this.shouldSerialize["AssociatedAccountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAssociatedAccountShortName()
        {
            this.shouldSerialize["AssociatedAccountShortName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAssociatedAccountFullName()
        {
            this.shouldSerialize["AssociatedAccountFullName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAssociatedAccountId()
        {
            return this.shouldSerialize["AssociatedAccountId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAssociatedAccountNumber()
        {
            return this.shouldSerialize["AssociatedAccountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAssociatedAccountShortName()
        {
            return this.shouldSerialize["AssociatedAccountShortName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAssociatedAccountFullName()
        {
            return this.shouldSerialize["AssociatedAccountFullName"];
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
            return obj is AssociatedAccount other &&                ((this.AssociatedAccountId == null && other.AssociatedAccountId == null) || (this.AssociatedAccountId?.Equals(other.AssociatedAccountId) == true)) &&
                ((this.AssociatedAccountNumber == null && other.AssociatedAccountNumber == null) || (this.AssociatedAccountNumber?.Equals(other.AssociatedAccountNumber) == true)) &&
                ((this.AssociatedAccountShortName == null && other.AssociatedAccountShortName == null) || (this.AssociatedAccountShortName?.Equals(other.AssociatedAccountShortName) == true)) &&
                ((this.AssociatedAccountFullName == null && other.AssociatedAccountFullName == null) || (this.AssociatedAccountFullName?.Equals(other.AssociatedAccountFullName) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AssociatedAccountId = {(this.AssociatedAccountId == null ? "null" : this.AssociatedAccountId.ToString())}");
            toStringOutput.Add($"this.AssociatedAccountNumber = {(this.AssociatedAccountNumber == null ? "null" : this.AssociatedAccountNumber)}");
            toStringOutput.Add($"this.AssociatedAccountShortName = {(this.AssociatedAccountShortName == null ? "null" : this.AssociatedAccountShortName)}");
            toStringOutput.Add($"this.AssociatedAccountFullName = {(this.AssociatedAccountFullName == null ? "null" : this.AssociatedAccountFullName)}");
        }
    }
}