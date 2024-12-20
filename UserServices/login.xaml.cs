using MaterialDesignThemes.Wpf;
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

namespace TriArbit_v1.UserServices
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : UserControl
    {
        AppWindow app;
        public login()
        {
            InitializeComponent();
        }

        private void SignupBTN_Click(object sender, RoutedEventArgs e)
        {
            signup Signup = new signup();
            UserWindow User = Window.GetWindow(this) as UserWindow;
            User.UserContent.Content = Signup;
        }

        private async void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (Validate()) {
                if (VerifyUser())
                {
                    Loader.IsOpen = true;
                    string username = Username.Text;
                    app = new AppWindow(username);
                    await Task.Delay(5000);
                    Success.IsOpen = true;
                    Loader.IsOpen = false;
                }
                else
                    Failure.IsOpen = true;
            }
        }
        private bool Validate()
        {
            bool flag = true;
            if (Username.Text == "")
            {
                Username.BorderBrush = new SolidColorBrush(Colors.Red);
                HintAssist.SetHint(Username, "* Required");
                flag = false;
            }

            if (Password.Password == "")
            {
                Password.BorderBrush = new SolidColorBrush(Colors.Red);
                HintAssist.SetHint(Password, "* Required");
                flag = false;
            }
            return flag;
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password.BorderBrush = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void MimimizeBTN_Click(object sender, RoutedEventArgs e)
        {
            UserWindow User = Window.GetWindow(this) as UserWindow;
            User.WindowState = WindowState.Minimized;
        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {
            UserWindow User = Window.GetWindow(this) as UserWindow;
            User.Close();
        }

        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            Username.BorderBrush = new SolidColorBrush(Colors.WhiteSmoke);
        }
        private bool VerifyUser()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit");
            connection.Open();
            string query = "SELECT username,password FROM user_info WHERE username=@un AND password=@pw";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@un", Username.Text);
            command.Parameters.AddWithValue("@pw", Password.Password);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == true)
            {
                //Prompt_Box.Content = "User Verified";
                //string username = reader["username"].ToString();
                connection.Close();
                return true;
                //Dashboard daObj = new Dashboard(username);
                //daObj.Show();
                //this.Close();

                //PromptBox.Content = temp;
            }
            else
            {
                connection.Close();
                return false;
            }
            
        }

        private void PopupClose_Click(object sender, RoutedEventArgs e)
        {
            Success.IsOpen = false;
        }

        private void GoDashboard_Click(object sender, RoutedEventArgs e)
        {
            UserWindow User = Window.GetWindow(this) as UserWindow;
            app.Show();
            User.Close();
        }

        private void FailureClose_Click(object sender, RoutedEventArgs e)
        {
            Failure.IsOpen = false;
        }
    }
}
