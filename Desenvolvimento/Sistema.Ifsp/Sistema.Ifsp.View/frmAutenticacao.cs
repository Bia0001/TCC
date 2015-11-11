using Sistema.Ifsp.DAO;
using Sistema.Ifsp.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Sistema.Ifsp.View
{
    public partial class frmAutenticacao : Form
    {
        public int id { set; get; }
        public string nivelAcesso { set; get; }

        public frmAutenticacao()
        {
            carregarAbertura();
            carregandoContexto();
            InitializeComponent();
        }

        private void carregarAbertura()
        {
            var frmAbertura = new frmAbertura();
            frmAbertura.Show();
        }

        private void carregandoContexto()
        {
            try
            {
                var dao = new PessoaFisicaDAO();
                var d = dao.get(p => p.idPessoaFisica == 0).FirstOrDefault();
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao carregar a aplicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor preenhca todos os campos!");
                txtUsuario.Focus();
                return;
            }
            else
            {
                try
                {
                    var tDAO = new TerceirizadoDAO();
                    var fDAO = new FuncionarioDAO();
                    string senha = Cripitografia.encripto(txtSenha.Text);
                    var terceirizado = tDAO.get(p => p.autenticacao.usuario == txtUsuario.Text && p.autenticacao.senha == senha).FirstOrDefault();
                    var funcionario = fDAO.get(p => p.autenticacao.usuario == txtUsuario.Text && p.autenticacao.senha == senha).FirstOrDefault();
                    if ((terceirizado != null))
                    {
                        var principal = frmPrincipal.getInstance();
                        principal.Show();
                        principal.verificarUsuarioLogado(terceirizado.idPessoaFisica, terceirizado.autenticacao.nivelAcesso);
                        Visible = false;
                    }
                    else if ((funcionario != null))
                    {
                        var principal = frmPrincipal.getInstance();
                        principal.Show();
                        principal.verificarUsuarioLogado(funcionario.idPessoaFisica, funcionario.autenticacao.nivelAcesso);
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário encontrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao tentar autenticar\nDetalhes: " + ex, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }
    }
}
