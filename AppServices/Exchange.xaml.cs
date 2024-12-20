using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TriArbit_v1.AppServices
{
    /// <summary>
    /// Interaction logic for Exchange.xaml
    /// </summary>
    public partial class Exchange : UserControl
    {
        private string UserName;
        public Exchange(string username)
        {
            InitializeComponent();
            UserName = username;
            FetchDetails();
        }

        private void PasteAPI_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Api.Text = Clipboard.GetText();
            }
        }
        void FetchDetails()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit");
            connection.Open();
            string query = "SELECT api,secret FROM exch_info WHERE username=@un";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@un", UserName);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Api.Text = reader.GetString(0);
                    Secret.Text = reader.GetString(1);
                }
            }
            reader.Close();
            connection.Close();
        }
        private bool SaveToDB()
        {
            string ConnectionString = "server=localhost;uid=root;password=;database=TriArbit";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            string query = "UPDATE exch_info SET api = @api, secret = @scrt, exchange = @exch WHERE username = @un";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@api", Api.Text);
            command.Parameters.AddWithValue("@scrt", Secret.Text);
            command.Parameters.AddWithValue("@exch", Exch_1.Text);
            command.Parameters.AddWithValue("@un", UserName);
            if (command.ExecuteNonQuery() == 0)
            {
                connection.Close();
                return false;
            }
            else
            {
                connection.Close();
                return true;
            }

        }

        private void PasteSecret_Click(object sender, RoutedEventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                Secret.Text = Clipboard.GetText();
            }
        }
        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            AppWindow App = Window.GetWindow(this) as AppWindow;
            App.Menu.SelectedIndex = 0;
        }

        private void PopupClose_Click(object sender, RoutedEventArgs e)
        {
            Success.IsOpen = false;
        }

        private void GoDashboard_Click(object sender, RoutedEventArgs e)
        {
            AppWindow App = Window.GetWindow(this) as AppWindow;
            App.Menu.SelectedIndex = 0;
        }

        private void UpdateBTN_Click(object sender, RoutedEventArgs e)
        {
            if (SaveToDB())
                Success.IsOpen = true;
        }
    }
}
