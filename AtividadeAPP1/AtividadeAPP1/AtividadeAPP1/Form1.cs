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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

               

        private void tsmisair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmifahrenheit_Click(object sender, EventArgs e)
        {
            Hide();
            frmfareinheit fah = new frmfareinheit();
            fah.Show();
        }

        private void distânciaELitrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdistanciaelitos dislit = new frmdistanciaelitos();
            dislit.Show();
        }

        private void dólaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmdolares dol = new frmdolares();
            dol.Show();

        }

        private void quadradoDaSomaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiquadradodasoma_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmquadradodasoma quadrado = new frmquadradodasoma();
            quadrado.Show();
        }

        private void tsmiarea_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmarea area = new frmarea();
            area.Show();
        }

        private void tsmiingressos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmingressos ingresso = new frmingressos();
            ingresso.Show();
        }

        private void tsmilivros_Click(object sender, EventArgs e)
        {
            Hide();
            frmlivros livros = new frmlivros();
            livros.Show();
        }

        private void tsmisalarios_Click(object sender, EventArgs e)
        {
            Hide() ;
            frmsalarios salario = new frmsalarios();
            salario.Show();
        }

        private void tsmicasa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcasa casa = new frmcasa();
            casa.Show();
        }

        private void tsmiimc_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmimc imc = new frmimc();
            imc.Show();
        }
    }
}
