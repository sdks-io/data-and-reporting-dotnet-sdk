// <copyright file="EIDDownloadReq.cs" company="APIMatic">
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
    /// EIDDownloadReq.
    /// </summary>
    public class EIDDownloadReq
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EIDDownloadReq"/> class.
        /// </summary>
        public EIDDownloadReq()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EIDDownloadReq"/> class.
        /// </summary>
        /// <param name="eIDList">EIDList.</param>
        /// <param name="accountGroupIdList">AccountGroupIdList.</param>
        /// <param name="colCoCode">ColCoCode.</param>
        /// <param name="accountGroupCountry">AccountGroupCountry.</param>
        public EIDDownloadReq(
            List<string> eIDList,
            List<string> accountGroupIdList,
            int? colCoCode = null,
            int? accountGroupCountry = null)
        {
            this.ColCoCode = colCoCode;
            this.EIDList = eIDList;
            this.AccountGroupCountry = accountGroupCountry;
            this.AccountGroupIdList = accountGroupIdList;
        }

        /// <summary>
        /// Collecting Company Code of the selected payer.
        /// Mandatory
        /// </summary>
        [JsonProperty("ColCoCode", NullValueHandling = NullValueHandling.Include)]
        public int? ColCoCode { get; set; }

        /// <summary>
        /// Gets or sets EIDList.
        /// </summary>
        [JsonProperty("EIDList")]
        public List<string> EIDList { get; set; }

        /// <summary>
        /// ColCo code associated with the Account Group IDs of the given EID/EDI files.
        /// Mandatory
        /// </summary>
        [JsonProperty("AccountGroupCountry", NullValueHandling = NullValueHandling.Include)]
        public int? AccountGroupCountry { get; set; }

        /// <summary>
        /// Gets or sets AccountGroupIdList.
        /// </summary>
        [JsonProperty("AccountGroupIdList")]
        public List<string> AccountGroupIdList { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"EIDDownloadReq : ({string.Join(", ", toStringOutput)})";
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
            return obj is EIDDownloadReq other &&                ((this.ColCoCode == null && other.ColCoCode == null) || (this.ColCoCode?.Equals(other.ColCoCode) == true)) &&
                ((this.EIDList == null && other.EIDList == null) || (this.EIDList?.Equals(other.EIDList) == true)) &&
                ((this.AccountGroupCountry == null && other.AccountGroupCountry == null) || (this.AccountGroupCountry?.Equals(other.AccountGroupCountry) == true)) &&
                ((this.AccountGroupIdList == null && other.AccountGroupIdList == null) || (this.AccountGroupIdList?.Equals(other.AccountGroupIdList) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ColCoCode = {(this.ColCoCode == null ? "null" : this.ColCoCode.ToString())}");
            toStringOutput.Add($"this.EIDList = {(this.EIDList == null ? "null" : $"[{string.Join(", ", this.EIDList)} ]")}");
            toStringOutput.Add($"this.AccountGroupCountry = {(this.AccountGroupCountry == null ? "null" : this.AccountGroupCountry.ToString())}");
            toStringOutput.Add($"this.AccountGroupIdList = {(this.AccountGroupIdList == null ? "null" : $"[{string.Join(", ", this.AccountGroupIdList)} ]")}");
        }
    }
}