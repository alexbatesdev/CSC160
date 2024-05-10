using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long rowCount;
            ht.Clear();

            sql = "SELECT * FROM Users WHERE Username=@Username and Password=@Password";
            ht.Add("@Username", UsernameTextBox.Text);
            ht.Add("@Password", PasswordTextBox.Text);
            dt = ExDB.GetDataTable("ApplicationDevelopement", ht, sql);

            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Username or Password left blank");
            }
            else if (dt.Rows.Count > 0)
            {
                GlobalStuff.user = UsernameTextBox.Text;
                GlobalStuff.homePage = new Home();
                GlobalStuff.homePage.Show();
                GlobalStuff.loginPage.Close();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GlobalStuff.signUpPage = new SignUp();
            GlobalStuff.signUpPage.Show();
            GlobalStuff.loginPage.Close();
        }
    }
}
