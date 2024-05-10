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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            window.Title = "Gwergy";
            
        }

        double value;
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            value = e.NewValue;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            BananaBox.Text = value.ToString();
        }

        private void ComboRIP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            ComboBoxItem cbi = (ComboBoxItem)cbo.SelectedItem;
            MessageBox.Show(cbi.Content.ToString());
        }
    }
}
