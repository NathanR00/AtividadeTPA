using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAPP1
{
    public partial class frmingressos : Form
    {
        public frmingressos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int publico = int.Parse(txtpublico.Text);
            int tipo = int.Parse(txttipo.Text);
            double result = 0;

            if (tipo == 1) {
                result = publico * 0.10 * 5;
            }
            else
            {
                if (tipo == 2)
                {
                    result = publico * 0.50 * 10;
                }
                else
                {
                    if (tipo == 3)
                    {
                        result = publico * 0.30 * 20;
                    }
                    else
                    {
                        if (tipo == 4)
                        {
                            result = publico * 0.10 * 30;
                        }
                        else
                        {
                            if (tipo == 5)
                            {
                                result = (publico * 0.10 * 5) +(publico * 0.50 * 10) + (publico * 0.30 * 20) + (publico * 0.10 * 30);
                         }
                            else
                            {
                                MessageBox.Show("opção invalida! Escolha um ingresso entre 1 a 5");
                                return;
                            }
                        }
                    }
                }
            }
            lblresult.Text = "Renda Total: R$" + result.ToString("f2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtpublico.Clear();
            txttipo.Clear();
            lblresult.Text = "Renda Total:";
            
            txtpublico.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
