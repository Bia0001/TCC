using System;
using System.Linq;
using Sistema.Ifsp.Model;
using Sistema.Ifsp.Dao;

namespace Sistema.Ifsp.Control
{
    public abstract class SolicitacaoControl
    {
        public abstract bool cadastrar(int idAluno, int idAssistenteAluno, string motivo, StatusSolicitacao status);
        public abstract bool alterar(int id, int idAluno, int idAssistenteAluno, DateTime abertura, string motivo, StatusSolicitacao status);
        public abstract Solicitacao buscar(int id);
        public abstract bool excluir(int id);
        public abstract IQueryable<Solicitacao> geraRelatorio(int mes, int ano, string periodo);
    }
}