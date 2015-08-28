using Sistema.Ifsp.Model;
using Sistema.Ifsp.Repositorio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Sistema.Ifsp.DAO
{
    public class SolicitacaoSaidaDAO
    {
        private BancoContexto contexto;
        public SolicitacaoSaidaDAO()
        {
            contexto = RepositorioBanco.GetInstance();
        }
        public void Adicionar(SolicitacaoSaida solicitacao)
        {
            contexto.SolicitacoesSaida.Add(solicitacao);
            contexto.SaveChanges();
        }

        /*metodo para buscar todos alunos registrados*/
        public IQueryable<SolicitacaoSaida> Todos()
        {
            return contexto.SolicitacoesSaida;
        }
        public SolicitacaoSaida Pesquisar(int id)
        {
            return contexto.SolicitacoesSaida.Find(id);
        }
        public void Atualizar(SolicitacaoSaida solicitacao)
        {
            contexto.Entry(solicitacao).State = EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Delete(int id)
        {
            var solicitacao = contexto.SolicitacoesSaida.Where(s => s.idSolicitacaoSaida == id).First();
            contexto.Set<SolicitacaoSaida>().Remove(solicitacao);
            contexto.SaveChanges();
        }

        /*Pegando todas as solicitações geradas hoje e atualizando seus status caso expirado*/
        public IEnumerable<SolicitacaoSaida> PesquisarSolicitacoesHoje()
        {
            /*criando variável com data atual*/
            var dt = DateTime.Now;
            /*buscando solicitações cuja data seja de hoje*/
            var solicitacoes = contexto.SolicitacoesSaida.Where(s => s.abertura.Day == DateTime.Now.Day &&
            s.abertura.Month == dt.Month && s.abertura.Year == dt.Year).ToList();
            foreach (SolicitacaoSaida s in solicitacoes)
            {
                /*Verificando se previsão de encerramento foi atingida para determinar expiração*/
                if (s.status == "Aberto" && s.previsaoEncerramento < DateTime.Now)
                {
                    /*Se sim, atualiza status para "Expirado" e salva no banco de dados*/
                    s.status = "Expirado";
                    Atualizar(s);
                    contexto.SaveChanges();
                    /*Chamamos novamente o método para uma reverificação de status (Recursividade)*/
                    PesquisarSolicitacoesHoje();
                }
            }
            /*Retornando todas solicitaçãoes de hoje com status atualizado*/
            return solicitacoes;
        }
    }
}
