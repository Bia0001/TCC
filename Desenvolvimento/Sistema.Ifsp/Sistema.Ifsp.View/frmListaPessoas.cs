using Sistema.Ifsp.BO;
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
    public partial class frmListaPessoas : Form
    {
        public frmListaPessoas(List<Aluno> alunos)
        {
            InitializeComponent();
            PreencherGrid(alunos);
        }

        private void PreencherGrid(List<Aluno> alunos)
        {
            dgvAlunos.ColumnCount = 2;
            dgvAlunos.Columns[0].Name = "Prontuário";
            dgvAlunos.Columns[1].Name = "Nome";
            foreach (Aluno a in alunos)
            {
                dgvAlunos.Rows.Add(a.Prontuario.prontuario, a.nome);
            }
        }

        private void btnSelecionarAluno_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum aluno selecionado. Por favor selecione um aluno", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {           
                try
                {
                    var prontuario = dgvAlunos.CurrentRow.Cells[0].Value.ToString();
                    var alunoBo = new AlunoBO();
                    var aluno = alunoBo.PesquisarProntuario(prontuario);
                    if (aluno == null)
                    {
                        MessageBox.Show("Falha ao carregar aluno. Por favor tente novamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //Close();
                    }
                    else
                    {
                        frmMain frmPrincipal = frmMain.GetInstance();
                        frmPrincipal.Show();
                        frmPrincipal.PreencherFormularioAluno(aluno);
                        Dispose();
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar aluno.\n"+ ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                
            }
        }
    }
}
