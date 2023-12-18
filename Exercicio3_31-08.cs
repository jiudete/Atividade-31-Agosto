using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio3_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double diag, aresta, area;
            diag = Convert.ToDouble(txt_diagonal.Text);
            aresta = diag / Math.Sqrt(2);
            area = aresta * aresta;
            MessageBox.Show("Sua área é igual a: "+area);
        }
    }
}
