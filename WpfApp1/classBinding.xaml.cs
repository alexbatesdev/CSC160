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
    /// Interaction logic for classBinding.xaml
    /// </summary>
    public partial class classBinding : Window
    {
        private Game game;
        public classBinding()
        {
            InitializeComponent();
            game = new Game();
            this.DataContext = game;
        }

        private void setTitleButton_Click(object sender, RoutedEventArgs e)
        {
            game.Randomize();
        }
    }
}
