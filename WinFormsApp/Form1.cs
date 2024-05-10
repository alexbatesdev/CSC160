namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void myButton_Click(object sender, EventArgs e)
        {
            myLabel.Text = myTextBox.Text;
        }

        private void myTextBox_DoubleClick(object sender, EventArgs e)
        {
            //load form2
            Form2 form2 = new Form2();
            form2.ShowDialog();
            
        }
    }
}