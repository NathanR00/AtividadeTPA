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
    public partial class frmarea : Form
    {
        public frmarea()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double raio, result;
            raio = Convert.ToDouble(txtraio.Text);
            result = 3.14 * (raio * raio);
            txtresult.Text = result.ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtraio.Clear();
            txtresult.Clear();

            txtraio.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
            menu.Show();
        }

        private void lblraio_Click(object sender, EventArgs e)
        {

        }
    }
}
