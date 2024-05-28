// <copyright file="PricedTransactionReqV2SortOrderEnum.cs" company="APIMatic">
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
    /// PricedTransactionReqV2SortOrderEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricedTransactionReqV2SortOrderEnum
    {
        /// <summary>
        /// Enum1.
        /// </summary>
        [EnumMember(Value = "1")]
        Enum1,

        /// <summary>
        /// Enum2.
        /// </summary>
        [EnumMember(Value = "2")]
        Enum2,

        /// <summary>
        /// Enum3.
        /// </summary>
        [EnumMember(Value = "3")]
        Enum3,

        /// <summary>
        /// Enum4.
        /// </summary>
        [EnumMember(Value = "4")]
        Enum4,

        /// <summary>
        /// Enum5.
        /// </summary>
        [EnumMember(Value = "5")]
        Enum5,

        /// <summary>
        /// Enum6.
        /// </summary>
        [EnumMember(Value = "6")]
        Enum6
    }
}