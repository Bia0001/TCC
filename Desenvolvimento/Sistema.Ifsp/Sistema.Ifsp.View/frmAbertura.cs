using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Ifsp.DAO;

namespace Sistema.Ifsp.View
{
    public partial class frmAbertura : Form
    {
        public frmAbertura()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
