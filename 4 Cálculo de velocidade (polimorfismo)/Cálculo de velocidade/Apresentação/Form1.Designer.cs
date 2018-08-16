namespace Cálculo_de_velocidade
{
    partial class frmPrincipal
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
            this.lblDistancia = new System.Windows.Forms.Label();
            this.txbDistancia = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.txbTempo = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.lblPriscillaRizzardo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(53, 27);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(130, 13);
            this.lblDistancia.TabIndex = 0;
            this.lblDistancia.Text = "Informe a distância em km";
            // 
            // txbDistancia
            // 
            this.txbDistancia.Location = new System.Drawing.Point(56, 43);
            this.txbDistancia.Name = "txbDistancia";
            this.txbDistancia.Size = new System.Drawing.Size(115, 20);
            this.txbDistancia.TabIndex = 1;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(53, 66);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(129, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Informe o tempo em horas";
            // 
            // txbTempo
            // 
            this.txbTempo.Location = new System.Drawing.Point(56, 82);
            this.txbTempo.Name = "txbTempo";
            this.txbTempo.Size = new System.Drawing.Size(115, 20);
            this.txbTempo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(75, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(22, 158);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 5;
            this.lblResposta.Text = "Resposta";
            // 
            // lblPriscillaRizzardo
            // 
            this.lblPriscillaRizzardo.AutoSize = true;
            this.lblPriscillaRizzardo.Location = new System.Drawing.Point(76, 209);
            this.lblPriscillaRizzardo.Name = "lblPriscillaRizzardo";
            this.lblPriscillaRizzardo.Size = new System.Drawing.Size(130, 13);
            this.lblPriscillaRizzardo.TabIndex = 6;
            this.lblPriscillaRizzardo.Text = "Made by Priscilla Rizzardo";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(246, 244);
            this.Controls.Add(this.lblPriscillaRizzardo);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbTempo);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txbDistancia);
            this.Controls.Add(this.lblDistancia);
            this.Name = "frmPrincipal";
            this.Text = "Cálculo de velocidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.TextBox txbDistancia;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox txbTempo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Label lblPriscillaRizzardo;
    }
}

