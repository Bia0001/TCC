namespace Sistema.Ifsp.View
{
    partial class frmCodigoPlaca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCodigoPlaca));
            this.txtCodigoPlaca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.impressao = new System.Drawing.Printing.PrintDocument();
            this.previsualicaoImpressao = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // txtCodigoPlaca
            // 
            this.txtCodigoPlaca.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPlaca.Location = new System.Drawing.Point(30, 70);
            this.txtCodigoPlaca.Multiline = true;
            this.txtCodigoPlaca.Name = "txtCodigoPlaca";
            this.txtCodigoPlaca.ReadOnly = true;
            this.txtCodigoPlaca.Size = new System.Drawing.Size(282, 119);
            this.txtCodigoPlaca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código de Indetificação";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // impressao
            // 
            this.impressao.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.impressao_PrintPage);
            // 
            // previsualicaoImpressao
            // 
            this.previsualicaoImpressao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.previsualicaoImpressao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.previsualicaoImpressao.ClientSize = new System.Drawing.Size(400, 300);
            this.previsualicaoImpressao.Document = this.impressao;
            this.previsualicaoImpressao.Enabled = true;
            this.previsualicaoImpressao.Icon = ((System.Drawing.Icon)(resources.GetObject("previsualicaoImpressao.Icon")));
            this.previsualicaoImpressao.Name = "previsualicaoImpressao";
            this.previsualicaoImpressao.Visible = false;
            this.previsualicaoImpressao.Load += new System.EventHandler(this.previsualicaoImpressao_Load);
            // 
            // frmCodigoPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoPlaca);
            this.Name = "frmCodigoPlaca";
            this.Text = "frmCodigoPlaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPlaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument impressao;
        private System.Windows.Forms.PrintPreviewDialog previsualicaoImpressao;
    }
}