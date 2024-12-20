using MaterialDesignThemes.Wpf;
using Microsoft.Win32;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
using TriArbit_v1.UserServices;

namespace TriArbit_v1.AppServices
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : UserControl
    {
        private string Full_Name;
        private string UserName;
        private string User_Email;
        private string User_Password;
        private string imagePath;

        public Profile(string username)
        {
            InitializeComponent();
            UserName = username;
            FetchDetails();
        }

        void FetchDetails()
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit");
            connection.Open();
            string query = "SELECT fullname,email,password FROM user_info WHERE username=@un";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@un", UserName);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Full_Name = reader.GetString(0);
                    User_Email = reader.GetString(1);
                    User_Password = reader.GetString(2);
                }
            }
            reader.Close();
            connection.Close();
            FullName.Text = Full_Name;
            Username.Text = UserName;
            Email.Text = User_Email;
            Password.Password = User_Password;
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
            //string email;
            //string username;

            if (Email.Text == "")
            {
                Email.BorderBrush = new SolidColorBrush(Colors.Red);
                HintAssist.SetHint(Email, "* Required");
                flag = false;
            }

            MySqlConnection connection = new MySqlConnection("server=localhost;uid=root;password=;database=TriArbit");
            connection.Open();
            string query = "SELECT email FROM user_info WHERE email=@em";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@em", Email.Text);
            command.Parameters.AddWithValue("@un", Username.Text);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string email = reader.GetString(0);

                    if (Email.Text != User_Email)
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


        private bool SaveToDB()
        {
            byte[] imageData = null;
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }

            string ConnectionString = "server=localhost;uid=root;password=;database=TriArbit";
            MySqlConnection connection = new MySqlConnection(ConnectionString);
            connection.Open();
            string query = "UPDATE user_info SET fullname = @fn,pic = @pic, email = @em, password = @pw WHERE username = @un";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@fn", FullName.Text);
            command.Parameters.AddWithValue("@em", Email.Text);
            command.Parameters.AddWithValue("@pic", imageData);
            command.Parameters.AddWithValue("@un", UserName);
            command.Parameters.AddWithValue("@pw", Password.Password);
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

        private void PopupClose_Click(object sender, RoutedEventArgs e)
        {
            Success.IsOpen = false;
        }

        private void GoDashboard_Click(object sender, RoutedEventArgs e)
        {
            AppWindow App = Window.GetWindow(this) as AppWindow;
            App.Menu.SelectedIndex = 0;
        }

        private void ProfilePic_Click(object sender, RoutedEventArgs e)
        {
            AppWindow app = Window.GetWindow(this) as AppWindow;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files (*.*)|*.*";
            ofd.DefaultExt = ".jpg";
            
            if (ofd.ShowDialog() == true)
            {
                imagePath = ofd.FileName;
                ImageSource imageSource = new BitmapImage(new Uri(imagePath));

                //ProfilePic.Content = imagePath;
                double width = ProfilePic.Content.ToString().Length * 10;
                ProfilePic.Width = width;

                app.ProfilePic.ImageSource = imageSource;
            }
        }

        private void UpdateBTN_Click(object sender, RoutedEventArgs e)
        {
            AppWindow App = Window.GetWindow(this) as AppWindow;
            if (Validate())
                if (SaveToDB())
                {
                    Success.IsOpen = true;
                }  
            App.InitUser();
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            AppWindow App = Window.GetWindow(this) as AppWindow;
            App.Menu.SelectedIndex = 0;
        }
    }
}
