namespace Sistema.Ifsp.View
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principal = new System.Windows.Forms.TabControl();
            this.tabSolicitacoes = new System.Windows.Forms.TabPage();
            this.txtMotivoAluno = new System.Windows.Forms.TextBox();
            this.txtPesquisarAluno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbSolicitacaoSaida = new System.Windows.Forms.CheckBox();
            this.ckbSolicitacaoEntrada = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProntuarioAluno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.rdbNomeAluno = new System.Windows.Forms.RadioButton();
            this.rdbProntuarioAluno = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContato2Aluno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContato1Aluno = new System.Windows.Forms.TextBox();
            this.txtResponsavel2Aluno = new System.Windows.Forms.TextBox();
            this.txtResponsavel1Aluno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControleEstacionamento = new System.Windows.Forms.TabPage();
            this.tabSolicitacoesSaidaFinalizadasExpiradas = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvSolicitacoesExpiradas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSolicitacoesFinalizadas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSolicitacoesSaidaAbertas = new System.Windows.Forms.TabPage();
            this.btnFinalizarSolicitacao = new System.Windows.Forms.Button();
            this.dgvSolicitacoesAbertas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.timerAtualizaSolicitacoes = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGerarSolicitacaoAluno = new System.Windows.Forms.Button();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.principal.SuspendLayout();
            this.tabSolicitacoes.SuspendLayout();
            this.tabSolicitacoesSaidaFinalizadasExpiradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoesExpiradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoesFinalizadas)).BeginInit();
            this.tabSolicitacoesSaidaAbertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoesAbertas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // principal
            // 
            this.principal.Controls.Add(this.tabSolicitacoes);
            this.principal.Controls.Add(this.tabControleEstacionamento);
            this.principal.Controls.Add(this.tabSolicitacoesSaidaFinalizadasExpiradas);
            this.principal.Controls.Add(this.tabSolicitacoesSaidaAbertas);
            this.principal.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.principal.Location = new System.Drawing.Point(42, 53);
            this.principal.Name = "principal";
            this.principal.SelectedIndex = 0;
            this.principal.Size = new System.Drawing.Size(1098, 593);
            this.principal.TabIndex = 1;
            this.principal.Tag = "";
            // 
            // tabSolicitacoes
            // 
            this.tabSolicitacoes.Controls.Add(this.panel1);
            this.tabSolicitacoes.Controls.Add(this.txtMotivoAluno);
            this.tabSolicitacoes.Controls.Add(this.txtPesquisarAluno);
            this.tabSolicitacoes.Controls.Add(this.label9);
            this.tabSolicitacoes.Controls.Add(this.ckbSolicitacaoSaida);
            this.tabSolicitacoes.Controls.Add(this.ckbSolicitacaoEntrada);
            this.tabSolicitacoes.Controls.Add(this.label8);
            this.tabSolicitacoes.Controls.Add(this.txtProntuarioAluno);
            this.tabSolicitacoes.Controls.Add(this.label7);
            this.tabSolicitacoes.Controls.Add(this.txtNomeAluno);
            this.tabSolicitacoes.Controls.Add(this.btnPesquisarAluno);
            this.tabSolicitacoes.Controls.Add(this.rdbNomeAluno);
            this.tabSolicitacoes.Controls.Add(this.rdbProntuarioAluno);
            this.tabSolicitacoes.Controls.Add(this.label6);
            this.tabSolicitacoes.Controls.Add(this.label5);
            this.tabSolicitacoes.Controls.Add(this.txtContato2Aluno);
            this.tabSolicitacoes.Controls.Add(this.label4);
            this.tabSolicitacoes.Controls.Add(this.label3);
            this.tabSolicitacoes.Controls.Add(this.label2);
            this.tabSolicitacoes.Controls.Add(this.txtContato1Aluno);
            this.tabSolicitacoes.Controls.Add(this.txtResponsavel2Aluno);
            this.tabSolicitacoes.Controls.Add(this.txtResponsavel1Aluno);
            this.tabSolicitacoes.Controls.Add(this.label1);
            this.tabSolicitacoes.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSolicitacoes.Location = new System.Drawing.Point(4, 27);
            this.tabSolicitacoes.Name = "tabSolicitacoes";
            this.tabSolicitacoes.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolicitacoes.Size = new System.Drawing.Size(1090, 562);
            this.tabSolicitacoes.TabIndex = 0;
            this.tabSolicitacoes.Text = "Gerar Solicitações";
            this.tabSolicitacoes.UseVisualStyleBackColor = true;
            // 
            // txtMotivoAluno
            // 
            this.txtMotivoAluno.BackColor = System.Drawing.SystemColors.Control;
            this.txtMotivoAluno.Location = new System.Drawing.Point(49, 438);
            this.txtMotivoAluno.Multiline = true;
            this.txtMotivoAluno.Name = "txtMotivoAluno";
            this.txtMotivoAluno.Size = new System.Drawing.Size(991, 39);
            this.txtMotivoAluno.TabIndex = 28;
            // 
            // txtPesquisarAluno
            // 
            this.txtPesquisarAluno.BackColor = System.Drawing.SystemColors.Control;
            this.txtPesquisarAluno.Location = new System.Drawing.Point(49, 111);
            this.txtPesquisarAluno.Name = "txtPesquisarAluno";
            this.txtPesquisarAluno.Size = new System.Drawing.Size(480, 25);
            this.txtPesquisarAluno.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Pesquisar aluno por:";
            // 
            // ckbSolicitacaoSaida
            // 
            this.ckbSolicitacaoSaida.AutoSize = true;
            this.ckbSolicitacaoSaida.Checked = true;
            this.ckbSolicitacaoSaida.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSolicitacaoSaida.Location = new System.Drawing.Point(630, 45);
            this.ckbSolicitacaoSaida.Name = "ckbSolicitacaoSaida";
            this.ckbSolicitacaoSaida.Size = new System.Drawing.Size(200, 22);
            this.ckbSolicitacaoSaida.TabIndex = 25;
            this.ckbSolicitacaoSaida.Text = "Gerar Solicitação de Saída";
            this.ckbSolicitacaoSaida.UseVisualStyleBackColor = true;
            this.ckbSolicitacaoSaida.Click += new System.EventHandler(this.ckbSolicitacaoSaida_Click);
            // 
            // ckbSolicitacaoEntrada
            // 
            this.ckbSolicitacaoEntrada.AutoSize = true;
            this.ckbSolicitacaoEntrada.Location = new System.Drawing.Point(853, 45);
            this.ckbSolicitacaoEntrada.Name = "ckbSolicitacaoEntrada";
            this.ckbSolicitacaoEntrada.Size = new System.Drawing.Size(213, 22);
            this.ckbSolicitacaoEntrada.TabIndex = 24;
            this.ckbSolicitacaoEntrada.Text = "Gerar solicitação de entrada";
            this.ckbSolicitacaoEntrada.UseVisualStyleBackColor = true;
            this.ckbSolicitacaoEntrada.Click += new System.EventHandler(this.ckbSolicitacaoEntrada_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Prontuário do aluno:";
            // 
            // txtProntuarioAluno
            // 
            this.txtProntuarioAluno.Location = new System.Drawing.Point(560, 199);
            this.txtProntuarioAluno.Name = "txtProntuarioAluno";
            this.txtProntuarioAluno.ReadOnly = true;
            this.txtProntuarioAluno.Size = new System.Drawing.Size(480, 25);
            this.txtProntuarioAluno.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nome do aluno:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(49, 199);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.ReadOnly = true;
            this.txtNomeAluno.Size = new System.Drawing.Size(480, 25);
            this.txtNomeAluno.TabIndex = 17;
            // 
            // rdbNomeAluno
            // 
            this.rdbNomeAluno.AutoSize = true;
            this.rdbNomeAluno.Location = new System.Drawing.Point(167, 43);
            this.rdbNomeAluno.Name = "rdbNomeAluno";
            this.rdbNomeAluno.Size = new System.Drawing.Size(67, 22);
            this.rdbNomeAluno.TabIndex = 15;
            this.rdbNomeAluno.Text = "Nome";
            this.rdbNomeAluno.UseVisualStyleBackColor = true;
            // 
            // rdbProntuarioAluno
            // 
            this.rdbProntuarioAluno.AutoSize = true;
            this.rdbProntuarioAluno.Checked = true;
            this.rdbProntuarioAluno.Location = new System.Drawing.Point(51, 43);
            this.rdbProntuarioAluno.Name = "rdbProntuarioAluno";
            this.rdbProntuarioAluno.Size = new System.Drawing.Size(98, 22);
            this.rdbProntuarioAluno.TabIndex = 14;
            this.rdbProntuarioAluno.TabStop = true;
            this.rdbProntuarioAluno.Text = "Prontuário";
            this.rdbProntuarioAluno.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Motivo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(557, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Contato secundario:";
            // 
            // txtContato2Aluno
            // 
            this.txtContato2Aluno.Location = new System.Drawing.Point(560, 367);
            this.txtContato2Aluno.Name = "txtContato2Aluno";
            this.txtContato2Aluno.ReadOnly = true;
            this.txtContato2Aluno.Size = new System.Drawing.Size(480, 25);
            this.txtContato2Aluno.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contato principal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Responsável secundário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Responsável principal:";
            // 
            // txtContato1Aluno
            // 
            this.txtContato1Aluno.Location = new System.Drawing.Point(49, 367);
            this.txtContato1Aluno.Name = "txtContato1Aluno";
            this.txtContato1Aluno.ReadOnly = true;
            this.txtContato1Aluno.Size = new System.Drawing.Size(480, 25);
            this.txtContato1Aluno.TabIndex = 6;
            // 
            // txtResponsavel2Aluno
            // 
            this.txtResponsavel2Aluno.Location = new System.Drawing.Point(560, 281);
            this.txtResponsavel2Aluno.Name = "txtResponsavel2Aluno";
            this.txtResponsavel2Aluno.ReadOnly = true;
            this.txtResponsavel2Aluno.Size = new System.Drawing.Size(480, 25);
            this.txtResponsavel2Aluno.TabIndex = 4;
            // 
            // txtResponsavel1Aluno
            // 
            this.txtResponsavel1Aluno.Location = new System.Drawing.Point(49, 281);
            this.txtResponsavel1Aluno.Name = "txtResponsavel1Aluno";
            this.txtResponsavel1Aluno.ReadOnly = true;
            this.txtResponsavel1Aluno.Size = new System.Drawing.Size(480, 25);
            this.txtResponsavel1Aluno.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa:";
            // 
            // tabControleEstacionamento
            // 
            this.tabControleEstacionamento.Location = new System.Drawing.Point(4, 27);
            this.tabControleEstacionamento.Name = "tabControleEstacionamento";
            this.tabControleEstacionamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabControleEstacionamento.Size = new System.Drawing.Size(1090, 562);
            this.tabControleEstacionamento.TabIndex = 1;
            this.tabControleEstacionamento.Text = "Controle do Estacionamento";
            this.tabControleEstacionamento.UseVisualStyleBackColor = true;
            // 
            // tabSolicitacoesSaidaFinalizadasExpiradas
            // 
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Controls.Add(this.panel3);
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Controls.Add(this.panel2);
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Controls.Add(this.dgvSolicitacoesExpiradas);
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Controls.Add(this.dgvSolicitacoesFinalizadas);
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Location = new System.Drawing.Point(4, 27);
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Name = "tabSolicitacoesSaidaFinalizadasExpiradas";
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Size = new System.Drawing.Size(1090, 562);
            this.tabSolicitacoesSaidaFinalizadasExpiradas.TabIndex = 2;
            this.tabSolicitacoesSaidaFinalizadasExpiradas.Text = "Solicitações de Saída Finalizadas e Expiradas";
            this.tabSolicitacoesSaidaFinalizadasExpiradas.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Solicitações Finalizadas";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dgvSolicitacoesExpiradas
            // 
            this.dgvSolicitacoesExpiradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitacoesExpiradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitacoesExpiradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvSolicitacoesExpiradas.Location = new System.Drawing.Point(555, 113);
            this.dgvSolicitacoesExpiradas.MultiSelect = false;
            this.dgvSolicitacoesExpiradas.Name = "dgvSolicitacoesExpiradas";
            this.dgvSolicitacoesExpiradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitacoesExpiradas.Size = new System.Drawing.Size(490, 410);
            this.dgvSolicitacoesExpiradas.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Prontuário do Aluno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Aluno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Aberto por:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dgvSolicitacoesFinalizadas
            // 
            this.dgvSolicitacoesFinalizadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitacoesFinalizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitacoesFinalizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSolicitacoesFinalizadas.Location = new System.Drawing.Point(44, 113);
            this.dgvSolicitacoesFinalizadas.MultiSelect = false;
            this.dgvSolicitacoesFinalizadas.Name = "dgvSolicitacoesFinalizadas";
            this.dgvSolicitacoesFinalizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitacoesFinalizadas.Size = new System.Drawing.Size(490, 410);
            this.dgvSolicitacoesFinalizadas.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prontuário do Aluno";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nome do Aluno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Aberto por:";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tabSolicitacoesSaidaAbertas
            // 
            this.tabSolicitacoesSaidaAbertas.Controls.Add(this.panel5);
            this.tabSolicitacoesSaidaAbertas.Controls.Add(this.panel4);
            this.tabSolicitacoesSaidaAbertas.Controls.Add(this.dgvSolicitacoesAbertas);
            this.tabSolicitacoesSaidaAbertas.Location = new System.Drawing.Point(4, 27);
            this.tabSolicitacoesSaidaAbertas.Name = "tabSolicitacoesSaidaAbertas";
            this.tabSolicitacoesSaidaAbertas.Padding = new System.Windows.Forms.Padding(3);
            this.tabSolicitacoesSaidaAbertas.Size = new System.Drawing.Size(1090, 562);
            this.tabSolicitacoesSaidaAbertas.TabIndex = 3;
            this.tabSolicitacoesSaidaAbertas.Text = "Solicitações de Saída Abertas";
            this.tabSolicitacoesSaidaAbertas.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarSolicitacao
            // 
            this.btnFinalizarSolicitacao.BackColor = System.Drawing.Color.White;
            this.btnFinalizarSolicitacao.Image = global::Sistema.Ifsp.View.Properties.Resources._2;
            this.btnFinalizarSolicitacao.Location = new System.Drawing.Point(962, 2);
            this.btnFinalizarSolicitacao.Name = "btnFinalizarSolicitacao";
            this.btnFinalizarSolicitacao.Size = new System.Drawing.Size(75, 43);
            this.btnFinalizarSolicitacao.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnFinalizarSolicitacao, "Finalizar Solicitação");
            this.btnFinalizarSolicitacao.UseVisualStyleBackColor = false;
            this.btnFinalizarSolicitacao.Click += new System.EventHandler(this.btnFinalizarSolicitacao_Click);
            // 
            // dgvSolicitacoesAbertas
            // 
            this.dgvSolicitacoesAbertas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitacoesAbertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitacoesAbertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvSolicitacoesAbertas.Location = new System.Drawing.Point(44, 92);
            this.dgvSolicitacoesAbertas.MultiSelect = false;
            this.dgvSolicitacoesAbertas.Name = "dgvSolicitacoesAbertas";
            this.dgvSolicitacoesAbertas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitacoesAbertas.Size = new System.Drawing.Size(996, 380);
            this.dgvSolicitacoesAbertas.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Código";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Prontuário do Aluno";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome do Aluno";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Aberto por:";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Solicitações Abertas";
            // 
            // timerAtualizaSolicitacoes
            // 
            this.timerAtualizaSolicitacoes.Enabled = true;
            this.timerAtualizaSolicitacoes.Interval = 61500;
            this.timerAtualizaSolicitacoes.Tick += new System.EventHandler(this.timerAtualizaSolicitacoes_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.btnGerarSolicitacaoAluno);
            this.panel1.Location = new System.Drawing.Point(3, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 40);
            this.panel1.TabIndex = 29;
            // 
            // btnGerarSolicitacaoAluno
            // 
            this.btnGerarSolicitacaoAluno.BackColor = System.Drawing.Color.White;
            this.btnGerarSolicitacaoAluno.Image = global::Sistema.Ifsp.View.Properties.Resources._2;
            this.btnGerarSolicitacaoAluno.Location = new System.Drawing.Point(962, 0);
            this.btnGerarSolicitacaoAluno.Name = "btnGerarSolicitacaoAluno";
            this.btnGerarSolicitacaoAluno.Size = new System.Drawing.Size(75, 40);
            this.btnGerarSolicitacaoAluno.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnGerarSolicitacaoAluno, "Gerar Solicitação");
            this.btnGerarSolicitacaoAluno.UseVisualStyleBackColor = false;
            this.btnGerarSolicitacaoAluno.Click += new System.EventHandler(this.btnGerarSolicitacaoAluno_Click);
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.BackColor = System.Drawing.Color.White;
            this.btnPesquisarAluno.Image = global::Sistema.Ifsp.View.Properties.Resources._6;
            this.btnPesquisarAluno.Location = new System.Drawing.Point(535, 103);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(59, 40);
            this.btnPesquisarAluno.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnPesquisarAluno, "Pesquisar");
            this.btnPesquisarAluno.UseVisualStyleBackColor = false;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(44, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 29);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(555, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(490, 29);
            this.panel3.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Solicitações Expiradas";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel4.Controls.Add(this.label12);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(44, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(326, 35);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel5.Controls.Add(this.btnFinalizarSolicitacao);
            this.panel5.Location = new System.Drawing.Point(3, 511);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1084, 47);
            this.panel5.TabIndex = 5;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1184, 695);
            this.Controls.Add(this.principal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.principal.ResumeLayout(false);
            this.tabSolicitacoes.ResumeLayout(false);
            this.tabSolicitacoes.PerformLayout();
            this.tabSolicitacoesSaidaFinalizadasExpiradas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoesExpiradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoesFinalizadas)).EndInit();
            this.tabSolicitacoesSaidaAbertas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitacoesAbertas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.TabControl principal;
        private System.Windows.Forms.TabPage tabControleEstacionamento;
        private System.Windows.Forms.TabPage tabSolicitacoes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbSolicitacaoSaida;
        private System.Windows.Forms.CheckBox ckbSolicitacaoEntrada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProntuarioAluno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.RadioButton rdbNomeAluno;
        private System.Windows.Forms.RadioButton rdbProntuarioAluno;
        private System.Windows.Forms.Button btnGerarSolicitacaoAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContato2Aluno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContato1Aluno;
        private System.Windows.Forms.TextBox txtResponsavel2Aluno;
        private System.Windows.Forms.TextBox txtResponsavel1Aluno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisarAluno;
        private System.Windows.Forms.TextBox txtMotivoAluno;
        private System.Windows.Forms.TabPage tabSolicitacoesSaidaFinalizadasExpiradas;
        private System.Windows.Forms.DataGridView dgvSolicitacoesFinalizadas;
        private System.Windows.Forms.DataGridView dgvSolicitacoesExpiradas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabSolicitacoesSaidaAbertas;
        private System.Windows.Forms.DataGridView dgvSolicitacoesAbertas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnFinalizarSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Timer timerAtualizaSolicitacoes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}