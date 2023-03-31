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
    public partial class FormCalcularDesconto : Form
    {
        public FormCalcularDesconto()
        {
            InitializeComponent();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbCliente.SelectedIndex;

            switch (index)
            {
                case 0:
                    {
                        lbResultado.Text = "Cliente do tipo " + cbCliente.Text + " recebe 3% de desconto";
                        break;
                    }
                case 1:
                    {
                        lbResultado.Text = "Cliente do tipo " + cbCliente.Text + " recebe 5% de desconto";
                        break;
                    }
                case 2:
                    {
                        lbResultado.Text = "Cliente do tipo " + cbCliente.Text + " recebe 10% de desconto";
                        break;
                    }
                case 3:
                    {
                        lbResultado.Text = "Cliente do tipo " + cbCliente.Text + " recebe 12% de desconto";
                        break;
                    }
            }
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            int index = cbCliente.SelectedIndex;
            double total = 0;
            double desconto = 0;
            double valorTotal = 0;

            switch (index)
            {
                case 0:
                    {
                        total = Convert.ToDouble(txtTotal.Text);
                        desconto = total * 0.03;
                        valorTotal = total * 0.97;
                        txtDesconto.Text = desconto.ToString("C");
                        txtFinal.Text = valorTotal.ToString("C");

                        break;
                    }
                case 1:
                    {
                        total = Convert.ToDouble(txtTotal.Text);
                        desconto = total * 0.05;
                        valorTotal = total * 0.95;
                        txtDesconto.Text = desconto.ToString("C");
                        txtFinal.Text = valorTotal.ToString("C");
                        break;
                    }
                case 2:
                    {
                        total = Convert.ToDouble(txtTotal.Text);
                        desconto = total * 0.10;
                        valorTotal = total * 0.90;
                        txtDesconto.Text = desconto.ToString("C");
                        txtFinal.Text = valorTotal.ToString("C");
                        break;
                    }
                case 3:
                    {
                        total = Convert.ToDouble(txtTotal.Text);
                        desconto = total * 0.12;
                        valorTotal = total * 0.88;
                        txtDesconto.Text = desconto.ToString("C");
                        txtFinal.Text = valorTotal.ToString("C");
                        break;
                    }
            }
        }

        private void btnNovoDesconto_Click(object sender, EventArgs e)
        {
            cbCliente.SelectedItem = null;
            txtTotal.Clear();
            txtDesconto.Clear();
            txtFinal.Clear();
            lbResultado.Text = "";
        }
    }
}
