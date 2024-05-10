namespace safeCrackingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rando = new Random();
        List<int> secretCode = new List<int>();
        int guessAttemptCount = 0;
        private void startGame()
        {
            secretCode.Clear();
            secretCode.Add(rando.Next(0, 10));
            secretCode.Add(rando.Next(0, 10));
            secretCode.Add(rando.Next(0, 10));


            startResetButton.Text = "Reset";
            cheatButton.Enabled = true;
            submitButton.Enabled = true;
            digit1.Enabled = true;
            digit2.Enabled = true;
            digit3.Enabled = true;
            lastGuess.Text = "";
            secondLastGuess.Text = "";
            
        }

        private void restartGame()
        {
            digit1.Value = 0;
            digit2.Value = 0;
            digit3.Value = 0;
            digit1Hint.Image = null;
            digit2Hint.Image = null;
            digit3Hint.Image = null;
            guessAttemptCount = 0;
            startGame();
        }

        private void closeGame()
        {
            Application.Exit();
        }

        private void submitGuess()
        {
            guessAttemptCount++;
            List<int> guesses = new List<int> ();
            guesses.Add((int) digit1.Value);
            guesses.Add((int) digit2.Value);
            guesses.Add((int) digit3.Value);
            List<string> howClose = new List<string>();
            int correctGuessCount = 0;
            for (int i = 0; i < 3; i++)
            {
                if (Math.Abs(guesses[i] - secretCode[i]) >= 2)
                {
                    //off by 2 or more
                    if (i == 0)
                    {
                        digit1Hint.Image = Properties.Resources.offBy2;
                        howClose.Add("Not close");
                    } else if (i == 1)
                    {
                        digit2Hint.Image = Properties.Resources.offBy2;
                        howClose.Add("Not close");
                    } else if (i == 2)
                    {
                        digit3Hint.Image = Properties.Resources.offBy2;
                        howClose.Add("Not close");
                    }
                }
                else if (Math.Abs(guesses[i] - secretCode[i]) == 1)
                {
                    //digit 1 is close
                    if (i == 0)
                    {
                        digit1Hint.Image = Properties.Resources.offBy1;
                        howClose.Add("Close");
                    }
                    else if (i == 1)
                    {
                        digit2Hint.Image = Properties.Resources.offBy1;
                        howClose.Add("Close");
                    }
                    else if (i == 2)
                    {
                        digit3Hint.Image = Properties.Resources.offBy1;
                        howClose.Add("Close");
                    }
                }
                else if (guesses[i] == secretCode[i])
                {
                    if (i == 0)
                    {
                        digit1Hint.Image = Properties.Resources.offBy0;
                        howClose.Add("Correct");
                    }
                    else if (i == 1)
                    {
                        digit2Hint.Image = Properties.Resources.offBy0;
                        howClose.Add("Correct");
                    }
                    else if (i == 2)
                    {
                        digit3Hint.Image = Properties.Resources.offBy0;
                        howClose.Add("Correct");
                    }
                    //digit 1 is right on!
                    correctGuessCount++;
                }
            }

            if (correctGuessCount == 3)
            {
                MessageBox.Show("You guessed the code! Inside the safe you find 100 gold coins! " + guessAttemptCount + " of them turn out to be counterfeit chocolate coins.");
                //winGame
            } else
            {
                secondLastGuess.Text = lastGuess.Text;
                lastGuess.Text = guesses[0] + " - " + howClose[0] + ", " + guesses[1] + " - " + howClose[1] + ", " + guesses[2] + " - " + howClose[2];
            }
            if (guessAttemptCount == 100)
            {
                MessageBox.Show("As you enter your 100th guess the safe door falls off its hinges revealing 100 gold coins! Oh wait, they're all counterfiet chocolate coins and they're melting into a solid mass of foil and chocolate");
            }
        }

        private void cheat()
        {
            string message = "As you are trying to crack the code for this safe you notice an orange piece of paper sticking out from under the safe, it's a fallen stickynote with the code! ";
            message = message + "It reads: " + secretCode[0] + ", " + secretCode[1] + ", " + secretCode[2];
            MessageBox.Show(message);
        }

        private void startResetButton_Click(object sender, EventArgs e)
        {
            if (startResetButton.Text == "Start")
            {
                startGame();
            }
            else
            {
                restartGame();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            closeGame();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            submitGuess();
        }

        private void cheatButton_Click(object sender, EventArgs e)
        {
            cheat();
        }
    }
}