using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.XPath;
using Binance.Net;
using Binance.Net.Clients;
using Binance.Net.Clients.UsdFuturesApi;
using Binance.Net.Interfaces.Clients;
using Binance.Net.Objects;
using CryptoExchange.Net.Authentication;
using CryptoExchange.Net.CommonObjects;
using MySqlConnector;
using Newtonsoft.Json.Linq;

namespace TriArbit_v1.AppServices
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : UserControl
    {
        BinanceClient binanceClient;
        string apiKey;
        string apiSecret;
        string UserName;


        public Dashboard(string _user)
        {
            InitializeComponent();
            UserName = _user;
            //apiKey = "h8LVQJZYpzRK1cUSnBOcdQRkC5GqvxCuKszDxXbPjcVCpgPECGzRTLLG6fPdKLlf";
            //apiSecret = "cVBC1XnMG5b6spyaBtmGOZlUF3sreawnoTABgnKMHFJ8Ut5Nobi3G8ywQXlLFDfM";
            //FetchDetails();
            //Balance.Text = apiKey;
            //UpdateDashboard.Content = apiSecret;
            
            loadDataAsync();
        }
        async void loadDataAsync()
        {
            await FetchDetails();
            try
            {
                BinanceApiCredentials credentials = new BinanceApiCredentials(apiKey, apiSecret);
                binanceClient = new BinanceClient(new BinanceClientOptions { ApiCredentials = credentials });
                Status.Fill = new SolidColorBrush(Colors.Green);
                getBalance();
                getAssets();
                LoadOpenOrders();
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error: {ex.Message}");
                Status.Fill = new SolidColorBrush(Colors.IndianRed);
            }

        }/*
        void FetchDetails()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit");
            connection.Open();
            string query = "SELECT api, secret FROM exch_info WHERE username = @un";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@un", UserName);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    apiKey = reader.GetString(0);
                    apiSecret = reader.GetString(1);
                }
            }
            else
            {
                // Set default values if no records found
                apiKey = "";
                apiSecret = "";
            }

            reader.Close();
            connection.Close();
        }*/

        async Task FetchDetails()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit"))
            {
                await connection.OpenAsync();
                string query = "SELECT api, secret FROM exch_info WHERE username = @un";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@un", UserName);

                using (MySqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            apiKey = reader.GetString(0);
                            apiSecret = reader.GetString(1);
                        }
                    }
                    else
                    {
                        apiKey = "";
                        apiSecret = "";
                        Status.Fill = new SolidColorBrush(Colors.IndianRed);
                    }
                }
            }
        }


        private void getBalance()
        {
            var accountInfo = binanceClient.SpotApi.Account.GetBalancesAsync();
            var balances = accountInfo.Result;

            decimal totalBalance = 0;

            foreach (var balance in balances.Data)
            {

                if (balance.Asset == "USDT")
                {
                    totalBalance += balance.Total;
                }
            }
            Balance.Text = totalBalance.ToString();
        }
        private async void LoadOpenOrders()
        {
            var openOrders = await binanceClient.SpotApi.Trading.GetOpenOrdersAsync();

            // Convert the open orders to the OpenOrder model
            var openOrderList = openOrders.Data.Select(order => new Order
            {
                Symbol = order.Symbol,
                Quantity = order.Quantity,
                Price = order.Price,
                Side = order.Side.ToString()
            }).ToList();

            // Bind the open orders to the DataGrid
            openOrdersDataGrid.ItemsSource = openOrderList;
        }

        private async void getAssets()
        {
            try
            {
                var balanceData = await binanceClient.SpotApi.Account.GetUserAssetsAsync();
                if (!balanceData.Success)
                {
                    MessageBox.Show("Failed to fetch account information: " + balanceData.Error.Message);
                }
                else
                {
                    var assets = balanceData.Data.Where(asset => asset.Available > 0).ToList();
                    AssetsGrid.ItemsSource = assets;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BaseCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            getBalance();
        }

        private void UpdateDashboard_Click(object sender, RoutedEventArgs e)
        {
            AppWindow App = Window.GetWindow(this) as AppWindow;
            //App.Menu.SelectedIndex = 0;
            Dashboard dashboard = new Dashboard(UserName);
            App.AppContent.Content = dashboard;
        }
    }
    public class Order
    {
        public string Side { get; set; }
        public string Symbol { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
    }

}
