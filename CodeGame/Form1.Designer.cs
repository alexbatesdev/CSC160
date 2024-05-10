namespace CodeGame
{
    partial class NumberGuess
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
            this.mainButton = new System.Windows.Forms.Button();
            this.numberIn = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDifficulty = new System.Windows.Forms.GroupBox();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonMid = new System.Windows.Forms.RadioButton();
            this.radioButtonEZ = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guessTable = new System.Windows.Forms.TableLayoutPanel();
            this.guessLabel1 = new System.Windows.Forms.Label();
            this.guessLabel2 = new System.Windows.Forms.Label();
            this.guessLabel3 = new System.Windows.Forms.Label();
            this.guessLabel4 = new System.Windows.Forms.Label();
            this.guessLabel5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberIn)).BeginInit();
            this.groupBoxDifficulty.SuspendLayout();
            this.guessTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mainButton.Location = new System.Drawing.Point(405, 318);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(361, 91);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "OOOOO";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // numberIn
            // 
            this.numberIn.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberIn.Location = new System.Drawing.Point(405, 258);
            this.numberIn.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberIn.Name = "numberIn";
            this.numberIn.Size = new System.Drawing.Size(361, 54);
            this.numberIn.TabIndex = 1;
            this.numberIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberIn_KeyDown);
            // 
            // groupBoxDifficulty
            // 
            this.groupBoxDifficulty.Controls.Add(this.radioButtonHard);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonMid);
            this.groupBoxDifficulty.Controls.Add(this.radioButtonEZ);
            this.groupBoxDifficulty.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxDifficulty.Location = new System.Drawing.Point(405, 46);
            this.groupBoxDifficulty.Name = "groupBoxDifficulty";
            this.groupBoxDifficulty.Size = new System.Drawing.Size(361, 206);
            this.groupBoxDifficulty.TabIndex = 2;
            this.groupBoxDifficulty.TabStop = false;
            this.groupBoxDifficulty.Text = "JKL OM";
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Location = new System.Drawing.Point(17, 103);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(125, 41);
            this.radioButtonHard.TabIndex = 2;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "LLL";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            this.radioButtonHard.CheckedChanged += new System.EventHandler(this.radioButtonHard_CheckedChanged);
            // 
            // radioButtonMid
            // 
            this.radioButtonMid.AutoSize = true;
            this.radioButtonMid.Location = new System.Drawing.Point(17, 70);
            this.radioButtonMid.Name = "radioButtonMid";
            this.radioButtonMid.Size = new System.Drawing.Size(125, 41);
            this.radioButtonMid.TabIndex = 1;
            this.radioButtonMid.TabStop = true;
            this.radioButtonMid.Text = "KKK";
            this.radioButtonMid.UseVisualStyleBackColor = true;
            this.radioButtonMid.CheckedChanged += new System.EventHandler(this.radioButtonMid_CheckedChanged);
            // 
            // radioButtonEZ
            // 
            this.radioButtonEZ.AutoSize = true;
            this.radioButtonEZ.Location = new System.Drawing.Point(17, 31);
            this.radioButtonEZ.Name = "radioButtonEZ";
            this.radioButtonEZ.Size = new System.Drawing.Size(125, 41);
            this.radioButtonEZ.TabIndex = 0;
            this.radioButtonEZ.TabStop = true;
            this.radioButtonEZ.Text = "JJJ";
            this.radioButtonEZ.UseVisualStyleBackColor = true;
            this.radioButtonEZ.CheckedChanged += new System.EventHandler(this.radioButtonEZ_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "ABIMN";
            // 
            // guessTable
            // 
            this.guessTable.ColumnCount = 2;
            this.guessTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.guessTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.guessTable.Controls.Add(this.guessLabel1, 1, 0);
            this.guessTable.Controls.Add(this.guessLabel2, 1, 1);
            this.guessTable.Controls.Add(this.guessLabel3, 1, 2);
            this.guessTable.Controls.Add(this.guessLabel4, 1, 3);
            this.guessTable.Controls.Add(this.guessLabel5, 1, 4);
            this.guessTable.Controls.Add(this.pictureBox1, 0, 0);
            this.guessTable.Controls.Add(this.pictureBox2, 0, 1);
            this.guessTable.Controls.Add(this.pictureBox3, 0, 2);
            this.guessTable.Controls.Add(this.pictureBox4, 0, 3);
            this.guessTable.Controls.Add(this.pictureBox5, 0, 4);
            this.guessTable.Location = new System.Drawing.Point(12, 46);
            this.guessTable.Name = "guessTable";
            this.guessTable.RowCount = 5;
            this.guessTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.guessTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.guessTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.guessTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.guessTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.guessTable.Size = new System.Drawing.Size(361, 363);
            this.guessTable.TabIndex = 4;
            // 
            // guessLabel1
            // 
            this.guessLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guessLabel1.AutoSize = true;
            this.guessLabel1.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLabel1.Location = new System.Drawing.Point(200, 17);
            this.guessLabel1.Name = "guessLabel1";
            this.guessLabel1.Size = new System.Drawing.Size(51, 37);
            this.guessLabel1.TabIndex = 0;
            this.guessLabel1.Text = "u";
            this.guessLabel1.Click += new System.EventHandler(this.guessLabel1_Click);
            // 
            // guessLabel2
            // 
            this.guessLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guessLabel2.AutoSize = true;
            this.guessLabel2.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLabel2.Location = new System.Drawing.Point(200, 89);
            this.guessLabel2.Name = "guessLabel2";
            this.guessLabel2.Size = new System.Drawing.Size(51, 37);
            this.guessLabel2.TabIndex = 1;
            this.guessLabel2.Text = "u";
            this.guessLabel2.Click += new System.EventHandler(this.guessLabel2_Click);
            // 
            // guessLabel3
            // 
            this.guessLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guessLabel3.AutoSize = true;
            this.guessLabel3.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLabel3.Location = new System.Drawing.Point(200, 161);
            this.guessLabel3.Name = "guessLabel3";
            this.guessLabel3.Size = new System.Drawing.Size(51, 37);
            this.guessLabel3.TabIndex = 2;
            this.guessLabel3.Text = "u";
            this.guessLabel3.Click += new System.EventHandler(this.guessLabel3_Click);
            // 
            // guessLabel4
            // 
            this.guessLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guessLabel4.AutoSize = true;
            this.guessLabel4.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLabel4.Location = new System.Drawing.Point(200, 233);
            this.guessLabel4.Name = "guessLabel4";
            this.guessLabel4.Size = new System.Drawing.Size(51, 37);
            this.guessLabel4.TabIndex = 3;
            this.guessLabel4.Text = "u";
            this.guessLabel4.Click += new System.EventHandler(this.guessLabel4_Click);
            // 
            // guessLabel5
            // 
            this.guessLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guessLabel5.AutoSize = true;
            this.guessLabel5.Font = new System.Drawing.Font("Wingdings", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guessLabel5.Location = new System.Drawing.Point(200, 307);
            this.guessLabel5.Name = "guessLabel5";
            this.guessLabel5.Size = new System.Drawing.Size(51, 37);
            this.guessLabel5.TabIndex = 4;
            this.guessLabel5.Text = "u";
            this.guessLabel5.Click += new System.EventHandler(this.guessLabel5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(3, 147);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(84, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 219);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(84, 62);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(3, 291);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(84, 62);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // NumberGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 421);
            this.Controls.Add(this.guessTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDifficulty);
            this.Controls.Add(this.numberIn);
            this.Controls.Add(this.mainButton);
            this.Name = "NumberGuess";
            this.Text = "NumberGuess";
            this.Load += new System.EventHandler(this.NumberGuess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberIn)).EndInit();
            this.groupBoxDifficulty.ResumeLayout(false);
            this.groupBoxDifficulty.PerformLayout();
            this.guessTable.ResumeLayout(false);
            this.guessTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button mainButton;
        private NumericUpDown numberIn;
        private GroupBox groupBoxDifficulty;
        private RadioButton radioButtonHard;
        private RadioButton radioButtonMid;
        private RadioButton radioButtonEZ;
        private Label label1;
        private TableLayoutPanel guessTable;
        private Label guessLabel1;
        private Label guessLabel2;
        private Label guessLabel3;
        private Label guessLabel4;
        private Label guessLabel5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}