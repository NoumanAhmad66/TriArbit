using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TriArbit_v1.Core
{
    public class OpHandler
    {
        public Dictionary<string, decimal> ETH;
        public Dictionary<string, decimal> All;
        public Dictionary<string, decimal> BTC;
        public Dictionary<string, decimal> TUSD;
        public Dictionary<string, decimal> BUSD;
        public Dictionary<string, decimal> BNB;
        public Dictionary<string, decimal> DAI;
        public Dictionary<string, decimal> USDC;
        public Dictionary<string, decimal> XRP;
        public Dictionary<string, decimal> TRX;
        public Dictionary<string, decimal> DOGE;
        public Dictionary<string, decimal> DOT;
        public Dictionary<string, decimal> AUD;
        
        public OpHandler()
        {
            ETH = new Dictionary<string, decimal>();
            BTC = new Dictionary<string, decimal>();
            All = new Dictionary<string, decimal>();
            TUSD = new Dictionary<string, decimal>();
            BUSD = new Dictionary<string, decimal>();
            BNB = new Dictionary<string, decimal>();
            //DAI = new Dictionary<string, decimal>();
            //USDC = new Dictionary<string, decimal>();
            //XRP = new Dictionary<string, decimal>();
        }

        public async Task FetchOpportunities(List<Pair> usdtPairs, List<Pair> btcPairs,
               List<Pair> ethPairs, List<Pair> tusdPairs, List<Pair> busdPairs,List<Pair> bnbPairs,
               List<Pair> daiPairs, List<Pair> usdcPairs,List<Pair> xrpPairs, List<Pair> dogePairs,
               List<Pair> trxPairs, List<Pair> dotPairs, List<Pair> audPairs)
        {
            ETH_Opps(usdtPairs, ethPairs);
            TUSD_Opps(usdtPairs, tusdPairs);
            BUSD_Opps(usdtPairs, busdPairs);
            BTC_Opps(usdtPairs, btcPairs);
            BNB_Opps(usdtPairs, bnbPairs);
            //DAI_Opps(usdtPairs, daiPairs);
            //USDC_Opps(usdtPairs, usdcPairs);
            //TRX_Opps(usdtPairs, trxPairs);
            //DOGE_Opps(usdtPairs, dogePairs);
            //XRP_Opps(usdtPairs, xrpPairs);
            //DOT_Opps(usdtPairs, dotPairs);
            //AUD_Opps(usdtPairs, audPairs);
            
            All = ETH
                .Concat(BTC).Concat(TUSD).Concat(BUSD).Concat(BNB)
                .ToDictionary(pair => pair.Key, pair => pair.Value);
            //.Concat(DOT).Concat(AUD).Concat(TRX).Concat(DOGE).Concat(XRP).Concat(DAI).Concat(USDC)

        }

        private void AUD_Opps(List<Pair> usdtPairs, List<Pair> audPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(audPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal audPrice = audPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("AUD", audPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/AUD ==> AUD/USDT";
                    decimal profit = Math.Round(difference, 2);
                    AUD[trade] = profit;
                }
            }
        }
        private void USDC_Opps(List<Pair> usdtPairs, List<Pair> usdcPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(usdcPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdcPrice = usdcPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("USDC", usdcPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/USDC ==> USDC/USDT";
                    decimal profit = Math.Round(difference, 2);
                    USDC[trade] = profit;
                }
            }
        }
        private void DOT_Opps(List<Pair> usdtPairs, List<Pair> dotPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(dotPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal dotPrice = dotPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("DOT", dotPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/DOT ==> DOT/USDT";
                    decimal profit = Math.Round(difference, 2);
                    DOT[trade] = profit;
                }
            }
        }
        private void TRX_Opps(List<Pair> usdtPairs, List<Pair> trxPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(trxPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal trxPrice = trxPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("TRX", trxPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/TRX ==> TRX/USDT";
                    decimal profit = Math.Round(difference, 2);
                    TRX[trade] = profit;
                }
            }
        }
        private void DOGE_Opps(List<Pair> usdtPairs, List<Pair> dogePairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(dogePairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal dogePrice = dogePairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("DOGE", dogePrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/DOGE ==> DOGE/USDT";
                    decimal profit = Math.Round(difference, 2);
                    DOGE[trade] = profit;
                }
            }
        }
        private void XRP_Opps(List<Pair> usdtPairs, List<Pair> xrpPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(xrpPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal xrpPrice = xrpPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("XRP", xrpPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/XRP ==> XRP/USDT";
                    decimal profit = Math.Round(difference, 2);
                    XRP[trade] = profit;
                }
            }
        }
        
        private void DAI_Opps(List<Pair> usdtPairs, List<Pair> daiPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(daiPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal daiPrice = daiPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("DAI", daiPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/DAI ==> DAI/USDT";
                    decimal profit = Math.Round(difference, 2);
                    DAI[trade] = profit;
                }
            }
        }

        private void BNB_Opps(List<Pair> usdtPairs, List<Pair> bnbPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(bnbPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal bnbPrice = bnbPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("BNB", bnbPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/BNB ==> BNB/USDT";
                    decimal profit = Math.Round(difference, 2);
                    BNB[trade] = profit;
                }
            }
        }

        private void BUSD_Opps(List<Pair> usdtPairs, List<Pair> busdPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(busdPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal busdPrice = busdPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("BUSD", busdPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/BUSD ==> BUSD/USDT";
                    decimal profit = Math.Round(difference, 2);
                    BUSD[trade] = profit;
                }
            }
        }

        private void TUSD_Opps(List<Pair> usdtPairs, List<Pair> tusdPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(tusdPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal tusdPrice = tusdPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("TUSD", tusdPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/TUSD ==> TUSD/USDT";
                    decimal profit = Math.Round(difference, 2);
                    TUSD[trade] = profit;
                }
            }
        }

        private void ETH_Opps(List<Pair> usdtPairs, List<Pair> ethPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(ethPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal ethPrice = ethPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("ETH", ethPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/ETH ==> ETH/USDT";
                    decimal profit = Math.Round(difference, 2);
                    ETH[trade] = profit;
                }
            }
        }

        private void BTC_Opps(List<Pair> usdtPairs, List<Pair> btcPairs)
        {
            var pairs = usdtPairs.Select(pair => pair.coin)
                           .Intersect(btcPairs.Select(pair => pair.coin))
                           .ToList();

            foreach (var pair in pairs)
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal btcPrice = btcPairs.FirstOrDefault(p => p.coin == pair)?.price ?? 0;
                decimal usdtValue = calcValue("BTC", btcPrice, usdtPairs);
                var difference = (usdtValue - usdtPrice) / usdtPrice * 100;
                if (difference >= 0.5m)
                {
                    string trade = $"{pair}/USDT ==> {pair}/BTC ==> BTC/USDT";
                    decimal profit = Math.Round(difference, 2);
                    BTC[trade] = profit;
                }
            }
        }


        public static decimal calcValue(string cryptoName, decimal cryptoPrice, List<Pair> usdtPairs)
        {
            if (cryptoName == "USDT")
            {
                return cryptoPrice;
            }
            else
            {
                decimal usdtPrice = usdtPairs.FirstOrDefault(p => p.coin == cryptoName)?.price ?? 0;
                //decimal usdtPrice = usdtPairs[cryptoName];
                decimal usdtValue = cryptoPrice * usdtPrice;
                return usdtValue;
            }
        }

    }
}
