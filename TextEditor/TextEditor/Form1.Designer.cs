namespace TextEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLetterColorBlack = new System.Windows.Forms.Button();
            this.btnLetterColorPurple = new System.Windows.Forms.Button();
            this.btnLetterColorGreen = new System.Windows.Forms.Button();
            this.btnLetterColorBlue = new System.Windows.Forms.Button();
            this.btnLetterColorRed = new System.Windows.Forms.Button();
            this.btnBackgroundColorBlue = new System.Windows.Forms.Button();
            this.btnBackgroundColorPurple = new System.Windows.Forms.Button();
            this.btnBackgroundColorGreen = new System.Windows.Forms.Button();
            this.btnBackgroundColorPink = new System.Windows.Forms.Button();
            this.btnBackgroundColorWhite = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Times New Roman",
            "Calibri ",
            "Monotype Corsiva"});
            this.comboBox1.Location = new System.Drawing.Point(16, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBold.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBold.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBold.Location = new System.Drawing.Point(218, 12);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(28, 26);
            this.btnBold.TabIndex = 1;
            this.btnBold.Text = "B";
            this.btnBold.UseVisualStyleBackColor = false;
            this.btnBold.Click += new System.EventHandler(this.button1_Click);
            this.btnBold.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBold_Paint);
            // 
            // btnItalic
            // 
            this.btnItalic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnItalic.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Italic);
            this.btnItalic.Location = new System.Drawing.Point(252, 12);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(28, 26);
            this.btnItalic.TabIndex = 2;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = false;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUnderline.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnderline.Location = new System.Drawing.Point(286, 12);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(28, 26);
            this.btnUnderline.TabIndex = 3;
            this.btnUnderline.Text = "U";
            this.btnUnderline.UseVisualStyleBackColor = false;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(332, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color of letters:";
            // 
            // btnLetterColorBlack
            // 
            this.btnLetterColorBlack.BackColor = System.Drawing.Color.Black;
            this.btnLetterColorBlack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetterColorBlack.Location = new System.Drawing.Point(459, 12);
            this.btnLetterColorBlack.Name = "btnLetterColorBlack";
            this.btnLetterColorBlack.Size = new System.Drawing.Size(28, 26);
            this.btnLetterColorBlack.TabIndex = 5;
            this.btnLetterColorBlack.UseVisualStyleBackColor = false;
            this.btnLetterColorBlack.Click += new System.EventHandler(this.btnLetterColorBlack_Click);
            // 
            // btnLetterColorPurple
            // 
            this.btnLetterColorPurple.BackColor = System.Drawing.Color.Purple;
            this.btnLetterColorPurple.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetterColorPurple.Location = new System.Drawing.Point(494, 12);
            this.btnLetterColorPurple.Name = "btnLetterColorPurple";
            this.btnLetterColorPurple.Size = new System.Drawing.Size(28, 26);
            this.btnLetterColorPurple.TabIndex = 6;
            this.btnLetterColorPurple.UseVisualStyleBackColor = false;
            this.btnLetterColorPurple.Click += new System.EventHandler(this.btnLetterColorPurple_Click);
            // 
            // btnLetterColorGreen
            // 
            this.btnLetterColorGreen.BackColor = System.Drawing.Color.Green;
            this.btnLetterColorGreen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetterColorGreen.Location = new System.Drawing.Point(529, 12);
            this.btnLetterColorGreen.Name = "btnLetterColorGreen";
            this.btnLetterColorGreen.Size = new System.Drawing.Size(28, 26);
            this.btnLetterColorGreen.TabIndex = 7;
            this.btnLetterColorGreen.UseVisualStyleBackColor = false;
            this.btnLetterColorGreen.Click += new System.EventHandler(this.btnLetterColorGreen_Click);
            // 
            // btnLetterColorBlue
            // 
            this.btnLetterColorBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnLetterColorBlue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetterColorBlue.Location = new System.Drawing.Point(599, 12);
            this.btnLetterColorBlue.Name = "btnLetterColorBlue";
            this.btnLetterColorBlue.Size = new System.Drawing.Size(28, 26);
            this.btnLetterColorBlue.TabIndex = 9;
            this.btnLetterColorBlue.UseVisualStyleBackColor = false;
            this.btnLetterColorBlue.Click += new System.EventHandler(this.btnLetterColorBlue_Click);
            // 
            // btnLetterColorRed
            // 
            this.btnLetterColorRed.BackColor = System.Drawing.Color.Red;
            this.btnLetterColorRed.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLetterColorRed.Location = new System.Drawing.Point(564, 12);
            this.btnLetterColorRed.Name = "btnLetterColorRed";
            this.btnLetterColorRed.Size = new System.Drawing.Size(28, 26);
            this.btnLetterColorRed.TabIndex = 8;
            this.btnLetterColorRed.UseVisualStyleBackColor = false;
            this.btnLetterColorRed.Click += new System.EventHandler(this.btnLetterColorRed_Click);
            // 
            // btnBackgroundColorBlue
            // 
            this.btnBackgroundColorBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBackgroundColorBlue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundColorBlue.Location = new System.Drawing.Point(950, 12);
            this.btnBackgroundColorBlue.Name = "btnBackgroundColorBlue";
            this.btnBackgroundColorBlue.Size = new System.Drawing.Size(28, 26);
            this.btnBackgroundColorBlue.TabIndex = 15;
            this.btnBackgroundColorBlue.UseVisualStyleBackColor = false;
            this.btnBackgroundColorBlue.Click += new System.EventHandler(this.btnBackgroundColorBlue_Click);
            // 
            // btnBackgroundColorPurple
            // 
            this.btnBackgroundColorPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackgroundColorPurple.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundColorPurple.Location = new System.Drawing.Point(845, 12);
            this.btnBackgroundColorPurple.Name = "btnBackgroundColorPurple";
            this.btnBackgroundColorPurple.Size = new System.Drawing.Size(28, 26);
            this.btnBackgroundColorPurple.TabIndex = 14;
            this.btnBackgroundColorPurple.UseVisualStyleBackColor = false;
            this.btnBackgroundColorPurple.Click += new System.EventHandler(this.btnBackgroundColorPurple_Click);
            // 
            // btnBackgroundColorGreen
            // 
            this.btnBackgroundColorGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBackgroundColorGreen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundColorGreen.Location = new System.Drawing.Point(880, 12);
            this.btnBackgroundColorGreen.Name = "btnBackgroundColorGreen";
            this.btnBackgroundColorGreen.Size = new System.Drawing.Size(28, 26);
            this.btnBackgroundColorGreen.TabIndex = 13;
            this.btnBackgroundColorGreen.UseVisualStyleBackColor = false;
            this.btnBackgroundColorGreen.Click += new System.EventHandler(this.btnBackgroundColorGreen_Click);
            // 
            // btnBackgroundColorPink
            // 
            this.btnBackgroundColorPink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackgroundColorPink.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundColorPink.Location = new System.Drawing.Point(915, 12);
            this.btnBackgroundColorPink.Name = "btnBackgroundColorPink";
            this.btnBackgroundColorPink.Size = new System.Drawing.Size(28, 26);
            this.btnBackgroundColorPink.TabIndex = 12;
            this.btnBackgroundColorPink.UseVisualStyleBackColor = false;
            this.btnBackgroundColorPink.Click += new System.EventHandler(this.btnBackgroundColorPink_Click);
            // 
            // btnBackgroundColorWhite
            // 
            this.btnBackgroundColorWhite.BackColor = System.Drawing.Color.White;
            this.btnBackgroundColorWhite.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBackgroundColorWhite.Location = new System.Drawing.Point(810, 12);
            this.btnBackgroundColorWhite.Name = "btnBackgroundColorWhite";
            this.btnBackgroundColorWhite.Size = new System.Drawing.Size(28, 26);
            this.btnBackgroundColorWhite.TabIndex = 11;
            this.btnBackgroundColorWhite.UseVisualStyleBackColor = false;
            this.btnBackgroundColorWhite.Click += new System.EventHandler(this.btnBackgroundColorWhite_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(641, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Color of background:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1049, 522);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(921, 617);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 27);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(999, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(66, 26);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(999, 617);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 27);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button16_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.comboBox2.Location = new System.Drawing.Point(168, 14);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(44, 24);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 625);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Project name:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(123, 617);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 27);
            this.textBox1.TabIndex = 22;
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::TextEditor.Properties.Resources.Left;
            this.btnLeft.Location = new System.Drawing.Point(16, 44);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(54, 37);
            this.btnLeft.TabIndex = 23;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click_1);
            // 
            // btnCenter
            // 
            this.btnCenter.Image = global::TextEditor.Properties.Resources.Center;
            this.btnCenter.Location = new System.Drawing.Point(75, 44);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(54, 37);
            this.btnCenter.TabIndex = 24;
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnRight
            // 
            this.btnRight.Image = global::TextEditor.Properties.Resources.Right;
            this.btnRight.Location = new System.Drawing.Point(134, 44);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(54, 37);
            this.btnRight.TabIndex = 25;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnBackgroundColorBlue);
            this.Controls.Add(this.btnBackgroundColorPurple);
            this.Controls.Add(this.btnBackgroundColorGreen);
            this.Controls.Add(this.btnBackgroundColorPink);
            this.Controls.Add(this.btnBackgroundColorWhite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLetterColorBlue);
            this.Controls.Add(this.btnLetterColorRed);
            this.Controls.Add(this.btnLetterColorGreen);
            this.Controls.Add(this.btnLetterColorPurple);
            this.Controls.Add(this.btnLetterColorBlack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Text editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLetterColorBlack;
        private System.Windows.Forms.Button btnLetterColorPurple;
        private System.Windows.Forms.Button btnLetterColorGreen;
        private System.Windows.Forms.Button btnLetterColorBlue;
        private System.Windows.Forms.Button btnLetterColorRed;
        private System.Windows.Forms.Button btnBackgroundColorBlue;
        private System.Windows.Forms.Button btnBackgroundColorPurple;
        private System.Windows.Forms.Button btnBackgroundColorGreen;
        private System.Windows.Forms.Button btnBackgroundColorPink;
        private System.Windows.Forms.Button btnBackgroundColorWhite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnRight;
    }
}

