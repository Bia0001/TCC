namespace Sistema.Ifsp.View
{
    partial class frmPessoasFisicas
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
            this.dgvPessoaFisica = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelecionarPessoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaFisica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPessoaFisica
            // 
            this.dgvPessoaFisica.AllowUserToAddRows = false;
            this.dgvPessoaFisica.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPessoaFisica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoaFisica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPessoaFisica.Location = new System.Drawing.Point(12, 64);
            this.dgvPessoaFisica.MultiSelect = false;
            this.dgvPessoaFisica.Name = "dgvPessoaFisica";
            this.dgvPessoaFisica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoaFisica.Size = new System.Drawing.Size(733, 390);
            this.dgvPessoaFisica.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RG";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnSelecionarPessoa
            // 
            this.btnSelecionarPessoa.Location = new System.Drawing.Point(670, 475);
            this.btnSelecionarPessoa.Name = "btnSelecionarPessoa";
            this.btnSelecionarPessoa.Size = new System.Drawing.Size(75, 23);
            this.btnSelecionarPessoa.TabIndex = 1;
            this.btnSelecionarPessoa.Text = "Selecionar pessoa";
            this.btnSelecionarPessoa.UseVisualStyleBackColor = true;
            this.btnSelecionarPessoa.Click += new System.EventHandler(this.btnSelecionarPessoa_Click);
            // 
            // frmPessoasFisicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 510);
            this.Controls.Add(this.btnSelecionarPessoa);
            this.Controls.Add(this.dgvPessoaFisica);
            this.Name = "frmPessoasFisicas";
            this.Text = "frmPessoasFisicas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoaFisica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPessoaFisica;
        private System.Windows.Forms.Button btnSelecionarPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}