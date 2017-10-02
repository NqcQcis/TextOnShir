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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Парус Белеет парус одинокой В тумане моря голубом!.. Что ищет он в стране далекой? Что кинул он в краю родном?... Играют волны — ветер свищет," +
                "_Парус" +
"Белеет парус одинокой ";
        }
    }
}
