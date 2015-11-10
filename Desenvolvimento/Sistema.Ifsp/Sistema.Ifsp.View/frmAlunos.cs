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
    public partial class frmAlunos : Form
    {
        private IQueryable<Aluno> alunos;

        public frmAlunos(IQueryable<Aluno> alunos)
        {
            this.alunos = alunos;
            InitializeComponent();
            carregarGrid();
        }

        private void carregarGrid()
        {
            dgvAlunos.Rows.Clear();
            dgvAlunos.Update();
            dgvAlunos.Refresh();
            foreach (Aluno item in alunos)
            {
                dgvAlunos.Rows.Add(item.idPessoaFisica, item.prontuario.prontuario, item.nome);
            }
        }

        private void btnSelecionarAluno_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor selecione uma linha correspondente ao aluno desejado!");
            }
            else
            {
                int id = Convert.ToInt32(dgvAlunos.CurrentRow.Cells[0].Value);
                foreach (Aluno aluno in alunos)
                {
                    if (aluno.idPessoaFisica == id)
                    {
                        frmPrincipal f = frmPrincipal.getInstance();
                        f.Show();
                        f.preencherDadosAluno(aluno);
                        f.aluno = aluno;
                        f.gerarSolicitacoes2();
                        Dispose();
                    }
                }
            }
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {        

        }

    }
}