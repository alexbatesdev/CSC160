using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Resources.xaml
    /// </summary>
    public partial class Resources : Window
    {
        public Resources()
        {
            InitializeComponent();

        }

        private void ChangeColorButton_Click(object sender, RoutedEventArgs e)
        {
            Resources["CompanyColor"] = new SolidColorBrush(Colors.Aqua);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StaticResourceButton.Content = FindResource("CompanyName");
            Resources["AppString"] = "New AppString";
            StaticResourceButton.Content = FindResource("AppString");

            Resources["Mucus"] = "Prime Time Slime Time";
            DynamicResourceButton.Content = FindResource("Mucus");

            DynamicResourceButton.Content = Properties.Settings.Default.ValueLOL;
        }
    }
}
