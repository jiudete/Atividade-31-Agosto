using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio9_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double b, a, area;

            b = Convert.ToDouble(txt_base.Text);
            a = Convert.ToDouble(txt_altura.Text);
            area = b * a;
            if (area > 100)
            {
                MessageBox.Show("~Terreno Grande.");
            }
            else
            {
                MessageBox.Show("Terreno Pequeno.");
            }
        }
    }
}
