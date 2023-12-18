using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio4_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double a, b, area;
            a = Convert.ToDouble(txt_altura.Text);
            b = Convert.ToDouble(txt_base.Text);
            area = a * b / 2;
            MessageBox.Show("Sua area é igual a: "+area);
        }
    }
}
