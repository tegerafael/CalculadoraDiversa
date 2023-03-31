using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppCalculadoraDiversa.Formularios; // ter acesso aos formulários

namespace AppCalculadoraDiversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculadoraFinanceira_Click(object sender, EventArgs e)
        {
            FormCalculadoraFinanceira form = new FormCalculadoraFinanceira();
            form.ShowDialog();
        }

        private void btnCalcularDesconto_Click(object sender, EventArgs e)
        {
            FormCalcularDesconto form = new FormCalcularDesconto();
            form.ShowDialog();
        }

        private void btnCalcularRaizes_Click(object sender, EventArgs e)
        {
            FormCalcularRaizes form = new FormCalcularRaizes();
            form.ShowDialog();
        }

        private void btnSimularSalario_Click(object sender, EventArgs e)
        {
            FormSimularSalario form = new FormSimularSalario(); 
            form.ShowDialog();
        }
    }
}
