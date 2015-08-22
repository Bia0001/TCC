namespace Sistema.Ifsp.View
{
    partial class frmListaPessoas
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
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.btnSelecionarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(37, 65);
            this.dgvAlunos.MultiSelect = false;
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(843, 389);
            this.dgvAlunos.TabIndex = 0;
            // 
            // btnSelecionarAluno
            // 
            this.btnSelecionarAluno.Location = new System.Drawing.Point(805, 464);
            this.btnSelecionarAluno.Name = "btnSelecionarAluno";
            this.btnSelecionarAluno.Size = new System.Drawing.Size(75, 41);
            this.btnSelecionarAluno.TabIndex = 1;
            this.btnSelecionarAluno.Text = "Selecionar Aluno";
            this.btnSelecionarAluno.UseVisualStyleBackColor = true;
            this.btnSelecionarAluno.Click += new System.EventHandler(this.btnSelecionarAluno_Click);
            // 
            // frmListaPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 517);
            this.Controls.Add(this.btnSelecionarAluno);
            this.Controls.Add(this.dgvAlunos);
            this.Name = "frmListaPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaPessoas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnSelecionarAluno;
    }
}