namespace Sockets
{
    partial class Cliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPortaHost = new System.Windows.Forms.TextBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnEnviarArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arquivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Porta:";
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.Location = new System.Drawing.Point(36, 118);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(194, 20);
            this.txtEnderecoIP.TabIndex = 4;
            // 
            // txtPortaHost
            // 
            this.txtPortaHost.Location = new System.Drawing.Point(36, 177);
            this.txtPortaHost.Name = "txtPortaHost";
            this.txtPortaHost.Size = new System.Drawing.Size(194, 20);
            this.txtPortaHost.TabIndex = 5;
            // 
            // txtArquivo
            // 
            this.txtArquivo.Location = new System.Drawing.Point(36, 245);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(250, 20);
            this.txtArquivo.TabIndex = 6;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(292, 243);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 7;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // btnEnviarArquivo
            // 
            this.btnEnviarArquivo.Location = new System.Drawing.Point(94, 313);
            this.btnEnviarArquivo.Name = "btnEnviarArquivo";
            this.btnEnviarArquivo.Size = new System.Drawing.Size(192, 29);
            this.btnEnviarArquivo.TabIndex = 8;
            this.btnEnviarArquivo.Text = "Enviar";
            this.btnEnviarArquivo.UseVisualStyleBackColor = true;
            this.btnEnviarArquivo.Click += new System.EventHandler(this.BtnEnviarArquivo_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 369);
            this.Controls.Add(this.btnEnviarArquivo);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.txtPortaHost);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.TextBox txtPortaHost;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnEnviarArquivo;
    }
}

