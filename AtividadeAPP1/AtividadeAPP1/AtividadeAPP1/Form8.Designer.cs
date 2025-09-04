namespace AtividadeAPP1
{
    partial class frmingressos
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
            this.lblpublico = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtpublico = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblpublico
            // 
            this.lblpublico.AutoSize = true;
            this.lblpublico.Location = new System.Drawing.Point(134, 123);
            this.lblpublico.Name = "lblpublico";
            this.lblpublico.Size = new System.Drawing.Size(118, 13);
            this.lblpublico.TabIndex = 1;
            this.lblpublico.Text = "Qual foi o publico total?";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(131, 157);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(121, 13);
            this.lbltipo.TabIndex = 2;
            this.lbltipo.Text = "Qual o tipo de ingresso?";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(145, 198);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(96, 20);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "Renda total:";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(276, 150);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 4;
            // 
            // txtpublico
            // 
            this.txtpublico.Location = new System.Drawing.Point(276, 123);
            this.txtpublico.Name = "txtpublico";
            this.txtpublico.Size = new System.Drawing.Size(100, 20);
            this.txtpublico.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(398, 159);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(398, 120);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(398, 198);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 9;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmingressos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtpublico);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblpublico);
            this.Name = "frmingressos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ingressos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpublico;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtpublico;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
    }
}