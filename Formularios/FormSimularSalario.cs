using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadoraDiversa.Formularios
{
    public partial class FormSimularSalario : Form
    {
        public FormSimularSalario()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            int index = cbCargo.SelectedIndex;
            double vendas = 0;
            double salario = 0;
            double total = 0;

            switch (index)
            {
                case 0:
                    {
                        vendas = Convert.ToDouble(txtVendas.Text);
                        salario = Convert.ToDouble(txtSalario.Text);
                        total = salario + (vendas * 0.02);
                        lbResultado.Text = "Cargo de vendedor " + cbCargo.SelectedItem.ToString() + "\nSalário final de " + total.ToString("C");
                        break;
                    }
                case 1:
                    {
                        vendas = Convert.ToDouble(txtVendas.Text);
                        salario = Convert.ToDouble(txtSalario.Text);
                        total = salario + (vendas * 0.05);
                        lbResultado.Text = "Cargo de vendedor " + cbCargo.SelectedItem.ToString() + "\nSalário final de " + total.ToString("C");
                        break;
                    }
                case 2:
                    {
                        vendas = Convert.ToDouble(txtVendas.Text);
                        salario = Convert.ToDouble(txtSalario.Text);
                        total = salario + (vendas * 0.07);
                        lbResultado.Text = "Cargo de vendedor " + cbCargo.SelectedItem.ToString() + "\nSalário final de " + total.ToString("C");
                        break;
                    }
                case 3:
                    {
                        vendas = Convert.ToDouble(txtVendas.Text);
                        salario = Convert.ToDouble(txtSalario.Text);
                        total = salario + (vendas * 0.1);
                        lbResultado.Text = "Cargo de vendedor " + cbCargo.SelectedItem.ToString() + "\nSalário final de " + total.ToString("C");
                        break;
                    }
                case 4:
                    {
                        vendas = Convert.ToDouble(txtVendas.Text);
                        salario = Convert.ToDouble(txtSalario.Text);
                        total = salario + (vendas * 0.12);
                        lbResultado.Text = "Cargo de vendedor " + cbCargo.SelectedItem.ToString() + "\nSalário final de " + total.ToString("C");
                        break;
                    }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbCargo.SelectedItem = null;
            txtSalario.Clear();
            txtVendas.Clear();
            lbResultado.Text = null;
        }
    }
}
