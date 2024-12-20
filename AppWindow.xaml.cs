using MySqlConnector;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TriArbit_v1.AppServices;
using TriArbit_v1.Core;
using System.Windows.Markup;
using System.Windows.Threading;

namespace TriArbit_v1
{
    /// <summary>
    /// Interaction logic for AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
        private string UserName;
        public BitmapImage UserPic;
        public Data pairs;
        public OpHandler opps;
        Opportunities opportunities;
        Dashboard dashboard;
        private DispatcherTimer timer;
        public AppWindow(string username)
        {
            InitializeComponent();
            pairs = new Data();
            opps = new OpHandler();
            

            Menu.SelectedIndex = 0;
            UserName = username;
            opps = pairs.getOpportunities();
            dashboard = new Dashboard(UserName);
            AppContent.Content = dashboard;
            InitUser();
            opportunities = new Opportunities(opps);
            
            // Initialize the timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(15);
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
            //OpHandler handler = new OpHandler();
            //handler.FetchOpportunities(pairs);
        }

        public AppWindow()
        {
            InitializeComponent();
            //Ops = new List<Opportunity>();
            
            pairs = new Data();
            opps = new OpHandler();
            dashboard = new Dashboard(UserName);
            InitUser();
            Menu.SelectedIndex = 0;
            opps = pairs.getOpportunities();
            //OpHandler handler = new OpHandler();
            //handler.FetchOpportunities(pairs);

            // Initialize the timer
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Timer_Tick;

            // Start the timer
            timer.Start();
        }
        public async void InitUser()
        {
            UserPic = new BitmapImage();
            UserPic.BeginInit();
            

            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit");
            connection.Open();
            string query = "SELECT fullname, pic FROM user_info WHERE username=@un";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@un", UserName);

            MySqlDataReader reader = command.ExecuteReader();
            
            if (reader.Read() == true)
            {
                string fullName = reader.GetString(0);
                string firstName = fullName.Split(' ')[0];
                User.Content = "Hello, " + firstName;

                // Retrieve the profile picture from the database
                if (!reader.IsDBNull(1))
                {
                    byte[] imageData = (byte[])reader["pic"];
                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imageData))
                        {
                            //UserPic = new BitmapImage();
                            //UserPic.BeginInit();
                            UserPic.StreamSource = ms;
                            UserPic.CacheOption = BitmapCacheOption.OnLoad;
                            UserPic.EndInit();
                            ProfilePic.ImageSource = UserPic;
                        }
                    }
                    else
                    {
                        UserPic.UriSource = new Uri("pack://application:,,,/assets/avatar v2.jpg");
                        ProfilePic.ImageSource = UserPic;
                        UserPic.EndInit();
                    }
                }
            }
           
            connection.Close();
            await Task.Delay(5000);
        }
        
        private void MimimizeBTN_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            Application.Current.Shutdown();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Logout_Selected(object sender, RoutedEventArgs e)
        {
            //UserWindow user = new UserWindow();
            //user.Show();
            //this.Close();
            Application.Current.Shutdown(); // Close the current application instance
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location); // Start a new instance of the application
        }

        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            title.Content = "» Profile";
            Profile profile = new Profile(UserName);
            ProfilePic.ImageSource = UserPic;
            AppContent.Content = profile;
        }

        private void Exchange_Selected(object sender, RoutedEventArgs e)
        {
            title.Content = "» Exchange";
            Exchange exchange = new Exchange(UserName);
            ProfilePic.ImageSource = UserPic;
            AppContent.Content = exchange;
        }

        private void Opportunity_Selected(object sender, RoutedEventArgs e)
        {
            title.Content = "» Opportunities";
            //opportunities = new Opportunities(opps);
            ProfilePic.ImageSource = UserPic;
            AppContent.Content = opportunities;
        }

        private void Dashboard_Selected(object sender, RoutedEventArgs e)
        {
            dashboard = new Dashboard(UserName);
            ProfilePic.ImageSource = UserPic;
            AppContent.Content = dashboard;
        }
        private async void Timer_Tick(object sender, EventArgs e)
        {

            // Add your logic here
            await pairs.UpdatePairs();
            opps = pairs.getOpportunities();
            //opportunities = new Opportunities(opps);
            //opportunities.dataGrid.ItemsSource = opportunities.op.All;
            opportunities.dataGrid.ItemsSource = opps.All;
            //: Display a message box
            // MessageBox.Show("Opportunities updated after 15.");
        }
    }
}
