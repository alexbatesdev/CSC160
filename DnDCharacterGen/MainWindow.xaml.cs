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

namespace DnDCharacterGen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Character character;
        private bool keepName;
        public MainWindow()
        {
            InitializeComponent();
            character = new Character();
            this.DataContext = character;
            this.keepName = true;
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            character.Randomize(this.keepName ? NameInput.Text : "");
        }

        private void KeepNameButton_Click(object sender, RoutedEventArgs e)
        {
            keepName = !keepName;
            KeepNameCheckBox.IsChecked = keepName;
        }
    }
}
