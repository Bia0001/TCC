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
            ExibirSolicitacoesGrid();
            timerAtualizaGrids.Start();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            /*Verifica se o campo de pesquisa está vazio*/
            if (txtPesquisa.Text == "")
            {
                MessageBox.Show("Por favor preencha o campo de pesquisa!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {   /*Verifica qual radiobutton está selecionado para realizar pesquisa, se o radioButton por "Nome" estiver selecionado 
                e a presquisa obter resultados, um novo form é chamado exibindo os resultados, desabilitando form atual*/
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

        /*habiliatações e travamento de campos*/
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

        /*habiliatações e travamento de campos*/
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

        /*Preenche formulário de alunos com dados principais do aluno para geração de solicitação*/
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
            /*Verificando se existe um motivo para aluno ser dispensado, analisando Text Motivo*/
            if (txtMotivo.Text == "")
            {
                MessageBox.Show("Por favor escreva um motivo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {     
                    /*pesquisando aluno atraves de seu prontuario*/       
                    var alunoBo = new AlunoBO();
                    var aluno = alunoBo.PesquisarProntuario(txtProntuarioAluno.Text);
                    var assistenteBo = new AssistenteAlunoBO();
                    var assistente = assistenteBo.PesquisarProntuario("2");
                    /*criando nova intância de solicitação setando status como aberto e inserindo 
                    data e hora atual como abertura, adicionando 45 minutos na hora atual para 
                    previsão de encerramento e setando atores presentes na solicitação*/
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
                    /*persistindo solicitação e exibindo mensagem*/
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

        /*Limpando campos*/
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

        /*Preencendo grids com alunos com status em: aberto, expirado e encerrados 
        respectivamente em seus grids*/
        private void ExibirSolicitacoesGrid()
        {
            /*limpando grids*/
            dgvSolicitacoesAbertas.Rows.Clear();
            dgvSolicitacoesEncerradas.Rows.Clear();
            dgvSolicitacoesExpiradas.Rows.Clear();
            /*buscando solicitaçãos do dia atual*/
            var soliBO = new SolicitacaoSaidaBO();
            var solicitacoes = soliBO.PesquisarSolicitacoesHoje();
            /*Separando solicitaçãos por grid de acordo com seu status*/
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

        /*Dando atividade ao evento Tick do timer.
        Derminando que a cada Tick os gris serão atualziados*/
        private void tmrAtualiza_Tick(object sender, EventArgs e)
        {
            ExibirSolicitacoesGrid();
        }

        private void btnEncerrarSolicitacao_Click(object sender, EventArgs e)
        {
            /*Verificando se há solcitação selecionada*/
            if (dgvSolicitacoesAbertas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por selecione um aluno para liberar saída", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    /*Pesquisando solicitação no banco através de seu ID afim de validar sua integridade, alterar status para encerrado, 
                    setar data atual para encerramento, setar ator vigilante que encerra solicitação e atualiza grid*/
                    /*VIGILANTE TESTE para finalização de solitação, cujo nome é Samuel e idPessoaFisica é 3*/
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
