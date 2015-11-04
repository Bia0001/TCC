using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Ifsp.View
{
    public partial class frmCodigoPlaca : Form
    {
        public frmCodigoPlaca(string codigoPlaca)
        {
            InitializeComponent();
            txtCodigoPlaca.Text = codigoPlaca;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            previsualicaoImpressao.Show();
        }

        /*determinando previsualização em modo maximizado*/
        private void previsualicaoImpressao_Load(object sender, EventArgs e)
        {
            previsualicaoImpressao.WindowState = FormWindowState.Maximized;
        }

        /*determinando fonte, posição e texto a ser impresso*/
        private void impressao_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*determinando fonte, tamanho em pixel*/
            Font fonte = new Font("Arial", 200, FontStyle.Bold, GraphicsUnit.Pixel);
            /*determinando item a ser impresso*/
            e.Graphics.DrawString(txtCodigoPlaca.Text, fonte, Brushes.Black, 10, 60);
        }
    }
}