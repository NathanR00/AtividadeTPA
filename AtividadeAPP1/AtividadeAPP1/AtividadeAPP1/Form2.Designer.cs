namespace AtividadeAPP1
{
    partial class frmfareinheit
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
            this.lblcelsius = new System.Windows.Forms.Label();
            this.lblfahrenheit = new System.Windows.Forms.Label();
            this.txtcelsius = new System.Windows.Forms.TextBox();
            this.txtfahrenheit = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcelsius
            // 
            this.lblcelsius.AutoSize = true;
            this.lblcelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcelsius.Location = new System.Drawing.Point(165, 62);
            this.lblcelsius.Name = "lblcelsius";
            this.lblcelsius.Size = new System.Drawing.Size(329, 24);
            this.lblcelsius.TabIndex = 0;
            this.lblcelsius.Text = "Digite o número em graus celsius:";
            this.lblcelsius.Click += new System.EventHandler(this.lblcelsius_Click);
            // 
            // lblfahrenheit
            // 
            this.lblfahrenheit.AutoSize = true;
            this.lblfahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfahrenheit.Location = new System.Drawing.Point(165, 114);
            this.lblfahrenheit.Name = "lblfahrenheit";
            this.lblfahrenheit.Size = new System.Drawing.Size(380, 24);
            this.lblfahrenheit.TabIndex = 2;
            this.lblfahrenheit.Text = "Temperatura convertida em Fahrenheit:";
            // 
            // txtcelsius
            // 
            this.txtcelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelsius.Location = new System.Drawing.Point(591, 62);
            this.txtcelsius.Name = "txtcelsius";
            this.txtcelsius.Size = new System.Drawing.Size(135, 29);
            this.txtcelsius.TabIndex = 4;
            // 
            // txtfahrenheit
            // 
            this.txtfahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfahrenheit.Location = new System.Drawing.Point(591, 111);
            this.txtfahrenheit.Name = "txtfahrenheit";
            this.txtfahrenheit.ReadOnly = true;
            this.txtfahrenheit.Size = new System.Drawing.Size(135, 29);
            this.txtfahrenheit.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(169, 214);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(116, 32);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(340, 214);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(89, 32);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(526, 214);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 32);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmfareinheit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtfahrenheit);
            this.Controls.Add(this.txtcelsius);
            this.Controls.Add(this.lblfahrenheit);
            this.Controls.Add(this.lblcelsius);
            this.Name = "frmfareinheit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "conversão para fahreinheit";
            this.Load += new System.EventHandler(this.frmfareinheit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcelsius;
        private System.Windows.Forms.Label lblfahrenheit;
        private System.Windows.Forms.TextBox txtcelsius;
        private System.Windows.Forms.TextBox txtfahrenheit;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}