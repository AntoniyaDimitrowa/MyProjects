using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = comboBox1.Text;
            int selectedSize = int.Parse(comboBox2.Text);
            richTextBox1.Font = new Font(selectedFont, selectedSize);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFont = comboBox1.Text;
            int selectedSize = int.Parse(comboBox2.Text);
            richTextBox1.Font = new Font(selectedFont, selectedSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(richTextBox1.Font, FontStyle.Underline);
        }

        private void btnLetterColorBlack_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

        private void btnLetterColorPurple_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Purple;
        }

        private void btnLetterColorGreen_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void btnLetterColorRed_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void btnLetterColorBlue_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void btnBackgroundColorWhite_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
        }

        private void btnBackgroundColorPurple_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(192, 192, 255);
        }

        private void btnBackgroundColorGreen_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void btnBackgroundColorPink_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(255, 192, 255);
        }

        private void btnBackgroundColorBlue_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(192, 255, 255);
        }
    }
}
