using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio11_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double l1, l2, l3;
            l1 = Convert.ToDouble(txt_lado1.Text);
            l2 = Convert.ToDouble(txt_lado2.Text);
            l3 = Convert.ToDouble(txt_lado3.Text);
            if (l1 == 0 || l2 == 0 || l3 == 0)
            {
                MessageBox.Show("Não é um triângulo.");
            }
            else if (l1 == l2 && l2 == l3)
            {
                MessageBox.Show("Triângulo Equilátero");
            }
            else if ((l1 != l2 && l2 == l3) || (l2 != l3 && l3 == l1))
            {
                MessageBox.Show("Triângulo Isósceles");
            }
            else if (l1 != l2 && l2 != l3)
            {
                MessageBox.Show("Triângulo Escaleno");
            }
        }
    }
}
