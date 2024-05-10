namespace WinFormsApp
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
            this.myTextBox = new System.Windows.Forms.TextBox();
            this.myButton = new System.Windows.Forms.Button();
            this.myLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myTextBox
            // 
            this.myTextBox.Location = new System.Drawing.Point(336, 190);
            this.myTextBox.Multiline = true;
            this.myTextBox.Name = "myTextBox";
            this.myTextBox.PasswordChar = ' ';
            this.myTextBox.Size = new System.Drawing.Size(125, 67);
            this.myTextBox.TabIndex = 0;
            this.myTextBox.Text = "Spaghetti";
            this.myTextBox.DoubleClick += new System.EventHandler(this.myTextBox_DoubleClick);
            // 
            // myButton
            // 
            this.myButton.Location = new System.Drawing.Point(336, 276);
            this.myButton.Name = "myButton";
            this.myButton.Size = new System.Drawing.Size(142, 29);
            this.myButton.TabIndex = 1;
            this.myButton.Text = "View invisible ink";
            this.myButton.UseVisualStyleBackColor = true;
            this.myButton.Click += new System.EventHandler(this.myButton_Click);
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(269, 125);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(280, 20);
            this.myLabel.TabIndex = 2;
            this.myLabel.Text = "You write in this textbox with invisible ink";
            this.myLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myButton);
            this.Controls.Add(this.myTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox myTextBox;
        private Button myButton;
        private Label myLabel;
    }
}