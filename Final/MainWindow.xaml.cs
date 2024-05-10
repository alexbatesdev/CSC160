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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Style_Click(object sender, RoutedEventArgs e)
        {
            if (FindResource("LoremFontSize").ToString() == 10.ToString())
            {
                Resources["LoremForeGround"] = new SolidColorBrush(Colors.Blue);
                Resources["LoremFontFamily"] = new FontFamily("Comic Sans MS");
                Resources["LoremFontSize"] = (double)20;
            } else
            {
                Resources["LoremForeGround"] = new SolidColorBrush(Colors.Black);
                Resources["LoremFontFamily"] = new FontFamily("Calibri");
                Resources["LoremFontSize"] = (double)10;
            }
        }

        private void Button_DB_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql = "UPDATE People SET LastName = 'Joestar' WHERE FirstName = @FirstName";
            ht.Clear();
            ht.Add("@FirstName", "Joseph");
            ExDB.ExecuteIt("ApplicationDevelopement", sql, ht);

            sql = "SELECT * FROM People";
            ht.Clear();
            dt = ExDB.GetDataTable("ApplicationDevelopement", ht, sql);
            DataGrid.ItemsSource = dt.DefaultView;
            MessageBox.Show("Replaced the lastname of all Josephs with Joestar");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql = "INSERT INTO People (FirstName, LastName) VALUES (@FirstName, @LastName)";
            ht.Clear();
            ht.Add("@FirstName", "Joseph");
            ht.Add("@LastName", "Shull");
            ExDB.ExecuteIt("ApplicationDevelopement", sql, ht);
            
            
            sql = "SELECT * FROM People";
            ht.Clear();
            dt = ExDB.GetDataTable("ApplicationDevelopement", ht, sql);
            DataGrid.ItemsSource = dt.DefaultView;
            MessageBox.Show("Joseph Shull inserted into Table");
        }

        private void Button_EXT_Click(object sender, RoutedEventArgs e)
        {
            string loremText = FindResource("LoremText").ToString();
            Resources["LoremText"] = loremText.toggleCAPS();
            MessageBox.Show("Extension Method LoremIpsum.toggleCAPS() called");
        }

        private void Button_POK_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(8);
            Resources["PokemonImage"] = new BitmapImage(new Uri("pack://application:,,,/Resources/" + num + ".png"));
        }

        private void StringBuildButton_Click(object sender, RoutedEventArgs e)
        {
            string WebDesign = "supercalifragilisticexpialidocious"; //
            StringBuilder SpiderMan = new StringBuilder(); // supercalifragilisticexpialidocious
            List<String> WordBank = new List<string>() { 
                "Super", "Venom", "Iron", "Man",
                "Tactical", "sniffer", "Mysterio", "raging rhyno", 
                "league of evil", "SQUIDGAME", "justice", "experienced", 
                "Speed Dial 911", "kid arachnid", "Doc Ock",                            
                "Sorry for the iou, I'm out of cash", "Spiderman", "Octavious" };

            //Manual

            //SpiderMan.Append(WordBank[0]);
            //SpiderMan.Append(WordBank[4].Substring(WordBank[4].IndexOf("cal")));

            //Auto
            string webShot = "";
            for (int carnage = 0; carnage < WordBank.Count; carnage++)
            {
                //MessageBox.Show("Word: "+ WordBank[carnage]);
                for (int venom = 0; venom < WordBank[carnage].Length; venom++)
                {
                    int longestMatch = 0;
                    string match;
                    //MessageBox.Show("1st Char at index " + venom + ": " + WordBank[carnage][venom].ToString());
                    for (int edgySpiderMan = WordBank[carnage].Length - venom; edgySpiderMan > 0; edgySpiderMan--)
                    {
                        string checkedWord = WordBank[carnage].Substring(
                                                venom,
                                                edgySpiderMan
                                            ).ToLower();
                        //MessageBox.Show("Checked Substring: " + checkedWord);
                        if (WebDesign.ToLower().StartsWith(checkedWord))
                        {
                            match = WordBank[carnage].Substring(venom, edgySpiderMan);
                            //MessageBox.Show("Grabbed Word: " + match + " Length: " + match.Length);
                            
                            if (match.Length > longestMatch)
                            {
                                longestMatch = match.Length;
                                webShot = match;
                            }

                            
                        }
                    }
                    
                }
                if (webShot.Length > 0)
                {
                    //MessageBox.Show("Webbing >--------------------------<-<-<<{" + webShot + "}");
                    SpiderMan.Append(webShot.ToLower());
                    WebDesign = WebDesign.Remove(0, webShot.Length);
                    //MessageBox.Show("Remaining Word to Build: " + WebDesign);
                    webShot = "";
                }
            }


            StringBuildMe.Text = SpiderMan.ToString();



        }

        private void GenericsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Generic Functions just happened, I think you just missed it actually");

            double? value = Add(3.23452, 5);
            string stringy = concat(Window_Loaded, StringBuildButton_Click);

            double? Add<T, V>(T number_in1, V number_in2) {
                string char1 = number_in1.ToString();
                string char2 = number_in2.ToString();

                Double number_1;
                Double number_2;
                bool isNumeric = Double.TryParse(char1, out number_1);
                if (!isNumeric) return null;
                Double.TryParse(char2, out number_2);

                return number_1 + number_2;
            }

            string concat<T, V>(T thingy, V linguini)
            {
                return thingy.ToString() + linguini.ToString();
            }
        }

        private void Fork_Click(object sender, RoutedEventArgs e)
        {
            Fork fork = new Fork();
            fork.Show();
        }
    }
}
