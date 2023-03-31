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
    public partial class FormCalculadoraFinanceira : Form
    {
        public FormCalculadoraFinanceira()
        {
            InitializeComponent();
        }

        private void cbOpcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbOpcao.SelectedIndex;
            
            txtMontante.BackColor = SystemColors.Window;
            txtMontante.ReadOnly = false;

            txtCapital.BackColor = SystemColors.Window;
            txtCapital.ReadOnly = false;

            txtTaxa.BackColor = SystemColors.Window;
            txtTaxa.ReadOnly = false;

            txtTempo.BackColor = SystemColors.Window;
            txtTempo.ReadOnly = false;

            switch (index)
            {
                case 0: // montante
                    {
                        txtMontante.BackColor = Color.Gray;
                        txtMontante.ReadOnly = true;
                        break;
                    }
                case 1: // capital
                    {
                        txtCapital.BackColor = Color.Gray;
                        txtCapital.ReadOnly = true;
                        break;
                    }
                case 2: // tempo
                    {
                        txtTempo.BackColor = Color.Gray;
                        txtTempo.ReadOnly = true;
                        break;
                    }
                case 3: // taxa
                    {
                        txtTaxa.BackColor = Color.Gray;
                        txtTaxa.ReadOnly = true;
                        break;
                    }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int index = cbOpcao.SelectedIndex;

            double montante = 0;
            double capital = 0;
            double tempo = 0;
            double taxa = 0;
            double juros = 0;

            switch (index)
            {
                case 0:
                    {
                        capital = Convert.ToDouble(txtCapital.Text);
                        tempo = Convert.ToDouble(txtTaxa.Text);
                        taxa = Convert.ToDouble(txtTempo.Text) / 100;

                        montante = capital * (1 + taxa * tempo);
                        juros = montante - capital;

                        txtMontante.Text = montante.ToString("C");
                        txtJuros.Text = juros.ToString("C");
                        break;
                    }
                case 1:
                    {
                        montante = Convert.ToDouble(txtMontante.Text);
                        tempo = Convert.ToDouble(txtTaxa.Text);
                        taxa = Convert.ToDouble(txtTempo.Text) / 100;

                        capital = montante / (1 + taxa * tempo);
                        juros = montante - capital;

                        txtCapital.Text = capital.ToString("C");
                        txtJuros.Text = juros.ToString("C");
                        break;
                    }
                case 2:
                    {
                        montante = Convert.ToDouble(txtMontante.Text);
                        capital = Convert.ToDouble(txtCapital.Text);
                        taxa = Convert.ToDouble(txtTaxa.Text) / 100;

                        tempo = (montante - capital) / (capital * taxa);
                        juros = montante - capital;

                        txtTempo.Text = tempo.ToString();
                        txtJuros.Text = juros.ToString("C");
                        break;
                    }
                case 3:
                    {
                        montante = Convert.ToDouble(txtMontante.Text);
                        capital = Convert.ToDouble(txtCapital.Text);
                        tempo = Convert.ToDouble(txtTempo.Text);

                        taxa = ((montante - capital) / (capital * tempo)) * 100;
                        juros = montante - capital;

                        txtTaxa.Text = taxa.ToString();
                        txtJuros.Text = juros.ToString("C");
                        break;
                    }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            cbOpcao.SelectedItem = null;
            txtMontante.Text = string.Empty;
            txtCapital.Text = string.Empty;
            txtTaxa.Text = string.Empty;
            txtTempo.Text = string.Empty;
            txtJuros.Text = string.Empty;
        }
    }
}
