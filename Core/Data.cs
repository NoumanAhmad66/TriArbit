using CryptoExchange.Net.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace TriArbit_v1.Core
{
    public class Data
    {
        public List<Pair> tradingPairs;
        public List<Pair> usdtPairs;
        public List<Pair> btcPairs;
        public List<Pair> ethPairs;
        public List<Pair> tusdPairs;
        public List<Pair> busdPairs;
        public List<Pair> bnbPairs;
        public List<Pair> daiPairs;
        public List<Pair> usdcPairs;
        public List<Pair> xrpPairs;
        public List<Pair> dogePairs;
        public List<Pair> trxPairs;
        public List<Pair> dotPairs;
        public List<Pair> audPairs;

        OpHandler handler = new OpHandler();
        public Data()
        {
            tradingPairs = new List<Pair>();
            setPairs();   
        }

        public async void setPairs()
        {
            tradingPairs = await filterPairs();
            classifyPairs(tradingPairs);

            await handler.FetchOpportunities(usdtPairs, btcPairs, ethPairs, tusdPairs, busdPairs,
                bnbPairs, daiPairs,usdcPairs,xrpPairs,dogePairs,trxPairs,dotPairs,audPairs);
        }
        
        public OpHandler getOpportunities()
        {
            return handler;
        }

        private void classifyPairs(List<Pair> allPairs)
        {
            audPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("AUD"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("AUD", ""),
                            price = pair.price,
                        }).ToList();
            dotPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("DOT"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("DOT", ""),
                            price = pair.price,
                        }).ToList();
            trxPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("TRX"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("TRX", ""),
                            price = pair.price,
                        }).ToList();
            dogePairs = allPairs
                        .Where(pair => pair.coin.EndsWith("DOGE"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("DOGE", ""),
                            price = pair.price,
                        }).ToList();
            xrpPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("XRP"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("XRP", ""),
                            price = pair.price,
                        }).ToList();
            
            usdcPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("USDC"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("USDC", ""),
                            price = pair.price,
                        }).ToList();

            daiPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("DAI"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("DAI", ""),
                            price = pair.price,
                        }).ToList();

            bnbPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("BNB"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("BNB", ""),
                            price = pair.price,
                        }).ToList();

            btcPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("BTC"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("BTC", ""),
                            price = pair.price,
                        }).ToList();

            usdtPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("USDT"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("USDT", ""),
                            price = pair.price,
                        }).ToList();

            ethPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("ETH"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("ETH", ""),
                            price = pair.price,
                        }).ToList();
            tusdPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("TUSD"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("TUSD", ""),
                            price = pair.price,
                        }).ToList();
            busdPairs = allPairs
                        .Where(pair => pair.coin.EndsWith("BUSD"))
                        .Select(pair => new Pair
                        {
                            coin = pair.coin.Replace("BUSD", ""),
                            price = pair.price,
                        }).ToList();

        }

        public async Task UpdatePairs()
        {
            List<Pair> allPairs = new List<Pair>();
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.binance.com/api/v3/ticker/price");
                var content = await response.Content.ReadAsStringAsync();
                var tickerData = JArray.Parse(content);

                // Loop through the ticker data and update the values in the dictionary if the symbol matches
                foreach (var ticker in tickerData)
                {
                    var symbol = ticker["symbol"].ToString();
                    var price = Convert.ToDecimal(ticker["price"]);

                    foreach (Pair pair in tradingPairs)
                    {
                        if (pair.coin == symbol)
                        {
                            pair.price = price;
                            pair.coin = symbol;

                            allPairs.Add(pair);
                            break;
                        }
                    }
                }
            }
            tradingPairs = allPairs;
            classifyPairs(tradingPairs);
            await handler.FetchOpportunities(usdtPairs, btcPairs, ethPairs, tusdPairs, busdPairs,
                bnbPairs, daiPairs, usdcPairs, xrpPairs, dogePairs, trxPairs, dotPairs, audPairs);
        }
        public async Task<List<Pair>> filterPairs()
        {
            var allPairs = await fetchPairs();

            List<Pair> filteredPairs = new List<Pair>();

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("https://api.binance.com/api/v3/exchangeInfo");
                var content = await response.Content.ReadAsStringAsync();
                var exchangeInfo = JsonConvert.DeserializeObject<dynamic>(content);

                foreach (var symbol in exchangeInfo.symbols)
                {
                    string symbolName = symbol.symbol;
                    bool isTrading = symbol.status == "TRADING";
                    bool isSpotTradingAllowed = symbol.isSpotTradingAllowed == true;

                    if (isTrading && isSpotTradingAllowed && allPairs.ContainsKey(symbolName))
                    {
                        decimal currentPrice = allPairs[symbolName];
                        // call the API to get the current price for the symbol
                        // and set the currentPrice variable to the result
                        Pair p = new Pair {coin = symbolName, price = currentPrice };
                        filteredPairs.Add(p);
                    }
                }
            }
            //DataContext = filteredPairs;
            return filteredPairs;
        }
        private async Task<Dictionary<string, decimal>> fetchPairs()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("https://api.binance.com/api/v3/ticker/price");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var pairs = new Dictionary<string, decimal>();
                        var data = JArray.Parse(json);

                        foreach (var ticker in data)
                        {
                            var symbol = ticker["symbol"].ToString();
                            var price = Convert.ToDecimal(ticker["price"]);
                            pairs[symbol] = price;
                        }

                        return pairs;
                    }
                    else
                    {
                        throw new Exception($"Failed to get pairs: {response.StatusCode}");
                    }
                }
                catch (Exception e) {
                    throw new Exception($"Error: {e.Message}");
                }
            }
        }
    }
}
