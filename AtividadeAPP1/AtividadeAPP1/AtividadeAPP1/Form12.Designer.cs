namespace AtividadeAPP1
{
    partial class frmimc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.txtclassificacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(193, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 26);
            this.label6.TabIndex = 21;
            this.label6.Text = "Digite seu peso:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtpeso.Location = new System.Drawing.Point(376, 90);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 29);
            this.txtpeso.TabIndex = 22;
            this.txtpeso.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(193, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Digite sua altura:";
            // 
            // txtaltura
            // 
            this.txtaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtaltura.Location = new System.Drawing.Point(376, 140);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 29);
            this.txtaltura.TabIndex = 24;
            // 
            // txtimc
            // 
            this.txtimc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtimc.Location = new System.Drawing.Point(234, 240);
            this.txtimc.Name = "txtimc";
            this.txtimc.ReadOnly = true;
            this.txtimc.Size = new System.Drawing.Size(100, 29);
            this.txtimc.TabIndex = 25;
            // 
            // txtclassificacao
            // 
            this.txtclassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtclassificacao.Location = new System.Drawing.Point(495, 240);
            this.txtclassificacao.Name = "txtclassificacao";
            this.txtclassificacao.ReadOnly = true;
            this.txtclassificacao.Size = new System.Drawing.Size(293, 29);
            this.txtclassificacao.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(145, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 27;
            this.label2.Text = "IMC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(342, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "Classificação:";
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnvoltar.Location = new System.Drawing.Point(495, 191);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(117, 31);
            this.btnvoltar.TabIndex = 32;
            this.btnvoltar.Text = "VOLTAR";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnlimpar.Location = new System.Drawing.Point(329, 191);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(117, 31);
            this.btnlimpar.TabIndex = 31;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnbuscar.Location = new System.Drawing.Point(188, 191);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(117, 31);
            this.btnbuscar.TabIndex = 30;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmimc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtclassificacao);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.label6);
            this.Name = "frmimc";
            this.Text = "IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.TextBox txtclassificacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnbuscar;
    }
}