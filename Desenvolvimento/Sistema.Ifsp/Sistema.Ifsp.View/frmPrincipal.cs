using Sistema.Ifsp.DAO;
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
    public partial class frmPrincipal : Form
    {
        private static frmPrincipal instancia;
        public static frmPrincipal getInstancia()
        {
            if (instancia == null)
            {
                instancia = new frmPrincipal();
            }
            return instancia;
        }
        private frmPrincipal()
        {
            InitializeComponent();
            var assistenteDao = new AssistenteAlunoDAO();
            assistenteAluno = assistenteDao.find(2);
            var porteiroDao = new PorteiroDAO();
            porteiro = porteiroDao.find(4);
            preencherGridsSolicitacoes();
        }
        /*variaveis*/
        public Aluno aluno { get; set; }
        Porteiro porteiro;
        AssistenteAluno assistenteAluno;
        IQueryable<Aluno> alunos;
        int tempoExpiraçãoSolicitacao = 45;

        /*BOTÕES*/
        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            if (rdbProntuarioAluno.Checked == true)
            {
                if (String.IsNullOrWhiteSpace(txtPesquisarAluno.Text))
                {
                    mensagem("Insira valor no campo de pesquisa!");
                }
                else
                {
                    try
                    {
                        aluno = getAlunoProntuario(txtPesquisarAluno.Text);
                        if (aluno == null)
                        {
                            mensagem("Falha ao pesquisar aluno");
                        }
                        else
                        {
                            preencherDadosAluno(aluno);
                            gerarSolicitacoes2();
                        }
                    }
                    catch (Exception ex)
                    {
                        mensagem("Falha ao pesquisar aluno. Detalhes: " + ex);
                    }
                }
            }
            else if (rdbNomeAluno.Checked == true)
            {
                if (String.IsNullOrWhiteSpace(txtPesquisarAluno.Text))
                {
                    mensagem("Insira valor no campo de pesquisa!");
                }
                else
                {
                    try
                    {
                        var aDAO = new AlunoDAO();
                        alunos = aDAO.get(a => a.nome.StartsWith(txtPesquisarAluno.Text, StringComparison.CurrentCultureIgnoreCase));
                        if (alunos.Count() == 0)
                        {
                            mensagem("Nenhum aluno encontrado");
                            gerarSolicitacoes1();
                        }
                        else if (alunos.Count() == 1)
                        {
                            preencherDadosAluno(alunos.First());
                            gerarSolicitacoes2();
                        }
                        else
                        {
                            frmAlunos f = new frmAlunos(alunos);
                            f.ShowDialog();
                        }                        
                    }
                    catch (Exception ex)
                    {
                        mensagem("Nenhum aluno encontrado. Detalhes: "+ ex);
                        gerarSolicitacoes1();
                    }
                }
            }
        }

        private void btnGerarSolicitacaoAluno_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMotivoAluno.Text))
            {
                mensagem("Por favor. Insirar o Motivo");
            }
            else
            {
                if (ckbSolicitacaoSaida.Checked == true)
                {
                    try
                    {
                        var s = new SolicitacaoSaida()
                        {
                            abertura = DateTime.Now,
                            aluno = aluno,
                            assistenteAluno = assistenteAluno,
                            motivo = txtMotivoAluno.Text,
                            status = StatusSolicitacao.aberto
                        };
                        var solicitacaoSaidaDao = new SolicitacaoSaidaDAO();
                        if (solicitacaoSaidaDao.adicionar(s))
                        {
                            mensagem("Solicitação de saída gerada com sucesso!");
                            gerarSolicitacoes1();
                            preencherGridsSolicitacoes();
                        }
                        else
                        {
                            mensagem("Falha ao gerar solicitação de saida");
                            gerarSolicitacoes1();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        mensagem("Falha ao gerar solicitação. Detalhes: "+ex);
                    }
                }
                else
                {
                    var s = new SolicitacaoEntrada()
                    {
                        abertura = DateTime.Now,
                        aluno = aluno,
                        assistenteAluno = assistenteAluno,
                        motivo = txtMotivoAluno.Text
                    };
                    var sDao = new SolicitacaoEntradaDAO();
                    if (sDao.adicionar(s))
                    {
                        mensagem("Solicitação de entrada concedida com sucesso!");
                        gerarSolicitacoes1();
                    }
                    else
                    {
                        mensagem("Falha ao conceder solicitação de entrada. Tente novamente!");
                        gerarSolicitacoes1();
                    }
                }
            }
        }

        public void preencherDadosAluno(Aluno a)
        {
            txtNomeAluno.Text = a.nome;
            txtProntuarioAluno.Text = a.prontuario.prontuario;
            txtContato1Aluno.Text = a.contato1;
            txtContato2Aluno.Text = a.contato2;
            txtResponsavel1Aluno.Text = a.responsavel1;
            txtResponsavel2Aluno.Text = a.responsavel2;
        }

        private void preencherGridsSolicitacoes()
        {            
            dgvSolicitacoesAbertas.Rows.Clear();
            dgvSolicitacoesAbertas.Refresh();
            dgvSolicitacoesExpiradas.Rows.Clear();
            dgvSolicitacoesExpiradas.Refresh();
            dgvSolicitacoesFinalizadas.Rows.Clear();
            dgvSolicitacoesFinalizadas.Refresh();
            atualizandoStatusSolicitacoes();
            var ssDAO = new SolicitacaoSaidaDAO();
            //buscando todas as solicitações de hoje
            IQueryable<SolicitacaoSaida> solicitacoesSaida = getSolicitacaoesHoje();
            //inserindo cada uma em seu devido grid de acordo com seu status (aberto, experida, expirado)
            foreach (SolicitacaoSaida solicitacao in solicitacoesSaida)
            {
                if (solicitacao.status == StatusSolicitacao.aberto)
                {
                    dgvSolicitacoesAbertas.Rows.Add(solicitacao.idSolicitacao, solicitacao.aluno.prontuario.prontuario,
                        solicitacao.aluno.nome, solicitacao.assistenteAluno.nome);
                }
                else if (solicitacao.status == StatusSolicitacao.expirado)
                {
                    dgvSolicitacoesExpiradas.Rows.Add(solicitacao.idSolicitacao, solicitacao.aluno.prontuario.prontuario,
                        solicitacao.aluno.nome, solicitacao.assistenteAluno.nome);
                }
                else if (solicitacao.status == StatusSolicitacao.encerrado)
                {
                    dgvSolicitacoesFinalizadas.Rows.Add(solicitacao.idSolicitacao, solicitacao.aluno.prontuario.prontuario,
                        solicitacao.aluno.nome, solicitacao.assistenteAluno.nome);
                }
            }   
        }

        private void atualizandoStatusSolicitacoes()
        {
            var dataAtual = DateTime.Now;
            var ssDAO = new SolicitacaoSaidaDAO();
            var solicitacoesSaida = getSolicitacaoesHoje();
            //verificando se solicitação está expirada, se sim, atualiza seu status
            foreach (SolicitacaoSaida solicitacao in solicitacoesSaida)
            {
                //verificando se solicitacao ja estourou o tempo de expiração
                if (solicitacao.status == StatusSolicitacao.aberto &&
                    solicitacao.abertura.AddMinutes(tempoExpiraçãoSolicitacao) < dataAtual)
                {
                    try
                    {
                        solicitacao.status = StatusSolicitacao.expirado;
                        ssDAO.atualizar(solicitacao);
                    }
                    catch (Exception)
                    {
                        return;
                    }
                }
            }
        }

        private static IQueryable<SolicitacaoSaida> getSolicitacaoesHoje()
        {
            var ssDAO = new SolicitacaoSaidaDAO();
            var dataAtual = DateTime.Now;
            //buscando todas as solicitações de hoje
            return ssDAO.get(s => s.abertura.DayOfYear == dataAtual.DayOfYear && s.abertura.Year == dataAtual.Year);
        }

        private void mensagem(String mensagem)
        {
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Aluno getAlunoProntuario(string prontuario)
        {
            var aDAO = new AlunoDAO();
            return aDAO.get(a => a.prontuario.prontuario == prontuario).FirstOrDefault();
        }
        
        

        /*CONTROLES DOS FORMULÁRIOS*/
        private void gerarSolicitacoes1()
        {
            txtPesquisarAluno.Text = null;
            txtNomeAluno.ReadOnly = true;
            txtNomeAluno.Text = null;
            txtProntuarioAluno.ReadOnly = true;
            txtProntuarioAluno.Text = null;
            txtContato1Aluno.ReadOnly = true;
            txtContato1Aluno.Text = null;
            txtContato2Aluno.ReadOnly = true;
            txtContato2Aluno.Text = null;
            txtResponsavel1Aluno.ReadOnly = true;
            txtResponsavel1Aluno.Text = null;
            txtResponsavel2Aluno.ReadOnly = true;
            txtResponsavel2Aluno.Text = null;
            txtMotivoAluno.ReadOnly = true;
            txtMotivoAluno.Text = null;
            btnGerarSolicitacaoAluno.Enabled = false;
        }

        public void gerarSolicitacoes2()
        {
            txtNomeAluno.ReadOnly = true;
            txtProntuarioAluno.ReadOnly = true;
            txtContato1Aluno.ReadOnly = true;
            txtContato2Aluno.ReadOnly = true;
            txtResponsavel1Aluno.ReadOnly = true;
            txtResponsavel2Aluno.ReadOnly = true;
            txtMotivoAluno.ReadOnly = false;
            btnGerarSolicitacaoAluno.Enabled = true;
        }
        private void ckbSolicitacaoSaida_Click(object sender, EventArgs e)
        {
            ckbSolicitacaoEntrada.Checked = false;
        }

        private void ckbSolicitacaoEntrada_Click(object sender, EventArgs e)
        {
            ckbSolicitacaoSaida.Checked = false;
        }

        private void timerAtualizaSolicitacoes_Tick(object sender, EventArgs e)
        {
            preencherGridsSolicitacoes();
        }

        private void btnFinalizarSolicitacao_Click(object sender, EventArgs e)
        {
            if (dgvSolicitacoesAbertas.SelectedRows.Count == 0)
            {
                mensagem("Por favor selecione a linha que corresponde a solicitação desejada");
            }
            else
            {
                var ssDAO = new SolicitacaoSaidaDAO();
                var ss = ssDAO.find(Convert.ToInt32(dgvSolicitacoesAbertas.CurrentRow.Cells[0].Value));
                ss.encerramento = DateTime.Now;
                ss.status = StatusSolicitacao.encerrado;
                ss.porteiro = porteiro;
                try
                {
                    if (ssDAO.atualizar(ss))
                    {
                        mensagem("Solicitação finalizada com sucesso! Agora o aluno pode ser dispensado!");
                        preencherGridsSolicitacoes();
                    }
                    else
                    {
                        mensagem("Falha ao finalizar solicitação");
                    }
                }
                catch (Exception ex)
                {
                    mensagem("Falhar ao finalizar solicitação. Detalhes: "+ ex);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
