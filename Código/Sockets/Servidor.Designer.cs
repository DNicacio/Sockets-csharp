namespace Sockets
{
    partial class Servidor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEnderecoIP = new System.Windows.Forms.TextBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.btnEstabelecerConexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço IP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Porta:";
            // 
            // txtEnderecoIP
            // 
            this.txtEnderecoIP.AllowDrop = true;
            this.txtEnderecoIP.Location = new System.Drawing.Point(33, 118);
            this.txtEnderecoIP.Name = "txtEnderecoIP";
            this.txtEnderecoIP.Size = new System.Drawing.Size(195, 20);
            this.txtEnderecoIP.TabIndex = 4;
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(33, 186);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(195, 20);
            this.txtPorta.TabIndex = 5;
            // 
            // btnEstabelecerConexao
            // 
            this.btnEstabelecerConexao.Location = new System.Drawing.Point(64, 236);
            this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
            this.btnEstabelecerConexao.Size = new System.Drawing.Size(225, 37);
            this.btnEstabelecerConexao.TabIndex = 6;
            this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
            this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
            this.btnEstabelecerConexao.Click += new System.EventHandler(this.BtnEstabelecerConexao_Click);
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 285);
            this.Controls.Add(this.btnEstabelecerConexao);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.txtEnderecoIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Servidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEnderecoIP;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Button btnEstabelecerConexao;
    }
}