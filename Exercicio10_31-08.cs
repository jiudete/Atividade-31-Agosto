using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio10_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double peso, altura, r;
            peso = Convert.ToDouble(txt_peso.Text);
            altura = Convert.ToDouble(txt_altura.Text);
            r = peso / Math.Pow(altura, 2);
            if (r < 20 )
            {
                MessageBox.Show("Abaixo do peso");
            }
            else if (20 <= r && r < 25)
            {
                MessageBox.Show("Peso ideal");
            }
            else if (r >= 25)
            {
                MessageBox.Show("Acima do peso");
            }
        }
    }
}
