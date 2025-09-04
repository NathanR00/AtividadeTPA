using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AtividadeAPP1
{
    public partial class frmlivros : Form
    {
        public frmlivros()
        {
            InitializeComponent();
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double quantidade, total;
            

            quantidade = Convert.ToDouble(txtquantidade.Text);

            if (quantidade <= 10){
                total = quantidade * 12;
            }
            else{
                total = (10 * 12) + ((quantidade - 10) * 8);
            }
                lblresultado.Text = total.ToString();
              
            }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtquantidade.Clear();
            lblresultado.Text = "Resultado:";

            txtquantidade.Focus();
        }
    }
    }
