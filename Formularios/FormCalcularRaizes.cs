using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadoraDiversa.Formularios
{
    public partial class FormCalcularRaizes : Form
    {
        public FormCalcularRaizes()
        {
            InitializeComponent();
        }

        private void cbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbOperacao.SelectedIndex;

            cbOperacao.SelectedItem = null;
            txtBase.Clear();
            txtExpoente.Clear();
            txtResultado.Clear();
            txtExpoente.ReadOnly = false;


            switch (index)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        lblBase.Text = "Informe o radicando:";
                        lblExpoente.Text = "Índice:";
                        txtExpoente.Text = "2";
                        txtExpoente.ReadOnly = true;
                        break;
                    }
                case 2:
                    {
                        lblBase.Text = "Informe o radicando:";
                        lblExpoente.Text = "Índice:";
                        txtExpoente.Text = "3";
                        txtExpoente.ReadOnly = true;
                        break;
                    }
                case 3:
                    {
                        lblBase.Text = "Informe o radicando:";
                        lblExpoente.Text = "Informe o índice:";
                        break;
                    }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int index = cbOperacao.SelectedIndex;
            double bases = 0;
            double expoente = 0;
            double resultado = 0;

            switch (index)
            {
                case 0:
                    {
                        bases = Convert.ToDouble(txtBase.Text);
                        expoente = Convert.ToDouble(txtExpoente.Text);
                        resultado = Math.Pow(bases, expoente);
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
                case 1:
                    {
                        bases = Convert.ToDouble(txtBase.Text);
                        resultado = Math.Sqrt(bases);
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
                case 2:
                    {
                        bases = Convert.ToDouble(txtBase.Text);
                        resultado = Math.Pow(bases, (1.0/3.0));
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
                case 3:
                    {
                        bases = Convert.ToDouble(txtBase.Text);
                        expoente = Convert.ToDouble(txtExpoente.Text);
                        resultado = Math.Pow(bases, 1 / expoente);
                        txtResultado.Text = resultado.ToString();
                        break;
                    }
            }
    }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbOperacao.SelectedItem = null;
            txtBase.Clear();
            txtExpoente.Clear();
            txtResultado.Clear();
        }
    }
}
