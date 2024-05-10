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
using System.Windows.Shapes;

namespace Login
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlobalStuff.loginPage = new LoginPage();
            GlobalStuff.loginPage.Show();
            GlobalStuff.homePage.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GlobalStuff username = new GlobalStuff();
            this.DataContext = username;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<string> secrets = new List<string> 
            { 
                "42!", 
                "Chocolate", 
                "Nothing Matters so Everything Matters", 
                "Nobody will know you the same way you do", 
                "You will never know yourself in the same way others do",
                "Be Kind",
                "You are not the same person you were yesterday",
                "You are not the same person you will be tomorrow",
                "Everything",
                "There is no secret ingredient", 
                "There is no secret",
                "What makes the dragon warrior the dragon warrior is the dragon warrior",
                "Spaghetti is your friend, they are coming.",
                "Call loved ones, the chartruse is not alone",
                "Worry about the things you can control",
                "Don't worry about the things you can't control",
                "Everyone is just hanging out",
                "Don't be a dick"
            };
            string secret = secrets[new Random().Next(0, secrets.Count)];
            MessageBox.Show("The secret is... " + secret);
        }
    }
}
