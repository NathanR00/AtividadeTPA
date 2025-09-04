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
    public partial class frmsalarios : Form
    {
        public frmsalarios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salario, idade, resultado, acrescimo = 0;
            string sexo, nome;
            sexo = txtsexo.Text;
            salario = Convert.ToDouble(txtsalario.Text);
            idade = Convert.ToDouble(txtidade.Text);

            if (sexo == "M" && idade >= 30)
            {
                acrescimo = 100;
            }
            else if (sexo == "M" && idade < 30)
            {
                acrescimo = 50;
            }
            else if (sexo == "F" && idade >= 30)
            {
                acrescimo = 250;
            }
            else if (sexo == "F" && idade < 30)
            {
                acrescimo = 150;
            }

            resultado = salario + acrescimo;

            nome = txtnome.Text;

            txtnomefinal.Text = nome.ToString();

            txtresultado.Text = resultado.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
            txtidade.Clear();
            txtsalario.Clear();
            txtnomefinal.Clear();
            txtresultado.Clear();
            txtsexo.Clear();

            txtnome.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            this.Hide();
            menu.Show();
        }
    }

    }

      
