using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (comboBox2.SelectedIndex == -1)
            {
                comboBox2.SelectedIndex = 0;
            }
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
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.SelectedIndex = 0;
            }
            string selectedFont = comboBox1.Text;
            int selectedSize = int.Parse(comboBox2.Text);
            richTextBox1.Font = new Font(selectedFont, selectedSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Bold == true)
                {
                    newFontStyle = FontStyle.Regular;
                    btnBold.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    newFontStyle = FontStyle.Bold;
                    btnBold.BackColor = Color.Silver;
                }

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Italic == true)
                {
                    newFontStyle = FontStyle.Regular;
                    btnBold.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    newFontStyle = FontStyle.Italic;
                    btnBold.BackColor = Color.Silver;
                }

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (richTextBox1.SelectionFont.Underline == true)
                {
                    newFontStyle = FontStyle.Regular;
                    btnBold.BackColor = Color.WhiteSmoke;
                }
                else
                {
                    newFontStyle = FontStyle.Underline;
                    btnBold.BackColor = Color.Silver;
                }

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.ForeColor = Color.Black;
            richTextBox1.BackColor = Color.White;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string projectName = textBox1.Text + ".doc";
            if (File.Exists(projectName))
            {
                DialogResult result = MessageBox.Show($"{projectName} already exists. Do you want to replace it?", "Convirming \"Save\"", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    richTextBox1.SaveFile(projectName);
                }
            }
            else
            {
                richTextBox1.SaveFile(projectName);
            }
        }

        private void btnBold_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
