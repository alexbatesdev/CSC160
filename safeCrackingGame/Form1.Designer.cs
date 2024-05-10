namespace safeCrackingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.digit1 = new System.Windows.Forms.NumericUpDown();
            this.digit1Hint = new System.Windows.Forms.PictureBox();
            this.digit3 = new System.Windows.Forms.NumericUpDown();
            this.digit2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.guessBox = new System.Windows.Forms.GroupBox();
            this.secondLastGuess = new System.Windows.Forms.Label();
            this.lastGuess = new System.Windows.Forms.Label();
            this.cheatButton = new System.Windows.Forms.Button();
            this.digit2Hint = new System.Windows.Forms.PictureBox();
            this.digit3Hint = new System.Windows.Forms.PictureBox();
            this.startResetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1Hint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).BeginInit();
            this.guessBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit2Hint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3Hint)).BeginInit();
            this.SuspendLayout();
            // 
            // digit1
            // 
            this.digit1.Enabled = false;
            this.digit1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit1.Location = new System.Drawing.Point(12, 118);
            this.digit1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(83, 74);
            this.digit1.TabIndex = 0;
            this.digit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // digit1Hint
            // 
            this.digit1Hint.Location = new System.Drawing.Point(12, 38);
            this.digit1Hint.Name = "digit1Hint";
            this.digit1Hint.Size = new System.Drawing.Size(83, 74);
            this.digit1Hint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.digit1Hint.TabIndex = 3;
            this.digit1Hint.TabStop = false;
            // 
            // digit3
            // 
            this.digit3.Enabled = false;
            this.digit3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit3.Location = new System.Drawing.Point(225, 118);
            this.digit3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(83, 74);
            this.digit3.TabIndex = 4;
            this.digit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // digit2
            // 
            this.digit2.Enabled = false;
            this.digit2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digit2.Location = new System.Drawing.Point(118, 118);
            this.digit2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(83, 74);
            this.digit2.TabIndex = 5;
            this.digit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Safe Cracker";
            // 
            // submitButton
            // 
            this.submitButton.Enabled = false;
            this.submitButton.Location = new System.Drawing.Point(12, 202);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(296, 29);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // guessBox
            // 
            this.guessBox.Controls.Add(this.secondLastGuess);
            this.guessBox.Controls.Add(this.lastGuess);
            this.guessBox.Location = new System.Drawing.Point(12, 272);
            this.guessBox.Name = "guessBox";
            this.guessBox.Size = new System.Drawing.Size(296, 95);
            this.guessBox.TabIndex = 8;
            this.guessBox.TabStop = false;
            this.guessBox.Text = "Attempted Guesses";
            // 
            // secondLastGuess
            // 
            this.secondLastGuess.AutoSize = true;
            this.secondLastGuess.Location = new System.Drawing.Point(6, 54);
            this.secondLastGuess.Name = "secondLastGuess";
            this.secondLastGuess.Size = new System.Drawing.Size(58, 20);
            this.secondLastGuess.TabIndex = 1;
            this.secondLastGuess.Text = "guess 2";
            // 
            // lastGuess
            // 
            this.lastGuess.AutoSize = true;
            this.lastGuess.Location = new System.Drawing.Point(6, 23);
            this.lastGuess.Name = "lastGuess";
            this.lastGuess.Size = new System.Drawing.Size(58, 20);
            this.lastGuess.TabIndex = 0;
            this.lastGuess.Text = "guess 1";
            // 
            // cheatButton
            // 
            this.cheatButton.Enabled = false;
            this.cheatButton.Location = new System.Drawing.Point(12, 237);
            this.cheatButton.Name = "cheatButton";
            this.cheatButton.Size = new System.Drawing.Size(296, 29);
            this.cheatButton.TabIndex = 9;
            this.cheatButton.Text = "Cheat";
            this.cheatButton.UseVisualStyleBackColor = true;
            this.cheatButton.Click += new System.EventHandler(this.cheatButton_Click);
            // 
            // digit2Hint
            // 
            this.digit2Hint.Location = new System.Drawing.Point(118, 38);
            this.digit2Hint.Name = "digit2Hint";
            this.digit2Hint.Size = new System.Drawing.Size(83, 74);
            this.digit2Hint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.digit2Hint.TabIndex = 10;
            this.digit2Hint.TabStop = false;
            // 
            // digit3Hint
            // 
            this.digit3Hint.Location = new System.Drawing.Point(225, 38);
            this.digit3Hint.Name = "digit3Hint";
            this.digit3Hint.Size = new System.Drawing.Size(83, 74);
            this.digit3Hint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.digit3Hint.TabIndex = 11;
            this.digit3Hint.TabStop = false;
            // 
            // startResetButton
            // 
            this.startResetButton.Location = new System.Drawing.Point(12, 373);
            this.startResetButton.Name = "startResetButton";
            this.startResetButton.Size = new System.Drawing.Size(145, 29);
            this.startResetButton.TabIndex = 12;
            this.startResetButton.Text = "Start";
            this.startResetButton.UseVisualStyleBackColor = true;
            this.startResetButton.Click += new System.EventHandler(this.startResetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(165, 373);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(145, 29);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 411);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startResetButton);
            this.Controls.Add(this.digit3Hint);
            this.Controls.Add(this.digit2Hint);
            this.Controls.Add(this.cheatButton);
            this.Controls.Add(this.guessBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit1Hint);
            this.Controls.Add(this.digit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit1Hint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).EndInit();
            this.guessBox.ResumeLayout(false);
            this.guessBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit2Hint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3Hint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown digit1;
        private PictureBox digit1Hint;
        private NumericUpDown digit3;
        private NumericUpDown digit2;
        private Label label1;
        private Button submitButton;
        private GroupBox guessBox;
        private Label secondLastGuess;
        private Label lastGuess;
        private Button cheatButton;
        private PictureBox digit2Hint;
        private PictureBox digit3Hint;
        private Button startResetButton;
        private Button exitButton;
    }
}