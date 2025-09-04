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
    public partial class frmcasa : Form
    {
        public frmcasa()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Int32 codigo;
            codigo = Convert.ToInt32(txtcodigo.Text);
            switch (codigo)
            {
                case 100:
                    txtproduto.Text = "Cachorro Quente";
                    txtpreco.Text = "25,00";
                    break;
                case 101:
                    txtproduto.Text = "Bauru";
                    txtpreco.Text = "15,00";
                    break;
                case 102:
                    txtproduto.Text = "X-burguer";
                    txtpreco.Text = "35,00";
                    break;
                case 103:
                    txtproduto.Text = "Triplo X-Burguer";
                    txtpreco.Text = "47,00";
                    break;
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtproduto.Clear();
            txtpreco.Clear();
            txtcodigo.Clear();
            txtcodigo.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}