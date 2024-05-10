namespace CodeGame
{
    public partial class NumberGuess : Form
    {
        Random turro = new Random();
        List<Label> turroo = new List<Label>();
        List<PictureBox> turrooo = new List<PictureBox>();
        int turroooo = 0; //secreet num
        int turrooooo = 0; //num guess
        int turroooooo = 0; //max limit for the random

        private void StartGame()
        {
            turroooo = turro.Next(1, turroooooo + 1);
            numberIn.Enabled = true;
            mainButton.Text = "MMMMM";
        }
        private void InitializeGame()
        {
            turroo.Add(guessLabel1);
            turroo.Add(guessLabel2);
            turroo.Add(guessLabel3);
            turroo.Add(guessLabel4);
            turroo.Add(guessLabel5);

            turrooo.Add(pictureBox1);
            turrooo.Add(pictureBox2);
            turrooo.Add(pictureBox3);
            turrooo.Add(pictureBox4);
            turrooo.Add(pictureBox5);
        }
        
        private void ResetGame()
        {
            turrooooo = 0;
            mainButton.Enabled = true;
            numberIn.Enabled = false;
            numberIn.Value = 0;
            mainButton.Text = "OOOOO";

            foreach (Label label in turroo)
                label.Text = "";

            foreach (PictureBox pictobox in turrooo)
                pictobox.Image = null;
        }

        public NumberGuess()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            if (mainButton.Text == "OOOOO")
            {
                StartGame();
            } else
            {
                ResetGame();
            }

        }

        private void NumberGuess_Load(object sender, EventArgs e)
        {
            InitializeGame();
            ResetGame();
        }

        private void radioButtonEZ_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                turroooooo = 10;
            }
        }

        private void radioButtonMid_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                turroooooo = 100;
            }
        }

        private void radioButtonHard_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                turroooooo = 1000;
            }
        }

        private void GameWon()
        {
            numberIn.Enabled = false;
            MessageBox.Show("You win! Unfortunately this text can't be wingdings");
            //Application.Exit();
        }

        private void GameLost()
        {
            numberIn.Enabled = false;
            MessageBox.Show("You lost, unfortunately this text can't be wingdings. The number was " + turroooo);
        }

        private void numberIn_KeyDown(object sender, KeyEventArgs e)
        {
            int turrooooooooooooo = (int)numberIn.Value;

            if (e.KeyCode == Keys.Enter)
            {
                if (turrooooooooooooo < turroooo)
                {
                    turroo[turrooooo].Text = "GGGGG";
                    turroo[turrooooo].ForeColor = Color.Red;
                    turrooo[turrooooo].Image = Properties.Resources.incorrect_icon;
                } else if (turrooooooooooooo > turroooo)
                {
                    turroo[turrooooo].Text = "HHHHH";
                    turroo[turrooooo].ForeColor = Color.Red;
                    turrooo[turrooooo].Image = Properties.Resources.incorrect_icon;
                } else if (turrooooooooooooo == turroooo)
                {
                    turroo[turrooooo].Text = "CCCCC";
                    turroo[turrooooo].ForeColor = Color.Green;
                    turrooo[turrooooo].Image = Properties.Resources.correct_icon;
                    GameWon();
                }
                turrooooo++;
                if (turrooooo >= 5)
                {
                    GameLost();
                    return;
                }
            }
        }

        private void guessLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guessLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guessLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guessLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guessLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}