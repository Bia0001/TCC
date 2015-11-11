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
    public partial class frmAutenticacaoSubstituicao : Form
    {
        private PessoaFisica pessoaFisica;
        private int num = 0;

        public frmAutenticacaoSubstituicao()
        {
            InitializeComponent();
        }

        private void btnVerificarCredenciais_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioAtual.Text) || string.IsNullOrWhiteSpace(txtSenhaAtual.Text))
            {
                MessageBox.Show("Preencha os campos com seus dados atuais", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    var senha = Cripitografia.encripto(txtSenhaAtual.Text);
                    var fDAO = new FuncionarioDAO();
                    var tDAO = new TerceirizadoDAO();
                    var funcionario = fDAO.get(f => f.autenticacao.usuario == txtUsuarioAtual.Text && f.autenticacao.senha == senha).FirstOrDefault();
                    var terceirizado = tDAO.get(t => t.autenticacao.usuario == txtUsuarioAtual.Text && t.autenticacao.senha == senha).FirstOrDefault();
                    if (funcionario != null)
                    {
                        pessoaFisica = funcionario;
                        grpNovas.Enabled = true;
                        grpAtuais.Enabled = false;
                        txtUsuarioNovo.Focus();
                        num = 0;
                    }
                    else if (terceirizado != null)
                    {
                        pessoaFisica = terceirizado;
                        grpNovas.Enabled = true;
                        grpAtuais.Enabled = false;
                        txtUsuarioNovo.Focus();
                        num = 1;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum usuário encontrado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuarioAtual.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Falha ao verificar credênciais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioNovo.Text) || string.IsNullOrWhiteSpace(txtSenhaNova1.Text) || string.IsNullOrWhiteSpace(txtSenhaNova2.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuarioNovo.Focus();
            }
            else
            {
                if (txtSenhaNova1.Text != txtSenhaNova2.Text)
                {
                    MessageBox.Show("Senha incompatíveis, corrija por favor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuarioNovo.Focus();
                }
                else
                {
                    var senha = Cripitografia.encripto(txtSenhaNova2.Text);
                    try
                    {
                        if (num == 0)
                        {
                            var funcionario = (Funcionario)pessoaFisica;
                            funcionario.autenticacao.usuario = txtUsuarioNovo.Text;
                            funcionario.autenticacao.senha = senha;
                            var fDAO = new FuncionarioDAO();
                            fDAO.atualizar(funcionario);
                        }
                        else if (num == 1)
                        {
                            var terceirizado = (Terceirizado)pessoaFisica;
                            terceirizado.autenticacao.usuario = txtUsuarioNovo.Text;
                            terceirizado.autenticacao.senha = senha;
                            var tDAO = new TerceirizadoDAO();
                            tDAO.atualizar(terceirizado);
                        }
                        MessageBox.Show("Credenciais atualizadas com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        estadoInicial();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Falha ao atualizar credenciais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        estadoInicial();
                    }
                }
            }
        }

        private void estadoInicial()
        {
            txtUsuarioAtual.Text = null;
            txtSenhaAtual.Text = null;
            txtUsuarioNovo.Text = null;
            txtSenhaNova1.Text = null;
            txtSenhaNova2.Text = null;
            grpAtuais.Enabled = true;
            grpNovas.Enabled = false;
        }
    }
}
