using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextOnShir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int i = richTextBox1.TextLength;
            label1.Text = "Количество символов: " + i.ToString();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = Clipboard.GetText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = richTextBox1.Size.Width;
            label2.Text = a.ToString();
            string s = richTextBox1.Text;
            char f = '\n';
            int max = 0;
            String[] substrings = s.Split(f);
            for (int i = 0; i < substrings.Length; i++)
            {
                if (substrings[i].Length > max)
                {
                    max = i;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = "Вызвать форму 2";
            Form2 Form2 = new Form2();
            Form2.Show();
        }
    }
}
