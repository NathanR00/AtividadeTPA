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
    public partial class frmdolares : Form
    {
        public frmdolares()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double real, dolar, result;

            real = Convert.ToDouble(txtreal.Text);
            dolar = Convert.ToDouble(txtdolar.Text);

            result = real / dolar;

            txtresult.Text = result.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtreal.Clear();
            txtdolar.Clear();
            txtresult.Clear();

            txtreal.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }
    }
}
