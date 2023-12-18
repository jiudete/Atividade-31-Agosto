using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio5_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_converter_Click(object sender, EventArgs e)
        {
            double milha, metro, quilometro;
            milha = Convert.ToDouble(txt_milha.Text);
            metro = milha / 0.00062137;
            quilometro = metro / 1000;

            MessageBox.Show("Quilômetros: "+quilometro);
        }
    }
}
