using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio6_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            double dolar, cotacao, reais;
            dolar = Convert.ToDouble(txt_dolar.Text);
            cotacao = Convert.ToDouble(txt_cotacao.Text);
            reais = dolar * cotacao;
            MessageBox.Show("R$ "+reais);
        }
    }
}
