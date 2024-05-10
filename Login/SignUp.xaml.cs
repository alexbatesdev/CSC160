using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlobalStuff.loginPage = new LoginPage();
            GlobalStuff.loginPage.Show();
            GlobalStuff.signUpPage.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            ht.Clear();

            sql = "SELECT * FROM Users WHERE Username=@Username OR Email=@Email";
            ht.Add("@Username", UsernameTextBox.Text);
            ht.Add("@Email", EmailTextBox.Text);
            dt = ExDB.GetDataTable("ApplicationDevelopement", ht, sql);

            Regex regex = new Regex(@"^((?=\S*?[A-Z])(?=\S*?[a-z])(?=\S*?[0-9]).{6,})\S$", RegexOptions.Compiled);
            if (!regex.IsMatch(PasswordTextBox.Text))
            {
                MessageBox.Show("Password must be at least 6 characters long and contain at least one uppercase letter, one lowercase letter and one number");
            }
            else if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "" || EmailTextBox.Text == "" || NameTextBox.Text == "")
            {
                MessageBox.Show("Don't leave any of the fields blank");
            } else if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Username or Email Already Exists");
            }
            else
            {
                ht.Clear();
                sql = "INSERT INTO Users (Username, Password, Email, Name) VALUES (@Username, @Password, @Email, @Name)";
                ht.Add("@Username", UsernameTextBox.Text);
                ht.Add("@Password", PasswordTextBox.Text);
                ht.Add("@Email", EmailTextBox.Text);
                ht.Add("@Name", NameTextBox.Text);
                ExDB.ExecuteIt("ApplicationDevelopement", sql, ht);
                GlobalStuff.loginPage = new LoginPage();
                GlobalStuff.loginPage.Show();
                GlobalStuff.signUpPage.Close();
            }

            
        }
    }
}
