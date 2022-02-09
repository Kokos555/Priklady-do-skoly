using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo = Convert.ToInt32(textBox1.Text);
            int faktorial = 1;
            for (int i = 2; i <= cislo; i++)
            {
                faktorial *= i;
            }
            label1.Text = string.Format("Faktrial z cisla {0} je {1}", cislo, faktorial);
        }
    }
}
