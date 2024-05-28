// <copyright file="PricedTransactionReqV2InvoiceStatusEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ShellDataReportingAPIs.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using ShellDataReportingAPIs.Standard;
    using ShellDataReportingAPIs.Standard.Utilities;

    /// <summary>
    /// PricedTransactionReqV2InvoiceStatusEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricedTransactionReqV2InvoiceStatusEnum
    {
        /// <summary>
        /// I.
        /// </summary>
        [EnumMember(Value = "I")]
        I,

        /// <summary>
        /// U.
        /// </summary>
        [EnumMember(Value = "U")]
        U,

        /// <summary>
        /// A.
        /// </summary>
        [EnumMember(Value = "A")]
        A
    }
}