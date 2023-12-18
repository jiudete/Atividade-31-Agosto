using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio7_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            double n1, n2;
            n1 = Convert.ToDouble(txt_numero1.Text);
            n2 = Convert.ToDouble(txt_numero2.Text);

            if (n1 > n2)
            {
                MessageBox.Show("O primeiro número digitado é maior que o segundo." + n1);
            }
            else if (n2 > n1)
            {
                MessageBox.Show("O segundo número digitado é maior que o primeiro. " + n2);
            }
            else if (n1 == n2)
            {
                MessageBox.Show("Número são iguais.");
            }
        }
    }
}
