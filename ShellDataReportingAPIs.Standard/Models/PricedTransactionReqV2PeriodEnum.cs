// <copyright file="PricedTransactionReqV2PeriodEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using ShellDataReportingAPIs.Standard;
using ShellDataReportingAPIs.Standard.Utilities;

namespace ShellDataReportingAPIs.Standard.Models
{
    /// <summary>
    /// PricedTransactionReqV2PeriodEnum.
    /// </summary>

    [JsonConverter(typeof(NumberEnumConverter))]
    public enum PricedTransactionReqV2PeriodEnum
    {
        /// <summary>
        /// Enum1.
        /// </summary>
        Enum1 = 1,

        /// <summary>
        /// Enum2.
        /// </summary>
        Enum2 = 2,

        /// <summary>
        /// Enum3.
        /// </summary>
        Enum3 = 3
    }
}