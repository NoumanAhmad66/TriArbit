using MaterialDesignThemes.Wpf;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for signup.xaml
    /// </summary>
    public partial class signup : UserControl
    {
        AppWindow app;
        public signup()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            login Login = new login();
            UserWindow User = Window.GetWindow(this) as UserWindow;
            User.UserContent.Content = Login;
        }

        private void FullName_TextChanged(object sender, TextChangedEventArgs e)
        {
            FullName.BorderBrush = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {
            Email.BorderBrush = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password.BorderBrush = new SolidColorBrush(Colors.WhiteSmoke);
        }

        private bool Validate()
        {
            bool flag = true;
            string email = "abc@email.com";
            string username = "username";

            if (Email.Text == "")
            {
                Email.BorderBrush = new SolidColorBrush(Colors.Red);
                HintAssist.SetHint(Email, "* Required");
                flag = false;
            }

            if (Username.Text == "")
            {
                Username.BorderBrush = new SolidColorBrush(Colors.Red);
                HintAssist.SetHint(Username, "* Required");
                flag = false;
            }


            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit");
            connection.Open();
            string query = "SELECT email,username FROM user_info WHERE email=@em or username=@un";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@em", Email.Text);
            command.Parameters.AddWithValue("@un", Username.Text);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    username = reader.GetString(1);
                    email = reader.GetString(0);
                    // do something with the fullName and email variables

                    if (Username.Text != "")
                    {

                        if (Username.Text == username)
                        {
                            Username.BorderBrush = new SolidColorBrush(Colors.Red);
                            Username.Clear();
                            HintAssist.SetHint(Username, "* Already Registered!");
                            flag = false;
                        }
                    }

                    if (Email.Text != "")
                    {

                        if (Email.Text == email)
                        {
                            Email.BorderBrush = new SolidColorBrush(Colors.Red);
                            Email.Clear();
                            HintAssist.SetHint(Email, "* Already Registered!");
                            flag = false;
                        }
                    }
                }
            }
            reader.Close();
            connection.Close();           
            
            if (FullName.Text == "")
            {
                FullName.BorderBrush = new SolidColorBrush(Colors.Red);
                HintAssist.SetHint(FullName, "* Required");
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

        private async void Signup_Click(object sender, RoutedEventArgs e)
        {
            if (Validate())
            {
                if (SaveToDB())
                {
                    InitExch();
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
        private void InitExch()
        {
            string ConnectionString = "server=localhost;uid=root;password=;database=TriArbit";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            string query = "INSERT INTO exch_info(username) VALUES(@un)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@un", Username.Text);
            command.ExecuteNonQuery();
            connection.Close();
        }
        private bool SaveToDB()
        {
            string ConnectionString = "server=localhost;uid=root;password=;database=TriArbit";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            string query = "INSERT INTO user_info(fullname,email,username,password) VALUES(@fn,@em,@un,@pw)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@fn", FullName.Text);
            command.Parameters.AddWithValue("@em", Email.Text);
            command.Parameters.AddWithValue("@un", Username.Text);
            command.Parameters.AddWithValue("@pw", Password.Password);
            if(command.ExecuteNonQuery() == 0)
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
