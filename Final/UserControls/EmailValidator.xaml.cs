using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final.UserControls
{
    /// <summary>
    /// Interaction logic for EmailValidator.xaml
    /// </summary>
    public partial class EmailValidator : UserControl
    {
        public EmailValidator()
        {
            InitializeComponent();
        }

        private void Email_in_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex regex = new Regex(@"^((?!\.)[\w-_.]*[^.])(@\w+)(\.\w+(\.\w+)?[^.\W])$");
            if (regex.IsMatch(Email_in.Text))
            {
                Resources["isValid"] = new SolidColorBrush(Colors.Green);
                isValid.Content = "Valid";
            }
            else
            {
                Resources["isValid"] = new SolidColorBrush(Colors.Red);
                isValid.Content = "Invalid";
            }
        }
    }
}
