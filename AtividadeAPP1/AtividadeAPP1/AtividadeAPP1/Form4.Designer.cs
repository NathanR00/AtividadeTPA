namespace AtividadeAPP1
{
    partial class frmdolares
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
            this.txtreal = new System.Windows.Forms.TextBox();
            this.txtdolar = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.lblreal = new System.Windows.Forms.Label();
            this.lbldolar = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtreal
            // 
            this.txtreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreal.Location = new System.Drawing.Point(577, 87);
            this.txtreal.Margin = new System.Windows.Forms.Padding(4);
            this.txtreal.Name = "txtreal";
            this.txtreal.Size = new System.Drawing.Size(172, 34);
            this.txtreal.TabIndex = 0;
            // 
            // txtdolar
            // 
            this.txtdolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdolar.Location = new System.Drawing.Point(577, 155);
            this.txtdolar.Margin = new System.Windows.Forms.Padding(4);
            this.txtdolar.Name = "txtdolar";
            this.txtdolar.Size = new System.Drawing.Size(168, 34);
            this.txtdolar.TabIndex = 1;
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(425, 238);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(132, 34);
            this.txtresult.TabIndex = 2;
            // 
            // lblreal
            // 
            this.lblreal.AutoSize = true;
            this.lblreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreal.Location = new System.Drawing.Point(136, 87);
            this.lblreal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblreal.Name = "lblreal";
            this.lblreal.Size = new System.Drawing.Size(312, 29);
            this.lblreal.TabIndex = 3;
            this.lblreal.Text = "Digite um valor em Reais:";
            // 
            // lbldolar
            // 
            this.lbldolar.AutoSize = true;
            this.lbldolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldolar.Location = new System.Drawing.Point(136, 155);
            this.lbldolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldolar.Name = "lbldolar";
            this.lbldolar.Size = new System.Drawing.Size(345, 29);
            this.lbldolar.TabIndex = 4;
            this.lbldolar.Text = "Digite o valor atual do Dólar:";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresult.Location = new System.Drawing.Point(136, 238);
            this.lblresult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(259, 29);
            this.lblresult.TabIndex = 5;
            this.lblresult.Text = "Seu valor convertido:";
            this.lblresult.Click += new System.EventHandler(this.lblresult_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.AutoSize = true;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(299, 321);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(119, 41);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.AutoSize = true;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(454, 321);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(103, 41);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.AutoSize = true;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(603, 321);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 41);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmdolares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lbldolar);
            this.Controls.Add(this.lblreal);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtdolar);
            this.Controls.Add(this.txtreal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmdolares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter Reais para Dólares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtreal;
        private System.Windows.Forms.TextBox txtdolar;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label lblreal;
        private System.Windows.Forms.Label lbldolar;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}