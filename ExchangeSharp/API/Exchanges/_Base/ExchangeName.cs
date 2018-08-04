﻿/*
MIT LICENSE

Copyright 2018 Digital Ruby, LLC - http://www.digitalruby.com

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace ExchangeSharp
{
    using System.Collections.Generic;
    using System.Reflection;

    /// <summary>
    /// List of exchange names
    /// </summary>
    public static class ExchangeName
    {
        private static readonly HashSet<string> exchangeNames = new HashSet<string>();

        static ExchangeName()
        {
            foreach (FieldInfo field in typeof(ExchangeName).GetFields(BindingFlags.Public | BindingFlags.Static))
            {
                exchangeNames.Add(field.GetValue(null).ToString());
            }
        }

        /// <summary>
        /// Check if an exchange name exists
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>True if name exists, false otherwise</returns>
        public static bool HasName(string name)
        {
            return exchangeNames.Contains(name);
        }

        /// <summary>
        /// Get a list of all exchange names
        /// </summary>
        public static IReadOnlyCollection<string> ExchangeNames { get { return exchangeNames; } }

        /// <summary>
        /// Abucoins
        /// </summary>
        public const string Abucoins = "Abucoins";

        /// <summary>
        /// Binance
        /// </summary>
        public const string Binance = "Binance";

        /// <summary>
        /// Bitfinex
        /// </summary>
        public const string Bitfinex = "Bitfinex";

        /// <summary>
        /// Bithumb
        /// </summary>
        public const string Bithumb = "Bithumb";

        /// <summary>
        /// BitMEX
        /// </summary>
        public const string BitMEX = "BitMEX";

        /// <summary>
        /// Bitstamp
        /// </summary>
        public const string Bitstamp = "Bitstamp";

        /// <summary>
        /// Bittrex
        /// </summary>
        public const string Bittrex = "Bittrex";

        /// <summary>
        /// Bleutrade
        /// </summary>
        public const string Bleutrade = "Bleutrade";

        /// <summary>
        /// Cryptopia
        /// </summary>
        public const string Cryptopia = "Cryptopia";

        /// <summary>
        /// Coinbase
        /// </summary>
        public const string Coinbase = "Coinbase";

        /// <summary>
        /// Gemini
        /// </summary>
        public const string Gemini = "Gemini";

        /// <summary>
        /// Hitbtc
        /// </summary>
        public const string Hitbtc = "Hitbtc";

        /// <summary>
        /// Huobi
        /// </summary>
        public const string Huobi = "Huobi";

        /// <summary>
        /// Kraken
        /// </summary>
        public const string Kraken = "Kraken";

        /// <summary>
        /// Kucoin
        /// </summary>
        public const string Kucoin = "Kucoin";

        /// <summary>
        /// Livecoin
        /// </summary>
        public const string Livecoin = "Livecoin";

        /// <summary>
        /// Okex
        /// </summary>
        public const string Okex = "Okex";

        /// <summary>
        /// Poloniex
        /// </summary>
        public const string Poloniex = "Poloniex";

        /// <summary>
        /// TuxExchange
        /// </summary>
        public const string TuxExchange = "TuxExchange";

        /// <summary>
        /// Yobit
        /// </summary>
        public const string Yobit = "Yobit";

        /// <summary>
        /// ZB.com
        /// </summary>
        public const string ZBcom = "ZBcom";
    }
}