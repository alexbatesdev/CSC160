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
    /// Interaction logic for dataBindin.xaml
    /// </summary>
    public partial class dataBindin : Window
    {

        List<Student> students = new List<Student>();
        public dataBindin()
        {
            InitializeComponent();

            DataContext = this;

            //manual binding via c#
            Binding binding = new Binding("Text");
            binding.Source = textValue;
            textData.SetBinding(TextBlock.TextProperty, binding);

            students.Add(new Student() { Id = 1, Name = "John" });
            students.Add(new Student() { Id = 2, Name = "Mary" });
            students.Add(new Student() { Id = 3, Name = "Peter" });
            listStudents.ItemsSource = students;
            dataGridStudents.ItemsSource = students;
            comboStudents.ItemsSource = students;
            comboStudents.DisplayMemberPath = "Name";
            comboStudents.SelectedValuePath = "Id";
            
        }

        private void updateButton(object sender, RoutedEventArgs e)
        {
            BindingExpression be = textTitle.GetBindingExpression(TextBox.TextProperty);

            be.UpdateSource();
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            int newId = students[students.Count - 1].Id + 1;
            students.Add(new Student() { Id = newId, Name = "Student " + newId });
            listStudents.Items.Refresh();
        }

        private void buttonRemove_Click(object sender, RoutedEventArgs e)
        {
            if (listStudents.SelectedItem != null)
            {
                students.Remove((Student)listStudents.SelectedItem);
            }
            listStudents.Items.Refresh();
        }

        private void buttonChange_Click(object sender, RoutedEventArgs e)
        {
            if (listStudents.SelectedItem != null)
            {
                ((Student)listStudents.SelectedItem).Name = "NewName" + ((Student)listStudents.SelectedItem).Id;
            }
            listStudents.Items.Refresh();
        }
    }

    class Student
    {
        public int Id { get; set; }
        private string name;
        public string Name { get; set; }
    }
}
