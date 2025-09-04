namespace AtividadeAPP1
{
    partial class frmdistanciaelitos
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
            this.lbltemp = new System.Windows.Forms.Label();
            this.lblvel = new System.Windows.Forms.Label();
            this.txttemp = new System.Windows.Forms.TextBox();
            this.txtvel = new System.Windows.Forms.TextBox();
            this.lbldist = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdist = new System.Windows.Forms.TextBox();
            this.txtlit = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemp.Location = new System.Drawing.Point(112, 101);
            this.lbltemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(388, 29);
            this.lbltemp.TabIndex = 0;
            this.lbltemp.Text = "Forneça o tempo da viagem (H):";
            // 
            // lblvel
            // 
            this.lblvel.AutoSize = true;
            this.lblvel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvel.Location = new System.Drawing.Point(112, 153);
            this.lblvel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblvel.Name = "lblvel";
            this.lblvel.Size = new System.Drawing.Size(600, 58);
            this.lblvel.TabIndex = 1;
            this.lblvel.Text = "Forneça a velocidade média do automóvel (Km/h):\r\n\r\n";
            this.lblvel.Click += new System.EventHandler(this.lblvel_Click);
            // 
            // txttemp
            // 
            this.txttemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttemp.Location = new System.Drawing.Point(800, 101);
            this.txttemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttemp.Name = "txttemp";
            this.txttemp.Size = new System.Drawing.Size(132, 34);
            this.txttemp.TabIndex = 2;
            // 
            // txtvel
            // 
            this.txtvel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvel.Location = new System.Drawing.Point(800, 150);
            this.txtvel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvel.Name = "txtvel";
            this.txtvel.Size = new System.Drawing.Size(132, 34);
            this.txtvel.TabIndex = 3;
            // 
            // lbldist
            // 
            this.lbldist.AutoSize = true;
            this.lbldist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldist.Location = new System.Drawing.Point(400, 258);
            this.lbldist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldist.Name = "lbldist";
            this.lbldist.Size = new System.Drawing.Size(183, 29);
            this.lbldist.TabIndex = 4;
            this.lbldist.Text = "A distância foi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 316);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Litros usados:";
            // 
            // txtdist
            // 
            this.txtdist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdist.Location = new System.Drawing.Point(675, 258);
            this.txtdist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdist.Name = "txtdist";
            this.txtdist.ReadOnly = true;
            this.txtdist.Size = new System.Drawing.Size(132, 34);
            this.txtdist.TabIndex = 6;
            // 
            // txtlit
            // 
            this.txtlit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlit.Location = new System.Drawing.Point(675, 316);
            this.txtlit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtlit.Name = "txtlit";
            this.txtlit.ReadOnly = true;
            this.txtlit.Size = new System.Drawing.Size(132, 34);
            this.txtlit.TabIndex = 7;
            // 
            // btncalcular
            // 
            this.btncalcular.AutoSize = true;
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(147, 448);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(128, 42);
            this.btncalcular.TabIndex = 8;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.AutoSize = true;
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(309, 448);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(111, 42);
            this.btnlimpar.TabIndex = 9;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.AutoSize = true;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(476, 448);
            this.btnvoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(100, 42);
            this.btnvoltar.TabIndex = 10;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmdistanciaelitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtlit);
            this.Controls.Add(this.txtdist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbldist);
            this.Controls.Add(this.txtvel);
            this.Controls.Add(this.txttemp);
            this.Controls.Add(this.lblvel);
            this.Controls.Add(this.lbltemp);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmdistanciaelitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distância e litros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Label lblvel;
        private System.Windows.Forms.TextBox txttemp;
        private System.Windows.Forms.TextBox txtvel;
        private System.Windows.Forms.Label lbldist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdist;
        private System.Windows.Forms.TextBox txtlit;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}