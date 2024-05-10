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
using System.Data;
using System.Collections;
using System.Linq;
using System.Windows.Media.Media3D;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for DB.xaml
    /// </summary>
    public partial class DB : Window
    {

        //People ds = new People();
        //WpfApp1.PeopleTableAdapters.PeopleTableAdapter ta = new WpfApp1.PeopleTableAdapters.PeopleTableAdapter();

        public DB()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt;
            Hashtable ht = new Hashtable();
            string sql;
            long returnedID;

            //ta.Insert("Joseph", "Joestar");

            //People.PeopleDataTable dt2 = new People.PeopleDataTable();
            //ta.Fill(dt2);

            //People.PeopleRow dr = (People.PeopleRow)dt2.NewRow();
            //dr.FirstName = "Jotaro";
            //dr.LastName = "Kujo";
            //dt2.AddPeopleRow(dr);
            //ta.Update(dt2);



            //MyDataGrid.ItemsSource = dt2.DefaultView;

            // LINQ
            //var s = (from People in dt2 where People.ID == 3 select People.FirstName);
            //ResultLabel.Content = s.First().ToString();

            //dt2 = ta.GetData();
            //People.PeopleRow dr = dt2.FindByID(3) as People.PeopleRow;
            //3 is the primary key

            ht.Clear();
            sql = "SELECT * FROM People";
            ////sql = "SELECT * FROM People WHERE ID=@ID";
            //ht.Add("@ID", 3);
            dt = ExDB.GetDataTable("ApplicationDevelopement", ht, sql);
            MyDataGrid.ItemsSource = dt.DefaultView;

            DataRow dr;
            dr = dt.Rows[0];
            int x = (int)dr["ID"];
            ResultLabel.Content = x.ToString();
            ResultLabel.Content = dr["FirstName"];

            //if (dt.Rows.Count > 0)
            //{
            //    ResultLabel.Content = "Found";
            //}
            //else
            //{
            //    ResultLabel.Content = "Not Found";
            //}

            ht.Clear();
            sql = "INSERT INTO People (FirstName, LastName) VALUES (@FirstName, @LastName)";
            ht.Add("@FirstName", "John");
            ht.Add("@LastName", "Smith");
            returnedID = ExDB.ExecuteIt("ApplicationDevelopement", sql, ht);
            ResultLabel.Content = returnedID.ToString();

            ht.Clear();
            sql = "UPDATE People SET FirstName=@FirstName, LastName=@LastName WHERE ID=@ID";
            ht.Add("@FirstName", "Sigmund");
            ht.Add("@LastName", "Froid");
            ht.Add("@ID", 6);
            returnedID = ExDB.ExecuteIt("ApplicationDevelopement", sql, ht);

            ht.Clear();
            sql = "DELETE FROM People WHERE FirstName=@FirstName";
            ht.Add("@FirstName", "John");
            returnedID = ExDB.ExecuteIt("ApplicationDevelopement", sql, ht);

        }
    }
}
