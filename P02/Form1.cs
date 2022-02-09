using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int apomocne = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            for (int i = 1; i < n; i++)
            {
                apomocne *= a;
            }
            label1.Text = string.Format("Cisla {0} umocnene na {1} je {2}", a, n, apomocne);
        }
    }
}
