using Sistema.Ifsp.Model;
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
    public partial class frmPessoasFisicas : Form
    {
        private IQueryable<PessoaFisica> pessoas;

        public frmPessoasFisicas(IQueryable<PessoaFisica> pessoas)
        {
            InitializeComponent();
            this.pessoas = pessoas;
            preencherGrid();
        }

        private void preencherGrid()
        {
            foreach (PessoaFisica p in pessoas)
            {
                dgvPessoaFisica.Rows.Add(p.idPessoaFisica, p.nome, p.rg);
            }
        }

        private void btnSelecionarPessoa_Click(object sender, EventArgs e)
        {
            if (dgvPessoaFisica.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma pessoa selecionada. Selecione a linhda da pessoa correspondente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(dgvPessoaFisica.CurrentRow.Cells[0].Value);
                PessoaFisica pessoa = new PessoaFisica();
                foreach (PessoaFisica p in pessoas)
                {
                    if (p.idPessoaFisica == id)
                    {
                        pessoa = p;
                        break;
                    }
                }
                frmPrincipal f = frmPrincipal.getInstance();                
                f.Show();
                f.pessoaFisica = pessoa;
                f.preencherFormEstacionamento();
                Dispose();
            }
        }
    }
}
