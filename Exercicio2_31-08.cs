using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_31_08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aresta, area;
            aresta = Convert.ToDouble(txt_aresta.Text);
            area = aresta * aresta;
            MessageBox.Show("Sua área é igual a: "+area);
        }
    }
}
