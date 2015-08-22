using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Sistema.Ifsp.BO;
using Sistema.Ifsp.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.Ifsp.View
{
    public partial class frmMain : Form
    {
        /*SINGLETON*/
        private static frmMain instance;
        public static frmMain GetInstance()
        {
            if (instance == null)
            {
                instance = new frmMain();
            }
            return instance;
        }
        private frmMain()
        {
            InitializeComponent();
            tmrAtualiza.Start();
            ExibirSolicitacoesGrid();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "")
            {
                MessageBox.Show("Por favor preencha o campo de pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PrimeiroGerarSolicitacaoSaida();
                if (rdbProntuario.Checked == true)
                {
                    try
                    {
                        var alunoBo = new AlunoBO();
                        var aluno = alunoBo.PesquisarProntuario(txtPesquisa.Text);
                        if (aluno == null)
                        {
                            MessageBox.Show("Nenhum aluno encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            SegundoGerarSolicitacaoSaida();
                            PreencherFormularioAluno(aluno);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha ao pesquisar aluno\n" + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (rdbNome.Checked == true)               
                {
                    try
                    {
                        var alunoBo = new AlunoBO();
                        var alunos = alunoBo.Pesquisar(txtPesquisa.Text).ToList();
                        if (alunos.Count == 0)
                        {
                            MessageBox.Show("Nenhum aluno encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            var form = new frmListaPessoas(alunos);
                            form.ShowDialog();
                            SegundoGerarSolicitacaoSaida();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha ao pesquisar aluno\n" + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void SegundoGerarSolicitacaoSaida()
        {
            txtProntuarioAluno.ReadOnly = true;
            txtNomeCompletoAluno.ReadOnly = true;
            txtResponsavel1.ReadOnly = true;
            txtResponsavel2.ReadOnly = true;
            txtTelefone1.ReadOnly = true;
            txtTelefone2.ReadOnly = true;
            txtMotivo.ReadOnly = false;
        }

        private void PrimeiroGerarSolicitacaoSaida()
        {
            txtProntuarioAluno.ReadOnly = true;
            txtNomeCompletoAluno.ReadOnly = true;
            txtResponsavel1.ReadOnly = true;
            txtResponsavel2.ReadOnly = true;
            txtTelefone1.ReadOnly = true;
            txtTelefone2.ReadOnly = true;
            txtMotivo.ReadOnly = true;
        }

        public void PreencherFormularioAluno(Aluno aluno)
        {
            txtProntuarioAluno.Text = aluno.Prontuario.prontuario;
            txtNomeCompletoAluno.Text = aluno.nome;
            txtResponsavel1.Text = aluno.responsavel1;
            txtResponsavel2.Text = aluno.responsavel2;
            txtTelefone1.Text = aluno.contato1;
            txtTelefone2.Text = aluno.contato2;
        }

        private void btnSalvarSolicitacao_Click(object sender, EventArgs e)
        {
            if (txtMotivo.Text == "")
            {
                MessageBox.Show("Por favor escreva um motivo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {            
                    var alunoBo = new AlunoBO();
                    var aluno = alunoBo.PesquisarProntuario(txtProntuarioAluno.Text);
                    var assistenteBo = new AssistenteAlunoBO();
                    var assistente = assistenteBo.PesquisarProntuario("2");
                    var dt = DateTime.Now;
                    var solicitiacao = new SolicitacaoSaida()
                    {
                        abertura = dt,
                        Aluno = aluno,
                        AssistenteAluno = assistente,
                        motivo = txtMotivo.Text,
                        previsaoEncerramento = dt.AddMinutes(45),
                        status = "Aberto"
                    };
                    var solicitacaoBo = new SolicitacaoSaidaBO();
                    solicitacaoBo.Adicionar(solicitiacao);
                    TerceiroGeraSolicitacaoSaida();
                    PrimeiroGerarSolicitacaoSaida();
                    MessageBox.Show("Solicitação gerada com sucesso!\nAluno já liberado!", "Conluído", MessageBoxButtons.OK, MessageBoxIcon.None);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao gera solicitacão\n"+ ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void TerceiroGeraSolicitacaoSaida()
        {
            txtPesquisa.Text = "";           
            txtProntuarioAluno.Text = "";
            txtNomeCompletoAluno.Text = "";            ;
            txtResponsavel1.Text = "";
            txtResponsavel2.Text = "";
            txtTelefone1.Text = "";
            txtTelefone2.Text = "";
            txtMotivo.Text = "";
        }

        private void ExibirSolicitacoesGrid()
        {
            dgvSolicitacoesAbertas.Rows.Clear();
            dgvSolicitacoesEncerradas.Rows.Clear();
            dgvSolicitacoesExpiradas.Rows.Clear();
            var soliBO = new SolicitacaoSaidaBO();
            var solicitacoes = soliBO.PesquisarSolicitacoesHoje();
            foreach (SolicitacaoSaida s in solicitacoes)
            {
                if (s.status == "Aberto")
                {
                    dgvSolicitacoesAbertas.Rows.Add(s.idSolicitacaoSaida, s.Aluno.Prontuario.prontuario, s.Aluno.nome, s.AssistenteAluno.nome);
                }
                else if (s.status == "Expirado")
                {
                    dgvSolicitacoesExpiradas.Rows.Add(s.idSolicitacaoSaida, s.Aluno.Prontuario.prontuario, s.Aluno.nome, s.AssistenteAluno.nome);
                }
                else if (s.status == "Encerrado")
                {
                    dgvSolicitacoesEncerradas.Rows.Add(s.idSolicitacaoSaida, s.Aluno.Prontuario.prontuario, s.Aluno.nome, s.AssistenteAluno.nome);
                }
            }
        }

        private void tmrAtualiza_Tick(object sender, EventArgs e)
        {
            ExibirSolicitacoesGrid();
        }

        private void btnEncerrarSolicitacao_Click(object sender, EventArgs e)
        {
            if (dgvSolicitacoesAbertas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por selecione um aluno para liberar saída", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    /*Vigiante teste para finalização de solitação, cujo nome é Samuel e idPessoaFisica é 3*/
                    var vigilanteBO = new VigilanteBO();
                    var vigilante = vigilanteBO.Pesquisar(3);
                    var solicitacaoBO = new SolicitacaoSaidaBO();
                    var solicitacao = solicitacaoBO.Pesquisar(Convert.ToInt32(dgvSolicitacoesAbertas.CurrentRow.Cells[0].Value));
                    solicitacao.encerramento = DateTime.Now;
                    solicitacao.status = "Encerrado";
                    solicitacao.Vigilante = vigilante;
                    solicitacaoBO.Atualizar(solicitacao);
                    MessageBox.Show("Solicitação finalziar com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExibirSolicitacoesGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao finalizar solcitação, tente novamente\n"+ ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
            }
        }
    }
}
