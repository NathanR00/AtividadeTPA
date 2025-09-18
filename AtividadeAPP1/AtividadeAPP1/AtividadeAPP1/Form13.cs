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
    public partial class frmnotas : Form
    {
        public frmnotas()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double media, ma, nota1, nota2, nota3;

            media = Convert.ToDouble(txtmedia.Text);
            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);

            ma = (nota1 + nota2 * 2 + nota3 * 3 + media) / 7;

            if (ma >= 90)
            {
                txtconceito.Text = "A";
                txtmensagem.Text = "Aprovado";

            }
            else if (ma >= 75 && ma < 90)
            {
                txtconceito.Text = "B";
                txtmensagem.Text = "Aprovado";

            }
            else if (ma>=60 && ma < 75)
            {
                txtconceito.Text = "C";
                txtmensagem.Text = "Aprovado";
            }
            else if (ma>=40 && ma < 60)
            {
                txtconceito.Text = "D";
                txtmensagem.Text = "Reprovado";

            }
            else
            {
                txtconceito.Text = "E";
                txtmensagem.Text = "Reprovado";

            }

            txtma.Text = ma.ToString();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtma.Clear();
            txtmedia.Clear();   
            txtconceito.Clear();
            txtmensagem.Clear();
            txtident.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
