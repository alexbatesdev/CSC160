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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Controls.xaml
    /// </summary>
    public partial class Controls : Window
    {
        public Controls()
        {
            InitializeComponent();
        }

        private void PanicButton_Click(object sender, RoutedEventArgs e)
        {
            textInfo.Text = "Panic Button Clicked";
            PanicButton.Content = "OH NO!";
            img.Source = new BitmapImage(new Uri("Resources/incorrect-icon.png", UriKind.Relative));
        }
    }
}
