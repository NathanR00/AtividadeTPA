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
    public partial class frmfareinheit : Form
    {
        public frmfareinheit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblcelsius_Click(object sender, EventArgs e)
        {

        }

        private void frmfareinheit_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double c, result;
            c= Convert.ToDouble (txtcelsius.Text);
            result = (c * 1.8) + 32;
            txtfahrenheit.Text = result.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcelsius.Clear();
            txtfahrenheit.Clear();
            txtcelsius.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu menu = new frmmenu();
           
            menu.Show();
        }
    }
}
