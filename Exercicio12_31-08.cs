using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio12_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cat1, cat2, hip, h;
            cat1 = Convert.ToDouble(txt_cat1.Text);
            cat2 = Convert.ToDouble(txt_cat2.Text);
            h = Math.Pow(cat1, 2) + Math.Pow(cat2, 2);
            hip = Math.Sqrt(h);
            MessageBox.Show("O valor da hipotenusa é: "+hip);
        }
    }
}
