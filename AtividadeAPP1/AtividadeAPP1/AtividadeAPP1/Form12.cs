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
    public partial class frmimc : Form
    {
        public frmimc()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            double altura, peso, IMC;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            IMC = peso / Math.Pow(altura, 2);

            if (IMC < 17)
            {
                txtimc.Text = IMC.ToString();
                txtclassificacao.Text = "magreza severa";
            }
            else if (IMC >= 17 && IMC < 18.5)
            {
                txtimc.Text = IMC.ToString();
                txtclassificacao.Text = "magreza leve";
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                txtimc.Text = IMC.ToString();
                txtclassificacao.Text = "peso normal";
            }
            else if (IMC >= 25 && IMC < 30)
            {
                txtimc.Text = IMC.ToString();
                txtclassificacao.Text = "sobrepeso";
            }
            else if (IMC >= 30 && IMC < 35)
            {
                txtimc.Text = IMC.ToString();
                txtclassificacao.Text = "obesidade classe I";
            }
            else if (IMC >= 35 && IMC < 40)
            {
                txtimc.Text = IMC.ToString();
                txtclassificacao.Text = "obesidade classe II";
            }
            else if (IMC >= 40)
            {
                txtimc.Text = IMC.ToString();
                txtclassificacao.Text = "obesidade classe III";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtaltura.Clear();
            txtimc.Clear();
            txtclassificacao.Clear();
            txtpeso.Clear();
            txtpeso.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
 }

