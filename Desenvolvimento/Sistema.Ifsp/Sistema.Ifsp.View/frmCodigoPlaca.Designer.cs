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
            this.txtCodigoPlaca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCodigoPlaca
            // 
            this.txtCodigoPlaca.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPlaca.Location = new System.Drawing.Point(91, 108);
            this.txtCodigoPlaca.Multiline = true;
            this.txtCodigoPlaca.Name = "txtCodigoPlaca";
            this.txtCodigoPlaca.Size = new System.Drawing.Size(282, 119);
            this.txtCodigoPlaca.TabIndex = 0;
            // 
            // frmCodigoPlaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 258);
            this.Controls.Add(this.txtCodigoPlaca);
            this.Name = "frmCodigoPlaca";
            this.Text = "frmCodigoPlaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPlaca;
    }
}