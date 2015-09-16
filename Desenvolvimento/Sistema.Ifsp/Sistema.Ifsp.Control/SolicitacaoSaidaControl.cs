using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.Ifsp.Model;
using Sistema.Ifsp.Dao;

namespace Sistema.Ifsp.Control
{
    public class SolicitacaoSaidaControl : SolicitacaoControl
    {
        public override bool alterar(int id, int idAluno, int idAssistenteAluno, DateTime abertura, string motivo, StatusSolicitacao status)
        {
            throw new NotImplementedException();
        }

        public override Solicitacao buscar(int id)
        {
            throw new NotImplementedException();
        }

        public override bool cadastrar(int idAluno, int idAssistenteAluno, string motivo, StatusSolicitacao status)
        {
            try
            {
                var aDAO = new AlunoDAO();
                var a = aDAO.find(idAluno);
                var assistenteAlunoDAO = new AssistenteAlunoDAO();
                var assistente = assistenteAlunoDAO.find(idAssistenteAluno);
                var s = new Solicitacao();
                s.aberura = DateTime.Now;
                s.aluno = (Aluno)a;
                s.assistenteAluno = (AssistenteAluno)assistente;
                s.motivo = motivo;
                s.status = status;
                var sDAO = new SolicitacaoSaidaDAO();
                if (sDAO.adicionar(s))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Detalhes: "+ex);
            }
        }

        public override bool excluir(int id)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Solicitacao> geraRelatorio(int mes, int ano, string periodo)
        {
            throw new NotImplementedException();
        }
    }
}
