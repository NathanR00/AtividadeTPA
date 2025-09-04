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
    public partial class frmdistanciaelitos : Form
    {
        public frmdistanciaelitos()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double temp, vel, dist, lit;
            temp = Convert.ToDouble(txttemp.Text);
            vel = Convert.ToDouble(txtvel.Text);

            dist = temp * vel;
            lit = dist / 12;

            txtdist.Text = dist.ToString();
            txtlit.Text = lit.ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txttemp.Clear();
            txtvel.Clear();
            txtdist.Clear();
            txtlit.Clear();

            txttemp.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
