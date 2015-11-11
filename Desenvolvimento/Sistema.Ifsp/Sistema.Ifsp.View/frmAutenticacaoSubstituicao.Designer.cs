namespace Sistema.Ifsp.View
{
    partial class frmAutenticacaoSubstituicao
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
            this.txtUsuarioAtual = new System.Windows.Forms.TextBox();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerificarCredenciais = new System.Windows.Forms.Button();
            this.grpNovas = new System.Windows.Forms.GroupBox();
            this.txtSenhaNova1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioNovo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.grpAtuais = new System.Windows.Forms.GroupBox();
            this.txtSenhaNova2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpNovas.SuspendLayout();
            this.grpAtuais.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário atual:";
            // 
            // txtUsuarioAtual
            // 
            this.txtUsuarioAtual.Location = new System.Drawing.Point(20, 42);
            this.txtUsuarioAtual.Name = "txtUsuarioAtual";
            this.txtUsuarioAtual.Size = new System.Drawing.Size(311, 20);
            this.txtUsuarioAtual.TabIndex = 1;
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(20, 94);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.Size = new System.Drawing.Size(311, 20);
            this.txtSenhaAtual.TabIndex = 3;
            this.txtSenhaAtual.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha atual:";
            // 
            // btnVerificarCredenciais
            // 
            this.btnVerificarCredenciais.Location = new System.Drawing.Point(205, 133);
            this.btnVerificarCredenciais.Name = "btnVerificarCredenciais";
            this.btnVerificarCredenciais.Size = new System.Drawing.Size(126, 23);
            this.btnVerificarCredenciais.TabIndex = 4;
            this.btnVerificarCredenciais.Text = "Verificar Credenciais";
            this.btnVerificarCredenciais.UseVisualStyleBackColor = true;
            this.btnVerificarCredenciais.Click += new System.EventHandler(this.btnVerificarCredenciais_Click);
            // 
            // grpNovas
            // 
            this.grpNovas.Controls.Add(this.label5);
            this.grpNovas.Controls.Add(this.txtSenhaNova2);
            this.grpNovas.Controls.Add(this.btnAlterar);
            this.grpNovas.Controls.Add(this.txtSenhaNova1);
            this.grpNovas.Controls.Add(this.label4);
            this.grpNovas.Controls.Add(this.label3);
            this.grpNovas.Controls.Add(this.txtUsuarioNovo);
            this.grpNovas.Enabled = false;
            this.grpNovas.Location = new System.Drawing.Point(31, 190);
            this.grpNovas.Name = "grpNovas";
            this.grpNovas.Size = new System.Drawing.Size(353, 238);
            this.grpNovas.TabIndex = 5;
            this.grpNovas.TabStop = false;
            this.grpNovas.Text = "Novas Credenciais";
            // 
            // txtSenhaNova1
            // 
            this.txtSenhaNova1.Location = new System.Drawing.Point(20, 95);
            this.txtSenhaNova1.Name = "txtSenhaNova1";
            this.txtSenhaNova1.Size = new System.Drawing.Size(311, 20);
            this.txtSenhaNova1.TabIndex = 9;
            this.txtSenhaNova1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha:";
            // 
            // txtUsuarioNovo
            // 
            this.txtUsuarioNovo.Location = new System.Drawing.Point(20, 43);
            this.txtUsuarioNovo.Name = "txtUsuarioNovo";
            this.txtUsuarioNovo.Size = new System.Drawing.Size(311, 20);
            this.txtUsuarioNovo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuário:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(205, 188);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(126, 23);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.Text = "Alterar Credenciais";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // grpAtuais
            // 
            this.grpAtuais.Controls.Add(this.label1);
            this.grpAtuais.Controls.Add(this.txtUsuarioAtual);
            this.grpAtuais.Controls.Add(this.btnVerificarCredenciais);
            this.grpAtuais.Controls.Add(this.label2);
            this.grpAtuais.Controls.Add(this.txtSenhaAtual);
            this.grpAtuais.Location = new System.Drawing.Point(31, 12);
            this.grpAtuais.Name = "grpAtuais";
            this.grpAtuais.Size = new System.Drawing.Size(353, 172);
            this.grpAtuais.TabIndex = 6;
            this.grpAtuais.TabStop = false;
            this.grpAtuais.Text = "Credenciais Atuais";
            // 
            // txtSenhaNova2
            // 
            this.txtSenhaNova2.Location = new System.Drawing.Point(20, 150);
            this.txtSenhaNova2.Name = "txtSenhaNova2";
            this.txtSenhaNova2.Size = new System.Drawing.Size(311, 20);
            this.txtSenhaNova2.TabIndex = 11;
            this.txtSenhaNova2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Repita a nova senha:";
            // 
            // frmAutenticacaoSubstituicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 465);
            this.Controls.Add(this.grpAtuais);
            this.Controls.Add(this.grpNovas);
            this.Name = "frmAutenticacaoSubstituicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutenticacaoSubstituicao";
            this.grpNovas.ResumeLayout(false);
            this.grpNovas.PerformLayout();
            this.grpAtuais.ResumeLayout(false);
            this.grpAtuais.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuarioAtual;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerificarCredenciais;
        private System.Windows.Forms.GroupBox grpNovas;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtSenhaNova1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuarioNovo;
        private System.Windows.Forms.GroupBox grpAtuais;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenhaNova2;
    }
}