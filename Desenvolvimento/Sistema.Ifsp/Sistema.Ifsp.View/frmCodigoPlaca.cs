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
    }
}
