// <copyright file="PricedTransactionResponseTransactionsItemsLocation.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace ShellDataReportingAPIs.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<PricedTransactionResponseTransactionsItemsLocation>),
        new Type[] {
            typeof(MObjectCase),
            typeof(PricedTransactionItemsLocationItemsCase)
        },
        true
    )]
    public abstract class PricedTransactionResponseTransactionsItemsLocation
    {
        /// <summary>
        /// This is Object case.
        /// </summary>
        /// <returns>
        /// The PricedTransactionResponseTransactionsItemsLocation instance, wrapping the provided object value.
        /// </returns>
        public static PricedTransactionResponseTransactionsItemsLocation FromObject(object mObject)
        {
            return new MObjectCase().Set(mObject);
        }

        /// <summary>
        /// This is PricedTransactionItemsLocationItems case.
        /// </summary>
        /// <returns>
        /// The PricedTransactionResponseTransactionsItemsLocation instance, wrapping the provided PricedTransactionItemsLocationItems value.
        /// </returns>
        public static PricedTransactionResponseTransactionsItemsLocation FromPricedTransactionItemsLocationItems(PricedTransactionItemsLocationItems pricedTransactionItemsLocationItems)
        {
            return new PricedTransactionItemsLocationItemsCase().Set(pricedTransactionItemsLocationItems);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<object, T> mObject, Func<PricedTransactionItemsLocationItems, T> pricedTransactionItemsLocationItems);

        [JsonConverter(typeof(UnionTypeCaseConverter<MObjectCase, object>))]
        private sealed class MObjectCase : PricedTransactionResponseTransactionsItemsLocation, ICaseValue<MObjectCase, object>
        {
            public object _value;

            public override T Match<T>(Func<object, T> mObject, Func<PricedTransactionItemsLocationItems, T> pricedTransactionItemsLocationItems)
            {
                return mObject(_value);
            }

            public MObjectCase Set(object value)
            {
                _value = value;
                return this;
            }

            public object Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PricedTransactionItemsLocationItemsCase, PricedTransactionItemsLocationItems>))]
        private sealed class PricedTransactionItemsLocationItemsCase : PricedTransactionResponseTransactionsItemsLocation, ICaseValue<PricedTransactionItemsLocationItemsCase, PricedTransactionItemsLocationItems>
        {
            public PricedTransactionItemsLocationItems _value;

            public override T Match<T>(Func<object, T> mObject, Func<PricedTransactionItemsLocationItems, T> pricedTransactionItemsLocationItems)
            {
                return pricedTransactionItemsLocationItems(_value);
            }

            public PricedTransactionItemsLocationItemsCase Set(PricedTransactionItemsLocationItems value)
            {
                _value = value;
                return this;
            }

            public PricedTransactionItemsLocationItems Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}